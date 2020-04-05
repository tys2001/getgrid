using System;
using System.Collections.Generic;
using System.Linq;
//using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GetGrid
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Process prevProcess = GetPreviousProcess();
            if (prevProcess == null)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new mainForm());
            }
            else
            {
                WakeupWindow(prevProcess.MainWindowHandle);
            }
        }

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")]
        private static extern bool IsIconic(IntPtr hWnd);
        private const int SW_RESTORE = 9;

        public static void WakeupWindow(IntPtr hWnd)
        {
            if (IsIconic(hWnd)) ShowWindowAsync(hWnd, SW_RESTORE);
            SetForegroundWindow(hWnd);
        }
        
        public static Process GetPreviousProcess()
        {
            Process curProcess = Process.GetCurrentProcess();
            Process[] allProcesses = Process.GetProcessesByName(curProcess.ProcessName);
            foreach (Process checkProcess in allProcesses)
            {
                if (checkProcess.Id != curProcess.Id)
                {
                    if (String.Compare(checkProcess.MainModule.FileName, curProcess.MainModule.FileName, true) == 0)
                    {
                        return checkProcess;
                    }
                }
            }
            return null;
        }
    }
}
