using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            MyClass myClass = new MyClass();
            //myClass.Value1 = 5.8;
            //myClass.Value2 = 4.2;

            MyClass myClass1 = new MyClass(6.8, 3.2);
            //myClass.Value1 = 6.8;
            //myClass.Value2 = 3.2;
            
            Console.WriteLine($"{MyClass.count}");




            Console.ReadKey();




        }
    }
}
