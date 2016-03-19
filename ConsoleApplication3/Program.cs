using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication3.DsReference;
using System.IO;
using System.Text;
using System.Diagnostics;
namespace ConsoleApplication3
{
    class Program
    {
        static byte[] buffer;
        static ProcessStartInfo processinfo;
        static Process process;
        static void Main(string[] args)
        {
            Encoding enc = Encoding.ASCII;
            dsintClient c = new dsintClient();
            String fname;
            Console.WriteLine("enter the file to be downloaded with full path");
            fname = Console.ReadLine();
            buffer=c.getvideo(fname);
            Console.WriteLine(buffer.Length);
            Console.WriteLine("enter the file name to store in client side");
            String fnames;
            fnames = Console.ReadLine();
            /*using (StreamWriter sw = new StreamWriter("C:\\Users\\Naveen Raj\\Documents\\Visual Studio 11\\Projects\\ConsoleApplication3\\ConsoleApplication3\\"+fnames))
            {
                sw.Write(enc.GetString(buffer));
            }*/
            File.WriteAllBytes("D:\\client\\" + fnames, buffer);

            String command = @"start D:\VLC\vlc.exe D:\client\" + fnames;
            processinfo = new ProcessStartInfo("cmd.exe", " /c " + command);
            processinfo.CreateNoWindow = true;
            processinfo.UseShellExecute = false;
            process = Process.Start(processinfo);
            process.WaitForExit();
        }

    }
}
