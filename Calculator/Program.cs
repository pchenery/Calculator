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

            Console.WriteLine("How many numbers do you want to " + Operator + "? ");
            int totalNumber = int.Parse(Console.ReadLine());
            int[] inputs = new int[totalNumber];

            for (int i = 0; i < totalNumber; i++)
            {

                Console.WriteLine("Please enter Number " + (i + 1));
                inputs[i] = int.Parse(Console.ReadLine());
            }

            float output = inputs[0];

            for (int index = 1; index < totalNumber; index++)
            {
                if (Operator == "*")
                {
                    output = output * inputs[index];
                }
                else if (Operator == "/")
                {
                    output = output / inputs[index];
                }
                else if (Operator == "+")
                {
                    output = output + inputs[index];
                }
                else if (Operator == "-")
                {
                    output = output - inputs[index];
                }
            }

            Console.WriteLine($"Result is: {output}");
            Console.ReadLine();
        }
    }
}

