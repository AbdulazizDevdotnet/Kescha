using System;

namespace KESCHA.Classes
{
    public class Pet : Animal
    {
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