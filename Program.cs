using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Exception_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter a number");
                int num1= int.Parse(Console.ReadLine());

                Console.WriteLine("Enter another number");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine(num1/num2);
            }
            catch (Exception e){ 
            Console.WriteLine(e.Message);
            }
            Console.Read();
        }
    }
}
