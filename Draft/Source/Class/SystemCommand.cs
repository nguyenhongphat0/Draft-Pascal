using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DraftPascal
{
    class SystemCommand
    {
        public static string fpcPath = "C:\\FPC\\bin\\i386-win32\\";

        public static string fpc()
        {
            return fpcPath + "fpc.exe";
        }

        public static void go(string command, string param)
        {
            Process process = new Process();
            process.StartInfo.FileName = command;
            process.StartInfo.Arguments = param;
            process.StartInfo.WorkingDirectory = CodeFileManager.virtualFilePrefix;
            process.Start();
            process.WaitForExit();
        }

        public static Process init(string command, string param)
        {
            Process process = new Process();
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.FileName = command;
            process.StartInfo.Arguments = param;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WorkingDirectory = CodeFileManager.virtualFilePrefix;
            return process;
        }

        public static bool ExecuteWithTimeLimit(int timeSpan, Action codeBlock)
        {
            try
            {
                Task task = Task.Factory.StartNew(() => codeBlock());
                task.Wait(timeSpan);
                return task.IsCompleted;
            }
            catch (AggregateException ae)
            {
                throw ae.InnerExceptions[0];
            }
        }
    }
}
