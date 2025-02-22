using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing_C_
{
    class Program
    {
        static void Main()
        {
//llkk
            
            //Console.WriteLine(" Please enter the value of x ",X);
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            //string interpolation
            Console.WriteLine($"Your name is {name}");
            Console.WriteLine("Enter your age ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age is " + age);
            int[] number = { 20, 30, 40 };
            Console.WriteLine(number[1]);
            

            

            

        }

    }
}
