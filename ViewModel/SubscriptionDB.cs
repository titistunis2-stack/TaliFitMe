using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;

namespace ViewModel
{
    public class SubscriptionDB : BaseDB
    {
        public SubscriptionList SelectAll()
        {
            command.CommandText = $"SELECT  Subscription.*FROM Subscription";
            SubscriptionList groupList = new SubscriptionList(base.Select());
            return groupList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Subscription sb = entity as Subscription;
            sb.Name_of_sub = reader["name_of_sub"].ToString();
            sb.Price = double.Parse(reader["price"].ToString());
            base.CreateModel(entity);
            return sb;
        }
        public override BaseEntity NewEntity()
        {
            return new Subscription();
        }
        static private SubscriptionList list = new SubscriptionList();

        public static Subscription SelectById(int id)
        {
            SubscriptionDB db = new SubscriptionDB();
            list = db.SelectAll();

            Subscription g = list.Find(item => item.Id == id);
            return g;
        }
    }
}
