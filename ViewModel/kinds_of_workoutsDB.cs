using Model;
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
            command.CommandText = $"SELECT Kinds_of_workouts.* FROM Kinds_of_workouts";
            Kinds_of_workoutsList pList = new Kinds_of_workoutsList(base.Select());
            return pList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Kinds_of_workouts kw = entity as Kinds_of_workouts;
            kw.Name_of_workout = reader["name_of_workout"].ToString();
            kw.Max_amount_of_people = int.Parse(reader["max_amount_of_people"].ToString());
           
            base.CreateModel(entity);
            return kw;
        }
        public override BaseEntity NewEntity()
        {
            return new Kinds_of_workouts();
        }
        static private Kinds_of_workoutsList list = new Kinds_of_workoutsList();
        public static Kinds_of_workouts SelectById(int id)
        {
            Kinds_of_workoutsDB db = new Kinds_of_workoutsDB();
            list = db.SelectAll();

            Kinds_of_workouts g = list.Find(item => item.Id == id);
            return g;
        }

        //שלב ב
        //protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        //{
        //    Person c = entity as Person;
        //    if (c != null)
        //    {
        //        string sqlStr = $"DELETE FROM PersonTbl where id=@pid";

        //        command.CommandText = sqlStr;
        //        command.Parameters.Add(new OleDbParameter("@pid", c.Id));
        //    }
        //}
        //protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        //{
        //    Person c = entity as Person;
        //    if (c != null)
        //    {
        //        string sqlStr = $"Insert INTO  PersonTbl (PersonName) VALUES (@cName)";

        //        command.CommandText = sqlStr;
        //        command.Parameters.Add(new OleDbParameter("@cName", c.PersonName));
        //    }
        //}

        //protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        //{
        //    Person c = entity as Person;
        //    if (c != null)
        //    {
        //        string sqlStr = $"UPDATE PersonTbl  SET PersonName=@cName WHERE ID=@id";

        //        command.CommandText = sqlStr;
        //        command.Parameters.Add(new OleDbParameter("@cName", c.PersonName));
        //        command.Parameters.Add(new OleDbParameter("@id", c.Id));
        //    }
        //}
    }
}