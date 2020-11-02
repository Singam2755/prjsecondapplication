using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_basics
{
    class Boxingandunboxing
    {
        static void Main()
        {
            int petrol = 100;
            object o = petrol;
            Console.WriteLine("value:{0}", o);
            Console.WriteLine("................................");
            string oil = "10";
            int oilprice = Convert.ToInt32(oil);
            Console.WriteLine("value is { 0}",oilprice);
            Console.Read();

        }
    }
}
