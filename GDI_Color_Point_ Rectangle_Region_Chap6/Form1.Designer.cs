namespace GDI_Color_Point__Rectangle_Region_Chap6
{
    partial class Form1
    {
//Vẽ hình chữ nhật với màu tùy chỉnh(Color).

//Sử dụng Point để xác định vị trí.

//Dùng Rectangle để xác định vùng hình học.

//Dùng Region để "cắt" hoặc "khoanh" một phần của form để tô màu.
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
            SuspendLayout();
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(582, 353);
            Name = "Form1";
            Text = "GDI+ Demo - Color, Point, Rectangle, Region";
            Paint += Form1_Paint;
            ResumeLayout(false);
        }

        #endregion
    }
}
