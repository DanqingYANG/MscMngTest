using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace Test
{
    class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]

        static void Main(string[] args)
        {
            Tools.FolderSelector folder = new Tools.FolderSelector();
            folder.setFileType("jpg, png, , ,txt, mp3, cue, ape");
            folder.subFolders(@"F:\music");
            List<string> b = new List<string>();
            folder.getFiles(@"F:\music\Bach\Bach.-.[Goldberg.Variations(Walcha.EMI.Angle)].专辑.(Flac)",b);


            Tools.MusicFiles playlist = new MusicFiles();
            playlist.test();

        }
    }
}
