using İnheritanceExample04.Models;

Musteri musteri = new Musteri();

musteri.ad = "harun";
musteri.soyAd = "uysal";
musteri.eposta = "aaba";

Console.WriteLine("-------------");

BireyselMusteri bireyselmusteri = new BireyselMusteri();

bireyselmusteri.ad = "harunbireysel";
bireyselmusteri.soyAd = "harunbireysel";
bireyselmusteri.eposta = "harunbireysel";
bireyselmusteri.referans = "harunbireysel";

    Console.WriteLine("-------------------");

KurumsalMusteri kurumsal = new KurumsalMusteri();

kurumsal.ad = "kurumharund";
kurumsal.soyAd = "kurumharund";
kurumsal.eposta = "kurumharund";
kurumsal.sirketAdı = "kurumharund";

Console.WriteLine("Kurumsal Müşteri: " + kurumsal.ad + " " + kurumsal.soyAd);
Console.WriteLine("Şirket Adı: " + kurumsal.sirketAdı);
Console.WriteLine("Vergi No: " + kurumsal.eposta);
Console.WriteLine("-------------------");
Console.WriteLine("\nBireysel Müşteri: " + bireyselmusteri.ad + " " + bireyselmusteri.soyAd);
Console.WriteLine("TC Kimlik No: " + bireyselmusteri.referans);



