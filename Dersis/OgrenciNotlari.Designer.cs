namespace Dersis
{
    partial class OgrenciNotlari
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
            btnOgrenciNotlariGeri = new Button();
            dgwDerseGoreListele = new DataGridView();
            label1 = new Label();
            cbxDersSec = new ComboBox();
            label2 = new Label();
            btnListele = new Button();
            label3 = new Label();
            lblOrtalama = new Label();
            label4 = new Label();
            cbxDonemSec = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgwDerseGoreListele).BeginInit();
            SuspendLayout();
            // 
            // btnOgrenciNotlariGeri
            // 
            btnOgrenciNotlariGeri.BackColor = Color.IndianRed;
            btnOgrenciNotlariGeri.FlatStyle = FlatStyle.Flat;
            btnOgrenciNotlariGeri.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOgrenciNotlariGeri.ForeColor = Color.Transparent;
            btnOgrenciNotlariGeri.Location = new Point(333, 677);
            btnOgrenciNotlariGeri.Margin = new Padding(4, 5, 4, 5);
            btnOgrenciNotlariGeri.Name = "btnOgrenciNotlariGeri";
            btnOgrenciNotlariGeri.Size = new Size(267, 38);
            btnOgrenciNotlariGeri.TabIndex = 10;
            btnOgrenciNotlariGeri.Text = "Anasayfa";
            btnOgrenciNotlariGeri.UseVisualStyleBackColor = false;
            btnOgrenciNotlariGeri.Click += btnOgrenciNotlariGeri_Click;
            // 
            // dgwDerseGoreListele
            // 
            dgwDerseGoreListele.BackgroundColor = Color.White;
            dgwDerseGoreListele.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwDerseGoreListele.Location = new Point(77, 243);
            dgwDerseGoreListele.Margin = new Padding(4, 5, 4, 5);
            dgwDerseGoreListele.Name = "dgwDerseGoreListele";
            dgwDerseGoreListele.RowHeadersWidth = 62;
            dgwDerseGoreListele.RowTemplate.Height = 25;
            dgwDerseGoreListele.Size = new Size(771, 308);
            dgwDerseGoreListele.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 15F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(368, 53);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(223, 36);
            label1.TabIndex = 14;
            label1.Text = "DERS LİSTEMİZ";
            // 
            // cbxDersSec
            // 
            cbxDersSec.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbxDersSec.FormattingEnabled = true;
            cbxDersSec.Location = new Point(237, 157);
            cbxDersSec.Margin = new Padding(4, 5, 4, 5);
            cbxDersSec.Name = "cbxDersSec";
            cbxDersSec.Size = new Size(134, 30);
            cbxDersSec.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(105, 160);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 22);
            label2.TabIndex = 16;
            label2.Text = "Ders Seç :";
            // 
            // btnListele
            // 
            btnListele.BackColor = Color.FromArgb(64, 64, 64);
            btnListele.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnListele.ForeColor = Color.White;
            btnListele.Location = new Point(733, 141);
            btnListele.Margin = new Padding(4, 5, 4, 5);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(115, 60);
            btnListele.TabIndex = 17;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = false;
            btnListele.Click += btnListele_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(342, 612);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(190, 22);
            label3.TabIndex = 19;
            label3.Text = "Sınıf Ortalaması :";
            // 
            // lblOrtalama
            // 
            lblOrtalama.AutoSize = true;
            lblOrtalama.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrtalama.ForeColor = Color.Black;
            lblOrtalama.Location = new Point(551, 612);
            lblOrtalama.Margin = new Padding(4, 0, 4, 0);
            lblOrtalama.Name = "lblOrtalama";
            lblOrtalama.Size = new Size(40, 22);
            lblOrtalama.TabIndex = 21;
            lblOrtalama.Text = "0.0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(401, 160);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 22);
            label4.TabIndex = 23;
            label4.Text = "Dönem Seç :";
            // 
            // cbxDonemSec
            // 
            cbxDonemSec.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbxDonemSec.FormattingEnabled = true;
            cbxDonemSec.Location = new Point(529, 157);
            cbxDonemSec.Margin = new Padding(4, 5, 4, 5);
            cbxDonemSec.Name = "cbxDonemSec";
            cbxDonemSec.Size = new Size(134, 30);
            cbxDonemSec.TabIndex = 22;
            // 
            // OgrenciNotlari
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(937, 750);
            Controls.Add(label4);
            Controls.Add(cbxDonemSec);
            Controls.Add(lblOrtalama);
            Controls.Add(label3);
            Controls.Add(btnListele);
            Controls.Add(label2);
            Controls.Add(cbxDersSec);
            Controls.Add(label1);
            Controls.Add(dgwDerseGoreListele);
            Controls.Add(btnOgrenciNotlariGeri);
            Margin = new Padding(4, 5, 4, 5);
            Name = "OgrenciNotlari";
            Text = "OgrenciNotlari";
            ((System.ComponentModel.ISupportInitialize)dgwDerseGoreListele).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOgrenciNotlariGeri;
        private DataGridView dgwDerseGoreListele;
        private Label label1;
        private ComboBox cbxDersSec;
        private Label label2;
        private Button btnListele;
        private Label label3;
        private Label lblOrtalama;
        private Label label4;
        private ComboBox cbxDonemSec;
    }
}