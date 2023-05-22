using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample02.Models
{
    internal class Ogrenci
    {
        private string _StudentName;
        private int _StudentAge;
        public string StudentName {
            get { return _StudentName; }
            set { _StudentName = value;  } 
        }

        public int StudentAge {
            get { return _StudentAge;  }
            set {
                if (value >= 0)
                {
                    _StudentAge = value;
                }  else
                {
                    Console.WriteLine("Geçersiz yaş değeri girdiniz!");
                }
            } 
        }

        public void BilgileriGoster()
        {
            Console.WriteLine("Öğrencinin Adı : \n" + _StudentName + "" +
                "\nÖğrencinin Yaşı: \n" + _StudentAge);
        }
    }
}
