using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // GET 2 numbers from the user
            Console.Write("Please enter a number!");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Please enter ANOTHER number!");
            int num2 = int.Parse(Console.ReadLine());

            maths(num1, num2);
                }

        public static void maths(int num1, int num2)
        {
            //
            { 
             if (num1 > num2)
             {
                Console.Write(num1 + "is larger");
             }
             else if (num2 > num1)
             {
                Console.Write(num2 + "is larger");
             }
             else
             {
                Console.Write("Both numbers are EQUAL!");
            }
        }
        }

    }
}
