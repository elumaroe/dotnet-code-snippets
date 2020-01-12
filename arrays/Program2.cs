 using System;

namespace esther
{
    class Program
    {
        static void Main(string[] args)
        {

            int amt = 1000;
            int current;
            int pin = 5050;
            int pin1;
            int pin2;
            int f;
            Console.WriteLine("please insert your ccard");
             Console.WriteLine("your pin is 5050");
            Console.WriteLine("Enter your pin");
            pin2 = int.Parse(Console.ReadLine());
            if (pin2==pin)
            {
                Console.WriteLine("1. To check your balance");
                Console.WriteLine("2. To withdrawl");
                Console.WriteLine("3.To change your pin");
                
                




            }
        }
    }
}
