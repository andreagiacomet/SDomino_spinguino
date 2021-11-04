using System;

namespace PizzeriaPinguino
{
    public interface IIdentity
    {
        string Name { get; set; }
        decimal Price { get; set; }
    }
}

