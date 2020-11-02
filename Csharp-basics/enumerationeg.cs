using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_basics
{           enum Feedback
        {
            poor = 1, fair, good, excellent
        }
        class EnumerationEg
        {
            enum Months
            {
                Jan, Feb, mar, April, May, June, July
            }
            static void Main()
            {
                string Ename = "singam";
                Console.WriteLine("name:{0}||feedback:{1}", Ename, (int)Feedback.good);
                Console.WriteLine("name:{0}||feedback:{1}", Ename, Feedback.good);
                Console.WriteLine("name:{0}||feedback:{1}", Ename, Convert.ToInt32(Feedback.good));
                Console.Read();
            }

        }
    }
