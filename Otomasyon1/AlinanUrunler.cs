using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon1
{
    internal class AlinanUrunler
    {
        public int UrunStoğu { get; set; }
        public string UrnuIsmi { get; set; }

        public List<AlinanUrunler> alinanUrunlers()
        {
            return alinanUrunlers().ToList();
        }
    }
}
