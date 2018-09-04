namespace AbstractFactory.Toys
{
    public abstract class Cat : AnimalToy
    {
        protected Cat(string name) : base(name) { }
    }
}
