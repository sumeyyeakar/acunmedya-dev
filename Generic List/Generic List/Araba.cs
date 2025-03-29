using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_List
{
   public class Araba
    {
        public string marka { get; set; }
        public string model { get; set; }
        public double benzinHarcamasi { get; set; }
        public int toplamMesafe { get; set; }

        public Araba (string marka, string model, double benzinHarcamasi, int toplamMesafe)
        {
            this.marka = marka;
            this.model = model;
            this.benzinHarcamasi = benzinHarcamasi;
            this.toplamMesafe = toplamMesafe;
        }

        public Araba()
        {
        }

        public double toplamBenzin()
        {
            return (toplamMesafe / 100.0) * benzinHarcamasi;
        }
    }
}
