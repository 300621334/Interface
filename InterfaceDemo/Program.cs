using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Quk x = new Quk();
            Console.WriteLine(x.Age);
            x.Drink(16);
            x.Eat();
        }
    }
}
