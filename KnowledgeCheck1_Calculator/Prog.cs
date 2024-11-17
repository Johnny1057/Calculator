using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    internal class Prog
    {
        static void Main(string[] args)
        {
            var calc = new Calc();
            var calcInputs = new CalcCheck();
            string input;
            do  // added do while loop so program would not close after one operation
            {
                Console.WriteLine("I am a humble calculator here to assist you.");
                Console.WriteLine("Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");
                Console.WriteLine("Type exit to end the calculator");

                input = Console.ReadLine().ToLower();


                switch (input)
                {
                    case "1":    //addition
                        var addInputs = CalcCheck.GetTwoIntegers();
                        if (addInputs != null)
                        {
                            var (num1, num2) = addInputs.Value;
                            var result = Calc.Add(num1, num2);
                            CalcCheck.DisplayResults("addition", result);

                        }
                        break;

                    case "2":  // subtraction
                        var subtractInputs = CalcCheck.GetTwoIntegers();
                        if (subtractInputs != null)
                        {
                            var (num1, num2) = subtractInputs.Value;
                            var result = Calc.Subtract(num1, num2);
                            CalcCheck.DisplayResults("Subtraction", result);


                        }
                        break;
                    case "3": // multiplication
                        var multInputs = CalcCheck.GetTwoIntegers();
                        if (multInputs != null)
                        {
                            var (num1, num2) = multInputs.Value;
                            var result = Calc.Multiply(num1, num2);
                            CalcCheck.DisplayResults("Multiplication", result);
                        }
                        break;
                    case "4": // Division 
                        var divideInputs = CalcCheck.GetTwoDoubles();
                        if (divideInputs != null)
                        {
                            var (num1, num2) = divideInputs.Value;
                            var result = Calc.Divide(num1, num2);
                            CalcCheck.DisplayResults("Division", result);
                        }
                        break;
                        case "exit":
                        Console.WriteLine("Goodbye!"); // added exit message
                        break;

                    default:
                        Console.WriteLine("Invalid input, please try again.");
                        break;
                }
                if (input != "exit")
                {
                    Console.WriteLine("Press any key to continue to the next operation.");
                    Console.ReadKey(); // this seems to work but it kept putting the input at the start of the next loop, clearing seems to clean it up but i would prefer if the history could somehow remain. Looks better this way so keeping it for now
                    Console.Clear();
                }
            }
            while (input != "exit");
        }
    }
}
