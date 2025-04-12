namespace Araba_Form
{
    public partial class Form1 : Form
    {
        string marka = "";
        string model = "";
        string renk = "";
        string pencereSayisi = "";
        string kapýSayisi = "";
        string Yakýt = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void lblMarka_Click(object sender, EventArgs e)
        {

        }

        private void btnBilgileriGoster_Click(object sender, EventArgs e)
        {
            //TextBox dan yakýt bilgisi aldýk
            string yakýt = txtYakýt.Text;
            lblSonuc.Text = "Kaydedilen arabanýn markasý : " + marka + "\n" +
                "Modeli : " + model + "\n" +
                "Rengi : " + renk + "\n" +
                "Kapý Sayýsý : " + kapýSayisi + "\n" +
                "Pencere Sayýsý : " + pencereSayisi + "\n" +
                "100 km'de Yaktýðý Yakýt : " + yakýt;
        }

        private void cmbRenk_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Kulllanýcý renk ComboBox ýndan bir renk seçtiðinde renk bilgisi deðiþkene atanýr
            renk = cmbRenk.SelectedItem.ToString();
        }

        private void cmbKapýSayisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Seçilen kapý sayýsý deðiþkene atanýr(ComboBox üzerinden)
            kapýSayisi = cmbKapýSayisi.SelectedItem.ToString();
        }

        private void cmbPencereSayisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Seçilen pencere sayýsý bilgisi deðiþkene atanýr(ComboBox üzerinden)
            pencereSayisi = cmbPencereSayisi.SelectedItem.ToString();
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçilen marka adý deþiþkene atanýr(ComboBox üzerinden)
            marka = cmbMarka.SelectedItem.ToString();
        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Seçilen model deðiþkene atanýr(ComboBox üzerinden)
            model = cmbModel.SelectedItem.ToString();
        }
    }
}
