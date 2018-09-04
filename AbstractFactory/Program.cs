using System;
using AbstractFactory.Factory;
using AbstractFactory.Toys;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IToyFactory woodenToysFactory = new WoodenToysFactory();
            IToyFactory teddyToysFactory = new TeddyToysFactory();
            ShowFactory(woodenToysFactory);
            ShowFactory(teddyToysFactory);
            Console.ReadKey();
        }

        public static void ShowFactory(IToyFactory factory)
        {
            Bear bear = factory.GetBear();
            Cat cat = factory.GetCat();
            Console.WriteLine($"I've got {bear.ToyName} and {cat.ToyName}");
        }
    }
}
