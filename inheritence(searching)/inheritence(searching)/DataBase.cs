using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence_searching_
{
   public class DataBase
    {
        Batch[] geo = new Batch[2];


        public void khan()
        {


            //batch information

            geo[0] = new Batch()
            {

                bathcyear = 2016,
                bathid = 1891,

                Students = new Student()
                {
                    rno = 47,
                    sname = "Ansari",
                    save = 23,
                    IDs=55
                    
                      
                    
                },
                Teachers = new Teacher()
                {
                    grade = 17,
                    salary = 17000,
                    id=10,
                    name="Khan"
                    
                    
                },
                Fulladdress=new Address()
                {
                    city="Faislabad",
                    zipcode=3600
                    
                },

                
            };
            //geo[0].bathcyear = 2016;
            //geo[0].bathid = 1891;

            //geo[0].Students = new Student();
            //geo[0].Students.rno = 47;
            //geo[0].Students.sname = "Ansari";


            //geo[0].Teachers = new Teacher();
            //geo[0].Teachers.grade = 17;
            //geo[0].Teachers.salary = 17000;
            //geo[0].Teachers.id = 12;
            //geo[0].Teachers.name = "Hamza";


            //geo[0].Fulladdress = new Address();
            //geo[0].Fulladdress.city = "Faislabad";
            //geo[0].Fulladdress.zipcode = 3600;5tyu45

            
        }
       
        public void DaTa(string name)
        {
            Console.WriteLine("1-for FUll SHOW DATA  2-SEARCH BY NAME ONly for students");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {

                for (int i = 0; i < geo.Length; i++)
                {
                    if (geo[i] != null)
                    {
                        Console.WriteLine($"{geo[i].bathcyear} {geo[i].bathid} {geo[i].Fulladdress.city} {geo[i].Fulladdress.zipcode} {geo[i].Students.rno} {geo[i].Students.sname} {geo[0].Teachers.salary} {geo[0].Teachers.grade} {geo[0].Teachers.id} {geo[0].Teachers.name}");
                    }


                }
            }
            if(a==2)
            {
                Console.WriteLine("Enter Name: ");
               // string name = Console.ReadLine();
                for (int i = 0; i < geo.Length; i++)
                {
                    if (geo[i] != null)
                    {
                        if (name == geo[i].Students.sname)
                        {
                            Console.WriteLine($" {geo[i].Students.rno} {geo[i].Students.sname} {geo[i].Students.IDs} {geo[i].Students.save} ");
                            break;
                        }


                    }
                    

                }


            }


        }




    }
}
