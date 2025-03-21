using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Overloading.Class.cs
{
    public class Matematik
    {
        public int topla(int sayi1, int sayi2)
        {
            int sonuc = 0;
            sonuc = sayi1 + sayi2;
            return sonuc;
        }

        public int topla(int sayi1, int sayi2, int sayi3)
        {
            return sayi1 + sayi2 + sayi3;
        }

        public int topla(int sayi1, int sayi2, int sayi3,int sayi4)
        {
            return sayi1 + sayi2 + sayi3 + sayi4;
        }

        public double carp(double sayi1, double sayi2)
        {
            return sayi1*sayi2;
        }

        public double carp(double sayi1,double sayi2,double sayi3)
        {
            double sonuc = 0;
            sonuc = sayi1 * sayi2 * sayi3;
            return sonuc;
        }
     
    }
}
