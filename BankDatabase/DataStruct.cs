﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Database
{
    internal class DataStruct
    {
        public uint accNo;
        public uint pin;
        public int balance;
        public string firstName;
        public string lastName;
        public string imageLocation;

        public DataStruct()
        {
            accNo = 0;
            pin = 0;
            balance = 0;
            firstName = "";
            lastName = "";
            imageLocation = "";
        }

        public override string ToString()
        {
            string str = "\n *******************************************************";
            str = str + "\n Account Number: " + accNo;
            str = str + "\n PIN Number: " + pin;
            str = str + "\n Balance: " + balance;
            str = str + "\n First Name: " + firstName;
            str = str + "\n Last Name: " + lastName;
            str = str + "\n *******************************************************\n";

            return str;
        }
    }
}
