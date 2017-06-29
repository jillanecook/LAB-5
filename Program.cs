using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_5
{
    class Program
    {
        static void Main()
        {
            do
            {

                Console.WriteLine("Welcome to the Grand Circus Casino!");
                Console.WriteLine("How many sides does your die have?");
                int d = int.Parse(Console.ReadLine());

                Random rng = new Random();

                Console.WriteLine("Roll 1:");
                Console.WriteLine(rng.Next(1, d++));
                Console.WriteLine("Roll 2:");
                Console.WriteLine(rng.Next(1, d++));
                Console.WriteLine("Roll 3:");
                Console.WriteLine(rng.Next(1, d++));
                Console.WriteLine("Roll 4:");
                Console.WriteLine(rng.Next(1, d++));
            } while (Continue() == true);

        }
        public static Boolean Continue()
        {
            Boolean run;
            Console.WriteLine("Continue? Y/N");
            String answer = Console.ReadLine();

            if ((answer == "Y") || (answer == "y"))
            {
                run = true;
            }
            else if ((answer == "N") || (answer == "n"))
            {
                run = false;
                Console.WriteLine("Good Bye!");
            }
            else
            {
                Console.WriteLine("Does not compute!");
                run = Continue();

            }
            return run;
        }
    }

















}


