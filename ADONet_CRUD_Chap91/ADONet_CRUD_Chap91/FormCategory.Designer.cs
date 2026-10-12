namespace ADONet_CRUD_Chap91
{
    partial class FormCategory
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
        private Label lblCreate;
        private DateTimePicker dtCreate;
        private Label lblUpdate;
        private DateTimePicker dtUpdate;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearch;
        private DataGridView dgvCategory;
        private void InitializeComponent()
        {
            lblName = new Label();
            txtName = new TextBox();
            lblCreate = new Label();
            dtCreate = new DateTimePicker();
            lblUpdate = new Label();
            dtUpdate = new DateTimePicker();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            dgvCategory = new DataGridView();
            label1 = new Label();
            txtID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Location = new Point(20, 20);
            lblName.Name = "lblName";
            lblName.Size = new Size(130, 23);
            lblName.TabIndex = 0;
            lblName.Text = "Tên danh mục:";
            // 
            // txtName
            // 
            txtName.Location = new Point(144, 20);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 27);
            txtName.TabIndex = 1;
            // 
            // lblCreate
            // 
            lblCreate.Location = new Point(20, 60);
            lblCreate.Name = "lblCreate";
            lblCreate.Size = new Size(100, 23);
            lblCreate.TabIndex = 2;
            lblCreate.Text = "Ngày tạo:";
            // 
            // dtCreate
            // 
            dtCreate.Location = new Point(144, 60);
            dtCreate.Name = "dtCreate";
            dtCreate.Size = new Size(200, 27);
            dtCreate.TabIndex = 3;
            // 
            // lblUpdate
            // 
            lblUpdate.Location = new Point(20, 100);
            lblUpdate.Name = "lblUpdate";
            lblUpdate.Size = new Size(100, 23);
            lblUpdate.TabIndex = 4;
            lblUpdate.Text = "Ngày cập nhật:";
            // 
            // dtUpdate
            // 
            dtUpdate.Location = new Point(144, 100);
            dtUpdate.Name = "dtUpdate";
            dtUpdate.Size = new Size(200, 27);
            dtUpdate.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(20, 140);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 45);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(119, 140);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(101, 45);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(240, 140);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(89, 45);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(362, 140);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(92, 45);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Tìm";
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvCategory
            // 
            dgvCategory.ColumnHeadersHeight = 29;
            dgvCategory.Location = new Point(20, 226);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.RowHeadersWidth = 51;
            dgvCategory.Size = new Size(580, 200);
            dgvCategory.TabIndex = 10;
            dgvCategory.CellClick += dgvCategory_CellClick;
            // 
            // label1
            // 
            label1.Location = new Point(377, 24);
            label1.Name = "label1";
            label1.Size = new Size(124, 23);
            label1.TabIndex = 11;
            label1.Text = "Mã số danh mục:";
            // 
            // txtID
            // 
            txtID.Location = new Point(513, 17);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(93, 27);
            txtID.TabIndex = 12;
            // 
            // FormCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 446);
            Controls.Add(label1);
            Controls.Add(txtID);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblCreate);
            Controls.Add(dtCreate);
            Controls.Add(lblUpdate);
            Controls.Add(dtUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(dgvCategory);
            Name = "FormCategory";
            Text = "Danh mục sản phẩm";
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtID;
    }
}