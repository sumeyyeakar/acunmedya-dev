// See https://aka.ms/new-console-template for more information

using Generic_List;

public class Program
{
    static void Main(string[] arg)
    {
        List<Araba> arabalar = new List<Araba>();
        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine("Marka:");
            string marka = Console.ReadLine();

            Console.WriteLine("Model:");
            string model = Console.ReadLine();

            Console.WriteLine("100 km de yaktığı yakıt:");
            double benzinHarcamasi = double.Parse(Console.ReadLine());

            Console.WriteLine("Toplam mesafe:");
            int toplamMesafe = int.Parse(Console.ReadLine());

            Araba araba = new Araba()
            {
                marka = marka,
                model = model,
                benzinHarcamasi = benzinHarcamasi,
                toplamMesafe = toplamMesafe

            };
            arabalar.Add(araba);
            Console.WriteLine();

        }
        Console.WriteLine("Arabaların toplam yakıt tüketimleri:");
        for(int i = 0; i < arabalar.Count; i++)
        {
            Araba araba = arabalar [i];
            double toplamBenzin = araba.toplamBenzin();
            Console.WriteLine($"Marka:{araba.marka},Model:{araba.model},100 km de yaktığı yakıt:{araba.benzinHarcamasi},Toplam yakıt tüketimi:{toplamBenzin}");

        }
    }
}

//Görsel Programlama Nedir?
//Görsel programlama, kod yazmak yerine grafiksel araçlar kullanarak uygulama tasarımı yapmayı sağlayan bir tekniktir.
//burada öğeler görsel olarak yerleştirilir ve davranışları belirlenir.

//Metin tabanlı programlamadan farkları nelerdir?
//En büyük fark yazılım geliştirmede kullandıkları araçlardır.
//Metin tabanlıda kod yazarak uygulamalarını oluştururlar
//Görsel programlamada ise,
//yazılım geliştirmek için daha çok sürükle-bırak gibi yöntemler kullanılır. 
//görsel programlama daha hızlı ve kolay olabilir
//ama daha sınırlıdır, çünkü görsel öğelerle işlem yaparken çok derinlemesine özelleştirme ve detaylara inme şansı azdır.
//fakat metin tabanlı programlama daha güçlü ve esnektir.
//Programcı, her kod satırını kontrol eder ve çok özel işlevler yazabilir.