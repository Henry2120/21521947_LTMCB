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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                int so1 = Convert.ToInt32(stn.Text);
                int so2 = Convert.ToInt32(sth.Text);
                int kq = so1 + so2;
                this.kq.Text = kq.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter an integer");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("You need to type a number");
            }
        }
    }
}
