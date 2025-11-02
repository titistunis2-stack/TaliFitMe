using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;

namespace ViewModel
{
    public class Training_registrationDB : BaseDB
    {
        public Training_registrationList SelectAll()
        {
            command.CommandText = $"SELECT  id, id_trainee, id_excWorkouts FROM Training_registration";
            Training_registrationList groupList = new Training_registrationList(base.Select());
            return groupList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Training_registration tr = entity as Training_registration;

            var z = reader[1].ToString();
            tr.Id_trainee = TraineeDB.SelectById(int.Parse(reader[1].ToString()));
            tr.Id_excWorkouts = List_of_Exc_workoutsDB.SelectById(int.Parse(reader[2].ToString()));
            base.CreateModel(entity);
            return tr;
        }
        public override BaseEntity NewEntity()
        {
            return new Training_registration();
        }
        static private Training_registrationList list = new Training_registrationList();

        public static Training_registration SelectById(int id)
        {
            Training_registrationDB db = new Training_registrationDB();
            list = db.SelectAll();

            Training_registration g = list.Find(item => item.Id == id);
            return g;
        }

    }
}

