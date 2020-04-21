using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence_searching_
{
   public class Batch
    {
        public int bathid { get; set; }

        public int bathcyear { get; set; }

        private Teacher teachers;

        public Teacher Teachers
        {
            get { return teachers; }
            set { teachers = value; }
        }

        private Student students;

        public Student Students
        {
            get { return students; }
            set { students = value; }
        }

        private Address fulladdress;

        public Address Fulladdress
        {
            get { return fulladdress; }
            set { fulladdress = value; }
        }




    }
}
