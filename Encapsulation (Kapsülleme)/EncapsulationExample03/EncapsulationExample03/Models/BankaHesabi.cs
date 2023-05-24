using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample03.Models
{
    internal class BankaHesabi
    {
        private string hesapNo;
        private decimal bakiye;
        public string HesapNo {
            get { return hesapNo; }
            private set { hesapNo = value; } 
        }

        public decimal HesapBakiyesi { 
            get { return bakiye; }
            set { bakiye = value; } }


        public  BankaHesabi(string hesapNo, decimal baslangicBakiyesi)
        {
            HesapNo = hesapNo;
            HesapBakiyesi = baslangicBakiyesi;
        }

        public void ParaYatir(decimal miktar)
        {
            if (miktar > 0)
            {
                HesapBakiyesi += miktar;
            }
        }

        public void ParaCek(decimal miktar)
        {
            if (miktar > 0 && miktar <= HesapBakiyesi)
                HesapBakiyesi -= miktar;
            else
                Console.WriteLine("Geçersiz işlem!");
        }

        public void hesapBilgileriGöster()
        {
            Console.WriteLine(HesapNo);
            Console.WriteLine(HesapBakiyesi);
        }
    }
}

