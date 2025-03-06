using odev2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2.Classes
{
    public class Porsche : Araba, IHavadaUc
    {
        public void havadaUc(string marka)
        {
            Console.WriteLine(marka + " havada uçar");
        }
    }
}
