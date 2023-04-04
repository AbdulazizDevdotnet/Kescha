using KESCHA.Classes;

namespace KESCHA
{
    class Program
    {
        static void Main()
        {
            try
            {
                Animal kescha = new Bird(name: "Kescha", age: 5);
                Animal kasee = new Pet(name: "Kasee", age: 7);
                kescha.Security();

                Console.Write("\t HEY WELCOME \nPlease input your name: ");
                string userName = Console.ReadLine();
                Console.Write("Please input your age: ");
                short userAge = Convert.ToInt16(Console.ReadLine());
                kasee.Greeting2(userName);
                kescha.Greeting2(userName);
                kasee.Greeting(userName);
                kescha.Greeting(userName);
                kescha.CalculateAgeDifferenceNoReturn(userAge);
                // Console.WriteLine(kescha.Name);
                // Console.WriteLine(kescha.Age);
                kescha.PrintAgeDifference();
                kescha.CompareAges(userAge,userName);
                kescha.TellAboutFriends(userName,userAge);
                // System.Console.WriteLine(yourAge >= kescha.Age ?yourAge > kescha.Age ?"Siz Keschadan kattasiz":"Sizning kescha bilan yoshingiz teng" : "Siz Keschadan kichkinasiz ");
                
            }
            catch (FormatException formatException)
            {
                System.Console.WriteLine($"Error was thrown. Message: {formatException.Message}");
            }
            catch (Exception exception)
            {
                System.Console.WriteLine($"Error Message: {exception.Message}");
            }
            // Animal kescha = new Bird(name: "Kescha", age: 5);
            // Animal kasee = new Pet(name: "Kasee", age: 7);
            // kescha.Security();

            // Console.Write("\t HEY WELCOME \nPlease input your name: ");
            // string userName = Console.ReadLine();
            // Console.Write("Please input your age: ");
            // short userAge = Convert.ToInt16(Console.ReadLine());
            // kasee.Greeting2(userName);
            // kescha.Greeting2(userName);
            // kasee.Greeting(userName);
            // kescha.Greeting(userName);
            // kescha.CalculateAgeDifferenceNoReturn(userAge);
            // // Console.WriteLine(kescha.Name);
            // // Console.WriteLine(kescha.Age);
            // kescha.PrintAgeDifference();
            // kescha.CompareAges(userAge,userName);
            // kescha.TellAboutFriends(userName,userAge);
            // // System.Console.WriteLine(yourAge >= kescha.Age ?yourAge > kescha.Age ?"Siz Keschadan kattasiz":"Sizning kescha bilan yoshingiz teng" : "Siz Keschadan kichkinasiz ");

        }
    }
}
