namespace FormGiaoDien
{
    partial class FTicketRoad
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.BtSearchT = new System.Windows.Forms.Button();
            this.TbSearchT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbIdTicket = new System.Windows.Forms.TextBox();
            this.TbChair = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DgvTicket = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtCreateT = new System.Windows.Forms.Button();
            this.BtShowT = new System.Windows.Forms.Button();
            this.BtFixT = new System.Windows.Forms.Button();
            this.BtDeleteT = new System.Windows.Forms.Button();
            this.BtAddT = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DgvRoad = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtCreateR = new System.Windows.Forms.Button();
            this.BtShowR = new System.Windows.Forms.Button();
            this.BtFixR = new System.Windows.Forms.Button();
            this.BtDeleteR = new System.Windows.Forms.Button();
            this.BtAddR = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TbPlace1 = new System.Windows.Forms.TextBox();
            this.TbPlace2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtSearchR = new System.Windows.Forms.Button();
            this.TbSearchR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbIdRoad = new System.Windows.Forms.TextBox();
            this.TbLong = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTicket)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRoad)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1016, 535);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.DgvTicket);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1008, 506);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vé Xe";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::FormGiaoDien.Properties.Resources.pic1;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.BtSearchT);
            this.panel1.Controls.Add(this.TbSearchT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TbIdTicket);
            this.panel1.Controls.Add(this.TbChair);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 206);
            this.panel1.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(181, 167);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(173, 25);
            this.label14.TabIndex = 36;
            this.label14.Text = "Nhập mã cần tìm";
            // 
            // BtSearchT
            // 
            this.BtSearchT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtSearchT.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSearchT.Location = new System.Drawing.Point(671, 165);
            this.BtSearchT.Name = "BtSearchT";
            this.BtSearchT.Size = new System.Drawing.Size(79, 27);
            this.BtSearchT.TabIndex = 4;
            this.BtSearchT.Text = "Tìm";
            this.BtSearchT.UseVisualStyleBackColor = true;
            this.BtSearchT.Click += new System.EventHandler(this.BtSearch_Click);
            // 
            // TbSearchT
            // 
            this.TbSearchT.Location = new System.Drawing.Point(378, 165);
            this.TbSearchT.Name = "TbSearchT";
            this.TbSearchT.Size = new System.Drawing.Size(270, 22);
            this.TbSearchT.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 44);
            this.label1.TabIndex = 32;
            this.label1.Text = "VÉ XE KHÁCH";
            // 
            // TbIdTicket
            // 
            this.TbIdTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbIdTicket.Location = new System.Drawing.Point(181, 85);
            this.TbIdTicket.Name = "TbIdTicket";
            this.TbIdTicket.Size = new System.Drawing.Size(228, 27);
            this.TbIdTicket.TabIndex = 1;
            // 
            // TbChair
            // 
            this.TbChair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbChair.Location = new System.Drawing.Point(732, 85);
            this.TbChair.Name = "TbChair";
            this.TbChair.Size = new System.Drawing.Size(228, 27);
            this.TbChair.TabIndex = 2;
            this.TbChair.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(584, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "Số Ghế";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(33, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "Mã Số Vé";
            // 
            // DgvTicket
            // 
            this.DgvTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTicket.Location = new System.Drawing.Point(7, 295);
            this.DgvTicket.Name = "DgvTicket";
            this.DgvTicket.RowTemplate.Height = 24;
            this.DgvTicket.Size = new System.Drawing.Size(994, 205);
            this.DgvTicket.TabIndex = 4;
            this.DgvTicket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTicket_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::FormGiaoDien.Properties.Resources.pic1;
            this.panel3.Controls.Add(this.BtCreateT);
            this.panel3.Controls.Add(this.BtShowT);
            this.panel3.Controls.Add(this.BtFixT);
            this.panel3.Controls.Add(this.BtDeleteT);
            this.panel3.Controls.Add(this.BtAddT);
            this.panel3.Location = new System.Drawing.Point(7, 219);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(994, 69);
            this.panel3.TabIndex = 3;
            // 
            // BtCreateT
            // 
            this.BtCreateT.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCreateT.Location = new System.Drawing.Point(871, 6);
            this.BtCreateT.Name = "BtCreateT";
            this.BtCreateT.Size = new System.Drawing.Size(98, 58);
            this.BtCreateT.TabIndex = 9;
            this.BtCreateT.Text = "Tạo Mới";
            this.BtCreateT.UseVisualStyleBackColor = true;
            this.BtCreateT.Click += new System.EventHandler(this.BtCreateT_Click);
            // 
            // BtShowT
            // 
            this.BtShowT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtShowT.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtShowT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtShowT.Location = new System.Drawing.Point(663, 6);
            this.BtShowT.Name = "BtShowT";
            this.BtShowT.Size = new System.Drawing.Size(113, 60);
            this.BtShowT.TabIndex = 8;
            this.BtShowT.Text = "Hiển Thị Tất Cả";
            this.BtShowT.UseVisualStyleBackColor = true;
            this.BtShowT.Click += new System.EventHandler(this.BtShowT_Click);
            // 
            // BtFixT
            // 
            this.BtFixT.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtFixT.Image = global::FormGiaoDien.Properties.Resources.rsz_fix1;
            this.BtFixT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtFixT.Location = new System.Drawing.Point(465, 2);
            this.BtFixT.Name = "BtFixT";
            this.BtFixT.Size = new System.Drawing.Size(118, 62);
            this.BtFixT.TabIndex = 7;
            this.BtFixT.Text = "Sửa";
            this.BtFixT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtFixT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtFixT.UseVisualStyleBackColor = true;
            this.BtFixT.Click += new System.EventHandler(this.BtFixT_Click);
            // 
            // BtDeleteT
            // 
            this.BtDeleteT.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDeleteT.Image = global::FormGiaoDien.Properties.Resources.rsz_delete;
            this.BtDeleteT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtDeleteT.Location = new System.Drawing.Point(249, 3);
            this.BtDeleteT.Name = "BtDeleteT";
            this.BtDeleteT.Size = new System.Drawing.Size(128, 61);
            this.BtDeleteT.TabIndex = 6;
            this.BtDeleteT.Text = "Xóa";
            this.BtDeleteT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtDeleteT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtDeleteT.UseVisualStyleBackColor = true;
            this.BtDeleteT.Click += new System.EventHandler(this.BtDeleteT_Click);
            // 
            // BtAddT
            // 
            this.BtAddT.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAddT.Image = global::FormGiaoDien.Properties.Resources.rsz_add2;
            this.BtAddT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtAddT.Location = new System.Drawing.Point(29, 3);
            this.BtAddT.Name = "BtAddT";
            this.BtAddT.Size = new System.Drawing.Size(146, 61);
            this.BtAddT.TabIndex = 4;
            this.BtAddT.Text = "Thêm";
            this.BtAddT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtAddT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtAddT.UseVisualStyleBackColor = true;
            this.BtAddT.Click += new System.EventHandler(this.BtAddT_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DgvRoad);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1008, 506);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tuyến Xe";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DgvRoad
            // 
            this.DgvRoad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvRoad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRoad.Location = new System.Drawing.Point(4, 294);
            this.DgvRoad.Name = "DgvRoad";
            this.DgvRoad.RowTemplate.Height = 24;
            this.DgvRoad.Size = new System.Drawing.Size(996, 209);
            this.DgvRoad.TabIndex = 6;
            this.DgvRoad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRoad_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::FormGiaoDien.Properties.Resources.pic1;
            this.panel2.Controls.Add(this.BtCreateR);
            this.panel2.Controls.Add(this.BtShowR);
            this.panel2.Controls.Add(this.BtFixR);
            this.panel2.Controls.Add(this.BtDeleteR);
            this.panel2.Controls.Add(this.BtAddR);
            this.panel2.Location = new System.Drawing.Point(6, 218);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(994, 69);
            this.panel2.TabIndex = 5;
            // 
            // BtCreateR
            // 
            this.BtCreateR.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCreateR.Location = new System.Drawing.Point(871, 6);
            this.BtCreateR.Name = "BtCreateR";
            this.BtCreateR.Size = new System.Drawing.Size(98, 58);
            this.BtCreateR.TabIndex = 11;
            this.BtCreateR.Text = "Tạo Mới";
            this.BtCreateR.UseVisualStyleBackColor = true;
            this.BtCreateR.Click += new System.EventHandler(this.BtCreateR_Click);
            // 
            // BtShowR
            // 
            this.BtShowR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtShowR.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtShowR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtShowR.Location = new System.Drawing.Point(663, 6);
            this.BtShowR.Name = "BtShowR";
            this.BtShowR.Size = new System.Drawing.Size(113, 60);
            this.BtShowR.TabIndex = 10;
            this.BtShowR.Text = "Hiển Thị Tất Cả";
            this.BtShowR.UseVisualStyleBackColor = true;
            this.BtShowR.Click += new System.EventHandler(this.BtShowR_Click);
            // 
            // BtFixR
            // 
            this.BtFixR.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtFixR.Image = global::FormGiaoDien.Properties.Resources.rsz_fix1;
            this.BtFixR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtFixR.Location = new System.Drawing.Point(465, 2);
            this.BtFixR.Name = "BtFixR";
            this.BtFixR.Size = new System.Drawing.Size(118, 62);
            this.BtFixR.TabIndex = 9;
            this.BtFixR.Text = "Sửa";
            this.BtFixR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtFixR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtFixR.UseVisualStyleBackColor = true;
            this.BtFixR.Click += new System.EventHandler(this.BtFixR_Click);
            // 
            // BtDeleteR
            // 
            this.BtDeleteR.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDeleteR.Image = global::FormGiaoDien.Properties.Resources.rsz_delete;
            this.BtDeleteR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtDeleteR.Location = new System.Drawing.Point(249, 3);
            this.BtDeleteR.Name = "BtDeleteR";
            this.BtDeleteR.Size = new System.Drawing.Size(128, 61);
            this.BtDeleteR.TabIndex = 8;
            this.BtDeleteR.Text = "Xóa";
            this.BtDeleteR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtDeleteR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtDeleteR.UseVisualStyleBackColor = true;
            this.BtDeleteR.Click += new System.EventHandler(this.BtDeleteR_Click);
            // 
            // BtAddR
            // 
            this.BtAddR.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAddR.Image = global::FormGiaoDien.Properties.Resources.rsz_add2;
            this.BtAddR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtAddR.Location = new System.Drawing.Point(29, 3);
            this.BtAddR.Name = "BtAddR";
            this.BtAddR.Size = new System.Drawing.Size(146, 61);
            this.BtAddR.TabIndex = 7;
            this.BtAddR.Text = "Thêm";
            this.BtAddR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtAddR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtAddR.UseVisualStyleBackColor = true;
            this.BtAddR.Click += new System.EventHandler(this.BtAddR_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::FormGiaoDien.Properties.Resources.pic1;
            this.panel4.Controls.Add(this.TbPlace1);
            this.panel4.Controls.Add(this.TbPlace2);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.BtSearchR);
            this.panel4.Controls.Add(this.TbSearchR);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.TbIdRoad);
            this.panel4.Controls.Add(this.TbLong);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(994, 206);
            this.panel4.TabIndex = 4;
            // 
            // TbPlace1
            // 
            this.TbPlace1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPlace1.Location = new System.Drawing.Point(181, 119);
            this.TbPlace1.Name = "TbPlace1";
            this.TbPlace1.Size = new System.Drawing.Size(228, 27);
            this.TbPlace1.TabIndex = 3;
            // 
            // TbPlace2
            // 
            this.TbPlace2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPlace2.Location = new System.Drawing.Point(732, 119);
            this.TbPlace2.Name = "TbPlace2";
            this.TbPlace2.Size = new System.Drawing.Size(228, 27);
            this.TbPlace2.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(584, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 24);
            this.label8.TabIndex = 40;
            this.label8.Text = "Địa Điểm 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(33, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 24);
            this.label9.TabIndex = 39;
            this.label9.Text = "Địa Điểm 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Nhập mã cần tìm";
            // 
            // BtSearchR
            // 
            this.BtSearchR.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtSearchR.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSearchR.Location = new System.Drawing.Point(671, 165);
            this.BtSearchR.Name = "BtSearchR";
            this.BtSearchR.Size = new System.Drawing.Size(79, 27);
            this.BtSearchR.TabIndex = 6;
            this.BtSearchR.Text = "Tìm";
            this.BtSearchR.UseVisualStyleBackColor = true;
            this.BtSearchR.Click += new System.EventHandler(this.BtSearchR_Click);
            // 
            // TbSearchR
            // 
            this.TbSearchR.Location = new System.Drawing.Point(378, 165);
            this.TbSearchR.Name = "TbSearchR";
            this.TbSearchR.Size = new System.Drawing.Size(270, 22);
            this.TbSearchR.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(349, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 44);
            this.label3.TabIndex = 32;
            this.label3.Text = "CÁC TUYẾN XE";
            // 
            // TbIdRoad
            // 
            this.TbIdRoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbIdRoad.Location = new System.Drawing.Point(181, 57);
            this.TbIdRoad.Name = "TbIdRoad";
            this.TbIdRoad.Size = new System.Drawing.Size(228, 27);
            this.TbIdRoad.TabIndex = 1;
            // 
            // TbLong
            // 
            this.TbLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbLong.Location = new System.Drawing.Point(732, 57);
            this.TbLong.Name = "TbLong";
            this.TbLong.Size = new System.Drawing.Size(228, 27);
            this.TbLong.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(584, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 24);
            this.label12.TabIndex = 30;
            this.label12.Text = "Độ Dài";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(33, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 24);
            this.label7.TabIndex = 29;
            this.label7.Text = "Mã Số Tuyến";
            // 
            // FTicketRoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 560);
            this.Controls.Add(this.tabControl1);
            this.Name = "FTicketRoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Theo Dõi";
            this.Load += new System.EventHandler(this.FTicketRoad_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTicket)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvRoad)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtCreateT;
        private System.Windows.Forms.Button BtShowT;
        private System.Windows.Forms.Button BtFixT;
        private System.Windows.Forms.Button BtDeleteT;
        private System.Windows.Forms.Button BtAddT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbIdTicket;
        private System.Windows.Forms.TextBox TbChair;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DgvTicket;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button BtSearchT;
        private System.Windows.Forms.TextBox TbSearchT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtCreateR;
        private System.Windows.Forms.Button BtShowR;
        private System.Windows.Forms.Button BtFixR;
        private System.Windows.Forms.Button BtDeleteR;
        private System.Windows.Forms.Button BtAddR;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtSearchR;
        private System.Windows.Forms.TextBox TbSearchR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbIdRoad;
        private System.Windows.Forms.TextBox TbLong;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DgvRoad;
        private System.Windows.Forms.TextBox TbPlace1;
        private System.Windows.Forms.TextBox TbPlace2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}