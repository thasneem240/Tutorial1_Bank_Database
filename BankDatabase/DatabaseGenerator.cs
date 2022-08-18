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

        private string[] arrOfImages = { "P1.jpg", "P2.jpg", "P3.jpg", "P4.jpg", "P5.jpg", "P6.jpg",
        "P7.jpg","P8.jpg","P9.jpg","P10.jpg","P11.jpg","P12.jpg","P13.jpg","P14.jpg","P15.jpg","P16.jpg",
        "P17.jpg","P18.jpg","P19.png","P20.png",};

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


        private string GetProfilePicture() 
        {
            // Read Image

            //Bitmap bitmap = new Bitmap("C: \\Users\\Thasneem2\\OneDrive\\Pictures\\avatar.png");

            int index = rand.Next(arrOfImages.Length);
            string imageName = arrOfImages[index];
          
            string fileName = "C:\\Users\\Thasneem2\\OneDrive\\Pictures\\Profile_Pictures\\" + imageName;
       
            return fileName;
        }


        /* get Next Account Info */
        public void GetNextAccount(out uint pin, out uint accNo, out string firstName,
            out string lastName, out int balance, out string imageLocation)
        {
            pin = GetPIN();
            accNo = GetAcctNo();
            firstName = GetFirstname();
            lastName = GetLastname();
            balance = GetBalance();
            imageLocation = GetProfilePicture();
        }


    }
}
