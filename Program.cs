using System.Runtime.InteropServices;

namespace MessageBoxFunction
{
    public class Program
    {
        [DllImport("User32.dll", SetLastError = true)]
        private static extern int MessageBox(IntPtr hWnd, string lpText, string lpCaption, IntPtr uType);
        [DllImport("kernel32.dll")]
        private static extern IntPtr GetLastError();

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            MessageBox(IntPtr.Zero, "Pierwszy napis", "Tytuł", 0x00000004);
            IntPtr error = GetLastError();
            Console.WriteLine(error);
        }
    }
}
