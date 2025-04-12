namespace Araba_Form
{
    public partial class Form1 : Form
    {
        string marka = "";
        string model = "";
        string renk = "";
        string pencereSayisi = "";
        string kap�Sayisi = "";
        string Yak�t = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void lblMarka_Click(object sender, EventArgs e)
        {

        }

        private void btnBilgileriGoster_Click(object sender, EventArgs e)
        {
            //TextBox dan yak�t bilgisi ald�k
            string yak�t = txtYak�t.Text;
            lblSonuc.Text = "Kaydedilen araban�n markas� : " + marka + "\n" +
                "Modeli : " + model + "\n" +
                "Rengi : " + renk + "\n" +
                "Kap� Say�s� : " + kap�Sayisi + "\n" +
                "Pencere Say�s� : " + pencereSayisi + "\n" +
                "100 km'de Yakt��� Yak�t : " + yak�t;
        }

        private void cmbRenk_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Kulllan�c� renk ComboBox �ndan bir renk se�ti�inde renk bilgisi de�i�kene atan�r
            renk = cmbRenk.SelectedItem.ToString();
        }

        private void cmbKap�Sayisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se�ilen kap� say�s� de�i�kene atan�r(ComboBox �zerinden)
            kap�Sayisi = cmbKap�Sayisi.SelectedItem.ToString();
        }

        private void cmbPencereSayisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se�ilen pencere say�s� bilgisi de�i�kene atan�r(ComboBox �zerinden)
            pencereSayisi = cmbPencereSayisi.SelectedItem.ToString();
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Se�ilen marka ad� de�i�kene atan�r(ComboBox �zerinden)
            marka = cmbMarka.SelectedItem.ToString();
        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se�ilen model de�i�kene atan�r(ComboBox �zerinden)
            model = cmbModel.SelectedItem.ToString();
        }
    }
}
