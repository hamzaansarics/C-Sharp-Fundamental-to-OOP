using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_in_encapsulation
{
    class love
    {
        private string name;

       

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                for(int i=0; i<value.Length; i++)
                {
                    if(char.IsLowSurrogate(value[i]))
                    {
                        name = "Invalid Name";
                    }
                    else
                    {
                        name = value;
                    }
                }
            }
        }


    }
}
