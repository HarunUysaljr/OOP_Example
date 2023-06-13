using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritanceExample03.Models
{
    public class Otomobil
    {
        public virtual void Hızlan()
        {
            Console.WriteLine("Hizlanıyor");
        }
        public virtual void Yavasla()
        {
            Console.WriteLine("Yavaşlıyor");
        }

    }
}
