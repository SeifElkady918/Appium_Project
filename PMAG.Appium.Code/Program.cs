using Grpc.Core;
using PMAG.CU.Appium.Code.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMAG.CU.Appium.Code
{
    class Program
    {
        static void Main(string[] args)
        {
            string appiumNetworkIP = "127.0.0.1";
            int appiumNetworkPort = 4723;
            string gRPCNetworkIP = "localhost";
            int gRPCNetworkPort = 50051;

            //Samsung Galaxy A50 DeviceData
            DeviceData samsungGalaxyA50Data = new DeviceData("Galaxy A50", "R58N75SQXYH", "Android", "11", "UiAutomator2");

            //Create a Driver
            Console.WriteLine("Creating Samsung A50 Driver...");
            Driver samsungGalaxyA50Driver = new Android_Driver(samsungGalaxyA50Data, appiumNetworkIP, appiumNetworkPort);
            Console.WriteLine("Samsung A50 Driver Created Successfuly");

            Console.WriteLine("Creating gRPC service and Starting gRPC Network...");
            var server = gRPCNetworkCongig(samsungGalaxyA50Driver, gRPCNetworkIP, gRPCNetworkPort);
            Console.WriteLine("gRPC service and gRPC Network are created and started");

            Console.WriteLine("Press any key to stop the server...");
            Console.ReadKey();

            server.ShutdownAsync().Wait();
        }

        public static Server gRPCNetworkCongig(Driver driver, string gRPCIP, int gRPCPort)
        {
            Server server = new Server();

            server.Ports.Add(new ServerPort(gRPCIP, gRPCPort, ServerCredentials.Insecure));

            server.Services.Add(DriverService_gRPC.DriverService_gRPC.BindService(new DriverService(driver)));



            // Start the gRPC server
            server.Start();
            Console.WriteLine("Greeter server listening on port " + gRPCPort);
            return server;
        }
    }
}
