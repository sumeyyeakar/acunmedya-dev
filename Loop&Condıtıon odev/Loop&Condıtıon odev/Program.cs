// See https://aka.ms/new-console-template for more information

using Loop_Condıtıon_odev.Classes;

Console.WriteLine("Yaşınızı Giriniz: ");
int yas = int.Parse(Console.ReadLine());

if (yas >= 0 && yas < 18)
{
    Console.WriteLine("küçüksünüz");
}
else if (yas >= 18 && yas < 35)
{
    Console.WriteLine("gençsiniz");
}
else if (yas >= 35 && yas < 55)
{
    Console.WriteLine("yetişkinsiniz");
}
else if(yas>=55 && yas < 75)
{
    Console.WriteLine("yaşlısınız");
}
else if(yas>=75 && yas < 99)
{
    Console.WriteLine("çok yaşlısınız");
}
else
{
    Console.WriteLine("ya hiç doğmadınız ya da çoktan öldünüz");
}
Console.WriteLine("-------------------------------------------");


Console.WriteLine("Arabanın yaşını giriniz: ");
int arabayas = int.Parse(Console.ReadLine());

if(arabayas>=0 && arabayas < 10)
{
    Console.WriteLine("Arabanız yeni");
}
else if(arabayas>=10 && arabayas < 20)
{
    Console.WriteLine("Servise götürmeniz gerekebilir");
}
else if(arabayas>=20 && arabayas < 30)
{
    Console.WriteLine("Arabanız hurdaya çıkabilir");
}
else
{
    Console.WriteLine("Ya hiç üretilmedi ya da trafikten men edilmiştir");
}


Console.WriteLine("----------------------------------------");

GenelMudur gm = new GenelMudur();
gm.ekranaYaz("Ali", "Yıldız","Genel Müdür", "Yönetim","80.000");
Console.WriteLine();

Mudur mu = new Mudur();
mu.ekranaYaz("Veli", "Tuna", "Müdür", "Yönetim","60.000");
Console.WriteLine();

Programci pr = new Programci();
pr.ekranaYaz("Ayşe", "Kolay","Programcı","Yazılım","40.000");
Console.WriteLine();

Stajyer s = new Stajyer();
s.ekranaYaz("Mehmet","Yıldız","Stajyer","Destek","5.000");
Console.WriteLine();


double toplamMaas = 0.0;
Calisan[] calisanlar = {gm,mu,pr,s };
for (int i = 0; i < calisanlar.Length; i++)
{
    toplamMaas += calisanlar[i].MaasinizNedir();
}

 Console.WriteLine("Toplam:" +toplamMaas + " TL maaş alıyorlar");
 Console.WriteLine("-------------------------------------");


BMW bm = new BMW();
Mercedes me = new Mercedes();
Toyota to = new Toyota();

double toplamYakıt = 0.0;
Araba[] arabalar = { bm, me, to };
for(int i = 0; i < arabalar.Length; i++)
{
    toplamYakıt += arabalar[i].yakıtTuketım();
}

Console.WriteLine("Toplam "+toplamYakıt+"litre yakıt tüketiyorlar");


