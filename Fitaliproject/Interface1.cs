using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal interface Interface1
    {
        public Task<PersonList> GetAllPersons();

    }
}
