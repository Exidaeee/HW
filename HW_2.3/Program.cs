using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cat cat1 = new Cat("Bush", "red", 3);
            cat1.Eat();
            Cat cat2 = new Cat("Maer", "black", 5);
            cat2.Color();
            Cat cat3 = new Cat("Rea", "white", 4);
            Dog dog1 = new Dog("Spike", "gold", 1);
            dog1.Color();
            Dog dog2 = new Dog("Umbra", "white", 7);
            dog2.Drink();
            Dog dog3 = new Dog("Lacki", "black", 1);
            Bird bird1 = new Bird("Kesh", "Green", 6);
            Bird bird2 = new Bird("Mix", "Write", 2);
            bird2.Sleep();
            Pets[] pets = new Pets[] { cat1, cat2, cat3, dog1, dog2, dog3, bird1, bird2 };
            Array.Sort(pets);
            for (int i = 0; i < pets.Length; i++)
            {
                Console.WriteLine($"{pets[i].age} has {pets[i].name} ");
            }

        }
    }
}
