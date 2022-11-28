using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _28_11tasks
{
    class car
    {
    protected string carsMake;
        public string CarsMake
        {
            get; set;
        }
        protected int year;
        public int Year
        {
            get; set;
        }
        protected string Type;
        public string TYpe
        {
            get; set;
        }
        protected double Price;
        public double PRice
        {
            get; set;
        }
        protected string model;
        public string Model
        {
            get; set;
        }
        protected int modelNo;
        public int ModelNo
        {
            get; set;
        }
        protected string color;
        public string Color
        {
            get; set;
        }

        public car()
        {
        }
        public car(string c ,int y,string t,double p,string m,int no,string co)
        {
            carsMake = c;
            year = y;
            Type = t;
            Price= p;
            model = co;
            modelNo = no;
            color = co;


        }
        public void start()
        {
            Console.WriteLine("goooooo");
        }
        public void stop() 
        {
            Console.WriteLine("good bye");
        }
        
 public void kelo(int x,int y) 
        {
            Console.WriteLine(x * y);
        }
        

    }
    class ba : car
    {
        public ba(string carsMake, int year, string Type, double Price, string model, int modelNo, string color):base( carsMake,  year,  Type,  Price,  model,  modelNo, color) { }
        public void print()
        {
            Console.WriteLine(carsMake + " " + year + " " + Type + " " + Price + " " + model + " " + modelNo + " " + color);
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            ba ayah = new ba("aya",2000,"izzat",2000,"alzyout",2000," red");
            ayah.start();
            ayah.print();
            ayah.stop();
            ayah.kelo(2,3);

        }
    }
}
