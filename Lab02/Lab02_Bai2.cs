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
    public partial class Lab02_Bai2 : Form
    {
        public Lab02_Bai2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Print the content of a file to the richtextbox
                string text = File.ReadAllText(openFileDialog.FileName);
                richTextBox1.Text = text;
                //Get the name of the file
                string filePath = openFileDialog.FileName;
                filename.Text = openFileDialog.SafeFileName;
                //Get the path of the file
                FileInfo fileInfo = new FileInfo(filePath);
                long fileSizeInBytes = fileInfo.Length;
                size.Text = fileSizeInBytes.ToString();
                //Get the URL of the file
                Uri fileUri = new Uri(filePath);
                string fileUrl = fileUri.AbsoluteUri;
                url.Text = fileUrl.ToString();
                //Get the line count
                int lineCount = text.Split('\n').Length;

                // Get the word count
                int wordCount = text.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;

                // Get the character count
                int characterCount = text.Length;

                linecount.Text = lineCount.ToString();
                wordscount.Text = wordCount.ToString();
                characterscount.Text = characterCount.ToString();

            }

        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to exit?");
            this.Close();
        }
    }
}
