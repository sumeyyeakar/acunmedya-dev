// See https://aka.ms/new-console-template for more information
using Ödev.Classes;

Console.WriteLine("Hello, World!");

Araba a = new Araba();

BMW bm = new BMW();

Mercedes me = new Mercedes();

Porsche p = new Porsche();

Audi au = new Audi();

Togg t = new Togg();

Toyota to = new Toyota();



//bmw kısmı
bm.marka = "BMW";
bm.vites = "Düz";
bm.Print();


//mercedes kısmı
me.marka = "Mercedes";
me.vites = "Otomatik";
me.Print();

p.marka = "Porsche";
p.vites = "Otomatik";
p.Print();

au.marka = "Audi";
au.vites = "Otomatik";
au.Print();

t.marka = "Togg";
t.vites = "Düz";
t.Print();

to.marka = "Toyota";
to.vites = "Düz";
to.Print();



//diğerlerine marka adı atadık ama yukarıdaki şekilde devam ettirerek istersek yazdırabiliriz.
me.marka = "Mercedes";
p.marka = "Porsche";
au.marka = "Audi";
t.marka = "Togg";
to.marka = "Toyota";



//Abstraction (Soyutlama):
//Soyutlama bir nesnenin belirli özellikleri ve gerçekleştirebileceği eylemlerle genelleştirilmesidir
//Bunu sağlamak için soyut sınıflar veya ara yüzler kullanılır.
//Polymorphism (Çok Biçimlilik):
//Çok biçimcilik aynı metot adıyla farklı işlemler yapabilmeyi sağlar. Böylece aynı kod
//farklı şekillerde çalıştırılabilir. 
//Abstract Class (Soyut Sınıf):
//Soyut sınıflar doğrudan nesne oluşturmak için değil alt sınıflara bir temel sağlamak
//amacıyla kullanılır.İçerikleri tam olarak belirlenmez ve miras alınarak kullanılır.