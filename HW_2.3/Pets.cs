using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2._3
{
    internal class Pets : IComparable
    {
        public Pets(string name, string color, int years)
        {
            this.age = years;
            this.name = name;
            this.color = color;
        }
        public int age;
        public string name;
        public string color;
        public virtual void Eat()
        {
            Console.WriteLine($"Your pets want to eat");
        }
        public virtual void Drink()
        {
            Console.WriteLine($"Your pets want to drink");
        }
        public virtual void Sleep()
        {
            Console.WriteLine($"Your pets want to sleep");
        }
        public virtual void Color()
        {
            Console.WriteLine($"Pats {name} has {color} color");
        }
        public int CompareTo(object obj)
        {
            Pets p = obj as Pets;
            if (p != null)
            {
                if (this.age < p.age)
                    return -1;
                else if (this.age > p.age)
                    return 1;
                else return 0;
            }
            return 0;
        }
    }
    class Cat : Pets
    {
        public Cat(string name, string color, int years) : base(name, color, years)
        {

        }

        public override void Eat()
        {
            Console.WriteLine($"Your cat want to eat");
        }
        public override void Drink()
        {
            Console.WriteLine($"Your cat want to drink");
        }
        public override void Sleep()
        {
            Console.WriteLine($"Your cat want to sleep");
        }
        public override void Color()
        {
            Console.WriteLine($"Cat {name} has {color} color");
        }
    }
    class Dog : Pets
    {
        public Dog(string name, string color, int years) : base(name, color, years)
        {

        }

        public override void Eat()
        {
            Console.WriteLine($"Your dog want to eat");
        }
        public override void Drink()
        {
            Console.WriteLine($"Your dog want to drink");
        }
        public override void Sleep()
        {
            Console.WriteLine($"Your dog want to sleep");
        }
        public override void Color()
        {
            Console.WriteLine($"Dog {name} has {color} color");
        }
    }
    class Bird : Pets
    {
        public Bird(string name, string color, int years) : base(name, color, years)
        {

        }

        public override void Eat()
        {
            Console.WriteLine($"Your bird want to eat");
        }
        public override void Drink()
        {
            Console.WriteLine($"Your bird want to drink");
        }
        public override void Sleep()
        {
            Console.WriteLine($"Your bird want to sleep");
        }
        public override void Color()
        {
            Console.WriteLine($"Bird {name} has {color} color");
        }
    }

}   

