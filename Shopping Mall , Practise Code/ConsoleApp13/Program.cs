using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                WriteLine("\t\t\t/////////Create by Muhammad Farhan///////// \n\n\n\n");






                WriteLine("***Well Come***");
                WriteLine("            To..");
                WriteLine("                Chase Up..");
                WriteLine("                       online shopping Website..");
                WriteLine("............................");
                WriteLine("****************************");
                WriteLine(" press y if you want to log in..");
                WriteLine("     press n for visit our web site..");
                WriteLine("       press w if you want job on chase Up..");
                char cr = Convert.ToChar(ReadLine());
                if (cr == 'y'||cr =='Y')
                {
                    Clear();
                    WriteLine("Type Name:");
                    string name = (ReadLine());
                    if (name == "farhan"||name =="Farhan"||name =="SALMAN")
                    {
                        WriteLine("Type Pin Code:");
                        string pin = (ReadLine());
                        if (pin == "1234")
                        {
                            Clear();
                            WriteLine("This is a huge Markete in the Fiaslabad..");
                            WriteLine("In our markete..");
                            WriteLine("                     Laptop, Mobiles,Sports,etc...");
                            WriteLine("                                                       are avilable");
                            WriteLine("Type  your catogry name:");
                            string cat = ReadLine();
                            if (cat == "laptop"||cat =="Laptop"||cat =="LAPTOP")
                            {
                                Clear();
                                WriteLine("Well Come TO Laptop shop:");
                                WriteLine(".................................");
                                WriteLine("*********************************");
                                WriteLine("Follwing compnies brands are avilable,,");
                                WriteLine(" Dell,");
                                WriteLine("     hp,");
                                WriteLine("       samsung,");
                                WriteLine("               Lenovo,");
                                WriteLine("                     Apple,");
                                WriteLine(" Type your compnay choice..");
                                string bf = ReadLine();
                                if (bf == "dell"||bf =="Dell"||bf =="DELL")
                                {
                                    Clear();
                                    WriteLine("IN Dell Company follwing are avilabe in our markete");
                                    WriteLine("Product.Code::Device name::  Modle :: Genration    ::Colour:: Price ");
                                    WriteLine("  dl.001    ::   Dell    :: Core i3:: 2nd genration::Black ::Rs.12000-/");
                                    WriteLine("  dl.002    ::   Dell    :: Core i3:: 4th genration::White ::Rs.15000-/");
                                    WriteLine("  dl.003    ::   Dell    :: Core i5:: 2nd genration::Silver::Rs.16000-/");
                                    WriteLine("  dl.004    ::   Dell    :: Core i5:: 4th genration::Black ::Rs.20000-/");
                                    WriteLine("  dl.005    ::   Dell    :: Core i5:: 7th genration::Black ::Rs.34000-/");
                                    WriteLine("  dl.006    ::   Dell    :: Core i7:: 3rd genration::Grey  ::Rs.24500-/");
                                    WriteLine("  dl.007    ::   Dell    :: Core i7:: 4th genration::White ::Rs.29000-/");
                                    WriteLine("  dl.008    ::   Dell    :: Core i7:: 5th genration::Black ::Rs.36700-/");
                                    WriteLine("  dl.009    ::   Dell    :: Core i7:: 6th genration::Grey  ::Rs.42000-/");
                                    WriteLine("  dl.010    ::   Dell    :: Core i7:: 7th genration::White ::Rs.66000-/");
                                    WriteLine("Type the product no for purchase");
                                    string gf = ReadLine();
                                    if (gf == "dl.001")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i3::dl.001::Black ::2nd      ::12000");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (gf == "dl.002")
                                    {
                                        Clear();
                                        WriteLine("your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i3::dl.002::White ::4th      ::15000");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (gf == "dl.003")
                                    {
                                        Clear();
                                        WriteLine("your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i5::dl.003::silver::2nd      ::16000");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (gf == "dl.004")
                                    {
                                        Clear();
                                        WriteLine("your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i5::dl.004::Black ::4th      ::20000");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (gf == "dl.005")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i5::dl.005::Black ::7th      ::34000");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (gf == "dl.006")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i7::dl.006::Grey  ::3rd      ::24500");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      :          ::     ");
                                        WriteLine("       ::      ::     :           ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (gf == "dl.007")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i7::dl.007::White ::4th      ::29000");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (gf == "dl.008")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i7::dl.008::Black ::5th      ::36700");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (gf == "dl.009")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i7::dl.009::Grey ::6th       ::42000");
                                        WriteLine("       ::      ::     ::          ::     ");
                                        WriteLine("       ::      ::     ::          ::     ");
                                        WriteLine("       ::      ::     ::          ::     ");
                                        WriteLine("       ::      ::     ::          ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (gf == "dl.010")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i7::dl.010::White ::7th      ::66000");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else
                                    {
                                        Clear();
                                        WriteLine("Wrong Product Code");
                                        WriteLine("******************");
                                    }
                                }
                                else if (bf == "hp"||bf =="HP"||bf =="Hp")
                                {
                                    Clear();
                                    WriteLine("IN hp company follwing are avilabe in our markete");
                                    WriteLine("Product.Code::Device name::Modle   :: Genration    ::Colour::Price ");
                                    WriteLine("  hp.001    ::    hp     :: Core i3:: 2nd genration::Black ::Rs.12700-/");
                                    WriteLine("  hp.002    ::    hp     :: Core i3:: 4th genration::Silver::Rs.15800-/");
                                    WriteLine("  hp.003    ::    hp     :: Core i5:: 2nd genration::White ::Rs.16400-/");
                                    WriteLine("  hp.004    ::    hp     :: Core i5:: 4th genration::Grey  ::Rs.20300-/");
                                    WriteLine("  hp.005    ::    hp     :: Core i5:: 7th genration::Black ::Rs.34200-/");
                                    WriteLine("  hp.006    ::    hp     :: Core i7:: 3rd genration::White ::Rs.24600-/");
                                    WriteLine("  hp.007    ::    hp     :: Core i7:: 4th genration::Grey  ::Rs.29900-/");
                                    WriteLine("  hp.008    ::    hp     :: Core i7:: 5th genration::Siler ::Rs.36799-/");
                                    WriteLine("  hp.009    ::    hp     :: Core i7:: 6th genration::Black ::Rs.42100-/");
                                    WriteLine("  hp.010    ::    hp     :: Core i7:: 7th genration::White ::Rs.66130-/");
                                    WriteLine("Type the product no for purchase");
                                    string yr = ReadLine();
                                    if (yr == "hp.001")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i3::hp.001::Black ::2nd      ::12700");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (yr == "hp.002")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i3::hp.002::Silver::4th      ::15800");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (yr == "hp.003")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i5::hp.003::White ::2nd      ::16400");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");

                                    }
                                    else if (yr == "hp.004")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i5::hp.004::Grey  ::4th      ::20300");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (yr == "hp.005")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i5::hp.005::Black ::7th      ::34200");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (yr == "hp.006")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i7::hp.006::White ::3rd      ::24600");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (yr == "hp.007")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i7::hp.007::Grey  ::4th      ::29900");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (yr == "hp.008")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i7::hp.008::Silver::5th      ::36799");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (yr == "hp.009")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i7::hp.009::Black ::6th      ::42100");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (yr == "hp.010")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i7::hp.010::White ::7th      ::66130");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else
                                    {
                                        Clear();
                                        WriteLine("Wrong Product Code");
                                        WriteLine("******************");
                                    }
                                }
                                else if (bf == "samsung"||bf =="Samsung"||bf =="SAMSUNG")
                                {
                                    Clear();
                                    WriteLine("IN Samsung compay follwing are avilabe in our markete");
                                    WriteLine("Product.No::device name::  Modle :: Genration    ::Colour:: Price ");
                                    WriteLine("sm.001    ::  samsung  :: Core i3:: 2nd genration::Black :: Rs.12100-/");
                                    WriteLine("sm.002    ::  samsung  :: Core i3:: 4th genration::Silver:: Rs.15500-/");
                                    WriteLine("sm.003    ::  samsung  :: Core i5:: 2nd genration::White :: Rs.16000-/");
                                    WriteLine("sm.004    ::  samsung  :: Core i5:: 4th genration::Grey  :: Rs.20100-/");
                                    WriteLine("sm.005    ::  samsung  :: Core i5:: 7th genration::Black :: Rs.34000-/");
                                    WriteLine("sm.006    ::  samsung  :: Core i7:: 3rd genration::White :: Rs.24200-/");
                                    WriteLine("sm.007    ::  samsung  :: Core i7:: 4th genration::Grey  :: Rs.28900-/");
                                    WriteLine("sm.008    ::  samsung  :: Core i7:: 5th genration::Silver:: Rs.36199-/");
                                    WriteLine("sm.009    ::  samsung  :: Core i7:: 6th genration::Silver:: Rs.42000-/");
                                    WriteLine("sm.010    ::  samsung  :: Core i7:: 7th genration::White :: Rs.66500-/");
                                    WriteLine("Type the Product Code for purchase");
                                    string rt = ReadLine();
                                    if (rt == "sm.001")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i3::sm.001::Black ::2nd      ::12100");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (rt == "sm.002")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i3::sm.002::Silver::4th      ::15500");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (rt == "sm.003")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i5::sm.003::White::2nd       ::16000");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (rt == "sm.004")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i5::sm.004::Grey  ::4th      ::20100");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                        WriteLine("You buy this Device");
                                        WriteLine("Modle--Core i5");
                                        WriteLine("Product.Code--sm.004");
                                        WriteLine("colour--Grey");
                                        WriteLine("Genration--4th");
                                        WriteLine("Price is.20100");
                                    }
                                    else if (rt == "sm.005")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i5::sm.005::Black ::7th      ::34000");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (rt == "sm.006")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i7::sm.006::White ::3rd      ::24200");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (rt == "sm.007")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i7::sm.007::Grey  ::4th      ::28900");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (rt == "sm.008")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i7::sm.008::Silver::5th      ::36199");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (rt == "sm.009")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i7::sm.009::Silver::6th      ::42000");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (rt == "sm.010")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i7::sm.010::White ::7th      ::66500");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else
                                    {
                                        Clear();
                                        WriteLine("Wrong Product Code");
                                        WriteLine("******************");
                                    }
                                }
                                else if (bf == "lenovo"||bf=="Lenovo"||bf=="LENOVO")
                                {
                                    Clear();
                                    WriteLine("IN Lenovo compay follwing are avilabe in our markete");
                                    WriteLine("Product.Code::Device name::  Modle :: Genration    ::Colour:: Price ");
                                    WriteLine("  le.001    ::  lenovo  :: Core i3:: 2nd genration::Black :: Rs.12200-/");
                                    WriteLine("  le.002    ::  lenovo  :: Core i3:: 4th genration::Silver:: Rs.15300-/");
                                    WriteLine("  le.003    ::  lenovo  :: Core i5:: 2nd genration::White :: Rs.16150-/");
                                    WriteLine("  le.004    ::  lenovo  :: Core i5:: 4th genration::Grey  :: Rs.20400-/");
                                    WriteLine("  le.005    ::  lenovo  :: Core i5:: 7th genration::Black :: Rs.34500-/");
                                    WriteLine("  le.006    ::  lenovo  :: Core i7:: 3rd genration::White :: Rs.24100-/");
                                    WriteLine("  le.007    ::  lenovo  :: Core i7:: 4th genration::Grey  :: Rs.29999-/");
                                    WriteLine("  le.008    ::  lenovo  :: Core i7:: 5th genration::Silver:: Rs.36600-/");
                                    WriteLine("  le.009    ::  lenovo  :: Core i7:: 6th genration::Silver:: Rs.42100-/");
                                    WriteLine("  le.010    ::  lenovo  :: Core i7:: 7th genration::White :: Rs.66100-/");
                                    WriteLine("Type the Product Code for purchase");
                                    string tr = ReadLine();
                                    if (tr == "le.001")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i3::le.002::Black ::2nd      ::12200");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (tr == "le.002")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i3::le.002::Silver::4th      ::15300");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (tr == "le.003")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i5::le.003::White ::2nd      ::16150");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (tr == "le.004")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here--");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i5::le.004::Grey  ::4th      ::20400");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (tr == "le.005")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i5::le.005::Black ::7th      ::34500");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (tr == "le.006")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i7::le.006::White ::3rd      ::24100");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (tr == "le.007")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i7::le.007::Grey  ::4th      ::29999");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (tr == "le.008")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i7::le.008::Silver::5th      ::36600");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (tr == "le.009")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i7::le.009::Silver::6th      ::42100");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (tr == "le.010")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i7::le.010::White ::7th      ::66130");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else
                                    {
                                        Clear();
                                        WriteLine("Wrong Product Code");
                                        WriteLine("******************");
                                    }

                                }
                                else if (bf == "apple"||bf=="Apple"||bf=="APPLE")
                                {
                                    Clear();
                                    WriteLine("IN Apple company follwing are avilabe in our markete");
                                    WriteLine("Product.Code::Device name::  Modle :: Genration    ::Colour:: Price ");
                                    WriteLine("   ap.001   ::   Apple   :: Core i3:: 2nd genration::Black :: Rs.99000-/");
                                    WriteLine("   ap.002   ::   Apple   :: Core i3:: 4th genration::Silver:: Rs.153000-/");
                                    WriteLine("   ap.003   ::   Apple   :: Core i5:: 2nd genration::White :: Rs.161500-/");
                                    WriteLine("   ap.004   ::   Apple   :: Core i5:: 4th genration::Black :: Rs.204000-/");
                                    WriteLine("   ap.005   ::   Apple   :: Core i5:: 7th genration::Silver:: Rs.345000-/");
                                    WriteLine("   ap.006   ::   Apple   :: Core i7:: 3rd genration::White :: Rs.241000-/");
                                    WriteLine("   ap.007   ::   Apple   :: Core i7:: 4th genration::Black :: Rs.299990-/");
                                    WriteLine("   ap.008   ::   Apple   :: Core i7:: 5th genration::Silver:: Rs.366000-/");
                                    WriteLine("   ap.009   ::   Apple   :: Core i7:: 6th genration::White :: Rs.421600-/");
                                    WriteLine("   ap.010   ::   Apple   :: Core i7:: 7th genration::White :: Rs.661190-/");
                                    WriteLine("Type the Product Code for purchase");
                                    string tr = ReadLine();
                                    if (tr == "ap.001")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i3::ap.001::Black ::2nd      ::99000");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (tr == "ap.002")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i3::ap.002::Silver::4th      ::15300");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (tr == "ap.003")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i5::ap.003::White ::2nd      ::16150");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (tr == "ap.004")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i5::ap.004::Black ::4th      ::20400");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (tr == "ap.005")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i5::ap.005::Silver::7th      ::34500");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (tr == "ap.006")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i7::ap.001::White ::3rd      ::24100");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (tr == "ap.007")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i7::ap.007::Black ::4th      ::29999");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (tr == "ap.008")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i7::ap.008::Silver::5th      ::36600");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (tr == "ap.009")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i7::ap.009::White ::6th      ::42160");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else if (tr == "ap.010")
                                    {
                                        Clear();
                                        WriteLine("Your bill is here..");
                                        WriteLine("Modle  ::P.C   ::Colour::Genration::Price");
                                        WriteLine("core.i7::ap.010::White ::7th      ::66110");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("       ::      ::      ::         ::     ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("            Thanks For Shopping          ");
                                        WriteLine("                                         ");
                                    }
                                    else
                                    {
                                        Clear();
                                        WriteLine("Wrong Product Code");
                                        WriteLine("******************");
                                    }
                                }
                                else
                                {
                                    Clear();
                                    WriteLine("Sorry..invalid...");
                                    WriteLine("*****************");
                                }

                            }
                            else if (cat == "mobile"||cat=="Mobile"||cat=="MOBILE")
                            {
                                Clear();
                                WriteLine("Well come to Mobile to Shop..");
                                WriteLine("................................");
                                WriteLine("*********************************");
                                WriteLine("Folloing Companies are avilable in our markete:");
                                WriteLine(" Samsung,");
                                WriteLine("        Nokia,");
                                WriteLine("             Oppo,");
                                WriteLine("                  Huawie");
                                WriteLine("                      Q Mobile,");
                                WriteLine("Type your company Choice..");
                                string ld = ReadLine();
                                if (ld == "samsung"||ld=="Samsung"||ld=="SAMSUNG")
                                {
                                    Clear();
                                    WriteLine("Samsung..");
                                    WriteLine("Samsung Company the Follwing are available in our markete.");
                                    WriteLine("Product.Code::Device name::Modle::Colour ::Ram :: Rom ::Price      ");
                                    WriteLine("  sam.010   ::   Prime   ::  j1 ::b,w,g,R::1gb ::8gb ::Rs.11000-/  ");
                                    WriteLine("  sam.020   ::   Prime   ::  j5 ::b,w,g,R::2gb ::32gb::Rs.21000-/  ");
                                    WriteLine("  sam.030   ::   Prime   ::  j7 ::b,w,g,R::4gb ::64gb::Rs.29000-/  ");
                                    WriteLine("  sam.040   ::   Core    ::  j2 ::b,w,g,R::1gb ::8gb ::Rs.14000-/  ");
                                    WriteLine("  sam.050   ::   Core    ::  j5 ::b,w,g,R::2gb ::32gb::Rs.19000-/  ");
                                    WriteLine("  sam.060   ::   Core    ::  j7 ::b,w,g,R::3gb ::64gb::Rs.25000-/  ");
                                    WriteLine("  sam.070   ::   glaxy   ::  s6 ::b,w,g,R::6gb ::64gb::Rs.70000-/  ");
                                    WriteLine("  sam.080   ::   Core    ::G.360::b,w,g,R::1gb ::8gb ::Rs.17000-/  ");
                                    WriteLine("  sam.090   ::   galaxy  ::s3.+ ::b,w,g,R::4gb ::64gb::Rs.22000-/  ");
                                    WriteLine("  sam.011   ::   galaxy  ::  A3 ::b,w,g,R::2gb ::16gb::Rs.24000-/  ");
                                    WriteLine("Enter the product code of Mobile which you want to buy.............");
                                    string lg = ReadLine();
                                    if (lg == "sam.010")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("Modle  ::P.C    ::Colour ::Price");
                                        WriteLine("ji,prime::sam.010::White ::Rs.11000-/");
                                        WriteLine("        ::       ::      ::          ");
                                        WriteLine("        ::       ::      ::          ");
                                        WriteLine("        ::       ::      ::          ");
                                        WriteLine("        ::       ::      ::          ");
                                        WriteLine("-------------------------------------");
                                        WriteLine("        Thanks For Shopping          ");
                                        WriteLine("                                     ");

                                    }
                                    else if (lg == "sam.020")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("Modle  ::P.C    ::Colour ::Price");
                                        WriteLine("j5,prime::sam.020::Black ::Rs.21000-/");
                                        WriteLine("        ::       ::      ::          ");
                                        WriteLine("        ::       ::      ::          ");
                                        WriteLine("        ::       ::      ::          ");
                                        WriteLine("        ::       ::      ::          ");
                                        WriteLine("-------------------------------------");
                                        WriteLine("        Thanks For Shopping          ");
                                        WriteLine("                                     ");
                                    }
                                    else if (lg == "sam.030")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("Modle  ::P.C    ::Colour ::Price");
                                        WriteLine("j7,prime::sam.030::Golden::Rs.29000-/");
                                        WriteLine("        ::       ::      ::          ");
                                        WriteLine("        ::       ::      ::          ");
                                        WriteLine("        ::       ::      ::          ");
                                        WriteLine("        ::       ::      ::          ");
                                        WriteLine("-------------------------------------");
                                        WriteLine("        Thanks For Shopping          ");
                                        WriteLine("                                     ");
                                    }
                                    else if (lg == "sam.040")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("Modle  ::P.C    ::Colour ::Price     ");
                                        WriteLine("j2,prime::sam.040::Rose  ::Rs.14000-/");
                                        WriteLine("        ::       ::      ::          ");
                                        WriteLine("        ::       ::      ::          ");
                                        WriteLine("        ::       ::      ::          ");
                                        WriteLine("        ::       ::      ::          ");
                                        WriteLine("-------------------------------------");
                                        WriteLine("        Thanks For Shopping          ");
                                        WriteLine("                                     ");
                                    }
                                    else if (lg == "sam.050")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("Modle   ::P.C   ::Colour ::Price     ");
                                        WriteLine("j5,Core ::sam.050::White ::Rs.19000-/");
                                        WriteLine("        ::      ::      ::           ");
                                        WriteLine("        ::      ::      ::           ");
                                        WriteLine("        ::      ::      ::           ");
                                        WriteLine("        ::      ::      ::           ");
                                        WriteLine("-------------------------------------");
                                        WriteLine("        Thanks For Shopping          ");
                                        WriteLine("                                     ");
                                    }
                                    else if (lg == "sam.060")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("Modle   ::P.C   ::Colour::Price     ");
                                        WriteLine("j7,Core::sam.060::Black ::Rs.25000-/");
                                        WriteLine("        ::      ::      ::          ");
                                        WriteLine("        ::      ::      ::          ");
                                        WriteLine("        ::      ::      ::          ");
                                        WriteLine("        ::      ::      ::          ");
                                        WriteLine("------------------------------------");
                                        WriteLine("        Thanks For Shopping         ");
                                        WriteLine("                                    ");
                                    }
                                    else if (lg == "sam.070")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("Modle   ::P.C    ::Colour::Price");
                                        WriteLine("s6      ::sam.070::Golden::Rs.70000-/");
                                        WriteLine("        ::       ::      ::          ");
                                        WriteLine("        ::       ::      ::          ");
                                        WriteLine("        ::       ::      ::          ");
                                        WriteLine("        ::       ::      ::          ");
                                        WriteLine("-------------------------------------");
                                        WriteLine("        Thanks For Shopping          ");
                                        WriteLine("                                     ");
                                    }
                                    else if (lg == "sam.080")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("Modle   ::P.C    ::Colour ::Price   ");
                                        WriteLine("G.360   ::sam.080::Rose ::Rs.17000-/");
                                        WriteLine("        ::       ::      ::         ");
                                        WriteLine("        ::       ::      ::         ");
                                        WriteLine("        ::       ::      ::         ");
                                        WriteLine("        ::       ::      ::         ");
                                        WriteLine("------------------------------------");
                                        WriteLine("        Thanks For Shopping         ");
                                        WriteLine("                                    ");
                                    }
                                    else if (lg == "sam.090")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("Modle   ::P.C    ::Colour ::Price");
                                        WriteLine("s3,plus ::sam.010::White ::22000");
                                        WriteLine("        ::       ::      ::     ");
                                        WriteLine("        ::       ::      ::     ");
                                        WriteLine("        ::       ::      ::     ");
                                        WriteLine("        ::       ::      ::     ");
                                        WriteLine("-------------------------------");
                                        WriteLine("        Thanks For Shopping    ");
                                        WriteLine("                               ");
                                    }
                                    else if (lg == "sam.011")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("Modle  ::P.C     ::Colour ::Price");
                                        WriteLine("ji,prime::sam.011::Black  ::24000");
                                        WriteLine("        ::       ::       ::     ");
                                        WriteLine("        ::       ::       ::     ");
                                        WriteLine("        ::       ::       ::     ");
                                        WriteLine("        ::       ::       ::     ");
                                        WriteLine("---------------------------------");
                                        WriteLine("        Thanks For Shopping      ");
                                        WriteLine("                                 ");
                                    }
                                    else
                                    {
                                        Clear();
                                        WriteLine("Wrong product Code..");
                                        WriteLine("********************");
                                    }
                                }
                                else if (ld == "nokia"||ld =="Nokia"||ld=="NOKIA")
                                {
                                    Clear();
                                    WriteLine("Nokia");
                                    WriteLine("Nokia Company the Follwing are available in our markete.");
                                    WriteLine("product.code::Modle  ::Year::touch/keypad::Colour::price");
                                    WriteLine("nok.11      ::1208   ::2010::keypad      ::White ::Rs.1900-/ ");
                                    WriteLine("nok.12      ::3310   ::2016::keypad      ::Black ::Rs.6600-/ ");
                                    WriteLine("nok.13      ::230    ::2015::keypad      ::White ::Rs.6400-/ ");
                                    WriteLine("nok.14      ::206    ::2012::keypad      ::Black ::Rs.6200-/ ");
                                    WriteLine("nok.15      ::150    ::2011::keypad      ::White ::Rs.3900-/ ");
                                    WriteLine("nok.16      ::nokia.x::2015::Touch       ::black ::Rs.14500-/");
                                    WriteLine("nok.17      ::nokiaA3::2016::Touch       ::Black ::Rs.16000-/");
                                    WriteLine("nok.18      ::nokiaA5::2016::Touch       ::Black ::Rs.21950-/");
                                    WriteLine("nok.19      ::n.6300 ::2009::keypad      ::Silver::Rs.9999-/ ");
                                    WriteLine("nok.20      ::n.1600 ::2008::keypad      ::Black ::Rs.7999-/ ");
                                    WriteLine("Enter the product code of Mobile which you want to buy.......");
                                    string yt = ReadLine();
                                    if (yt == "nok.11")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle  ::year  ::Colour::price    ");
                                        WriteLine("nok.11 ::1208   ::2010  ::white ::Rs.1900-/");
                                        WriteLine("       ::       ::      ::      ::         ");
                                        WriteLine("       ::       ::      ::      ::         ");
                                        WriteLine("       ::       ::      ::      ::         ");
                                        WriteLine("-------------------------------------------");
                                        WriteLine("        Thanks For Shopping                ");
                                        WriteLine("                                           ");

                                    }
                                    else if (yt == "nok.12")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle  ::year  ::Colour::price    ");
                                        WriteLine("nok.12 ::3310   ::2016  ::Black ::Rs.6600-/");
                                        WriteLine("       ::       ::      ::      ::         ");
                                        WriteLine("       ::       ::      ::      ::         ");
                                        WriteLine("       ::       ::      ::      ::         ");
                                        WriteLine("-------------------------------------------");
                                        WriteLine("        Thanks For Shopping                ");
                                        WriteLine("                                           ");

                                    }
                                    else if (yt == "nok.13")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle  ::year  ::Colour::price    ");
                                        WriteLine("nok.13 ::230    ::2015  ::white ::Rs.6400-/");
                                        WriteLine("       ::       ::      ::      ::         ");
                                        WriteLine("       ::       ::      ::      ::         ");
                                        WriteLine("       ::       ::      ::      ::         ");
                                        WriteLine("-------------------------------------------");
                                        WriteLine("        Thanks For Shopping                ");
                                        WriteLine("                                           ");
                                    }
                                    else if (yt == "nok.14")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle  ::year  ::Colour::price    ");
                                        WriteLine("nok.14 ::206    ::2012  ::Black ::Rs.6200-/");
                                        WriteLine("       ::       ::      ::      ::         ");
                                        WriteLine("       ::       ::      ::      ::         ");
                                        WriteLine("       ::       ::      ::      ::         ");
                                        WriteLine("-------------------------------------------");
                                        WriteLine("        Thanks For Shopping                ");
                                        WriteLine("                                           ");

                                    }
                                    else if (yt == "nok.15")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle  ::year  ::Colour::price    ");
                                        WriteLine("nok.15 ::150    ::2011  ::White ::Rs.3900-/");
                                        WriteLine("       ::       ::      ::      ::         ");
                                        WriteLine("       ::       ::      ::      ::         ");
                                        WriteLine("       ::       ::      ::      ::         ");
                                        WriteLine("-------------------------------------------");
                                        WriteLine("        Thanks For Shopping                ");
                                        WriteLine("                                           ");
                                    }
                                    else if (yt == "nok.16")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle  ::year  ::Colour::price     ");
                                        WriteLine("nok.16 ::nokia.x::2015  ::black ::Rs.14500-/");
                                        WriteLine("       ::       ::      ::      ::          ");
                                        WriteLine("       ::       ::      ::      ::          ");
                                        WriteLine("       ::       ::      ::      ::          ");
                                        WriteLine("--------------------------------------------");
                                        WriteLine("        Thanks For Shopping                 ");
                                        WriteLine("                                            ");
                                    }
                                    else if (yt == "nok.17")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle  ::year  ::Colour::price     ");
                                        WriteLine("nok.17 ::NokiaA3::2016  ::balck ::Rs.16000-/");
                                        WriteLine("       ::       ::      ::      ::          ");
                                        WriteLine("       ::       ::      ::      ::          ");
                                        WriteLine("       ::       ::      ::      ::          ");
                                        WriteLine("--------------------------------------------");
                                        WriteLine("        Thanks For Shopping                 ");
                                        WriteLine("                                            ");
                                    }
                                    else if (yt == "nok.18")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle  ::year  ::Colour::price     ");
                                        WriteLine("nok.18 ::nokiaA5::2016  ::black ::Rs.21950-/");
                                        WriteLine("       ::       ::      ::      ::          ");
                                        WriteLine("       ::       ::      ::      ::          ");
                                        WriteLine("       ::       ::      ::      ::          ");
                                        WriteLine("--------------------------------------------");
                                        WriteLine("        Thanks For Shopping                 ");
                                        WriteLine("                                            ");
                                    }
                                    else if (yt == "nok.19")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle  ::year  ::Colour::price    ");
                                        WriteLine("nok.19 ::n.6300 ::2009  ::Silver::Rs.9999-/");
                                        WriteLine("       ::       ::      ::      ::         ");
                                        WriteLine("       ::       ::      ::      ::         ");
                                        WriteLine("-------------------------------------------");
                                        WriteLine("        Thanks For Shopping                ");
                                        WriteLine("                                           ");

                                    }
                                    else if (yt == "nok.20")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle  ::year  ::Colour::price    ");
                                        WriteLine("nok.20 ::n.1600 ::2008  ::black ::Rs.7999-/");
                                        WriteLine("       ::       ::      ::      ::         ");
                                        WriteLine("       ::       ::      ::      ::         ");
                                        WriteLine("       ::       ::      ::      ::         ");
                                        WriteLine("-------------------------------------------");
                                        WriteLine("        Thanks For Shopping                ");
                                        WriteLine("                                           ");
                                    }
                                    else
                                    {
                                        WriteLine("wrong product code");
                                        WriteLine("******************");
                                    }
                                }
                                else if (ld == "oppo"||ld=="Oppo"||ld=="OPPO")
                                {
                                    Clear();
                                    WriteLine("oppo");
                                    WriteLine("Oppo Company the Follwing are available in our markete.");
                                    WriteLine("product.code::Modle::Ram::Rom ::Colour ::price");
                                    WriteLine("op.21       ::f1   ::4gb::32gb::b,w,g,R::Rs.21000-/");
                                    WriteLine("op.22       ::f3   ::6gb::64gb::b,w,g,R::Rs.29000-/");
                                    WriteLine("op.23       ::A.37 ::2gb::16gb::b,w,g,R::Rs.16000-/");
                                    WriteLine("op.24       ::A57  ::3gb::32gb::b,w,g,R::Rs.20000-/");
                                    WriteLine("op.25       ::A.16 ::2gb::16gb::b,w,g,R::Rs.12000-/");
                                    WriteLine("op.26       ::yoyo ::1gb::16gb::b,w,g,R::Rs.9499-/ ");
                                    WriteLine("op.27       ::f5   ::3gb::32gb::b,w,g,R::Rs.27899-/");
                                    WriteLine("op.28       ::joy  ::1gb::8 gb::b,w,g,R::Rs.8500-/ ");
                                    WriteLine("op.29       ::f5   ::6gb::32gb::b,w,g,R::Rs.39899-/");
                                    WriteLine("op.30       ::f1.s ::4gb::32gb::b,w,g,R::Rs.26900-/");
                                    WriteLine("Enter the product code of Mobile which you want to buy..");
                                    string ty = ReadLine();
                                    if (ty == "op.21")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle  ::Ram ::Rom ::price     ");
                                        WriteLine("op.21  ::f1     ::4gb ::32gb::Rs.21000-/");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("----------------------------------------");
                                        WriteLine("        Thanks For Shopping             ");
                                        WriteLine("                                        ");

                                    }
                                    else if (ty == "op.22")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle  ::Ram ::Rom ::price     ");
                                        WriteLine("op.22  ::f3     ::6gb ::64gb::Rs.29000-/");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("----------------------------------------");
                                        WriteLine("        Thanks For Shopping             ");
                                        WriteLine("                                        ");
                                    }
                                    else if (ty == "op.23")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle  ::Ram ::Rom ::price     ");
                                        WriteLine("op.23  ::A.37   ::2gb ::16gb::Rs.16000-/");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("----------------------------------------");
                                        WriteLine("        Thanks For Shopping             ");
                                        WriteLine("                                        ");
                                    }
                                    else if (ty == "op.24")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle  ::Ram ::Rom ::price     ");
                                        WriteLine("op.24  ::A.57   ::3gb ::32gb::Rs.20000-/");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("----------------------------------------");
                                        WriteLine("        Thanks For Shopping             ");
                                        WriteLine("                                        ");
                                    }
                                    else if (ty == "op.25")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle  ::Ram ::Rom ::price     ");
                                        WriteLine("op.25  ::A.16   ::2gb ::16gb::Rs.12000-/");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("----------------------------------------");
                                        WriteLine("        Thanks For Shopping             ");
                                        WriteLine("                                        ");
                                    }
                                    else if (ty == "op.26")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle  ::Ram ::Rom ::price     ");
                                        WriteLine("op.26  ::f3     ::6gb ::64gb::Rs.29000-/");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("----------------------------------------");
                                        WriteLine("        Thanks For Shopping             ");
                                        WriteLine("                                        ");
                                    }
                                    else if (ty == "op.27")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle  ::Ram ::Rom ::price     ");
                                        WriteLine("op.27  ::yoyo   ::1gb ::16gb::Rs.9499-/ ");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("----------------------------------------");
                                        WriteLine("        Thanks For Shopping             ");
                                        WriteLine("                                        ");
                                    }
                                    else if (ty == "op.28")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle  ::Ram ::Rom ::price     ");
                                        WriteLine("op.28  ::joy    ::1gb ::8 gb::Rs.8500-/ ");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("----------------------------------------");
                                        WriteLine("        Thanks For Shopping             ");
                                        WriteLine("                                        ");
                                    }
                                    else if (ty == "op.29")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle  ::Ram ::Rom ::price     ");
                                        WriteLine("op.29  ::f5     ::6gb ::32gb::Rs.39899-/");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("----------------------------------------");
                                        WriteLine("        Thanks For Shopping             ");
                                        WriteLine("                                        ");
                                    }
                                    else if (ty == "op.30")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle  ::Ram ::Rom ::price     ");
                                        WriteLine("op.30  ::f1.s   ::4gb ::32gb::Rs.26900-/");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("----------------------------------------");
                                        WriteLine("        Thanks For Shopping             ");
                                        WriteLine("                                        ");
                                    }
                                    else
                                    {
                                        WriteLine("wrong product code");
                                        WriteLine("******************");
                                    }
                                }
                                else if (ld == "huawie"||ld=="Huawie"||ld=="HUAWIE")
                                {
                                    Clear();
                                    WriteLine("Huawie");
                                    WriteLine("Huawie Company the Follwing are available in our markete.");
                                    WriteLine("product.code::Modle   ::Ram::Rom  ::Colour::price");
                                    WriteLine("hu.21       ::honor.4c::2gb::8 gb ::b,w,g ::Rs.13000-/");
                                    WriteLine("hu.22       ::honor.4x::3gb::16gb ::b,w,g ::Rs.18000-/");
                                    WriteLine("hu.23       ::p.10lite::4gb::32gb ::b,w,g ::Rs.27000-/");
                                    WriteLine("hu.24       ::p.09lite::3gb::16gb ::b,w,g ::Rs.20000-/");
                                    WriteLine("hu.25       ::p.08lite::2gb::8gb  ::b,w,g ::Rs.17500-/");
                                    WriteLine("hu.26       ::y.5.!!  ::1gb::8gb  ::b,w,g ::Rs.12500-/");
                                    WriteLine("hu.27       ::mate.10 ::4gb::32gb ::b,w,g ::Rs.29500-/");
                                    WriteLine("hu.28       ::y.3     ::1gb::08gb ::b,w,g ::Rs.9636-/ ");
                                    WriteLine("hu.29       ::y.5     ::2gb::16gb ::b,w,g ::Rs.12798-/");
                                    WriteLine("hu.30       ::p.10plus::6gb::128gb::b,w,g ::Rs.57145-/");
                                    WriteLine("Enter the product code of Mobile which you want to buy..");
                                    string gm = ReadLine();
                                    if (gm == "hu.21")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle   ::Ram ::Rom ::price     ");
                                        WriteLine("hu.21  ::honor.4c::2gb ::08gb::Rs.13000-/");
                                        WriteLine("       ::        ::    ::    ::          ");
                                        WriteLine("       ::        ::    ::    ::          ");
                                        WriteLine("       ::        ::    ::    ::          ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("        Thanks For Shopping              ");
                                        WriteLine("                                         ");

                                    }
                                    else if (gm == "hu.22")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle   ::Ram ::Rom ::price     ");
                                        WriteLine("hu.22  ::honor.4x::3gb ::16gb::Rs.18000-/");
                                        WriteLine("       ::        ::    ::    ::          ");
                                        WriteLine("       ::        ::    ::    ::          ");
                                        WriteLine("       ::        ::    ::    ::          ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("        Thanks For Shopping              ");
                                        WriteLine("                                         ");
                                    }
                                    else if (gm == "hu.23")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle   ::Ram ::Rom ::price      ");
                                        WriteLine("hu.23  ::p.10lite::4gb ::32gb::Rs.27000-/ ");
                                        WriteLine("       ::        ::    ::    ::           ");
                                        WriteLine("       ::        ::    ::    ::           ");
                                        WriteLine("       ::        ::    ::    ::           ");
                                        WriteLine("------------------------------------------");
                                        WriteLine("        Thanks For Shopping               ");
                                        WriteLine("                                          ");
                                    }
                                    else if (gm == "hu.24")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle   ::Ram ::Rom ::price     ");
                                        WriteLine("hu.24  ::p.09lite::3gb ::16gb::Rs.20000-/");
                                        WriteLine("       ::        ::    ::    ::          ");
                                        WriteLine("       ::        ::    ::    ::          ");
                                        WriteLine("       ::        ::    ::    ::          ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("        Thanks For Shopping              ");
                                        WriteLine("                                         ");
                                    }
                                    else if (gm == "hu.25")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle   ::Ram ::Rom ::price     ");
                                        WriteLine("hu.25  ::p.08lite::2gb ::8gb::Rs.17500-/ ");
                                        WriteLine("       ::        ::    ::    ::          ");
                                        WriteLine("       ::        ::    ::    ::          ");
                                        WriteLine("       ::        ::    ::    ::          ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("        Thanks For Shopping              ");
                                        WriteLine("                                         ");
                                    }
                                    else if (gm == "hu.26")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle  ::Ram ::Rom ::price     ");
                                        WriteLine("hu.26  ::y 5.!! ::1gb ::8gb ::Rs.12500-/");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("----------------------------------------");
                                        WriteLine("        Thanks For Shopping             ");
                                        WriteLine("                                        ");
                                    }
                                    else if (gm == "hu.27")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle  ::Ram ::Rom ::price     ");
                                        WriteLine("hu.27  ::mate.10::4gb ::32gb::Rs.29500-/");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("----------------------------------------");
                                        WriteLine("        Thanks For Shopping             ");
                                        WriteLine("                                        ");
                                    }
                                    else if (gm == "hu.28")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle   ::Ram ::Rom ::price     ");
                                        WriteLine("hu.28  ::y.3     ::1gb ::08gb::Rs.9636-/ ");
                                        WriteLine("       ::        ::    ::    ::          ");
                                        WriteLine("       ::        ::    ::    ::          ");
                                        WriteLine("       ::        ::    ::    ::          ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("         Thanks For Shopping             ");
                                        WriteLine("                                         ");
                                    }
                                    else if (gm == "hu.29")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle   ::Ram ::Rom ::price     ");
                                        WriteLine("hu.29  ::y.5     ::2gb ::16gb::Rs.12798-/");
                                        WriteLine("       ::        ::    ::    ::          ");
                                        WriteLine("       ::        ::    ::    ::          ");
                                        WriteLine("       ::        ::    ::    ::          ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("         Thanks For Shopping             ");
                                        WriteLine("                                         ");
                                    }
                                    else if (gm == "hu.30")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle   ::Ram ::Rom  ::price     ");
                                        WriteLine("hu.30  ::p.10plus::6gb ::128gb::Rs.57145-/");
                                        WriteLine("       ::        ::    ::     ::          ");
                                        WriteLine("       ::        ::    ::     ::          ");
                                        WriteLine("       ::        ::    ::     ::          ");
                                        WriteLine("------------------------------------------");
                                        WriteLine("        Thanks For Shopping               ");
                                        WriteLine("                                         ");
                                    }
                                    else
                                    {
                                        Clear();
                                        WriteLine("wrong product code");
                                        WriteLine("******************");
                                    }
                                }
                                else if (ld == "q mobile"||ld=="Q mobile"||ld=="Q Mobile"||ld=="Q MOBILE")
                                {
                                    Clear();
                                    WriteLine("Q mobile");
                                    WriteLine("Q.mobile Company the Follwing are available in our markete.");
                                    WriteLine("product.code::Modle   ::Ram  ::Rom ::Colour::price");
                                    WriteLine("qm.21       ::s4      ::2gb  ::16gb::b,w   ::Rs.11700-/");
                                    WriteLine("qm.22       ::A1      ::3gb  ::32gb::b,w   ::Rs.21500-/");
                                    WriteLine("qm.23       ::CS1     ::2gb  ::16gb::b,w   ::Rs.14999-/");
                                    WriteLine("qm.24       ::Dual.1  ::1gb  ::08gb::b,w   ::Rs.8500-/ ");
                                    WriteLine("qm.25       ::i7i pro ::1gb  ::8gb ::b,w   ::Rs.7100-/ ");
                                    WriteLine("qm.26       ::j7 pro  ::2gb  ::16gb ::b,w  ::Rs.17899-/");
                                    WriteLine("qm.27       ::m350 pro::2gb  ::08gb::b,w   ::Rs.12500-/");
                                    WriteLine("qm.28       ::M6      ::3gb  ::32gb::b,w   ::Rs.26500-/");
                                    WriteLine("qm.29       ::x29     ::0.5gb::4 gb::b,w   ::Rs.4850-/ ");
                                    WriteLine("qm.30       ::x2 lite ::0.5gb::4 gb::b,w   ::Rs.4910-/ ");
                                    WriteLine("Enter the product code of Mobile which you want to buy..");
                                    string cm = ReadLine();
                                    if (cm == "qm.21")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle   ::Ram ::Rom ::price     ");
                                        WriteLine("qm.21  ::s4      ::2gb ::16gb::Rs.11700-/");
                                        WriteLine("       ::        ::    ::    ::          ");
                                        WriteLine("       ::        ::    ::    ::          ");
                                        WriteLine("       ::        ::    ::    ::          ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("        Thanks For Shopping              ");
                                        WriteLine("                                         ");

                                    }
                                    else if (cm == "qm.22")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle   ::Ram ::Rom ::price     ");
                                        WriteLine("qm.22  ::A1      ::3gb ::32gb::Rs.21500-/");
                                        WriteLine("       ::        ::    ::    ::          ");
                                        WriteLine("       ::        ::    ::    ::          ");
                                        WriteLine("       ::        ::    ::    ::          ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("        Thanks For Shopping              ");
                                        WriteLine("                                         ");
                                    }
                                    else if (cm == "qm.23")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle   ::Ram ::Rom ::price      ");
                                        WriteLine("qm.23  ::CS1     ::2gb ::16gb::Rs.14999-/ ");
                                        WriteLine("       ::        ::    ::    ::           ");
                                        WriteLine("       ::        ::    ::    ::           ");
                                        WriteLine("       ::        ::    ::    ::           ");
                                        WriteLine("------------------------------------------");
                                        WriteLine("        Thanks For Shopping               ");
                                        WriteLine("                                          ");
                                    }
                                    else if (cm == "qm.24")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle   ::Ram ::Rom ::price     ");
                                        WriteLine("qm.24  ::Dual.1  ::1gb ::8 gb::Rs.8500-/ ");
                                        WriteLine("       ::        ::    ::    ::          ");
                                        WriteLine("       ::        ::    ::    ::          ");
                                        WriteLine("       ::        ::    ::    ::          ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("        Thanks For Shopping              ");
                                        WriteLine("                                         ");
                                    }
                                    else if (cm == "qm.25")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle   ::Ram ::Rom ::price     ");
                                        WriteLine("qm.25  ::i7i pro ::1gb ::8gb::Rs.7100-/  ");
                                        WriteLine("       ::        ::    ::    ::          ");
                                        WriteLine("       ::        ::    ::    ::          ");
                                        WriteLine("       ::        ::    ::    ::          ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("        Thanks For Shopping              ");
                                        WriteLine("                                         ");
                                    }
                                    else if (cm == "qm.26")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle  ::Ram ::Rom ::price     ");
                                        WriteLine("qm.26  ::j7 pro ::2gb ::16gb::Rs.17899-/");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("       ::       ::    ::    ::          ");
                                        WriteLine("----------------------------------------");
                                        WriteLine("        Thanks For Shopping             ");
                                        WriteLine("                                        ");
                                    }
                                    else if (cm == "qm.27")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle   ::Ram ::Rom ::price     ");
                                        WriteLine("qm.27  ::m350 pro::2gb ::8 gb::Rs.12500-/");
                                        WriteLine("       ::        ::    ::    ::          ");
                                        WriteLine("       ::        ::    ::    ::          ");
                                        WriteLine("       ::        ::    ::    ::          ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("        Thanks For  Shopping             ");
                                        WriteLine("                                         ");
                                    }
                                    else if (cm == "qm.28")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle   ::Ram ::Rom ::price     ");
                                        WriteLine("qm.28  ::M6      ::3gb ::32gb::Rs.26500-/");
                                        WriteLine("       ::        ::    ::    ::          ");
                                        WriteLine("       ::        ::    ::    ::          ");
                                        WriteLine("       ::        ::    ::    ::          ");
                                        WriteLine("-----------------------------------------");
                                        WriteLine("         Thanks For Shopping             ");
                                        WriteLine("                                         ");
                                    }
                                    else if (cm == "qm.29")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle   ::Ram   ::Rom ::price     ");
                                        WriteLine("qm.29  ::x29     ::0.5gb ::4 gb::Rs.4850-/ ");
                                        WriteLine("       ::        ::      ::    ::          ");
                                        WriteLine("       ::        ::      ::    ::          ");
                                        WriteLine("       ::        ::      ::    ::          ");
                                        WriteLine("-------------------------------------------");
                                        WriteLine("         Thanks For Shopping               ");
                                        WriteLine("                                           ");
                                    }
                                    else if (cm == "qm.30")
                                    {
                                        Clear();
                                        WriteLine("You buy this Mobile");
                                        WriteLine("p.c    ::Modle   ::Ram  ::Rom ::price     ");
                                        WriteLine("qm.30  ::x2 lite ::0.5gb::4 gb::Rs.4910-/ ");
                                        WriteLine("       ::        ::     ::    ::          ");
                                        WriteLine("       ::        ::     ::    ::          ");
                                        WriteLine("       ::        ::     ::    ::          ");
                                        WriteLine("------------------------------------------");
                                        WriteLine("        Thanks For Shopping               ");
                                        WriteLine("                                          ");
                                    }
                                    else
                                    {
                                        WriteLine("wrong product code");
                                        WriteLine("******************");
                                    }
                                }
                                else
                                {
                                    WriteLine("invalid...");
                                    WriteLine("************");
                                }
                            }
                            else if (cat == "sports"||cat=="Sports"||cat=="SPORTS")
                            {
                                Clear();
                                WriteLine("Well Come TO Sports shop:");
                                WriteLine(".........................");
                                WriteLine("*************************");
                                WriteLine("In sports catagry follwing are avilable...");
                                WriteLine("                                          in our markete..");
                                WriteLine("Cricket..Bat,Tap Ball,hard ball,etc..");
                                WriteLine("         Football..Football,kit,shoes,etc...");
                                WriteLine("                   bedminten..Rocket,ball,shattel,etc...");
                                WriteLine("                              hockey..hockey,ball,kit,etc..");
                                WriteLine("Type your your Game...");
                                string al = ReadLine();
                                if (al == "cricket"||al=="Cricket"||al=="CRICKET")
                                {
                                    WriteLine("well come to cricket..");
                                    WriteLine("Cricket..");
                                    WriteLine("       bat,Tap Ball,hard ball,etc..");
                                    WriteLine("Type your choice in cricket which you want to buy..");
                                    string lg = ReadLine();
                                    if (lg == "bat"||lg=="Bat"||lg=="BAT")
                                    {
                                        Clear();
                                        WriteLine("The follwing bat are avilalle in our markete..");
                                        WriteLine("P.C::company::price    ");
                                        WriteLine("b.1::CA     ::Rs.1200-/");
                                        WriteLine("b.2::Star   ::Rs.1300-/");
                                        WriteLine("b.3::CA     ::Rs.1100-/");
                                        WriteLine("b.4::Star   ::Rs.1400-/");
                                        WriteLine("b.5::CA     ::Rs.1500-/");
                                        WriteLine("Type the product code of the bat which you want to buy..");
                                        string fl = ReadLine();
                                        if (fl == "b.1")
                                        {
                                            Clear();
                                            WriteLine("You buy this Bat.......");
                                            WriteLine("P.C::company::price    ");
                                            WriteLine("b.1::CA     ::Rs.1200-/");
                                            WriteLine("   ::       ::         ");
                                            WriteLine("   ::       ::         ");
                                            WriteLine("   ::       ::         ");
                                            WriteLine("   Thanks for shoping  ");
                                            WriteLine("                       ");
                                        }
                                        else if (fl == "b.2")
                                        {
                                            Clear();
                                            WriteLine("You buy this Bat.......");
                                            WriteLine("P.C::company::price    ");
                                            WriteLine("b.2::Star   ::Rs.1300-/");
                                            WriteLine("   ::       ::         ");
                                            WriteLine("   ::       ::         ");
                                            WriteLine("   ::       ::         ");
                                            WriteLine("   Thanks for shoping  ");
                                            WriteLine("                       ");
                                        }
                                        else if (fl == "b.3")
                                        {
                                            Clear();
                                            WriteLine("You buy this Bat.......");
                                            WriteLine("P.C::company::price    ");
                                            WriteLine("b.3::CA     ::Rs.1100-/");
                                            WriteLine("   ::       ::         ");
                                            WriteLine("   ::       ::         ");
                                            WriteLine("   ::       ::         ");
                                            WriteLine("   Thanks for shoping  ");
                                            WriteLine("                       ");
                                        }
                                        else if (fl == "b.4")
                                        {
                                            Clear();
                                            WriteLine("You buy this Bat.......");
                                            WriteLine("P.C::company::price    ");
                                            WriteLine("b.4::Star   ::Rs.1400-/");
                                            WriteLine("   ::       ::         ");
                                            WriteLine("   ::       ::         ");
                                            WriteLine("   ::       ::         ");
                                            WriteLine("   Thanks for shoping  ");
                                            WriteLine("                       ");
                                        }
                                        else if (fl == "b.5")
                                        {
                                            Clear();
                                            WriteLine("You buy this Bat.......");
                                            WriteLine("P.C::company::price    ");
                                            WriteLine("b.5::CA     ::Rs.1500-/");
                                            WriteLine("   ::       ::         ");
                                            WriteLine("   ::       ::         ");
                                            WriteLine("   ::       ::         ");
                                            WriteLine("   Thanks for shoping  ");
                                            WriteLine("                       ");
                                        }
                                        else
                                        {
                                            Clear();
                                            WriteLine("wrong product code..");
                                            WriteLine("********************");
                                        }
                                    }
                                    else if (lg == "tap ball"||lg=="Tap ball"||lg=="TAP BALL")
                                    {
                                        Clear();
                                        WriteLine("The follwing Tap Ball are avilalle in our markete..");
                                        WriteLine("P.C ::company::price   ");
                                        WriteLine("bl.1::CA     ::Rs.120-/");
                                        WriteLine("bl.2::Star   ::Rs.130-/");
                                        WriteLine("bl.3::CA     ::Rs.110-/");
                                        WriteLine("bl.4::Star   ::Rs.140-/");
                                        WriteLine("bl.5::CA     ::Rs.150-/");
                                        WriteLine("Type the product code of the bat which you want to buy..");
                                        string pm = ReadLine();
                                        if (pm == "bl.1")
                                        {
                                            Clear();
                                            WriteLine("Your bill is here......");
                                            WriteLine("P.C ::company::price   ");
                                            WriteLine("bl.1::CA     ::Rs.120-/");
                                            WriteLine("   ::       ::         ");
                                            WriteLine("   ::       ::         ");
                                            WriteLine("   ::       ::         ");
                                            WriteLine("   Thanks for shoping  ");
                                            WriteLine("                       ");
                                        }
                                        else if (pm == "bl.2")
                                        {
                                            Clear();
                                            WriteLine("Your bill is here......");
                                            WriteLine("P.C ::company::price   ");
                                            WriteLine("bl.2::Star   ::Rs.130-/");
                                            WriteLine("   ::       ::         ");
                                            WriteLine("   ::       ::         ");
                                            WriteLine("   ::       ::         ");
                                            WriteLine("   Thanks for shoping  ");
                                            WriteLine("                       ");
                                        }
                                        else if (pm == "bl.3")
                                        {
                                            Clear();
                                            WriteLine("Your bill is here......");
                                            WriteLine("P.C ::company::price   ");
                                            WriteLine("bl.3::CA     ::Rs.110-/");
                                            WriteLine("   ::       ::         ");
                                            WriteLine("   ::       ::         ");
                                            WriteLine("   ::       ::         ");
                                            WriteLine("   Thanks for shoping  ");
                                            WriteLine("                       ");
                                        }
                                        else if (pm == "bl.4")
                                        {
                                            Clear();
                                            WriteLine("Your bill is here......");
                                            WriteLine("P.C ::company::price   ");
                                            WriteLine("bl.4::Star   ::Rs.140-/");
                                            WriteLine("   ::       ::         ");
                                            WriteLine("   ::       ::         ");
                                            WriteLine("   ::       ::         ");
                                            WriteLine("   Thanks for shoping  ");
                                            WriteLine("                       ");
                                        }
                                        else if (pm == "bl.5")
                                        {
                                            Clear();
                                            WriteLine("Your bill is here......");
                                            WriteLine("P.C ::company::price   ");
                                            WriteLine("bl.5::CA     ::Rs.150-/");
                                            WriteLine("   ::       ::         ");
                                            WriteLine("   ::       ::         ");
                                            WriteLine("   ::       ::         ");
                                            WriteLine("   Thanks for shoping  ");
                                            WriteLine("                       ");
                                        }
                                        else
                                        {
                                            Clear();
                                            WriteLine("wrong product code.");
                                            WriteLine("*******************");
                                        }
                                    }
                                    else if (lg == "hard ball"||lg=="Hard Ball"||lg=="Hard ball")
                                    {
                                        Clear();
                                        WriteLine("The follwing Hard Ball are avilalle in our markete..");
                                        WriteLine("P.C ::company::colour::price   ");
                                        WriteLine("hb.1::CA     ::white ::Rs.200-/");
                                        WriteLine("hb.2::Star   ::Red   ::Rs.230-/");
                                        WriteLine("hb.3::CA     ::Red   ::Rs.210-/");
                                        WriteLine("hb.4::Star   ::White ::Rs.340-/");
                                        WriteLine("hb.5::CA     ::White ::Rs.450-/");
                                        WriteLine("Type the product code of the Hard ball which you want to buy..");
                                        string m = ReadLine();
                                        if (m == "hb.1")
                                        {
                                            Clear();
                                            WriteLine("Your bill is here..............");
                                            WriteLine("P.C ::company::colour::price   ");
                                            WriteLine("hb.1::CA     ::white ::Rs.120-/");
                                            WriteLine("    ::       ::       ::        ");
                                            WriteLine("    ::       ::       ::        ");
                                            WriteLine("    ::       ::       ::        ");
                                            WriteLine("--------------------------------");
                                            WriteLine("   Thanks for shoping           ");
                                            WriteLine("                                ");
                                        }
                                        else if (m == "hb.2")
                                        {
                                            Clear();
                                            WriteLine("Your bill is here..............");
                                            WriteLine("P.C ::company::colour::price   ");
                                            WriteLine("hb.2::Star   ::Red   ::Rs.230-/");
                                            WriteLine("    ::       ::       ::       ");
                                            WriteLine("    ::       ::       ::       ");
                                            WriteLine("    ::       ::       ::       ");
                                            WriteLine("-------------------------------");
                                            WriteLine("   Thanks for shoping          ");
                                            WriteLine("                               ");
                                        }
                                        else if (m == "hb.3")
                                        {
                                            Clear();
                                            WriteLine("Your bill is here..............");
                                            WriteLine("P.C ::company::colour::price   ");
                                            WriteLine("hb.3::CA     ::Red   ::Rs.210-/");
                                            WriteLine("    ::       ::       ::       ");
                                            WriteLine("    ::       ::       ::       ");
                                            WriteLine("    ::       ::       ::       ");
                                            WriteLine("-------------------------------");
                                            WriteLine("   Thanks for shoping          ");
                                            WriteLine("                               ");
                                        }
                                        else if (m == "hb.4")
                                        {
                                            Clear();
                                            WriteLine("Your bill is here..............");
                                            WriteLine("P.C ::company::colour::price   ");
                                            WriteLine("hb.4::Star   ::White ::Rs.340-/");
                                            WriteLine("    ::       ::       ::        ");
                                            WriteLine("    ::       ::       ::        ");
                                            WriteLine("    ::       ::       ::        ");
                                            WriteLine("-------------------------------");
                                            WriteLine("   Thanks for shoping          ");
                                            WriteLine("                               ");
                                        }
                                        else if (m == "hb.5")
                                        {
                                            Clear();
                                            WriteLine("Your bill is here..............");
                                            WriteLine("P.C ::company::colour::price   ");
                                            WriteLine("hb.5::CA     ::White ::Rs.450-/");
                                            WriteLine("    ::       ::       ::       ");
                                            WriteLine("    ::       ::       ::       ");
                                            WriteLine("    ::       ::       ::       ");
                                            WriteLine("-------------------------------");
                                            WriteLine("   Thanks for shoping          ");
                                            WriteLine("                               ");
                                        }
                                        else
                                        {
                                            Clear();
                                            WriteLine("wrong product code..");
                                            WriteLine("********************");
                                        }
                                    }
                                    else
                                    {
                                        Clear();
                                        WriteLine("Sorry this is not avilable in our markete.");
                                        WriteLine("******************************************");
                                    }
                                }
                                else if (al == "football"||al=="Football"||al=="FOOTBALL")
                                {
                                    Clear();
                                    WriteLine("well come to Football..");
                                    WriteLine("Football..");
                                    WriteLine("         Football,kit,shoes,etc...");
                                    WriteLine("Type your choice in cricket which you want to buy..");
                                    string l = ReadLine();
                                    if (l == "football"||l=="Football"||l=="FOOTBALL")
                                    {
                                        Clear();
                                        WriteLine("The follwing football are avilable in our markete:");
                                        WriteLine("P.c::company::Colour       ::price    ");
                                        WriteLine("f.1::       ::black & White::Rs.1500-/");
                                        WriteLine("f.2::       ::black & White::Rs.2000-/");
                                        WriteLine("f.3::       ::Red & White  ::Rs.2500-/");
                                        WriteLine("f.4::       ::Red & White  ::Rs.1000-/");
                                        WriteLine("f.5::       ::Blue & White ::Rs.900 -/");
                                        WriteLine("--------------------------------------");
                                        WriteLine("Type the product code which you want to buy..");
                                        string z = ReadLine();
                                        if (z == "f.1")
                                        {
                                            Clear();
                                            WriteLine("your bill is here");
                                            WriteLine("you buy thhis football");
                                            WriteLine("P.c::company::Colour       ::price    ");
                                            WriteLine("f.1::       ::black & White::Rs.1500-/");
                                            WriteLine("   ::       ::             ::         ");
                                            WriteLine("   ::       ::             ::         ");
                                            WriteLine("--------------------------------------");
                                            WriteLine("            Thanks for shoping        ");
                                            WriteLine("                                      ");
                                        }
                                        else if (z == "f.2")
                                        {
                                            Clear();
                                            WriteLine("your bill is here");
                                            WriteLine("you buy thhis football");
                                            WriteLine("P.c::company::Colour       ::price    ");
                                            WriteLine("f.2::       ::black & White::Rs.2000-/");
                                            WriteLine("   ::       ::             ::         ");
                                            WriteLine("   ::       ::             ::         ");
                                            WriteLine("--------------------------------------");
                                            WriteLine("            Thanks for shoping        ");
                                            WriteLine("                                      ");
                                        }
                                        else if (z == "f.3")
                                        {
                                            Clear();
                                            WriteLine("your bill is here");
                                            WriteLine("you buy thhis football");
                                            WriteLine("P.c::company::Colour       ::price    ");
                                            WriteLine("f.3::       ::Red   & White::Rs.2500-/");
                                            WriteLine("   ::       ::             ::         ");
                                            WriteLine("   ::       ::             ::         ");
                                            WriteLine("--------------------------------------");
                                            WriteLine("            Thanks for shoping        ");
                                            WriteLine("                                      ");
                                        }
                                        else if (z == "f.4")
                                        {
                                            Clear();
                                            WriteLine("your bill is here");
                                            WriteLine("you buy thhis football");
                                            WriteLine("P.c::company::Colour       ::price    ");
                                            WriteLine("f.4::       ::Red   & White::Rs.1000-/");
                                            WriteLine("   ::       ::             ::         ");
                                            WriteLine("   ::       ::             ::         ");
                                            WriteLine("--------------------------------------");
                                            WriteLine("            Thanks for shoping        ");
                                            WriteLine("                                      ");
                                        }
                                        if (z == "f.5")
                                        {
                                            Clear();
                                            WriteLine("your bill is here");
                                            WriteLine("you buy thhis football");
                                            WriteLine("P.c::company::Colour       ::price    ");
                                            WriteLine("f.5::       ::blue  & White::Rs.900-/ ");
                                            WriteLine("   ::       ::             ::         ");
                                            WriteLine("   ::       ::             ::         ");
                                            WriteLine("--------------------------------------");
                                            WriteLine("            Thanks for shoping        ");
                                            WriteLine("                                      ");
                                        }
                                        else
                                        {
                                            Clear();
                                            WriteLine("Wrong product code..");
                                            WriteLine("********************");
                                        }
                                    }
                                    else if (l == "kit"||l=="KIT"||l=="Kit")
                                    {
                                        Clear();
                                        WriteLine("The follwing kit are avilable in our markete:");
                                        WriteLine("P.c::Number  ::Colour       ::price   ");
                                        WriteLine("k.1::10,11,13::black & White::Rs.500-/");
                                        WriteLine("k.2::79,07,10::black & Red  ::Rs.700-/");
                                        WriteLine("k.3::10,77,12::Red & White  ::Rs.600-/");
                                        WriteLine("k.4::14,09,11::Red & Green  ::Rs.400-/");
                                        WriteLine("k.5::99,87,44::Blue & White ::Rs.300-/");
                                        WriteLine("--------------------------------------");
                                        WriteLine("Type the product code which you want to buy..");
                                        string f = ReadLine();
                                        if (f == "k.1")
                                        {
                                            Clear();
                                            WriteLine("your bill is here..");
                                            WriteLine("you buy this kit...");
                                            WriteLine("P.c::Number  ::Colour       ::price   ");
                                            WriteLine("k.1::10,11,13::black & White::Rs.500-/");
                                            WriteLine("   ::       ::             ::         ");
                                            WriteLine("   ::       ::             ::         ");
                                            WriteLine("--------------------------------------");
                                            WriteLine("            Thanks for shoping        ");
                                            WriteLine("                                      ");
                                        }
                                        else if (f == "k.2")
                                        {
                                            Clear();
                                            WriteLine("your bill is here..");
                                            WriteLine("you buy this kit...");
                                            WriteLine("P.c::Number  ::Colour       ::price   ");
                                            WriteLine("k.2::79,07,10::black & Red  ::Rs.700-/");
                                            WriteLine("   ::       ::             ::         ");
                                            WriteLine("   ::       ::             ::         ");
                                            WriteLine("--------------------------------------");
                                            WriteLine("            Thanks for shoping        ");
                                            WriteLine("                                      ");
                                        }
                                        else if (f == "k.3")
                                        {
                                            Clear();
                                            WriteLine("your bill is here..");
                                            WriteLine("you buy this kit...");
                                            WriteLine("P.c::Number  ::Colour       ::price   ");
                                            WriteLine("k.3::10,77,12::Red & White  ::Rs.600-/");
                                            WriteLine("   ::       ::             ::         ");
                                            WriteLine("   ::       ::             ::         ");
                                            WriteLine("--------------------------------------");
                                            WriteLine("            Thanks for shoping        ");
                                            WriteLine("                                      ");
                                        }
                                        else if (f == "k.4")
                                        {
                                            Clear();
                                            WriteLine("your bill is here..");
                                            WriteLine("you buy this kit...");
                                            WriteLine("P.c::Number  ::Colour       ::price   ");
                                            WriteLine("k.4::14,09,11::Red & Green  ::Rs.400-/");
                                            WriteLine("   ::       ::             ::         ");
                                            WriteLine("   ::       ::             ::         ");
                                            WriteLine("--------------------------------------");
                                            WriteLine("            Thanks for shoping        ");
                                            WriteLine("                                      ");
                                        }
                                        else if (f == "k.5")
                                        {
                                            Clear();
                                            WriteLine("your bill is here..");
                                            WriteLine("you buy this kit...");
                                            WriteLine("P.c::Number  ::Colour       ::price   ");
                                            WriteLine("k.5::99,87,44::Blue & White ::Rs.300-/");
                                            WriteLine("   ::       ::             ::         ");
                                            WriteLine("   ::       ::             ::         ");
                                            WriteLine("--------------------------------------");
                                            WriteLine("            Thanks for shoping        ");
                                            WriteLine("                                      ");
                                        }
                                        else
                                        {
                                            Clear();
                                            WriteLine("wrong produt code..");
                                            WriteLine("*******************");
                                        }
                                    }
                                    else if (l == "shoes")
                                    {
                                        Clear();
                                        WriteLine("Shoes....");
                                        WriteLine("type the number of shoes");
                                        string k = ReadLine();
                                        if (k == "11")
                                        {
                                            Clear();
                                            WriteLine("you buy this shoes..");
                                            WriteLine("price..Rs.1900-/");
                                            WriteLine("Thanks for Shopping");
                                            WriteLine("--------------------");
                                            WriteLine("                    ");
                                        }
                                        else if (k == "12")
                                        {
                                            Clear();
                                            WriteLine("you buy this shoes..");
                                            WriteLine("price..Rs.2000-/    ");
                                            WriteLine("Thanks for Shopping");
                                            WriteLine("--------------------");
                                            WriteLine("                    ");
                                        }
                                        else if (k == "10")
                                        {
                                            Clear();
                                            WriteLine("you buy this shoes..");
                                            WriteLine("price..Rs.1600-/    ");
                                            WriteLine("Thanks for Shopping");
                                            WriteLine("--------------------");
                                            WriteLine("                    ");
                                        }
                                        else if (k == "09")
                                        {
                                            Clear();
                                            WriteLine("you buy this shoes..");
                                            WriteLine("price..Rs.1400-/    ");
                                            WriteLine("Thanks for Shopping ");
                                            WriteLine("--------------------");
                                            WriteLine("                    ");
                                        }
                                        else if (k == "08")
                                        {
                                            Clear();
                                            WriteLine("you buy this shoes..");
                                            WriteLine("price..Rs.1300-/    ");
                                            WriteLine("Thanks for Shopping");
                                            WriteLine("--------------------");
                                            WriteLine("                    ");
                                        }
                                        else
                                        {
                                            Clear();
                                            WriteLine("Sorry this size is not avilalbe..");
                                            WriteLine("*********************************");
                                        }
                                    }
                                    else
                                    {
                                        Clear();
                                        WriteLine("Sorry this item is not avilalbe in our markete");
                                        WriteLine("**********************************************");
                                    }
                                }
                                else if(al == "bedminton"||al=="Bedminton"||al=="BEDMINTON")
                                {
                                    Clear();
                                    WriteLine("well come to Bedminton..");
                                    WriteLine("Bedminton..");
                                    WriteLine("         Rocket,Ball,shattle,etc...");
                                    WriteLine("Type your choice in Bedminton which you want to buy..");
                                    string z = ReadLine();
                                    if(z == "Rocket"||z=="Rocket"||z=="ROCKET")
                                    {
                                        Clear();
                                        WriteLine("Rockets..");
                                        WriteLine("Type which type you want to buy..");
                                        WriteLine("wood");
                                        WriteLine("    steel");
                                        WriteLine("         iron");
                                        string e = ReadLine();
                                        if(e == "wood"||e=="Wood"||e=="WOOD")
                                        {
                                            Clear();
                                            WriteLine("p.c::price   ");
                                            WriteLine("r.1::Rs.600-/");
                                            WriteLine("r.2::Rs.500-/");
                                            WriteLine("r.3::Rs.700-/");
                                            WriteLine("r.4::Rs.800-/");
                                            WriteLine("r.5::Rs.900-/");
                                            WriteLine("-------------");
                                            WriteLine("Type the product code which you want to buy.");
                                            string w = ReadLine();
                                            if(w == "r.1")
                                            {
                                                Clear();
                                                WriteLine("You buy this Rocket..");
                                                WriteLine("p.c::price   ");
                                                WriteLine("r.1::Rs.600-/");
                                                WriteLine("-------------");
                                                WriteLine("Thanks for shooping");
                                            }
                                            else if(w == "r.2")
                                            {
                                                Clear();
                                                WriteLine("You buy this Rocket..");
                                                WriteLine("p.c::price   ");
                                                WriteLine("r.2::Rs.500-/");
                                                WriteLine("-------------");
                                                WriteLine("Thanks for shooping");
                                            }
                                            else if(w == "r.3")
                                            {
                                                Clear();
                                                WriteLine("You buy this Rocket..");
                                                WriteLine("p.c::price   ");
                                                WriteLine("r.3::Rs.700-/");
                                                WriteLine("-------------");
                                                WriteLine("Thanks for shooping");
                                            }
                                            else if(w == "r.4")
                                            {
                                                Clear();
                                                WriteLine("You buy this Rocket..");
                                                WriteLine("p.c::price   ");
                                                WriteLine("r.4::Rs.800-/");
                                                WriteLine("-------------");
                                                WriteLine("Thanks for shooping");
                                            }
                                            else if(w == "r.5")
                                            {
                                                Clear();
                                                WriteLine("You buy this Rocket..");
                                                WriteLine("p.c::price   ");
                                                WriteLine("r.5::Rs.900-/");
                                                WriteLine("-------------");
                                                WriteLine("Thanks for shooping"); 
                                            }
                                            else
                                            {
                                                Clear();
                                                WriteLine("wrong product code.");
                                                WriteLine("*******************");
                                            }
                                        }
                                        else if(e == "steel"||e=="Steel"||e=="STEEL")
                                        {
                                            Clear();
                                            WriteLine("p.c ::price    ");
                                            WriteLine("rs.1::Rs.700-/ ");
                                            WriteLine("rs.2::Rs.900-/ ");
                                            WriteLine("rs.3::Rs.1000-/");
                                            WriteLine("rs.4::Rs.1100-/");
                                            WriteLine("rs.5::Rs.1500-/");
                                            WriteLine("Type the product code which you want to buy.");
                                            string t = ReadLine();
                                            if (t == "rs.1")
                                            {
                                                Clear();
                                                WriteLine("You buy this Rocket..");
                                                WriteLine("p.c ::price   ");
                                                WriteLine("rs.1::Rs.700-/");
                                                WriteLine("-------------");
                                                WriteLine("Thanks for shooping");
                                            }
                                            else if (t == "rs.2")
                                            {
                                                Clear();
                                                WriteLine("You buy this Rocket..");
                                                WriteLine("p.c ::price   ");
                                                WriteLine("rs.2::Rs.900-/");
                                                WriteLine("-------------");
                                                WriteLine("Thanks for shooping");
                                            }
                                            else if (t == "rs.3")
                                            {
                                                Clear();
                                                WriteLine("You buy this Rocket..");
                                                WriteLine("p.c ::price    ");
                                                WriteLine("rs.3::Rs.1000-/");
                                                WriteLine("-------------");
                                                WriteLine("Thanks for shooping");
                                            }
                                            else if (t == "r.4")
                                            {
                                                Clear();
                                                WriteLine("You buy this Rocket..");
                                                WriteLine("p.c ::price   ");
                                                WriteLine("rs.4::Rs.1100-/");
                                                WriteLine("-------------");
                                                WriteLine("Thanks for shooping");
                                            }
                                            else if (t == "r.5")
                                            {
                                                Clear();
                                                WriteLine("You buy this Rocket..");
                                                WriteLine("p.c ::price   ");
                                                WriteLine("rs.5::Rs.1500-/");
                                                WriteLine("-------------");
                                                WriteLine("Thanks for shooping");
                                            }
                                            else
                                            {
                                                Clear();
                                                WriteLine("wrong product code.");
                                                WriteLine("*******************");
                                            }
                                        }
                                        else if(e == "iron"||e=="Iron"||e=="IRON")
                                        {
                                            Clear();
                                            WriteLine("p.c::price   ");
                                            WriteLine("ir.1::Rs.300-/");
                                            WriteLine("ir.2::Rs.400-/");
                                            WriteLine("ir.3::Rs.500-/");
                                            WriteLine("ir.4::Rs.600-/");
                                            WriteLine("ir.5::Rs.700-/");
                                            WriteLine("Type the product code which you want to buy.");
                                            string q = ReadLine();
                                            if (q == "r.1")
                                            {
                                                Clear();
                                                WriteLine("You buy this Rocket..");
                                                WriteLine("p.c ::price   ");
                                                WriteLine("ir.1::Rs.300-/");
                                                WriteLine("-------------");
                                                WriteLine("Thanks for shooping");
                                            }
                                            else if (q == "ir.2")
                                            {
                                                Clear();
                                                WriteLine("You buy this Rocket..");
                                                WriteLine("p.c ::price   ");
                                                WriteLine("ir.2::Rs.400-/");
                                                WriteLine("-------------");
                                                WriteLine("Thanks for shooping");
                                            }
                                            else if (q == "ir.3")
                                            {
                                                Clear();
                                                WriteLine("You buy this Rocket..");
                                                WriteLine("p.c ::price   ");
                                                WriteLine("ir.3::Rs.500-/");
                                                WriteLine("-------------");
                                                WriteLine("Thanks for shooping");
                                            }
                                            else if (q == "ir.4")
                                            {
                                                Clear();
                                                WriteLine("You buy this Rocket..");
                                                WriteLine("p.c ::price   ");
                                                WriteLine("ir.4::Rs.600-/");
                                                WriteLine("-------------");
                                                WriteLine("Thanks for shooping");
                                            }
                                            else if (q == "ir.5")
                                            {
                                                Clear();
                                                WriteLine("You buy this Rocket..");
                                                WriteLine("p.c ::price   ");
                                                WriteLine("ir.5::Rs.700-/");
                                                WriteLine("-------------");
                                                WriteLine("Thanks for shooping");
                                            }
                                            else
                                            {
                                                Clear();
                                                WriteLine("wrong product code.");
                                                WriteLine("*******************");
                                            }
                                        }
                                        else
                                        {
                                            Clear();
                                            WriteLine("invalid...");
                                            WriteLine("***********");
                                        }
                                    }
                                    else if(z == "ball"||z=="Ball"||z=="BALL")
                                    {
                                        Clear();
                                        WriteLine("ball..");
                                        WriteLine("p.c ::price   ");
                                        WriteLine("rb.1::Rs.200-/");
                                        WriteLine("rb.2::Rs.300-/");
                                        WriteLine("rb.3::Rs.400-/");
                                        WriteLine("rb.4::Rs.500-/");
                                        WriteLine("rb.5::Rs.600-/");
                                        WriteLine("Type the product code which you want to buy.");
                                        string y = ReadLine();
                                        if (y == "rb.1")
                                        {
                                            Clear();
                                            WriteLine("You buy this ball..");
                                            WriteLine("p.c ::price   ");
                                            WriteLine("rb.1::Rs.200-/");
                                            WriteLine("-------------");
                                            WriteLine("Thanks for shooping");
                                        }
                                        else if (y == "rb.2")
                                        {
                                            Clear();
                                            WriteLine("You buy this ball..");
                                            WriteLine("p.c ::price   ");
                                            WriteLine("rb.2::Rs.300-/");
                                            WriteLine("-------------");
                                            WriteLine("Thanks for shooping");
                                        }
                                        else if (y == "rb.3")
                                        {
                                            Clear();
                                            WriteLine("You buy this ball..");
                                            WriteLine("p.c ::price   ");
                                            WriteLine("rb.3::Rs.400-/");
                                            WriteLine("-------------");
                                            WriteLine("Thanks for shooping");
                                        }
                                        else if (y == "rb.4")
                                        {
                                            Clear();
                                            WriteLine("You buy this Ball..");
                                            WriteLine("p.c ::price   ");
                                            WriteLine("rb.4::Rs.500-/");
                                            WriteLine("-------------");
                                            WriteLine("Thanks for shooping");
                                        }
                                        else if (y == "r.5")
                                        {
                                            Clear();
                                            WriteLine("You buy this ball..");
                                            WriteLine("p.c ::price   ");
                                            WriteLine("rb.5::Rs.600-/");
                                            WriteLine("-------------");
                                            WriteLine("Thanks for shooping");
                                        }
                                        else
                                        {
                                            Clear();
                                            WriteLine("wrong product code.");
                                            WriteLine("*******************");
                                        }
                                    }
                                    else if(z == "shattle"||z=="Shattle"||z=="SHATTLE")
                                    {
                                        Clear();
                                        WriteLine("shattle.");
                                        WriteLine("p.c::price   ");
                                        WriteLine("s.1::Rs.90-/ ");
                                        WriteLine("s.2::Rs.120-/");
                                        WriteLine("s.3::Rs.140-/");
                                        WriteLine("s.4::Rs.150-/");
                                        WriteLine("s.5::Rs.190-/");
                                        WriteLine("Type the product code which you want to buy.");
                                        string o = ReadLine();
                                        if (o == "s.1")
                                        {
                                            Clear();
                                            WriteLine("You buy this Shattle..");
                                            WriteLine("p.c ::price   ");
                                            WriteLine("s.1 ::Rs.090-/");
                                            WriteLine("-------------");
                                            WriteLine("Thanks for shooping");
                                        }
                                        else if (o == "s.2")
                                        {
                                            Clear();
                                            WriteLine("You buy this Shattle..");
                                            WriteLine("p.c ::price   ");
                                            WriteLine("s.2 ::Rs.120-/");
                                            WriteLine("-------------");
                                            WriteLine("Thanks for shooping");
                                        }
                                        else if (o == "s.3")
                                        {
                                            Clear();
                                            WriteLine("You buy this Shattle..");
                                            WriteLine("p.c ::price   ");
                                            WriteLine("s.3 ::Rs.140-/");
                                            WriteLine("-------------");
                                            WriteLine("Thanks for shooping");
                                        }
                                        else if (o == "s.4")
                                        {
                                            Clear();
                                            WriteLine("You buy this Shattle..");
                                            WriteLine("p.c ::price   ");
                                            WriteLine("s.4 ::Rs.150-/");
                                            WriteLine("-------------");
                                            WriteLine("Thanks for shooping");
                                        }
                                        else if (o == "s.5")
                                        {
                                            Clear();
                                            WriteLine("You buy this shattle..");
                                            WriteLine("p.c ::price   ");
                                            WriteLine("s.5::Rs.190-/ ");
                                            WriteLine("-------------");
                                            WriteLine("Thanks for shooping");
                                        }
                                        else
                                        {
                                            Clear();
                                            WriteLine("wrong product code.");
                                            WriteLine("*******************");
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            Clear();
                            WriteLine("wrong pin code:.....");
                            WriteLine("********************");
                        }
                    }
                    else
                    {
                        Clear();
                        WriteLine("wrong name:.....");
                        WriteLine("*******************");
                    }
                }
                else if (cr == 'n'||cr=='N')
                {
                    Clear();
                    WriteLine("Well come to chase up market web site");
                    WriteLine("Location....");
                    WriteLine("fiasalabad,styana road, sleemi chok...");
                    WriteLine("products..");
                    WriteLine("laptops,Mobiles,sports,Garments,Toys,etc");
                    WriteLine("Timming...");
                    WriteLine("24 hours");
                    WriteLine("GOOD LUCK");
                }
                else if (cr == 'w'||cr=='W')
                {
                    Clear();
                    WriteLine("You Want to job on Chase Up,,\n  Drop your Cv in the Cv box on the Main gate");
                }
                else
                {
                    Clear();
                    WriteLine("Invalid.....");
                    WriteLine("*********************");
                }

            }

        }
    }
}