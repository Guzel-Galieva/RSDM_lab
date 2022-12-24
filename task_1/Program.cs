using System;

namespace Tasks
{
    public class Task1
    {
        public static void Main(string[] args)
        {
            try
            {
                string newCount;
                switch (args[1])
                {
                    case "rub":
                        newCount = (double.Parse(args[0]) * 0.014).ToString("0.00");
                        Console.WriteLine($"Your {args[0]}{args[1]} equal to {newCount}$");
                        break;
                    case "$":
                        newCount = (double.Parse(args[0]) * 70.25).ToString("0.00");
                        Console.WriteLine($"Your {args[0]}{args[1]} equal to {newCount}rub");
                        break;
                    default:
                        Console.WriteLine("Undefined");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}