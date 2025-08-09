using Program1;
using Program2;
using Inheritance;
using Abstraction;
using Interface;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ShashankProgram obj = new ShashankProgram();
            obj.name();
            HeeraProgram.name();
            Console.WriteLine("-------Program 1 done-------------");

            Program2 obj2 = new("Heera");
            obj2.Printout("Shashank");
            obj2.Printout("Heera", 16);
            Console.WriteLine("-------Program 2 done-------------");

            Program3 obj3 = new Program3();
            obj3.BankBalance = 300000;
            obj3.showBankBalance();
            Console.WriteLine(obj3.BankBalance);
            Console.WriteLine("-------Program 3 done-------------");
            
            ClassB obj4 = new ClassB();
            obj4.PropertyA = "Shashank";
            obj4.printA();
            obj4.printA(obj4.PropertyA);
            Console.WriteLine("-------Program 4 done-------------");

            ClassD obj5 = new ClassD();
            obj5.printD();
            ClassDA.printDA();
            Console.WriteLine("-------Program 5 done-------------");

            ClassEF obj6 = new ClassEF();
            obj6.printE();


        }
    }
    
}