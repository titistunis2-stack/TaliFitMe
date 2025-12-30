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

            Person p1 = new Person() { First_name = "Naftali" };
            await api.InsertAPerson(p1);
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

            Gender g1 = new Gender() { Gender_name = "NewGender" };
            await api.InsertAGender(g1);
            Gender myGender = gList.First();
            myGender.Gender_name = "UpdatedName";
            await api.UpdateAGender(myGender);
            Console.WriteLine();


            SubscriptionList sList = await api.GetAllSubscription();
            Console.WriteLine(sList.Count);
             id = sList.Last().Id;
            await api.DeleteASubscription(id);
            sList = await api.GetAllSubscription();
            Console.WriteLine(sList.Count);

            Subscription s1 = new Subscription() { Name_of_sub = "twice a day" };
            await api.InsertASubscription(s1);
            Subscription mySubscription = sList.First();
            mySubscription.Name_of_sub = "UpdatedName";
            await api.UpdateASubscription(mySubscription);
            Console.WriteLine();


            TrainerList tList = await api.GetAllTrainer();
            Console.WriteLine(tList.Count);
             id = tList.Last().Id;
            await api.DeleteATrainer(id);
            tList = await api.GetAllTrainer();
            Console.WriteLine(tList.Count);

            Trainer t1 = new Trainer() { First_name = "Natali" };
            await api.InsertATrainer(t1);
            Trainer myTrainer = tList.First();
            myTrainer.First_name = "UpdatedName";
            await api.UpdateATrainer(myTrainer);
            Console.WriteLine();


            TraineeList teList = await api.GetAllTrainee();
            Console.WriteLine(teList.Count);
             id = teList.Last().Id;
            await api.DeleteATrainee(id);
            teList = await api.GetAllTrainee();
            Console.WriteLine(teList.Count);

            Trainee te1 = new Trainee() { First_name = "Natali" };
            await api.InsertATrainee(te1);
            Trainee myTrainee = teList.First();
            myTrainee.First_name = "UpdatedName";
            await api.UpdateATrainee(myTrainee);
            Console.WriteLine();



            Kinds_of_workoutsList kList = await api.GetAllKinds_of_workouts();
            Console.WriteLine(kList.Count);
             id = kList.Last().Id;
            await api.DeleteAKinds_of_workouts(id);
            kList = await api.GetAllKinds_of_workouts();
            Console.WriteLine(kList.Count);

            Kinds_of_workouts k1 = new Kinds_of_workouts() { Name_of_workout = "ice skating" };
            await api.InsertAKinds_of_workouts(k1);
            Kinds_of_workouts myKinds_of_workouts = kList.First();
            myKinds_of_workouts.Name_of_workout = "UpdatedName";
            await api.UpdateAKinds_of_workouts(myKinds_of_workouts);
            Console.WriteLine();




            Workouts_of_trainersList wList = await api.GetAllWorkouts_of_trainers();
            Console.WriteLine(wList.Count);
             id = wList.Last().Id;
            await api.DeleteAWorkouts_of_trainers(id);
            wList = await api.GetAllWorkouts_of_trainers();
            Console.WriteLine(wList.Count);

            Workouts_of_trainers w1 = new Workouts_of_trainers() { };
            await api.InsertAWorkouts_of_trainers(w1);
            Workouts_of_trainers myWorkouts_of_trainers = wList.First();
            myWorkouts_of_trainers.Id_trainer.First_name = "UpdatedName";
            await api.UpdateAWorkouts_of_trainers(myWorkouts_of_trainers);
            Console.WriteLine();



            Training_registrationList trList = await api.GetAllTraining_registration();
            Console.WriteLine("Before" + trList.Count);
             id = trList.Last().Id;
            await api.DeleteATraining_registration(id);
            trList = await api.GetAllTraining_registration();
            Console.WriteLine("After" + trList.Count);

            Training_registration tr1 = new Training_registration() { Id_trainee = new Trainee() { Id = 50 } };
            await api.InsertATraining_registration(tr1);
            Training_registration myTraining_registration = trList.First();
            myTraining_registration.Id_trainee.Telephone = "UpdatedName";
            await api.UpdateATraining_registration(myTraining_registration);
            Console.WriteLine();



            List_of_Exc_workoutsList leList = await api.GetAllList_of_Exc_workouts();
            Console.WriteLine(leList.Count);
             id = leList.Last().Id;
            await api.DeleteAList_of_Exc_workouts(id);
            leList = await api.GetAllList_of_Exc_workouts();
            Console.WriteLine(leList.Count);

            List_of_Exc_workouts le1 = new List_of_Exc_workouts() { };
            await api.InsertAList_of_Exc_workouts(le1);
            List_of_Exc_workouts myList_of_Exc_workouts = leList.First();
            myList_of_Exc_workouts.Id_kindOf_workouts.Name_of_workout = "UpdatedName";
            await api.UpdateAList_of_Exc_workouts(myList_of_Exc_workouts);
            Console.WriteLine();




            Console.ReadLine();
        }
    }
}
