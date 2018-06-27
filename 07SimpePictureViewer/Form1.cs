using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07SimpePictureViewer
{
    public partial class Form1 : Form
    {
        string[] files = new string[0];
        string directoryname = "";
        string filename = "";
        int index = 0;
        int MAX = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Openfile(string openFilePass)
        {
            int count = 0;
            if (System.IO.Path.GetExtension(openFilePass) != ".jpg" && System.IO.Path.GetExtension(openFilePass) != ".png")
            {
                MessageBox.Show("画像ファイルを選択してください。");
            }
            else
            {
                System.Drawing.Bitmap bm = new System.Drawing.Bitmap(openFilePass);
                pictureBox1.Image = bm;
                directoryname = System.IO.Path.GetDirectoryName(openFilePass);
                filename = System.IO.Path.GetFileName(openFilePass);
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(directoryname);
                System.IO.FileInfo[] openfiles = di.GetFiles("*.jpg", System.IO.SearchOption.AllDirectories);
                foreach (System.IO.FileInfo f in openfiles)
                {
                    if (f.FullName == openFilePass)
                    {
                        index = count;
                    }
                    Array.Resize(ref files, files.Length + 1);
                    files[count] = f.FullName;
                    count += 1;
                }
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string openFilePass;

            string[] DragDrop_files = (string[])e.Data.GetData(DataFormats.FileDrop);
            openFilePass = DragDrop_files[0];
            Openfile(openFilePass);
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string openFilePass;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFilePass = openFileDialog1.FileName;
                Openfile(openFilePass);
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            index += 1;
            if (files.Length > index)
            {
                pictureBox1.Image = new System.Drawing.Bitmap(files[index]);
            }
            else
            {
                index = 0;
                pictureBox1.Image = new System.Drawing.Bitmap(files[index]);
            }

        }

        private void フィットToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(フィットToolStripMenuItem.Checked)
            {
                フィットToolStripMenuItem.Checked = false;
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            else
            {
                フィットToolStripMenuItem.Checked = true;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

       

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //矢印キーが押されたことを表示する
                case Keys.Up:
                case Keys.Left:
                    index -= 1;
                    if (0 < index)
                    {
                        pictureBox1.Image = new System.Drawing.Bitmap(files[index]);
                    }
                    else
                    {
                        index = files.Length - 1;
                        pictureBox1.Image = new System.Drawing.Bitmap(files[index]);
                    }
                    break;

                case Keys.Right:
                case Keys.Down:
                    index += 1;
                    if (files.Length > index)
                    {
                        pictureBox1.Image = new System.Drawing.Bitmap(files[index]);
                    }
                    else
                    {
                        index = 0;
                        pictureBox1.Image = new System.Drawing.Bitmap(files[index]);
                    }
                    break;
                    
            }
        }
    }
}
