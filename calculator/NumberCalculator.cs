using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class NumberCalculator
    {
        public void PerformOneCalculation()
        {
            string Operator = Prompts.GetOperator();
            int[] numbers = Prompts.GetNumberArray(string.Format("How many numbers do you want {0}. ", Operator));
            float answer = GetAnswer(Operator, numbers);

            Console.WriteLine($"Result is: {answer}");
            Console.ReadLine();
        }

        private float GetAnswer(string Operator, int[] numbers)
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
