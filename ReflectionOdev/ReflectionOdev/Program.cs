namespace ReflectionOdev
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
