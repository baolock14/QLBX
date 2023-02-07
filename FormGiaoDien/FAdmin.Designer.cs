namespace FormGiaoDien
{
    partial class FAdmin
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TbQuyen = new System.Windows.Forms.TextBox();
            this.TbStaff = new System.Windows.Forms.TextBox();
            this.TbDelAcc = new System.Windows.Forms.Button();
            this.TbAddAcc = new System.Windows.Forms.Button();
            this.TbPass = new System.Windows.Forms.TextBox();
            this.TbAcc = new System.Windows.Forms.TextBox();
            this.BtResetPass = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvAccount = new System.Windows.Forms.DataGridView();
            this.BtCreate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAccount)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(414, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Quyền ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(414, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tên Nhân Viên";
            // 
            // TbQuyen
            // 
            this.TbQuyen.Location = new System.Drawing.Point(578, 296);
            this.TbQuyen.Name = "TbQuyen";
            this.TbQuyen.Size = new System.Drawing.Size(199, 22);
            this.TbQuyen.TabIndex = 4;
            // 
            // TbStaff
            // 
            this.TbStaff.Location = new System.Drawing.Point(578, 238);
            this.TbStaff.Name = "TbStaff";
            this.TbStaff.Size = new System.Drawing.Size(199, 22);
            this.TbStaff.TabIndex = 3;
            // 
            // TbDelAcc
            // 
            this.TbDelAcc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbDelAcc.Location = new System.Drawing.Point(244, 354);
            this.TbDelAcc.Name = "TbDelAcc";
            this.TbDelAcc.Size = new System.Drawing.Size(113, 69);
            this.TbDelAcc.TabIndex = 6;
            this.TbDelAcc.Text = "Xóa Tài Khoản";
            this.TbDelAcc.UseVisualStyleBackColor = true;
            this.TbDelAcc.Click += new System.EventHandler(this.TbDelAcc_Click);
            // 
            // TbAddAcc
            // 
            this.TbAddAcc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbAddAcc.Location = new System.Drawing.Point(78, 354);
            this.TbAddAcc.Name = "TbAddAcc";
            this.TbAddAcc.Size = new System.Drawing.Size(110, 69);
            this.TbAddAcc.TabIndex = 5;
            this.TbAddAcc.Text = "Thêm Tài Khoản";
            this.TbAddAcc.UseVisualStyleBackColor = true;
            this.TbAddAcc.Click += new System.EventHandler(this.TbAddAcc_Click);
            // 
            // TbPass
            // 
            this.TbPass.Location = new System.Drawing.Point(181, 292);
            this.TbPass.Name = "TbPass";
            this.TbPass.Size = new System.Drawing.Size(189, 22);
            this.TbPass.TabIndex = 2;
            // 
            // TbAcc
            // 
            this.TbAcc.Location = new System.Drawing.Point(181, 235);
            this.TbAcc.Name = "TbAcc";
            this.TbAcc.Size = new System.Drawing.Size(189, 22);
            this.TbAcc.TabIndex = 1;
            // 
            // BtResetPass
            // 
            this.BtResetPass.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtResetPass.Location = new System.Drawing.Point(418, 354);
            this.BtResetPass.Name = "BtResetPass";
            this.BtResetPass.Size = new System.Drawing.Size(103, 69);
            this.BtResetPass.TabIndex = 7;
            this.BtResetPass.Text = "Sửa Tài Khoản";
            this.BtResetPass.UseVisualStyleBackColor = true;
            this.BtResetPass.Click += new System.EventHandler(this.BtResetPass_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Đăng Nhập";
            // 
            // DgvAccount
            // 
            this.DgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAccount.Location = new System.Drawing.Point(3, 3);
            this.DgvAccount.Name = "DgvAccount";
            this.DgvAccount.RowTemplate.Height = 24;
            this.DgvAccount.Size = new System.Drawing.Size(774, 207);
            this.DgvAccount.TabIndex = 0;
            this.DgvAccount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAccount_CellContentClick);
            // 
            // BtCreate
            // 
            this.BtCreate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCreate.Location = new System.Drawing.Point(578, 354);
            this.BtCreate.Name = "BtCreate";
            this.BtCreate.Size = new System.Drawing.Size(107, 69);
            this.BtCreate.TabIndex = 8;
            this.BtCreate.Text = "Tạo Mới";
            this.BtCreate.UseVisualStyleBackColor = true;
            this.BtCreate.Click += new System.EventHandler(this.BtCreate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtCreate);
            this.panel1.Controls.Add(this.DgvAccount);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TbQuyen);
            this.panel1.Controls.Add(this.BtResetPass);
            this.panel1.Controls.Add(this.TbStaff);
            this.panel1.Controls.Add(this.TbAcc);
            this.panel1.Controls.Add(this.TbDelAcc);
            this.panel1.Controls.Add(this.TbPass);
            this.panel1.Controls.Add(this.TbAddAcc);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 453);
            this.panel1.TabIndex = 1;
            // 
            // FAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 477);
            this.Controls.Add(this.panel1);
            this.Name = "FAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tài Khoản";
            this.Load += new System.EventHandler(this.FAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAccount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvAccount;
        private System.Windows.Forms.Button BtResetPass;
        private System.Windows.Forms.TextBox TbAcc;
        private System.Windows.Forms.TextBox TbPass;
        private System.Windows.Forms.Button TbDelAcc;
        private System.Windows.Forms.Button TbAddAcc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbQuyen;
        private System.Windows.Forms.TextBox TbStaff;
        private System.Windows.Forms.Button BtCreate;
        private System.Windows.Forms.Panel panel1;

    }
}