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

            
            // INPUT get two numbers from user to use is equation.
          Console.Write("Enter a number between 1 and 10");
            int num1 =int.Parse(Console.ReadLine());

            Console.Write("Enter another number between 1 and 10");
            int num2 = int.Parse(Console.ReadLine());

            maths(num1,num2);

            Console.Write("The END");
            Console.ReadLine();
         
        }

        public static void maths(int num1,int num2)
        {

            Console.Write("Press 1 to ADD, Press 2 for PRODUCT, Press 3 to DIVIDE these numbers");
            int keyPressed = int.Parse(Console.ReadLine());

            // IF ELSE MENU 
            { 
            if (keyPressed == 1)
            {
                int answer = num1 + num2;
                Console.WriteLine(answer);
                }
            else if (keyPressed == 2)
            {
                int answer = num1 * num2;
                Console.WriteLine(answer);
                }
            else if (keyPressed == 3)
            {
                int answer = num1 / num2;
                Console.WriteLine(answer);
                }
            else if (keyPressed != 1 || keyPressed != 2 || keyPressed != 3)
            {
                Console.WriteLine("Press either 1, 2 or 3!");
            }
            else
            {
                Console.WriteLine("You've broken the app");
            }
                
        }
        }
    }
}

