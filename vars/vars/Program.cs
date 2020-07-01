using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vars.Math;

namespace vars
{
    class Program
    {
        static void Main(string[] args)
        {
            var Ken = new Person();
            Ken.FirstName = "Ken";
            Ken.LastName = "Simms";
            Ken.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 8);
            Console.WriteLine(result);
           

        }
    }
}
