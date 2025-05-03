using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiFormu
{
    public static class ZorunlulukKontrolu
    {
        public static bool dogrula(object dogrulanacakObje)
        {
            Type dogrulanacakTur = dogrulanacakObje.GetType();
            FieldInfo[] dogrulanacakTurAlanlari = dogrulanacakTur.GetFields(
                                                    BindingFlags.Public |
                                                    BindingFlags.Instance);
            foreach (FieldInfo dogrulanacakTurAlani in dogrulanacakTurAlanlari)
            {
                object[] zorunluAlanOznitelikleri = dogrulanacakTurAlani.GetCustomAttributes(typeof(ZorunluAlanAttribute), true);
                if (zorunluAlanOznitelikleri.Length != 0)
                {
                    string alanDegeri = dogrulanacakTurAlani.GetValue(dogrulanacakObje) as string;
                    if (string.IsNullOrEmpty(alanDegeri))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
