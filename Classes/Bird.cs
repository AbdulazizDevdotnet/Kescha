using System;

namespace KESCHA.Classes
{
    public class Bird : Animal,IAnimal,IBird
    {
        public Bird(string name, int age)
            : base(name,age)
        {

        }
        public override void Greeting(string userName)
        {
            Console.WriteLine($"Hello {userName}");
        }

        public override void Greeting2(string userName)
        {
            System.Console.WriteLine($"Hello {userName} my name is {Name} this is abstract method");;
        }
    }
}