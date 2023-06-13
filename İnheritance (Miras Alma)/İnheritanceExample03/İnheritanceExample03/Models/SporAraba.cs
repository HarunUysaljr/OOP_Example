using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritanceExample03.Models
{
    internal class SporAraba : Otomobil
    {
        public override void Hızlan()
        {
            Console.WriteLine("Hizlanıyor");
        }
        public override void Yavasla()
        {
            Console.WriteLine("Hizlanıyor");
        }
    }
}
