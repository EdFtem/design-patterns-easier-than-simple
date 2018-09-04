namespace AbstractFactory.Toys
{
    public abstract class AnimalToy
    {
        public string ToyName { get; set; }

        protected AnimalToy(string name)
        {
            this.ToyName = name;
        }
    }
}
