namespace Dersis
{
    partial class OgretmenListesi
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
            btnOgretmenListesiGeri = new Button();
            dgwOgretmenListele = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgwOgretmenListele).BeginInit();
            SuspendLayout();
            // 
            // btnOgretmenListesiGeri
            // 
            btnOgretmenListesiGeri.BackColor = Color.IndianRed;
            btnOgretmenListesiGeri.FlatStyle = FlatStyle.Flat;
            btnOgretmenListesiGeri.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOgretmenListesiGeri.ForeColor = Color.Transparent;
            btnOgretmenListesiGeri.Location = new Point(369, 608);
            btnOgretmenListesiGeri.Margin = new Padding(4, 5, 4, 5);
            btnOgretmenListesiGeri.Name = "btnOgretmenListesiGeri";
            btnOgretmenListesiGeri.Size = new Size(251, 38);
            btnOgretmenListesiGeri.TabIndex = 10;
            btnOgretmenListesiGeri.Text = "Anasayfa";
            btnOgretmenListesiGeri.UseVisualStyleBackColor = false;
            btnOgretmenListesiGeri.Click += btnOgretmenListesiGeri_Click;
            // 
            // dgwOgretmenListele
            // 
            dgwOgretmenListele.BackgroundColor = Color.White;
            dgwOgretmenListele.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwOgretmenListele.Location = new Point(83, 165);
            dgwOgretmenListele.Margin = new Padding(4, 5, 4, 5);
            dgwOgretmenListele.Name = "dgwOgretmenListele";
            dgwOgretmenListele.RowHeadersWidth = 62;
            dgwOgretmenListele.RowTemplate.Height = 25;
            dgwOgretmenListele.Size = new Size(778, 378);
            dgwOgretmenListele.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 15F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(358, 74);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(271, 36);
            label1.TabIndex = 12;
            label1.Text = "ÖĞRETMEN LİSTESİ";
            // 
            // OgretmenListesi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(967, 750);
            Controls.Add(label1);
            Controls.Add(dgwOgretmenListele);
            Controls.Add(btnOgretmenListesiGeri);
            Margin = new Padding(4, 5, 4, 5);
            Name = "OgretmenListesi";
            Text = "OgretmenListesi";
            Load += OgretmenListesi_Load;
            ((System.ComponentModel.ISupportInitialize)dgwOgretmenListele).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOgretmenListesiGeri;
        private DataGridView dgwOgretmenListele;
        private Label label1;
    }
}