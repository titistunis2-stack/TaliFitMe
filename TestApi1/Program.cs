using Service;
using Model;
namespace TestApi1
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Apiservice api = new Apiservice();
            PersonList pList = await api.GetAllPerson();
            Console.WriteLine(pList.Count);
            int id = pList.Last().Id;
            await api.DeleteAPerson(id);
            pList = await api.GetAllPerson();
            Console.WriteLine(pList.Count);

            Person p1 = new Person(){ First_name= "Naftali" };
            await  api.InsertAPerson(p1);
            Person myPerson = pList.First();
            myPerson.First_name = "UpdatedName";
            await api.UpdateAPerson(myPerson);
            Console.WriteLine();


            
            GenderList gList = await api.GetAllGender();
            Console.WriteLine(gList.Count);
             id = gList.Last().Id;
            await api.DeleteAGender(id);
            gList = await api.GetAllGender();
            Console.WriteLine(gList.Count);

            Gender g1 = new Gender() {Gender_name="NewGender" };
            await api.InsertAGender(g1);
            Gender myGender = gList.First();
            myGender.Gender_name = "UpdatedName";
            await api.UpdateAGender(myGender);
            Console.WriteLine();


           




            Console.ReadLine();
        }
    }
}
