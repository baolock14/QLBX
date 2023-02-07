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
    public partial class FTicketRoad : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=BAOLOC\SQLEXPRESS;Initial Catalog=XE;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        DataTable tb = new DataTable();

        public void LoadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "Select * From VE";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            DgvTicket.DataSource = table;

            command = connection.CreateCommand();
            command.CommandText = "Select * From TUYEN";
            adapter.SelectCommand = command;
            tb.Clear();
            adapter.Fill(tb);
            DgvRoad.DataSource = tb;

        }
        public FTicketRoad()
        {
            InitializeComponent();
        }

        private void FTicketRoad_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadData();
        }

        //Vé Xe Khách
        private void DgvTicket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            TbIdTicket.ReadOnly = true;
            i = DgvTicket.CurrentRow.Index;
            TbIdTicket.Text = DgvTicket.Rows[i].Cells[0].Value.ToString();
            TbChair.Text = DgvTicket.Rows[i].Cells[1].Value.ToString();
        }

        private void BtAddT_Click(object sender, EventArgs e)
        {
            int num;
            num = int.Parse(TbChair.Text);
            try
            {
                if (TbIdTicket.Text != "" && num > 0)
                {
                    command = connection.CreateCommand();
                    command.CommandText = "Insert into VE values (@MaSoVe, @SoGhe)";
                    command.Parameters.AddWithValue("MaSoVe", TbIdTicket);
                    command.Parameters.AddWithValue("SoGhe", num);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!", "Thông Báo");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm dữ liệu: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtDeleteT_Click(object sender, EventArgs e)
        {
            int valueRow = 0;
            command = connection.CreateCommand();
            command.CommandText = "Select MaSoVe From HOADONBANVE where MaSoVe = '" + TbIdTicket.Text + "'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            DgvTicket.DataSource = table;
            valueRow = table.Rows.Count;
            if (valueRow >= 1)
            {
                MessageBox.Show("Không thể xóa do dữ liệu còn trong HÓA ĐƠN BÁN VÉ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                try
                {
                    command = connection.CreateCommand();
                    command.CommandText = "Delete From VE where MaSoVe = '" + TbIdTicket.Text + "'";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công!", "Thông Báo");
                    LoadData();
                }
                catch
                {
                    MessageBox.Show("Xóa dữ liệu thất bại!", "Thông Báo");
                }
            }
        }

        private void BtFixT_Click(object sender, EventArgs e)
        {
            try
            {
                int num;
                num = int.Parse(TbChair.Text);
                command = connection.CreateCommand();
                command.CommandText = "Update VE set SoGhe = @SoGhe where MaSoVe = @MaSoVe";
                command.Parameters.AddWithValue("MaSoVe", TbIdTicket.Text);
                command.Parameters.AddWithValue("SoGhe", num);
                command.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!", "Thông Báo");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa dữ liệu: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtShowT_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtCreateT_Click(object sender, EventArgs e)
        {
            TbIdTicket.ReadOnly = false;
            TbIdTicket.Text = "";
            TbChair.Text = "";
        }

        private void BtSearch_Click(object sender, EventArgs e)
        {
            if (!TbSearchT.Text.Equals(""))
            {
                command = connection.CreateCommand();
                command.CommandText = "Select * From VE where MaSoVe like '%" + TbSearchT.Text + "%'";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                DgvTicket.DataSource = table;
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Các Tuyến Xe
        private void DgvRoad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            TbIdRoad.ReadOnly = true;
            i = DgvRoad.CurrentRow.Index;
            TbIdRoad.Text = DgvRoad.Rows[i].Cells[0].Value.ToString();
            TbPlace1.Text = DgvRoad.Rows[i].Cells[1].Value.ToString();
            TbPlace2.Text = DgvRoad.Rows[i].Cells[2].Value.ToString();
            TbLong.Text = DgvRoad.Rows[i].Cells[3].Value.ToString();
        }

        private void BtAddR_Click(object sender, EventArgs e)
        {
            try
            {
                if (TbIdRoad.Text != "" && TbPlace1.Text != "" && TbPlace2.Text != "" && TbLong.Text != "")
                {
                    command = connection.CreateCommand();
                    command.CommandText = "Insert into TUYEN values (@MaSoTuyen, @DiaDiem1, @DiaDiem2, @DoDai)";
                    command.Parameters.AddWithValue("MaSoTuyen", TbIdRoad.Text);
                    command.Parameters.AddWithValue("DiaDiem1", TbPlace1.Text);
                    command.Parameters.AddWithValue("DiaDiem2", TbPlace2.Text);
                    command.Parameters.AddWithValue("DoDai", TbLong.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!", "Thông Báo");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm dữ liệu: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtDeleteR_Click(object sender, EventArgs e)
        {
            int valueRow = 0;
            command = connection.CreateCommand();
            command.CommandText = "Select MaSoTuyen From XEOTO where MaSoTuyen = '" + TbIdRoad.Text + "'";
            adapter.SelectCommand = command;
            tb.Clear();
            adapter.Fill(tb);
            DgvRoad.DataSource = tb;
            valueRow = tb.Rows.Count;
            if (valueRow >= 1)
            {
                MessageBox.Show("Không thể xóa do vẫn còn xe chạy trên TUYẾN!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                try
                {
                    command = connection.CreateCommand();
                    command.CommandText = "Delete From TUYEN where MaSoTuyen = '" + TbIdRoad.Text + "'";
                    command.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Xóa thành công!", "Thông Báo");
                }
                catch
                {
                    MessageBox.Show("Xóa dữ liệu thất bại!", "Thông Báo");
                }
            }
        }

        private void BtFixR_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "Update TUYEN set DiaDiem1 = @DiaDiem1, DiaDiem2 = @DiaDiem2, DoDai = @DoDai where MaSoTuyen = @MaSoTuyen";
                command.Parameters.AddWithValue("MaSoTuyen", TbIdRoad.Text);
                command.Parameters.AddWithValue("DiaDiem1", TbPlace1.Text);
                command.Parameters.AddWithValue("DiaDiem2", TbPlace2.Text);
                command.Parameters.AddWithValue("DoDai", TbLong.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!", "Thông Báo");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa dữ liệu: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtShowR_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtCreateR_Click(object sender, EventArgs e)
        {
            TbIdRoad.ReadOnly = false;
            TbIdRoad.Text = "";
            TbPlace1.Text = "";
            TbPlace2.Text = "";
            TbLong.Text = "";
        }

        private void BtSearchR_Click(object sender, EventArgs e)
        {
            if (!TbSearchR.Text.Equals(""))
            {
                command = connection.CreateCommand();
                command.CommandText = "Select * From TUYEN where MaSoTuyen like '%" + TbSearchR.Text + "%'";
                adapter.SelectCommand = command;
                tb.Clear();
                adapter.Fill(tb);
                DgvRoad.DataSource = tb;
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
