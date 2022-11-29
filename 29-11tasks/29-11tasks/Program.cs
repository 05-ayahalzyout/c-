using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _29_11tasks
{
   abstract class Apply
    {
        public abstract void muny();

     public   string EmployeesName = "ayah";
        public string birth = "February";
        public int Id = 15;

        
        public Apply(string a,string b,int i) 
        {
        
        }

        public Apply()
        {

        }
        public void calc(int a,int b,int c)
        {
            var birthday = new DateTime(a, b, c);
            int age = (int)((DateTime.Now - birthday).TotalDays / 365.242199);
            Console.WriteLine(age);
        }
        public void calc( )
        {
            var birthday = new DateTime(1999, 2, 11);
            int age = (int)((DateTime.Now - birthday).TotalDays / 365.242199);
            Console.WriteLine(age);
        }
    }
    class Manager :Apply
    {
        public override void muny()
        {
            Console.WriteLine("Welcome to you");
                

        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
        Manager manager = new Manager();
            manager.muny();
            manager.calc(1999,2,11);
            manager.calc();
            Console.WriteLine("EmployeesName " + manager.EmployeesName + " " + "birth "+ manager.birth + " " + "Id " + manager.Id);
        }
    }
}
