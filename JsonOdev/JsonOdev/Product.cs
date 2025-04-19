using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonOdev
{
    [Serializable]
    public class Product
    {
        public string Name;
        public DateTime expryDate;
        public decimal price;
        public string Brand;
    }
}
