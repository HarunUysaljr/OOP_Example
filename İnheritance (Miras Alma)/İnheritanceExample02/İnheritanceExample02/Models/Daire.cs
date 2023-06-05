using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritanceExample02.Models
{
    public class Daire : Dikdortgen
    {
        public double YariCap { get; set; }

        public override double alanHesapla()
        {
            return Math.PI * Math.Pow(YariCap, 2);
        }

        public override double cevreHesapla()
        {
            return 2 * Math.PI * YariCap;
        }

    }
}
