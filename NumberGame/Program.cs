using System;

namespace NumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number: ");
            string strNumber = Console.ReadLine();
            int intNumber = int.Parse(strNumber);

            if (intNumber == 2)
            {
                Console.WriteLine(intNumber + "is correct, you won");
            }
            else
            {
                Console.WriteLine(intNumber + " " + "is incorrect, you lost");
            }
        }
    }
}
