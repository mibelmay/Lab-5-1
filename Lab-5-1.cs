using System;

namespace Labs
{
    public static class Program
    {
        public static void Main()
        {

            double previousInput = double.NaN;
            
            while (true)
            {
                Console.WriteLine("Введите число пожалуйста прошу вас иначе меня чикнут: ");
                string input = Console.ReadLine();
                
                if (input == "q") break;

                if (int.TryParse(input, out int intMumber))
                {
                    Console.WriteLine((char)intMumber);
                    previousInput = intMumber;
                    continue;
                }

                double doubleNumber = double.Parse(input);

                if (Math.Abs(doubleNumber - previousInput) < 1e-9)
                {
                    Console.WriteLine("Введенное число равно предыдущему!!!!!!!внимательнее!!");
                    break;
                }

                previousInput = doubleNumber;

            }
        }
    }
}