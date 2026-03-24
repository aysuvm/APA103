using System;
using _06_InterfaceAbstraction;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Eded daxil edin");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("2-ci ededi daxil edin");
        double number2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Lazimi emeli daxil edin (+, -, *,/)");
        string operation = Console.ReadLine();

        Calculation calc = new Calculation();
        double result = calc.Calculate(number1, number2, operation);

        Console.WriteLine($"Netice: {result}");
    }
}