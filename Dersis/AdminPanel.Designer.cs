namespace Dersis
{
    partial class AdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdminPanelGeri = new Button();
            label1 = new Label();
            label2 = new Label();
            tbxKullaniciAdi = new TextBox();
            tbxSifre = new TextBox();
            btnGirisYap = new Button();
            SuspendLayout();
            // 
            // btnAdminPanelGeri
            // 
            btnAdminPanelGeri.BackColor = Color.IndianRed;
            btnAdminPanelGeri.FlatStyle = FlatStyle.Flat;
            btnAdminPanelGeri.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdminPanelGeri.ForeColor = Color.Transparent;
            btnAdminPanelGeri.Location = new Point(86, 423);
            btnAdminPanelGeri.Margin = new Padding(4, 5, 4, 5);
            btnAdminPanelGeri.Name = "btnAdminPanelGeri";
            btnAdminPanelGeri.Size = new Size(346, 38);
            btnAdminPanelGeri.TabIndex = 10;
            btnAdminPanelGeri.Text = "ANASAYFA";
            btnAdminPanelGeri.UseVisualStyleBackColor = false;
            btnAdminPanelGeri.Click += btnAdminPanelGeri_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(86, 146);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(160, 22);
            label1.TabIndex = 11;
            label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(166, 220);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 22);
            label2.TabIndex = 12;
            label2.Text = "Şifre :";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbxKullaniciAdi
            // 
            tbxKullaniciAdi.Location = new Point(281, 137);
            tbxKullaniciAdi.Margin = new Padding(4, 5, 4, 5);
            tbxKullaniciAdi.Name = "tbxKullaniciAdi";
            tbxKullaniciAdi.Size = new Size(151, 31);
            tbxKullaniciAdi.TabIndex = 13;
            // 
            // tbxSifre
            // 
            tbxSifre.Location = new Point(281, 214);
            tbxSifre.Margin = new Padding(4, 5, 4, 5);
            tbxSifre.Name = "tbxSifre";
            tbxSifre.Size = new Size(151, 31);
            tbxSifre.TabIndex = 14;
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.CornflowerBlue;
            btnGirisYap.FlatStyle = FlatStyle.Flat;
            btnGirisYap.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGirisYap.ForeColor = Color.Transparent;
            btnGirisYap.Location = new Point(204, 308);
            btnGirisYap.Margin = new Padding(4, 5, 4, 5);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(153, 51);
            btnGirisYap.TabIndex = 15;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(569, 573);
            Controls.Add(btnGirisYap);
            Controls.Add(tbxSifre);
            Controls.Add(tbxKullaniciAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdminPanelGeri);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AdminPanel";
            Text = "AdminPanel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdminPanelGeri;
        private Label label1;
        private Label label2;
        private TextBox tbxKullaniciAdi;
        private TextBox tbxSifre;
        private Button btnGirisYap;
    }
}