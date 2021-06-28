
namespace MyFactoryClientType2
{
    partial class FormLogin
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
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxServerPort = new System.Windows.Forms.TextBox();
            this.textBoxServerIp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMyPort = new System.Windows.Forms.TextBox();
            this.textBoxMyIp = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxSender = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "user name";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(112, 173);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(112, 212);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Server Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Server IP";
            // 
            // textBoxServerPort
            // 
            this.textBoxServerPort.Location = new System.Drawing.Point(275, 47);
            this.textBoxServerPort.Name = "textBoxServerPort";
            this.textBoxServerPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxServerPort.TabIndex = 17;
            this.textBoxServerPort.Text = "13000";
            // 
            // textBoxServerIp
            // 
            this.textBoxServerIp.Location = new System.Drawing.Point(77, 48);
            this.textBoxServerIp.Name = "textBoxServerIp";
            this.textBoxServerIp.Size = new System.Drawing.Size(100, 20);
            this.textBoxServerIp.TabIndex = 16;
            this.textBoxServerIp.Text = "127.0.0.1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "MY PORT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "MY IP";
            // 
            // textBoxMyPort
            // 
            this.textBoxMyPort.Location = new System.Drawing.Point(275, 12);
            this.textBoxMyPort.Name = "textBoxMyPort";
            this.textBoxMyPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxMyPort.TabIndex = 13;
            this.textBoxMyPort.Text = "15000";
            // 
            // textBoxMyIp
            // 
            this.textBoxMyIp.Location = new System.Drawing.Point(77, 12);
            this.textBoxMyIp.Name = "textBoxMyIp";
            this.textBoxMyIp.Size = new System.Drawing.Size(100, 20);
            this.textBoxMyIp.TabIndex = 12;
            this.textBoxMyIp.Text = "127.0.0.1";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(256, 181);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(105, 51);
            this.buttonLogin.TabIndex = 20;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxSender
            // 
            this.textBoxSender.Location = new System.Drawing.Point(175, 73);
            this.textBoxSender.Multiline = true;
            this.textBoxSender.Name = "textBoxSender";
            this.textBoxSender.Size = new System.Drawing.Size(200, 75);
            this.textBoxSender.TabIndex = 26;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 259);
            this.Controls.Add(this.textBoxSender);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxServerPort);
            this.Controls.Add(this.textBoxServerIp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxMyPort);
            this.Controls.Add(this.textBoxMyIp);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxServerPort;
        private System.Windows.Forms.TextBox textBoxServerIp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBoxMyPort;
        public System.Windows.Forms.TextBox textBoxMyIp;
        private System.Windows.Forms.Button buttonLogin;
        public System.Windows.Forms.TextBox textBoxSender;
    }
}