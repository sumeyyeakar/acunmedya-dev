using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionOdev.Ödeme_Sistemi
{
    public class EFT : IOdemeYontemi
    {
        public string Ode(decimal tutar)
        {
            return "EFT ile " + tutar + " işlem tamamlandı";

        }
    }
}
