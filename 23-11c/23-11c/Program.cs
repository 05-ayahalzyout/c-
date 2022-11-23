using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_11c
{
     class Program
    {
       
        static int task1(int a,int b,int c,int d,int e,int f,int g,int h,int i,int j ) {
            return((a+b+c+d+e+f+g+h+i+j)/10);
        }
        static int task2(int k/*, int l, int m, int n, int o*/)
        {
            Console.WriteLine("Enter  number");


            return (k * k * k/*,l*l*l,m*m*m,n*n*n,o*o*o*/);
        }
        static void Main(string[] args)
        {
         int ava=  task1(10,20,10,30,50,40,60,20,10,50 );
            /////////////////////////////////////////////////////
            //Console.WriteLine (ava);
            //int ata = task2(1); 
              





        }
        static void task3()
        {
            int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            foreach (int year in years)
            {
                if (year > 1950)
                {
                    Console.WriteLine(year);
                }
            }

        }
        static int task4(int ageInYears)
        {
            int ageInDays = ageInYears * 12 * 30;
            return ageInDays;
        }
    }
}
