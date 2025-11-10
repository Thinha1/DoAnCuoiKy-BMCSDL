namespace DoAnBMCSDL.View
{
    partial class ChiTietHoaDonForm
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
            this.dgrv_cthd = new System.Windows.Forms.DataGridView();
            this.col_mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_madv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ngaytao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nguoitao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ngaysua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nguoisua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_kyhd = new System.Windows.Forms.Button();
            this.btn_rtn = new System.Windows.Forms.Button();
            this.btn_xuatfilepdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_cthd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrv_cthd
            // 
            this.dgrv_cthd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrv_cthd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_mahd,
            this.col_madv,
            this.col_soluong,
            this.col_thanhtien,
            this.col_ngaytao,
            this.col_nguoitao,
            this.col_ngaysua,
            this.col_nguoisua});
            this.dgrv_cthd.Location = new System.Drawing.Point(3, 58);
            this.dgrv_cthd.Name = "dgrv_cthd";
            this.dgrv_cthd.RowHeadersWidth = 51;
            this.dgrv_cthd.RowTemplate.Height = 24;
            this.dgrv_cthd.Size = new System.Drawing.Size(917, 280);
            this.dgrv_cthd.TabIndex = 0;
            this.dgrv_cthd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrv_cthd_CellContentClick);
            // 
            // col_mahd
            // 
            this.col_mahd.DataPropertyName = "MaHD";
            this.col_mahd.HeaderText = "Mã hoá đợn";
            this.col_mahd.MinimumWidth = 6;
            this.col_mahd.Name = "col_mahd";
            this.col_mahd.Width = 125;
            // 
            // col_madv
            // 
            this.col_madv.DataPropertyName = "MaDV";
            this.col_madv.HeaderText = "Mã dịch vụ";
            this.col_madv.MinimumWidth = 6;
            this.col_madv.Name = "col_madv";
            this.col_madv.Width = 125;
            // 
            // col_soluong
            // 
            this.col_soluong.DataPropertyName = "SoLuong";
            this.col_soluong.HeaderText = "Số lượng";
            this.col_soluong.MinimumWidth = 6;
            this.col_soluong.Name = "col_soluong";
            this.col_soluong.Width = 125;
            // 
            // col_thanhtien
            // 
            this.col_thanhtien.DataPropertyName = "ThanhTien";
            this.col_thanhtien.HeaderText = "Thành tiền";
            this.col_thanhtien.MinimumWidth = 6;
            this.col_thanhtien.Name = "col_thanhtien";
            this.col_thanhtien.Width = 125;
            // 
            // col_ngaytao
            // 
            this.col_ngaytao.DataPropertyName = "NgayTao";
            this.col_ngaytao.HeaderText = "Ngày tạo";
            this.col_ngaytao.MinimumWidth = 6;
            this.col_ngaytao.Name = "col_ngaytao";
            this.col_ngaytao.Width = 125;
            // 
            // col_nguoitao
            // 
            this.col_nguoitao.DataPropertyName = "NguoiTao";
            this.col_nguoitao.HeaderText = "Người tạo";
            this.col_nguoitao.MinimumWidth = 6;
            this.col_nguoitao.Name = "col_nguoitao";
            this.col_nguoitao.Width = 125;
            // 
            // col_ngaysua
            // 
            this.col_ngaysua.DataPropertyName = "NgaySua";
            this.col_ngaysua.HeaderText = "Ngày sửa";
            this.col_ngaysua.MinimumWidth = 6;
            this.col_ngaysua.Name = "col_ngaysua";
            this.col_ngaysua.Width = 125;
            // 
            // col_nguoisua
            // 
            this.col_nguoisua.DataPropertyName = "NguoiSua";
            this.col_nguoisua.HeaderText = "Người sửa";
            this.col_nguoisua.MinimumWidth = 6;
            this.col_nguoisua.Name = "col_nguoisua";
            this.col_nguoisua.Width = 125;
            // 
            // btn_kyhd
            // 
            this.btn_kyhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kyhd.Location = new System.Drawing.Point(954, 95);
            this.btn_kyhd.Name = "btn_kyhd";
            this.btn_kyhd.Size = new System.Drawing.Size(185, 73);
            this.btn_kyhd.TabIndex = 1;
            this.btn_kyhd.Text = "KÝ HOÁ ĐƠN";
            this.btn_kyhd.UseVisualStyleBackColor = true;
            this.btn_kyhd.Click += new System.EventHandler(this.btn_kyhd_Click);
            // 
            // btn_rtn
            // 
            this.btn_rtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rtn.Location = new System.Drawing.Point(954, 317);
            this.btn_rtn.Name = "btn_rtn";
            this.btn_rtn.Size = new System.Drawing.Size(185, 75);
            this.btn_rtn.TabIndex = 2;
            this.btn_rtn.Text = "TRỞ VỀ";
            this.btn_rtn.UseVisualStyleBackColor = true;
            this.btn_rtn.Click += new System.EventHandler(this.btn_rtn_Click);
            // 
            // btn_xuatfilepdf
            // 
            this.btn_xuatfilepdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xuatfilepdf.Location = new System.Drawing.Point(954, 205);
            this.btn_xuatfilepdf.Name = "btn_xuatfilepdf";
            this.btn_xuatfilepdf.Size = new System.Drawing.Size(185, 75);
            this.btn_xuatfilepdf.TabIndex = 3;
            this.btn_xuatfilepdf.Text = "XUẤT FILE PDF";
            this.btn_xuatfilepdf.UseVisualStyleBackColor = true;
            this.btn_xuatfilepdf.Click += new System.EventHandler(this.btn_xuatfilepdf_Click);
            // 
            // ChiTietHoaDonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 591);
            this.Controls.Add(this.btn_xuatfilepdf);
            this.Controls.Add(this.btn_rtn);
            this.Controls.Add(this.btn_kyhd);
            this.Controls.Add(this.dgrv_cthd);
            this.Name = "ChiTietHoaDonForm";
            this.Text = "ChiTietHoaDonForm";
            this.Load += new System.EventHandler(this.ChiTietHoaDonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_cthd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_kyhd;
        private System.Windows.Forms.Button btn_rtn;
        private System.Windows.Forms.DataGridView dgrv_cthd;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_madv;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_thanhtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ngaytao;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nguoitao;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ngaysua;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nguoisua;
        private System.Windows.Forms.Button btn_xuatfilepdf;
    }
}