using Model;
using System;
using ViewModel;
public class Program
{
    public static void Main(string[] args)
    {
        //GenderDB gn = new();
        //GenderList gList = gn.SelectAll();
        //foreach (Gender g in gList)
        //    Console.WriteLine(g.Gender_name);


        //SubscriptionDB s = new();
        //SubscriptionList sList = s.SelectAll();
        //foreach (Subscription su in sList)
        //    Console.WriteLine(su.Name_of_sub);

       


        //PersonDB pdb = new();
        //PersonList pList = pdb.SelectAll();
        //foreach (Person c in pList)
        //    Console.WriteLine(c.First_name);

       TraineeDB te = new();
       TraineeList teList = te.SelectAll();
        foreach (Trainee t in teList)
            Console.WriteLine(t.Health_Declaration);

    }
}
    
    

