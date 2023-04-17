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

namespace Lab02
{
    public partial class Lab02_Bai1 : Form
    {
        public Lab02_Bai1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("file.txt"))
            {
                string text = sr.ReadToEnd();
                richTextBox1.Text = text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("file.txt", true))
            {        
                sw.WriteLine(nhap.Text.ToUpper());
            }
        }
    }
}
