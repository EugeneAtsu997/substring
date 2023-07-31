using System;

namespace substring
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = "CONTROLLER-PFWP1006012230838737-BR-TAM2023-07-10 (34)-Tamale";
            string extractedValue = GetValueBetween(input, "-", "-");
            Console.WriteLine(extractedValue);
        }

        static string GetValueBetween(string input, string startValue, string endValue)
        {
            int startIndex = input.IndexOf(startValue) + startValue.Length;
            int endIndex = input.IndexOf(endValue, startIndex);

            if (startIndex < 0 || endIndex < 0 || endIndex <= startIndex)
            {
                // Values not found or in incorrect order
                return string.Empty;
            }

            return input.Substring(startIndex, endIndex - startIndex);
        }


        /*
         using System;
using System.IO;

class Program
{
    static void Main()
    {
        string logFilePath = "log.txt";

        if (!File.Exists(logFilePath))
        {
            // Create the log file
            File.Create(logFilePath).Close();
            Console.WriteLine("Log file created successfully!");
        }
        else
        {
            Console.WriteLine("Log file already exists.");
        }
    }
}

         */
    }
}