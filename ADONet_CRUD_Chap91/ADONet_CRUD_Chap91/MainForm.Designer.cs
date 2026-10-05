namespace ADONet_CRUD_Chap91
{
    partial class MainForm
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuItemCategory;
        private ToolStripMenuItem menuItemProduct;
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemProduct = new System.Windows.Forms.ToolStripMenuItem();
            SuspendLayout();
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCategory,
            this.menuItemProduct});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";

            this.menuItemCategory.Name = "menuItemCategory";
            this.menuItemCategory.Size = new System.Drawing.Size(90, 20);
            this.menuItemCategory.Text = "Danh mục SP";
            this.menuItemCategory.Click += new System.EventHandler(this.menuItemCategory_Click);

            this.menuItemProduct.Name = "menuItemProduct";
            this.menuItemProduct.Size = new System.Drawing.Size(80, 20);
            this.menuItemProduct.Text = "Sản phẩm";
            this.menuItemProduct.Click += new System.EventHandler(this.menuItemProduct_Click);
        
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            IsMdiContainer = true;
            Name = "MainForm";
            Text = "Quản lý bán hàng";
            Load += this.MainForm_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}
