using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample01.Models
{
    internal class Customer
    {
        private string _FirstName;
        private int _Id;
        private string _LastName;


        public int Id {
            get { return _Id; }
            set { _Id = value; }
        }
        //Mevcutta Bir Id Tutar proplardan dönen ismi Private Olana atamaktadır.


        public string FirstName
        { 
            get { return _FirstName; } 
            set { _FirstName = value; } 
        }
        //Mevcutta Bir İsim Tutar proplardan dönen ismi Private Olana atamaktadır.
        /*
         *  get { return "Sayın : " + _FirstName; }
         *  olarak eklendiğinde ismin başına sayın       gelir
         */

        public string SoyAd
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
        //Mevcutta Bir Soyisim Tutar proplardan dönen ismi Private Olana atamaktadır.


        //bir field üzerinde değeri okurken veya değeri verirken bu şekilde yapılabilmektedir
        //"İmplementasyon gizlenmesi" Auto Property Özelliği ile 
    }
}
