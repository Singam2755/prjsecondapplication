using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Eg1
    {
        void Welcome()
        {
            Console.WriteLine("welcome all");

        }
        string GetName()
        {
            return "singam";

        }
        int GetAge()
        {
            return 22;
        }
        char GetInitial()
        {
            return 'k';
        }

        static void Main()
        {
            Eg1 eg1 = new Eg1();
            eg1.Welcome();
            string name = eg1.GetName();
            Console.WriteLine("name:{0}", name);
            Console.WriteLine("age:{0}", eg1.GetAge());
            Console.WriteLine("initial:{0}", eg1.GetInitial());
            Console.Read();
        }
    }
}
