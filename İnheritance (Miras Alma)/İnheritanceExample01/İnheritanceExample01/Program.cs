using İnheritanceExample01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritanceExample01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            kedi kedi = new kedi();

            kedi.hayvan_isim = "Ares";
            kedi.hayvan_yas = 1;
            kedi.hayvan_rengi = "Sarı";
            kedi.hayvan_cinsiyet = "Erkek";
            kedi.kediPatisi = "2";
            kedi.hayvanBilgisiGoster();

            Console.ReadLine();

        }
    }
}
