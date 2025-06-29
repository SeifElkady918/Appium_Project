using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMAG.CU.Appium.Code.Modules
{
    public abstract class Driver
    {
        protected Uri uri { get; }

        protected AppiumOptions appiumOptions;

        public Driver(DeviceData deviceData, string networkIP, int networkPort)
        {
            appiumOptions = deviceData.options;

            // Create a URI with the given IP and port : http://127.0.0.1:4723/wd/hub
            uri = new Uri($"http://{networkIP}:{networkPort}/wd/hub");

        }

        public abstract void OpenSettings();
    }
}
