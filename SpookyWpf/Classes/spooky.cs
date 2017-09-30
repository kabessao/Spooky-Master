using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Spooky
{
    class Spooky
    {
        static public void EsconderTudo()
        {

            Process cmd = new Process()
            {
                StartInfo = new ProcessStartInfo("attrib.exe", "/s /d +h")
                {
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            cmd.Start();
            cmd.WaitForExit();
            cmd.Dispose();


        }

        static public void MostrarTudo()
        {
            var cmd = new Process()
            {
                StartInfo = new ProcessStartInfo("attrib.exe", "/s /d -h")
                {
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };
            cmd.Start();
            cmd.WaitForExit();


        }

        static public void EsconderAlguns(string[] nomes)
        {
            var cmd = new Process()
            {
                StartInfo = new ProcessStartInfo("attrib.exe")
                {
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            nomes = nomes.Where(x => !string.IsNullOrEmpty(x.TrimEnd())).Distinct().ToArray();

            foreach (var item in nomes)
            {

                cmd.StartInfo.Arguments = "/s /d +h " + item;
                cmd.Start();


            }
            cmd.WaitForExit();


        }

    }
}
