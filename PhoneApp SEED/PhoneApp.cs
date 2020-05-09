using System;
using System.Collections;
using System.Windows.Forms;

namespace PhoneApp
{
    /// <summary>
    /// This is the business tier.  The functions are called by the
    /// presentation tier.  This is the tier that calls the DataAccess
    /// tier as needed.  Because the methods and data aren't static,
    /// the presentation tier needs an object of type PhoneApp.
    /// </summary>
    public class PhoneApp
    {
        // The ArrayList is used to maintain the list of phones for
        // the presentation tier.
        private static ArrayList phoneList;

        // The dataModified value is used to determine if the file
        // needs to be written at the end of the application.
        private static bool dataModified;

        // This program assumes that the output filename is the same
        // as the input filename.
        private static string fileName;

        static PhoneApp()
        {
            dataModified = false;
            phoneList = new ArrayList();
        }

        public ArrayList ReadPhones(string inputFileName)
        {
            Phone ph;
            fileName = inputFileName;
            try
            {
                DataAccess.InitializeRead(fileName);
            }
            catch (System.IO.FileNotFoundException)
            {
                // If the file wasn't found, just return the
                // empty phone list.  This isn't really an error.
                return phoneList;
            }
            ph = DataAccess.ReadPhone();
            while (ph != null)
            {
                // Keep reading until no more data.
                phoneList.Add(ph);
                ph = DataAccess.ReadPhone();
            }
            DataAccess.FinishRead();
            return phoneList;
        }

        public void WritePhones()
        {
            // No need to output anything if the file wasn't modified
            if (dataModified)
            {
                DataAccess.InitializeWrite(fileName);
                foreach (Phone ph in phoneList)
                {
                    DataAccess.WritePhone(ph);
                }
                DataAccess.FinishWrite();
            }
        }

        public void NewPhone(Phone ph)
        {
            // Just take the new Phone object and add it to the
            // phone list.  Set the dataModified flag.
            phoneList.Add(ph);
            dataModified = true;
        }
    }
}

