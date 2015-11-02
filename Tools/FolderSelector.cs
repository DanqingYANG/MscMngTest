using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class FolderSelector
    {

        private string _indexPath;
        public string IndexPath
        {
            get
            {
                return _indexPath;
            }
            set
            {
                _indexPath = value;
            }
        }

        private List<string> _fileType;
        public List<string> FileType
        {
            get
            {
                return _fileType;
            }
            set
            {
                _fileType = value;
            }
        }

        public List<string> setFileType(string line)
        {
            List<string> fileTypeList = new List<string>();
            string[] linesplit = line.Split(',', ' ');
            List<string> fileTypes = new List<string>();
            for (int i = 0; i < linesplit.Length; i++)
            {
                if (linesplit[i] != "")
                {
                    fileTypes.Add(linesplit[i]);
                }
            }
            return fileTypes;
        }

        public List<string> getFileNames(string targetDirectory, List<string> filetypes)
        {
            List<string> filenames = new List<string>();
            DirectoryInfo di = new DirectoryInfo(targetDirectory);
            for (int i = 0; i < filetypes.Count; i++)
            {
                string key ="*." +filetypes[i];
                foreach (var fi in di.GetFiles(key))
                {
                    Console.WriteLine(fi.DirectoryName);
                    filenames.Add(fi.Name);
                }
            }          
            return filenames;
        }



        public List<string> subFolders(string targetDirectory)
        {
            List<string> subFolders = new List<string>();
            DirectoryInfo directory = new DirectoryInfo(targetDirectory);
            DirectoryInfo[] subdirs = directory.GetDirectories();
            Console.WriteLine(subdirs.ToString());
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            return subFolders;
        }


        public void reloadIndex()
        {
            //check and open local txt
            //rewrite message.
            string message = "Reversed Infomation:";

        }

        public void saveIndextoLocal(string path)
        {
            string filename= "index" + DateTime.Now.Date;
            string message = filename + "added to the " + path;
            return;
        }



        private bool hasSubfolder(string path)
        {
            IEnumerable<string> subfolders = Directory.EnumerateDirectories(path);
            return subfolders != null && subfolders.Any();           
        }


    }
}
