namespace KeyBoradEvent
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
            label1 = new Label();
            txtKeyUp = new TextBox();
            txtKeyDown = new TextBox();
            label2 = new Label();
            txtKeyPress = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 61);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "Sự kiện KeyUp";
            // 
            // txtKeyUp
            // 
            txtKeyUp.BackColor = Color.FromArgb(255, 192, 255);
            txtKeyUp.Location = new Point(196, 58);
            txtKeyUp.Name = "txtKeyUp";
            txtKeyUp.Size = new Size(125, 27);
            txtKeyUp.TabIndex = 1;
            txtKeyUp.KeyUp += txtKeyUp_KeyUp;
            // 
            // txtKeyDown
            // 
            txtKeyDown.BackColor = Color.FromArgb(192, 255, 255);
            txtKeyDown.Location = new Point(196, 120);
            txtKeyDown.Name = "txtKeyDown";
            txtKeyDown.Size = new Size(125, 27);
            txtKeyDown.TabIndex = 3;
            txtKeyDown.KeyDown += txtKeyDown_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 127);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 2;
            label2.Text = "Sự kiện KeyDown";
            // 
            // txtKeyPress
            // 
            txtKeyPress.BackColor = Color.FromArgb(255, 224, 192);
            txtKeyPress.Location = new Point(196, 182);
            txtKeyPress.Name = "txtKeyPress";
            txtKeyPress.Size = new Size(125, 27);
            txtKeyPress.TabIndex = 5;
            txtKeyPress.KeyPress += txtKeyPress_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 185);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 4;
            label3.Text = "Sự kiện KeyPress";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 289);
            Controls.Add(txtKeyPress);
            Controls.Add(label3);
            Controls.Add(txtKeyDown);
            Controls.Add(label2);
            Controls.Add(txtKeyUp);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKeyUp;
        private TextBox txtKeyDown;
        private Label label2;
        private TextBox txtKeyPress;
        private Label label3;
    }
}
