using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tools;
namespace MscMngTest2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //Tools.MusicFiles files;
            InitializeComponent();
            Tree1.Items.Clear();

            var items = Tree1.Items;

            //TreeViewItem item1 = new TreeViewItem();
            //item1.Header = "Computer";
            TreeViewItem item1 = new TreeViewItem() { Header = "Folder1" };
            TreeViewItem item2 = new TreeViewItem() { Header = "Folder2" };

            //item1.ItemsSource = new string[] { "Monitor", "CPU", "Mouse" };
            //item1.Items.GetItemAt(1);
            
            // ... Create a second TreeViewItem.
            TreeViewItem subItem = new TreeViewItem();

            List<TreeViewItem> itemList = new List<TreeViewItem>();
            int listLength = 10;
            
            for (int i = 0; i < listLength; i++)
            {
                TreeViewItem item = new TreeViewItem() { Header = "subItem" + i};
                itemList.Add(item);
            }

            subItem.Header = "subitem";

            items.Add(item1);
            items.Add(item2);

            foreach (TreeViewItem n in items)
            {
                if (n.Header == "Folder2")
                {
                    for (int i = 0; i < listLength; i++)
                    {
                        (n as TreeViewItem).Items.Add(itemList[i]);
                    }
                }
                    
            }

            
            
        }


        private void addNodes(TreeView SingleTree)
        {
            SingleTree.Items.Add("aaa");
        }
    }
}
