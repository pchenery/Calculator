using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator!");
            Console.WriteLine("========================== ");
            Console.WriteLine("Please enter the Operator: ");
            string Operator = Console.ReadLine();

            Console.WriteLine("Enter the first number: ");
            string myFirstNumber = Console.ReadLine();

            Console.WriteLine("Enter the second number: ");
            string mySecondNumber = Console.ReadLine();

            float output = 0.000f;
            switch (Operator)
            {
                case "+":
                    output = int.Parse(myFirstNumber) + int.Parse(mySecondNumber);
                    break;
                case "-":
                    output = int.Parse(myFirstNumber) - int.Parse(mySecondNumber);
                    break;
                case "x":
                    output = int.Parse(myFirstNumber) * int.Parse(mySecondNumber);
                    break;
                case "/":
                    output = float.Parse(myFirstNumber) / float.Parse(mySecondNumber);
                    break;
            }

            Console.WriteLine($"Result is: {output}");
            Console.ReadLine();
        }
    }
}
