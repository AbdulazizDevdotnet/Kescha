
namespace KESCHA.Classes
{
    public interface IAnimal
    {
        void PrintAgeDifference();
        void Greeting(string userName);
        void Greeting2(string userName);
        void CompareAges(int userAge,string userName);
        void TellAboutFriends(string userName,int userAge);
        void Security();
        // int CalculateAgeDifference(int userAge, int animalAge);
        void CalculateAgeDifferenceNoReturn(int userAge);
    }
}