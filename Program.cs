string password = "";
do
{
    System.Console.Write("Dasturdan foydalanish uchun parol kiriting: ");
    password = System.Console.ReadLine();
}while(password != "Abdulaziz20");


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

System.Console.WriteLine(yourAge >= keschasAge ?yourAge > keschasAge ?"Siz Keschadan kattasiz":"Sizning kescha bilan yoshingiz teng" : "Siz Keschadan kichkinasiz ");
System.Console.WriteLine("Let me tell you about my friends.");
string[] friendsName = { "Qarg'a", "Chumchuq", "Layle" ,"To'viq"};
short[] friendsAge = { 2, 3, 4, 5};
string[] address = { "Istalba", "Sim", "baland istalbani uchi", "Katak"};
short sanoq = 0;
while(sanoq < 4)
{
    System.Console.WriteLine($"{friendsName[sanoq]} is {friendsAge[sanoq]} years old and he is from {address[sanoq]}");
    sanoq++;
}

foreach(string friendName in friendsName)
{
    System.Console.WriteLine(friendName);
}