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
    public partial class FBill : Form
    {

        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=BAOLOC\SQLEXPRESS;Initial Catalog=XE;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public FBill()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "Select * From HOADONBANVE";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            DgvBill.DataSource = table;
        }
        private void FBill_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadData();
        }
        private void DgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            TbIdBill.ReadOnly = true;
            i = DgvBill.CurrentRow.Index;
            TbIdBill.Text = DgvBill.Rows[i].Cells[0].Value.ToString();
            TbIdCarB.Text = DgvBill.Rows[i].Cells[1].Value.ToString();
            TbIdCustomer.Text = DgvBill.Rows[i].Cells[2].Value.ToString();
            TbIdStaffB.Text = DgvBill.Rows[i].Cells[3].Value.ToString();
            TbIdTicketB.Text = DgvBill.Rows[i].Cells[4].Value.ToString();
            TbAmount.Text = DgvBill.Rows[i].Cells[5].Value.ToString();
            DtpDate.Text = DgvBill.Rows[i].Cells[6].Value.ToString();
            TbPrice.Text = DgvBill.Rows[i].Cells[7].Value.ToString();
        }

        private void BtAddB_Click(object sender, EventArgs e)
        {
            int Amo, Pri;
            Amo = int.Parse(TbAmount.Text);
            Pri = int.Parse(TbPrice.Text);
            try
            {
                if (TbIdBill.Text != "" && TbIdCarB.Text != "" && TbIdCustomer.Text != "" && TbIdStaffB.Text != "" && TbIdTicketB.Text != "" && Amo > 0 && DtpDate.Text != "" && Pri > 0)
                {
                    command = connection.CreateCommand();
                    command.CommandText = "Insert into HOADONBANVE values (@MaHDB, @MaSoXe, @MaKhach, @MaNhanVien, @MaSoVe, @SoLuong, @NgayLap, @DonGia)";
                    command.Parameters.AddWithValue("MaHDB", TbIdBill.Text);
                    command.Parameters.AddWithValue("MaSoXe", TbIdCarB.Text);
                    command.Parameters.AddWithValue("MaKhach", TbIdCustomer.Text);
                    command.Parameters.AddWithValue("MaNhanVien", TbIdStaffB.Text);
                    command.Parameters.AddWithValue("MaSoVe", TbIdTicketB.Text);
                    command.Parameters.AddWithValue("SoLuong", Amo);
                    command.Parameters.AddWithValue("NgayLap", DtpDate.Text);
                    command.Parameters.AddWithValue("DonGia", Pri);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!", "Thông Báo");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm dữ liệu: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtDeleteB_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "Delete From HOADONBANVE where MaHDB = '" + TbIdBill.Text + "'";
                command.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!", "Thông Báo");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtFixB_Click(object sender, EventArgs e)
        {
            int Amo, Pri;
            Amo = int.Parse(TbAmount.Text);
            Pri = int.Parse(TbPrice.Text);
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "Update HOADONBANVE set MaSoXe = @MaSoXe, MaKhach = @MaKhach, MaNhanVien = @MaNhanVien, MaSoVe = @MaSoVe, SoLuong = @SoLuong, NgayLap = @NgayLap, DonGia = @DonGia where MaHDB = @MaHDB";
                command.Parameters.AddWithValue("MaHDB", TbIdBill.Text);
                command.Parameters.AddWithValue("MaSoXe", TbIdCarB.Text);
                command.Parameters.AddWithValue("MaKhach", TbIdCustomer.Text);
                command.Parameters.AddWithValue("MaNhanVien", TbIdStaffB.Text);
                command.Parameters.AddWithValue("MaSoVe", TbIdTicketB.Text);
                command.Parameters.AddWithValue("SoLuong", Amo);
                command.Parameters.AddWithValue("NgayLap", DtpDate.Text);
                command.Parameters.AddWithValue("DonGia", Pri);
                command.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!", "Thông Báo");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtShowB_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtCreateB_Click(object sender, EventArgs e)
        {
            TbIdBill.ReadOnly = false;
            TbIdBill.Text = "";
            TbIdCarB.Text = "";
            TbIdCustomer.Text = "";
            TbIdStaffB.Text = "";
            TbIdTicketB.Text = "";
            TbAmount.Text = "";
            DtpDate.Text = "01/01/2019";
            TbPrice.Text = "";
        }

        private void BtSearchB_Click(object sender, EventArgs e)
        {
            if (!TbSearchB.Text.Equals(""))
            {
                command = connection.CreateCommand();
                command.CommandText = "Select * From HOADONBANVE where MaHDB like '%" + TbSearchB.Text + "%'";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                DgvBill.DataSource = table;
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
