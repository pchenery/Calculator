using System;
using System.Net.NetworkInformation;

namespace Calculator
{
    class Program
    {
        private const int NumberCalculator = 1;
        private const int DateCalculator = 2;

        static void Main(string[] args)
        {
            PrintWelcomeMessage();

            while (true)
            {
                int calculationMode = AskForCalculationMode();

                if (calculationMode == NumberCalculator)
                {
                    PerformOneCalculation();
                }
                else
                {
                    PerformDateCalculation();
                }
                
            }
        }

        private static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Calculator");
            Console.WriteLine("=========================");
        }

        private static void PrintMenuMessage()
        {
            Console.WriteLine("Which calculator mode do you want? ");
            Console.WriteLine("1) Numbers");
            Console.WriteLine("2) Dates");
        }

        private static int AskForCalculationMode()
        {
            PrintMenuMessage();
            return GetNumber("");
        } 

        private static void PerformOneCalculation()
        {
            string Operator = GetOperator();
            int[] numbers = GetNumberArray(Operator);
            float answer = GetAnswer(Operator, numbers);

            Console.WriteLine($"Result is: {answer}");
            Console.ReadLine();
        }

        private static void PerformDateCalculation()
        {
            DateTime enterDate = GetDate("Please Enter a Date");
            int numDays = GetNumber("Please enter the number of days to add ");
            DateTime answer = CalculateDate(enterDate, numDays);

            Console.WriteLine($"Result is: {answer}");
            Console.ReadLine();
        }

        private static string GetOperator()
        {
            Console.WriteLine("Please enter the Operator: ");
            string Operator = Console.ReadLine();
            return Operator;
        }

        private static DateTime CalculateDate(DateTime enterDate, int numDays)
        {
            return enterDate.AddDays(numDays);
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

        private static DateTime GetDate(string message)
        {
            DateTime userDate;

            do
            {
                Console.WriteLine(message);
            } while (!DateTime.TryParse(Console.ReadLine(), out userDate));

            return userDate;
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

