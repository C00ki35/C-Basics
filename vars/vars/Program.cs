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
            var number = 1;
            var count = 33;
            var total = 3.3;
            var firstName = "Peter";
            var letter = 'B';
            var isWorking = false;

            Console.WriteLine(count);
            Console.WriteLine(number);
            Console.WriteLine(firstName);
            Console.WriteLine(letter);
            Console.WriteLine(isWorking);
            Console.WriteLine(total);


            //Conversion types

            string numToString = "1234";
            int i = Convert.ToInt32(numToString);

            //Handling exceptions

            try
            {
                var n = "1223";
                byte b = Convert.ToByte(n);
                Console.WriteLine(b);
            }
            catch (Exception)
            {

                Console.WriteLine("The number could not be converted to a byte");
            }
        }
    }
}
