namespace OgrenciBilgiFormu
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
            lblAd = new Label();
            lblSoyad = new Label();
            lblBolum = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtBolum = new TextBox();
            btnDogrula = new Button();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(248, 71);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(29, 15);
            lblAd.TabIndex = 0;
            lblAd.Text = "AD :";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(248, 147);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(50, 15);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "SOYAD :";
            // 
            // lblBolum
            // 
            lblBolum.AutoSize = true;
            lblBolum.Location = new Point(248, 222);
            lblBolum.Name = "lblBolum";
            lblBolum.Size = new Size(54, 15);
            lblBolum.TabIndex = 2;
            lblBolum.Text = "BÖLÜM :";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(377, 63);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(136, 23);
            txtAd.TabIndex = 3;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(377, 139);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(136, 23);
            txtSoyad.TabIndex = 4;
            // 
            // txtBolum
            // 
            txtBolum.Location = new Point(377, 214);
            txtBolum.Name = "txtBolum";
            txtBolum.Size = new Size(136, 23);
            txtBolum.TabIndex = 5;
            // 
            // btnDogrula
            // 
            btnDogrula.BackColor = SystemColors.ActiveCaption;
            btnDogrula.Location = new Point(484, 263);
            btnDogrula.Name = "btnDogrula";
            btnDogrula.Size = new Size(121, 47);
            btnDogrula.TabIndex = 6;
            btnDogrula.Text = "Bilgileri Doğrula";
            btnDogrula.UseVisualStyleBackColor = false;
            btnDogrula.Click += btnDogrula_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Font = new Font("Segoe UI", 10F);
            lblSonuc.Location = new Point(248, 304);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(130, 19);
            lblSonuc.TabIndex = 7;
            lblSonuc.Text = "Öğrencinin Bilgileri :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSonuc);
            Controls.Add(btnDogrula);
            Controls.Add(txtBolum);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(lblBolum);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private Label lblSoyad;
        private Label lblBolum;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtBolum;
        private Button btnDogrula;
        private Label lblSonuc;
    }
}
