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

