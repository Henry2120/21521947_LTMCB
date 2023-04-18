using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab02_Bai1 b1 = new Lab02_Bai1();
            b1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab02_Bai2 b1 = new Lab02_Bai2();
            b1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab02_Bai3 b1 = new Lab02_Bai3();
            b1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab02_Bai4 b1 = new Lab02_Bai4();
            b1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lab02_Bai5 b1 = new Lab02_Bai5();
            b1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Lab02_Bai6 b1 = new Lab02_Bai6();
            b1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
