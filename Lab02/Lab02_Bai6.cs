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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Lab02
{
    public partial class Lab02_Bai6 : Form
    {
        public Lab02_Bai6()
        {
            InitializeComponent();
        }

        private void Lab02_Bai6_Load(object sender, EventArgs e)
        {
            InitTree();
        }
        private void InitTree()
        {
            string[] drives = Directory.GetLogicalDrives();
            TreeNode node = null;
            foreach (string drive in drives) 
            {
                node = new TreeNode(drive);
                treeview.Nodes.Add(node);
                node.Nodes.Add("Temp");
            }
        }
        private void treeview_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            node.Nodes.Clear();
            node.ImageIndex = 1;
            foreach (string dir in Directory.GetDirectories(node.FullPath))
            {
                TreeNode n = node.Nodes.Add(Path.GetFileName(dir));
                n.Nodes.Add("Tmp");
            }
        }

        private void treeview_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.ImageIndex = 0;
        }

        private void treeview_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ptb.Image = null;
            string[] files = Directory.GetFiles(e.Node.FullPath);
            flp.Controls.Clear();
            foreach (string file in files)
            {
                if (file.ToLower().EndsWith(".jpeg") || file.ToLower().EndsWith(".jpg") || file.ToLower().EndsWith(".png"))
                {
                    PictureBox pic = new PictureBox();
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Image = Image.FromFile(file);
                    pic.Cursor = Cursors.Hand;
                    flp.Controls.Add(pic);
                    pic.Click += new EventHandler(picturebox_click);
                }
            }
        }

        private void picturebox_click(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            ptb.Image = picture.Image;
        }
    }
}
