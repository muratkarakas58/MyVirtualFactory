
namespace MyFactoryClientType1
{
    partial class FormMyFactoryClientType1
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
            this.buttonSenderToServer = new System.Windows.Forms.Button();
            this.textBoxListen = new System.Windows.Forms.TextBox();
            this.textBoxMyIp = new System.Windows.Forms.TextBox();
            this.textBoxMyPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxServerIp = new System.Windows.Forms.TextBox();
            this.textBoxServerPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMachineName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMachineId = new System.Windows.Forms.TextBox();
            this.comboBoxMachineType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxProductionSpeeedOfMachine = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxProductionUnitType = new System.Windows.Forms.ComboBox();
            this.textBoxSender = new System.Windows.Forms.TextBox();
            this.comboBoxMachineStatus = new System.Windows.Forms.ComboBox();
            this.labe10 = new System.Windows.Forms.Label();
            this.textBoxMachineStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonListen
            // 
            this.buttonListen.Location = new System.Drawing.Point(21, 83);
            this.buttonListen.Name = "buttonListen";
            this.buttonListen.Size = new System.Drawing.Size(210, 23);
            this.buttonListen.TabIndex = 0;
            this.buttonListen.Text = "Listen";
            this.buttonListen.UseVisualStyleBackColor = true;
            this.buttonListen.Click += new System.EventHandler(this.buttonListen_Click);
            // 
            // buttonSenderToServer
            // 
            this.buttonSenderToServer.Location = new System.Drawing.Point(250, 83);
            this.buttonSenderToServer.Name = "buttonSenderToServer";
            this.buttonSenderToServer.Size = new System.Drawing.Size(200, 23);
            this.buttonSenderToServer.TabIndex = 1;
            this.buttonSenderToServer.Text = "Sender To Server";
            this.buttonSenderToServer.UseVisualStyleBackColor = true;
            this.buttonSenderToServer.Click += new System.EventHandler(this.buttonSenderToServer_Click);
            // 
            // textBoxListen
            // 
            this.textBoxListen.Location = new System.Drawing.Point(21, 118);
            this.textBoxListen.Multiline = true;
            this.textBoxListen.Name = "textBoxListen";
            this.textBoxListen.Size = new System.Drawing.Size(210, 146);
            this.textBoxListen.TabIndex = 3;
            // 
            // textBoxMyIp
            // 
            this.textBoxMyIp.Location = new System.Drawing.Point(83, 12);
            this.textBoxMyIp.Name = "textBoxMyIp";
            this.textBoxMyIp.Size = new System.Drawing.Size(100, 20);
            this.textBoxMyIp.TabIndex = 4;
            this.textBoxMyIp.Text = "127.0.0.1";
            // 
            // textBoxMyPort
            // 
            this.textBoxMyPort.Location = new System.Drawing.Point(281, 12);
            this.textBoxMyPort.Name = "textBoxMyPort";
            this.textBoxMyPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxMyPort.TabIndex = 5;
            this.textBoxMyPort.Text = "14000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "MY IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "MY PORT";
            // 
            // textBoxServerIp
            // 
            this.textBoxServerIp.Location = new System.Drawing.Point(83, 48);
            this.textBoxServerIp.Name = "textBoxServerIp";
            this.textBoxServerIp.Size = new System.Drawing.Size(100, 20);
            this.textBoxServerIp.TabIndex = 8;
            this.textBoxServerIp.Text = "127.0.0.1";
            // 
            // textBoxServerPort
            // 
            this.textBoxServerPort.Location = new System.Drawing.Point(281, 47);
            this.textBoxServerPort.Name = "textBoxServerPort";
            this.textBoxServerPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxServerPort.TabIndex = 9;
            this.textBoxServerPort.Text = "13000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Server IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Server Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "MachineName";
            // 
            // textBoxMachineName
            // 
            this.textBoxMachineName.Location = new System.Drawing.Point(645, 15);
            this.textBoxMachineName.Name = "textBoxMachineName";
            this.textBoxMachineName.Size = new System.Drawing.Size(121, 20);
            this.textBoxMachineName.TabIndex = 13;
            this.textBoxMachineName.Text = "MachineName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(478, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "MachineId";
            // 
            // textBoxMachineId
            // 
            this.textBoxMachineId.Location = new System.Drawing.Point(645, 47);
            this.textBoxMachineId.Name = "textBoxMachineId";
            this.textBoxMachineId.Size = new System.Drawing.Size(121, 20);
            this.textBoxMachineId.TabIndex = 15;
            this.textBoxMachineId.Text = "1";
            // 
            // comboBoxMachineType
            // 
            this.comboBoxMachineType.FormattingEnabled = true;
            this.comboBoxMachineType.Items.AddRange(new object[] {
            "CNC",
            "DÖKÜM ",
            "KILIF",
            "KAPLAMA"});
            this.comboBoxMachineType.Location = new System.Drawing.Point(645, 75);
            this.comboBoxMachineType.Name = "comboBoxMachineType";
            this.comboBoxMachineType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMachineType.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(478, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "MachineType";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(478, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "ProductionSpeeedOfMachine";
            // 
            // textBoxProductionSpeeedOfMachine
            // 
            this.textBoxProductionSpeeedOfMachine.Location = new System.Drawing.Point(645, 111);
            this.textBoxProductionSpeeedOfMachine.Name = "textBoxProductionSpeeedOfMachine";
            this.textBoxProductionSpeeedOfMachine.Size = new System.Drawing.Size(121, 20);
            this.textBoxProductionSpeeedOfMachine.TabIndex = 19;
            this.textBoxProductionSpeeedOfMachine.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(481, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "ProductionUnitType";
            // 
            // comboBoxProductionUnitType
            // 
            this.comboBoxProductionUnitType.FormattingEnabled = true;
            this.comboBoxProductionUnitType.Items.AddRange(new object[] {
            "KG",
            "METRE"});
            this.comboBoxProductionUnitType.Location = new System.Drawing.Point(645, 148);
            this.comboBoxProductionUnitType.Name = "comboBoxProductionUnitType";
            this.comboBoxProductionUnitType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProductionUnitType.TabIndex = 21;
            // 
            // textBoxSender
            // 
            this.textBoxSender.Location = new System.Drawing.Point(250, 118);
            this.textBoxSender.Multiline = true;
            this.textBoxSender.Name = "textBoxSender";
            this.textBoxSender.Size = new System.Drawing.Size(200, 146);
            this.textBoxSender.TabIndex = 22;
            // 
            // comboBoxMachineStatus
            // 
            this.comboBoxMachineStatus.FormattingEnabled = true;
            this.comboBoxMachineStatus.Items.AddRange(new object[] {
            "BUSY",
            "EMPTY"});
            this.comboBoxMachineStatus.Location = new System.Drawing.Point(645, 190);
            this.comboBoxMachineStatus.Name = "comboBoxMachineStatus";
            this.comboBoxMachineStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMachineStatus.TabIndex = 23;
            this.comboBoxMachineStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxMachineStatus_SelectedIndexChanged);
            // 
            // labe10
            // 
            this.labe10.AutoSize = true;
            this.labe10.Location = new System.Drawing.Point(484, 197);
            this.labe10.Name = "labe10";
            this.labe10.Size = new System.Drawing.Size(77, 13);
            this.labe10.TabIndex = 24;
            this.labe10.Text = "machineStatus";
            // 
            // textBoxMachineStatus
            // 
            this.textBoxMachineStatus.Location = new System.Drawing.Point(772, 190);
            this.textBoxMachineStatus.Name = "textBoxMachineStatus";
            this.textBoxMachineStatus.Size = new System.Drawing.Size(16, 20);
            this.textBoxMachineStatus.TabIndex = 25;
            // 
            // FormMyFactoryClientType1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 278);
            this.Controls.Add(this.textBoxMachineStatus);
            this.Controls.Add(this.labe10);
            this.Controls.Add(this.comboBoxMachineStatus);
            this.Controls.Add(this.textBoxSender);
            this.Controls.Add(this.comboBoxProductionUnitType);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxProductionSpeeedOfMachine);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxMachineType);
            this.Controls.Add(this.textBoxMachineId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxMachineName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxServerPort);
            this.Controls.Add(this.textBoxServerIp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMyPort);
            this.Controls.Add(this.textBoxMyIp);
            this.Controls.Add(this.textBoxListen);
            this.Controls.Add(this.buttonSenderToServer);
            this.Controls.Add(this.buttonListen);
            this.Name = "FormMyFactoryClientType1";
            this.Text = "FormMyFactoryClientType1";
            this.Load += new System.EventHandler(this.FormMyFactoryClientType1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonListen;
        private System.Windows.Forms.Button buttonSenderToServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxServerIp;
        private System.Windows.Forms.TextBox textBoxServerPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMachineName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMachineId;
        private System.Windows.Forms.ComboBox comboBoxMachineType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxProductionSpeeedOfMachine;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxProductionUnitType;
        public System.Windows.Forms.TextBox textBoxMyIp;
        public System.Windows.Forms.TextBox textBoxMyPort;
        public System.Windows.Forms.TextBox textBoxListen;
        public System.Windows.Forms.TextBox textBoxSender;
        private System.Windows.Forms.Label labe10;
        public System.Windows.Forms.ComboBox comboBoxMachineStatus;
        public System.Windows.Forms.TextBox textBoxMachineStatus;
    }
}

