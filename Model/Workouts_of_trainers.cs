using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Workouts_of_trainers : BaseEntity
    {
        private Trainer id_trainer;
        private Kinds_of_workouts id_kindsOfWorkouts;
        public Trainer Id_trainer { get => id_trainer; set => id_trainer = value; }
        public Kinds_of_workouts Id_kindsOfWorkouts { get => id_kindsOfWorkouts; set => id_kindsOfWorkouts = value; }
    }
}
