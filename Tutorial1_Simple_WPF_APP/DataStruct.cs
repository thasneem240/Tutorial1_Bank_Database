﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1_Simple_WPF_APP
{
    internal class DataStruct
    {
        public uint accNo;
        public uint pin;
        public int balance;
        public string firstName;
        public string lastName;

        public DataStruct()
        {
            accNo = 0;
            pin = 0; 
            balance = 0;
            firstName = "";
            lastName = "";
        }

    }
}
