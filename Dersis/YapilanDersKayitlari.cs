using Npgsql;
using System.Data;

namespace Dersis
{
    public partial class YapilanDersKayitlari : Form
    {
        public YapilanDersKayitlari()
        {
            InitializeComponent();
            LoadComboBoxData();
        }

        string conn = "Host=localhost;Username=postgres;password=1234;database=dersis"; //postgresql bağlantısı

        private void LoadComboBoxData()   //comboboxlara veri yükleme
        {
            // Öğrencileri ComboBox'a yükle
            string ogrenciQuery = "SELECT ogrencino FROM ogrenciler";
            FillComboBox(cbxOgrenciNoEkle, ogrenciQuery, "ogrencino", "ogrencino");
            FillComboBox(cbxOgrenciNoGuncelle, ogrenciQuery, "ogrencino", "ogrencino");

            // Dönemleri ComboBox'a yükle
            string donemQuery = "SELECT donemid, donemadi FROM donemler";
            FillComboBox(cbxDonemAdEkle, donemQuery, "donemadi", "donemid");
            FillComboBox(cbxDonemAdGuncelle, donemQuery, "donemadi", "donemid");

            // Dersleri ComboBox'a yükle
            string dersQuery = "SELECT derskodu, dersadi FROM dersler";
            FillComboBox(cbxDersAdiEkle, dersQuery, "dersadi", "derskodu");
            FillComboBox(cbxDersAdiGuncelle, dersQuery, "dersadi", "derskodu");

            // Kayıtları ComboBox'a yükle
            string kayitQuery = "SELECT kayitid FROM derskayitlari";
            FillComboBox(cbxKayitID, kayitQuery, "kayitid", "kayitid");
            FillComboBox(cbxKayitIdSil, kayitQuery, "kayitid", "kayitid");
        }

