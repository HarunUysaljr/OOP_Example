using İnheritanceExample02.Models;



Dikdortgen dikdortgen = new Dikdortgen();
dikdortgen.uzunluk = 5;
dikdortgen.genislik = 3;

Console.WriteLine("Dikdörtgenin Alanı: " + dikdortgen.alanHesapla());
Console.WriteLine("Dikdörtgenin Çevresi: " + dikdortgen.cevreHesapla());

Daire daire = new Daire();
daire.YariCap = 4;

Console.WriteLine("Dairenin Alanı: " + daire.alanHesapla());
Console.WriteLine("Dairenin Çevresi: " + daire.cevreHesapla());

Console.ReadLine();