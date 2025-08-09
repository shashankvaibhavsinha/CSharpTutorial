using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class ClassDA
    {
        static ClassDA()
        {
            Console.WriteLine("ClassDA constructor called");
        }
        public static void printDA()
        {
            Console.WriteLine("printDA invoked inside the Abstract ClassD");
        }
        public void printD()
        {
            Console.WriteLine("printD invoked inside the Abstract ClassD");
        }
    }

    class ClassD : ClassDA
    {
        static ClassD()
        {
            Console.WriteLine("ClassD constructor called");
        }
    }


}
