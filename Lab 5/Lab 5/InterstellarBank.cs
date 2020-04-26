using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab_5
{
    class InterstellarBank : IEnumerable
    {
        private static ArrayList accountList = new ArrayList();

        public InterstellarBank()
        {
            accountList = new ArrayList();
        }
        public void AddChecking(string name, decimal amt, decimal fee)
        {
            accountList.Add(new CheckingAccount(name, amt, fee));
        }
        public void AddSavings(string name, decimal amt, decimal interest)
        {
            accountList.Add(new SavingsAccount(name, amt, interest));
        }
        public IEnumerator GetEnumerator()
        {
            foreach(Object obj in accountList)
            {
                yield return obj.ToString();
            }
        }

    }
}