        private void FillComboBox(ComboBox comboBox, string query, string displayMember, string valueMember)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(conn))
            {
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                comboBox.DataSource = dataTable;
                comboBox.DisplayMember = displayMember;
                comboBox.ValueMember = valueMember;
            }
        }
        private void btnDersKayitlariGeri_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void KayitListele()
        {
            //İlişkili tablolardan veri almak için kullandık
            string query = "SELECT dk.kayitid, dk.dersno, d.DersAdi, o.ogrencino, CONCAT(o.ogrenciad, ' ', o.ogrencisoyad) AS OgrenciAd, dn.DonemAdi FROM derskayitlari dk " +
                "INNER JOIN ogrenciler o ON dk.ogrencino = o.ogrencino " +
                "INNER JOIN dersler d ON dk.dersno = d.derskodu " +
                "INNER JOIN Donemler dn ON d.DonemID = dn.DonemID";

            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dgwKayitListele.DataSource = dt;
        }

        private void YapilanDersKayitlari_Load(object sender, EventArgs e)
        {
            KayitListele();
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            int ogrenciNo = Convert.ToInt32(cbxOgrenciNoEkle.SelectedValue);
            int donemId = Convert.ToInt32(cbxDonemAdEkle.SelectedValue);
            int dersNo = Convert.ToInt32(cbxDersAdiEkle.SelectedValue);

            using (NpgsqlConnection connection = new NpgsqlConnection(conn))
            {
                connection.Open();
                //Öğrencinin döneme göre aldığı ders sayısını kontrol et
                string countQuery = "SELECT COUNT(*) FROM derskayitlari WHERE ogrencino = @OgrenciNo AND donemid = @DonemId";
                int ogrenciDersSayisi = 0;
                using (NpgsqlCommand countCommand = new NpgsqlCommand(countQuery, connection))
                {
                    countCommand.Parameters.AddWithValue("@OgrenciNo", ogrenciNo);
                    countCommand.Parameters.AddWithValue("@DonemId", donemId);
                    ogrenciDersSayisi = Convert.ToInt32(countCommand.ExecuteScalar());
                }

                // Aynı dersi birden fazla kez aldığını kontrol et
                string duplicateQuery = "SELECT COUNT(*) FROM derskayitlari WHERE ogrencino = @OgrenciNo AND donemid = @DonemId AND dersno = @DersNo";
                int duplicateCount = 0;
                using (NpgsqlCommand duplicateCommand = new NpgsqlCommand(duplicateQuery, connection))
                {
                    duplicateCommand.Parameters.AddWithValue("@OgrenciNo", ogrenciNo);
                    duplicateCommand.Parameters.AddWithValue("@DonemId", donemId);
                    duplicateCommand.Parameters.AddWithValue("@DersNo", dersNo);
                    duplicateCount = Convert.ToInt32(duplicateCommand.ExecuteScalar());
                }
                if (ogrenciDersSayisi < 10 && duplicateCount == 0) //alınan ders sayısı ondan az ve aynı dersi almadıysa 
                {
                    // Veritabanı komutunu oluştur
                    string query = "INSERT INTO derskayitlari (ogrencino, dersno, donemid) VALUES (@OgrenciNo, @DersNo, @DonemId)";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        // Parametreleri ekle
                        command.Parameters.AddWithValue("@OgrenciNo", ogrenciNo);
                        command.Parameters.AddWithValue("@DersNo", dersNo);
                        command.Parameters.AddWithValue("@DonemId", donemId);

                        try
                        {
                            connection.Close();
                            // Veritabanına bağlan
                            connection.Open();

                            // Komutu çalıştır
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Kayıt başarıyla eklendi!");
                                // TextBox'ları temizle
                                Temizle();
                                KayitListele();
                                LoadComboBoxData();
                            }
                            else
                            {
                                MessageBox.Show("Kayıt eklenirken bir hata oluştu!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Öğrencinin belli bir dönemde 10 taneden fazla dersi olamaz veya aynı dersi birden fazla alamaz!");
                }
            }

        }

        private void Temizle() //Comboboxları temizle
        {
            cbxDersAdiEkle.SelectedIndex = -1;
            cbxDonemAdEkle.SelectedIndex = -1;
            cbxOgrenciNoEkle.SelectedIndex = -1;
            cbxKayitID.SelectedIndex = -1;
            cbxOgrenciNoGuncelle.SelectedIndex = -1;
            cbxDersAdiGuncelle.SelectedIndex = -1;
            cbxDonemAdGuncelle.SelectedIndex = -1;
            cbxKayitIdSil.SelectedIndex = -1;
        }

        private void btnKayitGuncelle_Click(object sender, EventArgs e)
        {
            int kayitId = Convert.ToInt32(cbxKayitID.SelectedValue);
            int ogrenciNo = Convert.ToInt32(cbxOgrenciNoGuncelle.SelectedValue);
            int dersNo = Convert.ToInt32(cbxDersAdiGuncelle.SelectedValue);
            int donemId = Convert.ToInt32(cbxDonemAdGuncelle.SelectedValue);

            using (NpgsqlConnection connection = new NpgsqlConnection(conn))
            {
                // Veritabanı komutunu oluştur
                string query = "UPDATE derskayitlari SET ogrencino = @OgrenciNo, dersno=@DersNo, donemid=@DonemId WHERE kayitid = @KayitId";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@OgrenciNo", ogrenciNo);
                    command.Parameters.AddWithValue("@DersNo", dersNo);
                    command.Parameters.AddWithValue("@DonemId", donemId);
                    command.Parameters.AddWithValue("@KayitId", kayitId);

                    try
                    {
                        // Veritabanına bağlan
                        connection.Open();

                        // Komutu çalıştır
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Kayıt başarıyla güncellendi!");
                            // TextBox'ları temizle
                            Temizle();
                            KayitListele();
                            LoadComboBoxData();
                        }
                        else
                        {
                            MessageBox.Show("Kayıt güncellenirken bir hatayla karşılaşıldı!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }

        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            int secilenId = Convert.ToInt32(cbxKayitIdSil.SelectedValue);

            // PostgreSQL veritabanına bağlan
            using (NpgsqlConnection connection = new NpgsqlConnection(conn))
            {
                // Veritabanı komutunu oluştur
                string query = "DELETE FROM derskayitlari WHERE kayitid = @Id"; // kayit id ye göre veri sil
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    // Parametreyi ekle
                    command.Parameters.AddWithValue("@Id", secilenId);

                    try
                    {
                        // Veritabanına bağlan
                        connection.Open();

                        // Komutu çalıştır
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Kayıt başarıyla silindi!");
                            // ComboBox'a yeniden veri yükle
                            Temizle();
                            KayitListele();
                            LoadComboBoxData();
                        }
                        else
                        {
                            MessageBox.Show("Silme işlemi başarısız oldu!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }
    }
}
