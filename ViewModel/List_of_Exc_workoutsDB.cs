using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;

namespace ViewModel
{
    public class List_of_Exc_workoutsDB : BaseDB
    {
        public List_of_Exc_workoutsList SelectAll()
        {
            command.CommandText = $"SELECT  id, id_kindOf_workouts, workout_date, " +
                $"workout_time, id_trainer FROM  List_of_Exc_workouts";
            List_of_Exc_workoutsList groupList = new List_of_Exc_workoutsList(base.Select());
            return groupList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            List_of_Exc_workouts lw = entity as List_of_Exc_workouts;
            lw.Workout_date = DateTime.Parse(reader["workout_date"].ToString());
            lw.Workout_time = DateTime.Parse(reader["workout_time"].ToString());
            int x= (int)reader["id_trainer"];
            lw.Id_trainer = TrainerDB.SelectById((int)reader["id_trainer"]);
            lw.Id_kindOf_workouts = Kinds_of_workoutsDB.SelectById((int)reader["id_kindOf_workouts"]);
            base.CreateModel(entity);
            return lw;
        }
        public override BaseEntity NewEntity()
        {
            return new List_of_Exc_workouts();
        }
        static private List_of_Exc_workoutsList list = new List_of_Exc_workoutsList();

        public static List_of_Exc_workouts SelectById(int id)
        {
            List_of_Exc_workoutsDB db = new List_of_Exc_workoutsDB();
            list = db.SelectAll();

            List_of_Exc_workouts g = list.Find(item => item.Id == id);
            return g;
        }
    }
}
