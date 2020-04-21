using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLecture09
{
    public class C1 : IF1, IF2
    {
        private int id;

        public int Id  // Imp.
        {
            get { return id; }
            set { id = value; }
        }
        private string name;

        public string Name  // Imp.
        {
            get { return name; }
            set { name = value; }
        }

        string IF1.Data(int _id, string _name)  // Exp.
        {
            Id = _id;
            Name = _name;
            return $"Id : {Id} , Name : {Name}";
        }

        string IF2.Data(int _id, string _name) // Exp.
        {
            Id = _id;
            Name = _name;
            return $"Id : {Id} .... Name : {Name}";
        }

        public string Data1(int _id, string _name)  // Impl.
        {

            return "";
        }
    }
}
