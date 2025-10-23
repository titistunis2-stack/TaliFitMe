namespace Model
{
    public class List_of_Exc_workouts
    {
        private int id_kindOf_workouts;
        private DateTime workout_date;
        private DateTime workout_time;
        private int id_trainer;

        public int Id_kindOf_workouts { get => id_kindOf_workouts; set => id_kindOf_workouts = value; }
        public DateTime Workout_date { get => workout_date; set => workout_date = value; }
        public DateTime Workout_time { get => workout_time; set => workout_time = value; }
        public int Id_trainer { get => id_trainer; set => id_trainer = value; }
    }
}
