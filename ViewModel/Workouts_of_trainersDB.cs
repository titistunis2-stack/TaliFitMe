using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;

namespace ViewModel
{
    //public class Workouts_of_trainersDB : BaseDB
    //{
    //    public Workouts_of_trainersList SelectAll()
    //    {
    //        command.CommandText = $"SELECT * FROM Workouts_of_trainersTbl";
    //        Workouts_of_trainersList groupList = new Workouts_of_trainersList(base.Select());
    //        return groupList;
    //    }
    //    protected override BaseEntity CreateModel(BaseEntity entity)
    //    {
    //        Workouts_of_trainers wt = entity as Workouts_of_trainers;
    //        wt.Gender_name = reader["gender_name"].ToString();
    //        base.CreateModel(entity);
    //        return wt;
    //    }
    //    public override BaseEntity NewEntity()
    //    {
    //        return new Workouts_of_trainers();
    //    }
    //}
}
