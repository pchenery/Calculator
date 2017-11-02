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
            PrintWelcomeMessage();

            while (true)
            {
                PerformOneCalculation();
            }
        }

        private static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Calculator");
            Console.WriteLine("=========================");
        }

        private static void PerformOneCalculation()
        {
            string Operator = GetOperator();
            int[] numbers = GetNumberArray(Operator);
            float answer = GetAnswer(Operator, numbers);

            Console.WriteLine($"Result is: {answer}");
            Console.ReadLine();

        }

        private static string GetOperator()
        {
            Console.WriteLine("Please enter the Operator: ");
            string Operator = Console.ReadLine();
            return Operator;
        }

        private static int[] GetNumberArray(string Operator)
        {
            int totalNumber = GetNumber("How many numbers do you want to " + Operator + "? ");
            int[] inputs = new int[totalNumber];

            for (int i = 0; i < totalNumber; i++)
            {
                inputs[i] = GetNumber("Please enter Number ");
            }

            return inputs;
        }

        private static int GetNumber(string message)
        {
            int number;

            do
            {
                Console.WriteLine(message);
            } while (!int.TryParse(Console.ReadLine(), out number));

            return number;
        }

        private static float GetAnswer(string Operator, int[] numbers)
        {
            float output = numbers[0];

            for (int index = 1; index < numbers.Length; index++)
            {
                if (Operator == "*")
                {
                    output = output * numbers[index];
                }
                else if (Operator == "/")
                {
                    output = output / numbers[index];
                }
                else if (Operator == "+")
                {
                    output = output + numbers[index];
                }
                else if (Operator == "-")
                {
                    output = output - numbers[index];
                }
            }
            return output;
        }
    }
}

