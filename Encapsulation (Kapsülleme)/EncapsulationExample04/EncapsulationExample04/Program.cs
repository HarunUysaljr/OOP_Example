using EncapsulationExample04.Models;

Song song = new Song();


song.Title = "Gülpembe";
song.Artist = "Barış Manço";
song.Duration = TimeSpan.FromSeconds(54);

Console.WriteLine($"Şarkı: {song.Title} - {song.Artist}");
Console.WriteLine($"Süresi: {song.Duration}");

song.Oynat();

Console.WriteLine("Durdurmak için bir tuşa basınız....");
Console.ReadKey();

Console.WriteLine("");

song.Duraklat();


Console.ReadLine();

