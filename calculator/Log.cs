using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Log
    {
        private string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public void ClearLog()
        {
            using (StreamWriter outputFile = new StreamWriter(mydocpath + @"\CalcLog.txt"))
            {
                outputFile.Write (String.Empty);
            }
        }

        public void AddToLog(string line)
        {
            using (StreamWriter outputFile = new StreamWriter(mydocpath + @"\CalcLog.txt",true))
            {
                outputFile.WriteLine(line);
                outputFile.WriteLine();
            }
        }
    }
}
