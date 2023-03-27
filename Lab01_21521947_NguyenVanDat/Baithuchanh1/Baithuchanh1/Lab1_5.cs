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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            int sot1 = Convert.ToInt32(inpA.Text);
            int sot2 = Convert.ToInt32(inpB.Text);
            double kq1 = 1, kq2 = 1, kq3 = 0, kq4 = 0, kq5 = 0;
            for (int i = 1; i <= sot1; i++) { kq1 *= i; };
            for (int i = 1; i <= sot2; i++) { kq2 *= i; };
            for (int i = 1; i <= sot1; i++) { kq3 += i; };
            for (int i = 1; i <= sot2; i++) { kq4 += i; };
            for (int i = 1; i <= sot2; i++) { kq5 += Math.Pow(sot1, i); };
            this.out1.Text = kq1.ToString();
            this.out2.Text = kq2.ToString();
            this.out3.Text = kq3.ToString();
            this.out4.Text = kq4.ToString();
            this.out5.Text = kq5.ToString();

        }

        private void delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to delete?");
            this.inpA.Clear();
            this.inpB.Clear();
            this.out1.Clear();
            this.out2.Clear();
            this.out3.Clear();
            this.out4.Clear();
            this.out5.Clear();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to exit?");
            this.Close();
        }
    }
}
