using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp
{
    public class Phone
    {
        /// <summary>
        /// There is one Phone object per phone number in the
        /// database.
        /// </summary>
        private string m_Name;
        private string m_PhoneNumber;
        public const string FormatError = "**";

        public Phone(string name, string phone)
        {
            // Use the properties so that data validation is done.
            Name = name;
            PhoneNumber = phone;
        }

        public string Name
        {
            get { return m_Name; }
            set
            {
                // A valid name must contain a comma.
                if (value.IndexOf(",") < 0)
                    throw new ApplicationException("Invalid name format: " + value);
                m_Name = value;
            }
        }

        public string PhoneNumber
        {
            get { return m_PhoneNumber; }
            set
            {
                if (value.Length != 10)
                    throw new ApplicationException("Phone number must be ten digits: " + value);
                for (int i = 0; i < 10; ++i)
                    if (!char.IsDigit(value[i]))
                        throw new ApplicationException("Phone number must be ten digits: " + value);
                m_PhoneNumber = value;
            }
        }

        public override string ToString()
        {
            return m_Name;
        }

        public override bool Equals(object obj)
        {
            Phone other;
            // Make sure we're comparing two Phone objects.
            if (obj == null || !(obj is Phone))
                return false;
            // Two Phone objects are equal if the phone numbers are
            // the same.
            other = (Phone)obj;
            return m_PhoneNumber == other.PhoneNumber;
        }

        public override int GetHashCode()
        {
            // Just hash the phone number.
            return m_PhoneNumber.GetHashCode();
        }

        public static string ValidateName(string name)
        {

        }

        public static string ValidatePhoneNumber(string number)
        {

        }
    }
}
