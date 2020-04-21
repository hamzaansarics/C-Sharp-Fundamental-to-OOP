using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Project
{
    class khan
    {
        private string name;
        private string email;
        private int rno;
        private long pn;
        private float cgpa;

        

        public string Name
        {
            get
            {
                return "COOOOOL";
            }
            set
            {
                if (value == "Hamza" || value =="hamza")
                {
                    name = value;
                }
               else
                {
                    name = "Invalid Name";
                    
                }
            }
        }


        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (value == "bloggersforever250@gmail.com")
                {
                    email = value;
                }
                else
                {
                    email = "Invalid Email";
                }
            }
        }
       

        public int Rno
        {
            get
            {
                return rno;
            }
            set
            {
                if (value == 1891)
                {
                    rno = value;
                }
                else
                {
                    throw new Exception("Invalid");
                }
            }
        }

        public long Pn
        {
            get
            {
                return pn;
            }
            set
            {
                if (value == 03427659916)
                {
                    pn = value;
                }
                else
                {
                    pn = 0;
                }
            }
        }

        public float CGPA
        {
            get
            {
                return cgpa;
            }
            set
            {
                if (value == 3.81f)
                {
                    cgpa = value;
                }
                else
                {
                    cgpa = 0.0f;
                }
            }
        }
    }
}
