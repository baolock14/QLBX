namespace FormGiaoDien
{
    partial class FBill
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgvBill = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtCreateB = new System.Windows.Forms.Button();
            this.BtShowB = new System.Windows.Forms.Button();
            this.BtFixB = new System.Windows.Forms.Button();
            this.BtDeleteB = new System.Windows.Forms.Button();
            this.BtAddB = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.TbIdTicketB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.BtSearchB = new System.Windows.Forms.Button();
            this.TbSearchB = new System.Windows.Forms.TextBox();
            this.TbIdStaffB = new System.Windows.Forms.TextBox();
            this.TbPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TbIdCustomer = new System.Windows.Forms.TextBox();
            this.TbAmount = new System.Windows.Forms.TextBox();
            this.TbIdCarB = new System.Windows.Forms.TextBox();
            this.TbIdBill = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBill)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.DgvBill);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 689);
            this.panel1.TabIndex = 0;
            // 
            // DgvBill
            // 
            this.DgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBill.Location = new System.Drawing.Point(4, 421);
            this.DgvBill.Name = "DgvBill";
            this.DgvBill.RowTemplate.Height = 24;
            this.DgvBill.Size = new System.Drawing.Size(982, 265);
            this.DgvBill.TabIndex = 4;
            this.DgvBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBill_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::FormGiaoDien.Properties.Resources.image2;
            this.panel3.Controls.Add(this.BtCreateB);
            this.panel3.Controls.Add(this.BtShowB);
            this.panel3.Controls.Add(this.BtFixB);
            this.panel3.Controls.Add(this.BtDeleteB);
            this.panel3.Controls.Add(this.BtAddB);
            this.panel3.Location = new System.Drawing.Point(4, 345);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(982, 69);
            this.panel3.TabIndex = 3;
            // 
            // BtCreateB
            // 
            this.BtCreateB.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCreateB.Location = new System.Drawing.Point(860, 6);
            this.BtCreateB.Name = "BtCreateB";
            this.BtCreateB.Size = new System.Drawing.Size(98, 58);
            this.BtCreateB.TabIndex = 15;
            this.BtCreateB.Text = "Tạo Mới";
            this.BtCreateB.UseVisualStyleBackColor = true;
            this.BtCreateB.Click += new System.EventHandler(this.BtCreateB_Click);
            // 
            // BtShowB
            // 
            this.BtShowB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtShowB.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtShowB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtShowB.Location = new System.Drawing.Point(672, 4);
            this.BtShowB.Name = "BtShowB";
            this.BtShowB.Size = new System.Drawing.Size(113, 60);
            this.BtShowB.TabIndex = 14;
            this.BtShowB.Text = "Hiển Thị Tất Cả";
            this.BtShowB.UseVisualStyleBackColor = true;
            this.BtShowB.Click += new System.EventHandler(this.BtShowB_Click);
            // 
            // BtFixB
            // 
            this.BtFixB.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtFixB.Image = global::FormGiaoDien.Properties.Resources.rsz_fix1;
            this.BtFixB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtFixB.Location = new System.Drawing.Point(473, 4);
            this.BtFixB.Name = "BtFixB";
            this.BtFixB.Size = new System.Drawing.Size(118, 62);
            this.BtFixB.TabIndex = 13;
            this.BtFixB.Text = "Sửa";
            this.BtFixB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtFixB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtFixB.UseVisualStyleBackColor = true;
            this.BtFixB.Click += new System.EventHandler(this.BtFixB_Click);
            // 
            // BtDeleteB
            // 
            this.BtDeleteB.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDeleteB.Image = global::FormGiaoDien.Properties.Resources.rsz_delete;
            this.BtDeleteB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtDeleteB.Location = new System.Drawing.Point(253, 4);
            this.BtDeleteB.Name = "BtDeleteB";
            this.BtDeleteB.Size = new System.Drawing.Size(128, 61);
            this.BtDeleteB.TabIndex = 12;
            this.BtDeleteB.Text = "Xóa";
            this.BtDeleteB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtDeleteB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtDeleteB.UseVisualStyleBackColor = true;
            this.BtDeleteB.Click += new System.EventHandler(this.BtDeleteB_Click);
            // 
            // BtAddB
            // 
            this.BtAddB.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAddB.Image = global::FormGiaoDien.Properties.Resources.rsz_add2;
            this.BtAddB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtAddB.Location = new System.Drawing.Point(29, 3);
            this.BtAddB.Name = "BtAddB";
            this.BtAddB.Size = new System.Drawing.Size(146, 61);
            this.BtAddB.TabIndex = 11;
            this.BtAddB.Text = "Thêm";
            this.BtAddB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtAddB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtAddB.UseVisualStyleBackColor = true;
            this.BtAddB.Click += new System.EventHandler(this.BtAddB_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::FormGiaoDien.Properties.Resources.image2;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.DtpDate);
            this.panel2.Controls.Add(this.TbIdTicketB);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.BtSearchB);
            this.panel2.Controls.Add(this.TbSearchB);
            this.panel2.Controls.Add(this.TbIdStaffB);
            this.panel2.Controls.Add(this.TbPrice);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.TbIdCustomer);
            this.panel2.Controls.Add(this.TbAmount);
            this.panel2.Controls.Add(this.TbIdCarB);
            this.panel2.Controls.Add(this.TbIdBill);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 335);
            this.panel2.TabIndex = 0;
            // 
            // DtpDate
            // 
            this.DtpDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.DtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DtpDate.Location = new System.Drawing.Point(730, 177);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DtpDate.Size = new System.Drawing.Size(228, 27);
            this.DtpDate.TabIndex = 7;
            this.DtpDate.Value = new System.DateTime(2020, 8, 13, 0, 0, 0, 0);
            // 
            // TbIdTicketB
            // 
            this.TbIdTicketB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbIdTicketB.Location = new System.Drawing.Point(730, 69);
            this.TbIdTicketB.Name = "TbIdTicketB";
            this.TbIdTicketB.Size = new System.Drawing.Size(228, 27);
            this.TbIdTicketB.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label14.Location = new System.Drawing.Point(182, 301);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(173, 25);
            this.label14.TabIndex = 26;
            this.label14.Text = "Nhập mã cần tìm";
            // 
            // BtSearchB
            // 
            this.BtSearchB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtSearchB.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSearchB.Location = new System.Drawing.Point(672, 299);
            this.BtSearchB.Name = "BtSearchB";
            this.BtSearchB.Size = new System.Drawing.Size(79, 27);
            this.BtSearchB.TabIndex = 10;
            this.BtSearchB.Text = "Tìm";
            this.BtSearchB.UseVisualStyleBackColor = true;
            this.BtSearchB.Click += new System.EventHandler(this.BtSearchB_Click);
            // 
            // TbSearchB
            // 
            this.TbSearchB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbSearchB.Location = new System.Drawing.Point(379, 299);
            this.TbSearchB.Name = "TbSearchB";
            this.TbSearchB.Size = new System.Drawing.Size(270, 27);
            this.TbSearchB.TabIndex = 9;
            // 
            // TbIdStaffB
            // 
            this.TbIdStaffB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbIdStaffB.Location = new System.Drawing.Point(187, 232);
            this.TbIdStaffB.Name = "TbIdStaffB";
            this.TbIdStaffB.Size = new System.Drawing.Size(250, 27);
            this.TbIdStaffB.TabIndex = 4;
            // 
            // TbPrice
            // 
            this.TbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPrice.Location = new System.Drawing.Point(730, 229);
            this.TbPrice.Multiline = true;
            this.TbPrice.Name = "TbPrice";
            this.TbPrice.Size = new System.Drawing.Size(228, 25);
            this.TbPrice.TabIndex = 8;
            this.TbPrice.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.PeachPuff;
            this.label8.Location = new System.Drawing.Point(582, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "Đơn Giá";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.PeachPuff;
            this.label9.Location = new System.Drawing.Point(15, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "Mã Nhân Viên";
            // 
            // TbIdCustomer
            // 
            this.TbIdCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbIdCustomer.Location = new System.Drawing.Point(187, 177);
            this.TbIdCustomer.Name = "TbIdCustomer";
            this.TbIdCustomer.Size = new System.Drawing.Size(250, 27);
            this.TbIdCustomer.TabIndex = 3;
            // 
            // TbAmount
            // 
            this.TbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbAmount.Location = new System.Drawing.Point(730, 121);
            this.TbAmount.Name = "TbAmount";
            this.TbAmount.Size = new System.Drawing.Size(228, 27);
            this.TbAmount.TabIndex = 6;
            this.TbAmount.Text = "0";
            // 
            // TbIdCarB
            // 
            this.TbIdCarB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbIdCarB.Location = new System.Drawing.Point(187, 121);
            this.TbIdCarB.Name = "TbIdCarB";
            this.TbIdCarB.Size = new System.Drawing.Size(250, 27);
            this.TbIdCarB.TabIndex = 2;
            // 
            // TbIdBill
            // 
            this.TbIdBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbIdBill.Location = new System.Drawing.Point(187, 64);
            this.TbIdBill.Name = "TbIdBill";
            this.TbIdBill.Size = new System.Drawing.Size(254, 27);
            this.TbIdBill.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.PeachPuff;
            this.label6.Location = new System.Drawing.Point(582, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ngày Lập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.PeachPuff;
            this.label5.Location = new System.Drawing.Point(582, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Số Lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.PeachPuff;
            this.label4.Location = new System.Drawing.Point(582, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mã Số Vé";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.PeachPuff;
            this.label3.Location = new System.Drawing.Point(15, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mã Khách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PeachPuff;
            this.label2.Location = new System.Drawing.Point(15, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã Số Xe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.PeachPuff;
            this.label7.Location = new System.Drawing.Point(15, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Mã Hóa Đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(311, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN BÁN VÉ";
            // 
            // FBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1014, 714);
            this.Controls.Add(this.panel1);
            this.Name = "FBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.FBill_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBill)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbIdStaffB;
        private System.Windows.Forms.TextBox TbPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TbIdCustomer;
        private System.Windows.Forms.TextBox TbAmount;
        private System.Windows.Forms.TextBox TbIdCarB;
        private System.Windows.Forms.TextBox TbIdBill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button BtSearchB;
        private System.Windows.Forms.TextBox TbSearchB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtCreateB;
        private System.Windows.Forms.Button BtShowB;
        private System.Windows.Forms.Button BtFixB;
        private System.Windows.Forms.Button BtDeleteB;
        private System.Windows.Forms.Button BtAddB;
        private System.Windows.Forms.TextBox TbIdTicketB;
        private System.Windows.Forms.DataGridView DgvBill;
        private System.Windows.Forms.DateTimePicker DtpDate;
    }
}