using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Everyone!");
            GreetBlack();
            GreetWhite();
        }
        static void GreetWhite()
        {
            Console.WriteLine("Hello White");
        }
        static void GreetBlack()
        {
            Console.WriteLine("Hello Black");
        }
    }
}