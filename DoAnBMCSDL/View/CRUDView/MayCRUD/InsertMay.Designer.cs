namespace DoAnBMCSDL.View.CRUDView.MayCRUD
{
    partial class InsertMay
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
            this.btn_cncl = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_loaimay = new System.Windows.Forms.ComboBox();
            this.cmb_trangthai = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_cncl
            // 
            this.btn_cncl.BackColor = System.Drawing.Color.Tomato;
            this.btn_cncl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cncl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cncl.Location = new System.Drawing.Point(393, 210);
            this.btn_cncl.Name = "btn_cncl";
            this.btn_cncl.Size = new System.Drawing.Size(126, 36);
            this.btn_cncl.TabIndex = 23;
            this.btn_cncl.Text = "CANCEL";
            this.btn_cncl.UseVisualStyleBackColor = false;
            this.btn_cncl.Click += new System.EventHandler(this.btn_cncl_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_insert.Location = new System.Drawing.Point(223, 210);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(126, 36);
            this.btn_insert.TabIndex = 22;
            this.btn_insert.Text = "INSERT";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Trạng thái";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Loại máy";
            // 
            // cmb_loaimay
            // 
            this.cmb_loaimay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_loaimay.FormattingEnabled = true;
            this.cmb_loaimay.Location = new System.Drawing.Point(339, 67);
            this.cmb_loaimay.Name = "cmb_loaimay";
            this.cmb_loaimay.Size = new System.Drawing.Size(250, 28);
            this.cmb_loaimay.TabIndex = 26;
            // 
            // cmb_trangthai
            // 
            this.cmb_trangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_trangthai.FormattingEnabled = true;
            this.cmb_trangthai.Location = new System.Drawing.Point(339, 134);
            this.cmb_trangthai.Name = "cmb_trangthai";
            this.cmb_trangthai.Size = new System.Drawing.Size(250, 28);
            this.cmb_trangthai.TabIndex = 27;
            // 
            // InsertMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 344);
            this.Controls.Add(this.cmb_trangthai);
            this.Controls.Add(this.cmb_loaimay);
            this.Controls.Add(this.btn_cncl);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InsertMay";
            this.Text = "InsertMay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_cncl;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_loaimay;
        private System.Windows.Forms.ComboBox cmb_trangthai;
    }
}