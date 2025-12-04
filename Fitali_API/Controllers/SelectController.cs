using Microsoft.AspNetCore.Mvc;
using Model;
using ViewModel;

namespace Fitali_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SelectController : ControllerBase
    {
        [HttpGet]
        [ActionName("GenderSelector")]

        public GenderList SelectAllGenders()
        {
            GenderDB db=new GenderDB();
            GenderList genders=db.SelectAll();
            return genders;
        }
        [HttpPost]
        public int InsertAGender([FromBody] Gender gender)
        {
            GenderDB db= new GenderDB();
            db.Insert(gender);
            int x = db.SaveChanges();
            return x;
        }
        [HttpDelete("{id}")]
        public int DeleteAGender(int id)
        {
            Gender gender = GenderDB.SelectById(id);
            GenderDB db = new GenderDB();
            db.Delete(gender);
            int x = db.SaveChanges();
            return x;
        }

        [HttpGet]
        [ActionName("PersonSelector")]

        public PersonList SelectAllPerson()
        {
            PersonDB db = new PersonDB();
            PersonList persons = db.SelectAll();
            return persons;
        }
        [HttpPost]
        public int InsertAPerson(Person p)
        {
            PersonDB db = new PersonDB();
            db.Insert(p);
            int x = db.SaveChanges();
            return x;
        }
        public int DeleteAPerson(int id)
        {
            Person person = PersonDB.SelectById(id);
            PersonDB db = new PersonDB();
            db.Delete(person);
            int x = db.SaveChanges();
            return x;
        }

        [HttpGet]
        [ActionName("SubscriptionSelector")]
        public SubscriptionList SelectAllSubscription()
        {
            SubscriptionDB db = new SubscriptionDB();
            SubscriptionList subscription = db.SelectAll();
            return subscription;
        }
        [HttpGet]
        [ActionName("TrainerSelector")]

        public int InsertASubscription(Subscription s)
        {
            SubscriptionDB db = new SubscriptionDB();
            db.Insert(s);
            int x = db.SaveChanges();
            return x;
        } 
        public TrainerList SelectAllTrainer()
        {
            TrainerDB db = new TrainerDB();
            TrainerList trainers = db.SelectAll();
            return trainers;
        }
        [HttpGet]
        [ActionName("TraineeSelector")]

        public int InsertATrainer(Trainer t)
        {
            TrainerDB db = new TrainerDB();
            db.Insert(t);
            int x = db.SaveChanges();
            return x;
        }
        public TraineeList SelectAllTrainee()
        {
            TraineeDB db = new TraineeDB();
            TraineeList trainees = db.SelectAll();
            return trainees;
        }
        [HttpGet]
        [ActionName("Training_registrationSelector")]

        public int InsertATrainee(Trainee te)
        {
            TraineeDB db = new TraineeDB();
            db.Insert(te);
            int x = db.SaveChanges();
            return x;
        }
        public Training_registrationList SelectAllTraining_registration()
        {
            Training_registrationDB db = new Training_registrationDB();
            Training_registrationList training_registrations = db.SelectAll();
            return training_registrations;
        }

        public int InsertATraining_registration(Training_registration tr)
        {
            Training_registrationDB db = new Training_registrationDB();
            db.Insert(tr);
            int x = db.SaveChanges();
            return x;
        }
        [HttpGet]
        [ActionName("Workouts_of_trainersSelector")]

        public Workouts_of_trainersList SelectAllWorkouts_of_trainers()
        {
            Workouts_of_trainersDB db = new Workouts_of_trainersDB();
            Workouts_of_trainersList workouts_of_trainerss = db.SelectAll();
            return workouts_of_trainerss;
        }
        public int InsertAWorkouts_of_trainers(Workouts_of_trainers w)
        {
            Workouts_of_trainersDB db = new Workouts_of_trainersDB();
            db.Insert(w);
            int x = db.SaveChanges();
            return x;
        }

        [HttpGet]
        [ActionName("Kinds_of_workoutsSelector")]

        public Kinds_of_workoutsList SelectAllKinds_of_workouts()
        {
            Kinds_of_workoutsDB db = new Kinds_of_workoutsDB();
            Kinds_of_workoutsList kinds_of_workoutss = db.SelectAll();
            return kinds_of_workoutss;
        }

        public int InsertAKinds_of_workouts(Kinds_of_workouts kw)
        {
            Kinds_of_workoutsDB db = new Kinds_of_workoutsDB();
            db.Insert(kw);
            int x = db.SaveChanges();
            return x;
        }
        [HttpGet]
        [ActionName("List_of_Exc_workoutsSelector")]

        public List_of_Exc_workoutsList SelectAllList_of_Exc_workouts()
        {
            List_of_Exc_workoutsDB db = new List_of_Exc_workoutsDB();
            List_of_Exc_workoutsList list_of_Exc_workoutss = db.SelectAll();
            return list_of_Exc_workoutss;
        }
        public int InsertAList_of_Exc_workouts(List_of_Exc_workouts l)
        {
            List_of_Exc_workoutsDB db = new List_of_Exc_workoutsDB();
            db.Insert(l);
            int x = db.SaveChanges();
            return x;
        }



















        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
