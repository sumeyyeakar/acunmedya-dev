namespace HastaRandevuSistemi
{
    partial class Form1
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
            lblBrans = new Label();
            lblDoktor = new Label();
            cmbBrans = new ComboBox();
            cmbDoktor = new ComboBox();
            txtHastaAdi = new TextBox();
            txtHastaSoyadi = new TextBox();
            lblHastaAd = new Label();
            lblHastaSoyad = new Label();
            dtpTarih = new DateTimePicker();
            lblTarih = new Label();
            cmbSaat = new ComboBox();
            btnRandevuOlustur = new Button();
            lblSaat = new Label();
            SuspendLayout();
            // 
            // lblBrans
            // 
            lblBrans.AutoSize = true;
            lblBrans.Location = new Point(238, 71);
            lblBrans.Name = "lblBrans";
            lblBrans.Size = new Size(42, 15);
            lblBrans.TabIndex = 0;
            lblBrans.Text = "Branş :";
            // 
            // lblDoktor
            // 
            lblDoktor.AutoSize = true;
            lblDoktor.Location = new Point(238, 134);
            lblDoktor.Name = "lblDoktor";
            lblDoktor.Size = new Size(49, 15);
            lblDoktor.TabIndex = 1;
            lblDoktor.Text = "Doktor :";
            // 
            // cmbBrans
            // 
            cmbBrans.FormattingEnabled = true;
            cmbBrans.Location = new Point(346, 63);
            cmbBrans.Name = "cmbBrans";
            cmbBrans.Size = new Size(121, 23);
            cmbBrans.TabIndex = 2;
            cmbBrans.SelectedIndexChanged += cmbBrans_SelectedIndexChanged;
            // 
            // cmbDoktor
            // 
            cmbDoktor.FormattingEnabled = true;
            cmbDoktor.Location = new Point(346, 126);
            cmbDoktor.Name = "cmbDoktor";
            cmbDoktor.Size = new Size(121, 23);
            cmbDoktor.TabIndex = 3;
            // 
            // txtHastaAdi
            // 
            txtHastaAdi.Location = new Point(346, 184);
            txtHastaAdi.Name = "txtHastaAdi";
            txtHastaAdi.Size = new Size(121, 23);
            txtHastaAdi.TabIndex = 4;
            // 
            // txtHastaSoyadi
            // 
            txtHastaSoyadi.Location = new Point(346, 245);
            txtHastaSoyadi.Name = "txtHastaSoyadi";
            txtHastaSoyadi.Size = new Size(121, 23);
            txtHastaSoyadi.TabIndex = 5;
            // 
            // lblHastaAd
            // 
            lblHastaAd.AutoSize = true;
            lblHastaAd.Location = new Point(238, 192);
            lblHastaAd.Name = "lblHastaAd";
            lblHastaAd.Size = new Size(64, 15);
            lblHastaAd.TabIndex = 6;
            lblHastaAd.Text = "Hasta Adı :";
            // 
            // lblHastaSoyad
            // 
            lblHastaSoyad.AutoSize = true;
            lblHastaSoyad.Location = new Point(238, 253);
            lblHastaSoyad.Name = "lblHastaSoyad";
            lblHastaSoyad.Size = new Size(81, 15);
            lblHastaSoyad.TabIndex = 7;
            lblHastaSoyad.Text = "Hasta Soyadı :";
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(227, 303);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(176, 23);
            dtpTarih.TabIndex = 8;
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Location = new Point(111, 311);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(77, 15);
            lblTarih.TabIndex = 9;
            lblTarih.Text = "Tarih Seçiniz :";
            // 
            // cmbSaat
            // 
            cmbSaat.FormattingEnabled = true;
            cmbSaat.Location = new Point(554, 301);
            cmbSaat.Name = "cmbSaat";
            cmbSaat.Size = new Size(121, 23);
            cmbSaat.TabIndex = 10;
            // 
            // btnRandevuOlustur
            // 
            btnRandevuOlustur.Location = new Point(516, 357);
            btnRandevuOlustur.Name = "btnRandevuOlustur";
            btnRandevuOlustur.Size = new Size(113, 35);
            btnRandevuOlustur.TabIndex = 11;
            btnRandevuOlustur.Text = "Randevu Oluştur";
            btnRandevuOlustur.UseVisualStyleBackColor = true;
            btnRandevuOlustur.Click += btnRandevuOlustur_Click;
            // 
            // lblSaat
            // 
            lblSaat.AutoSize = true;
            lblSaat.Location = new Point(449, 309);
            lblSaat.Name = "lblSaat";
            lblSaat.Size = new Size(74, 15);
            lblSaat.TabIndex = 12;
            lblSaat.Text = "Saat Seçiniz :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSaat);
            Controls.Add(btnRandevuOlustur);
            Controls.Add(cmbSaat);
            Controls.Add(lblTarih);
            Controls.Add(dtpTarih);
            Controls.Add(lblHastaSoyad);
            Controls.Add(lblHastaAd);
            Controls.Add(txtHastaSoyadi);
            Controls.Add(txtHastaAdi);
            Controls.Add(cmbDoktor);
            Controls.Add(cmbBrans);
            Controls.Add(lblDoktor);
            Controls.Add(lblBrans);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBrans;
        private Label lblDoktor;
        private ComboBox cmbBrans;
        private ComboBox cmbDoktor;
        private TextBox txtHastaAdi;
        private TextBox txtHastaSoyadi;
        private Label lblHastaAd;
        private Label lblHastaSoyad;
        private DateTimePicker dtpTarih;
        private Label lblTarih;
        private ComboBox cmbSaat;
        private Button btnRandevuOlustur;
        private Label lblSaat;
    }
}
