namespace DoAnBMCSDL.View
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lbl_user = new System.Windows.Forms.Label();
            this.dgrv_may = new System.Windows.Forms.DataGridView();
            this.col_mamay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ngaytao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ngtao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tab_dichvu = new System.Windows.Forms.TabPage();
            this.dgrv_dv = new System.Windows.Forms.DataGridView();
            this.col_madv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tendv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ngaytao_dv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nguoitao_dv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ngaysua_dv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nguoisua_dv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_rf_dv = new FontAwesome.Sharp.IconButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tab_khach = new System.Windows.Forms.TabPage();
            this.icon_refresh_kh = new FontAwesome.Sharp.IconButton();
            this.btn_update_kh = new System.Windows.Forms.Button();
            this.btn_delete_kh = new System.Windows.Forms.Button();
            this.dgrv_kh = new System.Windows.Forms.DataGridView();
            this.col_makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cccd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ngaytao_kh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nguoitao_kh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ngaysua_kh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nguoisua_kh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_insert_kh = new System.Windows.Forms.Button();
            this.tab_may = new System.Windows.Forms.TabPage();
            this.btn_update_may = new System.Windows.Forms.Button();
            this.btn_del_may = new System.Windows.Forms.Button();
            this.btn_insertMay = new System.Windows.Forms.Button();
            this.btn_refresh = new FontAwesome.Sharp.IconButton();
            this.tab_hoadon = new System.Windows.Forms.TabPage();
            this.btn_rf_hd = new FontAwesome.Sharp.IconButton();
            this.btn_xemcthd = new System.Windows.Forms.Button();
            this.dgrv_hd = new System.Windows.Forms.DataGridView();
            this.col_mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_mamay_hd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_makhhd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tgbd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tgkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ngaytaohd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nguoitaohd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ngaysuahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nguoisuahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExportFile = new System.Windows.Forms.Button();
            this.btnDecyptDes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_may)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tab_dichvu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_dv)).BeginInit();
            this.tab_khach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_kh)).BeginInit();
            this.tab_may.SuspendLayout();
            this.tab_hoadon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_hd)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(1252, 198);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(101, 41);
            this.btn_logout.TabIndex = 0;
            this.btn_logout.Text = "LOGOUT";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(1212, 51);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(121, 29);
            this.lbl_user.TabIndex = 1;
            this.lbl_user.Text = "Welcome!";
            // 
            // dgrv_may
            // 
            this.dgrv_may.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrv_may.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_mamay,
            this.col_loai,
            this.col_trangthai,
            this.col_ngaytao,
            this.col_ngtao});
            this.dgrv_may.Location = new System.Drawing.Point(-4, 2);
            this.dgrv_may.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgrv_may.Name = "dgrv_may";
            this.dgrv_may.RowHeadersWidth = 51;
            this.dgrv_may.RowTemplate.Height = 24;
            this.dgrv_may.Size = new System.Drawing.Size(988, 417);
            this.dgrv_may.TabIndex = 3;
            // 
            // col_mamay
            // 
            this.col_mamay.DataPropertyName = "MaMay";
            this.col_mamay.HeaderText = "Mã máy";
            this.col_mamay.MinimumWidth = 6;
            this.col_mamay.Name = "col_mamay";
            this.col_mamay.Width = 125;
            // 
            // col_loai
            // 
            this.col_loai.DataPropertyName = "Loai";
            this.col_loai.HeaderText = "Loại";
            this.col_loai.MinimumWidth = 6;
            this.col_loai.Name = "col_loai";
            this.col_loai.Width = 125;
            // 
            // col_trangthai
            // 
            this.col_trangthai.DataPropertyName = "TrangThai";
            this.col_trangthai.HeaderText = "Trạng thái";
            this.col_trangthai.MinimumWidth = 6;
            this.col_trangthai.Name = "col_trangthai";
            this.col_trangthai.Width = 125;
            // 
            // col_ngaytao
            // 
            this.col_ngaytao.DataPropertyName = "NGAYTAO";
            this.col_ngaytao.HeaderText = "Ngày tạo";
            this.col_ngaytao.MinimumWidth = 6;
            this.col_ngaytao.Name = "col_ngaytao";
            this.col_ngaytao.Width = 125;
            // 
            // col_ngtao
            // 
            this.col_ngtao.DataPropertyName = "NGUOITAO";
            this.col_ngtao.HeaderText = "Người tạo";
            this.col_ngtao.MinimumWidth = 6;
            this.col_ngtao.Name = "col_ngtao";
            this.col_ngtao.Width = 125;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tab_dichvu);
            this.tabControlMain.Controls.Add(this.tab_khach);
            this.tabControlMain.Controls.Add(this.tab_may);
            this.tabControlMain.Controls.Add(this.tab_hoadon);
            this.tabControlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.ItemSize = new System.Drawing.Size(100, 30);
            this.tabControlMain.Location = new System.Drawing.Point(12, 31);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1178, 461);
            this.tabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlMain.TabIndex = 4;
            this.tabControlMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlMain_Selected);
            // 
            // tab_dichvu
            // 
            this.tab_dichvu.BackColor = System.Drawing.Color.Transparent;
            this.tab_dichvu.Controls.Add(this.dgrv_dv);
            this.tab_dichvu.Controls.Add(this.btn_rf_dv);
            this.tab_dichvu.Controls.Add(this.button1);
            this.tab_dichvu.Controls.Add(this.button2);
            this.tab_dichvu.Controls.Add(this.button3);
            this.tab_dichvu.Location = new System.Drawing.Point(4, 34);
            this.tab_dichvu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_dichvu.Name = "tab_dichvu";
            this.tab_dichvu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_dichvu.Size = new System.Drawing.Size(1170, 423);
            this.tab_dichvu.TabIndex = 2;
            this.tab_dichvu.Text = "Dịch vụ";
            // 
            // dgrv_dv
            // 
            this.dgrv_dv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrv_dv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_madv,
            this.col_tendv,
            this.col_dongia,
            this.col_ngaytao_dv,
            this.col_nguoitao_dv,
            this.col_ngaysua_dv,
            this.col_nguoisua_dv});
            this.dgrv_dv.Location = new System.Drawing.Point(0, 3);
            this.dgrv_dv.Name = "dgrv_dv";
            this.dgrv_dv.RowHeadersWidth = 51;
            this.dgrv_dv.RowTemplate.Height = 24;
            this.dgrv_dv.Size = new System.Drawing.Size(1010, 420);
            this.dgrv_dv.TabIndex = 14;
            // 
            // col_madv
            // 
            this.col_madv.DataPropertyName = "MaDV";
            this.col_madv.HeaderText = "Mã dịch vụ";
            this.col_madv.MinimumWidth = 6;
            this.col_madv.Name = "col_madv";
            this.col_madv.Width = 125;
            // 
            // col_tendv
            // 
            this.col_tendv.DataPropertyName = "TenDV";
            this.col_tendv.HeaderText = "Tên dịch vụ";
            this.col_tendv.MinimumWidth = 6;
            this.col_tendv.Name = "col_tendv";
            this.col_tendv.Width = 160;
            // 
            // col_dongia
            // 
            this.col_dongia.DataPropertyName = "DonGia";
            this.col_dongia.HeaderText = "Đơn giá";
            this.col_dongia.MinimumWidth = 6;
            this.col_dongia.Name = "col_dongia";
            this.col_dongia.Width = 125;
            // 
            // col_ngaytao_dv
            // 
            this.col_ngaytao_dv.DataPropertyName = "NgayTao";
            this.col_ngaytao_dv.HeaderText = "Ngày tạo";
            this.col_ngaytao_dv.MinimumWidth = 6;
            this.col_ngaytao_dv.Name = "col_ngaytao_dv";
            this.col_ngaytao_dv.Width = 125;
            // 
            // col_nguoitao_dv
            // 
            this.col_nguoitao_dv.DataPropertyName = "NguoiTao";
            this.col_nguoitao_dv.HeaderText = "Người tạo";
            this.col_nguoitao_dv.MinimumWidth = 6;
            this.col_nguoitao_dv.Name = "col_nguoitao_dv";
            this.col_nguoitao_dv.Width = 125;
            // 
            // col_ngaysua_dv
            // 
            this.col_ngaysua_dv.DataPropertyName = "NgaySua";
            this.col_ngaysua_dv.HeaderText = "Ngày sửa";
            this.col_ngaysua_dv.MinimumWidth = 6;
            this.col_ngaysua_dv.Name = "col_ngaysua_dv";
            this.col_ngaysua_dv.Width = 125;
            // 
            // col_nguoisua_dv
            // 
            this.col_nguoisua_dv.DataPropertyName = "NguoiSua";
            this.col_nguoisua_dv.HeaderText = "Người sửa";
            this.col_nguoisua_dv.MinimumWidth = 6;
            this.col_nguoisua_dv.Name = "col_nguoisua_dv";
            this.col_nguoisua_dv.Width = 125;
            // 
            // btn_rf_dv
            // 
            this.btn_rf_dv.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.btn_rf_dv.IconColor = System.Drawing.Color.Black;
            this.btn_rf_dv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_rf_dv.IconSize = 30;
            this.btn_rf_dv.Location = new System.Drawing.Point(1074, 44);
            this.btn_rf_dv.Name = "btn_rf_dv";
            this.btn_rf_dv.Size = new System.Drawing.Size(46, 33);
            this.btn_rf_dv.TabIndex = 13;
            this.btn_rf_dv.UseVisualStyleBackColor = true;
            this.btn_rf_dv.Click += new System.EventHandler(this.btn_rf_dv_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1045, 169);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(1045, 232);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 41);
            this.button2.TabIndex = 11;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(1045, 101);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 41);
            this.button3.TabIndex = 10;
            this.button3.Text = "INSERT";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tab_khach
            // 
            this.tab_khach.BackColor = System.Drawing.Color.White;
            this.tab_khach.Controls.Add(this.btnDecyptDes);
            this.tab_khach.Controls.Add(this.btnExportFile);
            this.tab_khach.Controls.Add(this.icon_refresh_kh);
            this.tab_khach.Controls.Add(this.btn_update_kh);
            this.tab_khach.Controls.Add(this.btn_delete_kh);
            this.tab_khach.Controls.Add(this.dgrv_kh);
            this.tab_khach.Controls.Add(this.btn_insert_kh);
            this.tab_khach.ForeColor = System.Drawing.Color.Black;
            this.tab_khach.Location = new System.Drawing.Point(4, 34);
            this.tab_khach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_khach.Name = "tab_khach";
            this.tab_khach.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_khach.Size = new System.Drawing.Size(1170, 423);
            this.tab_khach.TabIndex = 1;
            this.tab_khach.Text = "Khách hàng";
            // 
            // icon_refresh_kh
            // 
            this.icon_refresh_kh.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.icon_refresh_kh.IconColor = System.Drawing.Color.Black;
            this.icon_refresh_kh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icon_refresh_kh.IconSize = 30;
            this.icon_refresh_kh.Location = new System.Drawing.Point(1058, 22);
            this.icon_refresh_kh.Name = "icon_refresh_kh";
            this.icon_refresh_kh.Size = new System.Drawing.Size(46, 33);
            this.icon_refresh_kh.TabIndex = 9;
            this.icon_refresh_kh.UseVisualStyleBackColor = true;
            this.icon_refresh_kh.Click += new System.EventHandler(this.icon_refresh_kh_Click);
            // 
            // btn_update_kh
            // 
            this.btn_update_kh.ForeColor = System.Drawing.Color.Black;
            this.btn_update_kh.Location = new System.Drawing.Point(1029, 147);
            this.btn_update_kh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_update_kh.Name = "btn_update_kh";
            this.btn_update_kh.Size = new System.Drawing.Size(101, 41);
            this.btn_update_kh.TabIndex = 8;
            this.btn_update_kh.Text = "UPDATE";
            this.btn_update_kh.UseVisualStyleBackColor = true;
            this.btn_update_kh.Click += new System.EventHandler(this.btn_update_kh_Click);
            // 
            // btn_delete_kh
            // 
            this.btn_delete_kh.ForeColor = System.Drawing.Color.Black;
            this.btn_delete_kh.Location = new System.Drawing.Point(1029, 210);
            this.btn_delete_kh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete_kh.Name = "btn_delete_kh";
            this.btn_delete_kh.Size = new System.Drawing.Size(101, 41);
            this.btn_delete_kh.TabIndex = 7;
            this.btn_delete_kh.Text = "DELETE";
            this.btn_delete_kh.UseVisualStyleBackColor = true;
            this.btn_delete_kh.Click += new System.EventHandler(this.btn_delete_kh_Click);
            // 
            // dgrv_kh
            // 
            this.dgrv_kh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrv_kh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_makh,
            this.col_tenkh,
            this.col_sdt,
            this.col_cccd,
            this.col_sodu,
            this.col_ngaytao_kh,
            this.col_nguoitao_kh,
            this.col_ngaysua_kh,
            this.col_nguoisua_kh});
            this.dgrv_kh.Location = new System.Drawing.Point(3, 5);
            this.dgrv_kh.Name = "dgrv_kh";
            this.dgrv_kh.RowHeadersWidth = 51;
            this.dgrv_kh.RowTemplate.Height = 24;
            this.dgrv_kh.Size = new System.Drawing.Size(988, 422);
            this.dgrv_kh.TabIndex = 0;
            // 
            // col_makh
            // 
            this.col_makh.DataPropertyName = "MaKH";
            this.col_makh.HeaderText = "Mã khách hàng";
            this.col_makh.MinimumWidth = 6;
            this.col_makh.Name = "col_makh";
            this.col_makh.Width = 130;
            // 
            // col_tenkh
            // 
            this.col_tenkh.DataPropertyName = "TenKH";
            this.col_tenkh.HeaderText = "Họ và tên";
            this.col_tenkh.MinimumWidth = 6;
            this.col_tenkh.Name = "col_tenkh";
            this.col_tenkh.Width = 125;
            // 
            // col_sdt
            // 
            this.col_sdt.DataPropertyName = "SoDienThoai";
            this.col_sdt.HeaderText = "Số điện thoại";
            this.col_sdt.MinimumWidth = 6;
            this.col_sdt.Name = "col_sdt";
            this.col_sdt.Width = 125;
            // 
            // col_cccd
            // 
            this.col_cccd.DataPropertyName = "CCCD";
            this.col_cccd.HeaderText = "CCCD";
            this.col_cccd.MinimumWidth = 6;
            this.col_cccd.Name = "col_cccd";
            this.col_cccd.Width = 125;
            // 
            // col_sodu
            // 
            this.col_sodu.DataPropertyName = "SoDu";
            dataGridViewCellStyle7.Format = "#,##0 đ";
            this.col_sodu.DefaultCellStyle = dataGridViewCellStyle7;
            this.col_sodu.HeaderText = "Số dư";
            this.col_sodu.MinimumWidth = 6;
            this.col_sodu.Name = "col_sodu";
            this.col_sodu.Width = 125;
            // 
            // col_ngaytao_kh
            // 
            this.col_ngaytao_kh.DataPropertyName = "NgayTao";
            dataGridViewCellStyle8.Format = "dd/MM/yy";
            this.col_ngaytao_kh.DefaultCellStyle = dataGridViewCellStyle8;
            this.col_ngaytao_kh.HeaderText = "Ngày tạo";
            this.col_ngaytao_kh.MinimumWidth = 6;
            this.col_ngaytao_kh.Name = "col_ngaytao_kh";
            this.col_ngaytao_kh.Width = 125;
            // 
            // col_nguoitao_kh
            // 
            this.col_nguoitao_kh.DataPropertyName = "NguoiTao";
            this.col_nguoitao_kh.HeaderText = "Người tạo";
            this.col_nguoitao_kh.MinimumWidth = 6;
            this.col_nguoitao_kh.Name = "col_nguoitao_kh";
            this.col_nguoitao_kh.Width = 125;
            // 
            // col_ngaysua_kh
            // 
            this.col_ngaysua_kh.DataPropertyName = "NgaySua";
            dataGridViewCellStyle9.Format = "dd/MM/yy";
            dataGridViewCellStyle9.NullValue = null;
            this.col_ngaysua_kh.DefaultCellStyle = dataGridViewCellStyle9;
            this.col_ngaysua_kh.HeaderText = "Ngày sửa";
            this.col_ngaysua_kh.MinimumWidth = 6;
            this.col_ngaysua_kh.Name = "col_ngaysua_kh";
            this.col_ngaysua_kh.Width = 125;
            // 
            // col_nguoisua_kh
            // 
            this.col_nguoisua_kh.DataPropertyName = "NguoiSua";
            this.col_nguoisua_kh.HeaderText = "Người sửa";
            this.col_nguoisua_kh.MinimumWidth = 6;
            this.col_nguoisua_kh.Name = "col_nguoisua_kh";
            this.col_nguoisua_kh.Width = 125;
            // 
            // btn_insert_kh
            // 
            this.btn_insert_kh.ForeColor = System.Drawing.Color.Black;
            this.btn_insert_kh.Location = new System.Drawing.Point(1029, 79);
            this.btn_insert_kh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_insert_kh.Name = "btn_insert_kh";
            this.btn_insert_kh.Size = new System.Drawing.Size(101, 41);
            this.btn_insert_kh.TabIndex = 6;
            this.btn_insert_kh.Text = "INSERT";
            this.btn_insert_kh.UseVisualStyleBackColor = true;
            this.btn_insert_kh.Click += new System.EventHandler(this.btn_insert_kh_Click);
            // 
            // tab_may
            // 
            this.tab_may.Controls.Add(this.btn_update_may);
            this.tab_may.Controls.Add(this.btn_del_may);
            this.tab_may.Controls.Add(this.btn_insertMay);
            this.tab_may.Controls.Add(this.btn_refresh);
            this.tab_may.Controls.Add(this.dgrv_may);
            this.tab_may.ForeColor = System.Drawing.Color.Black;
            this.tab_may.Location = new System.Drawing.Point(4, 34);
            this.tab_may.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_may.Name = "tab_may";
            this.tab_may.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_may.Size = new System.Drawing.Size(1170, 423);
            this.tab_may.TabIndex = 0;
            this.tab_may.Text = "Máy";
            this.tab_may.UseVisualStyleBackColor = true;
            // 
            // btn_update_may
            // 
            this.btn_update_may.ForeColor = System.Drawing.Color.Black;
            this.btn_update_may.Location = new System.Drawing.Point(1023, 148);
            this.btn_update_may.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_update_may.Name = "btn_update_may";
            this.btn_update_may.Size = new System.Drawing.Size(101, 41);
            this.btn_update_may.TabIndex = 13;
            this.btn_update_may.Text = "UPDATE";
            this.btn_update_may.UseVisualStyleBackColor = true;
            this.btn_update_may.Click += new System.EventHandler(this.btn_update_may_Click);
            // 
            // btn_del_may
            // 
            this.btn_del_may.ForeColor = System.Drawing.Color.Black;
            this.btn_del_may.Location = new System.Drawing.Point(1023, 211);
            this.btn_del_may.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_del_may.Name = "btn_del_may";
            this.btn_del_may.Size = new System.Drawing.Size(101, 41);
            this.btn_del_may.TabIndex = 12;
            this.btn_del_may.Text = "DELETE";
            this.btn_del_may.UseVisualStyleBackColor = true;
            this.btn_del_may.Click += new System.EventHandler(this.btn_del_may_Click);
            // 
            // btn_insertMay
            // 
            this.btn_insertMay.ForeColor = System.Drawing.Color.Black;
            this.btn_insertMay.Location = new System.Drawing.Point(1023, 80);
            this.btn_insertMay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_insertMay.Name = "btn_insertMay";
            this.btn_insertMay.Size = new System.Drawing.Size(101, 41);
            this.btn_insertMay.TabIndex = 11;
            this.btn_insertMay.Text = "INSERT";
            this.btn_insertMay.UseVisualStyleBackColor = true;
            this.btn_insertMay.Click += new System.EventHandler(this.btn_insertMay_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.btn_refresh.IconColor = System.Drawing.Color.Black;
            this.btn_refresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_refresh.IconSize = 30;
            this.btn_refresh.Location = new System.Drawing.Point(1044, 26);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(46, 33);
            this.btn_refresh.TabIndex = 10;
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // tab_hoadon
            // 
            this.tab_hoadon.Controls.Add(this.btn_rf_hd);
            this.tab_hoadon.Controls.Add(this.btn_xemcthd);
            this.tab_hoadon.Controls.Add(this.dgrv_hd);
            this.tab_hoadon.Location = new System.Drawing.Point(4, 34);
            this.tab_hoadon.Name = "tab_hoadon";
            this.tab_hoadon.Padding = new System.Windows.Forms.Padding(3);
            this.tab_hoadon.Size = new System.Drawing.Size(1170, 423);
            this.tab_hoadon.TabIndex = 3;
            this.tab_hoadon.Text = "Hoá đơn";
            this.tab_hoadon.UseVisualStyleBackColor = true;
            // 
            // btn_rf_hd
            // 
            this.btn_rf_hd.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.btn_rf_hd.IconColor = System.Drawing.Color.Black;
            this.btn_rf_hd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_rf_hd.IconSize = 30;
            this.btn_rf_hd.Location = new System.Drawing.Point(1057, 19);
            this.btn_rf_hd.Name = "btn_rf_hd";
            this.btn_rf_hd.Size = new System.Drawing.Size(46, 33);
            this.btn_rf_hd.TabIndex = 14;
            this.btn_rf_hd.UseVisualStyleBackColor = true;
            this.btn_rf_hd.Click += new System.EventHandler(this.btn_rf_hd_Click);
            // 
            // btn_xemcthd
            // 
            this.btn_xemcthd.Location = new System.Drawing.Point(1014, 67);
            this.btn_xemcthd.Name = "btn_xemcthd";
            this.btn_xemcthd.Size = new System.Drawing.Size(137, 82);
            this.btn_xemcthd.TabIndex = 1;
            this.btn_xemcthd.Text = "XEM CHI TIẾT HOÁ ĐƠN";
            this.btn_xemcthd.UseVisualStyleBackColor = true;
            this.btn_xemcthd.Click += new System.EventHandler(this.btn_xemcthd_Click);
            // 
            // dgrv_hd
            // 
            this.dgrv_hd.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgrv_hd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrv_hd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_mahd,
            this.col_mamay_hd,
            this.col_makhhd,
            this.col_tgbd,
            this.col_tgkh,
            this.col_tongtien,
            this.col_ngaytaohd,
            this.col_nguoitaohd,
            this.col_ngaysuahd,
            this.col_nguoisuahd});
            this.dgrv_hd.Location = new System.Drawing.Point(0, 0);
            this.dgrv_hd.Name = "dgrv_hd";
            this.dgrv_hd.RowHeadersWidth = 51;
            this.dgrv_hd.RowTemplate.Height = 24;
            this.dgrv_hd.Size = new System.Drawing.Size(983, 423);
            this.dgrv_hd.TabIndex = 0;
            // 
            // col_mahd
            // 
            this.col_mahd.DataPropertyName = "MaHD";
            this.col_mahd.HeaderText = "Mã hoá đơn";
            this.col_mahd.MinimumWidth = 6;
            this.col_mahd.Name = "col_mahd";
            this.col_mahd.Width = 125;
            // 
            // col_mamay_hd
            // 
            this.col_mamay_hd.DataPropertyName = "MaMay";
            this.col_mamay_hd.HeaderText = "Mã máy";
            this.col_mamay_hd.MinimumWidth = 6;
            this.col_mamay_hd.Name = "col_mamay_hd";
            this.col_mamay_hd.Width = 125;
            // 
            // col_makhhd
            // 
            this.col_makhhd.DataPropertyName = "MaKH";
            this.col_makhhd.HeaderText = "Mã khách hàng";
            this.col_makhhd.MinimumWidth = 6;
            this.col_makhhd.Name = "col_makhhd";
            this.col_makhhd.Width = 125;
            // 
            // col_tgbd
            // 
            this.col_tgbd.DataPropertyName = "ThoiGianBatDau";
            this.col_tgbd.HeaderText = "Thời gian bắt đầu";
            this.col_tgbd.MinimumWidth = 6;
            this.col_tgbd.Name = "col_tgbd";
            this.col_tgbd.Width = 150;
            // 
            // col_tgkh
            // 
            this.col_tgkh.DataPropertyName = "ThoiGianKetThuc";
            this.col_tgkh.HeaderText = "Thời gian kết thúc";
            this.col_tgkh.MinimumWidth = 6;
            this.col_tgkh.Name = "col_tgkh";
            this.col_tgkh.Width = 150;
            // 
            // col_tongtien
            // 
            this.col_tongtien.DataPropertyName = "TongTien";
            this.col_tongtien.HeaderText = "Tổng tiền";
            this.col_tongtien.MinimumWidth = 6;
            this.col_tongtien.Name = "col_tongtien";
            this.col_tongtien.Width = 125;
            // 
            // col_ngaytaohd
            // 
            this.col_ngaytaohd.DataPropertyName = "NgayTao";
            this.col_ngaytaohd.HeaderText = "Ngày tạo";
            this.col_ngaytaohd.MinimumWidth = 6;
            this.col_ngaytaohd.Name = "col_ngaytaohd";
            this.col_ngaytaohd.Width = 125;
            // 
            // col_nguoitaohd
            // 
            this.col_nguoitaohd.DataPropertyName = "NguoiTao";
            this.col_nguoitaohd.HeaderText = "Người tạo";
            this.col_nguoitaohd.MinimumWidth = 6;
            this.col_nguoitaohd.Name = "col_nguoitaohd";
            this.col_nguoitaohd.Width = 125;
            // 
            // col_ngaysuahd
            // 
            this.col_ngaysuahd.DataPropertyName = "NgaySua";
            this.col_ngaysuahd.HeaderText = "Ngày sửa";
            this.col_ngaysuahd.MinimumWidth = 6;
            this.col_ngaysuahd.Name = "col_ngaysuahd";
            this.col_ngaysuahd.Width = 125;
            // 
            // col_nguoisuahd
            // 
            this.col_nguoisuahd.DataPropertyName = "NguoiSua";
            this.col_nguoisuahd.HeaderText = "Người sửa";
            this.col_nguoisuahd.MinimumWidth = 6;
            this.col_nguoisuahd.Name = "col_nguoisuahd";
            this.col_nguoisuahd.Width = 125;
            // 
            // btnExportFile
            // 
            this.btnExportFile.Location = new System.Drawing.Point(1029, 283);
            this.btnExportFile.Name = "btnExportFile";
            this.btnExportFile.Size = new System.Drawing.Size(101, 55);
            this.btnExportFile.TabIndex = 10;
            this.btnExportFile.Text = "Xuất File";
            this.btnExportFile.UseVisualStyleBackColor = true;
            this.btnExportFile.Click += new System.EventHandler(this.btnExportFile_Click);
            // 
            // btnDecyptDes
            // 
            this.btnDecyptDes.Location = new System.Drawing.Point(1029, 353);
            this.btnDecyptDes.Name = "btnDecyptDes";
            this.btnDecyptDes.Size = new System.Drawing.Size(101, 65);
            this.btnDecyptDes.TabIndex = 11;
            this.btnDecyptDes.Text = "Giải mã file";
            this.btnDecyptDes.UseVisualStyleBackColor = true;
            this.btnDecyptDes.Click += new System.EventHandler(this.btnDecyptDes_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1431, 567);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.btn_logout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_may)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tab_dichvu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_dv)).EndInit();
            this.tab_khach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_kh)).EndInit();
            this.tab_may.ResumeLayout(false);
            this.tab_hoadon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_hd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.DataGridView dgrv_may;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tab_may;
        private System.Windows.Forms.TabPage tab_khach;
        private System.Windows.Forms.TabPage tab_dichvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_mamay;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ngaytao;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ngtao;
        private System.Windows.Forms.Button btn_delete_kh;
        private System.Windows.Forms.DataGridView dgrv_kh;
        private System.Windows.Forms.Button btn_insert_kh;
        private System.Windows.Forms.Button btn_update_kh;
        private FontAwesome.Sharp.IconButton icon_refresh_kh;
        private System.Windows.Forms.TabPage tab_hoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cccd;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ngaytao_kh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nguoitao_kh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ngaysua_kh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nguoisua_kh;
        private FontAwesome.Sharp.IconButton btn_refresh;
        private System.Windows.Forms.Button btn_update_may;
        private System.Windows.Forms.Button btn_del_may;
        private System.Windows.Forms.Button btn_insertMay;
        private FontAwesome.Sharp.IconButton btn_rf_dv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_xemcthd;
        private System.Windows.Forms.DataGridView dgrv_hd;
        private System.Windows.Forms.DataGridView dgrv_dv;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_madv;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tendv;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ngaytao_dv;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nguoitao_dv;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ngaysua_dv;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nguoisua_dv;
        private FontAwesome.Sharp.IconButton btn_rf_hd;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_mamay_hd;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_makhhd;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tgbd;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tgkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ngaytaohd;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nguoitaohd;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ngaysuahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nguoisuahd;
        private System.Windows.Forms.Button btnExportFile;
        private System.Windows.Forms.Button btnDecyptDes;
    }
}