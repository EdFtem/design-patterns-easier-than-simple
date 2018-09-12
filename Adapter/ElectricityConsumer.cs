using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class ElectricityConsumer
    {
        public static void ChargeNotebook(INewElectricitySystem electricitySystem)
        {
            Console.WriteLine(electricitySystem.MatchWideSocket());
        }
    }
}
