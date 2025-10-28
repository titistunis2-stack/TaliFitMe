﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Trainee: Person
    {
        private bool health_Declaration;
        private DateTime joining_date;
        private Subscription id_Sub;

        
        public DateTime Joining_date { get => joining_date; set => joining_date = value; }
        public Subscription Id_Sub { get => id_Sub; set => id_Sub = value; }
        public bool Health_Declaration { get => health_Declaration; set => health_Declaration = value; }
    }
}
