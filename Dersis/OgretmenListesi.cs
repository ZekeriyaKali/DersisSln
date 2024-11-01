using Npgsql;
using System.Data;

namespace Dersis
{
    public partial class OgretmenListesi : Form
    {
        public OgretmenListesi()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;password=1234;database=dersis");
        private void btnOgretmenListesiGeri_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void OgretmenListesi_Load(object sender, EventArgs e)
        {
            string query = "SELECT d.DersKodu, d.DersAdi, CONCAT(o.ogretmenad, ' ', o.ogretmensoyad) AS OgretmenAd, dn.DonemAdi " +
                "FROM Dersler d " +
                "INNER JOIN OgretimUyeleri o ON d.OgretmenId = o.OgretmenId " +
                "INNER JOIN Donemler dn ON d.DonemID = dn.DonemID";

            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dgwOgretmenListele.DataSource = dt;
        }
    }
}
