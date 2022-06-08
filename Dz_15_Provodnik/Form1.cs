using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Dz_15_Provodnik
{
    public partial class Form1 : Form
    {
        public TreeNode node, child;
        ImageList imageList = new ImageList(); 

        public int x { get; set; } 
         
        public Form1()
        {
            InitializeComponent(); 

            //Нажатие кнопки мыши на любом месте дерева
            treeView1.MouseDown += new MouseEventHandler(treeView1_MouseDown);  

            //Диски
            string[] astrLogicalDrives = System.IO.Directory.GetLogicalDrives(); 
            treeView1.Nodes.Clear();
            foreach (string disk in astrLogicalDrives)
                node = treeView1.Nodes.Add(disk);

            x = 20;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            child.Expand();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            child.Collapse();
        }

        private void большиеЗначкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x = 50;
        }

        private void маленькиеЗначкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x = 20;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            child.Collapse();
        }

        private void темнаяТемаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Black;
            treeView1.BackColor = Color.Gray;
            listView1.BackColor = Color.Gray;
            menuStrip1.BackColor = Color.Gray;
        }

        private void светлаяТемаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.White;
            treeView1.BackColor = Color.White;
            listView1.BackColor = Color.White;
            menuStrip1.BackColor = Color.White;
        }

        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            imageList.Images.Add(Bitmap.FromFile("folder.png"));
            treeView1.ImageList = imageList;
            treeView1.ItemHeight = x; 

            if (e.Button == MouseButtons.Right)
            {
                TreeNode node1 = treeView1.GetNodeAt(e.X, e.Y);
                if (node1 != null)
                {
                    //Папки + файлы дерево
                    string pathToFolder = node1.Text;  
                    string[] files = Directory.GetFiles(pathToFolder);
                    string[] directories = Directory.GetDirectories(pathToFolder); 
                       
                    node1.Nodes.Clear();
                    foreach (string dir in directories) node1.Nodes.Add(dir);  
                    foreach (string file in files) node1.Nodes.Add(file);  
                }
            }
            else
            {
                TreeNode node1 = treeView1.GetNodeAt(e.X, e.Y);
                if (node1 != null)
                {
                    //Папки + файлы лист
                    child = node1;
                    string pathToFolder = node1.Text; 
                    string[] files = Directory.GetFiles(pathToFolder);
                    string[] directories = Directory.GetDirectories(pathToFolder); 
                    listView1.Clear();

                    foreach (string dir in directories)
                    {

                        ListViewItem listViewItem = new ListViewItem(dir);
                        listViewItem.ImageIndex = 0;
                        listView1.Items.Add(listViewItem);
                    }
                    foreach (string file in files) listView1.Items.Add(file); 
                }
            }
        }
          
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            this.notifyIcon1.Visible = false;
        } 

        private void Form1_Resize_1(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
                this.notifyIcon1.Visible = true;
                this.notifyIcon1.ShowBalloonTip(3);
            }
        } 
    }
} 