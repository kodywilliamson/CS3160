using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    interface IAccount
    {
        void Credit();
        void Debit();
        Double Balance { get; }
    }
}
