using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace HomeWork
{
    class Program
    {
        static void Main()
        {
            //S - single responsibility principle (Этот класс умеет только то что должен уметь)
            Cat myCat = new Cat();
            myCat.Name = "Simon";
            myCat.Eat();
            myCat.Move();

            //O - Open Closed Principle (При добавление нового функционала мы не переопределяем методы Cat а добавляем новые методы)
            //При добавлений нового функционала нам будет достаточно добавить этот метод внутри нового класса

            myCat.Eat();
            WildCat wildCat = new WildCat();
            wildCat.WildKilling();


            //L - Liskov Substitution Principle (Мы можем дополнять но не замещать поведение базового класса)
            //то есть новый клиентский класс будет добавлять новый функционал в себя но не будет изменять то что умеет Cat
            Cat bigCat = new WildCat();
            bigCat.Eat();


            //I - Interface Segregation Principle (Клиент не должен зависеть от методов которые не используются!)
            //Вроде WildDog должен наследовать интерфейс IDog но он не сможет использовать метод Training();
            //Вместо того что бы наследоватся от IDog и играть с костылями в виде Exception мы просто реализуем отдельный интерфейс с нужными методами
            //и наследуемся от него
            WildDog wolf = new WildDog();
            wolf.Hunt();


            //D - Dependency Injection Principle(Нужно абстрагироватся и лишать жёстких связей)
            //Возможно пример притянут за уши но ничего дельного придумать не смог...
            DeterminingTypeDog myDog = new DeterminingTypeDog(new FighterDog());
            
        }
    }
}
