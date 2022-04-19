using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _86DersSortedList // SortedList tıpkı Pythondaki Dictionary gibidir. Yani bir liste icerisinde (key,value) degelerini tutar.
{                           // Ayrica kendisi Keyleri alfabetik ya da kucukten buyuge dogru otomatik siralar.
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, int> siraliliste = new SortedList<string, int>();
            siraliliste.Add("Murat", 25);
            siraliliste.Add("Huseyin", 22);
            siraliliste.Add("Emir", 20);
            siraliliste.Add("Cingoz", 19);
            siraliliste.Add("Kaan", 27);

            //Console.WriteLine(siraliliste.IndexOfKey("Kaan"));
        }
    }
}
