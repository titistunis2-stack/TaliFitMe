using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;

namespace ViewModel
{
    public class ManagerDB : PersonDB
    {
        public ManagerList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Manager";
            ManagerList groupList = new ManagerList(base.Select());
            return groupList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Manager mg = entity as Manager;
            base.CreateModel(entity);
            return mg;
        }
        public override BaseEntity NewEntity()
        {
            return new Manager();
        }
    }
}
