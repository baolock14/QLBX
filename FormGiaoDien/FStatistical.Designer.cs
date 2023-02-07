namespace FormGiaoDien
{
    partial class FStatistical
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sp_TKTicketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.XEDataSet = new FormGiaoDien.XEDataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.DtpTime2 = new System.Windows.Forms.DateTimePicker();
            this.DtpTime1 = new System.Windows.Forms.DateTimePicker();
            this.BtRp1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RpAmountTicket = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CbPlace2 = new System.Windows.Forms.ComboBox();
            this.CbPlace1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtRp2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RpAmountCar = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_TKTicketTableAdapter = new FormGiaoDien.XEDataSetTableAdapters.sp_TKTicketTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_TKTicketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XEDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sp_TKTicketBindingSource
            // 
            this.sp_TKTicketBindingSource.DataMember = "sp_TKTicket";
            this.sp_TKTicketBindingSource.DataSource = this.XEDataSet;
            // 
            // XEDataSet
            // 
            this.XEDataSet.DataSetName = "XEDataSet";
            this.XEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(991, 624);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.DtpTime2);
            this.tabPage1.Controls.Add(this.DtpTime1);
            this.tabPage1.Controls.Add(this.BtRp1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(983, 595);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Số lượng Vé";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(460, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "THỐNG KÊ SỐ LƯỢNG VÉ BÁN RA";
            // 
            // DtpTime2
            // 
            this.DtpTime2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpTime2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpTime2.Location = new System.Drawing.Point(677, 55);
            this.DtpTime2.Name = "DtpTime2";
            this.DtpTime2.Size = new System.Drawing.Size(200, 28);
            this.DtpTime2.TabIndex = 5;
            this.DtpTime2.Value = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            // 
            // DtpTime1
            // 
            this.DtpTime1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpTime1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpTime1.Location = new System.Drawing.Point(212, 55);
            this.DtpTime1.Name = "DtpTime1";
            this.DtpTime1.Size = new System.Drawing.Size(200, 28);
            this.DtpTime1.TabIndex = 4;
            this.DtpTime1.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // BtRp1
            // 
            this.BtRp1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRp1.Location = new System.Drawing.Point(423, 98);
            this.BtRp1.Name = "BtRp1";
            this.BtRp1.Size = new System.Drawing.Size(141, 42);
            this.BtRp1.TabIndex = 3;
            this.BtRp1.Text = "Tạo Báo Cáo";
            this.BtRp1.UseVisualStyleBackColor = true;
            this.BtRp1.Click += new System.EventHandler(this.BtRp1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(563, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến Ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ Ngày";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RpAmountTicket);
            this.panel1.Location = new System.Drawing.Point(4, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 443);
            this.panel1.TabIndex = 0;
            // 
            // RpAmountTicket
            // 
            this.RpAmountTicket.Location = new System.Drawing.Point(3, 4);
            this.RpAmountTicket.Name = "RpAmountTicket";
            this.RpAmountTicket.Size = new System.Drawing.Size(967, 436);
            this.RpAmountTicket.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CbPlace2);
            this.tabPage2.Controls.Add(this.CbPlace1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.BtRp2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(983, 595);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Số lượng Xe";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CbPlace2
            // 
            this.CbPlace2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbPlace2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbPlace2.FormattingEnabled = true;
            this.CbPlace2.Items.AddRange(new object[] {
            "Hue",
            "Da Nang",
            "Da Lat",
            "Quang Tri",
            "Dong Hoi ",
            "Binh My",
            "Gia Lam"});
            this.CbPlace2.Location = new System.Drawing.Point(669, 57);
            this.CbPlace2.Name = "CbPlace2";
            this.CbPlace2.Size = new System.Drawing.Size(163, 30);
            this.CbPlace2.TabIndex = 15;
            // 
            // CbPlace1
            // 
            this.CbPlace1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbPlace1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbPlace1.FormattingEnabled = true;
            this.CbPlace1.Items.AddRange(new object[] {
            "Hue",
            "Da Nang",
            "Da Lat",
            "Quang Tri",
            "Dong Hoi ",
            "Binh My",
            "Gia Lam"});
            this.CbPlace1.Location = new System.Drawing.Point(211, 57);
            this.CbPlace1.Name = "CbPlace1";
            this.CbPlace1.Size = new System.Drawing.Size(163, 30);
            this.CbPlace1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(233, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(516, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "THỐNG KÊ SỐ LƯỢNG XE MỖI TUYẾN";
            // 
            // BtRp2
            // 
            this.BtRp2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRp2.Location = new System.Drawing.Point(407, 99);
            this.BtRp2.Name = "BtRp2";
            this.BtRp2.Size = new System.Drawing.Size(147, 42);
            this.BtRp2.TabIndex = 10;
            this.BtRp2.Text = "Tạo Báo Cáo";
            this.BtRp2.UseVisualStyleBackColor = true;
            this.BtRp2.Click += new System.EventHandler(this.BtRp2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(566, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bến Đến";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(122, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Bến Đi";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RpAmountCar);
            this.panel2.Location = new System.Drawing.Point(5, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(972, 442);
            this.panel2.TabIndex = 7;
            // 
            // RpAmountCar
            // 
            this.RpAmountCar.Location = new System.Drawing.Point(4, 3);
            this.RpAmountCar.Name = "RpAmountCar";
            this.RpAmountCar.Size = new System.Drawing.Size(965, 436);
            this.RpAmountCar.TabIndex = 0;
            // 
            // sp_TKTicketTableAdapter
            // 
            this.sp_TKTicketTableAdapter.ClearBeforeFill = true;
            // 
            // FStatistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 649);
            this.Controls.Add(this.tabControl1);
            this.Name = "FStatistical";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_TKTicketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XEDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker DtpTime2;
        private System.Windows.Forms.DateTimePicker DtpTime1;
        private System.Windows.Forms.Button BtRp1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbPlace2;
        private System.Windows.Forms.ComboBox CbPlace1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtRp2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer RpAmountCar;
        private System.Windows.Forms.BindingSource sp_TKTicketBindingSource;
        private XEDataSet XEDataSet;
        private XEDataSetTableAdapters.sp_TKTicketTableAdapter sp_TKTicketTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer RpAmountTicket;
    }
}