using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMAG.CU.Appium.Code.Modules
{
    public class DeviceData
    {
        public AppiumOptions options = new AppiumOptions();

        public DeviceData(string deviceName, string deviceID, string platform, string platformVersion, string automationName)
        {
            options.PlatformName = platform;
            options.AddAdditionalCapability("appium:udid", deviceID);
            options.AddAdditionalCapability("appium:deviceName", deviceName);
            options.AddAdditionalCapability("appium:platformVersion", platformVersion);
            options.AddAdditionalCapability("appium:automationName", automationName);
        }
    }
}
