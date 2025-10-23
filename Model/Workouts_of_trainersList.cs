using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Workouts_of_trainersList : List<Workouts_of_trainers>
    {
        public Workouts_of_trainersList() { }
        public Workouts_of_trainersList(IEnumerable<Workouts_of_trainers> list) : base(list) { }
        public Workouts_of_trainersList(IEnumerable<BaseEntity> list) : base(list.Cast<Workouts_of_trainers>().ToList()) { }

    }
}
