using odev2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2.Classes
{
    public class BMW : Araba, IHızlıGit, IDenizdeYuz, IHavadaUc
    {
        internal double Yakıt;

        public void denizdeYuz(string marka)
        {
            Console.WriteLine(marka + " denizde yüzer");
        }

        public void havadaUc(string marka)
        {
            Console.WriteLine(marka + " havada uçar");
        }

        public void hızlıGit(string marka)
        {
            Console.WriteLine(marka + " hızlı gider");
        }
    }
}
