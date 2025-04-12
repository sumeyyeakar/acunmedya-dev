namespace Araba_Form
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
            lblMarka = new Label();
            lblModel = new Label();
            lblRenk = new Label();
            lblKapıSayisi = new Label();
            lblPencereSayisi = new Label();
            cmbMarka = new ComboBox();
            cmbModel = new ComboBox();
            cmbRenk = new ComboBox();
            cmbKapıSayisi = new ComboBox();
            cmbPencereSayisi = new ComboBox();
            btnBilgileriGoster = new Button();
            lblYakıt = new Label();
            txtYakıt = new TextBox();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // lblMarka
            // 
            lblMarka.AutoSize = true;
            lblMarka.Location = new Point(227, 20);
            lblMarka.Name = "lblMarka";
            lblMarka.Size = new Size(46, 15);
            lblMarka.TabIndex = 0;
            lblMarka.Text = "Marka :";
            lblMarka.Click += lblMarka_Click;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(227, 68);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(47, 15);
            lblModel.TabIndex = 1;
            lblModel.Text = "Model :";
            // 
            // lblRenk
            // 
            lblRenk.AutoSize = true;
            lblRenk.Location = new Point(227, 109);
            lblRenk.Name = "lblRenk";
            lblRenk.Size = new Size(39, 15);
            lblRenk.TabIndex = 2;
            lblRenk.Text = "Renk :";
            // 
            // lblKapıSayisi
            // 
            lblKapıSayisi.AutoSize = true;
            lblKapıSayisi.Location = new Point(227, 163);
            lblKapıSayisi.Name = "lblKapıSayisi";
            lblKapıSayisi.Size = new Size(68, 15);
            lblKapıSayisi.TabIndex = 3;
            lblKapıSayisi.Text = "Kapı Sayısı :";
            // 
            // lblPencereSayisi
            // 
            lblPencereSayisi.AutoSize = true;
            lblPencereSayisi.Location = new Point(227, 214);
            lblPencereSayisi.Name = "lblPencereSayisi";
            lblPencereSayisi.Size = new Size(87, 15);
            lblPencereSayisi.TabIndex = 4;
            lblPencereSayisi.Text = "Pencere Sayısı :";
            // 
            // cmbMarka
            // 
            cmbMarka.FormattingEnabled = true;
            cmbMarka.Items.AddRange(new object[] { "Seçiniz", "Toyota", "BMW", "Mercedes", "Audi" });
            cmbMarka.Location = new Point(388, 20);
            cmbMarka.Name = "cmbMarka";
            cmbMarka.Size = new Size(121, 23);
            cmbMarka.TabIndex = 5;
            cmbMarka.SelectedIndexChanged += cmbMarka_SelectedIndexChanged;
            // 
            // cmbModel
            // 
            cmbModel.FormattingEnabled = true;
            cmbModel.Items.AddRange(new object[] { "Seçiniz", "Yaris", "X5", "C180", "A4" });
            cmbModel.Location = new Point(387, 68);
            cmbModel.Name = "cmbModel";
            cmbModel.Size = new Size(121, 23);
            cmbModel.TabIndex = 6;
            cmbModel.SelectedIndexChanged += cmbModel_SelectedIndexChanged;
            // 
            // cmbRenk
            // 
            cmbRenk.FormattingEnabled = true;
            cmbRenk.Items.AddRange(new object[] { "Seçiniz", "Siyah", "Beyaz", "Gri", "Kırmızı", "Mavi" });
            cmbRenk.Location = new Point(387, 109);
            cmbRenk.Name = "cmbRenk";
            cmbRenk.Size = new Size(121, 23);
            cmbRenk.TabIndex = 7;
            cmbRenk.SelectedIndexChanged += cmbRenk_SelectedIndexChanged;
            // 
            // cmbKapıSayisi
            // 
            cmbKapıSayisi.FormattingEnabled = true;
            cmbKapıSayisi.Items.AddRange(new object[] { "Seçiniz", "2", "3", "4", "5" });
            cmbKapıSayisi.Location = new Point(387, 163);
            cmbKapıSayisi.Name = "cmbKapıSayisi";
            cmbKapıSayisi.Size = new Size(121, 23);
            cmbKapıSayisi.TabIndex = 8;
            cmbKapıSayisi.SelectedIndexChanged += cmbKapıSayisi_SelectedIndexChanged;
            // 
            // cmbPencereSayisi
            // 
            cmbPencereSayisi.FormattingEnabled = true;
            cmbPencereSayisi.Items.AddRange(new object[] { "4", "6", "8" });
            cmbPencereSayisi.Location = new Point(387, 214);
            cmbPencereSayisi.Name = "cmbPencereSayisi";
            cmbPencereSayisi.Size = new Size(121, 23);
            cmbPencereSayisi.TabIndex = 9;
            cmbPencereSayisi.SelectedIndexChanged += cmbPencereSayisi_SelectedIndexChanged;
            // 
            // btnBilgileriGoster
            // 
            btnBilgileriGoster.Location = new Point(389, 320);
            btnBilgileriGoster.Name = "btnBilgileriGoster";
            btnBilgileriGoster.Size = new Size(120, 33);
            btnBilgileriGoster.TabIndex = 10;
            btnBilgileriGoster.Text = "BİLGİLERİ GÖSTER";
            btnBilgileriGoster.UseVisualStyleBackColor = true;
            btnBilgileriGoster.Click += btnBilgileriGoster_Click;
            // 
            // lblYakıt
            // 
            lblYakıt.AutoSize = true;
            lblYakıt.Location = new Point(227, 269);
            lblYakıt.Name = "lblYakıt";
            lblYakıt.Size = new Size(147, 15);
            lblYakıt.TabIndex = 11;
            lblYakıt.Text = "100 km'de Yaktığı Yakıt(L) :";
            // 
            // txtYakıt
            // 
            txtYakıt.Location = new Point(388, 261);
            txtYakıt.Name = "txtYakıt";
            txtYakıt.Size = new Size(121, 23);
            txtYakıt.TabIndex = 12;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(227, 356);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(46, 15);
            lblSonuc.TabIndex = 13;
            lblSonuc.Text = "Sonuç :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSonuc);
            Controls.Add(txtYakıt);
            Controls.Add(lblYakıt);
            Controls.Add(btnBilgileriGoster);
            Controls.Add(cmbPencereSayisi);
            Controls.Add(cmbKapıSayisi);
            Controls.Add(cmbRenk);
            Controls.Add(cmbModel);
            Controls.Add(cmbMarka);
            Controls.Add(lblPencereSayisi);
            Controls.Add(lblKapıSayisi);
            Controls.Add(lblRenk);
            Controls.Add(lblModel);
            Controls.Add(lblMarka);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMarka;
        private Label lblModel;
        private Label lblRenk;
        private Label lblKapıSayisi;
        private Label lblPencereSayisi;
        private ComboBox cmbMarka;
        private ComboBox cmbModel;
        private ComboBox cmbRenk;
        private ComboBox cmbKapıSayisi;
        private ComboBox cmbPencereSayisi;
        private Button btnBilgileriGoster;
        private Label lblYakıt;
        private TextBox txtYakıt;
        private Label lblSonuc;
    }
}
