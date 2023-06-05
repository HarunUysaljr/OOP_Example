using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritanceExample01.Models
{
    public class Hayvan
    {
        public string hayvan_isim;
        public string hayvan_cinsiyet;
        public string hayvan_rengi;
        public int hayvan_yas;
        public void hayvanBilgisiGoster()
        {
            Console.WriteLine(hayvan_isim);
            Console.WriteLine(hayvan_cinsiyet);
            Console.WriteLine(hayvan_rengi);
            Console.WriteLine(hayvan_yas);
        }
    }
}
