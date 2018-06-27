using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            string[] ext = { ".png", ".jpg", ".gif", ".bmp", ".ico", ".tiff", ".jpeg" };
            if (ext.Contains(System.IO.Path.GetExtension(openFilePass.ToLower())))
            {
                files = new string[0];
                directoryname = "";
                filename = "";
                index = 0;
                System.Drawing.Bitmap bm = new System.Drawing.Bitmap(openFilePass);
                pictureBox1.Image = bm;
                directoryname = System.IO.Path.GetDirectoryName(openFilePass);
                filename = System.IO.Path.GetFileName(openFilePass);
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(directoryname);
                System.IO.FileInfo[] openfiles = di.GetFiles("*.*", System.IO.SearchOption.AllDirectories);
                foreach (System.IO.FileInfo f in openfiles)
                {
                    if (ext.Contains(System.IO.Path.GetExtension(f.FullName.ToLower())))
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
            else
            {
                MessageBox.Show("画像ファイルを選択してください。");
            }
        }

        private void Next()
        {

            if (files.Length != 0)
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
        }

        private void Back()
        {
            if (files.Length != 0)
            {
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
            }
        }

        private void Fullscreen(bool flag)
        {
            if (flag)
            {
                this.TopMost = true;
                this.TopMost = false;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                menuStrip1.Dock = DockStyle.None;
                メニューバー表示ToolStripMenuItem.Checked = false;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                menuStrip1.Dock = DockStyle.Top;
                メニューバー表示ToolStripMenuItem.Checked = true;
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
            Next();
        }

        private void フィットToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (フィットToolStripMenuItem.Checked)
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
                    Back();
                    break;

                case Keys.Right:
                case Keys.Down:
                    Next();
                    break;
                case Keys.F11:
                    if (this.FormBorderStyle == FormBorderStyle.None)
                    {
                        Fullscreen(false); //フルスクリーン解除
                    }
                    else
                    {
                        Fullscreen(true); //フルスクリーン
                    }
                    break;
                case Keys.Escape:
                    if (this.FormBorderStyle == FormBorderStyle.None)
                    {
                        Fullscreen(false); //フルスクリーン解除
                    }
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void 開くToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string openFilePass;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFilePass = openFileDialog1.FileName;
                Openfile(openFilePass);
            }
        }

        private void 進むToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Next();
        }

        private void 戻るToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void メニューバー非表示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.Dock = DockStyle.None;
            メニューバー表示ToolStripMenuItem.Checked = false;
        }

        private void メニューバー表示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (メニューバー表示ToolStripMenuItem.Checked)
            {
                menuStrip1.Dock = DockStyle.None;
                メニューバー表示ToolStripMenuItem.Checked = false;
            }
            else
            {
                menuStrip1.Dock = DockStyle.Top;
                メニューバー表示ToolStripMenuItem.Checked = true;
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Next();
            Next();
        }

        private void フルスクリーンSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.FormBorderStyle == FormBorderStyle.None)
            {
                Fullscreen(false); //フルスクリーン解除
                フルスクリーンSToolStripMenuItem.Checked = false;
                フルスクリーンToolStripMenuItem.Checked = false;
            }
            else
            {
                Fullscreen(true); //フルスクリーン
                フルスクリーンSToolStripMenuItem.Checked = true;
                フルスクリーンToolStripMenuItem.Checked = true;
            }
        }

        private void フルスクリーンToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.FormBorderStyle == FormBorderStyle.None)
            {
                Fullscreen(false); //フルスクリーン解除
                フルスクリーンSToolStripMenuItem.Checked = false;
                フルスクリーンToolStripMenuItem.Checked = false;
            }
            else
            {
                Fullscreen(true); //フルスクリーン
                フルスクリーンSToolStripMenuItem.Checked = true;
                フルスクリーンToolStripMenuItem.Checked = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Next();
            if (Convert.ToDouble(textBox1.Text) >= 0.001)
            {
                timer1.Interval = Convert.ToInt32(Convert.ToDouble(textBox1.Text) * 1000);
            }
            else
            {
                timer1.Enabled = !timer1.Enabled;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox1.Text) >= 0.001)
            {
                timer1.Interval = Convert.ToInt32(Convert.ToDouble(textBox1.Text) * 1000);
                timer1.Enabled = !timer1.Enabled;
            }
        }
    }
}
