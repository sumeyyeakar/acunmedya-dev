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
                using (StreamWriter sw = new StreamWriter(@"C:\Users\�mer\Desktop\acunmedya\CMT17OOP\product.json"))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    jsonSerializer.Serialize(writer, products);
                    MessageBox.Show("Serile�tirme tamamland� ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata olu�tu : " + ex.Message.ToString());

            }
        }

        private void btnJsonOku_Click(object sender, EventArgs e)
        {
            try
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                using (StreamReader sr = new StreamReader(@"C:\Users\�mer\Desktop\acunmedya\CMT17OOP\product.json"))
                using (JsonReader reader = new JsonTextReader(sr))

                {
                    List<Product> products = jsonSerializer.Deserialize<List<Product>>(reader);

                    foreach (var product in products)
                    {

                        txtUrunAd.Text = product.Name;
                        txtF�yat.Text = Convert.ToString(product.price);
                        txtMarka.Text = product.Brand;
                        dtp1.Value = product.expryDate;
                    }

                    MessageBox.Show("Json Okuma tamamland�");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata olu�tu : " + ex.Message.ToString());
            }
        }
    }

}

//Reflection nedir?
//Reflection, program �al���rken  s�n�flar, metodlar, �zellikler (properties)
//gibi yap�lar hakk�nda bilgi almak ve i�lem yapmak i�in kullan�l�r
//�zellikle:
//JSON d�n���mleri
//Otomatik UI olu�turma
//�zellik tabanl� validasyon sistemleri
//Geli�mi� loglama
//ORM(Entity Framework gibi) sistemlerde kullan�l�r.

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

        Console.WriteLine("Ogrenci s�n�f�ndaki �zellikler:");

        foreach (PropertyInfo ozellik in tip.GetProperties())
        {
            Console.WriteLine($"- {ozellik.Name} ({ozellik.PropertyType.Name})");
        }
    }
}
*/

