using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P_Studio
{
    class Tools
    {
        public static FileStream WaitForFile(string fullPath, FileMode mode, FileAccess access, FileShare share)
        {
            for (int numTries = 0; numTries < 10; numTries++)
            {
                FileStream fs = null;
                try
                {
                    fs = new FileStream(fullPath, mode, access, share);
                    return fs;
                }
                catch (IOException)
                {
                    if (fs != null)
                    {
                        fs.Dispose();
                    }
                    Thread.Sleep(1000);
                }
            }
            return null;
        }

        public static void CloseProcess(string procName)
        {
            foreach (Process p in Process.GetProcessesByName(procName))
                p.Kill();
            PStudio.assetEditor = "";
        }
        public static void Mount(string exePath, string inputFile, IntPtr panel)
        {
            if (File.Exists(exePath))
            {
                string processName = Path.GetFileName(exePath);
                PStudio.assetEditor = processName;
                // Close existing process
                CloseProcess(processName);
                // Load Program
                Process process = new Process();
                process.StartInfo.FileName = exePath;
                // Add .flow/.msg pair to commandline args
                if (Path.GetExtension(inputFile).ToLower().Equals(".flow") && File.Exists(inputFile.Replace(".flow", ".msg")))
                    process.StartInfo.Arguments += $"\"{inputFile.Replace(".flow", ".msg")}\" ";
                if (Path.GetExtension(inputFile).ToLower().Equals(".msg") && File.Exists(inputFile.Replace(".msg", ".flow")))
                    process.StartInfo.Arguments += $"\"{inputFile.Replace(".msg", ".flow")}\" ";
                // Add initial input file
                process.StartInfo.Arguments += $"\"{inputFile}\"";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.Start();
                Thread.Sleep(1000);
                process.WaitForInputIdle();
                // Add program to form and focus on it
                if (processName == "Amicitia.exe")
                    PStudio.assetEditorHandle = process.MainWindowHandle;
                else if (processName == "notepad++.exe")
                    PStudio.scriptEditorHandle = process.MainWindowHandle;
                SetParent(process.MainWindowHandle, panel);
                SetParent(process.MainWindowHandle, panel);
                ShowWindow(process.MainWindowHandle, SW_MINIMIZE);
                SetForegroundWindow(process.MainWindowHandle);
                SetFocus(process.MainWindowHandle);
                MoveWindow(process.MainWindowHandle, 0, 0, PStudio.formWidth, PStudio.formHeight, true);
                IntPtr HMENU = GetMenu(process.MainWindowHandle);
                int count = GetMenuItemCount(HMENU);
                for (int i = 0; i < count; i++)
                    RemoveMenu(HMENU, 0, (MF_BYPOSITION | MF_REMOVE));
                DrawMenuBar(process.MainWindowHandle);
                SetWindowLong(process.MainWindowHandle, GWL_STYLE, WS_VISIBLE);
                ShowWindow(process.MainWindowHandle, SW_MAXIMIZE);
                SetForegroundWindow(process.MainWindowHandle);
                SetFocus(process.MainWindowHandle);
                Program.status.Update($"[INFO] Loaded \"{Path.GetFileName(inputFile)}\" with {processName}");
            }
            else
            {
                Program.status.Update($"[ERROR] Could not find program at path: \"{exePath}\"");
            }
        }

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr SetFocus(IntPtr hWnd);
        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, uint dwNewLong);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
        [DllImport("user32.dll")]
        static extern IntPtr GetMenu(IntPtr hWnd);
        [DllImport("user32.dll")]
        static extern int GetMenuItemCount(IntPtr hMenu);
        [DllImport("user32.dll")]
        static extern bool DrawMenuBar(IntPtr hWnd);
        [DllImport("user32.dll")]
        static extern bool RemoveMenu(IntPtr hMenu, uint uPosition, uint uFlags);
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, uint wParam, uint lParam);
        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool DestroyWindow(IntPtr hwnd);

        const int GWL_STYLE = (-16);
        private const int SW_MAXIMIZE = 3;
        private const int SW_MINIMIZE = 2;
        private const int SW_NORMALE = 1;
        public static uint MF_BYPOSITION = 0x400;
        public static uint MF_REMOVE = 0x1000;
        const uint WS_VISIBLE = 0x10000000;
    }
}
