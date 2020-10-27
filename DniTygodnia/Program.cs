using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DniTygodnia
{
    class Program
    {
        static void Main(string[] args)
        {

        naprawa:

            try
            {
                Console.WriteLine("Podaj dzień");
                int day = Convert.ToInt32(Console.ReadLine());
                if (day <= 0 || day >= 8)
                    throw new Exception("Dzień tygodnia odpowiada liczbie od 1 do 7!!!");

                switch (day)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                }
            }
            catch (FormatException uchwyt)
            {
                Console.WriteLine("Wystąpił wyjątek: " + uchwyt.Message);
                // throw;
            }

            catch (Exception uchwyt)
            {
                Console.WriteLine("Wystąpił wyjątek: " + uchwyt.Message);
                goto naprawa;
            }

            finally
            {
                Console.WriteLine("Program idzie dalej...");
            }

            Console.ReadKey();
        }
    }
}
