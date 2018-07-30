using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("Hello " + firstName + " " + lastName + "!" );

            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Are you male or female?");
            string gender = Console.ReadLine();

            Console.WriteLine(firstName + " is " + age + " years old and is " + gender );

            Console.WriteLine("Type a number bewtween 1 and 10");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Type ANOTHER number between 1 and 10");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 / num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);

            



        }

    }

    
}






    