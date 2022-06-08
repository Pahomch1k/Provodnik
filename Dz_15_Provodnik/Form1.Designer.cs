
namespace Dz_15_Provodnik
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.большиеЗначкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маленькиеЗначкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.темнаяТемаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.светлаяТемаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 24);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(327, 547);
            this.treeView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem5});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 20);
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(28, 20);
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(28, 20);
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.большиеЗначкиToolStripMenuItem,
            this.маленькиеЗначкиToolStripMenuItem,
            this.темнаяТемаToolStripMenuItem,
            this.светлаяТемаToolStripMenuItem});
            this.toolStripMenuItem5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem5.Image")));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(28, 20);
            // 
            // большиеЗначкиToolStripMenuItem
            // 
            this.большиеЗначкиToolStripMenuItem.Name = "большиеЗначкиToolStripMenuItem";
            this.большиеЗначкиToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.большиеЗначкиToolStripMenuItem.Text = "Большие значки";
            this.большиеЗначкиToolStripMenuItem.Click += new System.EventHandler(this.большиеЗначкиToolStripMenuItem_Click);
            // 
            // маленькиеЗначкиToolStripMenuItem
            // 
            this.маленькиеЗначкиToolStripMenuItem.Name = "маленькиеЗначкиToolStripMenuItem";
            this.маленькиеЗначкиToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.маленькиеЗначкиToolStripMenuItem.Text = "Маленькие значки";
            this.маленькиеЗначкиToolStripMenuItem.Click += new System.EventHandler(this.маленькиеЗначкиToolStripMenuItem_Click);
            // 
            // темнаяТемаToolStripMenuItem
            // 
            this.темнаяТемаToolStripMenuItem.Name = "темнаяТемаToolStripMenuItem";
            this.темнаяТемаToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.темнаяТемаToolStripMenuItem.Text = "Темная тема";
            this.темнаяТемаToolStripMenuItem.Click += new System.EventHandler(this.темнаяТемаToolStripMenuItem_Click);
            // 
            // светлаяТемаToolStripMenuItem
            // 
            this.светлаяТемаToolStripMenuItem.Name = "светлаяТемаToolStripMenuItem";
            this.светлаяТемаToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.светлаяТемаToolStripMenuItem.Text = "Светлая тема";
            this.светлаяТемаToolStripMenuItem.Click += new System.EventHandler(this.светлаяТемаToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(333, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(641, 547);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Значок в области уведомлений";
            this.notifyIcon1.BalloonTipTitle = "Системный трэй";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Значок в области уведомлений";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 571);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem большиеЗначкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маленькиеЗначкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem темнаяТемаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem светлаяТемаToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

