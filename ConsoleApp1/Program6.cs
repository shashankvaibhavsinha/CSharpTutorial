using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IClassE
    {
        public void printE()
        {
            Console.WriteLine("printE method invoked");
        }
    }
    interface IClassF
    {
        public void printF()
        {
            Console.WriteLine("printF method invoked");
        }
    }
    class ClassEF : IClassE, IClassF
    {
        public void printEF()
        {
            Console.WriteLine("printEF method invoked");
        }
    }
}
