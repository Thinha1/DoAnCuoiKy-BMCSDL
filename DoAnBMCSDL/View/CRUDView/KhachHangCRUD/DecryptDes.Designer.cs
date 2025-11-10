namespace DoAnBMCSDL.View.CRUDView.KhachHangCRUD
{
    partial class DecryptDes
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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tb_Decrypt = new System.Windows.Forms.TabPage();
            this.key = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_filedec = new System.Windows.Forms.TextBox();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.btn_decbrow = new System.Windows.Forms.Button();
            this.btn_keybrow = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl2.SuspendLayout();
            this.tb_Decrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tb_Decrypt);
            this.tabControl2.Location = new System.Drawing.Point(12, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(776, 392);
            this.tabControl2.TabIndex = 0;
            // 
            // tb_Decrypt
            // 
            this.tb_Decrypt.BackColor = System.Drawing.Color.Transparent;
            this.tb_Decrypt.Controls.Add(this.button1);
            this.tb_Decrypt.Controls.Add(this.btn_keybrow);
            this.tb_Decrypt.Controls.Add(this.btn_decbrow);
            this.tb_Decrypt.Controls.Add(this.txt_key);
            this.tb_Decrypt.Controls.Add(this.txt_filedec);
            this.tb_Decrypt.Controls.Add(this.label2);
            this.tb_Decrypt.Controls.Add(this.key);
            this.tb_Decrypt.Location = new System.Drawing.Point(4, 25);
            this.tb_Decrypt.Name = "tb_Decrypt";
            this.tb_Decrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Decrypt.Size = new System.Drawing.Size(768, 363);
            this.tb_Decrypt.TabIndex = 0;
            this.tb_Decrypt.Text = "Decrypt";
            // 
            // key
            // 
            this.key.AutoSize = true;
            this.key.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.key.Location = new System.Drawing.Point(64, 150);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(52, 25);
            this.key.TabIndex = 0;
            this.key.Text = "KEY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "FILE";
            // 
            // txt_filedec
            // 
            this.txt_filedec.Location = new System.Drawing.Point(123, 91);
            this.txt_filedec.Name = "txt_filedec";
            this.txt_filedec.Size = new System.Drawing.Size(508, 22);
            this.txt_filedec.TabIndex = 2;
            // 
            // txt_key
            // 
            this.txt_key.Location = new System.Drawing.Point(123, 154);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(508, 22);
            this.txt_key.TabIndex = 3;
            // 
            // btn_decbrow
            // 
            this.btn_decbrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_decbrow.Location = new System.Drawing.Point(656, 84);
            this.btn_decbrow.Name = "btn_decbrow";
            this.btn_decbrow.Size = new System.Drawing.Size(64, 34);
            this.btn_decbrow.TabIndex = 4;
            this.btn_decbrow.Text = "...";
            this.btn_decbrow.UseVisualStyleBackColor = true;
            this.btn_decbrow.Click += new System.EventHandler(this.btn_decbrow_Click);
            // 
            // btn_keybrow
            // 
            this.btn_keybrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_keybrow.Location = new System.Drawing.Point(656, 150);
            this.btn_keybrow.Name = "btn_keybrow";
            this.btn_keybrow.Size = new System.Drawing.Size(64, 34);
            this.btn_keybrow.TabIndex = 5;
            this.btn_keybrow.Text = "...";
            this.btn_keybrow.UseVisualStyleBackColor = true;
            this.btn_keybrow.Click += new System.EventHandler(this.btn_keybrow_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(357, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 54);
            this.button1.TabIndex = 6;
            this.button1.Text = "Decrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DecryptDes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl2);
            this.Name = "DecryptDes";
            this.Text = "DecryptDes";
            this.tabControl2.ResumeLayout(false);
            this.tb_Decrypt.ResumeLayout(false);
            this.tb_Decrypt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tb_Decrypt;
        private System.Windows.Forms.TextBox txt_key;
        private System.Windows.Forms.TextBox txt_filedec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label key;
        private System.Windows.Forms.Button btn_keybrow;
        private System.Windows.Forms.Button btn_decbrow;
        private System.Windows.Forms.Button button1;
    }
}