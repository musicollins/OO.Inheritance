using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public interface IAnimal
    {
        void BuyMe();
        void animalSound(); // interface method (does not have a body) 
        void run(); // interface method (does not have a body) 
    }

    public class Dog : IAnimal
    {


        public void animalSound()
        {
            Console.WriteLine("Woof Woof");
        }

        public void BuyMe()
        {
            Console.WriteLine($"You just bought a {nameof(Dog)}");
        }

        public void run()
        {
            Console.WriteLine($"{nameof(Dog)} is running!");
        }
    }

    public class Cat : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("Miau Miau");
        }

        public void BuyMe()
        {
            Console.WriteLine($"You just bought a {nameof(Cat)}");
        }

        public void run()
        {
            Console.WriteLine($"{nameof(Cat)} is running!");
        }
    }

    public class Iguana : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("Iguanaaaaa");
        }

        public void BuyMe()
        {
            Console.WriteLine($"You just bought a {nameof(Iguana)}");
        }

        public void run()
        {
            Console.WriteLine($"{nameof(Iguana)} is running!");
        }
    }
}
