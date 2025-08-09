using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    class Program3
    {
        private int bankBalance;

        public int BankBalance   // property
        {
            get { return bankBalance+30; }   // get method
            set { bankBalance = value; }  // set method
        }

        public void showBankBalance()
        {
            Console.WriteLine("Bank Balance:"+ bankBalance);
        }
    }
}
