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
            int number;

            do
            {
                Console.WriteLine(message);
            } while (!int.TryParse(Console.ReadLine(), out number));

            return number;
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

        public static int[] GetNumberArray(string Operator)
        {
            int totalNumber = GetNumber(Operator);
            int[] inputs = new int[totalNumber];

            for (int i = 0; i < totalNumber; i++)
            {
                inputs[i] = GetNumber(string.Format("Please enter number {0}: ", i + 1));
            }

            return inputs;
        }
    }
}
