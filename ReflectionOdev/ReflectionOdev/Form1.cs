using Microsoft.VisualBasic.ApplicationServices;
using ReflectionOdev.Ödeme_Sistemi;
using System;
using System.IO;
using System.Windows.Forms;

namespace ReflectionOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void btnKlasorSec_Click(object sender, EventArgs e)
        {
            string anaKlasor = @"C:\Users\Ömer\Desktop\acunmedya\ReflectionOdev";
            listBox1.Items.Clear();
            KlasorleriTara(anaKlasor);

        }

        private void KlasorleriTara(string anaKlasor)
        {

            string[] altKlasorler = Directory.GetDirectories(anaKlasor);

            foreach (string klasor in altKlasorler)
            {
                string klasorAdi = Path.GetFileName(klasor);
                listBox1.Items.Add(klasorAdi);


                string[] csDosyalari = Directory.GetFiles(klasor, "*.cs");

                foreach (string dosya in csDosyalari)
                {
                    string[] satirlar = File.ReadAllLines(dosya);

                    foreach (string satir in satirlar)
                    {
                        if (satir.Contains("class "))
                        {
                            string classAdi = satir.Trim().Split(' ')[2];
                            listBox1.Items.Add("   " + classAdi);
                            break;
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var odemeYontemleri = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(t => typeof(IOdemeYontemi).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
                .ToList();

            cmbOdemeYontemleri.DisplayMember = "Name";
            cmbOdemeYontemleri.Items.Clear();

            foreach (var yontem in odemeYontemleri)
            {
                cmbOdemeYontemleri.Items.Add(yontem); 
            }

            if (cmbOdemeYontemleri.Items.Count > 0)
                cmbOdemeYontemleri.SelectedIndex = 0;
        }

        
        private void btnOde_Click(object sender, EventArgs e)
        { 
            try
            {
                var secilenTip = cmbOdemeYontemleri.SelectedItem as Type;
                decimal tutar;

                if (!decimal.TryParse(txtTutar.Text, out tutar))
                {
                    lblSonuc.Text = "Geçerli bir tutar giriniz.";
                    return;
                }

                if (secilenTip == null)
                {
                    lblSonuc.Text = "Seçilen ödeme yöntemi bulunamadý.";
                    return;
                }

                var nesne = Activator.CreateInstance(secilenTip) as IOdemeYontemi;
                if (nesne == null)
                {
                    lblSonuc.Text = "Nesne oluþturulamadý.";
                    return;
                }

                string sonuc = nesne.Ode(tutar);
                lblSonuc.Text = sonuc;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu:\n" + ex.Message);
            }
        }
    }
}



//Attribute:sýnýf, metot, property gibi yapýlarla ilgili ek bilgi saðlar.
//Nerelerde ve Neden Kullanýlýr?
//genellikle programýmýzda bazý özellikleri belirtmek ya da kontrol etmek için kullanýlýr
//[Obsolete]:o öðenin eski olduðunu ve yerine baþka bir þey kullanýlmasýnýn gerektiðini bildirir.
//[Required]: özellikle veri doðrulama (validation) iþlemlerinde kullanýlýr
//Örneðin, bir formda kullanýcýdan bir alanýn boþ býrakýlmamasý isteniyorsa 

//Kendi özel attribute'umuzu oluþturmak için:
//bir sýnýf yazmamýz ve bu sýnýfý Attribute sýnýfýndan türetmemiz gerekir. 

//Bir Attribute Nasýl Okunur (Reflection ile)
//Reflection, programýmýzýn çalýþma zamanýnda kendisi hakkýnda bilgi almasýný saðlayan bir tekniktir
//Attribute’larý okumak için GetCustomAttributes() metodunu kullanabiliriz.
/*

public class Program
{
    [Obsolete("Bu metot eski, yeni metodu kullanýn.")]
    public void EskiMetot() { }

    public static void Main()
    {
        var program = new Program();

        var method = typeof(Program).GetMethod("EskiMetot");

        var attribute = (ObsoleteAttribute)Attribute.GetCustomAttribute(method, typeof(ObsoleteAttribute));

        if (attribute != null)
        {
            Console.WriteLine(attribute.Message);
        }
    }

Attribute'lar ile Veri Doðrulama (Validation) Nasýl Yapýlabilir?
Veri doðrulama (validation) için attribute’lar, örneðin [Required], 
kullanýcýdan alýnan verilerin geçerli olup olmadýðýný kontrol etmek için kullanýlýr.
*/




