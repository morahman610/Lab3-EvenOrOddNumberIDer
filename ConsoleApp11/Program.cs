using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, Please enter your name");
            string UsersName = Console.ReadLine();

        Start:

            Console.WriteLine($"{UsersName}, please enter a number between 1 and 100.");
            string UsersNumber = Console.ReadLine();

            bool ItsANumber = int.TryParse(UsersNumber, out int i);

            if (ItsANumber)
            {
                if ( i >= 1 && i <= 100)
                {
                    if (i % 2 == 0)
                    {
                        if (i >= 2 && i <= 25)
                        {
                            Console.WriteLine("Even  and less than 25");
                        }
                        else if (i >= 26 && i <= 60)
                        {
                            Console.WriteLine("Even");

                        }
                        else
                        {
                            Console.WriteLine($"{i} Even");
                        }
                    }
                    else
                    {
                        if (i >= 60)
                        {
                            Console.WriteLine($"{i} Odd");
                        }
                        else
                        {
                            Console.WriteLine($"{i} Odd");
                        }
                    }

                }
                else
                {
                    Console.WriteLine($"{UsersName},The number you have entered is not between 1 and 100");
                    goto Start;
                }

            }
            else
            {
                Console.WriteLine($"{UsersName}, what you have entered is not a number.");

                Console.WriteLine("Press any key to use the program again. Press Q to quit.");

                string quit = Console.ReadLine().ToLower();
                if (quit == "q")
                {
                    goto End;
                }

                goto Start;
            }

        End:
            Console.WriteLine($"Thank You for using this program, {UsersName}.");
        }
    }
}
