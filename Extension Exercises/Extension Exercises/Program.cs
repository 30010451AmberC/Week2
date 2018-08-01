using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.Write("Enter a number between 1 and 10");
            int num1 =int.Parse(Console.ReadLine());

            Console.Write("Enter another number between 1 and 10");
            int num2 = int.Parse(Console.ReadLine());
        }

        public static void maths()
        {
            Console.Write("Would you like to 1)ADD 2)PRODUCT 3)DIVIDE these number?");
            int keyPressed = int.Parse(Console.ReadKey());

            if (keyPressed == 1)
            {

            }
            else if (keyPressed == 2)
            {
            }
            else if (keyPressed == 3)
            {

            }
            else if (keyPressed != 1, 2, 3)
            {

            }

        }
    }
}

