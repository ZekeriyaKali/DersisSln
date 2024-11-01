using Npgsql;
using System.Data;

namespace Dersis
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void btnOgrenciListesi_Click(object sender, EventArgs e)
        {
            OgrenciListesi ogrenciListesi = new OgrenciListesi();
            ogrenciListesi.Show();
            this.Hide();
        }

        private void btnAcilanDersler_Click(object sender, EventArgs e)
        {
            AcilanDersler acilanDersler = new AcilanDersler();
            acilanDersler.Show();
            this.Hide();
        }

        private void btnDersKayitlari_Click(object sender, EventArgs e)
        {
            YapilanDersKayitlari yapilanDersKayitlari = new YapilanDersKayitlari();
            yapilanDersKayitlari.Show();
            this.Hide();
        }

        private void btnOgretmenListesi_Click(object sender, EventArgs e)
        {
            OgretmenListesi ogretmenListesi = new OgretmenListesi();
            ogretmenListesi.Show();
            this.Hide();
        }

        private void btnOgrenciNotlari_Click(object sender, EventArgs e)
        {
            OgrenciNotlari ogrenciNotlari = new OgrenciNotlari();
            ogrenciNotlari.Show();
            this.Hide();
        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Hide();
        }
    }
}