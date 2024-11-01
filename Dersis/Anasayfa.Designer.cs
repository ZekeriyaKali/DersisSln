namespace Dersis
{
    partial class Anasayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnAcilanDersler = new Button();
            btnOgrenciListesi = new Button();
            btnDersKayitlari = new Button();
            btnOgretmenListesi = new Button();
            btnOgrenciNotlari = new Button();
            btnAdminPanel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(91, 157);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(809, 37);
            label1.TabIndex = 2;
            label1.Text = "Ders Yönetim Sistemine (DERSİS) Hoşgeldiniz!";
            // 
            // btnAcilanDersler
            // 
            btnAcilanDersler.BackColor = Color.RoyalBlue;
            btnAcilanDersler.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAcilanDersler.Location = new Point(143, 252);
            btnAcilanDersler.Margin = new Padding(4, 5, 4, 5);
            btnAcilanDersler.Name = "btnAcilanDersler";
            btnAcilanDersler.Size = new Size(267, 85);
            btnAcilanDersler.TabIndex = 3;
            btnAcilanDersler.Text = "Açılan Dersler";
            btnAcilanDersler.UseVisualStyleBackColor = false;
            btnAcilanDersler.Click += btnAcilanDersler_Click;
            // 
            // btnOgrenciListesi
            // 
            btnOgrenciListesi.BackColor = Color.LightCoral;
            btnOgrenciListesi.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOgrenciListesi.Location = new Point(539, 252);
            btnOgrenciListesi.Margin = new Padding(4, 5, 4, 5);
            btnOgrenciListesi.Name = "btnOgrenciListesi";
            btnOgrenciListesi.Size = new Size(267, 85);
            btnOgrenciListesi.TabIndex = 4;
            btnOgrenciListesi.Text = "Öğrenci Listesi";
            btnOgrenciListesi.UseVisualStyleBackColor = false;
            btnOgrenciListesi.Click += btnOgrenciListesi_Click;
            // 
            // btnDersKayitlari
            // 
            btnDersKayitlari.BackColor = Color.MediumAquamarine;
            btnDersKayitlari.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDersKayitlari.Location = new Point(143, 398);
            btnDersKayitlari.Margin = new Padding(4, 5, 4, 5);
            btnDersKayitlari.Name = "btnDersKayitlari";
            btnDersKayitlari.Size = new Size(267, 85);
            btnDersKayitlari.TabIndex = 5;
            btnDersKayitlari.Text = "Yapılan Ders Kayıtları";
            btnDersKayitlari.UseVisualStyleBackColor = false;
            btnDersKayitlari.Click += btnDersKayitlari_Click;
            // 
            // btnOgretmenListesi
            // 
            btnOgretmenListesi.BackColor = Color.SandyBrown;
            btnOgretmenListesi.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOgretmenListesi.ForeColor = SystemColors.ControlText;
            btnOgretmenListesi.Location = new Point(539, 398);
            btnOgretmenListesi.Margin = new Padding(4, 5, 4, 5);
            btnOgretmenListesi.Name = "btnOgretmenListesi";
            btnOgretmenListesi.Size = new Size(267, 85);
            btnOgretmenListesi.TabIndex = 6;
            btnOgretmenListesi.Text = "Öğretmen Listesi";
            btnOgretmenListesi.UseVisualStyleBackColor = false;
            btnOgretmenListesi.Click += btnOgretmenListesi_Click;
            // 
            // btnOgrenciNotlari
            // 
            btnOgrenciNotlari.BackColor = Color.PaleGoldenrod;
            btnOgrenciNotlari.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOgrenciNotlari.Location = new Point(362, 531);
            btnOgrenciNotlari.Margin = new Padding(4, 5, 4, 5);
            btnOgrenciNotlari.Name = "btnOgrenciNotlari";
            btnOgrenciNotlari.Size = new Size(267, 85);
            btnOgrenciNotlari.TabIndex = 7;
            btnOgrenciNotlari.Text = "Öğrenci Notları";
            btnOgrenciNotlari.UseVisualStyleBackColor = false;
            btnOgrenciNotlari.Click += btnOgrenciNotlari_Click;
            // 
            // btnAdminPanel
            // 
            btnAdminPanel.BackColor = Color.LightSeaGreen;
            btnAdminPanel.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdminPanel.Location = new Point(798, 31);
            btnAdminPanel.Margin = new Padding(4, 5, 4, 5);
            btnAdminPanel.Name = "btnAdminPanel";
            btnAdminPanel.Size = new Size(186, 83);
            btnAdminPanel.TabIndex = 8;
            btnAdminPanel.Text = "Admin Paneli";
            btnAdminPanel.UseVisualStyleBackColor = false;
            btnAdminPanel.Click += btnAdminPanel_Click;
            // 
            // Anasayfa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1010, 710);
            Controls.Add(btnAdminPanel);
            Controls.Add(btnOgrenciNotlari);
            Controls.Add(btnOgretmenListesi);
            Controls.Add(btnDersKayitlari);
            Controls.Add(btnOgrenciListesi);
            Controls.Add(btnAcilanDersler);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Anasayfa";
            Text = "DERSİS Yönetim Sistemi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnAcilanDersler;
        private Button btnOgrenciListesi;
        private Button btnDersKayitlari;
        private Button btnOgretmenListesi;
        private Button btnOgrenciNotlari;
        private Button btnAdminPanel;
    }
}