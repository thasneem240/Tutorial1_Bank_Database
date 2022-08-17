using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1_Simple_WPF_APP
{
    internal class program
    {
        public static void Main(string[] args) 
        {
            DatabaseClass db = new DatabaseClass();
            List<DataStruct> dataStructs = db.dataStructList;

            foreach (DataStruct dataStruct in dataStructs) 
            {
                Console.WriteLine(dataStruct.ToString());
            }

            Console.ReadLine();
        }
    }
}
