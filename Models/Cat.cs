using System;

namespace classes.Models
{
    class Cat
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public int Lives { get; private set; }
        private bool Happy { get; set; }
        private int Pets { get; set; }
        private int Tolerance { get; set; }

        public void Pet()
        {
            Pets++;
            Happy = Pets < Tolerance;
            if (Happy)
            {
                System.Console.WriteLine("meow");
            }
            else
            {
                System.Console.WriteLine("Hiss");
            }

        }

        public void Catnip()
        {
            Pets = 0;
        }

        public void Feed()
        {
            Happy = true;
            System.Console.WriteLine("mmmmm");
        }

        public void Feed(string food)
        {
            if (food == "catfood")
            {
                System.Console.WriteLine("mmmmm");
                return;
            }
            System.Console.WriteLine("BARF");
        }

        public void Feed(int oz)
        {

        }

        public void Feed(string food, int oz)
        {
            Random rnd = new Random();
            rnd.Next(3, 3);
        }

        public void Feed(int oz, string food)
        {

        }

        public Cat(string firstName, string lastName, int tolerance)
        {
            FirstName = firstName;
            LastName = lastName;
            Tolerance = tolerance;
            Lives = 9;
            Happy = true;
        }
        public Cat(string FullName, int tolerance)
        {
            String[] names = FullName.Split(' ');
            FirstName = names[0];
            Tolerance = tolerance;
            LastName = "";
            if (names.Length > 1)
            {
                LastName = names[1];
            }

        }



        public decimal Add(int a, int b)
        {
            throw new Exception("I hate you");
        }
        public decimal Add(double a, double b)
        {
            return (decimal)(a + b);
        }
        public decimal Add(decimal a, decimal b)
        {
            return a + b;
        }
    }
}