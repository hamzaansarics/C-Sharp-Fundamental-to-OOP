using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Student
    {
        public int Id => 5;
        public string Name => "Bilal";
        public double CGPA => 4.0;

        public (int, string, double) Data()
        {
            return (Id, Name, CGPA);
        }
    }
}
