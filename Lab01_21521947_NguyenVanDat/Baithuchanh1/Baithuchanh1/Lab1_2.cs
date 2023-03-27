using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baithuchanh1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int kqa1 = 0, kq1 = 0;
            int kqa2 = 0, kq2 = 0;
            int sot1 = Convert.ToInt32(s1.Text);
            int sot2 = Convert.ToInt32(s2.Text);
            int sot3 = Convert.ToInt32(s3.Text);
            kqa1 = Math.Max(sot1, sot2);
            kq1 = Math.Max(kqa1, sot3);
            kqa2 = Math.Min(sot1, sot2);
            kq2 = Math.Min(kqa2, sot3);
            this.kq1.Text = kq1.ToString();
            this.kq2.Text = kq2.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to delete?");
            this.s1.Clear();
            this.s2.Clear();
            this.s3.Clear();
            this.kq1.Clear();
            this.kq2.Clear();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to exit?");
            this.Close();
        }
    }
}
