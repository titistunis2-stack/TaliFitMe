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
            command.CommandText = $"SELECT Gender.* FROM Gender";
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
        static private GenderList list = new GenderList();

        public static Gender SelectById(int id)
        {
            GenderDB db = new GenderDB();
            list = db.SelectAll();

            Gender g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Gender p = entity as Gender;
            if (p != null)
            {
                string sqlStr = $"UPDATE Gender SET Gender_name=@gender_name WHERE ID=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@gender_name", p.Gender_name));
                command.Parameters.Add(new OleDbParameter("@id", p.Id));
            }
        }
    }
}
