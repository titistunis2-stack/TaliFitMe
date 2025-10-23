using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TrainerList : List<Trainer>
    {
        public TrainerList() { }
        public TrainerList(IEnumerable<Trainer> list) : base(list) { }
        public TrainerList(IEnumerable<BaseEntity> list) : base(list.Cast<Trainer>().ToList()) { }

    }
}
