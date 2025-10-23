using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TraineeList : List<Trainee>
    {
        public TraineeList() { }
        public TraineeList(IEnumerable<Trainee> list) : base(list) { }
        public TraineeList(IEnumerable<BaseEntity> list) : base(list.Cast<Trainee>().ToList()) { }

    }
}
