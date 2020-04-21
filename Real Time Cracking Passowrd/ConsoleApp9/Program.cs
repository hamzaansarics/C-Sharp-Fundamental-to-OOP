using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            Console.WriteLine("Select Type of Cracking");
            Console.WriteLine("1-Full Cracking\n 2-For only Small Character Cracking ");
            int ns = Convert.ToInt32(Console.ReadLine());

            if (ns == 1)
            {
                #region Complete search

                string g = null;
                string sbs = "-kha";
                Console.WriteLine("Enter Length of Password");
                int np = Convert.ToInt32(Console.ReadLine());

                string[] an = new string[]
                {
                "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p",
                   "q","r","s","t","u","v","w","x","y","z",

                   "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P",
                   "Q","R","S","T","U","V","W","X","Y","Z",

                   "0","1","2","3","4","5","6","7","8","9",

                   "+","-","!","@","#","$","%","^","&","*","/","_","?",",",":",";","|","=","(",")","{","}","<",">","."

                };

                if (np == 3)
                {
                    for (int a = 0; a < an.Length; a++)
                    {
                        for (int b = 0; b < an.Length; b++)
                        {
                            for (int c = 0; c < an.Length; c++)
                            {
                                if (an[a] + an[b] + an[c] == sbs)
                                {
                                    g = an[a] + an[b] + an[c];
                                }
                            }

                        }

                    }
                }
                else if (np == 4)
                {

                    for (int a = 0; a < an.Length; a++)
                    {
                        for (int b = 0; b < an.Length; b++)
                        {
                            for (int c = 0; c < an.Length; c++)
                            {
                                for (int d = 0; d < an.Length; d++)
                                {
                                    if (an[a] + an[b] + an[c] + an[d] == sbs)
                                    {
                                        g = an[a] + an[b] + an[c] + an[d];
                                    }
                                }
                            }

                        }

                    }
                }
                else if (np == 5)
                {

                    for (int a = 0; a < an.Length; a++)
                    {
                        for (int b = 0; b < an.Length; b++)
                        {
                            for (int c = 0; c < an.Length; c++)
                            {
                                for (int d = 0; d < an.Length; d++)
                                {
                                    for (int e = 0; e < an.Length; e++)
                                    {
                                        if (an[a] + an[b] + an[c] + an[d] + an[e] == sbs)
                                        {
                                            g = an[a] + an[b] + an[c] + an[d] + an[e];
                                        }
                                    }
                                }
                            }

                        }

                    }
                }
                else if (np == 6)
                {

                    for (int a = 0; a < an.Length; a++)
                    {
                        for (int b = 0; b < an.Length; b++)
                        {
                            for (int c = 0; c < an.Length; c++)
                            {
                                for (int d = 0; d < an.Length; d++)
                                {
                                    for (int e = 0; e < an.Length; e++)
                                    {
                                        for (int f = 0; f < an.Length; f++)
                                        {

                                            if (an[a] + an[b] + an[c] + an[d] + an[e] + an[f] == sbs)
                                            {
                                                g = an[a] + an[b] + an[c] + an[d] + an[e] + an[f];
                                            }
                                        }
                                    }
                                }
                            }

                        }

                    }
                }
                else if (np == 7)
                {

                    for (int a = 0; a < an.Length; a++)
                    {
                        for (int b = 0; b < an.Length; b++)
                        {
                            for (int c = 0; c < an.Length; c++)
                            {
                                for (int d = 0; d < an.Length; d++)
                                {
                                    for (int e = 0; e < an.Length; e++)
                                    {
                                        for (int f = 0; f < an.Length; f++)
                                        {
                                            for (int h = 0; h < an.Length; h++)
                                            {

                                                if (an[a] + an[b] + an[c] + an[d] + an[e] + an[f] + an[h] == sbs)
                                                {
                                                    g = an[a] + an[b] + an[c] + an[d] + an[e] + an[f] + an[h];
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }

                    }
                }
                else if (np == 8)
                {

                    for (int a = 0; a < an.Length; a++)
                    {
                        for (int b = 0; b < an.Length; b++)
                        {
                            for (int c = 0; c < an.Length; c++)
                            {
                                for (int d = 0; d < an.Length; d++)
                                {
                                    for (int e = 0; e < an.Length; e++)
                                    {
                                        for (int f = 0; f < an.Length; f++)
                                        {
                                            for (int h = 0; h < an.Length; h++)
                                            {

                                                for (int i = 0; i < an.Length; i++)
                                                {
                                                    if (an[a] + an[b] + an[c] + an[d] + an[e] + an[f] + an[h] + an[i] == sbs)
                                                    {
                                                        g = an[a] + an[b] + an[c] + an[d] + an[e] + an[f] + an[h] + an[i];
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }

                    }
                }
                else if (np == 9)
                {

                    for (int a = 0; a < an.Length; a++)
                    {
                        for (int b = 0; b < an.Length; b++)
                        {
                            for (int c = 0; c < an.Length; c++)
                            {
                                for (int d = 0; d < an.Length; d++)
                                {
                                    for (int e = 0; e < an.Length; e++)
                                    {
                                        for (int f = 0; f < an.Length; f++)
                                        {
                                            for (int h = 0; h < an.Length; h++)
                                            {

                                                for (int i = 0; i < an.Length; i++)
                                                {
                                                    for (int j = 0; j < an.Length; j++)
                                                    {
                                                        if (an[a] + an[b] + an[c] + an[d] + an[e] + an[f] + an[h] + an[i] + an[j] == sbs)
                                                        {
                                                            g = an[a] + an[b] + an[c] + an[d] + an[e] + an[f] + an[h] + an[i] + an[j];
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }

                    }
                }
                else if (np == 10)
                {

                    for (int a = 0; a < an.Length; a++)
                    {
                        for (int b = 0; b < an.Length; b++)
                        {
                            for (int c = 0; c < an.Length; c++)
                            {
                                for (int d = 0; d < an.Length; d++)
                                {
                                    for (int e = 0; e < an.Length; e++)
                                    {
                                        for (int f = 0; f < an.Length; f++)
                                        {
                                            for (int h = 0; h < an.Length; h++)
                                            {

                                                for (int i = 0; i < an.Length; i++)
                                                {
                                                    for (int j = 0; j < an.Length; j++)
                                                    {
                                                        for (int k = 0; k < an.Length; k++)
                                                        {
                                                            if (an[a] + an[b] + an[c] + an[d] + an[e] + an[f] + an[h] + an[i] + an[j] + an[k] == sbs)
                                                            {
                                                                g = an[a] + an[b] + an[c] + an[d] + an[e] + an[f] + an[h] + an[i] + an[j] + an[k];
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }

                    }
                }
                else if (np == 11)
                {

                    for (int a = 0; a < an.Length; a++)
                    {
                        for (int b = 0; b < an.Length; b++)
                        {
                            for (int c = 0; c < an.Length; c++)
                            {
                                for (int d = 0; d < an.Length; d++)
                                {
                                    for (int e = 0; e < an.Length; e++)
                                    {
                                        for (int f = 0; f < an.Length; f++)
                                        {
                                            for (int h = 0; h < an.Length; h++)
                                            {

                                                for (int i = 0; i < an.Length; i++)
                                                {
                                                    for (int j = 0; j < an.Length; j++)
                                                    {
                                                        for (int k = 0; k < an.Length; k++)
                                                        {
                                                            for (int l = 0; l < an.Length; l++)
                                                            {
                                                                if (an[a] + an[b] + an[c] + an[d] + an[e] + an[f] + an[h] + an[i] + an[j] + an[k] + an[l] == sbs)
                                                                {
                                                                    g = an[a] + an[b] + an[c] + an[d] + an[e] + an[f] + an[h] + an[i] + an[j] + an[k] + an[l];
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }

                    }
                }

                else if (np == 12)
                {

                    for (int a = 0; a < an.Length; a++)
                    {
                        for (int b = 0; b < an.Length; b++)
                        {
                            for (int c = 0; c < an.Length; c++)
                            {
                                for (int d = 0; d < an.Length; d++)
                                {
                                    for (int e = 0; e < an.Length; e++)
                                    {
                                        for (int f = 0; f < an.Length; f++)
                                        {
                                            for (int h = 0; h < an.Length; h++)
                                            {

                                                for (int i = 0; i < an.Length; i++)
                                                {
                                                    for (int j = 0; j < an.Length; j++)
                                                    {
                                                        for (int k = 0; k < an.Length; k++)
                                                        {
                                                            for (int l = 0; l < an.Length; l++)
                                                            {
                                                                for (int m = 0; m < an.Length; m++)
                                                                {
                                                                    if (an[a] + an[b] + an[c] + an[d] + an[e] + an[f] + an[h] + an[i] + an[j] + an[k] + an[l] + an[m] == sbs)
                                                                    {
                                                                        g = an[a] + an[b] + an[c] + an[d] + an[e] + an[f] + an[h] + an[i] + an[j] + an[k] + an[l] + an[m];
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }

                    }
                }


                if (g == null)
                {
                    Console.WriteLine("Password is not matched");
                }
                else
                {
                    Console.WriteLine("Password is cracked: " + g);
                }

                #endregion
            }
            else if (ns == 2)
            {
                #region Small Letter
                string gp = null;
                string sb = "sari";
                Console.WriteLine("Enter Length of Password");
                int n = Convert.ToInt32(Console.ReadLine());

                string[] ans = new string[]
                {
                "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p",
                   "q","r","s","t","u","v","w","x","y","z"
                };

                if (n == 3)
                {
                    for (int a = 0; a < ans.Length; a++)
                    {
                        for (int b = 0; b < ans.Length; b++)
                        {
                            for (int c = 0; c < ans.Length; c++)
                            {
                                if (ans[a] + ans[b] + ans[c] == sb)
                                {
                                    gp = ans[a] + ans[b] + ans[c];
                                }
                            }

                        }

                    }
                }
                else if (n == 4)
                {

                    for (int a = 0; a < ans.Length; a++)
                    {
                        for (int b = 0; b < ans.Length; b++)
                        {
                            for (int c = 0; c < ans.Length; c++)
                            {
                                for (int d = 0; d < ans.Length; d++)
                                {
                                    if (ans[a] + ans[b] + ans[c] + ans[d] == sb)
                                    {
                                        gp = ans[a] + ans[b] + ans[c] + ans[d];
                                    }
                                }
                            }

                        }

                    }
                }
                else if (n == 5)
                {

                    for (int a = 0; a < ans.Length; a++)
                    {
                        for (int b = 0; b < ans.Length; b++)
                        {
                            for (int c = 0; c < ans.Length; c++)
                            {
                                for (int d = 0; d < ans.Length; d++)
                                {
                                    for (int e = 0; e < ans.Length; e++)
                                    {
                                        if (ans[a] + ans[b] + ans[c] + ans[d] + ans[e] == sb)
                                        {
                                            gp = ans[a] + ans[b] + ans[c] + ans[d] + ans[e];
                                        }
                                    }
                                }
                            }

                        }

                    }
                }
                else if (n == 6)
                {

                    for (int a = 0; a < ans.Length; a++)
                    {
                        for (int b = 0; b < ans.Length; b++)
                        {
                            for (int c = 0; c < ans.Length; c++)
                            {
                                for (int d = 0; d < ans.Length; d++)
                                {
                                    for (int e = 0; e < ans.Length; e++)
                                    {
                                        for (int f = 0; f < ans.Length; f++)
                                        {

                                            if (ans[a] + ans[b] + ans[c] + ans[d] + ans[e] + ans[f] == sb)
                                            {
                                                gp = ans[a] + ans[b] + ans[c] + ans[d] + ans[e] + ans[f];
                                            }
                                        }
                                    }
                                }
                            }

                        }

                    }
                }
                else if (n == 7)
                {

                    for (int a = 0; a < ans.Length; a++)
                    {
                        for (int b = 0; b < ans.Length; b++)
                        {
                            for (int c = 0; c < ans.Length; c++)
                            {
                                for (int d = 0; d < ans.Length; d++)
                                {
                                    for (int e = 0; e < ans.Length; e++)
                                    {
                                        for (int f = 0; f < ans.Length; f++)
                                        {
                                            for (int h = 0; h < ans.Length; h++)
                                            {

                                                if (ans[a] + ans[b] + ans[c] + ans[d] + ans[e] + ans[f] + ans[h] == sb)
                                                {
                                                    gp = ans[a] + ans[b] + ans[c] + ans[d] + ans[e] + ans[f] + ans[h];
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }

                    }
                }
                else if (n == 8)
                {

                    for (int a = 0; a < ans.Length; a++)
                    {
                        for (int b = 0; b < ans.Length; b++)
                        {
                            for (int c = 0; c < ans.Length; c++)
                            {
                                for (int d = 0; d < ans.Length; d++)
                                {
                                    for (int e = 0; e < ans.Length; e++)
                                    {
                                        for (int f = 0; f < ans.Length; f++)
                                        {
                                            for (int h = 0; h < ans.Length; h++)
                                            {

                                                for (int i = 0; i < ans.Length; i++)
                                                {
                                                    if (ans[a] + ans[b] + ans[c] + ans[d] + ans[e] + ans[f] + ans[h] + ans[i] == sb)
                                                    {
                                                        gp = ans[a] + ans[b] + ans[c] + ans[d] + ans[e] + ans[f] + ans[h] + ans[i];
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }

                    }
                }
                else if (n == 9)
                {

                    for (int a = 0; a < ans.Length; a++)
                    {
                        for (int b = 0; b < ans.Length; b++)
                        {
                            for (int c = 0; c < ans.Length; c++)
                            {
                                for (int d = 0; d < ans.Length; d++)
                                {
                                    for (int e = 0; e < ans.Length; e++)
                                    {
                                        for (int f = 0; f < ans.Length; f++)
                                        {
                                            for (int h = 0; h < ans.Length; h++)
                                            {

                                                for (int i = 0; i < ans.Length; i++)
                                                {
                                                    for (int j = 0; j < ans.Length; j++)
                                                    {
                                                        if (ans[a] + ans[b] + ans[c] + ans[d] + ans[e] + ans[f] + ans[h] + ans[i] + ans[j] == sb)
                                                        {
                                                            gp = ans[a] + ans[b] + ans[c] + ans[d] + ans[e] + ans[f] + ans[h] + ans[i] + ans[j];
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }

                    }
                }
                else if (n == 10)
                {

                    for (int a = 0; a < ans.Length; a++)
                    {
                        for (int b = 0; b < ans.Length; b++)
                        {
                            for (int c = 0; c < ans.Length; c++)
                            {
                                for (int d = 0; d < ans.Length; d++)
                                {
                                    for (int e = 0; e < ans.Length; e++)
                                    {
                                        for (int f = 0; f < ans.Length; f++)
                                        {
                                            for (int h = 0; h < ans.Length; h++)
                                            {

                                                for (int i = 0; i < ans.Length; i++)
                                                {
                                                    for (int j = 0; j < ans.Length; j++)
                                                    {
                                                        for (int k = 0; k < ans.Length; k++)
                                                        {
                                                            if (ans[a] + ans[b] + ans[c] + ans[d] + ans[e] + ans[f] + ans[h] + ans[i] + ans[j] + ans[k] == sb)
                                                            {
                                                                gp = ans[a] + ans[b] + ans[c] + ans[d] + ans[e] + ans[f] + ans[h] + ans[i] + ans[j] + ans[k];
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }

                    }
                }
                else if (n == 11)
                {

                    for (int a = 0; a < ans.Length; a++)
                    {
                        for (int b = 0; b < ans.Length; b++)
                        {
                            for (int c = 0; c < ans.Length; c++)
                            {
                                for (int d = 0; d < ans.Length; d++)
                                {
                                    for (int e = 0; e < ans.Length; e++)
                                    {
                                        for (int f = 0; f < ans.Length; f++)
                                        {
                                            for (int h = 0; h < ans.Length; h++)
                                            {

                                                for (int i = 0; i < ans.Length; i++)
                                                {
                                                    for (int j = 0; j < ans.Length; j++)
                                                    {
                                                        for (int k = 0; k < ans.Length; k++)
                                                        {
                                                            for (int l = 0; l < ans.Length; l++)
                                                            {
                                                                if (ans[a] + ans[b] + ans[c] + ans[d] + ans[e] + ans[f] + ans[h] + ans[i] + ans[j] + ans[k] + ans[l] == sb)
                                                                {
                                                                    gp = ans[a] + ans[b] + ans[c] + ans[d] + ans[e] + ans[f] + ans[h] + ans[i] + ans[j] + ans[k] + ans[l];
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }

                    }
                }

                else if (n == 12)
                {

                    for (int a = 0; a < ans.Length; a++)
                    {
                        for (int b = 0; b < ans.Length; b++)
                        {
                            for (int c = 0; c < ans.Length; c++)
                            {
                                for (int d = 0; d < ans.Length; d++)
                                {
                                    for (int e = 0; e < ans.Length; e++)
                                    {
                                        for (int f = 0; f < ans.Length; f++)
                                        {
                                            for (int h = 0; h < ans.Length; h++)
                                            {

                                                for (int i = 0; i < ans.Length; i++)
                                                {
                                                    for (int j = 0; j < ans.Length; j++)
                                                    {
                                                        for (int k = 0; k < ans.Length; k++)
                                                        {
                                                            for (int l = 0; l < ans.Length; l++)
                                                            {
                                                                for (int m = 0; m < ans.Length; m++)
                                                                {
                                                                    if (ans[a] + ans[b] + ans[c] + ans[d] + ans[e] + ans[f] + ans[h] + ans[i] + ans[j] + ans[k] + ans[l] + ans[m] == sb)
                                                                    {
                                                                        gp = ans[a] + ans[b] + ans[c] + ans[d] + ans[e] + ans[f] + ans[h] + ans[i] + ans[j] + ans[k] + ans[l] + ans[m];
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }

                    }
                }
                if (gp == null)
                {
                    Console.WriteLine("Password is not matched");
                }
                else
                {
                    Console.WriteLine("Password is cracked: " + gp);
                }


                #endregion
                
            }



           
            Console.ReadKey();

        }
    }
}
