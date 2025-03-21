using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Overloading.Constructor
{
    public class Araba
    {
        public Marka marka;     
        public Kapı kapı;     
        public Pencere pencere; 
        public Kasa kasa;
        public string model;
        public string fiyat;

        public Araba(Marka marka, Kapı kapı, Pencere pencere, Kasa kasa,string model,string fiyat)
        {
            this.marka = marka;
            this.kapı = kapı;
            this.pencere = pencere;
            this.kasa = kasa;
            this.model = model;
            this.fiyat = fiyat;
        }
        public void yaz()
        {
            Console.WriteLine("Arabanın markası:" +marka.markaAdi +
                              " modeli:" +model +
                              " kapı sayısı:" +kapı.kapıSayısı +
                              " pencere sayısı:" +pencere.pencereSayisi +
                              " kasası:" +kasa.tipi +
                              " fiyatı:" +fiyat);
        }

    }
}
