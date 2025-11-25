using Model;
using System;
using ViewModel;
using static System.Net.Mime.MediaTypeNames;
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

        Gender genderToUpdate = gList[0];
        genderToUpdate.Gender_name = "omer";
        gn.Update(genderToUpdate);
        int x = gn.SaveChanges();
        Console.WriteLine($"{x} row were updated");

        Gender gInsert = new Gender();
        gInsert.Gender_name = "non-binary";
        gn.Insert(gInsert);
        int q = gn.SaveChanges();
        Console.WriteLine($"{q} row were inserted");


        Console.WriteLine("\nDelete");
        Gender genderToDelete = gList.Last();
        gn.Delete(genderToDelete);
        int cy = gn.SaveChanges();
        Console.WriteLine($"{cy} rows were deleted");
        Console.WriteLine("genders after delete: ");
        gList = gn.SelectAll();
        foreach (Gender g in gList)
            Console.WriteLine(g.Gender_name);








        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Subscriptionss:");
        Console.ResetColor();
        SubscriptionDB s = new();
        SubscriptionList sList = s.SelectAll();
        foreach (Subscription su in sList)
            Console.WriteLine(su.Name_of_sub);

        Subscription subscriptionToUpdate = sList[0];
        subscriptionToUpdate.Name_of_sub = "omer";
        s.Update(subscriptionToUpdate);
        int o = s.SaveChanges();
        Console.WriteLine($"{o} row were updated");

        Subscription sInsert = new Subscription();
        sInsert.Name_of_sub = "5 times a week";
        sInsert.Price = 600;
        s.Insert(sInsert);
        int ss = s.SaveChanges();
        Console.WriteLine($"{ss} row were inserted");


        Console.WriteLine("\nDelete");
        Subscription subscriptionToDelete = sList.Last();
        s.Delete(subscriptionToDelete);
        int sssss = s.SaveChanges();
        Console.WriteLine($"{sssss} rows were deleted");
        Console.WriteLine("Subscriptions after delete: ");
        sList = s.SelectAll();
        foreach (Subscription sss in sList)
            Console.WriteLine(sss.Name_of_sub);



        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Persons:");
        Console.ResetColor();
        PersonDB pdb = new();
        PersonList pList = pdb.SelectAll();
        foreach (Person pe in pList)
            Console.WriteLine(pe.First_name);


        Person personToUpdate = pList[0];
        personToUpdate.First_name = "omer";
        pdb.Update(personToUpdate);
        int y = pdb.SaveChanges();
        Console.WriteLine($"{y} row were updated");


        Person pInsert = new Person();
        pInsert.First_name = "Alex";
        pInsert.Last_name = "Johnson";
        pInsert.Telephone = "0539272552";
        pInsert.Num_id = "A123456789";
        pInsert.Email = "AlexJonag5678@gmail.com";
        pInsert.Born_date = new DateTime(1995, 3, 15);
        pInsert.Photo = "alex_photo.jpg";
        pInsert.User_name = "AlexJ95";
        pInsert.Pass = "jajajajaaj45";
        pInsert.Id_gender = GenderDB.SelectById(1);
        pdb.Insert(pInsert);
        int z = pdb.SaveChanges();
        Console.WriteLine($"{z} row were inserted");


        Console.WriteLine("\nDelete");
        Person personToDelete = pList.Last();
        pdb.Delete(personToDelete);
        int per = pdb.SaveChanges();
        Console.WriteLine($"{per} rows were deleted");
        Console.WriteLine("Subscriptions after delete: ");
        pList = pdb.SelectAll();
        foreach (Person ppp in pList)
            Console.WriteLine(ppp.First_name);


        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Trainers:");
        Console.ResetColor();
        TrainerDB Trainers = new();
        TrainerList hList = Trainers.SelectAll();
        foreach (Trainer Trainerss in hList)
            Console.WriteLine(Trainerss.Paymet_per_hour);


        Trainer trainerToUpdate = hList[0];
        trainerToUpdate.Paymet_per_hour = 56;
        Trainers.Update(trainerToUpdate);
        int a = Trainers.SaveChanges();
        Console.WriteLine($"{a} row were updated");
        foreach (Trainer Trainerss in hList)
            Console.WriteLine(Trainerss.Paymet_per_hour);


        Trainer tInsert = new Trainer() { Last_name = "Choen", First_name = "Alona", Telephone = "0587624131", Born_date = new DateTime(1988, 3, 9), Num_id = "783261563", Email = "AlonaCh@gmail.com", Pass = "Alona2397326", User_name = "AlonaChoen23", Photo = "hgfhhk", Id_gender = gList[0] };
        tInsert.Paymet_per_hour = 890;
        tInsert.Certificate = "Yoga";
        tInsert.Experience = true;
        tInsert.Description = "teaching for 22 years";
        Trainers.Insert(tInsert);
        int eeee = Trainers.SaveChanges();
        Console.WriteLine($"{eeee} row were inserted");
        hList = Trainers.SelectAll();
        foreach (Trainer Trainerss in hList)
            Console.WriteLine(Trainerss.Certificate);


        Console.WriteLine("\nDelete");
        Trainer trainerToDelete = hList.Last();
        Trainers.Delete(trainerToDelete);
        int tr = Trainers.SaveChanges();
        Console.WriteLine($"{tr} rows were deleted");
        Console.WriteLine("Subscriptions after delete: ");
        hList = Trainers.SelectAll();
        foreach (Trainer teerr in hList)
            Console.WriteLine(teerr.Paymet_per_hour);





        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("List_of_Exc_workouts:");
        Console.ResetColor();
        List_of_Exc_workoutsDB l = new();
        List_of_Exc_workoutsList lList = l.SelectAll();
        foreach (List_of_Exc_workouts listofexc in lList)
            Console.WriteLine(listofexc.Workout_date);


        List_of_Exc_workouts list_of_Exc_workoutsToUpdate = lList[0];
        list_of_Exc_workoutsToUpdate.Workout_date = new DateTime(2025, 1, 1, 8,30,0);
        list_of_Exc_workoutsToUpdate.Id_trainer = hList[1];
        l.Update(list_of_Exc_workoutsToUpdate);
        int c = l.SaveChanges();
        Console.WriteLine($"{c} row were updated");
        foreach (List_of_Exc_workouts listofexc in lList)
            Console.WriteLine(listofexc.Workout_date);

        
        List_of_Exc_workouts lInsert = new List_of_Exc_workouts() { };
        lInsert.Id_trainer = TrainerDB.SelectById(3);
        lInsert.Id_kindOf_workouts = Kinds_of_workoutsDB.SelectById(3);
        lInsert.Workout_date = new DateTime(2024, 9, 10,12,30,0);
        l.Insert(lInsert);
        int ss1 = l.SaveChanges();
        Console.WriteLine($"{ss1} row were inserted");
        lList = l.SelectAll();
        foreach (List_of_Exc_workouts listofexc in lList)
            Console.WriteLine(listofexc.Workout_date);


        Console.WriteLine("\nDelete");
        List_of_Exc_workouts list_of_Exc_workoutsToDelete = lList.Last();
        l.Delete(list_of_Exc_workoutsToDelete);
        int ll = l.SaveChanges();
        Console.WriteLine($"{ll} rows were deleted");
        Console.WriteLine("List_of_Exc_workouts after delete: ");
        lList = l.SelectAll();
        foreach (List_of_Exc_workouts eetrr in lList)
            Console.WriteLine(eetrr.Workout_date);


        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Trainee:");
        Console.ResetColor();
        TraineeDB e = new();
        TraineeList eList = e.SelectAll();
        foreach (Trainee Trainees in eList)
            Console.WriteLine(Trainees.Joining_date);


        Trainee traineeToUpdate = eList[1];
        traineeToUpdate.Joining_date = new DateTime(2023, 5, 8);
        e.Update(traineeToUpdate);
        int b = e.SaveChanges();
        Console.WriteLine($"{b} row were updated");
        foreach (Trainee Trainees in eList)
            Console.WriteLine(Trainees.Joining_date);


        Trainee teInsert = new Trainee() { Last_name = "Choen", First_name = "Alona", Telephone = "0587624131", Born_date = new DateTime(1988, 3, 9), Num_id = "783261563", Email = "AlonaCh@gmail.com", Pass = "Alona2397326", User_name = "AlonaChoen23", Photo = "hgfhhk", Id_gender = gList[0] };
        teInsert.Health_Declaration = true;
        teInsert.Joining_date = new DateTime(2022, 7, 20);
        teInsert.Id_Sub = teInsert.Id_Sub = SubscriptionDB.SelectById(1);
        e.Insert(teInsert);
        int w = e.SaveChanges();
        Console.WriteLine($"{w} row were inserted");
        eList = e.SelectAll();
        foreach (Trainee Trainee in eList)
            Console.WriteLine(Trainee.Joining_date);


        Console.WriteLine("\nDelete");
        Trainee traineeToDelete = eList.Last();
        e.Delete(traineeToDelete);
        int te = e.SaveChanges();
        Console.WriteLine($"{te} rows were deleted");
        Console.WriteLine("Trainee after delete: ");
        eList = e.SelectAll();
        foreach (Trainee trre in eList)
            Console.WriteLine(trre.Joining_date);






        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Kinds_of_workouts:");
        Console.ResetColor();
        Kinds_of_workoutsDB Kinds_of_workoutss = new();
        Kinds_of_workoutsList Kinds_of_workoutsList = Kinds_of_workoutss.SelectAll();
        foreach (Kinds_of_workouts Kinds_of_workoutsss in Kinds_of_workoutsList)
            Console.WriteLine(Kinds_of_workoutsss.Name_of_workout);


        Kinds_of_workouts kinds_of_workoutsToUpdate = Kinds_of_workoutsList[1];
        kinds_of_workoutsToUpdate.Name_of_workout = "omer";
        Kinds_of_workoutss.Update(kinds_of_workoutsToUpdate);
        z = Kinds_of_workoutss.SaveChanges();
        Console.WriteLine($"{z} row were updated");


        Kinds_of_workouts kInsert = new Kinds_of_workouts();
        kInsert.Name_of_workout = "running";
        kInsert.Max_amount_of_people = 80;
        Kinds_of_workoutss.Insert(kInsert);
        ss = Kinds_of_workoutss.SaveChanges();
        Console.WriteLine($"{ss} row were inserted");
        foreach (Kinds_of_workouts Kinds_of_workoutsss in Kinds_of_workoutsList)
            Console.WriteLine(Kinds_of_workoutsss.Name_of_workout);


        Console.WriteLine("\nDelete");
        Kinds_of_workouts kinds_of_workoutsToDelete = Kinds_of_workoutsList.Last();
        Kinds_of_workoutss.Delete(kinds_of_workoutsToDelete);
        int kw = Kinds_of_workoutss.SaveChanges();
        Console.WriteLine($"{kw} rows were deleted");
        Console.WriteLine("Subscriptions after delete: ");
        Kinds_of_workoutsList = Kinds_of_workoutss.SelectAll();
        foreach (Kinds_of_workouts kk in Kinds_of_workoutsList)
            Console.WriteLine(kk.Name_of_workout);



        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Training_registration:");
        Console.ResetColor();
        Training_registrationDB Training_registrations = new();
        Training_registrationList Training_registrationList = Training_registrations.SelectAll();
        foreach (Training_registration Training_registrationss in Training_registrationList)
            Console.WriteLine(Training_registrationss.Id_excWorkouts.Workout_date);


        Training_registration training_registrationToUpdate = Training_registrationList[1];
        training_registrationToUpdate.Id_excWorkouts.Workout_date = new DateTime(1899, 12, 30, 20, 30, 0, 0);
        Training_registrations.Update(training_registrationToUpdate);
        int ww = Training_registrations.SaveChanges();
        Console.WriteLine($"{ww} row were updated");
        foreach (Training_registration Training_registrationss in Training_registrationList)
            Console.WriteLine(Training_registrationss.Id_excWorkouts.Workout_date);


        Training_registration trInsert = new Training_registration();
        trInsert.Id_excWorkouts = List_of_Exc_workoutsDB.SelectById(1);
        trInsert.Id_trainee = TraineeDB.SelectById(2);
        Training_registrations.Insert(trInsert);
        int qq = Training_registrations.SaveChanges();
        Console.WriteLine($"{qq} row were inserted");
        Training_registrationList = Training_registrations.SelectAll();
        foreach (Training_registration Training_registrationss in Training_registrationList)
            Console.WriteLine(Training_registrationss.Id_excWorkouts.Workout_date);

        Console.WriteLine("\nDelete");
        Training_registration training_registrationToDelete = Training_registrationList.Last();
        Training_registrations.Delete(training_registrationToDelete);
        int trr = Training_registrations.SaveChanges();
        Console.WriteLine($"{trr} rows were deleted");
        Console.WriteLine("Training_registration after delete: ");
        Training_registrationList = Training_registrations.SelectAll();
        foreach (Training_registration trrr in Training_registrationList)
            Console.WriteLine(trrr.Id_excWorkouts.Workout_date);





        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Workouts_of_trainers:");
        Console.ResetColor();
        Workouts_of_trainersDB Workouts_of_trainers = new();
        Workouts_of_trainersList Workouts_of_trainersList = Workouts_of_trainers.SelectAll();
        foreach (Workouts_of_trainers Workouts_of_trainersss in Workouts_of_trainersList)
            Console.WriteLine(Workouts_of_trainersss.Id_kind_of_workouts.Name_of_workout);


        Workouts_of_trainers Workouts_of_trainersToUpdate = Workouts_of_trainersList[1];
        Workouts_of_trainersToUpdate.Id_kind_of_workouts.Name_of_workout = "tola";
        Workouts_of_trainers.Update(Workouts_of_trainersToUpdate);
        int wb = Workouts_of_trainers.SaveChanges();
        Console.WriteLine($"{wb} row were updated");
        foreach (Workouts_of_trainers Workouts_of_trainerss in Workouts_of_trainersList)
            Console.WriteLine(Workouts_of_trainerss.Id_kind_of_workouts.Name_of_workout);

        Workouts_of_trainers wInsert = new Workouts_of_trainers();
        wInsert.Id_trainer = TrainerDB.SelectById(7);
        wInsert.Id_kind_of_workouts = Kinds_of_workoutsDB.SelectById(2);
        Workouts_of_trainers.Insert(wInsert);
        int wq = Workouts_of_trainers.SaveChanges();
        Console.WriteLine($"{wq} row were inserted");
        Workouts_of_trainersList = Workouts_of_trainers.SelectAll();
        foreach (Workouts_of_trainers Workouts_of_trainerss in Workouts_of_trainersList)
            Console.WriteLine(Workouts_of_trainerss.Id_kind_of_workouts.Name_of_workout);


        Console.WriteLine("\nDelete");
        Workouts_of_trainers Workouts_of_trainersToDelete = Workouts_of_trainersList.Last();
        Workouts_of_trainers.Delete(Workouts_of_trainersToDelete);
        int wtr = Workouts_of_trainers.SaveChanges();
        Console.WriteLine($"{wtr} rows were deleted");
        Console.WriteLine("Workouts_of_trainers after delete: ");
        Workouts_of_trainersList = Workouts_of_trainers.SelectAll();
        foreach (Workouts_of_trainers wtrr in Workouts_of_trainersList)
            Console.WriteLine(wtrr.Id_kind_of_workouts.Name_of_workout);















    }
}



