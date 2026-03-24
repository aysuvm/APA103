using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_InterfaceAbstraction
{
    public class Calculation : ICalculation
    {


        public double Calculate(double number1, double number2, string operation)
        {
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    if (number2 == 0)
                    {
                        Console.WriteLine("0-a bolmek olmaz!");
                        return 0;
                    }
                    result = number1 / number2;
                    break;
                default:
                    Console.WriteLine("Yanlis emel!");
                    break;
            }
            return result;
        }
    }
}
