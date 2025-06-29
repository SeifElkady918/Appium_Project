using Driver_Service_gRPC;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PMAG.CU.Appium.Tool
{
    public partial class Form1 : Form
    {
        Driver_Service_gRPC.Driver_Service_gRPC.Driver_Service_gRPCClient _client;

        public Form1()
        {
            InitializeComponent();

            const string Target = "localhost:50051";
            Channel channel = new Channel(Target, ChannelCredentials.Insecure);

            var _client = new Driver_Service_gRPC.Driver_Service_gRPC.Driver_Service_gRPCClient(channel);

            Console.WriteLine("Openning Settings ...");
            _client.OpenSettings(new OpenSettingsRequest());

            channel.ShutdownAsync().Wait();

        }

        private void DoTest(object sender, EventArgs e)
        {
            //Console.WriteLine("Openning Settings ...");
            //_client.OpenSettings(new OpenSettingsRequest());
            //testcase_BT(comboBoxDesiredDevices.Text);
        }

        public async void testcase_BT(string desiredDevice)
        {
            Console.WriteLine("Openning Settings ...");
            _client.OpenSettings(new OpenSettingsRequest());
            // OpenSettingsResponse openSettingsResponse = await _client.OpenSettingsAsync(new OpenSettingsRequest { });
            Console.WriteLine("Settings Openned");

            //Console.WriteLine($"Reading {desiredDevice} state ...");
            //var readStateResponse = await _client.ReadDeviceStateAsync(new ReadDeviceStateRequest { DesiredDevice = desiredDevice });

            //Console.WriteLine($"{desiredDevice} is {readStateResponse.State}");

            Console.WriteLine("Testcase ended");
        }

    }
}
