using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritanceExample03.Models
{
    internal class SUV : Otomobil
    {
        public void Hızlan()
        {
            Console.WriteLine("Hizlanıyor");
        }
        public void Yavasla()
        {
            Console.WriteLine("Hizlanıyor");
        }
    }
}
