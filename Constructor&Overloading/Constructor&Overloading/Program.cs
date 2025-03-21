// See https://aka.ms/new-console-template for more information
using Constructor_Overloading.Class.cs;
using Constructor_Overloading.Constructor;



Marka marka = new Marka("BMW");
Kapı kapı = new Kapı(4);
Pencere pencere = new Pencere(4);
Kasa kasa = new Kasa("Sedan");

Araba araba = new Araba(marka,kapı,pencere,kasa,"X5","2.000.000 ");
araba.yaz();

Console.WriteLine();

Matematik m = new Matematik();


Console.WriteLine("iki sayının toplamı : " + m.topla(5, 5));

Console.WriteLine ("Üç sayının toplamı: " +m.topla(5, 5, 5));

Console.WriteLine("Dört sayının toplamı: " +m.topla(5,6,7,8));



Console.WriteLine("İki sayının çarpımı : " + m.carp(7.5,3.1));

Console.WriteLine("Üç sayının çarpımı : " + m.carp(2.8,5.7,6));


//Garbage Collector: kulllanılmayan bellek alanlarını temizler
//GC, bellek dolduğu zaman veya sistemin ihtiyacı olduğunda,kullanılmayan nesneleri temizler
//bellek kullanımını daha verimli hale getirir ve geliştiricinin işini kolaylaştırır

//Generic Classlar ve Generic Methodlar
//Generic yapılar,aynı kodu farklı veri türleriyle kullanmamızı sağlar
//Boxing:bir değer tipini(mesela int) bir nesne gibi saklamak
//Unboxing:bir nesne tipine dönüştürdüğümüz değeri tekrar orjinal tipine geri almak
//Boximg ve unboxing işlemleri daha fazla bellek ve işlem gücü harcar, performansı olumsuz etkiler