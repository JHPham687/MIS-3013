using System;
using System.Collections.Generic;
using System.Text;

namespace Toys
{
    class ToyBox
    {
        public List<Toy> Toys { get; set; }

        public ToyBox()
        {
            Toys = new List<Toy>();
        }

        public Toy GetRandomToy()
        {
            Random rand = new Random();
            int randomToy = rand.Next(0, Toys.Count);

            return Toys[randomToy];
        }
    }
}
