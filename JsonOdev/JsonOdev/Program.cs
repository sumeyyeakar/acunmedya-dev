namespace JsonOdev
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
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

