using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMAG.CU.Appium_II.Utilities
{
    class Xpath
    {
        //------------------------------------------------Packages-------------------------------------------//

        public static readonly Dictionary<string, string> SettingsPackage = new Dictionary<string, string>
        {
        {"Android", "com.android.settings"},
        {"iOS", "com.apple.Preferences"},
        };

        public static readonly Dictionary<string, string> SettingsActivity = new Dictionary<string, string>
        {
        {"Android", "com.android.settings.homepage.SettingsHomepageActivity"},
        {"Device2", "//XPath/To/Device2/ConnectionIcon"},
        };

        public static readonly Dictionary<string, string> VLCPackage = new Dictionary<string, string>
        {
        {"Android", "org.videolan.vlc"},
        {"iOS", "com.apple.Preferences"},
        };

        public static readonly Dictionary<string, string> VLCActivity = new Dictionary<string, string>
        {
        {"Android", "org.videolan.vlc.StartActivity"},
        {"Device2", "//XPath/To/Device2/ConnectionIcon"},
        };

        public static readonly Dictionary<string, string> PhonePackage = new Dictionary<string, string>
        {
        {"Android", "com.samsung.android.dialer"},
        {"iOS", "com.apple.Preferences"},
        };

        public static readonly Dictionary<string, string> PhoneActivity = new Dictionary<string, string>
        {
        {"Android", "com.samsung.android.dialer.DialtactsActivity"},
        {"Device2", "//XPath/To/Device2/ConnectionIcon"},
        };

        public static readonly Dictionary<string, string> KTMPackage = new Dictionary<string, string>
        {
        {"Android", "com.ktm.bikeapp.ktm"},
        {"iOS", "com.apple.Preferences"},
        };

        public static readonly Dictionary<string, string> KTMActivity = new Dictionary<string, string>
        {
        {"Android", "com.ktm.bikeapp.ui.activity.MainActivity"},
        {"Device2", "//XPath/To/Device2/ConnectionIcon"},
        };

        //------------------------------------------------Bluetooth-------------------------------------------//

        public static readonly Dictionary<string, string> ConnectionsIcon = new Dictionary<string, string>
        {
        {"Android", "//android.widget.TextView[@resource-id=\"android:id/title\" and @text=\"Connections\"]"},
        {"Device2", "//XPath/To/Device2/ConnectionIcon"},
        };

        public static readonly Dictionary<string, string> BluetoothIcon = new Dictionary<string, string>
        {
        {"Android", "//android.widget.TextView[@resource-id=\"android:id/title\" and @text=\"Bluetooth\"]"},
        {"iOS", "//XCUIElementTypeStaticText[@name=\"Bluetooth\"]"},
        };

        public static readonly Dictionary<string, string> BluetoothSwitchIcon = new Dictionary<string, string>
        {
        {"Android", "//android.widget.Switch[@resource-id=\"com.android.settings:id/switch_widget\"]"},
        {"Device2", "//XPath/To/Device2/ConnectionIcon"},
        };

        public static readonly Dictionary<string, string> ScanIcon = new Dictionary<string, string>
        {
        {"Android", "//android.widget.Button[@text='Scan']"},
        {"Device2", "//XPath/To/Device2/ConnectionIcon"},
        };

        public static readonly Dictionary<string, string> StopIcon = new Dictionary<string, string>
        {
        {"Android", "//android.widget.Button[@text='Stop']"},
        {"Device2", "//XPath/To/Device2/ConnectionIcon"},
        };

        public static readonly Dictionary<string, string> DesiredDevice = new Dictionary<string, string>
        {
        {"Android", "//android.widget.TextView[@resource-id=\"android:id/title\" and @text=\"‎{0}‎\"]"},
        {"Device2", "//XPath/To/Device2/ConnectionIcon"},
        };

        public static readonly Dictionary<string, string> PairedDevicesHeader = new Dictionary<string, string>
        {
        {"Android", "//android.widget.TextView[@content-desc=\"Paired devices, Header\"]"},
        {"Device2", "//XPath/To/Device2/ConnectionIcon"},
        };

        public static readonly Dictionary<string, string> AvailableDevicesHeader = new Dictionary<string, string>
        {
        {"Android", "//android.widget.TextView[@content-desc=\"Available devices, Header\"]"},
        {"Device2", "//XPath/To/Device2/ConnectionIcon"},
        };

        public static readonly Dictionary<string, string> DesiredDevicesBTSettings = new Dictionary<string, string>
        {
        {"Android", "//android.widget.ImageView[@content-desc=\"‎{0}‎, Device settings\"]"},
        {"Device2", "//XPath/To/Device2/ConnectionIcon"},
        };

        public static readonly Dictionary<string, string> BTHeadderTitle = new Dictionary<string, string>
        {
        {"Android", "//android.widget.TextView[@text=\"Bluetooth\"]"},
        {"Device2", "//XPath/To/Device2/ConnectionIcon"},
        };

        public static readonly Dictionary<string, string> BluetoothConnectionElement = new Dictionary<string, string>
        {
        {"Android", "//android.widget.TextView[@resource-id=\"com.android.settings:id/bluetooth_header_summary\"]"},
        {"Device2", "//XPath/To/Device2/ConnectionIcon"},
        };

        public static readonly Dictionary<string, string> BluetoothDisconnectIcon = new Dictionary<string, string>
        {
        {"Android", "//android.widget.Button[@content-desc=\"Disconnect\"]"},
        {"Device2", "//XPath/To/Device2/ConnectionIcon"},
        };

        public static readonly Dictionary<string, string> BluetoothConnectIcon = new Dictionary<string, string>
        {
        {"Android", "//android.widget.Button[@content-desc=\"Connect\"]"},
        {"Device2", "//XPath/To/Device2/ConnectionIcon"},
        };

        public static readonly Dictionary<string, string> BluetoothUnPairIcon = new Dictionary<string, string>
        {
        {"Android", "//android.widget.Button[@content-desc=\"Unpair\"]"},
        {"Device2", "//XPath/To/Device2/ConnectionIcon"},
        };

        public static readonly Dictionary<string, string> BluetoothPairIcon = new Dictionary<string, string>
        {
        {"Android", "//android.widget.Button[@resource-id=\"android:id/button1\"]"},
        {"Device2", "//XPath/To/Device2/ConnectionIcon"},
        };

        public static readonly Dictionary<string, string> BluetoothNavigateBackIcon = new Dictionary<string, string>
        {
        {"Android", "//android.widget.ImageButton[@content-desc=\"Navigate up\"]"},
        {"Device2", "//XPath/To/Device2/ConnectionIcon"},
        };

        //------------------------------------------------MediaPlayer-------------------------------------------//

        public static readonly Dictionary<string, string> SoundsAndViberationIcon = new Dictionary<string, string>
        {
        {"Android", "//android.widget.TextView[@resource-id=\"android:id/title\" and @text=\"Sounds and vibration\"]"},
        {"Device2", "//XPath/To/Device2/ConnectionIcon"},
        };

        public static readonly Dictionary<string, string> VolumeIcon = new Dictionary<string, string>
        {
        {"Android", "//android.widget.TextView[@resource-id=\"android:id/title\" and @text=\"Volume\"]"},
        {"Device2", "//XPath/To/Device2/ConnectionIcon"},
        };

        public static readonly Dictionary<string, string> VolumeScrollBar = new Dictionary<string, string>
        {
        {"Android", "//androidx.recyclerview.widget.RecyclerView[@resource-id=\"com.android.settings:id/recycler_view\"]/android.widget.LinearLayout[2]/android.widget.LinearLayout[2]/android.widget.LinearLayout/child::*"},
        {"ios", "//XPath/To/Device2/ConnectionIcon"},
        };

        //------------------------------------------------EXTRAS-------------------------------------------//

        public static readonly Dictionary<string, string> CloseAllIcon = new Dictionary<string, string>
        {
        {"Android", "//android.widget.Button[@resource-id=\"com.sec.android.app.launcher:id/clear_all_button\"]"},
        {"Device2", "//XPath/To/Device2/ConnectionIcon"},
        };
    }
}
