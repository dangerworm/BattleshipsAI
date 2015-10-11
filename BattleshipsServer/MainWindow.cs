using BattleshipsAI;
using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.Windows.Forms;

namespace BattleshipsServer
{
    public partial class MainWindow : Form
    {
        private string hostUri;

        private WebServiceHost host;

        public MainWindow()
        {
            InitializeComponent();

            hostUri = "http://localhost:8080/";
            host = new WebServiceHost(typeof(Service), new Uri(hostUri));
        }

        public void WriteLine(string text)
        {
            txtConsole.Text += text + "\r\n";
        }

        public void WriteLine(string format, object text)
        {
            txtConsole.Text += String.Format(format + "\r\n", text);
        }

        private void btnStart_Click(object sender, System.EventArgs e)
        {
            try
            {
                ServiceEndpoint ep = host.AddServiceEndpoint(typeof(IService), new WebHttpBinding(), "");
                host.Open();
                using (ChannelFactory<IService> cf = new ChannelFactory<IService>(new WebHttpBinding(), hostUri))
                {
                    cf.Endpoint.Behaviors.Add(new WebHttpBehavior());

                    IService channel = cf.CreateChannel();

                    WriteLine("Calling Start via HTTP GET: ");
                    int s = channel.Start(new StartRequest
                    {
                        MaxTurns = 10,
                        GridSize = "H8",
                        Players = new[] { "Player1", "Player2" },
                        Ships = new[] { "Carrier", "Destroyer" },
                        MineCount = 5
                    });

                    WriteLine("Output: {0}", s);
                }

                host.Close();
            }
            catch (CommunicationException cex)
            {
                WriteLine("An exception occurred: {0}", cex.Message);
                host.Abort();
            }
        }
    }
}
