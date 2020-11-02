using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_basics
{
    class _2darrayeg
    {
        static void Main()
        {

            Console.WriteLine("enter the row size");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the column size");
            int column = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[row, column];
             
               for (int i = 0; i < row; i++)
               {
                for (int j = 0; j < column; j++)
                {
                    Console.WriteLine("Enter[{0}{1}]",i, j);
                }
            }
            Console.Read();
        }

    }
}
