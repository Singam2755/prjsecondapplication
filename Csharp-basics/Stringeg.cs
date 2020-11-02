using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_basics
{
    class Stringeg
    {
        static void Main()
        {
            string firstname = "singam ganesh";
            Console.WriteLine("Length of the string :{0}",firstname.Length);
            Console.WriteLine("converting to uppercase : {0}",firstname.ToUpper());
            Console.WriteLine("contains :{0}",firstname.Contains("gan"));
            Console.WriteLine("index g :{0}",firstname.IndexOf("g"));
            Console.Read();

        }
    }
}
