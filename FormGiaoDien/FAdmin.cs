using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FormGiaoDien
{
    public partial class FAdmin : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=BAOLOC\SQLEXPRESS;Initial Catalog=XE;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public void LoadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "Select * From ACCOUNT";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            DgvAccount.DataSource = table;
        }
        public FAdmin()
        {
            InitializeComponent();
        }
        private void FAdmin_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadData();
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            TbAcc.ReadOnly = true;
            i = DgvAccount.CurrentRow.Index;
            TbAcc.Text = DgvAccount.Rows[i].Cells[0].Value.ToString();
            TbStaff.Text = DgvAccount.Rows[i].Cells[1].Value.ToString();
            TbPass.Text = DgvAccount.Rows[i].Cells[2].Value.ToString();
            TbQuyen.Text = DgvAccount.Rows[i].Cells[3].Value.ToString();
        }

        private void TbAddAcc_Click(object sender, EventArgs e)
        {
            if (TbAcc.Text != "" && TbStaff.Text != "" && TbPass.Text != "" && TbQuyen.Text != "" )
            {
                command = connection.CreateCommand();
                command.CommandText = "Insert into ACCOUNT values ('" + TbAcc.Text + "', '" + TbStaff.Text + "', '" + TbPass.Text + "','" + TbQuyen.Text + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!", "Thông Báo");
                LoadData();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TbDelAcc_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "Delete From ACCOUNT where TaiKhoan = '" +TbAcc.Text+ "'";
            command.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công!", "Thông Báo");
            LoadData();
        }

        private void BtResetPass_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "Update ACCOUNT set MatKhau = '" + TbPass.Text + "', TenNhanVien = '" + TbStaff.Text + "', Quyen = '" + TbQuyen.Text + "' where TaiKhoan = '" + TbAcc.Text + "'";
            command.ExecuteNonQuery();
            MessageBox.Show("Sửa thành công!", "Thông Báo");
            LoadData();
        }

        private void BtCreate_Click(object sender, EventArgs e)
        {
            TbAcc.ReadOnly = false;
            TbAcc.Text = "";
            TbStaff.Text = "";
            TbPass.Text = "";
            TbQuyen.Text = "";
        }
    }
}
