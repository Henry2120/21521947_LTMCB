using System;
using System.IO.Compression;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Lab02
{
    public partial class Lab02_Bai5 : Form
    {
        public Lab02_Bai5()
        {
            InitializeComponent();
        }
        private void CompressButton_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog opd = new OpenFileDialog();
                if (opd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = opd.FileName;
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Title = "Save the compressed file as";

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string outputFile = saveFileDialog1.FileName;
                        string compressionFormat = Path.GetExtension(outputFile).ToLower();

                        using (FileStream originalFileStream = new FileStream(filePath, FileMode.Open))
                        {
                            switch (compressionFormat)
                            {
                                case ".zip":
                                    using (FileStream compressedFileStream = File.Create(outputFile))
                                    using (ZipArchive archive = new ZipArchive(compressedFileStream, ZipArchiveMode.Create))
                                    {
                                        ZipArchiveEntry entry = archive.CreateEntry(Path.GetFileName(filePath));
                                        using (Stream uncompressedStream = entry.Open())
                                        {
                                            originalFileStream.CopyTo(uncompressedStream);
                                        }
                                    }
                                    break;
                                case ".gz":
                                    using (FileStream compressedFileStream = File.Create(outputFile))
                                    using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                                    {
                                        originalFileStream.CopyTo(compressionStream);
                                    }
                                    break;
                                default:
                                    MessageBox.Show("Invalid compression format specified.");
                                    return;
                            }
                            MessageBox.Show("File compression completed successfully.");
                        }
                    }
                }
            }
        }
    }
}
