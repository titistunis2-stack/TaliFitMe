using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Subscription : BaseEntity
    {
        private string name_of_subscription;
        private double price;

        public string Name_of_subscription { get => name_of_subscription; set => name_of_subscription = value; }
        public double Price { get => price; set => price = value; }
    }
}
