using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            string[] kurslar = new string[] { "kamp", "yazılım", ".net", "api" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (var kurs in kurslar)  //dizi temelli yapıları tek tek dönmeye yarıyor
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
