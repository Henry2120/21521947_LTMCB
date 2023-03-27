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
    public partial class Lab1_3 : Form
    {
        public Lab1_3()
        {
            InitializeComponent();
        }


        private void read_Click(object sender, EventArgs e)
        {
            string kq = "";
            int so = Convert.ToInt32(input.Text);
            switch (so)
            {
                case 0:
                    kq = "Khong";
                    break;
                case 1:
                    kq = "Mot";
                    break;
                case 2:
                    kq = "Hai";
                    break;
                case 3:
                    kq = "Ba";
                    break;
                case 4:
                    kq = "Bon";
                    break;
                case 5:
                    kq = "Nam";
                    break;
                case 6:
                    kq = "Sau";
                    break;
                case 7:
                    kq = "Bay";
                    break;
                case 8:
                    kq = "Tam";
                    break;
                case 9:
                    kq = "Chin";
                    break;
            }
            this.kq1.Text = kq;
        }
        private void delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to delete?");
            this.input.Clear();
            this.kq1.Clear();
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to exit?");
            this.Close();
        }

    }
}
