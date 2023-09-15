

using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.PortableExecutable;

namespace firstLessonCsharp
{
    internal class Program
    {
        

        
        public void Zaza(int num)
        {
            

            for (int i = 1; i < num; ++i)
            {
                if (i % 3 == 0 && i % 5 == 0)

                    Console.Write("FizBaz ");

                else if (i % 3 == 0)

                    Console.Write("Fiz ");

                else if (i % 5 == 0)

                    Console.Write("Baz ");

                else
                    Console.Write(i + " ");
            }
        }

        static void Main(string[] args)
        {
           // Console.BackgroundColor= ConsoleColor.DarkRed;
            Program p = new Program();


            //Console.WriteLine("Hello, World!");

            //int first, second, ans, first1;
            //first = 0;
            //Console.Write("Enter first number -> ");
            //// first = Convert.ToInt32(Console.ReadLine());

            //try
            //{
            //    first = int.Parse(Console.ReadLine());
            //}

            //catch(Exception) {

            //    Console.WriteLine("Error!!!");

            //}
            //Console.Write("Enter second number -> ");
            //second = Convert.ToInt32(Console.ReadLine());
            //ans = first + second;
            //Console.WriteLine("Equal is " + ans);
            //Console.WriteLine(sizeof(double));

            //int length;
            //Console.Write("Enter length of arr -> ");
            //length = int.Parse(Console.ReadLine());
            //foreach(var i in args)
            //Program.Zaza(length);
            // p.Zaza(length);
            //string str1 = "";
            //string str2 = "";
            //float num1;
            //int num2;
            //Console.Write("Enter first number -> ");
            //str1 = Console.ReadLine();
            //str2 = Console.ReadLine();
            ////num2 = int.Parse(str2);

            //while (!(float.TryParse(str1, out num1)) || !(int.TryParse(str2, out num2)))
            //{

            //    Console.Write("Enter first number -> ");
            //    str1 = Console.ReadLine();
            //     num1 = float.Parse(str1);

            //    Console.Write("Enter second number -> ");
            //    str2 = Console.ReadLine();
            //     num2 = int.Parse(str2);

            //}
            //float res = num1 / 100 * num2;

            //if ((num2 > 100 || num2 <= 0) && num2 > num1)

            //    Console.Write("Error!!!");  

            //else

            //    Console.WriteLine("result is " + res);
            Console.Write("Enter 1-st number -> ");
            string str = Console.ReadLine();
            Console.Write("Enter 2-nd number -> ");
            str += Console.ReadLine();
            Console.Write("Enter 3-d number -> ");
            str += Console.ReadLine();
            Console.Write("Enter 4-th number -> ");
            str += Console.ReadLine();
            Console.WriteLine("result is " + str);

            Console.WriteLine(int.Parse(str));


            Console.Write("Enter 1-st number -> ");
            int str1 = int.Parse(Console.ReadLine());
            Console.Write("Enter 2-st number -> ");
            int str2 = int.Parse(Console.ReadLine());
            Console.Write("Enter 3-st number -> ");
            int str3 = int.Parse(Console.ReadLine());
            Console.Write("Enter 4-st number -> ");
            int str4 = int.Parse(Console.ReadLine());

            int result = str1 * 1000 + str2 * 100 + str3 * 10 + str4;
            Console.WriteLine("res = " + result);
        }
    }
}