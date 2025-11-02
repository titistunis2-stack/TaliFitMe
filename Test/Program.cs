using Model;
using System;
using ViewModel;
public class Program
{
    public static void Main(string[] args)
    {
         Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Genders:");
        Console.ResetColor();
        GenderDB gn = new();
        GenderList gList = gn.SelectAll();
        foreach (Gender g in gList)
            Console.WriteLine(g.Gender_name);
        Console.WriteLine();

         Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Subscriptionss:");
        Console.ResetColor();
        SubscriptionDB s = new();
        SubscriptionList sList = s.SelectAll();
        foreach (Subscription su in sList)
            Console.WriteLine(su.Name_of_sub);

        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Persons:");
        Console.ResetColor();
        PersonDB pdb = new();
        PersonList pList = pdb.SelectAll();
        foreach (Person c in pList)
            Console.WriteLine(c.First_name);

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Trainers:");
        Console.ResetColor();
        TrainerDB Trainers = new();
        TrainerList hList = Trainers.SelectAll();
        foreach (Trainer Trainerss in hList)
            Console.WriteLine(Trainerss.Paymet_per_hour);

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("List_of_Exc_workouts:");
        Console.ResetColor();
        List_of_Exc_workoutsDB l = new();
        List_of_Exc_workoutsList lList = l.SelectAll();
        foreach (List_of_Exc_workouts c in lList)
            Console.WriteLine(c.Workout_date);
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Trainee:");
        Console.ResetColor();
        TraineeDB e = new();
        TraineeList eList = e.SelectAll();
        foreach (Trainee Trainees in eList)
            Console.WriteLine(Trainees.Joining_date);

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Kinds_of_workouts:");
        Console.ResetColor();
        Kinds_of_workoutsDB Kinds_of_workoutss = new();
        Kinds_of_workoutsList Kinds_of_workoutsList = Kinds_of_workoutss.SelectAll();
        foreach (Kinds_of_workouts Kinds_of_workoutsss in Kinds_of_workoutsList)
            Console.WriteLine(Kinds_of_workoutsss.Max_amount_of_people);

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Training_registration:");
        Console.ResetColor();
        Training_registrationDB Training_registrations = new();
        Training_registrationList Training_registrationList = Training_registrations.SelectAll();
        foreach (Training_registration Training_registrationss in Training_registrationList)
            Console.WriteLine(Training_registrationss.Id_excWorkouts.Workout_time);

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Workouts_of_trainers:");
        Console.ResetColor();
        Workouts_of_trainersDB Workouts_of_trainers = new();
        Workouts_of_trainersList Workouts_of_trainersList = Workouts_of_trainers.SelectAll();
        foreach (Workouts_of_trainers Workouts_of_trainersss in Workouts_of_trainersList)
            Console.WriteLine(Workouts_of_trainersss.Id_kindsOfWorkouts.Name_of_workout);

    }
}
    
    

