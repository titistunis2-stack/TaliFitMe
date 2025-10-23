using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;

namespace ViewModel
{
    public class GenderDB : BaseDB
    {
        public GenderList SelectAll()
        {
            command.CommandText = $"SELECT * FROM GenderTbl";
            GenderList groupList = new GenderList(base.Select());
            return groupList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Gender gn = entity as Gender;
            gn.Gender_name = reader["gender_name"].ToString();
            base.CreateModel(entity);
            return gn;
        }
        public override BaseEntity NewEntity()
        {
            return new Gender();
        }
    }
}
