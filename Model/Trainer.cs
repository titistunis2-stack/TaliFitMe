using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Trainer: Person
    {
        private double payment_per_hour;
        private string certificate;
        private bool expeience;
        private string description;

        public double Payment_per_hour { get => payment_per_hour; set => payment_per_hour = value; }
        public string Certificate { get => certificate; set => certificate = value; }
        public bool Expeience { get => expeience; set => expeience = value; }
        public string Description { get => description; set => description = value; }
    }
}
