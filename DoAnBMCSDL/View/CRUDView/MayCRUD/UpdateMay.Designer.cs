namespace DoAnBMCSDL.View.CRUDView.MayCRUD
{
    partial class UpdateMay
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
            this.cmb_trangthai = new System.Windows.Forms.ComboBox();
            this.cmb_loaimay = new System.Windows.Forms.ComboBox();
            this.btn_cncl = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_trangthai
            // 
            this.cmb_trangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_trangthai.FormattingEnabled = true;
            this.cmb_trangthai.Location = new System.Drawing.Point(378, 160);
            this.cmb_trangthai.Name = "cmb_trangthai";
            this.cmb_trangthai.Size = new System.Drawing.Size(250, 28);
            this.cmb_trangthai.TabIndex = 33;
            // 
            // cmb_loaimay
            // 
            this.cmb_loaimay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_loaimay.FormattingEnabled = true;
            this.cmb_loaimay.Location = new System.Drawing.Point(378, 93);
            this.cmb_loaimay.Name = "cmb_loaimay";
            this.cmb_loaimay.Size = new System.Drawing.Size(250, 28);
            this.cmb_loaimay.TabIndex = 32;
            // 
            // btn_cncl
            // 
            this.btn_cncl.BackColor = System.Drawing.Color.Tomato;
            this.btn_cncl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cncl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cncl.Location = new System.Drawing.Point(428, 321);
            this.btn_cncl.Name = "btn_cncl";
            this.btn_cncl.Size = new System.Drawing.Size(126, 36);
            this.btn_cncl.TabIndex = 31;
            this.btn_cncl.Text = "CANCEL";
            this.btn_cncl.UseVisualStyleBackColor = false;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_update.Location = new System.Drawing.Point(258, 321);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(126, 36);
            this.btn_update.TabIndex = 30;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Trạng thái";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Loại máy";
            // 
            // UpdateMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_trangthai);
            this.Controls.Add(this.cmb_loaimay);
            this.Controls.Add(this.btn_cncl);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateMay";
            this.Text = "UpdateMay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_trangthai;
        private System.Windows.Forms.ComboBox cmb_loaimay;
        private System.Windows.Forms.Button btn_cncl;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}