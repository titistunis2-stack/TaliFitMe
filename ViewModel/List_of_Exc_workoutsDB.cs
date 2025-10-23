using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;

namespace ViewModel
{
    //public class List_of_Exc_workoutsDB : BaseDB
    //{
    //    public List_of_Exc_workoutsList SelectAll()
    //    {
    //        command.CommandText = $"SELECT * FROM List_of_Exc_workoutsTbl";
    //        List_of_Exc_workoutsList groupList = new List_of_Exc_workoutsList(base.Select());
    //        return groupList;
    //    }
    //    protected override BaseEntity CreateModel(BaseEntity entity)
    //    {
    //        List_of_Exc_workouts lw = entity as List_of_Exc_workouts;
    //        lw.List_of_Exc_workouts_name = reader["List_of_Exc_workouts_name"].ToString();
    //        base.CreateModel(entity);
    //        return lw;
    //    }
    //    public override BaseEntity NewEntity()
    //    {
    //        return new List_of_Exc_workouts();
    //    }
    //}
}
