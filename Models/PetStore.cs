using System.Collections.Generic;

namespace classes.Models
{
    class PetStore
    {
        public List<Cat> Cats { get; private set; } = new List<Cat>();
        public List<Dog> Dogs { get; private set; } = new List<Dog>();

        public void AddInventory(Cat cat)
        {
            Cats.Add(cat);
        }
        public void AddInventory(Dog dog)
        {
            Dogs.Add(dog);
        }
        public void AddInventory(List<Cat> cats)
        {
            Cats.AddRange(cats);
        }
        public void AddInventory(Cat[] cats)
        {
            Cats.AddRange(cats);
        }

        public PetStore()
        {
            Cats
        }
    }
}