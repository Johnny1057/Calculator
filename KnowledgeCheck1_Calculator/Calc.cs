using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    public class Calc
    {
        public static int Add(int num1, int num2) => num1 + num2;
        public static int Subtract(int num1, int num2) => num1 - num2;
        public static int Multiply(int num1, int num2) => num1 * num2;
        public static double Divide(double num1, double num2) => num1 / num2;
    }

} // would it be more accurate as all decimals? YAGNI for now i guess