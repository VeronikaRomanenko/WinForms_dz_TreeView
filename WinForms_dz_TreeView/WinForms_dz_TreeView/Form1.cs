using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_dz_TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillDriveNodes();
        }

        private void FillDriveNodes()
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                TreeNode driveNode = new TreeNode(drive.Name);
                treeView1.Nodes.Add(driveNode);
            }
        }

        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            string[] dirs = Directory.GetDirectories(e.Node.FullPath);
            for (int i = 0; i < dirs.Length; i++)
            {
                TreeNode driveNode = new TreeNode(new DirectoryInfo(dirs[i]).Name);
                e.Node.Nodes.Add(driveNode);
            }

            txbAdres.Text = e.Node.FullPath;
        }
        //string[] dirs = Directory.GetDirectories(treeView1.SelectedNode.FullPath);
        //    for (int i = 0; i<dirs.Length; i++)
        //    {
        //        lsbSoderschimoe.Controls.Add(new Control(new DirectoryInfo(dirs[i]).Name));
        //    }
    }
}