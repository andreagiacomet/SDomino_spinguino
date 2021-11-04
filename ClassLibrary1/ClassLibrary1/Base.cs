namespace PizzeriaPinguino
{
    public abstract class Base : IIdentity
    {
        public abstract string Name { get; set; }
        public abstract decimal Price { get; set; }
    }
}

