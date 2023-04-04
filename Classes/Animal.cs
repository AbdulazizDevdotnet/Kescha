namespace KESCHA.Classes
{
    public abstract class Animal
    {
        private int age;
        private string password = "Abdulaziz20";
        public string Name { get; set; }
        public int Age {get; set; }
        public int AgeDifference { get; set; }

        public Animal()
        {
            Name = "No name";
            Age = 0;
            AgeDifference = 0;
        }
        public Animal(string name,int age)
        {
            Age = age;
            Name = name;
        }
        public Animal(
            string name,
            int userAge, 
            int animalAge)
        {
            Name = name;
            Age = animalAge;
            // AgeDifference = CalculateAgeDifference(userAge , animalAge);
            // CalculateAgeDifferenceNoReturn(userAge, animalAge);
        }
        public virtual void Greeting(string userName)
        {
            Console.WriteLine($"Hello {userName} how are you");
        }
        public abstract void Greeting2(string userName);
        public void PrintAgeDifference()
        {
            Console.WriteLine($"The difference betwen your and {Name}'s age is {AgeDifference}");
        }
        public void CompareAges(int userAge,string userName)
        {
            if(Age > userAge)
            {
                Console.WriteLine($"{userName} siz {Name}dan {Age - userAge} yoshga kichik ekansiz");
            }
            else if(Age == userAge)
            {
                Console.WriteLine($"{userName} siz {Name} bilan teng ekansiz");
            }
            else
            {
                Console.WriteLine($"{userName} siz {Name}an {userAge - Age} yoshga katta ekansiz");
            }
        }
        public void TellAboutFriends(string userName,int userAge)
        {
            System.Console.WriteLine("Let me tell you about my friends.");
            string[] friendsName = { "Qarg'a", "Chumchuq", "Layle" ,"To'viq", userName};
            short[] friendsAge = { 2, 3, 4, 5, (short)userAge};
            string[] address = { "Istalba", "Sim", "baland istalbani uchi", "Katak","O'z uyida"};
            short sanoq = 0;
            while(sanoq < friendsName.Length)
            {
                Console.WriteLine($"{friendsName[sanoq]} is {friendsAge[sanoq]} years old and he is from {address[sanoq]}");
                sanoq++;
            }
        }
        public void Security()
        {
            string passwordUser = "";
            Console.Write("Dasturdan foydalanish uchun parol kiriting: ");
            passwordUser = Console.ReadLine();
            if(passwordUser != password)
            {
                do
                {
                    Console.Write("Xato parol!\nParolni kiriting: ");
                    passwordUser = Console.ReadLine();
                }while(passwordUser != password);
            }
        }
        private int CalculateAgeDifference(int userAge, int animalAge)
        {
            return userAge > animalAge?
            userAge - animalAge:
            animalAge-userAge;        
        }
        public void CalculateAgeDifferenceNoReturn(int userAge)
        {
            AgeDifference = userAge - Age;
        }
    }
}