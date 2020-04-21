using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLecture09
{
    public interface IF2
    {
        int Id { get; set; }
        string Name { get; set; }
        string Data(int _id, string _name);
        string Data1(int _id, string _name);

    }
}
