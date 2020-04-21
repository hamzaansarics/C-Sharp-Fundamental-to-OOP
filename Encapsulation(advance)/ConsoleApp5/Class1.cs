using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class song
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
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsDigit(value[i]))
                    {
                       
                            name = "Valid";
                       
                    }
                    
                    else  
                    {
                        name = "Not Valid";
                    }
                }
                 

                }
               
            }
        }

    }

   

