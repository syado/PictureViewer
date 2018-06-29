namespace _07SimpePictureViewer
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.開くToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.進むToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.戻るToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.メニューバー表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.フィットToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.メニューバー非表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開くToolStripMenuItem1,
            this.進むToolStripMenuItem,
            this.戻るToolStripMenuItem,
            this.メニューバー表示ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 92);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // 開くToolStripMenuItem1
            // 
            this.開くToolStripMenuItem1.Name = "開くToolStripMenuItem1";
            this.開くToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.開くToolStripMenuItem1.Text = "開く(&O)";
            this.開くToolStripMenuItem1.Click += new System.EventHandler(this.開くToolStripMenuItem1_Click);
            // 
            // 進むToolStripMenuItem
            // 
            this.進むToolStripMenuItem.Name = "進むToolStripMenuItem";
            this.進むToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.進むToolStripMenuItem.Text = "進む(N)";
            this.進むToolStripMenuItem.Click += new System.EventHandler(this.進むToolStripMenuItem_Click);
            // 
            // 戻るToolStripMenuItem
            // 
            this.戻るToolStripMenuItem.Name = "戻るToolStripMenuItem";
            this.戻るToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.戻るToolStripMenuItem.Text = "戻る(&B)";
            this.戻るToolStripMenuItem.Click += new System.EventHandler(this.戻るToolStripMenuItem_Click);
            // 
            // メニューバー表示ToolStripMenuItem
            // 
            this.メニューバー表示ToolStripMenuItem.Checked = true;
            this.メニューバー表示ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.メニューバー表示ToolStripMenuItem.Name = "メニューバー表示ToolStripMenuItem";
            this.メニューバー表示ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.メニューバー表示ToolStripMenuItem.Text = "メニューバー表示(&M)";
            this.メニューバー表示ToolStripMenuItem.Click += new System.EventHandler(this.メニューバー表示ToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.表示ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開くToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.開くToolStripMenuItem.Text = "開く(&O)";
            this.開くToolStripMenuItem.Click += new System.EventHandler(this.開くToolStripMenuItem_Click);
            // 
            // 表示ToolStripMenuItem
            // 
            this.表示ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.フィットToolStripMenuItem,
            this.メニューバー非表示ToolStripMenuItem});
            this.表示ToolStripMenuItem.Name = "表示ToolStripMenuItem";
            this.表示ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.表示ToolStripMenuItem.Text = "表示";
            // 
            // フィットToolStripMenuItem
            // 
            this.フィットToolStripMenuItem.Checked = true;
            this.フィットToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.フィットToolStripMenuItem.Name = "フィットToolStripMenuItem";
            this.フィットToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.フィットToolStripMenuItem.Text = "フィット(&F)";
            this.フィットToolStripMenuItem.Click += new System.EventHandler(this.フィットToolStripMenuItem_Click);
            // 
            // メニューバー非表示ToolStripMenuItem
            // 
            this.メニューバー非表示ToolStripMenuItem.Name = "メニューバー非表示ToolStripMenuItem";
            this.メニューバー非表示ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.メニューバー非表示ToolStripMenuItem.Text = "メニューバー非表示(&M)";
            this.メニューバー非表示ToolStripMenuItem.Click += new System.EventHandler(this.メニューバー非表示ToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 表示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem フィットToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 進むToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 戻るToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem メニューバー表示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem メニューバー非表示ToolStripMenuItem;
    }
}

