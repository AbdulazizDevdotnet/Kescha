using KESCHA.Classes;

namespace KESCHA
{
    class Program
    {
        static void Main()
        {
            Animal kescha = new Animal(name: "Kescha", age: 5);
            kescha.Security();

            Console.Write("\t HEY WELCOME \nPlease input your name: ");
            string userName = Console.ReadLine();
            Console.Write("Please input your age: ");
            short userAge = Convert.ToInt16(Console.ReadLine());
            kescha.CalculateAgeDifferenceNoReturn(userAge);
            // Console.WriteLine(kescha.Name);
            // Console.WriteLine(kescha.Age);
            kescha.PrintAgeDifference();
            kescha.CompareAges(userAge,userName);
            kescha.TellAboutFriends(userName,userAge);
            // System.Console.WriteLine(yourAge >= kescha.Age ?yourAge > kescha.Age ?"Siz Keschadan kattasiz":"Sizning kescha bilan yoshingiz teng" : "Siz Keschadan kichkinasiz ");

        }
    }
}
