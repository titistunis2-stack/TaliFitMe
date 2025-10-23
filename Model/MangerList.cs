using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ManagerList : List<Manger>
    {
        public ManagerList() { }
        public ManagerList(IEnumerable<Manger> list) : base(list) { }
        public ManagerList(IEnumerable<BaseEntity> list) : base(list.Cast<Manger>().ToList()) { }

    }
}
