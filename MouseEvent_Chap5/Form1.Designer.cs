namespace MouseEvent_Chap5
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
            lbMouseClick = new Label();
            lbEnterHoverLeave = new Label();
            txtMouseDown = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtMouseUp = new TextBox();
            SuspendLayout();
            // 
            // lbMouseClick
            // 
            lbMouseClick.AutoSize = true;
            lbMouseClick.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lbMouseClick.Location = new Point(172, 9);
            lbMouseClick.Name = "lbMouseClick";
            lbMouseClick.Size = new Size(293, 41);
            lbMouseClick.TabIndex = 0;
            lbMouseClick.Text = "Sự kiện MouseClick";
            lbMouseClick.MouseClick += lbMouseClick_MouseClick;
            // 
            // lbEnterHoverLeave
            // 
            lbEnterHoverLeave.AutoSize = true;
            lbEnterHoverLeave.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lbEnterHoverLeave.Location = new Point(152, 100);
            lbEnterHoverLeave.Name = "lbEnterHoverLeave";
            lbEnterHoverLeave.Size = new Size(391, 41);
            lbEnterHoverLeave.TabIndex = 1;
            lbEnterHoverLeave.Text = "Sự kiện Enter-Hover-Leave";
            lbEnterHoverLeave.MouseEnter += lbEnterHoverLeave_MouseEnter;
            lbEnterHoverLeave.MouseLeave += lbEnterHoverLeave_MouseLeave;
            lbEnterHoverLeave.MouseHover += lbEnterHoverLeave_MouseHover;
            // 
            // txtMouseDown
            // 
            txtMouseDown.Location = new Point(340, 183);
            txtMouseDown.Name = "txtMouseDown";
            txtMouseDown.Size = new Size(125, 27);
            txtMouseDown.TabIndex = 2;
            txtMouseDown.MouseDown += txtMouseUpDown_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(68, 186);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 3;
            label1.Text = "Sự kiện MouseDown";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(68, 242);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 5;
            label2.Text = "Sự kiện MouseUp";
            // 
            // txtMouseUp
            // 
            txtMouseUp.Location = new Point(340, 239);
            txtMouseUp.Name = "txtMouseUp";
            txtMouseUp.Size = new Size(125, 27);
            txtMouseUp.TabIndex = 4;
            txtMouseUp.MouseUp += txtMouseUp_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 371);
            Controls.Add(label2);
            Controls.Add(txtMouseUp);
            Controls.Add(label1);
            Controls.Add(txtMouseDown);
            Controls.Add(lbEnterHoverLeave);
            Controls.Add(lbMouseClick);
            Name = "Form1";
            Text = "Form1";
            MouseMove += Form1_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMouseClick;
        private Label lbEnterHoverLeave;
        private TextBox txtMouseDown;
        private Label label1;
        private Label label2;
        private TextBox txtMouseUp;
    }
}
