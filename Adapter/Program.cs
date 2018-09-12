using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var newElectricitySystem = new NewElectricitySystem();
            ElectricityConsumer.ChargeNotebook(newElectricitySystem);

            var oldElectricitySystem = new OldElectricitySystem();
            Adapter adapter = new Adapter(oldElectricitySystem);
            ElectricityConsumer.ChargeNotebook(adapter);
            Console.ReadKey();
        }
    }
}
