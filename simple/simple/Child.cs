using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple
{
    class Child 
    {
        public string email { get; set; }
        private Person safe;

        public Person Safe
        {
            get { return safe; }
            set { safe = value; }
        }

    }
}
