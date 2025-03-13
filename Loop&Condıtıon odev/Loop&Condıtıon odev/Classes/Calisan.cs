using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Condıtıon_odev.Classes
{
    public abstract class Calisan
    {
        public void ekranaYaz(string isim, string soyisim, string meslegi,
            string departmani, string maaş)
        {
            Console.WriteLine("Adı:"+isim + "\nSoyadı:" +soyisim
           + "\nMesleği:"+ meslegi+ "\nDepartmanı:"+departmani+"\nMaaşı:"+maaş);
        }
        public abstract double MaasinizNedir();
       
    }
}
