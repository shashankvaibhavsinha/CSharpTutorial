using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program2
    {
        static Program2()
        {
            Console.WriteLine("Static Program2");
        }
        public Program2(string name)
        {
            Console.WriteLine("Constructor Program2:"+name);
        }
        public void Printout(string name)
        {
            Console.WriteLine("Printout: name:" + name);
        }
        public void Printout(string name, int age)
        {
            Console.WriteLine("Printout: name:" + name + " Age: "+age);
        }
    }
}
