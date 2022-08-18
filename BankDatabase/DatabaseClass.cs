using Bank_Database;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDatabase
{
    public class DatabaseClass
    {
        List<DataStruct> dataStructList;
        DatabaseGenerator databaseGenerator;

        public DatabaseClass()
        {
            dataStructList = new List<DataStruct>(); // list of data struct object
            databaseGenerator = new DatabaseGenerator(); // database geneartor

            for (int i = 0; i < 100; i++)
            {
                /* Create a DataStruct Object */

                DataStruct dataStruct = new DataStruct();

                /* Generate the Data */

                databaseGenerator.GetNextAccount(out dataStruct.pin, out dataStruct.accNo,
                    out dataStruct.firstName, out dataStruct.lastName, out dataStruct.balance,
                    out dataStruct.bitmap);

                /* Load the data into a List */

                dataStructList.Add(dataStruct);
            }

        }


        public uint GetAcctNoByIndex(int index)
        {
            DataStruct dataStruct = dataStructList[index-1];
            uint accNo = dataStruct.accNo;

            return accNo;
        }

        public uint GetPINByIndex(int index)
        {
            return dataStructList[index-1].pin;
        }

        public string GetFirstNameByIndex(int index)
        {
            return dataStructList[index - 1].firstName;
        }

        public string GetLaseNameByIndex(int index)
        {
            return dataStructList[index - 1].lastName;
        }

        public int GetBalanceByIndex(int index)
        {
            return dataStructList[index - 1].balance;
        }

        public Bitmap GetProfilePictureByIndex(int index) 
        {
            return dataStructList[index - 1].bitmap;
        }
        public int GetNumRecords()
        {
            return dataStructList.Count;
        }

    }
}
