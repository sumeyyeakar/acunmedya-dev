namespace ReflectionOdev
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
            listBox1 = new ListBox();
            btnKlasorSec = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lblSonuc = new Label();
            btnOde = new Button();
            lblTutar = new Label();
            txtTutar = new TextBox();
            cmbOdemeYontemleri = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(42, 35);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(153, 109);
            listBox1.TabIndex = 0;
            // 
            // btnKlasorSec
            // 
            btnKlasorSec.Location = new Point(70, 163);
            btnKlasorSec.Name = "btnKlasorSec";
            btnKlasorSec.Size = new Size(102, 23);
            btnKlasorSec.TabIndex = 1;
            btnKlasorSec.Text = "Klasör Seçiniz";
            btnKlasorSec.UseVisualStyleBackColor = true;
            btnKlasorSec.Click += btnKlasorSec_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(btnKlasorSec);
            groupBox1.Location = new Point(23, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(255, 225);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dosya Yapısı ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblSonuc);
            groupBox2.Controls.Add(btnOde);
            groupBox2.Controls.Add(lblTutar);
            groupBox2.Controls.Add(txtTutar);
            groupBox2.Controls.Add(cmbOdemeYontemleri);
            groupBox2.Location = new Point(422, 34);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(275, 212);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ödeme Sistemi";
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(74, 158);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(20, 15);
            lblSonuc.TabIndex = 4;
            lblSonuc.Text = "\" \"";
            // 
            // btnOde
            // 
            btnOde.Location = new Point(150, 108);
            btnOde.Name = "btnOde";
            btnOde.Size = new Size(75, 23);
            btnOde.TabIndex = 3;
            btnOde.Text = "ÖDE";
            btnOde.UseVisualStyleBackColor = true;
            btnOde.Click += btnOde_Click;
            // 
            // lblTutar
            // 
            lblTutar.AutoSize = true;
            lblTutar.Location = new Point(22, 71);
            lblTutar.Name = "lblTutar";
            lblTutar.Size = new Size(68, 15);
            lblTutar.TabIndex = 2;
            lblTutar.Text = "Tutar Girin :";
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(125, 63);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(100, 23);
            txtTutar.TabIndex = 1;
            // 
            // cmbOdemeYontemleri
            // 
            cmbOdemeYontemleri.FormattingEnabled = true;
            cmbOdemeYontemleri.Items.AddRange(new object[] { "Seçiniz", "Kredi Kartı", "Havale", " EFT" });
            cmbOdemeYontemleri.Location = new Point(18, 27);
            cmbOdemeYontemleri.Name = "cmbOdemeYontemleri";
            cmbOdemeYontemleri.Size = new Size(121, 23);
            cmbOdemeYontemleri.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button btnKlasorSec;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox cmbOdemeYontemleri;
        private Button btnOde;
        private Label lblTutar;
        private TextBox txtTutar;
        private Label lblSonuc;
    }
}
