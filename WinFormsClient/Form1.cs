using Grpc.Net.Client;
using GrpcTest;
using Microsoft.Extensions.Logging;

namespace WinFormsClient
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
            var url = "https://localhost:5001";
            var channel = GrpcChannel.ForAddress(url);
            client = new Greeter.GreeterClient(channel);
            
        }
        public Greeter.GreeterClient client { get; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private  void button1_Click(object sender, EventArgs e)
        {
            var helloRequest=new HelloRequest();
            helloRequest.Name = lbltxt.Text;
            var result= client.SayHello(helloRequest);
            label3.Text = result.Message;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}