namespace MenuStrip_ContextMenu_Chap7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuFileNew = new ToolStripMenuItem();
            mnuFileOpen = new ToolStripMenuItem();
            mnuFileClose = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            mnuExit = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            otherToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            cntmnuRed = new ToolStripMenuItem();
            ctmnuBlue = new ToolStripMenuItem();
            ctmnuGreen = new ToolStripMenuItem();
            lbTestContextMenuStrip = new Label();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile, editToolStripMenuItem, otherToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(656, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuFileNew, mnuFileOpen, mnuFileClose, toolStripMenuItem1, mnuExit });
            mnuFile.Image = (Image)resources.GetObject("mnuFile.Image");
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(66, 24);
            mnuFile.Text = "File";
            // 
            // mnuFileNew
            // 
            mnuFileNew.Image = (Image)resources.GetObject("mnuFileNew.Image");
            mnuFileNew.Name = "mnuFileNew";
            mnuFileNew.ShortcutKeys = Keys.Control | Keys.N;
            mnuFileNew.Size = new Size(195, 26);
            mnuFileNew.Text = "New";
            // 
            // mnuFileOpen
            // 
            mnuFileOpen.Image = (Image)resources.GetObject("mnuFileOpen.Image");
            mnuFileOpen.Name = "mnuFileOpen";
            mnuFileOpen.ShortcutKeys = Keys.Control | Keys.O;
            mnuFileOpen.Size = new Size(195, 26);
            mnuFileOpen.Text = "Open";
            // 
            // mnuFileClose
            // 
            mnuFileClose.Image = (Image)resources.GetObject("mnuFileClose.Image");
            mnuFileClose.Name = "mnuFileClose";
            mnuFileClose.ShortcutKeys = Keys.Control | Keys.End;
            mnuFileClose.Size = new Size(195, 26);
            mnuFileClose.Text = "Close";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(192, 6);
            // 
            // mnuExit
            // 
            mnuExit.Image = (Image)resources.GetObject("mnuExit.Image");
            mnuExit.Name = "mnuExit";
            mnuExit.ShortcutKeys = Keys.Shift | Keys.F4;
            mnuExit.Size = new Size(195, 26);
            mnuExit.Text = "Exit";
            mnuExit.Click += mnuExit_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // otherToolStripMenuItem
            // 
            otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            otherToolStripMenuItem.Size = new Size(60, 24);
            otherToolStripMenuItem.Text = "Other";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { cntmnuRed, ctmnuBlue, ctmnuGreen });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(122, 82);
            // 
            // cntmnuRed
            // 
            cntmnuRed.Image = (Image)resources.GetObject("cntmnuRed.Image");
            cntmnuRed.Name = "cntmnuRed";
            cntmnuRed.Size = new Size(121, 26);
            cntmnuRed.Text = "Red";
            cntmnuRed.Click += cntmnuRed_Click;
            // 
            // ctmnuBlue
            // 
            ctmnuBlue.Image = (Image)resources.GetObject("ctmnuBlue.Image");
            ctmnuBlue.Name = "ctmnuBlue";
            ctmnuBlue.Size = new Size(121, 26);
            ctmnuBlue.Text = "Blue";
            ctmnuBlue.Click += ctmnuBlue_Click;
            // 
            // ctmnuGreen
            // 
            ctmnuGreen.Image = (Image)resources.GetObject("ctmnuGreen.Image");
            ctmnuGreen.Name = "ctmnuGreen";
            ctmnuGreen.Size = new Size(121, 26);
            ctmnuGreen.Text = "Green";
            ctmnuGreen.Click += ctmnuGreen_Click;
            // 
            // lbTestContextMenuStrip
            // 
            lbTestContextMenuStrip.AutoSize = true;
            lbTestContextMenuStrip.ContextMenuStrip = contextMenuStrip1;
            lbTestContextMenuStrip.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lbTestContextMenuStrip.Location = new Point(192, 105);
            lbTestContextMenuStrip.Name = "lbTestContextMenuStrip";
            lbTestContextMenuStrip.Size = new Size(288, 35);
            lbTestContextMenuStrip.TabIndex = 2;
            lbTestContextMenuStrip.Text = "Test ContextMenuStrip";
            lbTestContextMenuStrip.MouseHover += lbTestContextMenuStrip_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ContextMenuStrip = contextMenuStrip1;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(144, 225);
            label1.Name = "label1";
            label1.Size = new Size(392, 35);
            label1.TabIndex = 3;
            label1.Text = "Test Without ContextMenuStrip";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 348);
            Controls.Add(label1);
            Controls.Add(lbTestContextMenuStrip);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu & Menu Strip";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuFileNew;
        private ToolStripMenuItem mnuFileOpen;
        private ToolStripMenuItem mnuFileClose;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem otherToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem cntmnuRed;
        private ToolStripMenuItem ctmnuBlue;
        private ToolStripMenuItem ctmnuGreen;
        private Label lbTestContextMenuStrip;
        private Label label1;
        private ToolTip toolTip1;
    }
}
