using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_implement_practise
{
    class khan
    {
        private int id;
        private string name;
        public khan()
        {
            Console.WriteLine("This is default constructor");
        }
        public khan(int _id) :this()
        {
            this.id = _id;
            Console.WriteLine(id);
        }
        public khan(int _id,string Name) :this(_id)
        {
            this.id = _id;
            name = Name;
            Console.WriteLine("Id: " + id + " Name: " + name);
        }
    }
}
