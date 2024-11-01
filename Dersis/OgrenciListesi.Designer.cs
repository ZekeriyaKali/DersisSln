namespace Dersis
{
    partial class OgrenciListesi
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
            btnOgrenciListesiGeri = new Button();
            dgwOgrenciNotListele = new DataGridView();
            label1 = new Label();
            cbxOgrenciSec = new ComboBox();
            cbxDonemSec = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            btnListele = new Button();
            label4 = new Label();
            lblOrtalama = new Label();
            ((System.ComponentModel.ISupportInitialize)dgwOgrenciNotListele).BeginInit();
            SuspendLayout();
            // 
            // btnOgrenciListesiGeri
            // 
            btnOgrenciListesiGeri.BackColor = Color.IndianRed;
            btnOgrenciListesiGeri.FlatStyle = FlatStyle.Flat;
            btnOgrenciListesiGeri.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOgrenciListesiGeri.ForeColor = Color.Transparent;
            btnOgrenciListesiGeri.Location = new Point(423, 671);
            btnOgrenciListesiGeri.Margin = new Padding(4, 5, 4, 5);
            btnOgrenciListesiGeri.Name = "btnOgrenciListesiGeri";
            btnOgrenciListesiGeri.Size = new Size(267, 38);
            btnOgrenciListesiGeri.TabIndex = 9;
            btnOgrenciListesiGeri.Text = "Anasayfa";
            btnOgrenciListesiGeri.UseVisualStyleBackColor = false;
            btnOgrenciListesiGeri.Click += btnOgrenciListesiGeri_Click;
            // 
            // dgwOgrenciNotListele
            // 
            dgwOgrenciNotListele.BackgroundColor = Color.White;
            dgwOgrenciNotListele.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwOgrenciNotListele.Location = new Point(153, 230);
            dgwOgrenciNotListele.Margin = new Padding(4, 5, 4, 5);
            dgwOgrenciNotListele.Name = "dgwOgrenciNotListele";
            dgwOgrenciNotListele.RowHeadersWidth = 62;
            dgwOgrenciNotListele.RowTemplate.Height = 25;
            dgwOgrenciNotListele.Size = new Size(841, 338);
            dgwOgrenciNotListele.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 15F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(435, 69);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(255, 36);
            label1.TabIndex = 13;
            label1.Text = "ÖĞRENCİ LİSTESİ";
            // 
            // cbxOgrenciSec
            // 
            cbxOgrenciSec.ForeColor = SystemColors.WindowText;
            cbxOgrenciSec.FormattingEnabled = true;
            cbxOgrenciSec.Location = new Point(321, 167);
            cbxOgrenciSec.Margin = new Padding(4, 5, 4, 5);
            cbxOgrenciSec.Name = "cbxOgrenciSec";
            cbxOgrenciSec.Size = new Size(171, 33);
            cbxOgrenciSec.TabIndex = 14;
            // 
            // cbxDonemSec
            // 
            cbxDonemSec.FormattingEnabled = true;
            cbxDonemSec.Location = new Point(662, 167);
            cbxDonemSec.Margin = new Padding(4, 5, 4, 5);
            cbxDonemSec.Name = "cbxDonemSec";
            cbxDonemSec.Size = new Size(171, 33);
            cbxDonemSec.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(153, 173);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(160, 22);
            label2.TabIndex = 16;
            label2.Text = "Öğrenci No Seç:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(516, 173);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(120, 22);
            label3.TabIndex = 17;
            label3.Text = "Dönem Seç :";
            // 
            // btnListele
            // 
            btnListele.BackColor = Color.RoyalBlue;
            btnListele.FlatStyle = FlatStyle.Flat;
            btnListele.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnListele.ForeColor = Color.Transparent;
            btnListele.Location = new Point(887, 158);
            btnListele.Margin = new Padding(4, 5, 4, 5);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(107, 53);
            btnListele.TabIndex = 18;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = false;
            btnListele.Click += btnListele_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(456, 604);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(190, 22);
            label4.TabIndex = 19;
            label4.Text = "Dönem Ortalaması :";
            // 
            // lblOrtalama
            // 
            lblOrtalama.AutoSize = true;
            lblOrtalama.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrtalama.ForeColor = Color.RoyalBlue;
            lblOrtalama.Location = new Point(638, 604);
            lblOrtalama.Margin = new Padding(4, 0, 4, 0);
            lblOrtalama.Name = "lblOrtalama";
            lblOrtalama.Size = new Size(40, 22);
            lblOrtalama.TabIndex = 20;
            lblOrtalama.Text = "0.0";
            // 
            // OgrenciListesi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(1143, 750);
            Controls.Add(lblOrtalama);
            Controls.Add(label4);
            Controls.Add(btnListele);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbxDonemSec);
            Controls.Add(cbxOgrenciSec);
            Controls.Add(label1);
            Controls.Add(dgwOgrenciNotListele);
            Controls.Add(btnOgrenciListesiGeri);
            Margin = new Padding(4, 5, 4, 5);
            Name = "OgrenciListesi";
            Text = "OgrenciListesi";
            ((System.ComponentModel.ISupportInitialize)dgwOgrenciNotListele).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOgrenciListesiGeri;
        private DataGridView dgwOgrenciNotListele;
        private Label label1;
        private ComboBox cbxOgrenciSec;
        private ComboBox cbxDonemSec;
        private Label label2;
        private Label label3;
        private Button btnListele;
        private Label label4;
        private Label lblOrtalama;
    }
}