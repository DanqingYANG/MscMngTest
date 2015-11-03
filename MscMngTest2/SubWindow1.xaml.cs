using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MscMngTest2
{
    /// <summary>
    /// Interaction logic for SubWindow1.xaml
    /// </summary>
    public partial class SubWindow1 : Window
    {
        public SubWindow1()
        {
            InitializeComponent();
            ListDirectory(SubWindowTree1, @"F:\music");
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ListDirectory(TreeView treeView, string path)
        {
            treeView.Items.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);
            treeView.Items.Add(CreateDirectoryNode(rootDirectoryInfo));
        }

        private  TreeViewItem CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            
            //TreeView with file system directory structure
            var directoryNode = new TreeViewItem() { Header = new CheckBox() { Content = directoryInfo.Name } };
            foreach(var directory in directoryInfo.GetDirectories())
            {
                directoryNode.Items.Add(CreateDirectoryNode(directory));
            }
            //foreach (var file in directoryInfo.GetFiles())
            //{
            //    directoryNode.Items.Add(new TreeViewItem() { Header = file.Name });
            //}
            return directoryNode;
        }


    }
}
