using System;

namespace engindemirogders2donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "kurs1";
            string kurs2 = "kurs2";
            string kurs3 = "kurs3";
            string[] kurslar = new string[] { kurs1, kurs2, kurs3 };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
