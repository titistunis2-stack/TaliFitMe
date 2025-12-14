using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Model;

namespace Service
{
    public class Apiservice: IApiService
    {
        string uri;
        public HttpClient client;
        public Apiservice()
        {
          uri = "https://fitalibackendapi.azurewebsites.net/api/";
            client = new HttpClient();
            //client.BaseAddress = new Uri(uri);
        }
        public async Task<PersonList>GetAllPerson()
        {
            return await client.GetFromJsonAsync<PersonList>(uri+"/api/Insert/personSelector");
        }
        public async Task<int> DeleteAPerson(int id)
        {
            return  (await client.DeleteAsync(uri+"api/Insert/DeletePerson/"+id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertAPerson(Person person)
        {
            return (await client.PostAsJsonAsync<Person>(uri+"api/Insert/InsertPerson", person)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateAPerson(Person person)
        {
            return (await client.PutAsJsonAsync<Person>(uri+"api/Insert/UpdatePerson", person)).IsSuccessStatusCode ? 1 : 0;
        }


        public async Task<GenderList> GetAllGender()
        {
            return await client.GetFromJsonAsync<GenderList>(uri + "/api/Insert/genderSelector");
        }
        public async Task<int> DeleteAGender(int id)
        {
            return (await client.DeleteAsync(uri + "api/Insert/DeleteGender/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertAGender(Gender gender)
        {
            return (await client.PostAsJsonAsync<Gender>(uri + "api/Insert/InsertGender", gender)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateAGender(Gender gender)
        {
            return (await client.PutAsJsonAsync<Gender>(uri + "api/Insert/UpdateGender", gender)).IsSuccessStatusCode ? 1 : 0;
        }


        public async Task<SubscriptionList> GetAllSubscription()
        {
            return await client.GetFromJsonAsync<SubscriptionList>(uri + "/api/Insert/subscriptionSelector");
        }
        public async Task<int> DeleteASubscription(int id)
        {
            return (await client.DeleteAsync(uri + "api/Insert/DeleteSubscription/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertASubscription(Subscription subscription)
        {
            return (await client.PostAsJsonAsync<Subscription>(uri + "api/Insert/InsertSubscription", subscription)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateASubscription(Subscription subscription)
        {
            return (await client.PutAsJsonAsync<Subscription>(uri + "api/Insert/UpdateSubscription", subscription)).IsSuccessStatusCode ? 1 : 0;
        }


        public async Task<TrainerList> GetAllTrainer()
        {
            return await client.GetFromJsonAsync<TrainerList>(uri + "/api/Insert/trainerSelector");
        }
        public async Task<int> DeleteATrainer(int id)
        {
            return (await client.DeleteAsync(uri + "api/Insert/DeleteTrainer/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertATrainer(Trainer trainer)
        {
            return (await client.PostAsJsonAsync<Trainer>(uri + "api/Insert/InsertTrainer", trainer)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateATrainer(Trainer trainer)
        {
            return (await client.PutAsJsonAsync<Trainer>(uri + "api/Insert/UpdateTrainer", trainer)).IsSuccessStatusCode ? 1 : 0;
        }



        public async Task<TraineeList> GetAllTrainee()
        {
            return await client.GetFromJsonAsync<TraineeList>(uri + "/api/Insert/traineeSelector");
        }
        public async Task<int> DeleteATrainee(int id)
        {
            return (await client.DeleteAsync(uri + "api/Insert/DeleteTrainee/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertATrainee(Trainee trainee)
        {
            return (await client.PostAsJsonAsync<Trainee>(uri + "api/Insert/InsertTrainee", trainee)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateATrainee(Trainee trainee)
        {
            return (await client.PutAsJsonAsync<Trainee>(uri + "api/Insert/UpdateTrainee", trainee)).IsSuccessStatusCode ? 1 : 0;
        }




        public async Task<Kinds_of_workoutsList> GetAllKinds_of_workouts()
        {
            return await client.GetFromJsonAsync<Kinds_of_workoutsList>(uri + "/api/Insert/kinds_of_workoutsSelector");
        }
        public async Task<int> DeleteAKinds_of_workouts(int id)
        {
            return (await client.DeleteAsync(uri + "api/Insert/DeleteKinds_of_workouts/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertAKinds_of_workouts(Kinds_of_workouts kinds_of_workouts)
        {
            return (await client.PostAsJsonAsync<Kinds_of_workouts>(uri + "api/Insert/InsertKinds_of_workouts", kinds_of_workouts)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateAKinds_of_workouts(Kinds_of_workouts kinds_of_workouts)
        {
            return (await client.PutAsJsonAsync<Kinds_of_workouts>(uri + "api/Insert/UpdateKinds_of_workouts", kinds_of_workouts)).IsSuccessStatusCode ? 1 : 0;
        }



        public async Task<List_of_Exc_workoutsList> GetAllList_of_Exc_workouts()
        {
            return await client.GetFromJsonAsync<List_of_Exc_workoutsList>(uri + "/api/Insert/list_of_Exc_workoutsSelector");
        }
        public async Task<int> DeleteAList_of_Exc_workouts(int id)
        {
            return (await client.DeleteAsync(uri + "api/Insert/DeleteList_of_Exc_workouts/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertAList_of_Exc_workouts(List_of_Exc_workouts list_of_Exc_workouts)
        {
            return (await client.PostAsJsonAsync<List_of_Exc_workouts>(uri + "api/Insert/InsertList_of_Exc_workouts", list_of_Exc_workouts)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateAList_of_Exc_workouts(List_of_Exc_workouts list_of_Exc_workouts)
        {
            return (await client.PutAsJsonAsync<List_of_Exc_workouts>(uri + "api/Insert/UpdateList_of_Exc_workouts", list_of_Exc_workouts)).IsSuccessStatusCode ? 1 : 0;
        }





        public async Task<Training_registrationList> GetAllTraining_registration()
        {
            return await client.GetFromJsonAsync<Training_registrationList>(uri + "/api/Insert/training_registrationSelector");
        }
        public async Task<int> DeleteATraining_registration(int id)
        {
            return (await client.DeleteAsync(uri + "api/Insert/DeleteTraining_registration/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertATraining_registration(Training_registration training_registration)
        {
            return (await client.PostAsJsonAsync<Training_registration>(uri + "api/Insert/InsertTraining_registration", training_registration)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateATraining_registration(Training_registration training_registration)
        {
            return (await client.PutAsJsonAsync<Training_registration>(uri + "api/Insert/UpdateTraining_registration", training_registration)).IsSuccessStatusCode ? 1 : 0;
        }




        public async Task<Workouts_of_trainersList> GetAllWorkouts_of_trainers()
        {
            return await client.GetFromJsonAsync<Workouts_of_trainersList>(uri + "/api/Insert/workouts_of_trainersSelector");
        }
        public async Task<int> DeleteAWorkouts_of_trainers(int id)
        {
            return (await client.DeleteAsync(uri + "api/Insert/DeleteWorkouts_of_trainers/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertAWorkouts_of_trainers(Workouts_of_trainers workouts_of_trainers)
        {
            return (await client.PostAsJsonAsync<Workouts_of_trainers>(uri + "api/Insert/InsertWorkouts_of_trainers", workouts_of_trainers)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateAWorkouts_of_trainers(Workouts_of_trainers workouts_of_trainers)
        {
            return (await client.PutAsJsonAsync<Workouts_of_trainers>(uri + "api/Insert/UpdateWorkouts_of_trainers", workouts_of_trainers)).IsSuccessStatusCode ? 1 : 0;
        }
    }
}
