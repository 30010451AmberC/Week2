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

            //Program asks user to guess number between 1 and 10
            Console.Write("Guess my (WHOLE) number between 1 and 10");
            int userNum = int.Parse(Console.ReadLine());
            int myNum = 7;

            guess(userNum, myNum);

            //Program asks user to enter in final mark out of 100
            Console.Write("Please enter your final mark for the course!");
            int finalMark = int.Parse(Console.ReadLine());

            grades(finalMark);

            //Program determines and displays whether users number is odd or even
            Console.Write("Please eneter a WHOLE number!");
            int userNum1 = int.Parse(Console.ReadLine());

            oddeven(userNum1);

            //Program asks user to enter a 4-digit pin number
            Console.Write("Please enter a 4-digit pin number. You number must be between 1000 and 9999!");
            int pinNum = int.Parse(Console.ReadLine());

            pincheck(pinNum);

            Console.Write("Please re-enter your PIN to check if it matches.");
            int checkNum = int.Parse(Console.ReadLine());

            recheck(pinNum, checkNum);

            //Program asks user to enter a palindrome, one letter at a time.
            Console.Write("Please think of a 3 letter palindrome, enter 1 letter at a time.");
            Console.Write("First letter:");
            string letter1 = Console.ReadLine();
            Console.Write("Second letter:");
            string letter2 = Console.ReadLine();
            Console.Write("Third letter:");
            string letter3 = Console.ReadLine();

            vowel(letter2);




        }

        public static void maths(int num1, int num2)
        {
            //If statement for task 1.
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

        public static void guess(int userNum, int myNum)
            
            //If statement for task 2
        {
            if (userNum == myNum)
            {
                Console.Write("You guessed the right number!");
            }
            else if (userNum != myNum)
            {
                Console.Write("You've guessed the incorrect number.");
            }
            else
            {
                Console.Write("Your number needs to be between 1 and 10. Start again.");
            }
        }

        public static void grades(int finalMark)

        //If statement for task 3.
        {
            if (finalMark >= 90)
            {
                Console.Write("Your grade is A+!");
            }
            else if (finalMark >= 80)
            {
                Console.Write("Your grade is A!");
            }
            else if (finalMark >= 70)
            {
                Console.Write("Your grade is B+");
            }
            else if (finalMark >= 60)
            {
                Console.Write("Your grade is B");
            }
            else if (finalMark >= 50)
            {
                Console.Write("Your grade is C");
            }
            else if (finalMark >= 40)
            {
                Console.Write("Your grade is D");
            }
            else if (finalMark >=0)
            {
                Console.Write("Your grade is F");
            }
            else
            {
                Console.Write("Marks entered were greater than 100 or less than zero. TRY AGAIN!");
            }
      
        }

        public static void oddeven(int userNum1)

        //If Statement for Task 4
        {
            if ((userNum1%2) == 0)
            {
                Console.Write("Your number is Even!");
            }
            else
            {
                Console.Write("Your number is Odd!");
            }
            
        }

        public static void pincheck(int pinNum)

        //If statement for Task 5a
        {
            if (pinNum >= 1000 && pinNum <= 9999)
            {
                Console.Write("Thank you!");
            }
            else
            {
                Console.Write("Your PIN is not within the right parameters.");
            }
        }

        public static void recheck(int checkNum, int pinNum)

        //If statement for Task 5b
        {
            if(checkNum == pinNum)
            {
                Console.Write("Your PIN has been set!");
            }
            else
            {
                Console.Write("ERROR! Your PIN numbers did NOT match. Your PIN was not set.");
            }
        }

        public static void vowel(string letter2)

        //If statement for Task 6a
        {
            if (letter2 == "a") 
            {
                palindromeCheck(letter1, letter3);
            }
            else
            {
                Console.Write("Your word is NOT a palindrome!");
            }
        }

        public static void plaindromeCheck(string letter1, string letter2)

        //If statement for Task 6b
        {
            if (letter1 == letter2)
            {
                Console.Write("Well done! Your word is a palindrome!");
            }
            else
            {
                Console.Write("This word is NOT a palindrome!");
            }
        }
    

    }
}
