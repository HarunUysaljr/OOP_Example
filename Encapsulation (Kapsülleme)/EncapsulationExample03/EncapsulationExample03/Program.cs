using EncapsulationExample03.Models;

BankaHesabi banka = new BankaHesabi("4551", 1524 );

banka.hesapBilgileriGöster();

banka.ParaYatir(2);
banka.ParaCek(1525);
banka.hesapBilgileriGöster();

/*
 İlk olarak, EncapsulationExample03.Models adında bir namespace oluşturulur.
Ardından BankaHesabi adında bir sınıf tanımlanır. Bu sınıf, bir banka hesabını temsil eder.
Sınıfın içinde, hesapNo ve bakiye adında özel (private) alanlar bulunur. 
Bu alanlar sadece sınıf içinde erişilebilir durumdadır.
HesapNo özelliği, sadece okunabilir bir şekilde tanımlanır. Dışarıdan erişim sağlanabilmesi için get erişimci kullanılır ve set erişimciye private olarak belirlenir.
HesapBakiyesi özelliği, hem okunabilir hem de yazılabilir bir şekilde tanımlanır. Hem get hem de set erişimcileri kullanılır.
BankaHesabi sınıfının bir kurucu metodu tanımlanır. Bu metot, bir hesap numarası ve başlangıç bakiyesi alır ve ilgili alanlara değerler atanır.
ParaYatir metodu, belirli bir miktar para yatırma işlemini gerçekleştirir. Miktarın 0'dan büyük olması durumunda, hesap bakiyesi bu miktar kadar artırılır.
ParaCek metodu, belirli bir miktar para çekme işlemini gerçekleştirir. Miktarın 0'dan büyük ve hesap bakiyesinden küçük veya eşit olması durumunda, hesap bakiyesi bu miktar kadar azaltılır. Aksi durumda "Geçersiz işlem!" mesajı ekrana yazdırılır.
HesapBilgileriniGoster metodu, hesap numarasını ve hesap bakiyesini ekrana yazdırır.

 */