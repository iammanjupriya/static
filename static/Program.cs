using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @static
{
    internal class Program
    {
        class firstProgram
        {
            static int a;
            int b;
            static void Square()

            {
                Console.WriteLine("enter no");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("print " + a);
            }
            public void Square1()

            {
                Console.WriteLine("enter no");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("print " + b);
            }
            static void Main(string[] args)
            {
               firstProgram p = new firstProgram();
                //int num1 = 5;
                //int num2 = 10;
                //  Console.WriteLine(num1 + " " + num2);
                Square();
                p.Square1();
                // Console.WriteLine(num1 + " " + num2);
                Console.WriteLine("Press Enter Key to Exit..");
                Console.ReadLine();
            }
        }
    }
}

    

