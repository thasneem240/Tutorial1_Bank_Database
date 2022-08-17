using RemoteServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BankServerInterface foob;

        public MainWindow()
        {
            // Setup the Window
            InitializeComponent();

            /* This is a factory that generates remote connections to our remote class. This 
               is what hides the RPC stuff! */
            ChannelFactory<RemoteServer.BankServerInterface> foobFactory;
            NetTcpBinding tcp = new NetTcpBinding();

            //Set the URL and create the connection!
            string URL = "net.tcp://localhost:8100/DataService";

            foobFactory = new ChannelFactory<BankServerInterface>(tcp, URL);
            foob = foobFactory.CreateChannel();

            //Also, tell me how many entries are in the DB.
            pTotalItem.Text = foob.GetNumEntries().ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int index = 0;
            string fName = "", lName = "";
            int bal = 0;
            uint acct = 0, pin = 0;

            /* index = Convert.ToInt32(pIndex.Text);
            In brief, int.Parse and Convert ToInt32 are two methods to convert a string to an integer. 
            The main difference between int Parse and Convert ToInt32 in C# is that 
            passing a null value to int Parse will throw an ArgumentNullException
            while passing a null value to Convert ToInt32 will give zero.*/

            //On click, Get the index....
            index = Int32.Parse(pIndex.Text);

            //Then, run our RPC function, using the out mode parameters... And Get All the Values for out
            foob.GetValuesForEntry(index, out acct, out pin, out bal, out fName, out lName);

            pFirstName.Text = fName;
            pLastName.Text = lName;
            pAccNum.Text = acct.ToString();
            pPinNo.Text = pin.ToString("D4"); // Padding with 0
            pBalance.Text = bal.ToString("C"); // ("C") displays $

        }
    }
}
