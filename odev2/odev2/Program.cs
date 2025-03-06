// See https://aka.ms/new-console-template for more information
using odev2.Abstracts;
using odev2.Abstracts2;
using odev2.Classes;

Console.WriteLine("ÖDEV 1:");

Araba a = new Araba();

BMW bm = new BMW();
bm.marka = "BMW";
bm.hızlıGit(bm.marka);
bm.denizdeYuz(bm.marka);
bm.havadaUc(bm.marka);

Mercedes me = new Mercedes();
me.marka = "Mercedes";
me.denizdeYuz(me.marka);
me.havadaUc(me.marka);

Porsche po = new Porsche();
po.marka = "Porsche";
po.havadaUc(po.marka);

Console.WriteLine("------------------------------------:");


Console.WriteLine("ÖDEV 2:");


GenelMudur gm = new GenelMudur();
Mudur mu = new Mudur();
Programci pr = new Programci();
Stajyer s = new Stajyer();

double toplamMaas = 0.0;

toplamMaas += gm.maasinizNedir();
toplamMaas += mu.maasinizNedir();
toplamMaas += pr.maasinizNedir();
toplamMaas += s.maasinizNedir();

Console.WriteLine("Toplam maaş : " + toplamMaas + " TL ");
Console.WriteLine("---------------------------------");


Console.WriteLine("ÖDEV 3:");

BMW2 bm2 = new BMW2();
Mercedes2 me2 = new Mercedes2();
Porsche2 po2 = new Porsche2();


double toplamYakıt = 0.0;

toplamYakıt += bm2.yakıtTuketım();
toplamYakıt += me2.yakıtTuketım();
toplamYakıt += po2.yakıtTuketım();

Console.WriteLine("Toplam: " + toplamYakıt + " L benzin harcıyorlar");


//Array (Dizi) Nedir?
//Array'ler aynı veri tipindeki birden fazla öğeyi içerisinde
//saklayan yapılardır.