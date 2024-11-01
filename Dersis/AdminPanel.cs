
namespace Dersis
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void btnAdminPanelGeri_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (tbxKullaniciAdi.Text == "admin" && tbxSifre.Text == "123")
            {
                MessageBox.Show("Giriş Başarılı!");
                AdminIslemleri adminIslemleri = new AdminIslemleri();
                adminIslemleri.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış!");
            }
        }
    }
}
