using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    public abstract class Animal {
        public string Name { get; set; }
    }

    public class Cat : Animal, ICat
    {
        public void Eat()
        {
            Console.WriteLine("Cat eat");
        }

        public void Move()
        {
            Console.WriteLine("Cat move");
        }
    }

    public class Dog : Animal, IDog
    {
        public void Eat()
        {
            Console.WriteLine("Dog eat");
        }

        public void Move()
        {
            Console.WriteLine("Dog move");
        }

        public void Training()
        {
            Console.WriteLine("Training true");
        }
    }

    public class WildDog : IWildDog
    {
        private void Eat()
        {
            Console.WriteLine("Wolf eat");
        }

        public void Hunt()
        {
            Console.WriteLine("Wolf hunting");
            Eat();
        }
    }

    public class WildCat : Cat
    {
        public void WildKilling()
        {
            Console.WriteLine("Kill animal");
        }
    }

    public interface ICat
    {
        public void Move();
        public void Eat();
    }

    public interface IDog
    {
        public void Move();

        public void Eat();

        public void Training();
    }

    public interface IWildDog
    {
        public void Hunt();
    }

    public class DeterminingTypeDog
    {
        IDog dogType;
        public DeterminingTypeDog(IDog dog)
        {
            dogType = dog;
        }
    }

    public class FighterDog : IDog
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void Training()
        {
            throw new NotImplementedException();
        }
    }

    public class ICompanionDog : IDog
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void Training()
        {
            throw new NotImplementedException();
        }
    };
}
