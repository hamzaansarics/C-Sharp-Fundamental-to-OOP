using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Class1
    {
        
        

        public void data()
        {
            
while(true)
            {

                Console.WriteLine("1-Instruction\n2-Login\n3-Sign Up");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    Console.WriteLine("\t\nYou Can Sign Up Using Different Password which should be contain chrarcte / digit");




                }
                if (a == 2)
                {
                    Console.WriteLine("Enter password");
                    string psw = Console.ReadLine();
                    if (psw == "hamza12")
                    {
                        Console.WriteLine("Enter UserName");
                        string name = Console.ReadLine();
                        if (name == "Ansari")
                        {
                            Console.WriteLine("Welcome to C#");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Name");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid Password ");
                    }

                }

                if (a == 3)
                {
                    Console.WriteLine("Enter Password");
                    string psw = Console.ReadLine();
                    for (int i = 0; i < psw.Length; i++)
                    {
                        if (char.IsDigit(psw[i]))
                        {
                            Console.WriteLine("You Account is successfuly Registerd!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Error!!" +
                                "    Please Click 1-&see the instruction and then try to sign up");
                            break;
                        }

                    }


                }
            }

        }


    }
}
