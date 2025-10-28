using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;

namespace ViewModel
{
    public class PersonDB : BaseDB
    {
        public PersonList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Person";
            PersonList groupList = new PersonList(base.Select());
            return groupList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Person p = entity as Person;
            p.First_name = reader["first_name"].ToString();
            p.Last_name = reader["last_name"].ToString();
            p.Telephone = reader["telephone"].ToString();
            p.Num_id = reader["num_id"].ToString();
            p.Email = reader["email"].ToString();
            p.Born_date = DateTime.Parse(reader["born_date"].ToString());
            p.Photo = reader["photo"].ToString();
            p.User_name = reader["user_name"].ToString();
            p.Pass = reader["pass"].ToString();
            p.Id_gender = GenderDB.SelectById((int)reader["id_gender"]);
            base.CreateModel(entity);
            return p;
        }
        public override BaseEntity NewEntity()
        {
            return new Person();
        }
        static private PersonList list = new PersonList();
        public static Person SelectById(int id)
        {
            PersonDB db = new PersonDB();
            list = db.SelectAll();

            Person g = list.Find(item => item.Id == id);
            return g;
        }

    }
}
