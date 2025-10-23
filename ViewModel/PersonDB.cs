using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;

namespace ViewModel
{
    //public class PersonDB : BaseDB
    //{
    //    public PersonList SelectAll()
    //    {
    //        command.CommandText = $"SELECT * FROM PersonTbl";
    //        PersonList groupList = new PersonList(base.Select());
    //        return groupList;
    //    }
    //    protected override BaseEntity CreateModel(BaseEntity entity)
    //    {
    //        Person p = entity as Person;
    //        p.First_name = reader["first_name"].ToString();
    //        p.First_name = reader["first_name"].ToString();
    //        p.First_name = reader["first_name"].ToString();
    //        p.First_name = reader["first_name"].ToString();
    //        p.First_name = reader["first_name"].ToString();
    //        p.First_name = reader["first_name"].ToString();
    //        p.First_name = reader["first_name"].ToString();
    //        p.First_name = reader["first_name"].ToString();
    //        base.CreateModel(entity);
    //        return p;
    //    }
    //    public override BaseEntity NewEntity()
    //    {
    //        return new Person();
    //    }
    }
}
