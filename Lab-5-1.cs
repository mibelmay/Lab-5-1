using System;

namespace Labs
{
    public static class Program
    {
        public static void Main()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "q")
                    break;
                bool success = int.TryParse(input, out int intMumber);
                if (success)
                {
                    Console.WriteLine((char)intMumber);
                    continue;
                }
                break;

            }
        }
    }
}