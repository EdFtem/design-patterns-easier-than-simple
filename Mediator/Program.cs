using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Brain brain = new Brain();
            brain.Ear.HearSomething();
            brain.SomethingHappenedToBodyPart(brain.Ear);
            Console.ReadKey();
        }
    }
}
