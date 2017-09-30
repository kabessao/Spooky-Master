using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Spooky
{
    class spooky
    {
        static public void EsconderTudo ()
        {
            using (Process cmd = new Process())
            {
                cmd.StartInfo.FileName = "attrib.exe";
                cmd.StartInfo.Arguments = "/s /d +s +h";
                cmd.StartInfo.UseShellExecute = false;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.Start();
                cmd.WaitForExit();
                
            }
        }

        static public void MostrarTudo()
        {
            using (Process cmd = new Process())
            {
                cmd.StartInfo.FileName = "attrib.exe";
                cmd.StartInfo.Arguments = "/s /d -s -h";
                cmd.StartInfo.UseShellExecute = false;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.Start();
                cmd.WaitForExit();

            }
        }

        static public void EsconderAlguns (string[] nomes, bool soltos)
        {
            using (Process cmd = new Process())
            {
                cmd.StartInfo.FileName = "attrib.exe";
                
                cmd.StartInfo.UseShellExecute = false;
                cmd.StartInfo.CreateNoWindow = true;
                foreach (var item in nomes)
                {
                    cmd.StartInfo.Arguments = "/s /d +s +h " + item.Replace('\r', ' ');
                    cmd.Start();
                }
                if (soltos)
                {
                    cmd.StartInfo.Arguments = " +s +h";
                    cmd.Start();
                }
                cmd.WaitForExit();

            }
        }

    }
}
