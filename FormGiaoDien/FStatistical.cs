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
using Microsoft.Reporting.WinForms;

namespace FormGiaoDien
{
    public partial class FStatistical : Form
    {
        public FStatistical()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'XEDataSet.sp_TKTicket' table. You can move, or remove it, as needed.
            this.RpAmountCar.RefreshReport();
            this.RpAmountTicket.RefreshReport();
        }

        private void BtRp1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = Properties.Settings.Default.XEConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_TKTicket";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                cmd.Parameters.Add(new SqlParameter("@NgayLap1", DtpTime1.Value.Date));
                cmd.Parameters.Add(new SqlParameter("@NgayLap2", DtpTime2.Value.Date));
                DataSet ds = new DataSet();
                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                dap.Fill(ds);
                RpAmountTicket.ProcessingMode = ProcessingMode.Local;
                RpAmountTicket.LocalReport.ReportPath = "RpTicket.rdlc";
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "dsTicket";
                rds.Value = ds.Tables[0];
                RpAmountTicket.LocalReport.DataSources.Clear();
                RpAmountTicket.LocalReport.DataSources.Add(rds);
                RpAmountTicket.RefreshReport();
            }
            catch
            {
                MessageBox.Show("Lỗi khi tạo báo cáo!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtRp2_Click(object sender, EventArgs e)
        {
            try
            {
                if (CbPlace1.Text != null && CbPlace2 != null)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = Properties.Settings.Default.XEConnectionString;
                    SqlCommand Cmd = new SqlCommand();
                    Cmd.CommandText = "sp_TKCar";
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Connection = con;
                    Cmd.Parameters.Add(new SqlParameter("@DiaDiem1", CbPlace1.Text));
                    Cmd.Parameters.Add(new SqlParameter("@DiaDiem2", CbPlace2.Text));
                    DataSet ds = new DataSet();
                    SqlDataAdapter dap = new SqlDataAdapter(Cmd);
                    dap.Fill(ds);
                    RpAmountCar.ProcessingMode = ProcessingMode.Local;
                    RpAmountCar.LocalReport.ReportPath = "RpCar.rdlc";
                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "dsCar";
                    rds.Value = ds.Tables[0];
                    RpAmountCar.LocalReport.DataSources.Clear();
                    RpAmountCar.LocalReport.DataSources.Add(rds);
                    RpAmountCar.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Bạn chưa điền đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi khi tạo báo cáo!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
