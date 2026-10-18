using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ADONet_CRUD_Chap91
{
    public partial class FormProduct : Form
    {
        private SqlConnection connection;
        private DataTable dataTable;
        public FormProduct()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=ProductManageDB;Integrated Security=True;TrustServerCertificate=True;");
            LoadCategoriesToComboBox();
            LoadProducts();
        }
        private void LoadCategoriesToComboBox()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Categories", this.connection);
            System.Data.DataTable table = new System.Data.DataTable();
            adapter.Fill(table);
            cboCategory.DataSource = table;
            cboCategory.DisplayMember = "Name";
            cboCategory.ValueMember = "id";
        }

        private void LoadProducts()
        {


            string query = "SELECT p.id, p.Name, p.FilePath, p.Price, p.Description, p.Storage, " +
                           "c.Name AS CategoryName, p.create_date, p.update_date " +
                           "FROM Product p INNER JOIN Categories c ON p.Category_id = c.id";

            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);

            // Tạo cột hình ảnh mới
            System.Data.DataTable dtWithImage = new System.Data.DataTable();
            dtWithImage.Columns.Add("id");
            dtWithImage.Columns.Add("Name");
            dtWithImage.Columns.Add("Image", typeof(System.Drawing.Image)); // Hình ảnh
            dtWithImage.Columns.Add("Price");
            dtWithImage.Columns.Add("Description");
            dtWithImage.Columns.Add("Storage");
            dtWithImage.Columns.Add("Category");
            dtWithImage.Columns.Add("create_date");
            dtWithImage.Columns.Add("update_date");


            foreach (System.Data.DataRow row in dt.Rows)
            {
                string imagePath = System.IO.Path.Combine("Content/images/Products", row["FilePath"].ToString());
                System.Drawing.Image img = null;

                if (System.IO.File.Exists(imagePath))
                {
                    using (System.IO.FileStream fs = new System.IO.FileStream(imagePath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                    {
                        img = System.Drawing.Image.FromStream(fs);
                    }
                }

                dtWithImage.Rows.Add(
                    row["id"],
                    row["Name"],
                    img,
                    row["Price"],
                    row["Description"],
                    row["Storage"],
                    row["CategoryName"],
                    row["create_date"],
                    row["update_date"]
                );
            }

            dgvProduct.Columns.Clear();
            dgvProduct.DataSource = dtWithImage;

            dgvProduct.RowTemplate.Height = 180; // hoặc hơn nếu ảnh lớn

            // Đặt lại kiểu hiển thị cho cột hình ảnh
            System.Windows.Forms.DataGridViewImageColumn imgCol = new System.Windows.Forms.DataGridViewImageColumn();
            imgCol = (System.Windows.Forms.DataGridViewImageColumn)dgvProduct.Columns["Image"];
            imgCol.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            imgCol.Width = 180;

            dgvProduct.Columns["id"].HeaderText = "ID";
            dgvProduct.Columns["Name"].HeaderText = "Tên SP";
            dgvProduct.Columns["Image"].HeaderText = "Hình ảnh";
            dgvProduct.Columns["Price"].HeaderText = "Giá";
            dgvProduct.Columns["Description"].HeaderText = "Mô tả";
            dgvProduct.Columns["Storage"].HeaderText = "Kho";
            dgvProduct.Columns["Category"].HeaderText = "Danh mục";
        }

        private string selectedImagePath = "";
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                selectedImagePath = ofd.FileName;
                picImage.Image = Image.FromFile(selectedImagePath);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedImagePath))
            {
                System.Windows.Forms.MessageBox.Show("Vui lòng chọn ảnh sản phẩm.");
                return;
            }

            string fileName = System.IO.Path.GetFileName(selectedImagePath);
            string targetPath = System.IO.Path.Combine("Content/images/Products", fileName);
            if (!System.IO.File.Exists(targetPath))
            {
                System.IO.File.Copy(selectedImagePath, targetPath);
            }


            connection.Open();
            string sql = "INSERT INTO Product (Name, FilePath, Price, Description, Storage, Category_id, create_date, update_date) " +
                         "VALUES (@Name, @FilePath, @Price, @Description, @Storage, @Category_id, @create_date, @update_date)";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@FilePath", fileName);
            cmd.Parameters.AddWithValue("@Price", System.Convert.ToDecimal(txtPrice.Text));
            cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
            cmd.Parameters.AddWithValue("@Storage", txtStorage.Text);
            cmd.Parameters.AddWithValue("@Category_id", cboCategory.SelectedValue);
            cmd.Parameters.AddWithValue("@create_date", System.DateTime.Now);
            cmd.Parameters.AddWithValue("@update_date", System.DateTime.Now);
            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Đã thêm sản phẩm thành công !");
            LoadProducts();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
       "Bạn có chắc chắn muốn cập nhật sản phẩm này?",
       "Xác nhận cập nhật",
        MessageBoxButtons.YesNo,
     MessageBoxIcon.Question
   );

            if (result == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            if (string.IsNullOrEmpty(txtId.Text))
            {
                System.Windows.Forms.MessageBox.Show("Vui lòng chọn sản phẩm cần cập nhật.");
                return;
            }

            string fileName = System.IO.Path.GetFileName(selectedImagePath);
            string targetPath = System.IO.Path.Combine("Content/images/Products", fileName);
            if (!System.IO.File.Exists(targetPath))
            {
                System.IO.File.Copy(selectedImagePath, targetPath);
            }


            connection.Open();
            string sql = "UPDATE Product SET Name=@Name, FilePath=@FilePath, Price=@Price, Description=@Description, Storage=@Storage, " +
                         "Category_id=@Category_id, update_date=@update_date WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@FilePath", fileName);
            cmd.Parameters.AddWithValue("@Price", System.Convert.ToDecimal(txtPrice.Text));
            cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
            cmd.Parameters.AddWithValue("@Storage", txtStorage.Text);
            cmd.Parameters.AddWithValue("@Category_id", cboCategory.SelectedValue);
            cmd.Parameters.AddWithValue("@update_date", System.DateTime.Now);
            cmd.Parameters.AddWithValue("@id", txtId.Text);
            cmd.ExecuteNonQuery();
            connection.Close();

            System.Windows.Forms.MessageBox.Show("Cập nhật thành công.");
            LoadProducts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
      "Bạn có chắc chắn muốn cập nhật sản phẩm này?",
      "Xác nhận cập nhật",
       MessageBoxButtons.YesNo,
    MessageBoxIcon.Question
  );

            if (result == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            if (string.IsNullOrEmpty(txtId.Text))
            {
                System.Windows.Forms.MessageBox.Show("Vui lòng chọn sản phẩm cần xoá.");
                return;
            }


            connection.Open();
            string sql = "DELETE FROM Product WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@id", txtId.Text);
            cmd.ExecuteNonQuery();
            connection.Close();

            System.Windows.Forms.MessageBox.Show("Đã xoá sản phẩm.");
            LoadProducts();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                System.Windows.Forms.DataGridViewRow row = dgvProduct.Rows[e.RowIndex];
                txtId.Text = row.Cells["id"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();
                txtStorage.Text = row.Cells["Storage"].Value.ToString();
                cboCategory.Text = row.Cells["Category"].Value.ToString(); // dùng text thay vì id

                // Lấy lại tên ảnh từ ảnh đang hiển thị nếu cần (nếu bạn cần giữ lại FilePath)
                // Hoặc lưu tên ảnh ở biến tạm trong DataTable

                picImage.Image = (System.Drawing.Image)row.Cells["Image"].Value;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword1 = txtName.Text.Trim();
            string keyword2 = cboCategory.Text.Trim();

            string query = "SELECT p.id, p.Name, p.FilePath, p.Price, p.Description, p.Storage, " +
                           "c.Name AS CategoryName, p.create_date, p.update_date " +
                           "FROM Product p INNER JOIN Categories c ON p.Category_id = c.id " +
                           "WHERE p.Name LIKE @keyword1 OR c.Name LIKE @keyword2";

          SqlDataAdapter da = new SqlDataAdapter(query, connection);
            da.SelectCommand.Parameters.AddWithValue("@keyword1", "%" + keyword1 + "%");
            da.SelectCommand.Parameters.AddWithValue("@keyword2", "%" + keyword2 + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);

            // Convert ảnh như trong LoadProducts()
            System.Data.DataTable dtWithImage = new System.Data.DataTable();
            dtWithImage.Columns.Add("id");
            dtWithImage.Columns.Add("Name");
            dtWithImage.Columns.Add("Image", typeof(System.Drawing.Image));
            dtWithImage.Columns.Add("Price");
            dtWithImage.Columns.Add("Description");
            dtWithImage.Columns.Add("Storage");
            dtWithImage.Columns.Add("Category");
            dtWithImage.Columns.Add("create_date");
            dtWithImage.Columns.Add("update_date");

            foreach (System.Data.DataRow row in dt.Rows)
            {
                string imagePath = System.IO.Path.Combine("Content/images/Products", row["FilePath"].ToString());
                System.Drawing.Image img = null;

                if (System.IO.File.Exists(imagePath))
                {
                    using (System.IO.FileStream fs = new System.IO.FileStream(imagePath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                    {
                        img = System.Drawing.Image.FromStream(fs);
                    }
                }

                dtWithImage.Rows.Add(
                    row["id"],
                    row["Name"],
                    img,
                    row["Price"],
                    row["Description"],
                    row["Storage"],
                    row["CategoryName"],
                    row["create_date"],
                    row["update_date"]
                );
            }

            dgvProduct.DataSource = dtWithImage;

            // Set layout lại
            ((System.Windows.Forms.DataGridViewImageColumn)dgvProduct.Columns["Image"]).ImageLayout =
                System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            dgvProduct.Columns["Image"].Width = 180;
            dgvProduct.RowTemplate.Height = 180;
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}
