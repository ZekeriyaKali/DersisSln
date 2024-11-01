namespace Dersis
{
    partial class AdminIslemleri
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
            btnAdminIslemleriGeri = new Button();
            groupBox1 = new GroupBox();
            btnOgrenciEkle = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbxOgrenciSoyad = new TextBox();
            tbxOgrenciAd = new TextBox();
            tbxOgrenciNo = new TextBox();
            groupBox2 = new GroupBox();
            btnOgretmenEkle = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbxOgretmenSoyad = new TextBox();
            tbxOgretmenAd = new TextBox();
            tbxOgretmenId = new TextBox();
            groupBox3 = new GroupBox();
            cbxDonemId = new ComboBox();
            cbxOgretmenId = new ComboBox();
            label18 = new Label();
            btnDersEkle = new Button();
            label7 = new Label();
            label16 = new Label();
            tbxGecmeNotu = new TextBox();
            label8 = new Label();
            label9 = new Label();
            tbxDersAd = new TextBox();
            tbxDersKodu = new TextBox();
            groupBox4 = new GroupBox();
            btnDonemEkle = new Button();
            label10 = new Label();
            label11 = new Label();
            tbxDonemAd = new TextBox();
            tbxDonemID = new TextBox();
            groupBox5 = new GroupBox();
            cbxDonemAdGecme = new ComboBox();
            label20 = new Label();
            label17 = new Label();
            tbxGecmeNotuGun = new TextBox();
            btnGecmeNotu = new Button();
            label15 = new Label();
            cbxDersAdiGecme = new ComboBox();
            cbxKayitID = new ComboBox();
            btnNotEkle = new Button();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            tbxFinalNot = new TextBox();
            tbxVizeNot = new TextBox();
            dgwAdminKayit = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwAdminKayit).BeginInit();
            SuspendLayout();
            // 
            // btnAdminIslemleriGeri
            // 
            btnAdminIslemleriGeri.BackColor = Color.IndianRed;
            btnAdminIslemleriGeri.FlatStyle = FlatStyle.Flat;
            btnAdminIslemleriGeri.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdminIslemleriGeri.ForeColor = Color.Transparent;
            btnAdminIslemleriGeri.Location = new Point(82, 829);
            btnAdminIslemleriGeri.Margin = new Padding(4, 5, 4, 5);
            btnAdminIslemleriGeri.Name = "btnAdminIslemleriGeri";
            btnAdminIslemleriGeri.Size = new Size(191, 38);
            btnAdminIslemleriGeri.TabIndex = 10;
            btnAdminIslemleriGeri.Text = "ANASAYFA";
            btnAdminIslemleriGeri.UseVisualStyleBackColor = false;
            btnAdminIslemleriGeri.Click += btnAdminIslemleriGeri_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnOgrenciEkle);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbxOgrenciSoyad);
            groupBox1.Controls.Add(tbxOgrenciAd);
            groupBox1.Controls.Add(tbxOgrenciNo);
            groupBox1.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(81, 72);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(401, 353);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci Ekle";
            // 
            // btnOgrenciEkle
            // 
            btnOgrenciEkle.ForeColor = Color.LightSeaGreen;
            btnOgrenciEkle.Location = new Point(267, 283);
            btnOgrenciEkle.Margin = new Padding(4, 5, 4, 5);
            btnOgrenciEkle.Name = "btnOgrenciEkle";
            btnOgrenciEkle.Size = new Size(107, 38);
            btnOgrenciEkle.TabIndex = 6;
            btnOgrenciEkle.Text = "Ekle";
            btnOgrenciEkle.UseVisualStyleBackColor = true;
            btnOgrenciEkle.Click += btnOgrenciEkle_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 211);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(170, 22);
            label3.TabIndex = 5;
            label3.Text = "Öğrenci Soyadı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 147);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(140, 22);
            label2.TabIndex = 4;
            label2.Text = "Öğrenci Adı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 77);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(130, 22);
            label1.TabIndex = 3;
            label1.Text = "Öğrenci No :";
            // 
            // tbxOgrenciSoyad
            // 
            tbxOgrenciSoyad.Location = new Point(213, 208);
            tbxOgrenciSoyad.Margin = new Padding(4, 5, 4, 5);
            tbxOgrenciSoyad.Name = "tbxOgrenciSoyad";
            tbxOgrenciSoyad.Size = new Size(161, 29);
            tbxOgrenciSoyad.TabIndex = 2;
            // 
            // tbxOgrenciAd
            // 
            tbxOgrenciAd.Location = new Point(213, 142);
            tbxOgrenciAd.Margin = new Padding(4, 5, 4, 5);
            tbxOgrenciAd.Name = "tbxOgrenciAd";
            tbxOgrenciAd.Size = new Size(161, 29);
            tbxOgrenciAd.TabIndex = 1;
            // 
            // tbxOgrenciNo
            // 
            tbxOgrenciNo.Location = new Point(213, 77);
            tbxOgrenciNo.Margin = new Padding(4, 5, 4, 5);
            tbxOgrenciNo.Name = "tbxOgrenciNo";
            tbxOgrenciNo.Size = new Size(161, 29);
            tbxOgrenciNo.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnOgretmenEkle);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(tbxOgretmenSoyad);
            groupBox2.Controls.Add(tbxOgretmenAd);
            groupBox2.Controls.Add(tbxOgretmenId);
            groupBox2.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(569, 72);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(419, 353);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Öğretim Üyesi Ekle";
            // 
            // btnOgretmenEkle
            // 
            btnOgretmenEkle.ForeColor = Color.LightSeaGreen;
            btnOgretmenEkle.Location = new Point(273, 283);
            btnOgretmenEkle.Margin = new Padding(4, 5, 4, 5);
            btnOgretmenEkle.Name = "btnOgretmenEkle";
            btnOgretmenEkle.Size = new Size(107, 38);
            btnOgretmenEkle.TabIndex = 13;
            btnOgretmenEkle.Text = "Ekle";
            btnOgretmenEkle.UseVisualStyleBackColor = true;
            btnOgretmenEkle.Click += btnOgretmenEkle_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 211);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(180, 22);
            label4.TabIndex = 12;
            label4.Text = "Öğretmen Soyadı :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 147);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(150, 22);
            label5.TabIndex = 11;
            label5.Text = "Öğretmen Adı :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 82);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(140, 22);
            label6.TabIndex = 10;
            label6.Text = "Öğretmen ID :";
            // 
            // tbxOgretmenSoyad
            // 
            tbxOgretmenSoyad.Location = new Point(209, 208);
            tbxOgretmenSoyad.Margin = new Padding(4, 5, 4, 5);
            tbxOgretmenSoyad.Name = "tbxOgretmenSoyad";
            tbxOgretmenSoyad.Size = new Size(171, 29);
            tbxOgretmenSoyad.TabIndex = 9;
            // 
            // tbxOgretmenAd
            // 
            tbxOgretmenAd.Location = new Point(209, 142);
            tbxOgretmenAd.Margin = new Padding(4, 5, 4, 5);
            tbxOgretmenAd.Name = "tbxOgretmenAd";
            tbxOgretmenAd.Size = new Size(171, 29);
            tbxOgretmenAd.TabIndex = 8;
            // 
            // tbxOgretmenId
            // 
            tbxOgretmenId.Location = new Point(209, 77);
            tbxOgretmenId.Margin = new Padding(4, 5, 4, 5);
            tbxOgretmenId.Name = "tbxOgretmenId";
            tbxOgretmenId.Size = new Size(171, 29);
            tbxOgretmenId.TabIndex = 7;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cbxDonemId);
            groupBox3.Controls.Add(cbxOgretmenId);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(btnDersEkle);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(tbxGecmeNotu);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(tbxDersAd);
            groupBox3.Controls.Add(tbxDersKodu);
            groupBox3.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(569, 452);
            groupBox3.Margin = new Padding(4, 5, 4, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 5, 4, 5);
            groupBox3.Size = new Size(419, 442);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ders Ekle";
            // 
            // cbxDonemId
            // 
            cbxDonemId.FormattingEnabled = true;
            cbxDonemId.Location = new Point(209, 243);
            cbxDonemId.Margin = new Padding(4, 5, 4, 5);
            cbxDonemId.Name = "cbxDonemId";
            cbxDonemId.Size = new Size(171, 30);
            cbxDonemId.TabIndex = 17;
            // 
            // cbxOgretmenId
            // 
            cbxOgretmenId.FormattingEnabled = true;
            cbxOgretmenId.Location = new Point(209, 180);
            cbxOgretmenId.Margin = new Padding(4, 5, 4, 5);
            cbxOgretmenId.Name = "cbxOgretmenId";
            cbxOgretmenId.Size = new Size(171, 30);
            cbxOgretmenId.TabIndex = 16;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(76, 251);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(110, 22);
            label18.TabIndex = 15;
            label18.Text = "Dönem Ad :";
            // 
            // btnDersEkle
            // 
            btnDersEkle.ForeColor = Color.LightSeaGreen;
            btnDersEkle.Location = new Point(273, 377);
            btnDersEkle.Margin = new Padding(4, 5, 4, 5);
            btnDersEkle.Name = "btnDersEkle";
            btnDersEkle.Size = new Size(107, 38);
            btnDersEkle.TabIndex = 13;
            btnDersEkle.Text = "Ekle";
            btnDersEkle.UseVisualStyleBackColor = true;
            btnDersEkle.Click += btnDersEkle_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 180);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(140, 22);
            label7.TabIndex = 12;
            label7.Text = "Öğretmen Ad :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(56, 307);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(130, 22);
            label16.TabIndex = 18;
            label16.Text = "Geçme Notu :";
            // 
            // tbxGecmeNotu
            // 
            tbxGecmeNotu.Location = new Point(209, 300);
            tbxGecmeNotu.Margin = new Padding(4, 5, 4, 5);
            tbxGecmeNotu.Name = "tbxGecmeNotu";
            tbxGecmeNotu.Size = new Size(171, 29);
            tbxGecmeNotu.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(76, 118);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(110, 22);
            label8.TabIndex = 11;
            label8.Text = "Ders Adı :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(66, 55);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(120, 22);
            label9.TabIndex = 10;
            label9.Text = "Ders Kodu :";
            // 
            // tbxDersAd
            // 
            tbxDersAd.Location = new Point(209, 113);
            tbxDersAd.Margin = new Padding(4, 5, 4, 5);
            tbxDersAd.Name = "tbxDersAd";
            tbxDersAd.Size = new Size(171, 29);
            tbxDersAd.TabIndex = 8;
            // 
            // tbxDersKodu
            // 
            tbxDersKodu.Location = new Point(209, 48);
            tbxDersKodu.Margin = new Padding(4, 5, 4, 5);
            tbxDersKodu.Name = "tbxDersKodu";
            tbxDersKodu.Size = new Size(171, 29);
            tbxDersKodu.TabIndex = 7;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnDonemEkle);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(tbxDonemAd);
            groupBox4.Controls.Add(tbxDonemID);
            groupBox4.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(82, 452);
            groupBox4.Margin = new Padding(4, 5, 4, 5);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 5, 4, 5);
            groupBox4.Size = new Size(401, 310);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            groupBox4.Text = "Dönem Ekle";
            // 
            // btnDonemEkle
            // 
            btnDonemEkle.ForeColor = Color.LightSeaGreen;
            btnDonemEkle.Location = new Point(266, 222);
            btnDonemEkle.Margin = new Padding(4, 5, 4, 5);
            btnDonemEkle.Name = "btnDonemEkle";
            btnDonemEkle.Size = new Size(107, 38);
            btnDonemEkle.TabIndex = 13;
            btnDonemEkle.Text = "Ekle";
            btnDonemEkle.UseVisualStyleBackColor = true;
            btnDonemEkle.Click += btnDonemEkle_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(63, 150);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(120, 22);
            label10.TabIndex = 12;
            label10.Text = "Dönem Adı :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(73, 83);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(110, 22);
            label11.TabIndex = 11;
            label11.Text = "Dönem ID :";
            // 
            // tbxDonemAd
            // 
            tbxDonemAd.Location = new Point(210, 145);
            tbxDonemAd.Margin = new Padding(4, 5, 4, 5);
            tbxDonemAd.Name = "tbxDonemAd";
            tbxDonemAd.Size = new Size(164, 29);
            tbxDonemAd.TabIndex = 9;
            // 
            // tbxDonemID
            // 
            tbxDonemID.Location = new Point(210, 78);
            tbxDonemID.Margin = new Padding(4, 5, 4, 5);
            tbxDonemID.Name = "tbxDonemID";
            tbxDonemID.Size = new Size(164, 29);
            tbxDonemID.TabIndex = 8;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(cbxDonemAdGecme);
            groupBox5.Controls.Add(label20);
            groupBox5.Controls.Add(label17);
            groupBox5.Controls.Add(tbxGecmeNotuGun);
            groupBox5.Controls.Add(btnGecmeNotu);
            groupBox5.Controls.Add(label15);
            groupBox5.Controls.Add(cbxDersAdiGecme);
            groupBox5.Controls.Add(cbxKayitID);
            groupBox5.Controls.Add(btnNotEkle);
            groupBox5.Controls.Add(label12);
            groupBox5.Controls.Add(label13);
            groupBox5.Controls.Add(label14);
            groupBox5.Controls.Add(tbxFinalNot);
            groupBox5.Controls.Add(tbxVizeNot);
            groupBox5.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox5.ForeColor = Color.White;
            groupBox5.Location = new Point(1198, 504);
            groupBox5.Margin = new Padding(4, 5, 4, 5);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4, 5, 4, 5);
            groupBox5.Size = new Size(784, 363);
            groupBox5.TabIndex = 14;
            groupBox5.TabStop = false;
            groupBox5.Text = "Not Ekle - Güncelle";
            // 
            // cbxDonemAdGecme
            // 
            cbxDonemAdGecme.FormattingEnabled = true;
            cbxDonemAdGecme.Location = new Point(176, 199);
            cbxDonemAdGecme.Margin = new Padding(4, 5, 4, 5);
            cbxDonemAdGecme.Name = "cbxDonemAdGecme";
            cbxDonemAdGecme.Size = new Size(171, 30);
            cbxDonemAdGecme.TabIndex = 20;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(36, 139);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(130, 22);
            label20.TabIndex = 25;
            label20.Text = "Geçme Notu :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(56, 207);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(110, 22);
            label17.TabIndex = 19;
            label17.Text = "Dönem Ad :";
            // 
            // tbxGecmeNotuGun
            // 
            tbxGecmeNotuGun.Location = new Point(176, 132);
            tbxGecmeNotuGun.Margin = new Padding(4, 5, 4, 5);
            tbxGecmeNotuGun.Name = "tbxGecmeNotuGun";
            tbxGecmeNotuGun.Size = new Size(171, 29);
            tbxGecmeNotuGun.TabIndex = 24;
            // 
            // btnGecmeNotu
            // 
            btnGecmeNotu.ForeColor = Color.LightSeaGreen;
            btnGecmeNotu.Location = new Point(144, 281);
            btnGecmeNotu.Margin = new Padding(4, 5, 4, 5);
            btnGecmeNotu.Name = "btnGecmeNotu";
            btnGecmeNotu.Size = new Size(203, 38);
            btnGecmeNotu.TabIndex = 19;
            btnGecmeNotu.Text = "Ekle - Güncelle";
            btnGecmeNotu.UseVisualStyleBackColor = true;
            btnGecmeNotu.Click += btnGecmeNotu_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(56, 70);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(110, 22);
            label15.TabIndex = 16;
            label15.Text = "Ders Adı :";
            // 
            // cbxDersAdiGecme
            // 
            cbxDersAdiGecme.FormattingEnabled = true;
            cbxDersAdiGecme.Location = new Point(176, 65);
            cbxDersAdiGecme.Margin = new Padding(4, 5, 4, 5);
            cbxDersAdiGecme.Name = "cbxDersAdiGecme";
            cbxDersAdiGecme.Size = new Size(171, 30);
            cbxDersAdiGecme.TabIndex = 15;
            // 
            // cbxKayitID
            // 
            cbxKayitID.FormattingEnabled = true;
            cbxKayitID.Location = new Point(569, 65);
            cbxKayitID.Margin = new Padding(4, 5, 4, 5);
            cbxKayitID.Name = "cbxKayitID";
            cbxKayitID.Size = new Size(171, 30);
            cbxKayitID.TabIndex = 14;
            // 
            // btnNotEkle
            // 
            btnNotEkle.ForeColor = Color.LightSeaGreen;
            btnNotEkle.Location = new Point(537, 281);
            btnNotEkle.Margin = new Padding(4, 5, 4, 5);
            btnNotEkle.Name = "btnNotEkle";
            btnNotEkle.Size = new Size(203, 38);
            btnNotEkle.TabIndex = 13;
            btnNotEkle.Text = "Ekle - Güncelle";
            btnNotEkle.UseVisualStyleBackColor = true;
            btnNotEkle.Click += btnNotEkle_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(431, 200);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(130, 22);
            label12.TabIndex = 12;
            label12.Text = "Final Notu :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(441, 133);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(120, 22);
            label13.TabIndex = 11;
            label13.Text = "Vize Notu :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(451, 68);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(110, 22);
            label14.TabIndex = 10;
            label14.Text = "Kayıt ID :";
            // 
            // tbxFinalNot
            // 
            tbxFinalNot.Location = new Point(569, 197);
            tbxFinalNot.Margin = new Padding(4, 5, 4, 5);
            tbxFinalNot.Name = "tbxFinalNot";
            tbxFinalNot.Size = new Size(171, 29);
            tbxFinalNot.TabIndex = 9;
            // 
            // tbxVizeNot
            // 
            tbxVizeNot.Location = new Point(569, 130);
            tbxVizeNot.Margin = new Padding(4, 5, 4, 5);
            tbxVizeNot.Name = "tbxVizeNot";
            tbxVizeNot.Size = new Size(171, 29);
            tbxVizeNot.TabIndex = 8;
            // 
            // dgwAdminKayit
            // 
            dgwAdminKayit.BackgroundColor = Color.White;
            dgwAdminKayit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwAdminKayit.Location = new Point(1067, 72);
            dgwAdminKayit.Margin = new Padding(4, 5, 4, 5);
            dgwAdminKayit.Name = "dgwAdminKayit";
            dgwAdminKayit.RowHeadersWidth = 62;
            dgwAdminKayit.RowTemplate.Height = 25;
            dgwAdminKayit.Size = new Size(973, 390);
            dgwAdminKayit.TabIndex = 15;
            // 
            // AdminIslemleri
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(2141, 913);
            Controls.Add(dgwAdminKayit);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(btnAdminIslemleriGeri);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AdminIslemleri";
            Text = "AdminIslemleri";
            Load += AdminIslemleri_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwAdminKayit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdminIslemleriGeri;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button btnOgrenciEkle;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbxOgrenciSoyad;
        private TextBox tbxOgrenciAd;
        private TextBox tbxOgrenciNo;
        private Button btnOgretmenEkle;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbxOgretmenSoyad;
        private TextBox tbxOgretmenAd;
        private TextBox tbxOgretmenId;
        private Button btnDersEkle;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox tbxDersAd;
        private TextBox tbxDersKodu;
        private Button btnDonemEkle;
        private Label label10;
        private Label label11;
        private TextBox tbxDonemAd;
        private TextBox tbxDonemID;
        private GroupBox groupBox5;
        private Button btnNotEkle;
        private Label label12;
        private Label label13;
        private TextBox tbxFinalNot;
        private TextBox tbxVizeNot;
        private DataGridView dgwAdminKayit;
        private Label label18;
        private ComboBox cbxDonemId;
        private ComboBox cbxOgretmenId;
        private ComboBox cbxKayitID;
        private Label label14;
        private Button btnGecmeNotu;
        private Label label16;
        private TextBox tbxGecmeNotu;
        private Label label15;
        private ComboBox cbxDersAdiGecme;
        private Label label20;
        private TextBox tbxGecmeNotuGun;
        private ComboBox cbxDonemAdGecme;
        private Label label17;
    }
}