using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OOPConsoleApp10
{
    public class Student
    {
        //public int Id { get; set; }


        //.............
        //private int id;

        //public int Id
        //{
        //    get { return id; }
        //    set
        //    {
        //        id = value;
        //    }
        //}



        //...............................................
        //// Properties  ... Full Property 
        private string id;

        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value == "hamza" || value == "Hamza")
                {
                    WriteLine("Ap k sath Ziadti kabhi nh howi...Exelent");
                    bool temp = true;
                }
                else
                {
                    value = id;
                }

            }

            //private int id;




            ////....................................................... Getter and Setter Method (Field level validation or Encapsulation) 
            //private int id;
            //public void SetId(int _id)
            //{
            //    if (_id <= 0)
            //    {
            //        //throw new Exception("Id should be > 0");
            //        id = 0;
            //    }
            //    else
            //    {
            //        id = _id;
            //    }
            //}
            //public int GetId()
            //{
            //    return id;
            //}
            // private string name;

            //............

            //private int id;

            //public int Id
            //{
            //    get { return id; }
            //    set { id = value; }
            //}

            //private string name;

            //public string Name
            //{
            //    get { return name; }
            //    set { name = value; }
            //}

            //private string email;

            //public string Email
            //{
            //    get { return email; }
            //    set { email = value; }
            //}

            //public string Address { get; set; }  // Auto Implement Prop.


            //        public string Address { get; } = "Fsd";  // C# 6.0


            //        private string email;

            //        // C# 7.0
            //        public string Email
            //        {
            //            get => email; 
            //            set => email = value; 
            //        }


            //        public void MyFunction() => Console.WriteLine();

            //    }
        }
    }
}

