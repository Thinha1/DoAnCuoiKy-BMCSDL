namespace DoAnBMCSDL.View.SignView
{
    partial class VerifySignature
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
            this.btn_oppdf = new System.Windows.Forms.Button();
            this.btn_opencert = new System.Windows.Forms.Button();
            this.txt_pdf = new System.Windows.Forms.TextBox();
            this.txt_cert = new System.Windows.Forms.TextBox();
            this.btn_verify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_oppdf
            // 
            this.btn_oppdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_oppdf.Location = new System.Drawing.Point(586, 69);
            this.btn_oppdf.Name = "btn_oppdf";
            this.btn_oppdf.Size = new System.Drawing.Size(148, 69);
            this.btn_oppdf.TabIndex = 0;
            this.btn_oppdf.Text = "OPEN PDF FILE";
            this.btn_oppdf.UseVisualStyleBackColor = true;
            this.btn_oppdf.Click += new System.EventHandler(this.btn_oppdf_Click);
            // 
            // btn_opencert
            // 
            this.btn_opencert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_opencert.Location = new System.Drawing.Point(586, 174);
            this.btn_opencert.Name = "btn_opencert";
            this.btn_opencert.Size = new System.Drawing.Size(148, 83);
            this.btn_opencert.TabIndex = 1;
            this.btn_opencert.Text = "OPEN CERTIFICATE FILE";
            this.btn_opencert.UseVisualStyleBackColor = true;
            this.btn_opencert.Click += new System.EventHandler(this.btn_opencert_Click);
            // 
            // txt_pdf
            // 
            this.txt_pdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pdf.Location = new System.Drawing.Point(169, 90);
            this.txt_pdf.Name = "txt_pdf";
            this.txt_pdf.Size = new System.Drawing.Size(398, 27);
            this.txt_pdf.TabIndex = 2;
            // 
            // txt_cert
            // 
            this.txt_cert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cert.Location = new System.Drawing.Point(169, 214);
            this.txt_cert.Name = "txt_cert";
            this.txt_cert.Size = new System.Drawing.Size(398, 27);
            this.txt_cert.TabIndex = 3;
            // 
            // btn_verify
            // 
            this.btn_verify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verify.Location = new System.Drawing.Point(300, 333);
            this.btn_verify.Name = "btn_verify";
            this.btn_verify.Size = new System.Drawing.Size(148, 83);
            this.btn_verify.TabIndex = 4;
            this.btn_verify.Text = "VERIFY";
            this.btn_verify.UseVisualStyleBackColor = true;
            this.btn_verify.Click += new System.EventHandler(this.btn_verify_Click);
            // 
            // VerifySignature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_verify);
            this.Controls.Add(this.txt_cert);
            this.Controls.Add(this.txt_pdf);
            this.Controls.Add(this.btn_opencert);
            this.Controls.Add(this.btn_oppdf);
            this.Name = "VerifySignature";
            this.Text = "VerifySignature";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_oppdf;
        private System.Windows.Forms.Button btn_opencert;
        private System.Windows.Forms.TextBox txt_pdf;
        private System.Windows.Forms.TextBox txt_cert;
        private System.Windows.Forms.Button btn_verify;
    }
}