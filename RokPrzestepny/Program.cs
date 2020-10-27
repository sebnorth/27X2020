using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RokPrzestepny
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Podaj rok: ");
            //int.TryParse(Console.ReadLine(), out int rok);

            Obliczenia.CzyRokJestPrzestepny(1900);
            Obliczenia.CzyRokJestPrzestepny(2000);
            Obliczenia.CzyRokJestPrzestepny(2020);
            Obliczenia.CzyRokJestPrzestepny(2021);



            Console.ReadKey();
        }
    }
}
