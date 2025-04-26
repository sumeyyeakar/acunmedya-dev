using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionOdev.Ödeme_Sistemi
{
    public class KrediKarti : IOdemeYontemi
    {
        public string Ode(decimal tutar)
        {
            return "Kredi kartı ile " + tutar + " ödendi";
        }
    }
}
