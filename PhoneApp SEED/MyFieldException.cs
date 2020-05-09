using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class MyFieldException : ApplicationException
    {
        private string fieldName;
        private string wrongValue;

        public MyFieldException(string msg, string field, string val) : base(msg)
        {
            fieldName = field;
            wrongValue = val;
        }
        public string GetField()
        {
            return fieldName;
        }
        public string GetVal()
        {
            return wrongValue;
        }
    }
}
