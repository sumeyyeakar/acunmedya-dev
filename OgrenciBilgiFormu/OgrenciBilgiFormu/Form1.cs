namespace OgrenciBilgiFormu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDogrula_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.isim = txtAd.Text;
            ogr.soyisim = txtSoyad.Text;
            ogr.bolum = txtBolum.Text;


            if (!ZorunlulukKontrolu.dogrula(ogr))
            {
                MessageBox.Show("Lütfen tüm alanlarý doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Form baþarýlý!", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblSonuc.Text = "Ad: " + ogr.isim + "\n" +
                                "Soyad: " + ogr.soyisim + "\n" +
                                "Bölüm: " + ogr.bolum;
            }
        }
    }
}
