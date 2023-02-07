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
    public partial class FManage : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=BAOLOC\SQLEXPRESS;Initial Catalog=XE;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        DataTable tb = new DataTable();
        DataTable tab = new DataTable();
        public void LoadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "Select * From NHANVIEN";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            DgvStaff.DataSource = table;

            command = connection.CreateCommand();
            command.CommandText = "Select * From CHUXE";
            adapter.SelectCommand = command;
            tb.Clear();
            adapter.Fill(tb);
            DgvDriver.DataSource = tb;

            command = connection.CreateCommand();
            command.CommandText = "Select * From XEOTO";
            adapter.SelectCommand = command;
            tab.Clear();
            adapter.Fill(tab);
            DgvCar.DataSource = tab;
        }

        public FManage()
        {
            InitializeComponent();
        }

        private void FManage_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadData();
        }

        //Hồ Sơ Nhân Viên
        private void DgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            TbIdStaff.ReadOnly = true;
            i = DgvStaff.CurrentRow.Index;
            TbIdStaff.Text = DgvStaff.Rows[i].Cells[0].Value.ToString();
            TbNameStaff.Text = DgvStaff.Rows[i].Cells[1].Value.ToString();
            CbSex.Text = DgvStaff.Rows[i].Cells[2].Value.ToString();
            DtpBirthday.Text = DgvStaff.Rows[i].Cells[3].Value.ToString();
            TbAddress.Text = DgvStaff.Rows[i].Cells[4].Value.ToString();
            TbPhone.Text = DgvStaff.Rows[i].Cells[5].Value.ToString();
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (TbIdStaff.Text != "" && TbNameStaff.Text != "" && CbSex.Text != "" && DtpBirthday.Text != "" && TbAddress.Text != "" && TbPhone.Text != "")
                {
                    command = connection.CreateCommand();
                    command.CommandText = "Insert into NHANVIEN values (@MaNhanVien, @TenNhanVien, @GioiTinh, @NgaySinh, @DiaChi, @SoDienThoai)";
                    command.Parameters.AddWithValue("MaNhanVien", TbIdStaff.Text);
                    command.Parameters.AddWithValue("TenNhanVien", TbNameStaff.Text);
                    command.Parameters.AddWithValue("GioiTinh", CbSex.Text);
                    command.Parameters.AddWithValue("NgaySinh", DtpBirthday.Text);
                    command.Parameters.AddWithValue("DiaChi", TbAddress.Text);
                    command.Parameters.AddWithValue("SoDienThoai", TbPhone.Text);
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

        private void BtDelete_Click(object sender, EventArgs e)
        {
            int valueRow = 0;
            command = connection.CreateCommand();
            command.CommandText = "Select MaNhanVien From HOADONBANVE where MaNhanVien = '" + TbIdStaff.Text + "'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            DgvStaff.DataSource = table;
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
                    command.CommandText = "Delete From NHANVIEN where MaNhanVien = '" + TbIdStaff.Text + "'";
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

        private void BtFix_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "Update NHANVIEN set TenNhanVien = @TenNhanVien, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, DiaChi = @DiaChi, SoDienThoai = @SoDienThoai where MaNhanVien = @MaNhanVien";
                command.Parameters.AddWithValue("MaNhanVien", TbIdStaff.Text);
                command.Parameters.AddWithValue("TenNhanVien", TbNameStaff.Text);
                command.Parameters.AddWithValue("GioiTinh", CbSex.Text);
                command.Parameters.AddWithValue("NgaySinh", DtpBirthday.Text);
                command.Parameters.AddWithValue("DiaChi", TbAddress.Text);
                command.Parameters.AddWithValue("SoDienThoai", TbPhone.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!", "Thông Báo");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa dữ liệu: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtSearch_Click(object sender, EventArgs e)
        {
            if (!TbSearch.Text.Equals(""))
            {
                command = connection.CreateCommand();
                command.CommandText = "Select * From NHANVIEN where MaNhanVien like '%" + TbSearch.Text + "%'";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                DgvStaff.DataSource = table;
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtShowStaff_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtCreateStaff_Click(object sender, EventArgs e)
        {
            TbIdStaff.ReadOnly = false;
            TbSearch.Text = "";
            TbIdStaff.Text = "";
            TbNameStaff.Text = "";
            CbSex.Text = "";
            DtpBirthday.Text = "01/01/1990";
            TbAddress.Text = "";
            TbPhone.Text = "";
        }

        //Hồ Sơ Chủ Xe
        private void DgvDriver_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            TbIdDriver.ReadOnly = true;
            i = DgvDriver.CurrentRow.Index;
            TbIdDriver.Text = DgvDriver.Rows[i].Cells[0].Value.ToString();
            TbDriverName.Text = DgvDriver.Rows[i].Cells[1].Value.ToString();
            TbIdCard.Text = DgvDriver.Rows[i].Cells[2].Value.ToString();
            TbAddressD.Text = DgvDriver.Rows[i].Cells[3].Value.ToString();
            TbPhoneD.Text = DgvDriver.Rows[i].Cells[4].Value.ToString();
        }

        private void BtAddD_Click(object sender, EventArgs e)
        {
            try
            {
                if (TbIdDriver.Text != "" && TbDriverName.Text != "" && TbIdCard.Text != "" && TbAddressD.Text != "" && TbPhoneD.Text != "")
                {
                    command = connection.CreateCommand();
                    command.CommandText = "Insert into CHUXE values (@MaChuXe, @TenChuXe, @SoCMT, @DiaChi, @DienThoai";
                    command.Parameters.AddWithValue("MaChuXe", TbIdDriver.Text);
                    command.Parameters.AddWithValue("TenChuXe", TbDriverName.Text);
                    command.Parameters.AddWithValue("SoCMT", TbIdCard.Text);
                    command.Parameters.AddWithValue("DiaChi", TbAddressD.Text);
                    command.Parameters.AddWithValue("DienThoai", TbPhoneD.Text);
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

        private void BtDeleteD_Click(object sender, EventArgs e)
        {
            int valueRow = 0;
            command = connection.CreateCommand();
            command.CommandText = "Select MaChuXe From XEOTO where MaChuXe = '" + TbIdDriver.Text + "'";
            adapter.SelectCommand = command;
            tb.Clear();
            adapter.Fill(tb);
            DgvDriver.DataSource = tb;
            valueRow = tb.Rows.Count;
            if (valueRow >= 1)
            {
                MessageBox.Show("Không thể xóa do vẫn còn XE trong hồ sơ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                try
                {
                    command = connection.CreateCommand();
                    command.CommandText = "Delete From CHUXE where MaChuXe = '" + TbIdDriver.Text + "'";
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

        private void BtFixD_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "Update CHUXE set TenChuXe = @TenChuXe, SoCMT = @SoCMT, DiaChi = @DiaChi, DienThoai = @DienThoai where MaChuXe = @MaChuXe";
                command.Parameters.AddWithValue("MaChuXe", TbIdDriver.Text);
                command.Parameters.AddWithValue("TenChuXe", TbDriverName.Text);
                command.Parameters.AddWithValue("SoCMT", TbIdCard.Text);
                command.Parameters.AddWithValue("DiaChi", TbAddressD.Text);
                command.Parameters.AddWithValue("DienThoai", TbPhoneD.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!", "Thông Báo");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa dữ liệu: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtSearchD_Click(object sender, EventArgs e)
        {
            if (!TbSearchD.Text.Equals(""))
            {
                command = connection.CreateCommand();
                command.CommandText = "Select * From CHUXE where MaChuXe like '%" + TbSearchD.Text + "%'";
                adapter.SelectCommand = command;
                tb.Clear();
                adapter.Fill(tb);
                DgvDriver.DataSource = tb;
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtShowD_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtCreateD_Click(object sender, EventArgs e)
        {
            TbIdDriver.ReadOnly = false;
            TbIdDriver.Text = "";
            TbDriverName.Text = "";
            TbIdCard.Text = "";
            TbAddressD.Text = "";
            TbPhoneD.Text = "";
        }

        //Hồ Sơ Xe
        private void DgvCar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            TbIdCar.ReadOnly = true;
            TbIdOwner.ReadOnly = true;
            i = DgvCar.CurrentRow.Index;
            TbIdCar.Text = DgvCar.Rows[i].Cells[0].Value.ToString();
            TbCarNumber.Text = DgvCar.Rows[i].Cells[1].Value.ToString();
            TbChairNumber.Text = DgvCar.Rows[i].Cells[2].Value.ToString();
            TbIdOwner.Text = DgvCar.Rows[i].Cells[3].Value.ToString();
            TbIdRoadC.Text = DgvCar.Rows[i].Cells[4].Value.ToString();
        }

        private void BtAddCar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TbIdCar.Text != "" && TbCarNumber.Text != "" && TbChairNumber.Text != "" && TbIdOwner.Text != "" && TbIdRoadC.Text != "")
                {
                    command = connection.CreateCommand(); 
                    command.CommandText = "Insert into XEOTO values (@MaSoXe, @BienSo, @SoGhe, @MaChuXe, @MaSoTuyen";
                    command.Parameters.AddWithValue("MaSoXe", TbIdDriver.Text);
                    command.Parameters.AddWithValue("BienSo", TbDriverName.Text);
                    command.Parameters.AddWithValue("SoGhe", TbIdCard.Text);
                    command.Parameters.AddWithValue("MaChuXe", TbAddressD.Text);
                    command.Parameters.AddWithValue("MaSoTuyen", TbPhoneD.Text);
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

        private void BtDelCar_Click(object sender, EventArgs e)
        {
            int valueRow = 0;
            command = connection.CreateCommand();
            command.CommandText = "Select MaSoXe From HOADONBANVE where MaSoXe = '" + TbIdCar.Text + "'";
            adapter.SelectCommand = command;
            tab.Clear();
            adapter.Fill(tab);
            DgvCar.DataSource = tab;
            valueRow = tab.Rows.Count;
            if (valueRow >= 1)
            {
                MessageBox.Show("Không thể xóa do dữ liệu còn trong HÓA ĐƠN BÁN VÉ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadData();
            }
            else
            {
                try
                {
                    command.CommandText = "Delete From XEOTO where MaSoXe = '" + TbIdCar.Text + "'";
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

        private void BtFixCar_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "Update XEOTO set BienSo = @BienSo, SoGhe = @SoGhe, MaChuXe = @MaChuXe, MaSoTuyen = @MaSoTuyen where MaSoXe = @MaSoXe";
                command.Parameters.AddWithValue("MaSoXe", TbIdDriver.Text);
                command.Parameters.AddWithValue("BienSo", TbDriverName.Text);
                command.Parameters.AddWithValue("SoGhe", TbIdCard.Text);
                command.Parameters.AddWithValue("MaChuXe", TbAddressD.Text);
                command.Parameters.AddWithValue("MaSoTuyen", TbPhoneD.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!", "Thông Báo");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa dữ liệu: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtSearchC_Click(object sender, EventArgs e)
        {
            if (!TbSearchC.Text.Equals(""))
            {
                command = connection.CreateCommand();
                command.CommandText = "Select * From XEOTO where MaSoXe like '%" + TbSearchC.Text + "%'";
                adapter.SelectCommand = command;
                tab.Clear();
                adapter.Fill(tab);
                DgvDriver.DataSource = tab;
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }    

        private void BtShowCar_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtCreateCar_Click(object sender, EventArgs e)
        {
            TbIdCar.ReadOnly = false;
            TbIdOwner.ReadOnly = false;
            TbIdCar.Text = "";
            TbCarNumber.Text = "";
            TbChairNumber.Text = "";
            TbIdOwner.Text = "";
            TbIdRoadC.Text = "";
        }
    }
}
