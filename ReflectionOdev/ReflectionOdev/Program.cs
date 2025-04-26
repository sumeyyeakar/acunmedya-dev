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
