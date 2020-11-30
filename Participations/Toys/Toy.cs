using System;

namespace Toys
{
    class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        private string Notes;

        private static Random rand = new Random();

        public Toy()
        {
            Manufacturer = " ";
            Name = " ";
            Price = 0;
            Notes = " ";
        }
    }

    public string GetAisle()
    {
        Manufacturer = Manufacturer.ToUpper();
        char firstLetMan = Manufacturer[0];
        int number = rand.Next(1,25);
        string returnStatement = $"{firstLetMan}{number}";
        return returnStatement;
    }

    public override string ToString()
    {
        return Name.ToString();
    }
}