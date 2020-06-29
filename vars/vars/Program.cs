using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vars
{
    class Program
    {
        static void Main(string[] args)
        {
            //operators

            var a = 10;
            var b = 20;
            var c = 4;

            Console.WriteLine((float)a/(float)b);
            Console.WriteLine((a * b) + c);
            Console.WriteLine(a > b);
            Console.WriteLine(a != c);
            Console.WriteLine(c < b && c < a);


        }
    }
}
