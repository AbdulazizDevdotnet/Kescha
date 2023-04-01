System.Console.Write("\t HEY WELCOME \nPlease input your name: ");
string yourName = System.Console.ReadLine();
System.Console.Write("Please input your age: ");
short yourAge = System.Convert.ToInt16(System.Console.ReadLine());
short keschasAge = 7;
if(keschasAge > yourAge)
{
    System.Console.WriteLine($"{yourName} siz Keschadan {keschasAge - yourAge} yoshga kichik ekansiz");
}
else if(keschasAge == yourAge)
{
    System.Console.WriteLine($"{yourName} siz Kescha bilan teng ekansiz");
}
else
{
    System.Console.WriteLine($"{yourName} siz Keschadan {yourAge - keschasAge} yoshga katta ekansiz");
}