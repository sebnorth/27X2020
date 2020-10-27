using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonwersjaTypów
{
    class Program
    {
        static void Main(string[] args)
        {


            double x = (6 / 7 > 0) ? (6 / 7) : (7 / 6);
            Console.WriteLine(x);
            // Console.WriteLine((double) (7/6));

            Console.ReadKey();
        }
    }
}
