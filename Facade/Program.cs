using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            SkiFacade facade = new SkiFacade();
            var price = facade.HaveGoodRest(10, 20, 10, 3, 3);
            Console.WriteLine($"Price = { price }");
            Console.ReadKey();
        }
    }
}
