using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Database
{
    internal class DatabaseGenerator
    {

        /* Random Object to Create random Numbers and Strings */

        private Random rand = new Random();

        private string[] arrOfFirstName = { "Mohamed","Wade", "Dave", "Seth", "Ivan", "Riley", "Gilbert",
            "Jorge", "Dan", "Brian", "Roberto", "Ramon", "Miles", "Liam", "Nathaniel", "Ethan", "Lewis",
            "Milton", "Claude", "Joshua", "Glen", "Harvey", "Blake", "Antonio", "Connor", "Julian", "Aidan"};

        private string[] arrOfLastName = {"Thasneem", "Terry", "Shelton", "Miles", "Lucas", "Fletcher",
            "Parks", "Norris", "Guzman", "Daniel", "Newton", "Potter", "Francis", "Erickson", "Norman",
            "Moody", "Lindsey", "Gross", "Sherman", "Simon", "Jones", "Brown", "Garcia", "Rodriguez",
            "Lee", "Young", "Hall" };



        private string GetFirstname()
        {
            int index = rand.Next(arrOfFirstName.Length);
            string fName = arrOfFirstName[index];
            return fName;
        }

        private string GetLastname()
        {
            int index = rand.Next(arrOfLastName.Length);
            string lName = arrOfLastName[index];
            return lName;
        }

        private uint GetPIN()
        {
            uint pinNo = Convert.ToUInt32(rand.Next(10000)); // Generate a number between 0 and 9999
            return pinNo;
        }


        private uint GetAcctNo()
        {
            uint accNo = Convert.ToUInt32(rand.Next(1000000, 10000000));
            return accNo;
        }


        private int GetBalance()
        {
            int accBal = rand.Next(1000, 1000000000);
            return accBal;
        }


        private Bitmap GetProfilePicture() 
        {
            // Read Image

            Bitmap bitmap = new Bitmap("C: \\Users\\Thasneem2\\OneDrive\\Pictures\\avatar.png");

            return bitmap;
        }


        /* get Next Account Info */
        public void GetNextAccount(out uint pin, out uint accNo, out string firstName,
            out string lastName, out int balance, out Bitmap bitmap)
        {
            pin = GetPIN();
            accNo = GetAcctNo();
            firstName = GetFirstname();
            lastName = GetLastname();
            balance = GetBalance();
            bitmap = GetProfilePicture();
        }


    }
}
