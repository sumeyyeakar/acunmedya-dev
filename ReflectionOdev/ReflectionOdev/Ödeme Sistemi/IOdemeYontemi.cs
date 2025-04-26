using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionOdev.Ödeme_Sistemi
{
    public interface IOdemeYontemi
    {
        string Ode(decimal tutar);
    }
}
