// OnlineAlisverisUygulamasi sınıfından bir örnek oluşturuluyor
using Shopping.Models;

ShoppingApp uygulama = new ShoppingApp("kullanici123", "sifre123");

// Kullanıcı adı ve şifreye erişim sağlanıyor
Console.WriteLine("Kullanıcı Adı: " + uygulama.CustomerName);
Console.WriteLine("Şifre: " + uygulama.CustomerPassword);

// Ürünler sepete ekleniyor
uygulama.UrunEkle("Telefon");
uygulama.UrunEkle("Bilgisayar");
uygulama.UrunEkle("Televizyon");

// Sepet içeriği gösteriliyor
uygulama.SepetiGoster();

Console.ReadLine();