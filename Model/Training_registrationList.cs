using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Training_registrationList : List<Training_registration>
    {
        public Training_registrationList() { }
        public Training_registrationList(IEnumerable<Training_registration> list) : base(list) { }
        public Training_registrationList(IEnumerable<BaseEntity> list) : base(list.Cast<Training_registration>().ToList()) { }

    }
}
