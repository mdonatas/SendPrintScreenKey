using System.Runtime.InteropServices;

namespace SendPrintScreenKey;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        SendPrintScreenKeyEvent();
    }

    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
    public static extern void keybd_event(uint bVk, uint bScan, uint dwFlags, uint dwExtraInfo);

    private const int VK_SNAPSHOT = 0x2C;

    public static void SendPrintScreenKeyEvent()
    {
        keybd_event(VK_SNAPSHOT, 0, 0, 0);
    }
}
