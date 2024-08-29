namespace graphTheory
{
    partial class frmMatrix
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMatrix));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoaDinh = new System.Windows.Forms.Button();
            this.btnXoaCanh = new System.Windows.Forms.Button();
            this.btnThemDinh = new System.Windows.Forms.Button();
            this.btnThemCanh = new System.Windows.Forms.Button();
            this.btnTaoMaTran = new System.Windows.Forms.Button();
            this.lbDSDinh = new System.Windows.Forms.ListBox();
            this.txtDuongDan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDuyet = new FontAwesome.Sharp.IconButton();
            this.btnVeDoThi = new FontAwesome.Sharp.IconButton();
            this.btnLamMoi = new FontAwesome.Sharp.IconButton();
            this.btnDocFile = new FontAwesome.Sharp.IconButton();
            this.txtMaTran = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.cbxDinhBatDau = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxDinhKetThuc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbDSCanh = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxChucNang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlDinh = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTrongso = new System.Windows.Forms.TextBox();
            this.pbBang = new System.Windows.Forms.PictureBox();
            this.pnlCayKhung = new System.Windows.Forms.Panel();
            this.cboCayKhung = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rtxtMaGia = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlDinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBang)).BeginInit();
            this.pnlCayKhung.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnXoaDinh);
            this.panel1.Controls.Add(this.btnXoaCanh);
            this.panel1.Controls.Add(this.btnThemDinh);
            this.panel1.Controls.Add(this.btnThemCanh);
            this.panel1.Location = new System.Drawing.Point(703, 241);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 120);
            this.panel1.TabIndex = 41;
            // 
            // btnXoaDinh
            // 
            this.btnXoaDinh.BackColor = System.Drawing.Color.RosyBrown;
            this.btnXoaDinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaDinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDinh.ForeColor = System.Drawing.Color.White;
            this.btnXoaDinh.Location = new System.Drawing.Point(28, 18);
            this.btnXoaDinh.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaDinh.Name = "btnXoaDinh";
            this.btnXoaDinh.Size = new System.Drawing.Size(117, 34);
            this.btnXoaDinh.TabIndex = 16;
            this.btnXoaDinh.Text = "Xóa Đỉnh";
            this.btnXoaDinh.UseVisualStyleBackColor = false;
            this.btnXoaDinh.Click += new System.EventHandler(this.btnXoaDinh_Click);
            // 
            // btnXoaCanh
            // 
            this.btnXoaCanh.BackColor = System.Drawing.Color.RosyBrown;
            this.btnXoaCanh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaCanh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaCanh.ForeColor = System.Drawing.Color.White;
            this.btnXoaCanh.Location = new System.Drawing.Point(220, 21);
            this.btnXoaCanh.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaCanh.Name = "btnXoaCanh";
            this.btnXoaCanh.Size = new System.Drawing.Size(120, 32);
            this.btnXoaCanh.TabIndex = 17;
            this.btnXoaCanh.Text = "Xóa Cạnh";
            this.btnXoaCanh.UseVisualStyleBackColor = false;
            this.btnXoaCanh.Click += new System.EventHandler(this.btnXoaCanh_Click);
            // 
            // btnThemDinh
            // 
            this.btnThemDinh.BackColor = System.Drawing.Color.RosyBrown;
            this.btnThemDinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemDinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDinh.ForeColor = System.Drawing.Color.White;
            this.btnThemDinh.Location = new System.Drawing.Point(28, 78);
            this.btnThemDinh.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemDinh.Name = "btnThemDinh";
            this.btnThemDinh.Size = new System.Drawing.Size(117, 33);
            this.btnThemDinh.TabIndex = 18;
            this.btnThemDinh.Text = "Thêm Đỉnh";
            this.btnThemDinh.UseVisualStyleBackColor = false;
            this.btnThemDinh.Click += new System.EventHandler(this.btnThemDinh_Click);
            // 
            // btnThemCanh
            // 
            this.btnThemCanh.BackColor = System.Drawing.Color.RosyBrown;
            this.btnThemCanh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemCanh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCanh.ForeColor = System.Drawing.Color.White;
            this.btnThemCanh.Location = new System.Drawing.Point(220, 78);
            this.btnThemCanh.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemCanh.Name = "btnThemCanh";
            this.btnThemCanh.Size = new System.Drawing.Size(120, 33);
            this.btnThemCanh.TabIndex = 19;
            this.btnThemCanh.Text = "Thêm Cạnh";
            this.btnThemCanh.UseVisualStyleBackColor = false;
            this.btnThemCanh.Click += new System.EventHandler(this.btnThemCanh_Click);
            // 
            // btnTaoMaTran
            // 
            this.btnTaoMaTran.BackColor = System.Drawing.Color.RosyBrown;
            this.btnTaoMaTran.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaoMaTran.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoMaTran.ForeColor = System.Drawing.Color.White;
            this.btnTaoMaTran.Location = new System.Drawing.Point(781, 456);
            this.btnTaoMaTran.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaoMaTran.Name = "btnTaoMaTran";
            this.btnTaoMaTran.Size = new System.Drawing.Size(224, 36);
            this.btnTaoMaTran.TabIndex = 40;
            this.btnTaoMaTran.Text = "Tạo ma trận ngẫu nhiên";
            this.btnTaoMaTran.UseVisualStyleBackColor = false;
            this.btnTaoMaTran.Click += new System.EventHandler(this.btnTaoMaTran_Click);
            // 
            // lbDSDinh
            // 
            this.lbDSDinh.FormattingEnabled = true;
            this.lbDSDinh.ItemHeight = 16;
            this.lbDSDinh.Location = new System.Drawing.Point(1428, 268);
            this.lbDSDinh.Margin = new System.Windows.Forms.Padding(4);
            this.lbDSDinh.Name = "lbDSDinh";
            this.lbDSDinh.Size = new System.Drawing.Size(161, 132);
            this.lbDSDinh.TabIndex = 38;
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuongDan.Location = new System.Drawing.Point(337, 4);
            this.txtDuongDan.Margin = new System.Windows.Forms.Padding(4);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.ReadOnly = true;
            this.txtDuongDan.Size = new System.Drawing.Size(520, 30);
            this.txtDuongDan.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1441, 241);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 22);
            this.label6.TabIndex = 30;
            this.label6.Text = "Danh sách đỉnh";
            // 
            // btnDuyet
            // 
            this.btnDuyet.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDuyet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDuyet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuyet.ForeColor = System.Drawing.Color.White;
            this.btnDuyet.IconChar = FontAwesome.Sharp.IconChar.CheckDouble;
            this.btnDuyet.IconColor = System.Drawing.Color.White;
            this.btnDuyet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDuyet.IconSize = 25;
            this.btnDuyet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDuyet.Location = new System.Drawing.Point(897, 4);
            this.btnDuyet.Margin = new System.Windows.Forms.Padding(4);
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.Size = new System.Drawing.Size(155, 38);
            this.btnDuyet.TabIndex = 33;
            this.btnDuyet.Text = "Duyệt";
            this.btnDuyet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDuyet.UseVisualStyleBackColor = false;
            this.btnDuyet.Click += new System.EventHandler(this.btnDuyet_Click);
            // 
            // btnVeDoThi
            // 
            this.btnVeDoThi.BackColor = System.Drawing.Color.RosyBrown;
            this.btnVeDoThi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVeDoThi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeDoThi.ForeColor = System.Drawing.Color.White;
            this.btnVeDoThi.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVeDoThi.IconColor = System.Drawing.Color.Black;
            this.btnVeDoThi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVeDoThi.Location = new System.Drawing.Point(1060, 0);
            this.btnVeDoThi.Margin = new System.Windows.Forms.Padding(4);
            this.btnVeDoThi.Name = "btnVeDoThi";
            this.btnVeDoThi.Size = new System.Drawing.Size(108, 34);
            this.btnVeDoThi.TabIndex = 27;
            this.btnVeDoThi.Text = "Vẽ đồ thị";
            this.btnVeDoThi.UseVisualStyleBackColor = false;
            this.btnVeDoThi.Click += new System.EventHandler(this.btnVeDoThi_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.RosyBrown;
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLamMoi.IconColor = System.Drawing.Color.Black;
            this.btnLamMoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLamMoi.Location = new System.Drawing.Point(1176, 0);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(108, 34);
            this.btnLamMoi.TabIndex = 26;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnDocFile
            // 
            this.btnDocFile.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDocFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDocFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocFile.ForeColor = System.Drawing.Color.White;
            this.btnDocFile.IconChar = FontAwesome.Sharp.IconChar.FileCode;
            this.btnDocFile.IconColor = System.Drawing.Color.Linen;
            this.btnDocFile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDocFile.IconSize = 25;
            this.btnDocFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocFile.Location = new System.Drawing.Point(175, 2);
            this.btnDocFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnDocFile.Name = "btnDocFile";
            this.btnDocFile.Size = new System.Drawing.Size(153, 36);
            this.btnDocFile.TabIndex = 25;
            this.btnDocFile.Text = "Đọc File";
            this.btnDocFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDocFile.UseVisualStyleBackColor = false;
            this.btnDocFile.Click += new System.EventHandler(this.btnDocFile_Click);
            // 
            // txtMaTran
            // 
            this.txtMaTran.BackColor = System.Drawing.Color.White;
            this.txtMaTran.Location = new System.Drawing.Point(1428, 2);
            this.txtMaTran.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaTran.Multiline = true;
            this.txtMaTran.Name = "txtMaTran";
            this.txtMaTran.ReadOnly = true;
            this.txtMaTran.Size = new System.Drawing.Size(313, 233);
            this.txtMaTran.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "Đỉnh cuối";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::graphTheory.Properties.Resources.Menu;
            this.pictureBox1.Location = new System.Drawing.Point(0, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox1.Controls.Add(this.txtKetQua);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(712, 500);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1029, 212);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(18, 31);
            this.txtKetQua.Margin = new System.Windows.Forms.Padding(4);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(986, 164);
            this.txtKetQua.TabIndex = 0;
            // 
            // cbxDinhBatDau
            // 
            this.cbxDinhBatDau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDinhBatDau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDinhBatDau.FormattingEnabled = true;
            this.cbxDinhBatDau.Location = new System.Drawing.Point(239, 7);
            this.cbxDinhBatDau.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDinhBatDau.Name = "cbxDinhBatDau";
            this.cbxDinhBatDau.Size = new System.Drawing.Size(113, 30);
            this.cbxDinhBatDau.TabIndex = 6;
            this.cbxDinhBatDau.SelectedValueChanged += new System.EventHandler(this.cbxDinhBatDau_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Đỉnh đầu";
            // 
            // cbxDinhKetThuc
            // 
            this.cbxDinhKetThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDinhKetThuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDinhKetThuc.FormattingEnabled = true;
            this.cbxDinhKetThuc.Location = new System.Drawing.Point(239, 48);
            this.cbxDinhKetThuc.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDinhKetThuc.Name = "cbxDinhKetThuc";
            this.cbxDinhKetThuc.Size = new System.Drawing.Size(113, 30);
            this.cbxDinhKetThuc.TabIndex = 7;
            this.cbxDinhKetThuc.SelectedIndexChanged += new System.EventHandler(this.cbxDinhKetThuc_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1610, 241);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 22);
            this.label5.TabIndex = 32;
            this.label5.Text = "Danh sách cạnh";
            // 
            // lbDSCanh
            // 
            this.lbDSCanh.FormattingEnabled = true;
            this.lbDSCanh.ItemHeight = 16;
            this.lbDSCanh.Location = new System.Drawing.Point(1598, 268);
            this.lbDSCanh.Margin = new System.Windows.Forms.Padding(4);
            this.lbDSCanh.Name = "lbDSCanh";
            this.lbDSCanh.Size = new System.Drawing.Size(149, 132);
            this.lbDSCanh.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(49, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 23);
            this.label4.TabIndex = 36;
            this.label4.Text = "Quay về Menu";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbxChucNang
            // 
            this.cbxChucNang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChucNang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxChucNang.FormattingEnabled = true;
            this.cbxChucNang.Items.AddRange(new object[] {
            "Xét liên thông",
            "Duyệt BFS",
            "Duyệt DFS",
            "Kruskal",
            "Prim",
            "Dijkstra",
            "Ford Bellman"});
            this.cbxChucNang.Location = new System.Drawing.Point(897, 51);
            this.cbxChucNang.Margin = new System.Windows.Forms.Padding(4);
            this.cbxChucNang.Name = "cbxChucNang";
            this.cbxChucNang.Size = new System.Drawing.Size(155, 30);
            this.cbxChucNang.TabIndex = 34;
            this.cbxChucNang.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(737, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 27);
            this.label3.TabIndex = 29;
            this.label3.Text = "Chức năng";
            // 
            // pnlDinh
            // 
            this.pnlDinh.BackColor = System.Drawing.Color.White;
            this.pnlDinh.Controls.Add(this.label8);
            this.pnlDinh.Controls.Add(this.txtTrongso);
            this.pnlDinh.Controls.Add(this.label2);
            this.pnlDinh.Controls.Add(this.cbxDinhBatDau);
            this.pnlDinh.Controls.Add(this.label1);
            this.pnlDinh.Controls.Add(this.cbxDinhKetThuc);
            this.pnlDinh.Location = new System.Drawing.Point(703, 92);
            this.pnlDinh.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDinh.Name = "pnlDinh";
            this.pnlDinh.Size = new System.Drawing.Size(401, 141);
            this.pnlDinh.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(101, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Nhập trọng số";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtTrongso
            // 
            this.txtTrongso.Location = new System.Drawing.Point(239, 100);
            this.txtTrongso.Name = "txtTrongso";
            this.txtTrongso.Size = new System.Drawing.Size(100, 22);
            this.txtTrongso.TabIndex = 10;
            // 
            // pbBang
            // 
            this.pbBang.BackColor = System.Drawing.Color.MistyRose;
            this.pbBang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbBang.Location = new System.Drawing.Point(0, 65);
            this.pbBang.Margin = new System.Windows.Forms.Padding(4);
            this.pbBang.Name = "pbBang";
            this.pbBang.Size = new System.Drawing.Size(695, 643);
            this.pbBang.TabIndex = 23;
            this.pbBang.TabStop = false;
            this.pbBang.Paint += new System.Windows.Forms.PaintEventHandler(this.pbBang_Paint);
            // 
            // pnlCayKhung
            // 
            this.pnlCayKhung.BackColor = System.Drawing.Color.White;
            this.pnlCayKhung.Controls.Add(this.cboCayKhung);
            this.pnlCayKhung.Controls.Add(this.label7);
            this.pnlCayKhung.Location = new System.Drawing.Point(712, 368);
            this.pnlCayKhung.Name = "pnlCayKhung";
            this.pnlCayKhung.Size = new System.Drawing.Size(348, 72);
            this.pnlCayKhung.TabIndex = 42;
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
            this.cboCayKhung.SelectedIndexChanged += new System.EventHandler(this.cboCayKhung_SelectedIndexChanged);
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
            // rtxtMaGia
            // 
            this.rtxtMaGia.Location = new System.Drawing.Point(1113, 41);
            this.rtxtMaGia.Name = "rtxtMaGia";
            this.rtxtMaGia.Size = new System.Drawing.Size(304, 431);
            this.rtxtMaGia.TabIndex = 43;
            this.rtxtMaGia.Text = "";
            // 
            // frmMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1754, 716);
            this.Controls.Add(this.rtxtMaGia);
            this.Controls.Add(this.pnlCayKhung);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTaoMaTran);
            this.Controls.Add(this.lbDSDinh);
            this.Controls.Add(this.txtDuongDan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDuyet);
            this.Controls.Add(this.btnVeDoThi);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnDocFile);
            this.Controls.Add(this.txtMaTran);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbDSCanh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxChucNang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlDinh);
            this.Controls.Add(this.pbBang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMatrix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMatrix";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlDinh.ResumeLayout(false);
            this.pnlDinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBang)).EndInit();
            this.pnlCayKhung.ResumeLayout(false);
            this.pnlCayKhung.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoaDinh;
        private System.Windows.Forms.Button btnXoaCanh;
        private System.Windows.Forms.Button btnThemDinh;
        private System.Windows.Forms.Button btnThemCanh;
        private System.Windows.Forms.Button btnTaoMaTran;
        private System.Windows.Forms.ListBox lbDSDinh;
        private System.Windows.Forms.TextBox txtDuongDan;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btnDuyet;
        private FontAwesome.Sharp.IconButton btnVeDoThi;
        private FontAwesome.Sharp.IconButton btnLamMoi;
        private FontAwesome.Sharp.IconButton btnDocFile;
        private System.Windows.Forms.TextBox txtMaTran;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.ComboBox cbxDinhBatDau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxDinhKetThuc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbDSCanh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxChucNang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlDinh;
        private System.Windows.Forms.PictureBox pbBang;
        private System.Windows.Forms.Panel pnlCayKhung;
        private System.Windows.Forms.ComboBox cboCayKhung;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtxtMaGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTrongso;
    }
}