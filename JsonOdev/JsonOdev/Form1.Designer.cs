namespace JsonOdev
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
            lblUrunAd = new Label();
            lblFıyat = new Label();
            lblSonKullanma = new Label();
            lblMarka = new Label();
            txtUrunAd = new TextBox();
            txtFıyat = new TextBox();
            txtMarka = new TextBox();
            dtp1 = new DateTimePicker();
            btnJsonOlustur = new Button();
            btnJsonOku = new Button();
            SuspendLayout();
            // 
            // lblUrunAd
            // 
            lblUrunAd.AutoSize = true;
            lblUrunAd.Location = new Point(215, 86);
            lblUrunAd.Name = "lblUrunAd";
            lblUrunAd.Size = new Size(60, 15);
            lblUrunAd.TabIndex = 0;
            lblUrunAd.Text = "Ürün Adı :";
            // 
            // lblFıyat
            // 
            lblFıyat.AutoSize = true;
            lblFıyat.Location = new Point(215, 142);
            lblFıyat.Name = "lblFıyat";
            lblFıyat.Size = new Size(38, 15);
            lblFıyat.TabIndex = 1;
            lblFıyat.Text = "Fiyat :";
            // 
            // lblSonKullanma
            // 
            lblSonKullanma.AutoSize = true;
            lblSonKullanma.Location = new Point(215, 199);
            lblSonKullanma.Name = "lblSonKullanma";
            lblSonKullanma.Size = new Size(117, 15);
            lblSonKullanma.TabIndex = 2;
            lblSonKullanma.Text = "Son Kullanma Tarihi :";
            // 
            // lblMarka
            // 
            lblMarka.AutoSize = true;
            lblMarka.Location = new Point(215, 260);
            lblMarka.Name = "lblMarka";
            lblMarka.Size = new Size(46, 15);
            lblMarka.TabIndex = 3;
            lblMarka.Text = "Marka :";
            // 
            // txtUrunAd
            // 
            txtUrunAd.Location = new Point(423, 86);
            txtUrunAd.Name = "txtUrunAd";
            txtUrunAd.Size = new Size(136, 23);
            txtUrunAd.TabIndex = 4;
            // 
            // txtFıyat
            // 
            txtFıyat.Location = new Point(423, 142);
            txtFıyat.Name = "txtFıyat";
            txtFıyat.Size = new Size(136, 23);
            txtFıyat.TabIndex = 5;
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(423, 260);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(136, 23);
            txtMarka.TabIndex = 6;
            // 
            // dtp1
            // 
            dtp1.Location = new Point(423, 199);
            dtp1.Name = "dtp1";
            dtp1.Size = new Size(136, 23);
            dtp1.TabIndex = 7;
            // 
            // btnJsonOlustur
            // 
            btnJsonOlustur.Location = new Point(277, 341);
            btnJsonOlustur.Name = "btnJsonOlustur";
            btnJsonOlustur.Size = new Size(75, 42);
            btnJsonOlustur.TabIndex = 8;
            btnJsonOlustur.Text = "JSON OLUŞTUR";
            btnJsonOlustur.UseVisualStyleBackColor = true;
            btnJsonOlustur.Click += btnJsonOlustur_Click;
            // 
            // btnJsonOku
            // 
            btnJsonOku.Location = new Point(455, 341);
            btnJsonOku.Name = "btnJsonOku";
            btnJsonOku.Size = new Size(75, 42);
            btnJsonOku.TabIndex = 9;
            btnJsonOku.Text = "JSON OKU";
            btnJsonOku.UseVisualStyleBackColor = true;
            btnJsonOku.Click += btnJsonOku_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnJsonOku);
            Controls.Add(btnJsonOlustur);
            Controls.Add(dtp1);
            Controls.Add(txtMarka);
            Controls.Add(txtFıyat);
            Controls.Add(txtUrunAd);
            Controls.Add(lblMarka);
            Controls.Add(lblSonKullanma);
            Controls.Add(lblFıyat);
            Controls.Add(lblUrunAd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUrunAd;
        private Label lblFıyat;
        private Label lblSonKullanma;
        private Label lblMarka;
        private TextBox txtUrunAd;
        private TextBox txtFıyat;
        private TextBox txtMarka;
        private DateTimePicker dtp1;
        private Button btnJsonOlustur;
        private Button btnJsonOku;
    }
}
