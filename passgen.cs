using System;

namespace PassGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_' };

            Console.WriteLine("Password Generator");
            Console.WriteLine("Specify the type");
            Console.WriteLine("1 = powerful - [a-z] [A-Z] [0-9]");
            Console.WriteLine("2 = super powerful - [a-z] [A-Z] [0-9] [extra signs]");
            byte choice = Byte.Parse(Console.ReadLine());

            Console.Write("How many characters to generate? = ");

            var amount = Int32.Parse(Console.ReadLine());

            var random = new Random();
            // green color for generated password
            Console.ForegroundColor = ConsoleColor.Green;

            if (choice == 1)
            {
                for (int i = 0; i < amount; i++)
                {
                    var temp = random.Next(0, 61);
                    Console.Write(chars[temp]);
                }
            }
            else if (choice == 2)
            {
                for (int i = 0; i < amount; i++)
                {
                    var temp = random.Next(0, chars.Length);
                    Console.Write(chars[temp]);
                }
            }
            else
            {
                Console.WriteLine("Invalid parameter. END.");
            }

            // back to default console color
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
