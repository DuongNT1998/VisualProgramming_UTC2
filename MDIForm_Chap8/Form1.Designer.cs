namespace MDIForm_Chap8
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
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            mnuSpringForm = new ToolStripMenuItem();
            mnuSummerForm = new ToolStripMenuItem();
            mnuAutumnForm = new ToolStripMenuItem();
            mnuWinterForm = new ToolStripMenuItem();
            mnuExit = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            mnuCascadeLayout = new ToolStripMenuItem();
            mnuTileHorizontalLayout = new ToolStripMenuItem();
            mnuTileVerticalLayout = new ToolStripMenuItem();
            btnDangNhap = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, openToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { mnuSpringForm, mnuSummerForm, mnuAutumnForm, mnuWinterForm, mnuExit });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(46, 24);
            toolStripMenuItem1.Text = "File";
            // 
            // mnuSpringForm
            // 
            mnuSpringForm.Name = "mnuSpringForm";
            mnuSpringForm.Size = new Size(224, 26);
            mnuSpringForm.Text = "Spring Image";
            mnuSpringForm.Click += mnuSpringForm_Click;
            // 
            // mnuSummerForm
            // 
            mnuSummerForm.Name = "mnuSummerForm";
            mnuSummerForm.Size = new Size(224, 26);
            mnuSummerForm.Text = "Summer Image";
            mnuSummerForm.Click += mnuSummerForm_Click;
            // 
            // mnuAutumnForm
            // 
            mnuAutumnForm.Name = "mnuAutumnForm";
            mnuAutumnForm.Size = new Size(224, 26);
            mnuAutumnForm.Text = "Autumn Image";
            mnuAutumnForm.Click += mnuAutumnForm_Click;
            // 
            // mnuWinterForm
            // 
            mnuWinterForm.Name = "mnuWinterForm";
            mnuWinterForm.Size = new Size(224, 26);
            mnuWinterForm.Text = "Winter Image";
            mnuWinterForm.Click += mnuWinterForm_Click;
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(224, 26);
            mnuExit.Text = "Exit";
            mnuExit.Click += mnuExit_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuCascadeLayout, mnuTileHorizontalLayout, mnuTileVerticalLayout });
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(78, 24);
            openToolStripMenuItem.Text = "Window";
            // 
            // mnuCascadeLayout
            // 
            mnuCascadeLayout.Name = "mnuCascadeLayout";
            mnuCascadeLayout.Size = new Size(186, 26);
            mnuCascadeLayout.Text = "Cascade";
            mnuCascadeLayout.Click += mnuCascadeLayout_Click;
            // 
            // mnuTileHorizontalLayout
            // 
            mnuTileHorizontalLayout.Name = "mnuTileHorizontalLayout";
            mnuTileHorizontalLayout.Size = new Size(186, 26);
            mnuTileHorizontalLayout.Text = "TileHorizontal";
            mnuTileHorizontalLayout.Click += mnuTileHorizontalLayout_Click;
            // 
            // mnuTileVerticalLayout
            // 
            mnuTileVerticalLayout.Name = "mnuTileVerticalLayout";
            mnuTileVerticalLayout.Size = new Size(186, 26);
            mnuTileVerticalLayout.Text = "TileVertical";
            mnuTileVerticalLayout.Click += mnuTileVerticalLayout_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnDangNhap.ForeColor = SystemColors.Highlight;
            btnDangNhap.Location = new Point(328, 155);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(170, 77);
            btnDangNhap.TabIndex = 3;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDangNhap);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Main Form";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem mnuSpringForm;
        private ToolStripMenuItem mnuSummerForm;
        private ToolStripMenuItem mnuCascadeLayout;
        private ToolStripMenuItem mnuTileHorizontalLayout;
        private ToolStripMenuItem mnuTileVerticalLayout;
        private ToolStripMenuItem mnuAutumnForm;
        private ToolStripMenuItem mnuWinterForm;
        private ToolStripMenuItem mnuExit;
        private Button btnDangNhap;
    }
}
