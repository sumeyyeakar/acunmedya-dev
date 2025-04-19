using Newtonsoft.Json;
using System.Reflection;
using System.Xml.Serialization;

namespace JsonOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJsonOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                List<Product> products = new List<Product>();
                products.Add(new Product
                {
                    Name = "Lenovo L340",
                    price = 50000,
                    expryDate = DateTime.Now,
                    Brand = "Lenovo"
                });


                products.Add(new Product
                {
                    Name = "Logitech G915",
                    price = 10000,
                    expryDate = DateTime.Now,
                    Brand = "Logitech"
                });
                products.Add(new Product
                {
                    Name = "Iphone 15",
                    price = 60000,
                    expryDate = DateTime.Now,
                    Brand = "Apple"

                });


                JsonSerializer jsonSerializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(@"C:\Users\Ömer\Desktop\acunmedya\CMT17OOP\product.json"))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    jsonSerializer.Serialize(writer, products);
                    MessageBox.Show("Serileþtirme tamamlandý ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu : " + ex.Message.ToString());

            }
        }

        private void btnJsonOku_Click(object sender, EventArgs e)
        {
            try
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                using (StreamReader sr = new StreamReader(@"C:\Users\Ömer\Desktop\acunmedya\CMT17OOP\product.json"))
                using (JsonReader reader = new JsonTextReader(sr))

                {
                    List<Product> products = jsonSerializer.Deserialize<List<Product>>(reader);

                    foreach (var product in products)
                    {

                        txtUrunAd.Text = product.Name;
                        txtFýyat.Text = Convert.ToString(product.price);
                        txtMarka.Text = product.Brand;
                        dtp1.Value = product.expryDate;
                    }

                    MessageBox.Show("Json Okuma tamamlandý");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu : " + ex.Message.ToString());
            }
        }
    }

}

//Reflection nedir?
//Reflection, program çalýþýrken  sýnýflar, metodlar, özellikler (properties)
//gibi yapýlar hakkýnda bilgi almak ve iþlem yapmak için kullanýlýr
//Özellikle:
//JSON dönüþümleri
//Otomatik UI oluþturma
//Özellik tabanlý validasyon sistemleri
//Geliþmiþ loglama
//ORM(Entity Framework gibi) sistemlerde kullanýlýr.

/*
public class Ogrenci
{
    public string Ad { get; set; }
    public int Yas { get; set; }
    public string Bolum { get; set; }
}

class Program
{
    static void Main()
    {
        Type tip = typeof(Ogrenci);

        Console.WriteLine("Ogrenci sýnýfýndaki özellikler:");

        foreach (PropertyInfo ozellik in tip.GetProperties())
        {
            Console.WriteLine($"- {ozellik.Name} ({ozellik.PropertyType.Name})");
        }
    }
}
*/

