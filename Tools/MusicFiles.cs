using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tools
{
    public class MusicFiles
    {

        public void test()
        {
            string folder;
            string playHistoryPath = @"F:\music\AIRPLAY_CONFIG\LOCAL\audition.locallist";

            folder = getFolder();
            clearPlayHistory(playHistoryPath);
            openMusic(folder);
        }

        public string getFolder()
        {
            string folder = @"F:\music\Bach\Bach.-.[Goldberg.Variations(Walcha.EMI.Angle)].专辑.(Flac)";
            Console.WriteLine("Open the folder: " + folder);
            return folder;
        }

        public string[] getFiles(string folder)
        {
            string[] files = Directory.GetFiles(folder);
            for ( int i=0 ;i < files.Length;i++)
            {
                  Console.WriteLine(files[i]);
            }
            return files;
        }

        public void openMusic(string folder) 
        {
            //Process.Start(@"F:\music\AIRPLAY.exe", @"""F:\music\Mozart\Mozart - Violin Concertos\cd1\CDImage.ape.cue""");
            //Thread.Sleep(2000);//to prevent several airplay.exe start in the same time.
            //Process.Start(@"F:\music\AIRPLAY.exe", @"""F:\music\Bach\Bach.-.[Goldberg.Variations(Walcha.EMI.Angle)].专辑.(Flac)\033 Aria.mp3""");

            string filepath = "\"" + folder + "\"";
            Process pro = Process.Start(@"F:\music\AIRPLAY.exe", folder);
            Thread.Sleep(800);
            pro.Close();

            //IntPtr aHandle = pro.MainWindowHandle;

            //int i = files.Length;
            //int j = 0;
            //while ((i > 0) && true)
            //{
            //    string filepath = "\"" + files[j] + "\"";
            //    Process.Start(@"F:\music\AIRPLAY.exe", filepath);
            //    Thread.Sleep(800);
            //    j++;
            //    i--;
            //}
        }

        public void clearPlayHistory(string filename) 
        {

            File.Delete(filename);
        }
    }

}
