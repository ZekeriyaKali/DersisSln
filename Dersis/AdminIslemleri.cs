using Npgsql;
using System.Data;

namespace Dersis
{
    public partial class AdminIslemleri : Form
    {
        public AdminIslemleri()
        {
            InitializeComponent();
            LoadComboBoxData();
        }
        string conn = "Host=localhost;Username=postgres;password=1234;database=dersis";  //Postgresql bağlantısı
        private void btnAdminIslemleriGeri_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();  //Anasayfaya geri dönüş
            anasayfa.Show();
            this.Hide();
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            int ogrenciNo = Convert.ToInt32(tbxOgrenciNo.Text);   //textboxlardaki değeri değişkenlere atama
            string ogrenciAd = tbxOgrenciAd.Text;
            string ogrenciSoyad = tbxOgrenciSoyad.Text;

            using (NpgsqlConnection connection = new NpgsqlConnection(conn))
            {
                // Veritabanı komutunu oluştur
                string query = "INSERT INTO ogrenciler (ogrencino, ogrenciad, ogrencisoyad) VALUES (@OgrenciNo, @OgrenciAd, @OgrenciSoyad)"; //Ogrenciler tablosuna ekleme yapma
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@OgrenciNo", ogrenciNo);
                    command.Parameters.AddWithValue("@OgrenciAd", ogrenciAd);
                    command.Parameters.AddWithValue("@OgrenciSoyad", ogrenciSoyad);

                    try
                    {
                        // Veritabanına bağlan
                        connection.Open();

                        // Komutu çalıştır
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)   //Komut çalıştıysa
                        {
                            MessageBox.Show("Öğrenci başarıyla eklendi!");
                            // TextBox'ları temizle
                            Temizle();
                        }
                        else
                        {
                            MessageBox.Show("Öğrenci eklenirken bir hata oluştu!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void LoadComboBoxData()
        {
            // Öğretmenleri ComboBox'a yükle
            string ogretmenQuery = "SELECT ogretmenid, CONCAT(ogretmenad, ' ', ogretmensoyad) AS ogretmen FROM ogretimuyeleri";
            FillComboBox(cbxOgretmenId, ogretmenQuery, "ogretmen", "ogretmenid");

            // Dönemleri ComboBox'a yükle
            string donemQuery = "SELECT donemid, donemadi FROM donemler";
            FillComboBox(cbxDonemId, donemQuery, "donemadi", "donemid");
            FillComboBox(cbxDonemAdGecme, donemQuery, "donemadi", "donemid");

            //Ders kayıtlarını Combobox'a yükle
            string kayitQuery = "SELECT kayitid FROM derskayitlari";
            FillComboBox(cbxKayitID, kayitQuery, "kayitid", "kayitid");

            //Dersleri Combobox'a yükle
            string dersQuery = "SELECT derskodu, dersadi FROM dersler";
            FillComboBox(cbxDersAdiGecme, dersQuery, "dersadi", "derskodu");
        }

        private void FillComboBox(ComboBox comboBox, string query, string displayMember, string valueMember)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(conn))
            {
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                comboBox.DataSource = dataTable;  
                comboBox.DisplayMember = displayMember;  //Combobox ta görünen değer
                comboBox.ValueMember = valueMember;  //Combobox tan alınan değer
            }
        }

        private void Temizle()    //textbox ve comboboxları temizleme
        {
            tbxOgrenciNo.Text = "";
            tbxOgrenciAd.Text = "";
            tbxOgrenciSoyad.Text = "";
            tbxOgretmenId.Text = "";
            tbxOgretmenAd.Text = "";
            tbxOgretmenSoyad.Text = "";
            tbxDonemID.Text = "";
            tbxDonemAd.Text = "";
            tbxDersAd.Text = "";
            tbxDersKodu.Text = "";
            cbxDonemId.SelectedIndex = -1;
            cbxOgretmenId.SelectedIndex = -1;
            cbxKayitID.SelectedIndex = -1;
            tbxVizeNot.Text = "";
            tbxFinalNot.Text = "";
            cbxDersAdiGecme.SelectedIndex = -1;
            tbxGecmeNotu.Text = "";
            cbxDonemAdGecme.Text = "";
            tbxGecmeNotuGun.Text = "";
        }

        private void btnOgretmenEkle_Click(object sender, EventArgs e)
        {
            int ogretmenNo = Convert.ToInt32(tbxOgretmenId.Text); 
            string ogretmenAd = tbxOgretmenAd.Text;
            string ogretmenSoyad = tbxOgretmenSoyad.Text;

            using (NpgsqlConnection connection = new NpgsqlConnection(conn))
            {
                // Veritabanı komutunu oluştur
                string query = "INSERT INTO ogretimuyeleri (ogretmenid, ogretmenad, ogretmensoyad) VALUES (@OgretmenNo, @OgretmenAd, @OgretmenSoyad)";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@OgretmenNo", ogretmenNo);
                    command.Parameters.AddWithValue("@OgretmenAd", ogretmenAd);
                    command.Parameters.AddWithValue("@OgretmenSoyad", ogretmenSoyad);

                    try
                    {
                        // Veritabanına bağlan
                        connection.Open();

                        // Komutu çalıştır
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Öğretim üyesi başarıyla eklendi!");
                            // TextBox'ları temizle
                            Temizle();
                        }
                        else
                        {
                            MessageBox.Show("Öğretim üyesi eklenirken bir hata oluştu!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void btnDonemEkle_Click(object sender, EventArgs e)
        {
            int donemNo = Convert.ToInt32(tbxDonemID.Text);
            string donemAd = tbxDonemAd.Text;

            using (NpgsqlConnection connection = new NpgsqlConnection(conn))
            {
                // Veritabanı komutunu oluştur
                string query = "INSERT INTO donemler (donemid, donemad) VALUES (@DonemId, @DonemAd)";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@DonemId", donemNo);
                    command.Parameters.AddWithValue("@DonemAd", donemAd);

                    try
                    {
                        // Veritabanına bağlan
                        connection.Open();

                        // Komutu çalıştır
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Dönem başarıyla eklendi!");
                            // TextBox'ları temizle
                            Temizle();
                        }
                        else
                        {
                            MessageBox.Show("Dönem eklenirken bir hata oluştu!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void AdminIslemleri_Load(object sender, EventArgs e)
        {
            KayitListele();
        }

        private void KayitListele()
        {
            //İlişkili tablolardan değer almak için inner join kullandık.
            string query = "SELECT dk.kayitid, d.DersAdi, CONCAT(o.ogrenciad, ' ', o.ogrencisoyad) AS OgrenciAd, dn.DonemAdi, dk.vizenot, dk.finalnot, d.gecmenotu " +
                "FROM Derskayitlari dk " +
                "INNER JOIN ogrenciler o ON dk.ogrencino = o.ogrencino " +
                "INNER JOIN dersler d ON dk.dersno = d.derskodu " +
                "INNER JOIN Donemler dn ON d.DonemID = dn.DonemID";

            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dgwAdminKayit.DataSource = dt;  //datagridview a listeleme
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            int dersKodu = Convert.ToInt32(tbxDersKodu.Text);
            string dersAdi = tbxDersAd.Text;
            int ogretmenId = Convert.ToInt32(cbxOgretmenId.SelectedValue);
            int donemId = Convert.ToInt32(cbxDonemId.SelectedValue);
            int gecmeNotu = Convert.ToInt32(tbxGecmeNotu.Text);

            // PostgreSQL veritabanına bağlan
            using (NpgsqlConnection connection = new NpgsqlConnection(conn))
            {
                // Veritabanı komutunu oluştur
                string query = "INSERT INTO dersler (derskodu, dersadi, ogretmenid, donemid, gecmenotu) VALUES (@DersKodu, @DersAdi, @OgretmenId, @DonemId, @GecmeNotu)";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@DersKodu", dersKodu);
                    command.Parameters.AddWithValue("@DersAdi", dersAdi);
                    command.Parameters.AddWithValue("@OgretmenId", ogretmenId);
                    command.Parameters.AddWithValue("@DonemId", donemId);
                    command.Parameters.AddWithValue("@GecmeNotu", gecmeNotu);

                    try
                    {
                        // Veritabanına bağlan
                        connection.Open();

                        // Komutu çalıştır
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Ders başarıyla eklendi!");
                            // TextBox'ları temizle
                            Temizle();
                        }
                        else
                        {
                            MessageBox.Show("Ders eklenirken bir hata oluştu!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void btnNotEkle_Click(object sender, EventArgs e)
        {
            int kayitId = Convert.ToInt32(cbxKayitID.SelectedValue);
            float? vizeNot = string.IsNullOrEmpty(tbxVizeNot.Text) ? (float?)null : Convert.ToSingle(tbxVizeNot.Text); //vizenot veya finalnot boş olarak gelebileceği için null olma kontrolü yaptık.
            float? finalNot = string.IsNullOrEmpty(tbxFinalNot.Text) ? (float?)null : Convert.ToSingle(tbxFinalNot.Text);

            using (NpgsqlConnection connection = new NpgsqlConnection(conn))
            {
                // Veritabanı komutunu oluştur
                string query = "UPDATE derskayitlari SET vizenot = @VizeNot, finalnot = @FinalNot WHERE kayitid = @KayitId";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@VizeNot", vizeNot);
                    command.Parameters.AddWithValue("@FinalNot", finalNot);
                    command.Parameters.AddWithValue("@KayitId", kayitId);

                    try
                    {
                        // Veritabanına bağlan
                        connection.Open();

                        // Komutu çalıştır
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Notlar başarıyla güncellendi!");
                            // TextBox'ları temizle
                            Temizle();
                            KayitListele();
                        }
                        else
                        {
                            MessageBox.Show("Notlar güncellenirken bir hatayla karşılaşıldı!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void btnGecmeNotu_Click(object sender, EventArgs e)
        {

            int dersId = Convert.ToInt32(cbxDersAdiGecme.SelectedValue);
            int donemId = Convert.ToInt32(cbxDonemAdGecme.SelectedValue);
            int? gecmeNotu = string.IsNullOrEmpty(tbxGecmeNotuGun.Text) ? (int?)null : Convert.ToInt32(tbxGecmeNotuGun.Text);

            using (NpgsqlConnection connection = new NpgsqlConnection(conn))
            {
                // Veritabanı komutunu oluştur
                string query = "UPDATE dersler SET donemid=@DonemId, gecmenotu = @GecmeNotu WHERE derskodu = @DersId"; //gecme notu başta boş değer olabileceği için ekleme ve güncelleme işlemi aynı 
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))       //bu yüzden update komutu kullandık                 
                {
                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@DonemId", donemId);
                    command.Parameters.AddWithValue("@GecmeNotu", gecmeNotu);
                    command.Parameters.AddWithValue("@DersId", dersId);

                    try
                    {
                        // Veritabanına bağlan
                        connection.Open();

                        // Komutu çalıştır
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Geçme Notu başarıyla güncellendi!");
                            // TextBox'ları temizle
                            Temizle();
                            KayitListele();
                        }
                        else
                        {
                            MessageBox.Show("Geçme Notu güncellenirken bir hatayla karşılaşıldı!");
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