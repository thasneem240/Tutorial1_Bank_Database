using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Database
{
    internal class BankDetails
    {
        private string GetFirstname() 
        {
            string name = "Mohamed";
            return name;
        }

        private string GetLastname()
        {
            string name = "Thasneem";
            return name;
        }

        private uint GetPIN()
        {
            uint pinNo = 1234;
            return pinNo;
        }


        private uint GetAcctNo() 
        {
            uint accNo = 3456756768;
            return accNo;
        }


        private int GetBalance() 
        {
            int accBal = 5667889;
            return accBal;
        }


        /* get Next Account Info */
        public void GetNextAccount(out uint pin, out uint accNo,out string firstName,
            out string lastName,out int balance) 
        {
            pin = GetPIN();
            accNo = GetAcctNo();
            firstName = GetFirstname();
            lastName = GetLastname();
            balance = GetBalance();
        }


    }
}
