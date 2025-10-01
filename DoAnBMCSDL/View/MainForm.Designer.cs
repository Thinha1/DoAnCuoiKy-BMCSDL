namespace OracleConnect.View
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lbl_user = new System.Windows.Forms.Label();
            this.btn_logout_all = new System.Windows.Forms.Button();
            this.dgrv_may = new System.Windows.Forms.DataGridView();
            this.col_mamay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ngaytao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ngtao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tab_dichvu = new System.Windows.Forms.TabPage();
            this.tab_khach = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.dgrv_kh = new System.Windows.Forms.DataGridView();
            this.btn_insert_kh = new System.Windows.Forms.Button();
            this.tab_may = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.col_makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cccd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ngaytao_kh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nguoitao_kh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_may)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tab_khach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_kh)).BeginInit();
            this.tab_may.SuspendLayout();
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
            this.lbl_user.Location = new System.Drawing.Point(1177, 51);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(121, 29);
            this.lbl_user.TabIndex = 1;
            this.lbl_user.Text = "Welcome!";
            // 
            // btn_logout_all
            // 
            this.btn_logout_all.Location = new System.Drawing.Point(1252, 243);
            this.btn_logout_all.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_logout_all.Name = "btn_logout_all";
            this.btn_logout_all.Size = new System.Drawing.Size(101, 41);
            this.btn_logout_all.TabIndex = 2;
            this.btn_logout_all.Text = "LOGOUT ALL";
            this.btn_logout_all.UseVisualStyleBackColor = true;
            this.btn_logout_all.Click += new System.EventHandler(this.btn_logout_all_Click);
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
            this.dgrv_may.Location = new System.Drawing.Point(0, 4);
            this.dgrv_may.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgrv_may.Name = "dgrv_may";
            this.dgrv_may.RowHeadersWidth = 51;
            this.dgrv_may.RowTemplate.Height = 24;
            this.dgrv_may.Size = new System.Drawing.Size(988, 329);
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
            this.tabControlMain.ItemSize = new System.Drawing.Size(50, 21);
            this.tabControlMain.Location = new System.Drawing.Point(28, 26);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1143, 358);
            this.tabControlMain.TabIndex = 4;
            this.tabControlMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlMain_Selected);
            // 
            // tab_dichvu
            // 
            this.tab_dichvu.BackColor = System.Drawing.Color.Transparent;
            this.tab_dichvu.Location = new System.Drawing.Point(4, 25);
            this.tab_dichvu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_dichvu.Name = "tab_dichvu";
            this.tab_dichvu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_dichvu.Size = new System.Drawing.Size(1135, 329);
            this.tab_dichvu.TabIndex = 2;
            this.tab_dichvu.Text = "Dịch vụ";
            // 
            // tab_khach
            // 
            this.tab_khach.BackColor = System.Drawing.Color.White;
            this.tab_khach.Controls.Add(this.button3);
            this.tab_khach.Controls.Add(this.dgrv_kh);
            this.tab_khach.Controls.Add(this.btn_insert_kh);
            this.tab_khach.ForeColor = System.Drawing.Color.Black;
            this.tab_khach.Location = new System.Drawing.Point(4, 25);
            this.tab_khach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_khach.Name = "tab_khach";
            this.tab_khach.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_khach.Size = new System.Drawing.Size(1135, 329);
            this.tab_khach.TabIndex = 1;
            this.tab_khach.Text = "Khách hàng";
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(997, 115);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 41);
            this.button3.TabIndex = 7;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
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
            this.col_nguoitao_kh});
            this.dgrv_kh.Location = new System.Drawing.Point(3, 5);
            this.dgrv_kh.Name = "dgrv_kh";
            this.dgrv_kh.RowHeadersWidth = 51;
            this.dgrv_kh.RowTemplate.Height = 24;
            this.dgrv_kh.Size = new System.Drawing.Size(970, 319);
            this.dgrv_kh.TabIndex = 0;
            // 
            // btn_insert_kh
            // 
            this.btn_insert_kh.ForeColor = System.Drawing.Color.Black;
            this.btn_insert_kh.Location = new System.Drawing.Point(997, 60);
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
            this.tab_may.Controls.Add(this.button2);
            this.tab_may.Controls.Add(this.button1);
            this.tab_may.Controls.Add(this.dgrv_may);
            this.tab_may.ForeColor = System.Drawing.Color.Black;
            this.tab_may.Location = new System.Drawing.Point(4, 25);
            this.tab_may.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_may.Name = "tab_may";
            this.tab_may.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_may.Size = new System.Drawing.Size(1135, 329);
            this.tab_may.TabIndex = 0;
            this.tab_may.Text = "Máy";
            this.tab_may.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(997, 112);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(997, 57);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // col_makh
            // 
            this.col_makh.DataPropertyName = "MaKH";
            this.col_makh.HeaderText = "Mã khách hàng";
            this.col_makh.MinimumWidth = 6;
            this.col_makh.Name = "col_makh";
            this.col_makh.Width = 125;
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
            dataGridViewCellStyle1.Format = "#,##0 đ";
            this.col_sodu.DefaultCellStyle = dataGridViewCellStyle1;
            this.col_sodu.HeaderText = "Số dư";
            this.col_sodu.MinimumWidth = 6;
            this.col_sodu.Name = "col_sodu";
            this.col_sodu.Width = 125;
            // 
            // col_ngaytao_kh
            // 
            this.col_ngaytao_kh.DataPropertyName = "NgayTao";
            dataGridViewCellStyle2.Format = "dd/MM/yy";
            this.col_ngaytao_kh.DefaultCellStyle = dataGridViewCellStyle2;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1379, 491);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.btn_logout_all);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.btn_logout);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_may)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tab_khach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_kh)).EndInit();
            this.tab_may.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Button btn_logout_all;
        private System.Windows.Forms.DataGridView dgrv_may;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tab_may;
        private System.Windows.Forms.TabPage tab_khach;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tab_dichvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_mamay;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ngaytao;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ngtao;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgrv_kh;
        private System.Windows.Forms.Button btn_insert_kh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cccd;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ngaytao_kh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nguoitao_kh;
    }
}