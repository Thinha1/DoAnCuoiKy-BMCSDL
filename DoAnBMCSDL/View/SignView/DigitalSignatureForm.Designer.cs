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
            this.btn_genkey = new System.Windows.Forms.Button();
            this.txt_privatekey = new System.Windows.Forms.TextBox();
            this.btn_openprivatek = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_sign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_genkey
            // 
            this.btn_genkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_genkey.Location = new System.Drawing.Point(50, 495);
            this.btn_genkey.Name = "btn_genkey";
            this.btn_genkey.Size = new System.Drawing.Size(150, 93);
            this.btn_genkey.TabIndex = 0;
            this.btn_genkey.Text = "GENERATE KEY";
            this.btn_genkey.UseVisualStyleBackColor = true;
            this.btn_genkey.Click += new System.EventHandler(this.btn_genkey_Click);
            // 
            // txt_privatekey
            // 
            this.txt_privatekey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_privatekey.Location = new System.Drawing.Point(50, 50);
            this.txt_privatekey.Multiline = true;
            this.txt_privatekey.Name = "txt_privatekey";
            this.txt_privatekey.Size = new System.Drawing.Size(675, 240);
            this.txt_privatekey.TabIndex = 1;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(742, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 73);
            this.button1.TabIndex = 3;
            this.button1.Text = "OPEN PDF FILE\r\n";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(50, 333);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(675, 27);
            this.textBox1.TabIndex = 4;
            // 
            // btn_sign
            // 
            this.btn_sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sign.Location = new System.Drawing.Point(607, 495);
            this.btn_sign.Name = "btn_sign";
            this.btn_sign.Size = new System.Drawing.Size(150, 93);
            this.btn_sign.TabIndex = 5;
            this.btn_sign.Text = "SIGN";
            this.btn_sign.UseVisualStyleBackColor = true;
            // 
            // DigitalSignatureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 650);
            this.Controls.Add(this.btn_sign);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_openprivatek);
            this.Controls.Add(this.txt_privatekey);
            this.Controls.Add(this.btn_genkey);
            this.Name = "DigitalSignatureForm";
            this.Text = "DigitalSignatureForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_genkey;
        private System.Windows.Forms.TextBox txt_privatekey;
        private System.Windows.Forms.Button btn_openprivatek;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_sign;
    }
}