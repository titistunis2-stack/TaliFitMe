using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SubscriptionList : List<Subscription>
    {
        public SubscriptionList() { }
        public SubscriptionList(IEnumerable<Subscription> list) : base(list) { }
        public SubscriptionList(IEnumerable<BaseEntity> list) : base(list.Cast<Subscription>().ToList()) { }

    }
}
