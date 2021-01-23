using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {


            //array-dizi
            //lenght-eleman sayısı

            string[] kurslar = new string[]  { "java", "python", "C#","go","android"};


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
