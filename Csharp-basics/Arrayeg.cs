using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_basics
{
    class Arrayeg
    {
        static void Main()
        {
            string[] flower = new string[4];
            flower[0] = "lilly";
            flower[1] = "rose";
            flower[2] = "lotus";
            flower[3] = "jasmine";
            Console.WriteLine(flower[0]);
            for(int i=0; i<flower.Length; i++)
            {
                Console.WriteLine("index {0}:{1}", i,flower[i]);
            }
            
            Console.WriteLine("enter size of index:");
          

            


        }
    }
}
