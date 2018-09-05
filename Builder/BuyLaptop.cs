using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class BuyLaptop
    {
        private LaptopBuilder _laptopBuilder;

        public void SetLaptopBuilder(LaptopBuilder laptopBuilder)
        {
            _laptopBuilder = laptopBuilder;
        }

        public Laptop GetLaptop()
        {
            return _laptopBuilder.GetLaptop();
        }

        public void ConstructLaptop()
        {
            _laptopBuilder.CreateNewLaptop();
            _laptopBuilder.SetMonitorResolution();
            _laptopBuilder.SetBattery();
            _laptopBuilder.SetHDD();
            _laptopBuilder.SetMemory();
            _laptopBuilder.SetProcessor();
        }
    }
}
