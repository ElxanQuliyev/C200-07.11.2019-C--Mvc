using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sum;
            //string a, b;

            //Console.Write("a=");
            //a=Console.ReadLine();
            //Convert.ToInt32(a)
            //Console.Write("b=");
            //Console.ReadLine();
            //sum=
            //Convert.ToInt32




            //int w = 0;
            //while (w == 0)
            //{
            //    Console.Write("Birinci reqemi daxil edin: ");
            //    string a = Console.ReadLine();

            //    Console.Write("Ikinci reqemi daxil edin: ");

            //    string b = Console.ReadLine();
            //    try
            //    {

            //        w = Convert.ToInt32(a) + Convert.ToInt32(b);
            //        Console.WriteLine("Cavab :{0}", w);
            //    }
            //    catch (Exception)
            //    {

            //        Console.WriteLine("Zehmet olmasa reqem daxil edin.");
            //    }
            //}


            //string az = "Eliasasdasaas";
            //Console.WriteLine(az.Length);
            //object a = "Sasa";
            //string b = a.ToString();
            //Console.WriteLine(b);

            //int[] num = { 1, 2, 5, 45, 53 };
            //Console.WriteLine(num[3]);
            Random rnd = new Random();
            int a=0;
            List<int> myList=new List<int>();
            List<int> myList2 = new List<int>();

            while (a >= 0)
            {
                    a = rnd.Next(0, 10);
                     myList.Add(a);
                foreach (var num in myList)
                {
                   
                  
                        if (!myList2.Contains(num))
                        {
                            myList2.Add(num);
                            Console.WriteLine(num);
                         }
                    }
            }
          
            }
        }

    }
