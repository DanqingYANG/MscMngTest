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
            testTree1();
            testTree2();
        }

        public void testTree1()
        {
            var nodes = Tree1.Items;

            TreeViewItem node1 = new TreeViewItem() { Header = "Folder1" };
            TreeViewItem node2 = new TreeViewItem() { Header = "Folder2" };
            TreeViewItem subNode = new TreeViewItem() { Header = "subNode" };

            nodes.Add(node1);
            nodes.Add(node2);
            node2.Items.Add(subNode);

            List<TreeViewItem> nodeList = new List<TreeViewItem>();
            int listLength = 10;
            for (int i = 0; i < listLength; i++)
            {
                TreeViewItem nd = new TreeViewItem() { Header = "subNode" + i };
                nodeList.Add(nd);
            }
            for (int i = 0; i < listLength; i++)
            {
                node1.Items.Add(nodeList[i]);
            }

            return;
        }

        public void testTree2()
        {


        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void buttonModifyIndex_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("lalal");

            return;

        }

        private void buttonOpenMusic_Click(object sender, RoutedEventArgs e)
        {
            //Open Music
            MessageBox.Show("music~");

            return;
        }
    }
}
