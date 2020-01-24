using System;
using classes.Models;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat snibbley = new Cat("Mr.", "Snibbley", 3);
            System.Console.WriteLine(snibbley.FullName);
            snibbley.Pet();
            snibbley.Pet();
            snibbley.Feed();
            snibbley.Feed("catfood");

            PetStore p = new PetStore();
            p.AddInventory(snibbley);
        }
    }
}
