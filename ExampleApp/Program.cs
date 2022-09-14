using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            string fname = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Your name is " + fname);
            Console.ReadLine();
        }
    }
}
