using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //digits of the number
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            bool condition = true;
            int counter = 0;
            while (condition)
            {
                int reminder = num % 10;
                num = (num - reminder) / 10;
                counter++;
                if (num == 0)
                {
                    condition = false;
                }

            }
            Console.WriteLine(counter);



            //check prime number

            Console.WriteLine("Enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < num1 / 2; i++)
            {
                if (num1 % 2 == 0)
                {
                    Console.WriteLine("this is not prime number");
                    break;
                }
                else
                {
                    Console.WriteLine("this is  prime number");
                    break;
                }
            }



            // CHECK CURRENT SEASON
            Console.WriteLine("Enter month number");
            int monthNumber = Convert.ToInt32(Console.ReadLine());
            if (monthNumber == 1 || monthNumber == 2 || monthNumber == 12)
            {
                Console.WriteLine("this is winter month");
            }
            else if (monthNumber == 3 || monthNumber == 4 || monthNumber == 5)
            {
                Console.WriteLine("this is spring month");
            }
            else if (monthNumber == 6 || monthNumber == 7 || monthNumber == 8)
            {
                Console.WriteLine("this is summer month");
            }
            else if (monthNumber == 9 || monthNumber == 10 || monthNumber == 11)
            {
                Console.WriteLine("this is fall month");
            }
            else
            {
                Console.WriteLine("Enter  valid month number");
            }


        }
    }
}
