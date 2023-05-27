using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Models
{
    internal class ShoppingApp
    {
        private string _CustomerName;
        private string _CustomerPassword;
        private string[] _CustomerBasket;


        public string CustomerName {
            get { return _CustomerName; }
            set { _CustomerName = value; }
        }

        public string CustomerPassword
        {
            get { return _CustomerPassword; }
            set { _CustomerPassword = value; }
        }

        public string[] CustomerBasket
        {
            get { return _CustomerBasket; }
            set { _CustomerBasket = value; }
        }

        public ShoppingApp(string customerName, string customerPassword)
        {
            this._CustomerName = customerName;
            this._CustomerPassword = customerPassword;
            this.CustomerBasket = new string[0];
        }



        public void UrunEkle(string urunAdi)
        {
            Array.Resize(ref _CustomerBasket, _CustomerBasket.Length + 1);
            _CustomerBasket[_CustomerBasket.Length - 1] = urunAdi;
            Console.WriteLine(urunAdi + " sepete eklendi.");
        }

        public void SepetiGoster()
        {
            Console.WriteLine("Sepetinizdeki ürünler:");
            foreach (string urun in _CustomerBasket)
            {
                Console.WriteLine(urun);
            }
        }

    }
}

/*
 Ayrıca, sepete ürün eklemek için UrunEkle() ve sepeti göstermek için SepetiGoster() adında iki metot tanımlayın. UrunEkle() metodu, sepet dizisine yeni bir ürün eklesin ve SepetiGoster() metodu, sepet içindeki ürünleri ekrana yazdırsın."

Bu soruyu çözebilmeniz için bir OnlineAlisverisUygulamasi sınıfı oluşturmanız ve belirtilen özellikleri ve işlemleri içermesini sağlamanız gerekmektedir. */