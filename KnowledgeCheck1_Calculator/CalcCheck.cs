using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    public class CalcCheck
    {
        public static (int, int)? GetTwoIntegers() // tried to use all doubles but multiplication sometimes gave incorrectly rounded answers. Decided to only allow integers for everything except division
        {
            Console.WriteLine("Enter two integers:");
            var input1 = Console.ReadLine();
            var input2 = Console.ReadLine();

            if (int.TryParse(input1, out var num1) && int.TryParse(input2, out var num2))
            {
                return (num1, num2);
            }
            else
            {
                Console.WriteLine("One or both inputs are not valid integers.");
                return null;
            }
        }
        public static (double, double)? GetTwoDoubles()
        {
            Console.WriteLine("Enter two numbers:");
            var input1 = Console.ReadLine();
            var input2 = Console.ReadLine();

            if (double.TryParse(input1, out var num1) && double.TryParse(input2, out var num2))
            {
                if (num2 == 0) // in case user divides by zero
                {
                    Console.WriteLine("Cannot divide by zero! Please enter a valid dividend");
                    return null;
                }
                return (num1, num2);
            }
            else
            {
                Console.WriteLine("One or both inputs are not valid numbers.");
                return null;

            }
        } 
      
        public static void DisplayResults(string operation, double result) // display the operation and its result
        {
            Console.WriteLine($"The result of the {operation} is {result}");
        }

    }
}
