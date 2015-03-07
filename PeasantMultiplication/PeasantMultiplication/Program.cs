namespace PeasantMultiplication
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            string inputA, inputB;
            int a, b;

            if (args == null || args.Count() < 2)
            {
                Console.WriteLine("Please enter the numbers you want to multiply!");
                inputA = Console.ReadLine();
                inputB = Console.ReadLine();
            }
            else
            {
                inputA = args[0];
                inputB = args[1];
            }

            if (!int.TryParse(inputA, out a) || !int.TryParse(inputB, out b))
            {
                Console.WriteLine("Damn you for messing with my mind! I can't read that :(");
                return;
            }

            Multiplicator multiplicator = new Multiplicator();
            Console.WriteLine(multiplicator.Multiply(a, b));
        }
    }
}
