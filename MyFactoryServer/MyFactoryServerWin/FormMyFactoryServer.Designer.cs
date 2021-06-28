
namespace MyFactoryServer
{
    partial class FormMyFactoryServer
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
            this.buttonListen = new System.Windows.Forms.Button();
            this.textBoxListen = new System.Windows.Forms.TextBox();
            this.buttonSenderToMachine = new System.Windows.Forms.Button();
            this.textBoxSender = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonListen
            // 
            this.buttonListen.Location = new System.Drawing.Point(31, 12);
            this.buttonListen.Name = "buttonListen";
            this.buttonListen.Size = new System.Drawing.Size(371, 50);
            this.buttonListen.TabIndex = 0;
            this.buttonListen.Text = "Listen";
            this.buttonListen.UseVisualStyleBackColor = true;
            this.buttonListen.Click += new System.EventHandler(this.buttonListen_Click);
            // 
            // textBoxListen
            // 
            this.textBoxListen.Location = new System.Drawing.Point(31, 88);
            this.textBoxListen.Multiline = true;
            this.textBoxListen.Name = "textBoxListen";
            this.textBoxListen.Size = new System.Drawing.Size(371, 350);
            this.textBoxListen.TabIndex = 1;
            // 
            // buttonSenderToMachine
            // 
            this.buttonSenderToMachine.Location = new System.Drawing.Point(431, 12);
            this.buttonSenderToMachine.Name = "buttonSenderToMachine";
            this.buttonSenderToMachine.Size = new System.Drawing.Size(357, 50);
            this.buttonSenderToMachine.TabIndex = 2;
            this.buttonSenderToMachine.Text = "Sender To Machine";
            this.buttonSenderToMachine.UseVisualStyleBackColor = true;
            this.buttonSenderToMachine.Click += new System.EventHandler(this.buttonSenderToMachine_Click);
            // 
            // textBoxSender
            // 
            this.textBoxSender.Location = new System.Drawing.Point(431, 88);
            this.textBoxSender.Multiline = true;
            this.textBoxSender.Name = "textBoxSender";
            this.textBoxSender.Size = new System.Drawing.Size(357, 350);
            this.textBoxSender.TabIndex = 3;
            // 
            // FormMyFactoryServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxSender);
            this.Controls.Add(this.buttonSenderToMachine);
            this.Controls.Add(this.textBoxListen);
            this.Controls.Add(this.buttonListen);
            this.Name = "FormMyFactoryServer";
            this.Text = "FormMyFactoryServer";
            this.Load += new System.EventHandler(this.FormMyFactoryServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonListen;
        private System.Windows.Forms.Button buttonSenderToMachine;
        private System.Windows.Forms.TextBox textBoxSender;
        public System.Windows.Forms.TextBox textBoxListen;
    }
}

