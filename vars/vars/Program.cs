using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace vars
{

    public enum ShippingMethod
    {
        RegularAirmail = 1,
        RegisteredAirmail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Enums


            //Casting to value
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            //Casting to string value
            var Smethod = 2;
            Console.WriteLine((ShippingMethod)Smethod);

            var methodName = "Express";
            var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);
            }
    }


}
