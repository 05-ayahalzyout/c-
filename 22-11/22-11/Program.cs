using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _22_11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ///task1
            int[] ARR = { 1, 7, 9, 4, 5 };
            string[] arr2 = { "Str", "alex", "moh" };
            string[] arr3 = { "the", "fox", "over", " lazy", "dog" };


            ///task2
            String[] fruits = { "Tomato", "Banana", "Watermelon" };
            for (int i = 0; i < fruits.Length; i++)
            {
                if (fruits[i] == "Tomato") { Console.WriteLine(i); }
                if (fruits[i] == "Banana") { Console.WriteLine(i); }
                    
                     }



                ///task3
                string[] Food = { "Mansaf", "brgar", "kabsa", "shawarma", "dwale" };
                string[] Sport = { "golf", "fotbool", "tanas" };
                string[] Movie = { "mbc1", "mbc2", "mbc3", "mbc4" };
                foreach (string p in Food)
                {
                    Console.WriteLine(p);
                }
                foreach (string o in Sport)
                {
                    Console.WriteLine(o);
                }
                foreach (string u in Movie)
                {
                    Console.WriteLine(u);
                       }
            ///task4
            Console.WriteLine("Enter 3 numbers With addition(,)");
            string su = Console.ReadLine();
            string[] sume = su.Split(',' );
            int ss = 0;
            foreach(string u in sume) { ss = ss + Convert.ToInt32(u); }
            Console.WriteLine(ss);
            ///task5
            int sum = 0;
            for (int n = 1; n < 100; n += 2)
            {
                sum = sum + n;
            }
            Console.WriteLine(sum);

            ///task6
            for (int d = 0; d < 5; d++)
                
            {
                for (int b = 0; b <= d; b++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
            ///task7 
            int haya = 1;
            for (int v = 0; v < 4; v++)

            {
                for (int s = 0; s <=v; s++)
                {
                    Console.Write(haya);
                    haya++;

                }
                Console.WriteLine();
            }
        }
    }
}
