using Microsoft.VisualBasic.ApplicationServices;
using ReflectionOdev.�deme_Sistemi;
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
            string anaKlasor = @"C:\Users\�mer\Desktop\acunmedya\ReflectionOdev";
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
                    lblSonuc.Text = "Ge�erli bir tutar giriniz.";
                    return;
                }

                if (secilenTip == null)
                {
                    lblSonuc.Text = "Se�ilen �deme y�ntemi bulunamad�.";
                    return;
                }

                var nesne = Activator.CreateInstance(secilenTip) as IOdemeYontemi;
                if (nesne == null)
                {
                    lblSonuc.Text = "Nesne olu�turulamad�.";
                    return;
                }

                string sonuc = nesne.Ode(tutar);
                lblSonuc.Text = sonuc;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata olu�tu:\n" + ex.Message);
            }
        }
    }
}



//Attribute:s�n�f, metot, property gibi yap�larla ilgili ek bilgi sa�lar.
//Nerelerde ve Neden Kullan�l�r?
//genellikle program�m�zda baz� �zellikleri belirtmek ya da kontrol etmek i�in kullan�l�r
//[Obsolete]:o ��enin eski oldu�unu ve yerine ba�ka bir �ey kullan�lmas�n�n gerekti�ini bildirir.
//[Required]: �zellikle veri do�rulama (validation) i�lemlerinde kullan�l�r
//�rne�in, bir formda kullan�c�dan bir alan�n bo� b�rak�lmamas� isteniyorsa 

//Kendi �zel attribute'umuzu olu�turmak i�in:
//bir s�n�f yazmam�z ve bu s�n�f� Attribute s�n�f�ndan t�retmemiz gerekir. 

//Bir Attribute Nas�l Okunur (Reflection ile)
//Reflection, program�m�z�n �al��ma zaman�nda kendisi hakk�nda bilgi almas�n� sa�layan bir tekniktir
//Attribute�lar� okumak i�in GetCustomAttributes() metodunu kullanabiliriz.
/*

public class Program
{
    [Obsolete("Bu metot eski, yeni metodu kullan�n.")]
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

Attribute'lar ile Veri Do�rulama (Validation) Nas�l Yap�labilir?
Veri do�rulama (validation) i�in attribute�lar, �rne�in [Required], 
kullan�c�dan al�nan verilerin ge�erli olup olmad���n� kontrol etmek i�in kullan�l�r.
*/




