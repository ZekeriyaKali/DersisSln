using Npgsql;
using System.Data;

namespace Dersis
{
    public partial class OgrenciNotlari : Form
    {
        public OgrenciNotlari()
        {
            InitializeComponent();
            LoadComboBoxData();
        }
        string conn = "Host=localhost;Username=postgres;password=1234;database=dersis";
        private void btnOgrenciNotlariGeri_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void LoadComboBoxData()
        {
            // Öğretmenleri ComboBox'a yükle
            string ogrenciQuery = "SELECT derskodu,dersadi FROM dersler";
            FillComboBox(cbxDersSec, ogrenciQuery, "dersadi", "derskodu");

            // Dönemleri ComboBox'a yükle
            string donemQuery = "SELECT donemid, donemadi FROM donemler";
            FillComboBox(cbxDonemSec, donemQuery, "donemadi", "donemid");

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

        private void btnListele_Click(object sender, EventArgs e)
        {
            int dersId = Convert.ToInt32(cbxDersSec.SelectedValue);
            int donemId = Convert.ToInt32(cbxDonemSec.SelectedValue);

            // PostgreSQL veritabanından vize ve final notlarını getir
            using (NpgsqlConnection connection = new NpgsqlConnection(conn))
            {
                string query = "SELECT o.ogrencino, CONCAT(o.ogrenciad, ' ', o.ogrencisoyad) AS OgrenciAd," +
                    " dk.vizenot, dk.finalnot, d.gecmenotu FROM derskayitlari dk" +
                    " INNER JOIN dersler d ON dk.dersno = d.derskodu " +
                    "INNER JOIN ogrenciler o ON dk.ogrencino = o.ogrencino" +
                    " WHERE dk.dersno = @DersId AND dk.donemid = @DonemId";

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DersId", dersId);
                    command.Parameters.AddWithValue("@DonemId", donemId);

                    try
                    {
                        connection.Open();
                        NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgwDerseGoreListele.DataSource = dataTable;

                        double toplamNotlar = 0;
                        int notSayisi = 0;

                        foreach (DataRow row in dataTable.Rows)
                        {
                            double vizeNot = Convert.ToDouble(row["vizenot"]);
                            double finalNot = Convert.ToDouble(row["finalnot"]);

                            // Ders notlarının ortalamasını hesapla
                            double ortalama = (vizeNot + finalNot) / 2;
                            toplamNotlar += ortalama;
                            notSayisi++;
                        }

                        if (notSayisi > 0)
                        {
                            // Ortalama hesapla ve label'a yazdır
                            double ortalamaNot = toplamNotlar / notSayisi;
                            lblOrtalama.Text = ortalamaNot.ToString("0.00");
                        }
                        else
                        {
                            lblOrtalama.Text = "Seçilen ders ve döneme ait öğrenci bulunamadı.";
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
