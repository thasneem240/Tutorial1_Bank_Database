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

            foobFactory = new ChannelFactory<BankServerInterface>(tcp,URL);
            foob = foobFactory.CreateChannel();

            //Also, tell me how many entries are in the DB.
            pTotalItem.Text = foob.GetNumEntries().ToString();
        }
    }
}
