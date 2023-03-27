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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void exchange_Click(object sender, EventArgs e)
        {
            string tygia1 = "";
            double sotien = Convert.ToInt32(input.Text);
            if (choose.SelectedIndex == 0) { sotien *= 22.772; }
            else if (choose.SelectedIndex == 1) { sotien *= 28.132; }
            else if (choose.SelectedIndex == 2) { sotien *= 31.538; }
            else if (choose.SelectedIndex == 3) { sotien *= 17.286; }
            else { sotien *= 214; }
            this.output.Text = sotien.ToString();
        }
    }
}
