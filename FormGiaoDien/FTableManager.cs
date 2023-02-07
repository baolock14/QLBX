using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormGiaoDien
{
    public partial class FTableManager : Form
    {
        string TenDangNhap = "", TenNhanVien = "", MatKhau = "", Quyen = "";
        public FTableManager()
        {
            InitializeComponent();
        }
        public FTableManager(string TenDangNhap, string TenNhanVien, string MatKhau, string Quyen)
        {
            InitializeComponent();
            this.TenDangNhap = TenDangNhap;
            this.TenNhanVien = TenNhanVien;
            this.MatKhau = MatKhau;
            this.Quyen = Quyen;
        }

        private void FTableManager_Load(object sender, EventArgs e)
        {
            if (Quyen == "user")
            {
                AdminToolStripMenuItem.Enabled = false;
                hồSơToolStripMenuItem.Enabled = false;
                hóaĐơnToolStripMenuItem.Enabled = false;
            }
        }

        private void AdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAdmin f = new FAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void hồSơToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FManage f = new FManage();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FBill f = new FBill();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void theoDõiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FTicketRoad f = new FTicketRoad();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void StatisticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FStatistical f = new FStatistical();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
