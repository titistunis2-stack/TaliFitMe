using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class List_of_Exc_workoutsList : List<List_of_Exc_workouts>
    {
        public List_of_Exc_workoutsList() { }
        public List_of_Exc_workoutsList(IEnumerable<List_of_Exc_workouts> list) : base(list) { }
        public List_of_Exc_workoutsList(IEnumerable<BaseEntity> list) : base(list.Cast<List_of_Exc_workouts>().ToList()) { }

    }
}