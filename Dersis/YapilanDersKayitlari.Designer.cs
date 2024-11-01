namespace Dersis
{
    partial class YapilanDersKayitlari
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
            btnKayitSil = new Button();
            groupBox2 = new GroupBox();
            label7 = new Label();
            cbxKayitID = new ComboBox();
            btnKayitGuncelle = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cbxDonemAdGuncelle = new ComboBox();
            cbxDersAdiGuncelle = new ComboBox();
            cbxOgrenciNoGuncelle = new ComboBox();
            groupBox1 = new GroupBox();
            btnKayitEkle = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbxDonemAdEkle = new ComboBox();
            cbxDersAdiEkle = new ComboBox();
            cbxOgrenciNoEkle = new ComboBox();
            dgwKayitListele = new DataGridView();
            btnDersKayitlariGeri = new Button();
            label8 = new Label();
            cbxKayitIdSil = new ComboBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwKayitListele).BeginInit();
            SuspendLayout();
            // 
            // btnKayitSil
            // 
            btnKayitSil.BackColor = Color.Crimson;
            btnKayitSil.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnKayitSil.ForeColor = Color.White;
            btnKayitSil.Location = new Point(1001, 312);
            btnKayitSil.Margin = new Padding(4, 5, 4, 5);
            btnKayitSil.Name = "btnKayitSil";
            btnKayitSil.Size = new Size(267, 38);
            btnKayitSil.TabIndex = 14;
            btnKayitSil.Text = "Kayıt Sil";
            btnKayitSil.UseVisualStyleBackColor = false;
            btnKayitSil.Click += btnKayitSil_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cbxKayitID);
            groupBox2.Controls.Add(btnKayitGuncelle);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cbxDonemAdGuncelle);
            groupBox2.Controls.Add(cbxDersAdiGuncelle);
            groupBox2.Controls.Add(cbxOgrenciNoGuncelle);
            groupBox2.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(663, 452);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(456, 410);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ders Kaydı Güncelle";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(84, 51);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(110, 22);
            label7.TabIndex = 16;
            label7.Text = "Kayıt ID :";
            // 
            // cbxKayitID
            // 
            cbxKayitID.FormattingEnabled = true;
            cbxKayitID.Location = new Point(233, 48);
            cbxKayitID.Margin = new Padding(4, 5, 4, 5);
            cbxKayitID.Name = "cbxKayitID";
            cbxKayitID.Size = new Size(171, 30);
            cbxKayitID.TabIndex = 15;
            // 
            // btnKayitGuncelle
            // 
            btnKayitGuncelle.ForeColor = Color.MediumTurquoise;
            btnKayitGuncelle.Location = new Point(243, 329);
            btnKayitGuncelle.Margin = new Padding(4, 5, 4, 5);
            btnKayitGuncelle.Name = "btnKayitGuncelle";
            btnKayitGuncelle.Size = new Size(161, 38);
            btnKayitGuncelle.TabIndex = 7;
            btnKayitGuncelle.Text = "Kayıt Güncelle";
            btnKayitGuncelle.UseVisualStyleBackColor = true;
            btnKayitGuncelle.Click += btnKayitGuncelle_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 260);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(110, 22);
            label4.TabIndex = 6;
            label4.Text = "Dönem Ad :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(84, 190);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(110, 22);
            label5.TabIndex = 5;
            label5.Text = "Ders Adı :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(64, 123);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(130, 22);
            label6.TabIndex = 4;
            label6.Text = "Öğrenci No :";
            // 
            // cbxDonemAdGuncelle
            // 
            cbxDonemAdGuncelle.FormattingEnabled = true;
            cbxDonemAdGuncelle.Location = new Point(233, 257);
            cbxDonemAdGuncelle.Margin = new Padding(4, 5, 4, 5);
            cbxDonemAdGuncelle.Name = "cbxDonemAdGuncelle";
            cbxDonemAdGuncelle.Size = new Size(171, 30);
            cbxDonemAdGuncelle.TabIndex = 2;
            // 
            // cbxDersAdiGuncelle
            // 
            cbxDersAdiGuncelle.FormattingEnabled = true;
            cbxDersAdiGuncelle.Location = new Point(233, 187);
            cbxDersAdiGuncelle.Margin = new Padding(4, 5, 4, 5);
            cbxDersAdiGuncelle.Name = "cbxDersAdiGuncelle";
            cbxDersAdiGuncelle.Size = new Size(171, 30);
            cbxDersAdiGuncelle.TabIndex = 1;
            // 
            // cbxOgrenciNoGuncelle
            // 
            cbxOgrenciNoGuncelle.FormattingEnabled = true;
            cbxOgrenciNoGuncelle.Location = new Point(233, 120);
            cbxOgrenciNoGuncelle.Margin = new Padding(4, 5, 4, 5);
            cbxOgrenciNoGuncelle.Name = "cbxOgrenciNoGuncelle";
            cbxOgrenciNoGuncelle.Size = new Size(171, 30);
            cbxOgrenciNoGuncelle.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnKayitEkle);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbxDonemAdEkle);
            groupBox1.Controls.Add(cbxDersAdiEkle);
            groupBox1.Controls.Add(cbxOgrenciNoEkle);
            groupBox1.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(84, 452);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(456, 410);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ders Kaydı Yaptır";
            // 
            // btnKayitEkle
            // 
            btnKayitEkle.ForeColor = Color.MediumTurquoise;
            btnKayitEkle.Location = new Point(233, 329);
            btnKayitEkle.Margin = new Padding(4, 5, 4, 5);
            btnKayitEkle.Name = "btnKayitEkle";
            btnKayitEkle.Size = new Size(161, 38);
            btnKayitEkle.TabIndex = 7;
            btnKayitEkle.Text = "Kayıt Ekle";
            btnKayitEkle.UseVisualStyleBackColor = true;
            btnKayitEkle.Click += btnKayitEkle_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 233);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(110, 22);
            label3.TabIndex = 6;
            label3.Text = "Dönem Ad :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 168);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 22);
            label2.TabIndex = 5;
            label2.Text = "Ders Adı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 98);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(130, 22);
            label1.TabIndex = 4;
            label1.Text = "Öğrenci No :";
            // 
            // cbxDonemAdEkle
            // 
            cbxDonemAdEkle.FormattingEnabled = true;
            cbxDonemAdEkle.Location = new Point(233, 230);
            cbxDonemAdEkle.Margin = new Padding(4, 5, 4, 5);
            cbxDonemAdEkle.Name = "cbxDonemAdEkle";
            cbxDonemAdEkle.Size = new Size(171, 30);
            cbxDonemAdEkle.TabIndex = 2;
            // 
            // cbxDersAdiEkle
            // 
            cbxDersAdiEkle.FormattingEnabled = true;
            cbxDersAdiEkle.Location = new Point(233, 160);
            cbxDersAdiEkle.Margin = new Padding(4, 5, 4, 5);
            cbxDersAdiEkle.Name = "cbxDersAdiEkle";
            cbxDersAdiEkle.Size = new Size(171, 30);
            cbxDersAdiEkle.TabIndex = 1;
            // 
            // cbxOgrenciNoEkle
            // 
            cbxOgrenciNoEkle.FormattingEnabled = true;
            cbxOgrenciNoEkle.Location = new Point(233, 93);
            cbxOgrenciNoEkle.Margin = new Padding(4, 5, 4, 5);
            cbxOgrenciNoEkle.Name = "cbxOgrenciNoEkle";
            cbxOgrenciNoEkle.Size = new Size(171, 30);
            cbxOgrenciNoEkle.TabIndex = 0;
            // 
            // dgwKayitListele
            // 
            dgwKayitListele.BackgroundColor = Color.White;
            dgwKayitListele.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwKayitListele.Location = new Point(84, 60);
            dgwKayitListele.Margin = new Padding(4, 5, 4, 5);
            dgwKayitListele.Name = "dgwKayitListele";
            dgwKayitListele.RowHeadersWidth = 62;
            dgwKayitListele.RowTemplate.Height = 25;
            dgwKayitListele.Size = new Size(867, 290);
            dgwKayitListele.TabIndex = 16;
            // 
            // btnDersKayitlariGeri
            // 
            btnDersKayitlariGeri.BackColor = Color.IndianRed;
            btnDersKayitlariGeri.FlatStyle = FlatStyle.Flat;
            btnDersKayitlariGeri.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDersKayitlariGeri.ForeColor = Color.Transparent;
            btnDersKayitlariGeri.Location = new Point(1088, 60);
            btnDersKayitlariGeri.Margin = new Padding(4, 5, 4, 5);
            btnDersKayitlariGeri.Name = "btnDersKayitlariGeri";
            btnDersKayitlariGeri.Size = new Size(180, 38);
            btnDersKayitlariGeri.TabIndex = 15;
            btnDersKayitlariGeri.Text = "Anasayfa";
            btnDersKayitlariGeri.UseVisualStyleBackColor = false;
            btnDersKayitlariGeri.Click += btnDersKayitlariGeri_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(978, 248);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(110, 22);
            label8.TabIndex = 20;
            label8.Text = "Kayıt ID :";
            // 
            // cbxKayitIdSil
            // 
            cbxKayitIdSil.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbxKayitIdSil.FormattingEnabled = true;
            cbxKayitIdSil.Location = new Point(1096, 245);
            cbxKayitIdSil.Margin = new Padding(4, 5, 4, 5);
            cbxKayitIdSil.Name = "cbxKayitIdSil";
            cbxKayitIdSil.Size = new Size(171, 30);
            cbxKayitIdSil.TabIndex = 19;
            // 
            // YapilanDersKayitlari
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(1311, 928);
            Controls.Add(label8);
            Controls.Add(cbxKayitIdSil);
            Controls.Add(btnKayitSil);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgwKayitListele);
            Controls.Add(btnDersKayitlariGeri);
            Margin = new Padding(4, 5, 4, 5);
            Name = "YapilanDersKayitlari";
            Text = "YapilanDersKayitlari";
            Load += YapilanDersKayitlari_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwKayitListele).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKayitSil;
        private GroupBox groupBox2;
        private Button btnKayitGuncelle;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cbxDonemAdGuncelle;
        private ComboBox cbxDersAdiGuncelle;
        private ComboBox cbxOgrenciNoGuncelle;
        private GroupBox groupBox1;
        private Button btnKayitEkle;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbxDonemAdEkle;
        private ComboBox cbxDersAdiEkle;
        private ComboBox cbxOgrenciNoEkle;
        private DataGridView dgwKayitListele;
        private Button btnDersKayitlariGeri;
        private Label label7;
        private ComboBox cbxKayitID;
        private Label label8;
        private ComboBox cbxKayitIdSil;
    }
}