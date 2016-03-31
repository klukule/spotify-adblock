using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyCrack
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Spotify";
            if (File.Exists(path + "\\Apps\\ad.spa"))
            {
                File.Delete(path + "\\Apps\\ad.spa");
                File.WriteAllBytes(path + "\\Apps\\ad.spa", new byte[0]);
            }
            else
            {
                File.WriteAllBytes(path + "\\Apps\\ad.spa", new byte[0]);
            }
            path = Environment.SystemDirectory + "\\drivers\\etc\\hosts";
            StreamReader streamReader = new StreamReader(path);
            string str = streamReader.ReadToEnd();
            streamReader.Close();
            string value = str + "\r\n0.0.0.0 pubads.g.doubleclick.net\r\n0.0.0.0 securepubads.g.doubleclick.net";
            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.Write(value);
            streamWriter.Close();

            Console.WriteLine("Crack successfull");
            Console.ReadKey();
        }
    }
}
