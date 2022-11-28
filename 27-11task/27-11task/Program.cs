using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _27_11task
{
    class task
    {
        private int Age;
        private string Gender;
        private string Name;
        private string E_Mail;
        private string ID;
        private string Phone;

    public task (int a,string g,string n,string e,string i,string p)
        {
            if (a >= 18 && a <= 60) { Age = a; }
           
            Gender = g ;
            Name = n ;
            E_Mail=e ;
            ID= i ;
            string Phone1 = p.Substring(0, 3);
            if (Phone1 == "077" || Phone1 == "078" || Phone1 == "079")
            {
                Phone= p;
            }

        }

   public void Print()
        {

Console.WriteLine(Age+" "+Gender+" "+Name+" "+E_Mail+" "+ID+" "+Phone);





        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            task at = new task(1, "female", "ayah", "ayah.hgvhj", "52", "0772166474");
            

            at.Print();
        }
    }
}
