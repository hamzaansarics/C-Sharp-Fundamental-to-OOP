using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLecture03
{
    public class Student
    {
        #region F + P
        //// Full Propert
        //private int id;
        //public int Id
        //{
        //    get { return id; }
        //    set { id = value; }
        //}

        //.............................................
        // Auto Implement Property
        //public string Address { get; set; }

        //....................................................................
        //public string Email { get; private set; }  // Get or Read Only 

        //public void Data()
        //{
        //    Email = "rizwan@gmail.com";
        //}

        //...............................................
        //public string Email { get; }

        //Error
        //public void Data()
        //{
        //    Email = "rizwan@gmail.com";
        //}
        //....................................

        //public string Email { get; } = "rizwan@gmail.com";   // C# 6.0

        //public string Email { get; }
        //public Student(string email)
        //{
        //    Email = email;
        //}

        //public Student()
        //{
        //    Email = "rizwan@gmail.com";
        //}


        //..................

        //public string Name { private get; set; }

        //public void Data()
        //{
        //    Console.WriteLine($"Your Name : {Name}");
        //}

        //....

        //// C# 7.0

        //private int id;

        //public int Id
        //{
        //    get => id;
        //    set => id = value;
        //}

        //public string Email => "rizwan@gmail.com";   // C# 7.0

        //............................................................
        #endregion

        //public int Id { get; set; }
        //public string Name { get; set; }
        //public string Email { get; set; }

        #region Constructors
        //public Student()
        //{
        //    Console.WriteLine("Default Constructor");
        //}
        //public Student(int Id) : this()
        //{
        //    this.Id = Id;
        //    Console.WriteLine("1 Parametrized Constructor : " + Id);
        //}

        //public Student(int Id, string name) : this(Id)
        //{
        //    this.Id = Id;
        //    Name = name;
        //    Console.WriteLine("2 Parametrized Constructor : " + Id + " , "+ Name);
        //}
        #endregion


        //public int Id { private get; set; }
        //public string Name { private get; set; }
        //public string Email { private get; set; }

        //// No Input , No Output
        //public void Method1()
        //{
        //    Console.WriteLine($"Data : {Id} , {Name} , {Email}");
        //}


        //public int Id { get; private set; }
        //public string Name { get; private set; }
        //public string Email { get; private set; }
        //// Input , but No Output
        //public void Method1(int id, string _name, string _email)
        //{
        //    Id = id;
        //    Name = _name;
        //    Email = _email;
        //    Console.WriteLine($"Data : {Id} , {Name} , {Email}");
        //}
        //// Input , but Output
        //public string Method1(string _name, int id,  string _email)
        //{
        //    Id = id;
        //    Name = _name;
        //    Email = _email;
        //    return $"Data : {Id} , {Name} , {Email}";
        //}



        public int Id {  get; set; }
        public string Name {  get; set; }
        public string Email {  get; set; }
        // No Input , but Output
        public string Method()
        {
            return $" {Id} , {Name} , {Email}";
        }
        


    }
}
