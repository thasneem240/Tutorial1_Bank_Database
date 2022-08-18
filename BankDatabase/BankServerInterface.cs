using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BankDatabase
{
    [ServiceContract]
    public interface BankServerInterface
    {
        [OperationContract]
        int GetNumEntries();

        [OperationContract]
        [FaultContract(typeof(Exception))]
        void GetValuesForEntry(int index, out uint accNo, out uint pin, out int bal,
            out string fName, out string lName, out string bitmapLocation);
    }
}
