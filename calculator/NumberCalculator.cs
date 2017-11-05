using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class NumberCalculator
    {
        private Log log = new Log();

        public void PerformOneCalculation()
        {
            string Operator = Prompts.GetOperator();
            List<int> numbers = Prompts.GetNumberArray(string.Format("Please enter the numbers to {0}. ", Operator));
            float answer = GetAnswer(Operator, numbers);

            log.ClearLog();
            log.AddToLog(string.Join(Operator, numbers)+ " = "+answer);
            Console.WriteLine($"Result is: {answer}");
            Console.ReadLine();
        }

        private float GetAnswer(string Operator, List<int> numbers)
        {
            if (Operator == "*")
            {
                return numbers.Aggregate(func: (result, item) => result * item);
            }
            else if (Operator == "/")
            {
                return numbers.Aggregate(func: (result, item) => result / item);
            }
            else if (Operator == "+")
            {
                return numbers.Sum();
            }
            else if (Operator == "-")
            {
                return numbers.Aggregate(func: (result, item) => result - item);
            }
            return -1;
        }
    }
}
