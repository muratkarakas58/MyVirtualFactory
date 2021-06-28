
namespace MyFactoryClientType2
{
    partial class FormMyFactoryClientType2
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
            this.textBoxMyIp = new System.Windows.Forms.TextBox();
            this.textBoxMyPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxServerIp = new System.Windows.Forms.TextBox();
            this.textBoxServerPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxMachineType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxQuantityToBeProduced = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxProductionUnitType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxSender = new System.Windows.Forms.TextBox();
            this.textBoxListen = new System.Windows.Forms.TextBox();
            this.buttonGetMachineList = new System.Windows.Forms.Button();
            this.dataGridViewGetMachineList = new System.Windows.Forms.DataGridView();
            this.buttonGetMachineWorksList = new System.Windows.Forms.Button();
            this.dataGridViewGetMachineWorksList = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMachineId = new System.Windows.Forms.TextBox();
            this.dataGridViewGetWaitingWorksList = new System.Windows.Forms.DataGridView();
            this.buttonGetWaitingWorksList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGetMachineList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGetMachineWorksList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGetWaitingWorksList)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonListen
            // 
            this.buttonListen.Location = new System.Drawing.Point(18, 114);
            this.buttonListen.Name = "buttonListen";
            this.buttonListen.Size = new System.Drawing.Size(210, 23);
            this.buttonListen.TabIndex = 0;
            this.buttonListen.Text = "Listen";
            this.buttonListen.UseVisualStyleBackColor = true;
            this.buttonListen.Click += new System.EventHandler(this.buttonListen_Click);
            // 
            // buttonSenderToServer
            // 
            this.buttonSenderToServer.Location = new System.Drawing.Point(247, 114);
            this.buttonSenderToServer.Name = "buttonSenderToServer";
            this.buttonSenderToServer.Size = new System.Drawing.Size(200, 23);
            this.buttonSenderToServer.TabIndex = 1;
            this.buttonSenderToServer.Text = "Sender To Server";
            this.buttonSenderToServer.UseVisualStyleBackColor = true;
            this.buttonSenderToServer.Click += new System.EventHandler(this.buttonSenderToServer_Click);
            // 
            // textBoxMyIp
            // 
            this.textBoxMyIp.Enabled = false;
            this.textBoxMyIp.Location = new System.Drawing.Point(83, 12);
            this.textBoxMyIp.Name = "textBoxMyIp";
            this.textBoxMyIp.Size = new System.Drawing.Size(100, 20);
            this.textBoxMyIp.TabIndex = 4;
            this.textBoxMyIp.Text = "127.0.0.1";
            // 
            // textBoxMyPort
            // 
            this.textBoxMyPort.Enabled = false;
            this.textBoxMyPort.Location = new System.Drawing.Point(281, 12);
            this.textBoxMyPort.Name = "textBoxMyPort";
            this.textBoxMyPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxMyPort.TabIndex = 5;
            this.textBoxMyPort.Text = "15000";
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
            // comboBoxMachineType
            // 
            this.comboBoxMachineType.FormattingEnabled = true;
            this.comboBoxMachineType.Items.AddRange(new object[] {
            "CNC",
            "DÖKÜM ",
            "KILIF",
            "KAPLAMA"});
            this.comboBoxMachineType.Location = new System.Drawing.Point(623, 43);
            this.comboBoxMachineType.Name = "comboBoxMachineType";
            this.comboBoxMachineType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMachineType.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(456, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "MachineType";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(456, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "QuantityToBeProduced";
            // 
            // textBoxQuantityToBeProduced
            // 
            this.textBoxQuantityToBeProduced.Location = new System.Drawing.Point(623, 79);
            this.textBoxQuantityToBeProduced.Name = "textBoxQuantityToBeProduced";
            this.textBoxQuantityToBeProduced.Size = new System.Drawing.Size(121, 20);
            this.textBoxQuantityToBeProduced.TabIndex = 19;
            this.textBoxQuantityToBeProduced.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(459, 125);
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
            this.comboBoxProductionUnitType.Location = new System.Drawing.Point(623, 116);
            this.comboBoxProductionUnitType.Name = "comboBoxProductionUnitType";
            this.comboBoxProductionUnitType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProductionUnitType.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "UserName";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Enabled = false;
            this.textBoxUserName.Location = new System.Drawing.Point(623, 12);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(121, 20);
            this.textBoxUserName.TabIndex = 23;
            this.textBoxUserName.Text = "UserName";
            // 
            // textBoxSender
            // 
            this.textBoxSender.Location = new System.Drawing.Point(247, 148);
            this.textBoxSender.Multiline = true;
            this.textBoxSender.Name = "textBoxSender";
            this.textBoxSender.Size = new System.Drawing.Size(200, 146);
            this.textBoxSender.TabIndex = 25;
            // 
            // textBoxListen
            // 
            this.textBoxListen.Location = new System.Drawing.Point(18, 148);
            this.textBoxListen.Multiline = true;
            this.textBoxListen.Name = "textBoxListen";
            this.textBoxListen.Size = new System.Drawing.Size(210, 146);
            this.textBoxListen.TabIndex = 24;
            // 
            // buttonGetMachineList
            // 
            this.buttonGetMachineList.Location = new System.Drawing.Point(21, 310);
            this.buttonGetMachineList.Name = "buttonGetMachineList";
            this.buttonGetMachineList.Size = new System.Drawing.Size(207, 41);
            this.buttonGetMachineList.TabIndex = 26;
            this.buttonGetMachineList.Text = "GetMachineList";
            this.buttonGetMachineList.UseVisualStyleBackColor = true;
            this.buttonGetMachineList.Click += new System.EventHandler(this.buttonGetMachineList_Click);
            // 
            // dataGridViewGetMachineList
            // 
            this.dataGridViewGetMachineList.AllowUserToAddRows = false;
            this.dataGridViewGetMachineList.AllowUserToDeleteRows = false;
            this.dataGridViewGetMachineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGetMachineList.Location = new System.Drawing.Point(21, 357);
            this.dataGridViewGetMachineList.Name = "dataGridViewGetMachineList";
            this.dataGridViewGetMachineList.ReadOnly = true;
            this.dataGridViewGetMachineList.Size = new System.Drawing.Size(857, 130);
            this.dataGridViewGetMachineList.TabIndex = 27;
            // 
            // buttonGetMachineWorksList
            // 
            this.buttonGetMachineWorksList.Location = new System.Drawing.Point(213, 517);
            this.buttonGetMachineWorksList.Name = "buttonGetMachineWorksList";
            this.buttonGetMachineWorksList.Size = new System.Drawing.Size(221, 36);
            this.buttonGetMachineWorksList.TabIndex = 28;
            this.buttonGetMachineWorksList.Text = "GetMachineWorksList";
            this.buttonGetMachineWorksList.UseVisualStyleBackColor = true;
            this.buttonGetMachineWorksList.Click += new System.EventHandler(this.buttonGetMachineWorksList_Click);
            // 
            // dataGridViewGetMachineWorksList
            // 
            this.dataGridViewGetMachineWorksList.AllowUserToAddRows = false;
            this.dataGridViewGetMachineWorksList.AllowUserToDeleteRows = false;
            this.dataGridViewGetMachineWorksList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGetMachineWorksList.Location = new System.Drawing.Point(21, 559);
            this.dataGridViewGetMachineWorksList.Name = "dataGridViewGetMachineWorksList";
            this.dataGridViewGetMachineWorksList.ReadOnly = true;
            this.dataGridViewGetMachineWorksList.Size = new System.Drawing.Size(857, 150);
            this.dataGridViewGetMachineWorksList.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 517);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "MachineId";
            // 
            // textBoxMachineId
            // 
            this.textBoxMachineId.Location = new System.Drawing.Point(85, 517);
            this.textBoxMachineId.Name = "textBoxMachineId";
            this.textBoxMachineId.Size = new System.Drawing.Size(100, 20);
            this.textBoxMachineId.TabIndex = 31;
            this.textBoxMachineId.Text = "2";
            // 
            // dataGridViewGetWaitingWorksList
            // 
            this.dataGridViewGetWaitingWorksList.AllowUserToAddRows = false;
            this.dataGridViewGetWaitingWorksList.AllowUserToDeleteRows = false;
            this.dataGridViewGetWaitingWorksList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGetWaitingWorksList.Location = new System.Drawing.Point(18, 762);
            this.dataGridViewGetWaitingWorksList.Name = "dataGridViewGetWaitingWorksList";
            this.dataGridViewGetWaitingWorksList.ReadOnly = true;
            this.dataGridViewGetWaitingWorksList.Size = new System.Drawing.Size(857, 130);
            this.dataGridViewGetWaitingWorksList.TabIndex = 33;
            // 
            // buttonGetWaitingWorksList
            // 
            this.buttonGetWaitingWorksList.Location = new System.Drawing.Point(18, 715);
            this.buttonGetWaitingWorksList.Name = "buttonGetWaitingWorksList";
            this.buttonGetWaitingWorksList.Size = new System.Drawing.Size(207, 41);
            this.buttonGetWaitingWorksList.TabIndex = 32;
            this.buttonGetWaitingWorksList.Text = "GetWaitingWorksList";
            this.buttonGetWaitingWorksList.UseVisualStyleBackColor = true;
            this.buttonGetWaitingWorksList.Click += new System.EventHandler(this.buttonGetWaitingWorksList_Click);
            // 
            // FormMyFactoryClientType2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 904);
            this.Controls.Add(this.dataGridViewGetWaitingWorksList);
            this.Controls.Add(this.buttonGetWaitingWorksList);
            this.Controls.Add(this.textBoxMachineId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewGetMachineWorksList);
            this.Controls.Add(this.buttonGetMachineWorksList);
            this.Controls.Add(this.dataGridViewGetMachineList);
            this.Controls.Add(this.buttonGetMachineList);
            this.Controls.Add(this.textBoxSender);
            this.Controls.Add(this.textBoxListen);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxProductionUnitType);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxQuantityToBeProduced);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxMachineType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxServerPort);
            this.Controls.Add(this.textBoxServerIp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMyPort);
            this.Controls.Add(this.textBoxMyIp);
            this.Controls.Add(this.buttonSenderToServer);
            this.Controls.Add(this.buttonListen);
            this.Name = "FormMyFactoryClientType2";
            this.Text = "FormMyFactoryClientType2";
            this.Load += new System.EventHandler(this.FormMyFactoryClientType2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGetMachineList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGetMachineWorksList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGetWaitingWorksList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonListen;
        private System.Windows.Forms.Button buttonSenderToServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxMachineType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxQuantityToBeProduced;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxProductionUnitType;
        public System.Windows.Forms.TextBox textBoxMyIp;
        public System.Windows.Forms.TextBox textBoxMyPort;
        public System.Windows.Forms.TextBox textBoxServerIp;
        public System.Windows.Forms.TextBox textBoxServerPort;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxUserName;
        public System.Windows.Forms.TextBox textBoxSender;
        public System.Windows.Forms.TextBox textBoxListen;
        private System.Windows.Forms.Button buttonGetMachineList;
        private System.Windows.Forms.DataGridView dataGridViewGetMachineList;
        private System.Windows.Forms.Button buttonGetMachineWorksList;
        private System.Windows.Forms.DataGridView dataGridViewGetMachineWorksList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMachineId;
        private System.Windows.Forms.DataGridView dataGridViewGetWaitingWorksList;
        private System.Windows.Forms.Button buttonGetWaitingWorksList;
    }
}

