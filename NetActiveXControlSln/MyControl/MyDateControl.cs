using System;
using System.Runtime.InteropServices;

namespace MyControl
{
    [ProgId("MyControl.MyDateControl")]

    [ClassInterface(ClassInterfaceType.AutoDual)]
    [Guid("415D09B9-3C9F-43F4-BB5C-C056263EF270")]
    [ComVisible(true)]
    public class MyDateControl
    {
        public DateTime Today { get { return DateTime.Today; } }
        public string GetTodayDateString()
        {
            return DateTime.Today.ToString("yyyy/MM/dd HH:mm:ss");
        }
    }
}
