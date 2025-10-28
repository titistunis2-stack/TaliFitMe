using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;

//namespace ViewModel
//{
//    public class Training_registrationDB : BaseDB
//    {
//        public Training_registrationList SelectAll()
//        {
//            command.CommandText = $"SELECT * FROM Training_registrationTbl";
//            Training_registrationList groupList = new Training_registrationList(base.Select());
//            return groupList;
//        }
//        protected override BaseEntity CreateModel(BaseEntity entity)
//        {
//            Training_registration tr = entity as Training_registration;
//            tr. = reader["gender_name"].ToString();
//            base.CreateModel(entity);
//            return tr;
//        }
//        public override BaseEntity NewEntity()
//        {
//            return new Gender();
//        }
//        static private Training_registrationList list = new Training_registrationList();

//        public static Training_registration SelectById(int id)
//        {
//            Training_registrationDB db = new Training_registrationDB();
//            list = db.SelectAll();

//            Training_registration g = list.Find(item => item.Id == id);
//            return g;
//        }

//    }
//}

