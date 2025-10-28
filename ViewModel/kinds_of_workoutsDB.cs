using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace ViewModel
{
    public class Kinds_of_workoutsDB : BaseDB
    {
        public Kinds_of_workoutsList SelectAll()
        {
            command.CommandText = $"SELECT * FROM kinds_of_workoutsTbl";
            Kinds_of_workoutsList groupList = new Kinds_of_workoutsList(base.Select());
            return groupList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Kinds_of_workouts kw = entity as Kinds_of_workouts;
            kw.Name_of_workout = reader["name_of_workouts"].ToString();
            kw.Max_amount_of_people = int.Parse(reader["max_amount_of_people"].ToString());
            base.CreateModel(entity);
            return kw;
        }
        public override BaseEntity NewEntity()
        {
            return new Kinds_of_workouts();
        }
    }
}
