using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Prompts
    {
        public static int GetNumber(string message)
        {
            while (true)
            {
                int? isNumber = GetOptionalNumber(message);

                if (isNumber.HasValue)
                {
                    return isNumber.Value;
                }
            }
        }

        public static int? GetOptionalNumber(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    return null;
                }

                int number;
                if (int.TryParse(input, out number))
                {
                    return number;
                }
            }
        }

        public static string GetOperator()
        {
            Console.WriteLine("Please enter the Operator: ");
            string Operator = Console.ReadLine();
            return Operator;
        }

        public static DateTime GetDate(string message)
        {
            DateTime userDate;

            do
            {
                Console.WriteLine(message);
            } while (!DateTime.TryParse(Console.ReadLine(), out userDate));

            return userDate;
        }

        public static int GetDaysToAdd(string message)
        {
            int number;

            do
            {
                Console.WriteLine(message);
            } while (!int.TryParse(Console.ReadLine(), out number));

            return number;
        }

        public static List<int> GetNumberArray(string message)
        {
            Console.WriteLine(message);
            List<int> inputs = new List<int>();

            while (true)
            {
                int? number = GetOptionalNumber("Please enter the next number: ");

                if (number.HasValue)
                {
                    inputs.Add(number.Value);
                }
                else
                {
                    break;
                }
            }

            return inputs;
        }
    }
}
