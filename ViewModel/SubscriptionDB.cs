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

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Subscription s = entity as Subscription;
            if (s != null)
            {
                string sqlStr = $"INSERT INTO Subscription( Name_of_sub , Price) VALUES (@name_of_sub , @price)";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@name_of_sub", s.Name_of_sub));
                command.Parameters.Add(new OleDbParameter("@price", s.Price));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Subscription p = entity as Subscription;
            if (p != null)
            {
                string sqlStr = $"UPDATE Subscription SET Name_of_sub=@Name_of_sub" +
                    $",Price=@price" +
                    $" WHERE ID=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@name_of_sub", p.Name_of_sub));
                command.Parameters.Add(new OleDbParameter("@price", p.Price));
                command.Parameters.Add(new OleDbParameter("@id", p.Id));
            }
        }
    }
}
