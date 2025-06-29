using OpenQA.Selenium.Appium.Android;
using PMAG.CU.Appium_II.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PMAG.CU.Appium.Code.Modules
{
    public class Android_Driver : Driver
    {
        private AndroidDriver<AndroidElement> androidDriver;

        public Android_Driver(DeviceData deviceData, string networkIP, int networkPort) : base(deviceData, networkIP, networkPort)
        {
            androidDriver = new AndroidDriver<AndroidElement>(uri, appiumOptions);
        }

        public override void OpenSettings()
        {
            try
            {
                Console.WriteLine("Proceeding with opening Settings...");

                // Get settings package and activity Xpath from hashmap
                string SettingsPackage = Xpath.SettingsPackage[androidDriver.PlatformName];
                string SettingsActivities = Xpath.SettingsActivity[androidDriver.PlatformName];

                // Open settings app. Android
                androidDriver.StartActivity(SettingsPackage, SettingsActivities);

                // Pause execution for 1 second (1000 milliseconds)
                Thread.Sleep(1000);

                Console.WriteLine("Settings Opened successfully");
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                Console.WriteLine($"Failed to open settings: {ex.Message}");

                // Pause execution for 1 second (1000 milliseconds)
                Thread.Sleep(1000);
            }
        }
    }
}
