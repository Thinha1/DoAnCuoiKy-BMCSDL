namespace DoAnBMCSDL.View.SignView
{
    partial class DigitalSignatureForm
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
            this.btn_openprivatek = new System.Windows.Forms.Button();
            this.btn_openpdf = new System.Windows.Forms.Button();
            this.txt_pdf = new System.Windows.Forms.TextBox();
            this.btn_sign = new System.Windows.Forms.Button();
            this.txt_publickeyfile = new System.Windows.Forms.TextBox();
            this.btn_openpublick = new System.Windows.Forms.Button();
            this.txt_privatekey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_openprivatek
            // 
            this.btn_openprivatek.Location = new System.Drawing.Point(742, 50);
            this.btn_openprivatek.Name = "btn_openprivatek";
            this.btn_openprivatek.Size = new System.Drawing.Size(147, 73);
            this.btn_openprivatek.TabIndex = 2;
            this.btn_openprivatek.Text = "OPEN PRIVATE KEY";
            this.btn_openprivatek.UseVisualStyleBackColor = true;
            this.btn_openprivatek.Click += new System.EventHandler(this.btn_openprivatek_Click);
            // 
            // btn_openpdf
            // 
            this.btn_openpdf.Location = new System.Drawing.Point(742, 207);
            this.btn_openpdf.Name = "btn_openpdf";
            this.btn_openpdf.Size = new System.Drawing.Size(147, 73);
            this.btn_openpdf.TabIndex = 3;
            this.btn_openpdf.Text = "OPEN PDF FILE\r\n";
            this.btn_openpdf.UseVisualStyleBackColor = true;
            this.btn_openpdf.Click += new System.EventHandler(this.btn_openpdf_Click);
            // 
            // txt_pdf
            // 
            this.txt_pdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pdf.Location = new System.Drawing.Point(39, 229);
            this.txt_pdf.Name = "txt_pdf";
            this.txt_pdf.Size = new System.Drawing.Size(675, 27);
            this.txt_pdf.TabIndex = 4;
            // 
            // btn_sign
            // 
            this.btn_sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sign.Location = new System.Drawing.Point(426, 359);
            this.btn_sign.Name = "btn_sign";
            this.btn_sign.Size = new System.Drawing.Size(150, 93);
            this.btn_sign.TabIndex = 5;
            this.btn_sign.Text = "SIGN";
            this.btn_sign.UseVisualStyleBackColor = true;
            this.btn_sign.Click += new System.EventHandler(this.btn_sign_Click);
            // 
            // txt_publickeyfile
            // 
            this.txt_publickeyfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_publickeyfile.Location = new System.Drawing.Point(39, 150);
            this.txt_publickeyfile.Name = "txt_publickeyfile";
            this.txt_publickeyfile.Size = new System.Drawing.Size(675, 27);
            this.txt_publickeyfile.TabIndex = 7;
            // 
            // btn_openpublick
            // 
            this.btn_openpublick.Location = new System.Drawing.Point(742, 128);
            this.btn_openpublick.Name = "btn_openpublick";
            this.btn_openpublick.Size = new System.Drawing.Size(147, 73);
            this.btn_openpublick.TabIndex = 6;
            this.btn_openpublick.Text = "OPEN CERTIFICATE KEY FILE\r\n";
            this.btn_openpublick.UseVisualStyleBackColor = true;
            this.btn_openpublick.Click += new System.EventHandler(this.btn_openpublick_Click);
            // 
            // txt_privatekey
            // 
            this.txt_privatekey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_privatekey.Location = new System.Drawing.Point(39, 72);
            this.txt_privatekey.Name = "txt_privatekey";
            this.txt_privatekey.Size = new System.Drawing.Size(675, 27);
            this.txt_privatekey.TabIndex = 1;
            // 
            // DigitalSignatureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 550);
            this.Controls.Add(this.txt_publickeyfile);
            this.Controls.Add(this.btn_openpublick);
            this.Controls.Add(this.btn_sign);
            this.Controls.Add(this.txt_pdf);
            this.Controls.Add(this.btn_openpdf);
            this.Controls.Add(this.btn_openprivatek);
            this.Controls.Add(this.txt_privatekey);
            this.Name = "DigitalSignatureForm";
            this.Text = "DigitalSignatureForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_openprivatek;
        private System.Windows.Forms.Button btn_openpdf;
        private System.Windows.Forms.TextBox txt_pdf;
        private System.Windows.Forms.Button btn_sign;
        private System.Windows.Forms.TextBox txt_publickeyfile;
        private System.Windows.Forms.Button btn_openpublick;
        private System.Windows.Forms.TextBox txt_privatekey;
    }
}