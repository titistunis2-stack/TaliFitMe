using Service;
using Model;
namespace TestApi1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Apiservice api = new Apiservice();
            PersonList pList=await api.GetAllPerson();
            foreach (var person in pList)
            {
                Console.WriteLine($"ID: {person.Id}, Name: {person.User_name}");
            }   



        }
    }
}
