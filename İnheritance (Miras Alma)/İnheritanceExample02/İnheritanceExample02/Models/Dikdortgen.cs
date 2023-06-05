using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritanceExample02.Models
{
    public class Dikdortgen : GeometrikSekil
    {
        public double uzunluk { get; set; }
        public double genislik { get; set; }


        public override double alanHesapla()
        {
            return uzunluk * genislik;
        }

        public override double cevreHesapla()
        {
            return 2 * (uzunluk + genislik);
        }
    }
}

