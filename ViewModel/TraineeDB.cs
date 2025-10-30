using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;

namespace ViewModel
{
    public class TraineeDB : PersonDB
    {
        public TraineeList SelectAll()
        {
            command.CommandText = $"SELECT Person.id, Person.first_name, Person.last_name, Person.telephone, Person.num_id, Person.email, Person.born_date, Person.photo, Person.user_name, Person.pass, Person.id_gender, Trainee.health_Declaration, Trainee.joining_date, Trainee.id_Sub " +
                $"FROM (Trainee INNER JOIN Person ON Trainee.id = Person.id)";
            TraineeList groupList = new TraineeList(base.Select());
            return groupList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Trainee te = entity as Trainee;
            te.Health_Declaration = bool.Parse(reader["health_Declaration"].ToString());
            te.Joining_date = DateTime.Parse(reader["joining_date"].ToString());
            te.Id_Sub = SubscriptionDB.SelectById((int)reader["id_Sub"]);
            base.CreateModel(entity);
            return te;
        }
        public override BaseEntity NewEntity()
        {
            return new Trainee();
        }
        static private TraineeList list = new TraineeList();

        public static Trainee SelectById(int id)
        {
            TraineeDB db = new TraineeDB();
            list = db.SelectAll();

            Trainee te = list.Find(item => item.Id == id);
            return te;
        }


    }
}
