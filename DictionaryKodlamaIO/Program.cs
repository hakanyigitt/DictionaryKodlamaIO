using System;
using System.Collections.Generic;

namespace DictionaryKodlamaIO
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> ogrenci = new MyDictionary<int, string>();
            Console.WriteLine(ogrenci.Count);
            ogrenci.Add(28, "Hakan");
            ogrenci.Add(53, "Ahmet");
            Console.WriteLine(ogrenci.Count);
            ogrenci.Add(37, "Büşra");
            ogrenci.Show();
        }
    }
}
