using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;

namespace ViewModel
{
    public class TrainerDB : PersonDB
    {
        public TrainerList SelectAll()
        {
            command.CommandText = $"SELECT Person.*, Trainer.paymet_per_hour, Trainer.certificate, Trainer.experience, Trainer.description FROM  (Person INNER JOIN  Trainer ON Person.id = Trainer.id)";
            TrainerList groupList = new TrainerList(base.Select());
            return groupList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Trainer t = entity as Trainer;
            t.Paymet_per_hour= double.Parse(reader["paymet_per_hour"].ToString());
            t.Certificate = reader["certificate"].ToString();
            t.Experience = true;// bool.Parse(reader["experience"].ToString());
            t.Description = reader["description"].ToString();
            base.CreateModel(entity);
            return t;
        }
        public override BaseEntity NewEntity()
        {
            return new Trainer();
        }
        static private TrainerList list = new TrainerList();
        public static Trainer SelectById(int id)
        {
            TrainerDB db = new TrainerDB();
            list = db.SelectAll();

            Trainer g = list.Find(item => item.Id == id);
            return g;
        }

    }
}

