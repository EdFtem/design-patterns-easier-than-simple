using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            LaptopBuilder gamingLaptopBuilder = new GamingLaptopBuilder();
            BuyLaptop buyLaptop = new BuyLaptop();
            buyLaptop.SetLaptopBuilder(gamingLaptopBuilder);
            buyLaptop.ConstructLaptop();
            var laptop = buyLaptop.GetLaptop();
            Console.WriteLine($"{laptop.Memory}, {laptop.MonitorResolution}, {laptop.Battery}, {laptop.HDD}, {laptop.Processor}");
            Console.ReadKey();
        }
    }
}
