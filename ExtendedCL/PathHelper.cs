using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedCL
{
    public static class PathHelper
    {
        public readonly static string UserAppDataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public readonly static string ProcessPath = Process.GetCurrentProcess().MainModule.FileName;
        public readonly static string ProcessBaseName = Path.GetFileNameWithoutExtension(ProcessPath);
        public readonly static string ProcessAppDir = Path.Combine(UserAppDataDir, ProcessBaseName);
        public readonly static string ProcessDir = Path.GetDirectoryName(ProcessPath);

        public static void CreateProcessAppDir()
        {
            if (Directory.Exists(ProcessAppDir))
            {
                return;
            }
            Directory.CreateDirectory(ProcessAppDir);
        }
    }
}
