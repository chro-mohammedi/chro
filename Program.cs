using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter your age please:");        
            var ad= 2021;
            var  year= Convert.ToInt32(Console.ReadLine());
            var age =ad - year;
            Console.WriteLine(" you are born on " + age);
            Console.ReadKey();
        }
    }
}
