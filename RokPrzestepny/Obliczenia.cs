using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RokPrzestepny
{
    class Obliczenia
    {
        public static void CzyRokJestPrzestepny(int x) {

            if ((x % 4 == 0 && x % 100 != 0) || (x % 400 == 0))
                Console.WriteLine("Rok {0} jest przestępny", x);
            else
                Console.WriteLine("Rok {0} nie jest przestępny", x);
        }
    }
}
