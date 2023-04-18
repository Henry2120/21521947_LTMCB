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
using System.Runtime.Serialization.Formatters.Binary;
using static Lab02.Lab02_Bai4;

namespace Lab02
{
    public partial class Lab02_Bai4 : Form
    {
        public Lab02_Bai4()
        {
            InitializeComponent();
        }
        [Serializable]
        public class Student
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public string Phone { get; set; }
            public float Course1 { get; set; }
            public float Course2 { get; set; }
            public float Course3 { get; set; }
            public float DTB { get; set; }
            public override string ToString()
            {
                return Name + "\n" + ID + "\n" + Phone + "\n" + Course1 + "\n" + Course2 + "\n" + Course3 + "\n";
            }
        }
        List<Student> dsst = new List<Student>();


        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = txtName.Text;
            student.ID = txtID.Text;
            student.Phone = txtPhone.Text;
            student.Course1 = float.Parse(txtCourse1.Text);
            student.Course2 = float.Parse(txtCourse2.Text);
            student.Course3 = float.Parse(txtCourse3.Text);
            rtb.AppendText(student.ToString() + "\n");
            dsst.Add(student);
            txtName.Clear();
            txtID.Clear();
            txtPhone.Clear();
            txtCourse1.Clear();
            txtCourse2.Clear();
            txtCourse3.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            string path = fbd.SelectedPath + "\\input4.text";
            FileStream fs = new FileStream(path, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, dsst);
            fs.Close();
        }

        private void Writefile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            List<Student> sv = (List<Student>)bf.Deserialize(fs);
            rtb.Clear();
            foreach (Student svv in sv)
            {
                svv.DTB = (svv.Course1 + svv.Course2) / 2;
                rtb.AppendText(svv.ToString() + svv.DTB.ToString() + "\n\n");
            }
            fs.Close();
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            string path = fbd.SelectedPath + "\\output4.text";
            FileStream fsa = new FileStream(path, FileMode.Create);
            BinaryFormatter bfa = new BinaryFormatter();
            bf.Serialize(fsa, sv);
            fs.Close();
        }

    }
}
