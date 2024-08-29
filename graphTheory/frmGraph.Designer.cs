namespace graphTheory
{
    partial class frmGraph
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGraph));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMatran = new System.Windows.Forms.TextBox();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.pnlVeDoThi = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDuyet = new FontAwesome.Sharp.IconButton();
            this.btnLamMoi = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxChucNang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxLoaiDoThi = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxCachDuyet = new System.Windows.Forms.ComboBox();
            this.pnlFS = new System.Windows.Forms.Panel();
            this.cboDinhKT = new System.Windows.Forms.ComboBox();
            this.cboBD = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlCachDuyet = new System.Windows.Forms.Panel();
            this.txtTrongSo = new System.Windows.Forms.TextBox();
            this.labTrongSo = new System.Windows.Forms.Label();
            this.btnXacNhan = new FontAwesome.Sharp.IconButton();
            this.btnXoaDinh = new FontAwesome.Sharp.IconButton();
            this.btnXoaCanh = new FontAwesome.Sharp.IconButton();
            this.btnThemCanh = new FontAwesome.Sharp.IconButton();
            this.btnThemDinh = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelClickSukien = new System.Windows.Forms.Panel();
            this.pnlCayKhung = new System.Windows.Forms.Panel();
            this.cboCayKhung = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtxtMaGia = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlFS.SuspendLayout();
            this.pnlCachDuyet.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelClickSukien.SuspendLayout();
            this.pnlCayKhung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox1.Controls.Add(this.txtMatran);
            this.groupBox1.Controls.Add(this.txtKetqua);
            this.groupBox1.Location = new System.Drawing.Point(7, 618);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1875, 186);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Báo";
            // 
            // txtMatran
            // 
            this.txtMatran.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatran.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatran.Location = new System.Drawing.Point(1581, 21);
            this.txtMatran.Multiline = true;
            this.txtMatran.Name = "txtMatran";
            this.txtMatran.ReadOnly = true;
            this.txtMatran.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMatran.Size = new System.Drawing.Size(288, 154);
            this.txtMatran.TabIndex = 3;
            this.txtMatran.Text = "Ma Trận Tạo Thành";
            // 
            // txtKetqua
            // 
            this.txtKetqua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKetqua.BackColor = System.Drawing.SystemColors.Control;
            this.txtKetqua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetqua.Location = new System.Drawing.Point(13, 23);
            this.txtKetqua.Multiline = true;
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.ReadOnly = true;
            this.txtKetqua.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKetqua.Size = new System.Drawing.Size(1562, 154);
            this.txtKetqua.TabIndex = 2;
            this.txtKetqua.Text = "Kết Quả Duyệt";
            // 
            // pnlVeDoThi
            // 
            this.pnlVeDoThi.BackColor = System.Drawing.Color.Azure;
            this.pnlVeDoThi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVeDoThi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlVeDoThi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.pnlVeDoThi.Location = new System.Drawing.Point(7, 51);
            this.pnlVeDoThi.Name = "pnlVeDoThi";
            this.pnlVeDoThi.Size = new System.Drawing.Size(864, 543);
            this.pnlVeDoThi.TabIndex = 6;
            this.pnlVeDoThi.Click += new System.EventHandler(this.pnlVeDoThi_Click);
            this.pnlVeDoThi.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlVeDoThi_Paint);
            this.pnlVeDoThi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlVeDoThi_MouseClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDuyet);
            this.panel2.Controls.Add(this.btnLamMoi);
            this.panel2.Location = new System.Drawing.Point(6, 613);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 118);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnDuyet
            // 
            this.btnDuyet.BackColor = System.Drawing.Color.YellowGreen;
            this.btnDuyet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDuyet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnDuyet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuyet.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDuyet.ForeColor = System.Drawing.Color.White;
            this.btnDuyet.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnDuyet.IconColor = System.Drawing.Color.Honeydew;
            this.btnDuyet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDuyet.IconSize = 25;
            this.btnDuyet.Location = new System.Drawing.Point(33, 9);
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.Padding = new System.Windows.Forms.Padding(46, 0, 23, 0);
            this.btnDuyet.Size = new System.Drawing.Size(353, 49);
            this.btnDuyet.TabIndex = 0;
            this.btnDuyet.Text = "Duyệt";
            this.btnDuyet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDuyet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDuyet.UseVisualStyleBackColor = false;
            this.btnDuyet.Click += new System.EventHandler(this.btnDuyet_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Brown;
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLamMoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnLamMoi.IconColor = System.Drawing.Color.Aquamarine;
            this.btnLamMoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLamMoi.IconSize = 25;
            this.btnLamMoi.Location = new System.Drawing.Point(33, 64);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Padding = new System.Windows.Forms.Padding(23, 0, 23, 0);
            this.btnLamMoi.Size = new System.Drawing.Size(353, 49);
            this.btnLamMoi.TabIndex = 1;
            this.btnLamMoi.Text = "Xóa Và Tạo Mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(5, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "Chức Năng";
            // 
            // cbxChucNang
            // 
            this.cbxChucNang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChucNang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbxChucNang.FormattingEnabled = true;
            this.cbxChucNang.Items.AddRange(new object[] {
            "Dijkstra",
            "Kruskal",
            "Prim",
            "Duyệt BFS",
            "Duyệt DFS",
            "Xét Liên Thông"});
            this.cbxChucNang.Location = new System.Drawing.Point(138, 51);
            this.cbxChucNang.Name = "cbxChucNang";
            this.cbxChucNang.Size = new System.Drawing.Size(251, 34);
            this.cbxChucNang.TabIndex = 12;
            this.cbxChucNang.SelectedValueChanged += new System.EventHandler(this.cbxChucNang_SelectedValueChanged);
            this.cbxChucNang.TextChanged += new System.EventHandler(this.cbxChucNang_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(6, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Loại Đồ Thị";
            // 
            // cbxLoaiDoThi
            // 
            this.cbxLoaiDoThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLoaiDoThi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbxLoaiDoThi.FormattingEnabled = true;
            this.cbxLoaiDoThi.Items.AddRange(new object[] {
            "Đồ Thị Vô Hướng",
            "Đồ Thị Có Hướng"});
            this.cbxLoaiDoThi.Location = new System.Drawing.Point(138, 12);
            this.cbxLoaiDoThi.Name = "cbxLoaiDoThi";
            this.cbxLoaiDoThi.Size = new System.Drawing.Size(248, 34);
            this.cbxLoaiDoThi.TabIndex = 8;
            this.cbxLoaiDoThi.TextChanged += new System.EventHandler(this.cbxLoaiDoThi_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.cbxChucNang);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cbxLoaiDoThi);
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(405, 97);
            this.panel3.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(5, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Đỉnh Bắt Đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(7, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Đỉnh Kết Thúc";
            // 
            // cbxCachDuyet
            // 
            this.cbxCachDuyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCachDuyet.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbxCachDuyet.FormattingEnabled = true;
            this.cbxCachDuyet.Items.AddRange(new object[] {
            "Duyệt Từng Bước",
            "Duyệt Toàn Bộ"});
            this.cbxCachDuyet.Location = new System.Drawing.Point(132, 7);
            this.cbxCachDuyet.Name = "cbxCachDuyet";
            this.cbxCachDuyet.Size = new System.Drawing.Size(222, 34);
            this.cbxCachDuyet.TabIndex = 14;
            this.cbxCachDuyet.TextChanged += new System.EventHandler(this.cbxCachDuyet_TextChanged);
            // 
            // pnlFS
            // 
            this.pnlFS.BackColor = System.Drawing.Color.White;
            this.pnlFS.Controls.Add(this.label2);
            this.pnlFS.Controls.Add(this.label3);
            this.pnlFS.Controls.Add(this.cboDinhKT);
            this.pnlFS.Controls.Add(this.cboBD);
            this.pnlFS.Location = new System.Drawing.Point(0, 103);
            this.pnlFS.Name = "pnlFS";
            this.pnlFS.Size = new System.Drawing.Size(405, 88);
            this.pnlFS.TabIndex = 13;
            // 
            // cboDinhKT
            // 
            this.cboDinhKT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDinhKT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboDinhKT.FormattingEnabled = true;
            this.cboDinhKT.Items.AddRange(new object[] {
            "Đồ Thị Vô Hướng",
            "Đồ Thị Có Hướng"});
            this.cboDinhKT.Location = new System.Drawing.Point(166, 42);
            this.cboDinhKT.Name = "cboDinhKT";
            this.cboDinhKT.Size = new System.Drawing.Size(159, 34);
            this.cboDinhKT.TabIndex = 8;
            this.cboDinhKT.TextChanged += new System.EventHandler(this.cboDinhKT_TextChanged);
            // 
            // cboBD
            // 
            this.cboBD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboBD.FormattingEnabled = true;
            this.cboBD.Items.AddRange(new object[] {
            "Đồ Thị Vô Hướng",
            "Đồ Thị Có Hướng"});
            this.cboBD.Location = new System.Drawing.Point(166, 3);
            this.cboBD.Name = "cboBD";
            this.cboBD.Size = new System.Drawing.Size(159, 34);
            this.cboBD.TabIndex = 8;
            this.cboBD.TextChanged += new System.EventHandler(this.cboBD_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(6, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cách Duyệt";
            // 
            // pnlCachDuyet
            // 
            this.pnlCachDuyet.BackColor = System.Drawing.Color.White;
            this.pnlCachDuyet.Controls.Add(this.cbxCachDuyet);
            this.pnlCachDuyet.Controls.Add(this.label6);
            this.pnlCachDuyet.Location = new System.Drawing.Point(0, 197);
            this.pnlCachDuyet.Name = "pnlCachDuyet";
            this.pnlCachDuyet.Size = new System.Drawing.Size(402, 64);
            this.pnlCachDuyet.TabIndex = 14;
            // 
            // txtTrongSo
            // 
            this.txtTrongSo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTrongSo.Location = new System.Drawing.Point(129, 41);
            this.txtTrongSo.Name = "txtTrongSo";
            this.txtTrongSo.Size = new System.Drawing.Size(190, 34);
            this.txtTrongSo.TabIndex = 14;
            this.txtTrongSo.TextChanged += new System.EventHandler(this.txtTrongSo_TextChanged);
            // 
            // labTrongSo
            // 
            this.labTrongSo.AutoSize = true;
            this.labTrongSo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labTrongSo.Location = new System.Drawing.Point(7, 10);
            this.labTrongSo.Name = "labTrongSo";
            this.labTrongSo.Size = new System.Drawing.Size(99, 26);
            this.labTrongSo.TabIndex = 15;
            this.labTrongSo.Text = "Trọng Số";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnXacNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacNhan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXacNhan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXacNhan.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.btnXacNhan.IconColor = System.Drawing.Color.DarkSlateGray;
            this.btnXacNhan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXacNhan.IconSize = 28;
            this.btnXacNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXacNhan.Location = new System.Drawing.Point(86, 195);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Padding = new System.Windows.Forms.Padding(14, 0, 26, 2);
            this.btnXacNhan.Size = new System.Drawing.Size(202, 42);
            this.btnXacNhan.TabIndex = 4;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXacNhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnXoaDinh
            // 
            this.btnXoaDinh.BackColor = System.Drawing.Color.Brown;
            this.btnXoaDinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaDinh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnXoaDinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaDinh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaDinh.ForeColor = System.Drawing.Color.White;
            this.btnXoaDinh.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            this.btnXoaDinh.IconColor = System.Drawing.Color.Honeydew;
            this.btnXoaDinh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaDinh.IconSize = 28;
            this.btnXoaDinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaDinh.Location = new System.Drawing.Point(219, 81);
            this.btnXoaDinh.Name = "btnXoaDinh";
            this.btnXoaDinh.Padding = new System.Windows.Forms.Padding(9, 0, 9, 2);
            this.btnXoaDinh.Size = new System.Drawing.Size(171, 42);
            this.btnXoaDinh.TabIndex = 3;
            this.btnXoaDinh.Text = "Xóa Đỉnh";
            this.btnXoaDinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaDinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaDinh.UseVisualStyleBackColor = false;
            this.btnXoaDinh.Click += new System.EventHandler(this.btnXoaDinh_Click);
            // 
            // btnXoaCanh
            // 
            this.btnXoaCanh.BackColor = System.Drawing.Color.Brown;
            this.btnXoaCanh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaCanh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnXoaCanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaCanh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaCanh.ForeColor = System.Drawing.Color.White;
            this.btnXoaCanh.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            this.btnXoaCanh.IconColor = System.Drawing.Color.Honeydew;
            this.btnXoaCanh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaCanh.IconSize = 28;
            this.btnXoaCanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaCanh.Location = new System.Drawing.Point(219, 129);
            this.btnXoaCanh.Name = "btnXoaCanh";
            this.btnXoaCanh.Padding = new System.Windows.Forms.Padding(9, 0, 9, 2);
            this.btnXoaCanh.Size = new System.Drawing.Size(171, 42);
            this.btnXoaCanh.TabIndex = 2;
            this.btnXoaCanh.Text = "Xóa Cạnh";
            this.btnXoaCanh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaCanh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaCanh.UseVisualStyleBackColor = false;
            this.btnXoaCanh.Click += new System.EventHandler(this.btnXoaCanh_Click);
            // 
            // btnThemCanh
            // 
            this.btnThemCanh.BackColor = System.Drawing.Color.YellowGreen;
            this.btnThemCanh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemCanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemCanh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemCanh.ForeColor = System.Drawing.Color.White;
            this.btnThemCanh.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnThemCanh.IconColor = System.Drawing.Color.Honeydew;
            this.btnThemCanh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemCanh.IconSize = 28;
            this.btnThemCanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemCanh.Location = new System.Drawing.Point(7, 129);
            this.btnThemCanh.Name = "btnThemCanh";
            this.btnThemCanh.Padding = new System.Windows.Forms.Padding(9, 0, 9, 2);
            this.btnThemCanh.Size = new System.Drawing.Size(194, 41);
            this.btnThemCanh.TabIndex = 1;
            this.btnThemCanh.Text = "Thêm Cạnh";
            this.btnThemCanh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemCanh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemCanh.UseVisualStyleBackColor = false;
            this.btnThemCanh.Click += new System.EventHandler(this.btnThemCanh_Click);
            // 
            // btnThemDinh
            // 
            this.btnThemDinh.BackColor = System.Drawing.Color.YellowGreen;
            this.btnThemDinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemDinh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnThemDinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDinh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemDinh.ForeColor = System.Drawing.Color.White;
            this.btnThemDinh.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnThemDinh.IconColor = System.Drawing.Color.Honeydew;
            this.btnThemDinh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemDinh.IconSize = 28;
            this.btnThemDinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemDinh.Location = new System.Drawing.Point(9, 81);
            this.btnThemDinh.Name = "btnThemDinh";
            this.btnThemDinh.Padding = new System.Windows.Forms.Padding(9, 0, 9, 2);
            this.btnThemDinh.Size = new System.Drawing.Size(189, 42);
            this.btnThemDinh.TabIndex = 0;
            this.btnThemDinh.Text = "Thêm Đỉnh";
            this.btnThemDinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemDinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemDinh.UseVisualStyleBackColor = false;
            this.btnThemDinh.Click += new System.EventHandler(this.btnThemDinh_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panelClickSukien);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnlCayKhung);
            this.panel1.Controls.Add(this.pnlCachDuyet);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnlFS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1380, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 675);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelClickSukien
            // 
            this.panelClickSukien.BackColor = System.Drawing.Color.White;
            this.panelClickSukien.Controls.Add(this.txtTrongSo);
            this.panelClickSukien.Controls.Add(this.labTrongSo);
            this.panelClickSukien.Controls.Add(this.btnXacNhan);
            this.panelClickSukien.Controls.Add(this.btnXoaDinh);
            this.panelClickSukien.Controls.Add(this.btnXoaCanh);
            this.panelClickSukien.Controls.Add(this.btnThemCanh);
            this.panelClickSukien.Controls.Add(this.btnThemDinh);
            this.panelClickSukien.Location = new System.Drawing.Point(3, 345);
            this.panelClickSukien.Name = "panelClickSukien";
            this.panelClickSukien.Size = new System.Drawing.Size(399, 262);
            this.panelClickSukien.TabIndex = 13;
            this.panelClickSukien.Paint += new System.Windows.Forms.PaintEventHandler(this.panelClickSukien_Paint);
            // 
            // pnlCayKhung
            // 
            this.pnlCayKhung.BackColor = System.Drawing.Color.White;
            this.pnlCayKhung.Controls.Add(this.cboCayKhung);
            this.pnlCayKhung.Controls.Add(this.label7);
            this.pnlCayKhung.Location = new System.Drawing.Point(0, 267);
            this.pnlCayKhung.Name = "pnlCayKhung";
            this.pnlCayKhung.Size = new System.Drawing.Size(402, 72);
            this.pnlCayKhung.TabIndex = 1;
            // 
            // cboCayKhung
            // 
            this.cboCayKhung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCayKhung.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboCayKhung.FormattingEnabled = true;
            this.cboCayKhung.Items.AddRange(new object[] {
            "Nhỏ nhất",
            "Lớn nhất"});
            this.cboCayKhung.Location = new System.Drawing.Point(121, 18);
            this.cboCayKhung.Name = "cboCayKhung";
            this.cboCayKhung.Size = new System.Drawing.Size(205, 34);
            this.cboCayKhung.TabIndex = 14;
            this.cboCayKhung.TextChanged += new System.EventHandler(this.cbxCachDuyet_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(3, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cây khung";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(86, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 26);
            this.label8.TabIndex = 8;
            this.label8.Text = "Quay về Menu";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::graphTheory.Properties.Resources.Menu;
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtxtMaGia);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(891, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 587);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mã giả";
            // 
            // rtxtMaGia
            // 
            this.rtxtMaGia.Location = new System.Drawing.Point(0, 33);
            this.rtxtMaGia.Name = "rtxtMaGia";
            this.rtxtMaGia.Size = new System.Drawing.Size(446, 533);
            this.rtxtMaGia.TabIndex = 0;
            this.rtxtMaGia.Text = "";
            // 
            // frmGraph
            // 
            this.AcceptButton = this.btnThemCanh;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnLamMoi;
            this.ClientSize = new System.Drawing.Size(1785, 675);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlVeDoThi);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGraph";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đồ thị lý thuyết";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGraph_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlFS.ResumeLayout(false);
            this.pnlFS.PerformLayout();
            this.pnlCachDuyet.ResumeLayout(false);
            this.pnlCachDuyet.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelClickSukien.ResumeLayout(false);
            this.panelClickSukien.PerformLayout();
            this.pnlCayKhung.ResumeLayout(false);
            this.pnlCayKhung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMatran;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.Panel pnlVeDoThi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxChucNang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxLoaiDoThi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxCachDuyet;
        private System.Windows.Forms.Panel pnlFS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlCachDuyet;
        private System.Windows.Forms.TextBox txtTrongSo;
        private System.Windows.Forms.Label labTrongSo;
        private FontAwesome.Sharp.IconButton btnXacNhan;
        private FontAwesome.Sharp.IconButton btnXoaDinh;
        private FontAwesome.Sharp.IconButton btnXoaCanh;
        private FontAwesome.Sharp.IconButton btnThemCanh;
        private FontAwesome.Sharp.IconButton btnThemDinh;
        private FontAwesome.Sharp.IconButton btnDuyet;
        private FontAwesome.Sharp.IconButton btnLamMoi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelClickSukien;
        private System.Windows.Forms.ComboBox cboDinhKT;
        private System.Windows.Forms.ComboBox cboBD;
        private System.Windows.Forms.ComboBox cboCayKhung;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlCayKhung;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtxtMaGia;
    }
}