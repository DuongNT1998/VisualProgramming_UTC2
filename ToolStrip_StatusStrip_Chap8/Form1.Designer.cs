namespace ToolStrip_Chap8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip = new ToolStrip();
            btnOpen = new ToolStripButton();
            btnSave = new ToolStripButton();
            dropDown = new ToolStripDropDownButton();
            optionAToolStripMenuItem = new ToolStripMenuItem();
            optionBToolStripMenuItem = new ToolStripMenuItem();
            optionCToolStripMenuItem = new ToolStripMenuItem();
            toolComboBox = new ToolStripComboBox();
            toolTextBox = new ToolStripTextBox();
            statusStrip = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            progressBar = new ToolStripProgressBar();
            splitButton = new ToolStripSplitButton();
            toolBToolStripMenuItem = new ToolStripMenuItem();
            toolAToolStripMenuItem = new ToolStripMenuItem();
            statusDropDown = new ToolStripDropDownButton();
            helpToolStripMenuItem = new ToolStripMenuItem();
            settingToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, btnOpen, btnSave, dropDown, toolComboBox, toolTextBox });
            toolStrip.Location = new Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(700, 28);
            toolStrip.TabIndex = 0;
            // 
            // btnOpen
            // 
            btnOpen.Image = (Image)resources.GetObject("btnOpen.Image");
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(69, 25);
            btnOpen.Text = "Open";
            btnOpen.Click += btnOpen_Click;
            // 
            // btnSave
            // 
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(64, 25);
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;

            // 
            // dropDown
            // 
            dropDown.DropDownItems.AddRange(new ToolStripItem[] { optionAToolStripMenuItem, optionBToolStripMenuItem, optionCToolStripMenuItem });
            dropDown.Name = "dropDown";
            dropDown.Size = new Size(75, 25);
            dropDown.Text = "Options";
            // 
            // optionAToolStripMenuItem
            // 
            optionAToolStripMenuItem.Name = "optionAToolStripMenuItem";
            optionAToolStripMenuItem.Size = new Size(224, 26);
            optionAToolStripMenuItem.Text = "Option A";
            optionAToolStripMenuItem.Click += dropDown_Click;

            // 
            // optionBToolStripMenuItem
            // 
            optionBToolStripMenuItem.Name = "optionBToolStripMenuItem";
            optionBToolStripMenuItem.Size = new Size(224, 26);
            optionBToolStripMenuItem.Text = "Option B";
            optionBToolStripMenuItem.Click += dropDown_Click;

            // 
            // optionCToolStripMenuItem
            // 
            optionCToolStripMenuItem.Name = "optionCToolStripMenuItem";
            optionCToolStripMenuItem.Size = new Size(224, 26);
            optionCToolStripMenuItem.Text = "Option C";
            optionCToolStripMenuItem.Click += dropDown_Click;

            // 
            // toolComboBox
            // 
            toolComboBox.Items.AddRange(new object[] { "Low", "Medium", "High" });
            toolComboBox.Name = "toolComboBox";
            toolComboBox.Size = new Size(121, 28);
            toolComboBox.SelectedIndexChanged += toolComboBox_SelectedIndexChanged;

            // 
            // toolTextBox
            // 
            toolTextBox.Name = "toolTextBox";
            toolTextBox.Size = new Size(100, 28);
            toolTextBox.ToolTipText = "Enter something";
            toolTextBox.KeyDown += toolTextBox_KeyDown;

            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblStatus, progressBar, splitButton, statusDropDown });
            statusStrip.Location = new Point(0, 370);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(700, 30);
            statusStrip.TabIndex = 1;
            // 
            // lblStatus
            // 
            lblStatus.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            lblStatus.BorderStyle = Border3DStyle.Sunken;
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(54, 24);
            lblStatus.Text = "Ready";
            // 
            // progressBar
            // 
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(100, 22);
            progressBar.Value = 50;
            // 
            // splitButton
            // 
            splitButton.DropDownItems.AddRange(new ToolStripItem[] { toolBToolStripMenuItem, toolAToolStripMenuItem });
            splitButton.Name = "splitButton";
            splitButton.Size = new Size(63, 28);
            splitButton.Text = "Tools";
            splitButton.ButtonClick += splitButton_ButtonClick;

            // 
            // toolBToolStripMenuItem
            // 
            toolBToolStripMenuItem.Name = "toolBToolStripMenuItem";
            toolBToolStripMenuItem.Size = new Size(224, 26);
            toolBToolStripMenuItem.Text = "Tool B";
            toolBToolStripMenuItem.Click += toolBToolStripMenuItem_Click;

            // 
            // toolAToolStripMenuItem
            // 
            toolAToolStripMenuItem.Name = "toolAToolStripMenuItem";
            toolAToolStripMenuItem.Size = new Size(224, 26);
            toolAToolStripMenuItem.Text = "Tool A";
            toolAToolStripMenuItem.Click += toolStripMenuItem1_Click;

            // 
            // statusDropDown
            // 
            statusDropDown.DropDownItems.AddRange(new ToolStripItem[] { helpToolStripMenuItem, settingToolStripMenuItem });
            statusDropDown.Name = "statusDropDown";
            statusDropDown.Size = new Size(60, 28);
            statusDropDown.Text = "Menu";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(139, 26);
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;

            // 
            // settingToolStripMenuItem
            // 
            settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            settingToolStripMenuItem.Size = new Size(139, 26);
            settingToolStripMenuItem.Text = "Setting";
            settingToolStripMenuItem.Click += settingToolStripMenuItem_Click;

            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 28);
            // 
            // Form1
            // 
            ClientSize = new Size(700, 400);
            Controls.Add(toolStrip);
            Controls.Add(statusStrip);
            Name = "Form1";
            Text = "ToolStrip + StatusStrip Demo";
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        // Khai báo controls
        private ToolStrip toolStrip;
        private ToolStripButton btnOpen;
        private ToolStripButton btnSave;
        private ToolStripDropDownButton dropDown;
        private ToolStripTextBox toolTextBox;
        private ToolStripComboBox toolComboBox;

        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblStatus;
        private ToolStripProgressBar progressBar;
        private ToolStripSplitButton splitButton;
        private ToolStripDropDownButton statusDropDown;

        private System.Windows.Forms.Timer timer;
       

    #endregion


    private ToolStripMenuItem toolBToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem settingToolStripMenuItem;
        private ToolStripMenuItem optionAToolStripMenuItem;
        private ToolStripMenuItem optionBToolStripMenuItem;
        private ToolStripMenuItem optionCToolStripMenuItem;
        private ToolStripMenuItem toolAToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
    }
}
