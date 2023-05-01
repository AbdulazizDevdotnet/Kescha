using System;
using KESCHA.Enums;

namespace KESCHA.Classes
{
    public class Pet : Animal,IAnimal,IPet
    {
        public PetType Type { get; set; }
        public Pet(string name, int age)
            :base(name, age)
        {

        }
        public override void Greeting(string userName)
        {
            Console.WriteLine($"Meow {userName}");
        }

        public override void Greeting2(string userName)
        {
            Console.WriteLine($"Hello {userName} my name is {Name} this is abstrakt method");
        }
    }
}