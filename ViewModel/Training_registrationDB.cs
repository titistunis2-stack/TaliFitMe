using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;

namespace ViewModel
{
    //public class Training_registrationDB : BaseDB
    //{
    //    public Training_registrationList SelectAll()
    //    {
    //        command.CommandText = $"SELECT * FROM Training_registrationTbl";
    //        Training_registrationList groupList = new Training_registrationList(base.Select());
    //        return groupList;
    //    }
    //    protected override BaseEntity CreateModel(BaseEntity entity)
    //    {
    //        Training_registration tr = entity as Training_registration;
    //        tr.Gender_name = reader["gender_name"].ToString();
    //        base.CreateModel(entity);
    //        return tr;
    //    }
    //    public override BaseEntity NewEntity()
    //    {
    //        return new Gender();
    //    }
    //}
}
