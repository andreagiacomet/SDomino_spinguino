using System.Collections.Generic;
using System.Linq;

namespace PizzeriaPinguino
{
    public class Pizza
    {
        public Base basepizza;
        public Impasto impastopizza;
        public IEnumerable<Aggiunte> aggiunte;
        public decimal TotalPrice()
        {
            if (aggiunte.Any(x => x.Name == "Ananas"))
                return 0;
            return basepizza.Price + impastopizza.Price + aggiunte.Sum(x => x.Price);
        }
    }
}

