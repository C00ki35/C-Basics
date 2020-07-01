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
            //BASIC ARRAYS
            var numbers = new int[3];
            numbers[0] = 1;

            var flags = new bool[3];
            flags[0] = true;

            var names = new string[3] { "Jack", "Jill", "Tim" };


            //STRINGS
            string myname = string.Format("{0} {1}", "Dave", "Simpson");

            string firstName = "Ken";
            Console.WriteLine(firstName[0]);

            var sentence = "My name is \"Ken\"";
            Console.WriteLine(sentence);

            //Verbatim string - doesn't work with double quotes.
            Console.WriteLine(@"This \ is / // String");
            var didMatch = string.Compare("Ken", "Ken");
            Console.WriteLine(didMatch);
        }
    }
}
