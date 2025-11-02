using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;

namespace ViewModel
{
    public class Workouts_of_trainersDB : BaseDB
    {
        public Workouts_of_trainersList SelectAll()
        {
            command.CommandText = $"SELECT  id, id_trainer, id_kind_of_workouts FROM  Workouts_of_trainers";
           Workouts_of_trainersList groupList = new Workouts_of_trainersList(base.Select());
            return groupList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
           Workouts_of_trainers w = entity as Workouts_of_trainers;
           w.Id_trainer = TrainerDB.SelectById((int)reader["id_trainer"]);
           w.Id_kindsOfWorkouts= Kinds_of_workoutsDB.SelectById((int)reader["id_kind_of_workouts"]);
            base.CreateModel(entity);
            return w;
        }
        public override BaseEntity NewEntity()
        {
            return new Workouts_of_trainers();
        }
        static private Workouts_of_trainersList list = new Workouts_of_trainersList();
        public static Workouts_of_trainers SelectById(int id)
        {
           Workouts_of_trainersDB db = new Workouts_of_trainersDB();
            list = db.SelectAll();

           Workouts_of_trainers g = list.Find(item => item.Id == id);
            return g;
        }

    }
}
