namespace ADONet_CRUD_Chap91
{
    partial class FormProduct
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
        /// 
        private Label lblName;
        private TextBox txtName;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblDescription;
        private TextBox txtDescription;
        private Label lblStorage;
        private TextBox txtStorage;
        private Label lblCategory;
        private ComboBox cboCategory;
        private Label lblImage;
        private PictureBox picImage;
        private Button btnBrowse;
        private Label lblCreate;
        private DateTimePicker dtCreate;
        private Label lblUpdate;
        private DateTimePicker dtUpdate;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearch;
        private DataGridView dgvProduct;

        private void InitializeComponent()
        {
            lblName = new Label();
            txtName = new TextBox();
            lblPrice = new Label();
            txtPrice = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblStorage = new Label();
            txtStorage = new TextBox();
            lblCategory = new Label();
            cboCategory = new ComboBox();
            lblImage = new Label();
            picImage = new PictureBox();
            btnBrowse = new Button();
            lblCreate = new Label();
            dtCreate = new DateTimePicker();
            lblUpdate = new Label();
            dtUpdate = new DateTimePicker();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            dgvProduct = new DataGridView();
            label1 = new Label();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Location = new Point(20, 20);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 23);
            lblName.TabIndex = 0;
            lblName.Text = "Tên SP:";
            // 
            // txtName
            // 
            txtName.Location = new Point(120, 20);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 27);
            txtName.TabIndex = 1;
            // 
            // lblPrice
            // 
            lblPrice.Location = new Point(20, 60);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(100, 23);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Giá:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(120, 60);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 27);
            txtPrice.TabIndex = 3;
            // 
            // lblDescription
            // 
            lblDescription.Location = new Point(20, 100);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(100, 23);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Mô tả:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(120, 104);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(200, 60);
            txtDescription.TabIndex = 5;
            // 
            // lblStorage
            // 
            lblStorage.Location = new Point(464, 23);
            lblStorage.Name = "lblStorage";
            lblStorage.Size = new Size(100, 23);
            lblStorage.TabIndex = 6;
            lblStorage.Text = "Kho:";
            // 
            // txtStorage
            // 
            txtStorage.Location = new Point(570, 20);
            txtStorage.Name = "txtStorage";
            txtStorage.Size = new Size(100, 27);
            txtStorage.TabIndex = 7;
            // 
            // lblCategory
            // 
            lblCategory.Location = new Point(464, 73);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(100, 23);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "Danh mục:";
            // 
            // cboCategory
            // 
            cboCategory.Location = new Point(570, 73);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(244, 28);
            cboCategory.TabIndex = 9;
            // 
            // lblImage
            // 
            lblImage.Location = new Point(464, 122);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(100, 23);
            lblImage.TabIndex = 10;
            lblImage.Text = "Ảnh đại diện:";
            // 
            // picImage
            // 
            picImage.BorderStyle = BorderStyle.FixedSingle;
            picImage.Location = new Point(570, 122);
            picImage.Name = "picImage";
            picImage.Size = new Size(244, 100);
            picImage.TabIndex = 11;
            picImage.TabStop = false;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(481, 162);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(73, 38);
            btnBrowse.TabIndex = 12;
            btnBrowse.Text = "Chọn ảnh";
            btnBrowse.Click += btnBrowse_Click;
            // 
            // lblCreate
            // 
            lblCreate.Location = new Point(20, 199);
            lblCreate.Name = "lblCreate";
            lblCreate.Size = new Size(100, 23);
            lblCreate.TabIndex = 13;
            lblCreate.Text = "Ngày tạo:";
            // 
            // dtCreate
            // 
            dtCreate.Location = new Point(126, 199);
            dtCreate.Name = "dtCreate";
            dtCreate.Size = new Size(200, 27);
            dtCreate.TabIndex = 14;
            // 
            // lblUpdate
            // 
            lblUpdate.Location = new Point(20, 259);
            lblUpdate.Name = "lblUpdate";
            lblUpdate.Size = new Size(100, 23);
            lblUpdate.TabIndex = 15;
            lblUpdate.Text = "Ngày cập nhật:";
            // 
            // dtUpdate
            // 
            dtUpdate.Location = new Point(126, 259);
            dtUpdate.Name = "dtUpdate";
            dtUpdate.Size = new Size(200, 27);
            dtUpdate.TabIndex = 16;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(145, 329);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 33);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(290, 329);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(79, 33);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(452, 329);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(78, 33);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(626, 329);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(78, 33);
            btnSearch.TabIndex = 20;
            btnSearch.Text = "Tìm";
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeight = 29;
            dgvProduct.Location = new Point(20, 371);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(1036, 157);
            dgvProduct.TabIndex = 21;
            dgvProduct.CellClick += dgvProduct_CellClick;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(464, 258);
            label1.Name = "label1";
            label1.Size = new Size(118, 23);
            label1.TabIndex = 22;
            label1.Text = "Mã sản phẩm";
            // 
            // txtId
            // 
            txtId.Location = new Point(588, 255);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 27);
            txtId.TabIndex = 23;
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 540);
            Controls.Add(label1);
            Controls.Add(txtId);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblPrice);
            Controls.Add(txtPrice);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(lblStorage);
            Controls.Add(txtStorage);
            Controls.Add(lblCategory);
            Controls.Add(cboCategory);
            Controls.Add(lblImage);
            Controls.Add(picImage);
            Controls.Add(btnBrowse);
            Controls.Add(lblCreate);
            Controls.Add(dtCreate);
            Controls.Add(lblUpdate);
            Controls.Add(dtUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(dgvProduct);
            Name = "FormProduct";
            Text = "Sản phẩm";
            Load += FormProduct_Load;
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtId;
    }
}