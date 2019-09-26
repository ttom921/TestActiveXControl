using Microsoft.Win32;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MyDateControl
{
    [ProgId("MyDateControl.MyDateControlUI")]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [Guid("BB40E1F5-0E6C-47B3-A665-0D3FBDE1D01C")]
    [ComVisible(true)]
    public partial class MyDateControlUI: UserControl,IObjectSafety
    {
        public MyDateControlUI()
        {
            InitializeComponent();
        }

        private void cmdDisplayToday_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(DateTime.Today.ToString("yyyy/MM/dd"), "Today");
        }

        private void cmdGetOSVer_Click(object sender, System.EventArgs e)
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");
            MessageBox.Show(key.GetValue("BuildLabEx").ToString(), "OS Build Ver");
            key = null;
        }

        void IObjectSafety.GetInterfaceSafetyOptions(int riid, out int pdwSupportedOptions, out int pdwEnabledOptions)
        {
            pdwSupportedOptions = IObjectSafetyEnums.INTERFACESAFE_FOR_UNTRUSTED_CALLER | IObjectSafetyEnums.INTERFACESAFE_FOR_UNTRUSTED_DATA;
            pdwEnabledOptions = IObjectSafetyEnums.INTERFACESAFE_FOR_UNTRUSTED_CALLER | IObjectSafetyEnums.INTERFACESAFE_FOR_UNTRUSTED_DATA;
        }

        void IObjectSafety.SetInterfaceSafetyOptions(int riid, int pdwSupportedOptions, int pdwEnabledOptions)
        {
        }
    }
}
