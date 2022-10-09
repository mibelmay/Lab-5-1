using System;

namespace Labs
{
    public static class Program
    {
        public static void Main()
        {
            double previousInput = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "q")
                    break;
                bool success = int.TryParse(input, out int intMumber);
                if (success)
                {
                    Console.WriteLine((char)intMumber);
                    previousInput = intMumber;
                    continue;
                }
                double doubleNumber = double.Parse(input);
                if (Math.Abs(doubleNumber - previousInput) < 1e-9)
                    break;
                previousInput = doubleNumber;

            }
        }
    }
}