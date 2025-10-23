using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Kinds_of_workoutsList:List<Kinds_of_workouts>
    {            
            public Kinds_of_workoutsList() { }
            public Kinds_of_workoutsList(IEnumerable<Kinds_of_workouts> list) :base(list) { }
            public Kinds_of_workoutsList(IEnumerable<BaseEntity> list) : base(list.Cast<Kinds_of_workouts>().ToList()) { }
        
    }
}
