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
        //Console.WriteLine();

        //SubscriptionDB s = new();
        //SubscriptionList sList = s.SelectAll();
        //foreach (Subscription su in sList)
        //    Console.WriteLine(su.Name_of_sub);

        //Console.WriteLine();


        ////PersonDB pdb = new();
        ////PersonList pList = pdb.SelectAll();
        ////foreach (Person c in pList)
        ////    Console.WriteLine(c.First_name);


        //TrainerDB p = new();
        //TrainerList pList = p.SelectAll();
        //foreach (Trainer c in pList)
        //    Console.WriteLine(c.Paymet_per_hour);

        //List_of_Exc_workoutsDB l = new();
        //List_of_Exc_workoutsList lList = l.SelectAll();
        //foreach (List_of_Exc_workouts c in lList)
        //    Console.WriteLine(c.Workout_date);
        //Console.WriteLine();

        TraineeDB e = new();
        TraineeList eList = e.SelectAll();
        foreach (Trainee c in eList)
            Console.WriteLine(c.Joining_date);

        //Kinds_of_workoutsDB k = new();
        //Kinds_of_workoutsList kList = k.SelectAll();
        //foreach (Kinds_of_workouts c in kList)
        //    Console.WriteLine(c.Name_of_workout);

    }
}
    
    

