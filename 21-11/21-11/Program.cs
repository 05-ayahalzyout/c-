using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace _21_11
{
    internal class Program
    {
        static void Main(string[] args)
        {////task1
            Console.WriteLine("Please write a number ");
            int pp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please write a number ");
            int bb = Convert.ToInt32(Console.ReadLine());
            if (pp>bb)
            {
                Console.WriteLine(pp);
            }
            else { Console.WriteLine(bb); }

            //////task2
            //int ayah = Convert.ToInt32(Console.ReadLine());

            //if (ayah < 0)
            //{
            //    Console.WriteLine("-");




            //}

            //else Console.WriteLine("+");


            ///task3

            //int fn = Convert.ToInt32(Console.ReadLine());
            //int sn = Convert.ToInt32(Console.ReadLine());
            //int thn = Convert.ToInt32(Console.ReadLine());

            //int[] btool = { fn, sn, thn };
            //Array.Sort(btool);
            //Console.WriteLine(btool[2] + " , " + btool[1] + "," + btool[0]);


            /////task4
            //int f = Convert.ToInt32(Console.ReadLine());
            //int s = Convert.ToInt32(Console.ReadLine());
            //int t = Convert.ToInt32(Console.ReadLine());
            //int fi = Convert.ToInt32(Console.ReadLine());
            //int si = Convert.ToInt32(Console.ReadLine());
            //int[] l = { f, s, t,fi,si };
            //Array.Sort(l);
            //Console.WriteLine(l[4]);


            ///task5
            //Console.WriteLine("Write the distance from your house to the company");
            //double ayah = Convert.ToInt32(Console.ReadLine());
            //double alaa = ayah * 0.621371;
            //Console.WriteLine(alaa);


            ///task6
            //Console.WriteLine("Please write the time ");
            //int h = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please type the minutes");
            //int g = Convert.ToInt32(Console.ReadLine());
            //int c = h * 60;
            //int end = c + g;
            //Console.WriteLine(end);

            ///task7
            //Console.WriteLine("Please type the minutes");
            //int go = Convert.ToInt32(Console.ReadLine());
            //float ca = go / 60;
            //int a = go % 60;
            //Console.WriteLine(ca + "hours" + a + "minute");

            ///task8
            //string[] array = { "ayah", "alaa", "saja", "narjas", "amer" };
            //Console.WriteLine(array[0] + "length :" + array[0].Length);
            //Console.WriteLine(array[1] + "length :" + array[1].Length);
            //Console.WriteLine(array[2] + "length :" + array[2].Length);
            //Console.WriteLine(array[3] + "length :" + array[3].Length);
            //Console.WriteLine(array[4] + "length :" + array[4].Length);
            //Console.WriteLine("---------------------");
            //Console.WriteLine(array[0].Substring(0, 6));
            //Console.WriteLine(array[1].Substring(0, 6));
            //Console.WriteLine(array[2].Substring(0, 6));
            //Console.WriteLine(array[3].Substring(0, 6));
            //Console.WriteLine(array[4].Substring(0, 6));

        }
    }
}
