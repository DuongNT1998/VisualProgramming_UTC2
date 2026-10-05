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
    public partial class FormCategory : Form
    {
        private SqlConnection connection;
        private DataTable dataTable;

        public FormCategory()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=ProductManageDB;Integrated Security=True;TrustServerCertificate=True;");
            LoadCategories();
        }

        private void LoadCategories()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Categories", this.connection);
            System.Data.DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dgvCategory.DataSource = dataSet.Tables[0];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = this.txtName.Text;
            string query = "INSERT INTO Categories(Name, create_date, update_date) VALUES(@Name, @CreateDate, @UpdateDate)";
            SqlCommand cmd = new SqlCommand(query, this.connection);
            cmd.Parameters.Add(new SqlParameter("@Name", name));
            System.DateTime now = System.DateTime.Now;
            cmd.Parameters.Add(new SqlParameter("@CreateDate", now));
            cmd.Parameters.Add(new SqlParameter("@UpdateDate", now));
            this.connection.Open();
            cmd.ExecuteNonQuery();
            this.connection.Close();
            this.LoadCategories();
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
            int id = System.Convert.ToInt32(this.txtID.Text);
            string name = this.txtName.Text;
            string query = "UPDATE Categories SET Name=@Name, update_date=@UpdateDate WHERE id=@ID";
            SqlCommand cmd = new SqlCommand(query, this.connection);
            cmd.Parameters.Add(new SqlParameter("@ID", id));
            cmd.Parameters.Add(new SqlParameter("@Name", name));
            cmd.Parameters.Add(new SqlParameter("@UpdateDate", System.DateTime.Now));
            this.connection.Open();
            cmd.ExecuteNonQuery();
            this.connection.Close();
            this.LoadCategories();
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
            int id = System.Convert.ToInt32(this.txtID.Text);
            string query = "DELETE FROM Categories WHERE id=@ID";
            SqlCommand cmd = new SqlCommand(query, this.connection);
            cmd.Parameters.Add(new SqlParameter("@ID", id));
            this.connection.Open();
            cmd.ExecuteNonQuery();
            this.connection.Close();
            this.LoadCategories();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = this.txtName.Text;
            string query = "SELECT * FROM Categories WHERE Name LIKE @Keyword";
            SqlDataAdapter adapter = new SqlDataAdapter(query, this.connection);
            adapter.SelectCommand.Parameters.Add(new SqlParameter("@Keyword", "%" + keyword + "%"));
            System.Data.DataSet dataSet = new System.Data.DataSet();
            adapter.Fill(dataSet);
            this.dgvCategory.DataSource = dataSet.Tables[0];
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                System.Windows.Forms.DataGridViewRow row = dgvCategory.Rows[e.RowIndex];

                // Lấy dữ liệu từ các cột của dòng được chọn
                txtID.Text = row.Cells["id"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();

                // Xử lý ngày giờ cho create_date và update_date
                System.DateTime createDate, updateDate;
                if (System.DateTime.TryParse(row.Cells["create_date"].Value.ToString(), out createDate))
                {
                    dtCreate.Value = createDate;
                }
                if (System.DateTime.TryParse(row.Cells["update_date"].Value.ToString(), out updateDate))
                {
                    dtUpdate.Value = updateDate;
                }
            }
        }
    }
}
