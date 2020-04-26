using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab_5
{
    class InterstellarBank
    {
        private ArrayList accountList;

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
            foreach(object obj in accountList)
            {
                yield return obj;
            }
        }
    }
}
