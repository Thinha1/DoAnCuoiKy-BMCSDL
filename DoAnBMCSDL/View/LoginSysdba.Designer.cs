namespace OracleConnect.View
{
    partial class LoginSysdba
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_usernamesysdba = new System.Windows.Forms.TextBox();
            this.txt_passwordsysdba = new System.Windows.Forms.TextBox();
            this.btn_loginsysdba = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_sidsysdba = new System.Windows.Forms.TextBox();
            this.txt_hostsysdba = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_portsysdba = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN INTO SYSDBA ACCOUNT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password: ";
            // 
            // txt_usernamesysdba
            // 
            this.txt_usernamesysdba.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usernamesysdba.Location = new System.Drawing.Point(269, 165);
            this.txt_usernamesysdba.Name = "txt_usernamesysdba";
            this.txt_usernamesysdba.Size = new System.Drawing.Size(145, 27);
            this.txt_usernamesysdba.TabIndex = 3;
            // 
            // txt_passwordsysdba
            // 
            this.txt_passwordsysdba.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passwordsysdba.Location = new System.Drawing.Point(269, 200);
            this.txt_passwordsysdba.Name = "txt_passwordsysdba";
            this.txt_passwordsysdba.PasswordChar = '*';
            this.txt_passwordsysdba.Size = new System.Drawing.Size(145, 27);
            this.txt_passwordsysdba.TabIndex = 4;
            // 
            // btn_loginsysdba
            // 
            this.btn_loginsysdba.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_loginsysdba.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loginsysdba.Location = new System.Drawing.Point(200, 250);
            this.btn_loginsysdba.Name = "btn_loginsysdba";
            this.btn_loginsysdba.Size = new System.Drawing.Size(130, 49);
            this.btn_loginsysdba.TabIndex = 5;
            this.btn_loginsysdba.Text = "LOGIN";
            this.btn_loginsysdba.UseVisualStyleBackColor = false;
            this.btn_loginsysdba.Click += new System.EventHandler(this.btn_loginsysdba_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(128, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sid: ";
            // 
            // txt_sidsysdba
            // 
            this.txt_sidsysdba.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sidsysdba.Location = new System.Drawing.Point(269, 132);
            this.txt_sidsysdba.Name = "txt_sidsysdba";
            this.txt_sidsysdba.Size = new System.Drawing.Size(145, 27);
            this.txt_sidsysdba.TabIndex = 7;
            this.txt_sidsysdba.Text = "quanlynet";
            // 
            // txt_hostsysdba
            // 
            this.txt_hostsysdba.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hostsysdba.Location = new System.Drawing.Point(269, 62);
            this.txt_hostsysdba.Name = "txt_hostsysdba";
            this.txt_hostsysdba.Size = new System.Drawing.Size(145, 27);
            this.txt_hostsysdba.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(125, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Host: ";
            // 
            // txt_portsysdba
            // 
            this.txt_portsysdba.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_portsysdba.Location = new System.Drawing.Point(269, 95);
            this.txt_portsysdba.Name = "txt_portsysdba";
            this.txt_portsysdba.Size = new System.Drawing.Size(145, 27);
            this.txt_portsysdba.TabIndex = 11;
            this.txt_portsysdba.Text = "1521";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(125, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Port:";
            // 
            // LoginSysdba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 362);
            this.Controls.Add(this.txt_portsysdba);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_hostsysdba);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_sidsysdba);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_loginsysdba);
            this.Controls.Add(this.txt_passwordsysdba);
            this.Controls.Add(this.txt_usernamesysdba);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginSysdba";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_usernamesysdba;
        private System.Windows.Forms.TextBox txt_passwordsysdba;
        private System.Windows.Forms.Button btn_loginsysdba;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_sidsysdba;
        private System.Windows.Forms.TextBox txt_hostsysdba;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_portsysdba;
        private System.Windows.Forms.Label label6;
    }
}