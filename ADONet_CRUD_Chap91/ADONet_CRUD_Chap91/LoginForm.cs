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
    public partial class LoginForm : Form
    {

        public bool IsLoggedIn { get; set; } = false;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=localhost;Initial Catalog=ProductManageDB;Integrated Security=True;TrustServerCertificate=True;";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT COUNT(*) FROM [users] WHERE Username = @u AND Password = @p";
            cmd.Parameters.Add(new SqlParameter("@u", this.txtUsername.Text));
            cmd.Parameters.Add(new SqlParameter("@p", this.txtPassword.Text));

            int count = (int)cmd.ExecuteScalar();
            if (count == 1)
            {
                IsLoggedIn = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập!");
            }

            conn.Close();
        }
    }
}
