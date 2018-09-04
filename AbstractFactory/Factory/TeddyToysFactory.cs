using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Toys;

namespace AbstractFactory.Factory
{
    public class TeddyToysFactory : IToyFactory
    {
        public Bear GetBear()
        {
            return new TeddyBear();
        }

        public Cat GetCat()
        {
            return new TeddyCat();
        }
    }
}
