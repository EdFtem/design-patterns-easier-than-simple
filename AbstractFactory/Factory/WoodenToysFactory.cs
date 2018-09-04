using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Toys;

namespace AbstractFactory.Factory
{
    public class WoodenToysFactory : IToyFactory
    {
        public Bear GetBear()
        {
            return new WoodenBear();
        }

        public Cat GetCat()
        {
            return new WoodenCat();
        }
    }
}
