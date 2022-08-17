using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Tutorial1_Simple_WPF_APP;

namespace RemoteServer
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, UseSynchronizationContext = false)]
    internal class BankServerImplementation : BankServerInterface
    {
        /* Reference to the database Class*/

        DatabaseClass database;

        public BankServerImplementation()
        {
            database = new DatabaseClass();
        }

        public int GetNumEntries() 
        {
            return database.GetNumRecords();
        }

        public void GetValuesForEntry(int index, out uint accNo, out uint pin, out int bal,
            out string fName, out string lName)
        {
            accNo = database.GetAcctNoByIndex(index);
            pin = database.GetPINByIndex(index);
            bal = database.GetBalanceByIndex(index);
            fName = database.GetFirstNameByIndex(index);
            lName = database.GetLaseNameByIndex(index);
        }
    }
}
