using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Trainee: Person
    {
        private int health_Dedaration;
        private DateTime joining_date;
        private Subscription id_Sub;

        public int Health_Dedaration { get => health_Dedaration; set => health_Dedaration = value; }
        public DateTime Joining_date { get => joining_date; set => joining_date = value; }
        public Subscription Id_Sub { get => id_Sub; set => id_Sub = value; }
    }
}
