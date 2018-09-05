using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Toys
{
    public abstract class Bear : AnimalToy
    {
        protected Bear(string name) : base(name) { }
    }
}
