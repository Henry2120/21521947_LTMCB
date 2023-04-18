using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Lab02
{
    public partial class Lab02_Bai3 : Form
    {
        public Lab02_Bai3()
        {
            InitializeComponent();
        }

        private void readfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            rtb.Text = content;
            fs.Close();
            ofd.ShowDialog();
            FileStream fs1 = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs1);
            StringReader srd = new StringReader(content);
            string input, equal;
            for (int i = 0; i < rtb.Lines.Count(); i++)
            {
                input = srd.ReadLine();
                equal = new DataTable().Compute(input, null).ToString();
                sw.WriteLine(input + " = " + equal);
            }
            rtb.Clear();
            StreamReader sr1 = new StreamReader(fs1);
            content = sr1.ReadToEnd();
            rtb.Text = content;
            sw.Flush();
            fs1.Close();
        }

    }
}
