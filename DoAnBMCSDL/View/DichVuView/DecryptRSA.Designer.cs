namespace DoAnBMCSDL.View.DichVuView
{
    partial class DecryptRSA
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
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btn_keybrow = new System.Windows.Forms.Button();
            this.btn_decbrow = new System.Windows.Forms.Button();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.txt_filedec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(753, 350);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDecrypt);
            this.tabPage1.Controls.Add(this.btn_keybrow);
            this.tabPage1.Controls.Add(this.btn_decbrow);
            this.tabPage1.Controls.Add(this.txt_key);
            this.tabPage1.Controls.Add(this.txt_filedec);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.Coral;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(745, 321);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Decrypt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.ForeColor = System.Drawing.Color.Black;
            this.btnDecrypt.Location = new System.Drawing.Point(334, 208);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(126, 65);
            this.btnDecrypt.TabIndex = 6;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btn_keybrow
            // 
            this.btn_keybrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_keybrow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_keybrow.Location = new System.Drawing.Point(621, 127);
            this.btn_keybrow.Name = "btn_keybrow";
            this.btn_keybrow.Size = new System.Drawing.Size(64, 36);
            this.btn_keybrow.TabIndex = 5;
            this.btn_keybrow.Text = "...";
            this.btn_keybrow.UseVisualStyleBackColor = true;
            this.btn_keybrow.Click += new System.EventHandler(this.btn_keybrow_Click);
            // 
            // btn_decbrow
            // 
            this.btn_decbrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_decbrow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_decbrow.Location = new System.Drawing.Point(621, 66);
            this.btn_decbrow.Name = "btn_decbrow";
            this.btn_decbrow.Size = new System.Drawing.Size(64, 36);
            this.btn_decbrow.TabIndex = 4;
            this.btn_decbrow.Text = "...";
            this.btn_decbrow.UseVisualStyleBackColor = true;
            this.btn_decbrow.Click += new System.EventHandler(this.btn_decbrow_Click);
            // 
            // txt_key
            // 
            this.txt_key.Location = new System.Drawing.Point(231, 129);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(384, 30);
            this.txt_key.TabIndex = 3;
            // 
            // txt_filedec
            // 
            this.txt_filedec.Location = new System.Drawing.Point(231, 66);
            this.txt_filedec.Name = "txt_filedec";
            this.txt_filedec.Size = new System.Drawing.Size(384, 30);
            this.txt_filedec.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "PRIVATE KEY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(117, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "File";
            // 
            // DecryptRSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "DecryptRSA";
            this.Text = "DecyptRSA";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_key;
        private System.Windows.Forms.TextBox txt_filedec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_keybrow;
        private System.Windows.Forms.Button btn_decbrow;
        private System.Windows.Forms.Button btnDecrypt;
    }
}