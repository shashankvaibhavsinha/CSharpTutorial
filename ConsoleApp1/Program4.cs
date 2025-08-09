using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class ClassA
    {
        static ClassA()
        {
            Console.WriteLine("ClassA static Constructor Called");
        }
        public ClassA() {
            Console.WriteLine("ClassA Constructor Called");
        }
        private string variableA;

        public string PropertyA
        {
            get { return variableA; }   // get method
            set { variableA = value; }  // set method
        }
        public void printA()
        {
            Console.WriteLine("printA invoked");
        }
        public void printA(string name)
        {
            Console.WriteLine("printA invoked: "+name);
        }
    }

    class ClassB : ClassA
    {
        static ClassB()
        {
            Console.WriteLine("ClassB static Constructor Called");
        }
        public ClassB()
        {
            Console.WriteLine("ClassB Constructor Called");
        }
        private string variableB;

        public string PropertyB
        {
            get { return variableB; }   // get method
            set { variableB = value; }  // set method
        }
        public void printA()
        {
            Console.WriteLine("printB invoked instead of printA");
        }
        public void printB()
        {
            Console.WriteLine("printB invoked");
        }

        public void printB(string name)
        {
            Console.WriteLine("printB invoked: " + name);
        }
    }

    class ClassC : ClassB
    {
        static ClassC()
        {
            Console.WriteLine("ClassC static Constructor Called");
        }
        public ClassC()
        {
            Console.WriteLine("ClassC Constructor Called");
        }
        private string variableC;

        public string PropertyC
        {
            get { return variableC; }   // get method
            set { variableC = value; }  // set method
        }
        public void printC()
        {
            Console.WriteLine("printC invoked");
        }

        public void printC(string name)
        {
            Console.WriteLine("printC invoked: " + name);
        }
    }
}
