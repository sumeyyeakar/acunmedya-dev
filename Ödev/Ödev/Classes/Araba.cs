using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev.Classes
{
    public class Araba
    {
        public string marka;
        public string vites;
        public void Print()
        {
            Console.WriteLine("\n araba'nın markası = " + marka);
            Console.WriteLine("\n vites = " + vites);
            Console.WriteLine("----------------------");
        }

    }
}
