namespace Dersis
{
    partial class AcilanDersler
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
            btnAcilanDerslerGeri = new Button();
            dgwAcilanDersler = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgwAcilanDersler).BeginInit();
            SuspendLayout();
            // 
            // btnAcilanDerslerGeri
            // 
            btnAcilanDerslerGeri.BackColor = Color.IndianRed;
            btnAcilanDerslerGeri.FlatStyle = FlatStyle.Popup;
            btnAcilanDerslerGeri.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAcilanDerslerGeri.ForeColor = Color.Transparent;
            btnAcilanDerslerGeri.Location = new Point(256, 504);
            btnAcilanDerslerGeri.Margin = new Padding(4, 5, 4, 5);
            btnAcilanDerslerGeri.Name = "btnAcilanDerslerGeri";
            btnAcilanDerslerGeri.Size = new Size(184, 38);
            btnAcilanDerslerGeri.TabIndex = 11;
            btnAcilanDerslerGeri.Text = "ANASAYFA";
            btnAcilanDerslerGeri.UseVisualStyleBackColor = false;
            btnAcilanDerslerGeri.Click += btnDersKayitlariGeri_Click;
            // 
            // dgwAcilanDersler
            // 
            dgwAcilanDersler.BackgroundColor = SystemColors.GradientActiveCaption;
            dgwAcilanDersler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwAcilanDersler.Location = new Point(13, 111);
            dgwAcilanDersler.Margin = new Padding(4, 5, 4, 5);
            dgwAcilanDersler.Name = "dgwAcilanDersler";
            dgwAcilanDersler.RowHeadersWidth = 62;
            dgwAcilanDersler.RowTemplate.Height = 25;
            dgwAcilanDersler.Size = new Size(671, 364);
            dgwAcilanDersler.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 15F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(182, 49);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(335, 36);
            label1.TabIndex = 15;
            label1.Text = "KAYDI AÇILAN DERSLER";
            // 
            // AcilanDersler
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(697, 608);
            Controls.Add(label1);
            Controls.Add(dgwAcilanDersler);
            Controls.Add(btnAcilanDerslerGeri);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AcilanDersler";
            Text = "AcilanDerslerForm";
            Load += AcilanDersler_Load;
            ((System.ComponentModel.ISupportInitialize)dgwAcilanDersler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAcilanDerslerGeri;
        private DataGridView dgwAcilanDersler;
        private Label label1;
    }
}