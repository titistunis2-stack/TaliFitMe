using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;

namespace ViewModel
{
    //public class SubscriptionDB : BaseDB
    //{
    //    public SubscriptionList SelectAll()
    //    {
    //        command.CommandText = $"SELECT * FROM SubscriptionTbl";
    //        SubscriptionList groupList = new SubscriptionList(base.Select());
    //        return groupList;
    //    }
    //    protected override BaseEntity CreateModel(BaseEntity entity)
    //    {
    //        Subscription sb = entity as Subscription;
    //        sb.Subscription_name = reader["Subscription_name"].ToString();
    //        base.CreateModel(entity);
    //        return sb;
    //    }
    //    public override BaseEntity NewEntity()
    //    {
    //        return new Subscription();
    //    }
    //}
}
