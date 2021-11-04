namespace AdvancedSample
{
    partial class Form_PDO_ETParam
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
            this.btnSDOReadCheck = new System.Windows.Forms.Button();
            this.btnSDOWriteCheck = new System.Windows.Forms.Button();
            this.txtSubIndex = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.btnSDORead = new System.Windows.Forms.Button();
            this.btnSDOWrite = new System.Windows.Forms.Button();
            this.txtSDOWriteData = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtSDOSize = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtSDOAddress = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtWriteData = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnWriteRxPDO = new System.Windows.Forms.Button();
            this.btnReadRxPDO = new System.Windows.Forms.Button();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtOffset = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtSlaveNo = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnReadTxPDO = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSDOReadTimeWait = new System.Windows.Forms.Button();
            this.btnSDOWriteTimeWait = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtWaitTime = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAxisNumber = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.txtAxisWriteData = new System.Windows.Forms.TextBox();
            this.btnReadPhysicalOutput = new System.Windows.Forms.Button();
            this.btnWritePhysicalOutput = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSDOReadCheck
            // 
            this.btnSDOReadCheck.Location = new System.Drawing.Point(216, 156);
            this.btnSDOReadCheck.Name = "btnSDOReadCheck";
            this.btnSDOReadCheck.Size = new System.Drawing.Size(139, 23);
            this.btnSDOReadCheck.TabIndex = 69;
            this.btnSDOReadCheck.Text = "COE Read Check";
            this.btnSDOReadCheck.UseVisualStyleBackColor = true;
            this.btnSDOReadCheck.Click += new System.EventHandler(this.btnSDOReadCheck_Click);
            // 
            // btnSDOWriteCheck
            // 
            this.btnSDOWriteCheck.Location = new System.Drawing.Point(216, 55);
            this.btnSDOWriteCheck.Name = "btnSDOWriteCheck";
            this.btnSDOWriteCheck.Size = new System.Drawing.Size(139, 23);
            this.btnSDOWriteCheck.TabIndex = 68;
            this.btnSDOWriteCheck.Text = "COE Write Check";
            this.btnSDOWriteCheck.UseVisualStyleBackColor = true;
            this.btnSDOWriteCheck.Click += new System.EventHandler(this.btnSDOWriteCheck_Click);
            // 
            // txtSubIndex
            // 
            this.txtSubIndex.Location = new System.Drawing.Point(129, 57);
            this.txtSubIndex.Name = "txtSubIndex";
            this.txtSubIndex.Size = new System.Drawing.Size(78, 21);
            this.txtSubIndex.TabIndex = 67;
            this.txtSubIndex.Text = "0";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(9, 60);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(58, 12);
            this.Label8.TabIndex = 66;
            this.Label8.Text = "SubIndex";
            // 
            // btnSDORead
            // 
            this.btnSDORead.Location = new System.Drawing.Point(216, 127);
            this.btnSDORead.Name = "btnSDORead";
            this.btnSDORead.Size = new System.Drawing.Size(139, 23);
            this.btnSDORead.TabIndex = 65;
            this.btnSDORead.Text = "COE Read Request";
            this.btnSDORead.UseVisualStyleBackColor = true;
            this.btnSDORead.Click += new System.EventHandler(this.btnSDORead_Click);
            // 
            // btnSDOWrite
            // 
            this.btnSDOWrite.Location = new System.Drawing.Point(216, 26);
            this.btnSDOWrite.Name = "btnSDOWrite";
            this.btnSDOWrite.Size = new System.Drawing.Size(139, 23);
            this.btnSDOWrite.TabIndex = 64;
            this.btnSDOWrite.Text = "COE Write Request";
            this.btnSDOWrite.UseVisualStyleBackColor = true;
            this.btnSDOWrite.Click += new System.EventHandler(this.btnSDOWrite_Click);
            // 
            // txtSDOWriteData
            // 
            this.txtSDOWriteData.Location = new System.Drawing.Point(129, 117);
            this.txtSDOWriteData.Name = "txtSDOWriteData";
            this.txtSDOWriteData.Size = new System.Drawing.Size(78, 21);
            this.txtSDOWriteData.TabIndex = 63;
            this.txtSDOWriteData.Text = "0";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(9, 120);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(57, 12);
            this.Label5.TabIndex = 62;
            this.Label5.Text = "WriteData";
            // 
            // txtSDOSize
            // 
            this.txtSDOSize.Location = new System.Drawing.Point(129, 87);
            this.txtSDOSize.Name = "txtSDOSize";
            this.txtSDOSize.Size = new System.Drawing.Size(78, 21);
            this.txtSDOSize.TabIndex = 61;
            this.txtSDOSize.Text = "4";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(9, 90);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(30, 12);
            this.Label6.TabIndex = 60;
            this.Label6.Text = "Size";
            // 
            // txtSDOAddress
            // 
            this.txtSDOAddress.Location = new System.Drawing.Point(129, 27);
            this.txtSDOAddress.Name = "txtSDOAddress";
            this.txtSDOAddress.Size = new System.Drawing.Size(78, 21);
            this.txtSDOAddress.TabIndex = 59;
            this.txtSDOAddress.Text = "0x6064";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(9, 30);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(117, 12);
            this.Label7.TabIndex = 58;
            this.Label7.Text = "Parameter No(HEX)";
            // 
            // txtWriteData
            // 
            this.txtWriteData.Location = new System.Drawing.Point(97, 110);
            this.txtWriteData.Name = "txtWriteData";
            this.txtWriteData.Size = new System.Drawing.Size(78, 21);
            this.txtWriteData.TabIndex = 57;
            this.txtWriteData.Text = "10";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(9, 113);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(57, 12);
            this.Label4.TabIndex = 56;
            this.Label4.Text = "WriteData";
            // 
            // btnWriteRxPDO
            // 
            this.btnWriteRxPDO.Location = new System.Drawing.Point(186, 81);
            this.btnWriteRxPDO.Name = "btnWriteRxPDO";
            this.btnWriteRxPDO.Size = new System.Drawing.Size(124, 23);
            this.btnWriteRxPDO.TabIndex = 55;
            this.btnWriteRxPDO.Text = "RX_PDO Write";
            this.btnWriteRxPDO.UseVisualStyleBackColor = true;
            this.btnWriteRxPDO.Click += new System.EventHandler(this.btnWriteRxPDO_Click);
            // 
            // btnReadRxPDO
            // 
            this.btnReadRxPDO.Location = new System.Drawing.Point(186, 52);
            this.btnReadRxPDO.Name = "btnReadRxPDO";
            this.btnReadRxPDO.Size = new System.Drawing.Size(124, 23);
            this.btnReadRxPDO.TabIndex = 54;
            this.btnReadRxPDO.Text = "RX_PDO Read";
            this.btnReadRxPDO.UseVisualStyleBackColor = true;
            this.btnReadRxPDO.Click += new System.EventHandler(this.btnReadRxPDO_Click);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(97, 83);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(78, 21);
            this.txtSize.TabIndex = 53;
            this.txtSize.Text = "4";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(9, 86);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(30, 12);
            this.Label3.TabIndex = 52;
            this.Label3.Text = "Size";
            // 
            // txtOffset
            // 
            this.txtOffset.Location = new System.Drawing.Point(97, 56);
            this.txtOffset.Name = "txtOffset";
            this.txtOffset.Size = new System.Drawing.Size(78, 21);
            this.txtOffset.TabIndex = 51;
            this.txtOffset.Text = "0";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(9, 59);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(37, 12);
            this.Label1.TabIndex = 50;
            this.Label1.Text = "Offset";
            // 
            // txtSlaveNo
            // 
            this.txtSlaveNo.Location = new System.Drawing.Point(97, 25);
            this.txtSlaveNo.Name = "txtSlaveNo";
            this.txtSlaveNo.Size = new System.Drawing.Size(78, 21);
            this.txtSlaveNo.TabIndex = 49;
            this.txtSlaveNo.Text = "0";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(9, 28);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(85, 12);
            this.Label2.TabIndex = 48;
            this.Label2.Text = "Slave Number";
            // 
            // btnReadTxPDO
            // 
            this.btnReadTxPDO.Location = new System.Drawing.Point(186, 23);
            this.btnReadTxPDO.Name = "btnReadTxPDO";
            this.btnReadTxPDO.Size = new System.Drawing.Size(124, 23);
            this.btnReadTxPDO.TabIndex = 47;
            this.btnReadTxPDO.Text = "TX_PDO Read";
            this.btnReadTxPDO.UseVisualStyleBackColor = true;
            this.btnReadTxPDO.Click += new System.EventHandler(this.btnReadTxPDO_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSDOReadTimeWait);
            this.groupBox1.Controls.Add(this.btnSDOWriteTimeWait);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtWaitTime);
            this.groupBox1.Controls.Add(this.btnSDOReadCheck);
            this.groupBox1.Controls.Add(this.Label7);
            this.groupBox1.Controls.Add(this.txtSDOAddress);
            this.groupBox1.Controls.Add(this.btnSDOWriteCheck);
            this.groupBox1.Controls.Add(this.Label6);
            this.groupBox1.Controls.Add(this.txtSubIndex);
            this.groupBox1.Controls.Add(this.txtSDOSize);
            this.groupBox1.Controls.Add(this.Label8);
            this.groupBox1.Controls.Add(this.Label5);
            this.groupBox1.Controls.Add(this.btnSDORead);
            this.groupBox1.Controls.Add(this.txtSDOWriteData);
            this.groupBox1.Controls.Add(this.btnSDOWrite);
            this.groupBox1.Location = new System.Drawing.Point(12, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 235);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COE Read/Write";
            // 
            // btnSDOReadTimeWait
            // 
            this.btnSDOReadTimeWait.Location = new System.Drawing.Point(216, 185);
            this.btnSDOReadTimeWait.Name = "btnSDOReadTimeWait";
            this.btnSDOReadTimeWait.Size = new System.Drawing.Size(139, 37);
            this.btnSDOReadTimeWait.TabIndex = 73;
            this.btnSDOReadTimeWait.Text = "COE Read\r\n(Reply Wait Mode)";
            this.btnSDOReadTimeWait.UseVisualStyleBackColor = true;
            this.btnSDOReadTimeWait.Click += new System.EventHandler(this.btnSDOReadTimeWait_Click);
            // 
            // btnSDOWriteTimeWait
            // 
            this.btnSDOWriteTimeWait.Location = new System.Drawing.Point(216, 84);
            this.btnSDOWriteTimeWait.Name = "btnSDOWriteTimeWait";
            this.btnSDOWriteTimeWait.Size = new System.Drawing.Size(139, 37);
            this.btnSDOWriteTimeWait.TabIndex = 72;
            this.btnSDOWriteTimeWait.Text = "COE Write\r\n(Reply Wait Mode)";
            this.btnSDOWriteTimeWait.UseVisualStyleBackColor = true;
            this.btnSDOWriteTimeWait.Click += new System.EventHandler(this.btnSDOWriteTimeWait_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 12);
            this.label9.TabIndex = 70;
            this.label9.Text = "Reply Wait Time";
            // 
            // txtWaitTime
            // 
            this.txtWaitTime.Location = new System.Drawing.Point(129, 147);
            this.txtWaitTime.Name = "txtWaitTime";
            this.txtWaitTime.Size = new System.Drawing.Size(78, 21);
            this.txtWaitTime.TabIndex = 71;
            this.txtWaitTime.Text = "200";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnWriteRxPDO);
            this.groupBox2.Controls.Add(this.btnReadTxPDO);
            this.groupBox2.Controls.Add(this.Label2);
            this.groupBox2.Controls.Add(this.txtSlaveNo);
            this.groupBox2.Controls.Add(this.Label1);
            this.groupBox2.Controls.Add(this.txtOffset);
            this.groupBox2.Controls.Add(this.Label3);
            this.groupBox2.Controls.Add(this.txtSize);
            this.groupBox2.Controls.Add(this.btnReadRxPDO);
            this.groupBox2.Controls.Add(this.Label4);
            this.groupBox2.Controls.Add(this.txtWriteData);
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 150);
            this.groupBox2.TabIndex = 71;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PDO_Read/Write";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.txtAxisNumber);
            this.GroupBox3.Controls.Add(this.Label10);
            this.GroupBox3.Controls.Add(this.Label13);
            this.GroupBox3.Controls.Add(this.txtAxisWriteData);
            this.GroupBox3.Controls.Add(this.btnReadPhysicalOutput);
            this.GroupBox3.Controls.Add(this.btnWritePhysicalOutput);
            this.GroupBox3.Location = new System.Drawing.Point(12, 169);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(327, 70);
            this.GroupBox3.TabIndex = 80;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Axis Physical Output Read/Write";
            // 
            // txtAxisNumber
            // 
            this.txtAxisNumber.Location = new System.Drawing.Point(107, 20);
            this.txtAxisNumber.Name = "txtAxisNumber";
            this.txtAxisNumber.Size = new System.Drawing.Size(78, 21);
            this.txtAxisNumber.TabIndex = 26;
            this.txtAxisNumber.Text = "0";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(14, 24);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(85, 12);
            this.Label10.TabIndex = 25;
            this.Label10.Text = "Slave Number";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(14, 51);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(57, 12);
            this.Label13.TabIndex = 33;
            this.Label13.Text = "WriteData";
            // 
            // txtAxisWriteData
            // 
            this.txtAxisWriteData.Location = new System.Drawing.Point(107, 47);
            this.txtAxisWriteData.Name = "txtAxisWriteData";
            this.txtAxisWriteData.Size = new System.Drawing.Size(78, 21);
            this.txtAxisWriteData.TabIndex = 34;
            this.txtAxisWriteData.Text = "10";
            // 
            // btnReadPhysicalOutput
            // 
            this.btnReadPhysicalOutput.Location = new System.Drawing.Point(191, 18);
            this.btnReadPhysicalOutput.Name = "btnReadPhysicalOutput";
            this.btnReadPhysicalOutput.Size = new System.Drawing.Size(122, 23);
            this.btnReadPhysicalOutput.TabIndex = 24;
            this.btnReadPhysicalOutput.Text = "Read Axis IO";
            this.btnReadPhysicalOutput.UseVisualStyleBackColor = true;
            this.btnReadPhysicalOutput.Click += new System.EventHandler(this.btnReadPhysicalOutput_Click);
            // 
            // btnWritePhysicalOutput
            // 
            this.btnWritePhysicalOutput.Location = new System.Drawing.Point(191, 47);
            this.btnWritePhysicalOutput.Name = "btnWritePhysicalOutput";
            this.btnWritePhysicalOutput.Size = new System.Drawing.Size(122, 23);
            this.btnWritePhysicalOutput.TabIndex = 31;
            this.btnWritePhysicalOutput.Text = "Write Axis IO";
            this.btnWritePhysicalOutput.UseVisualStyleBackColor = true;
            this.btnWritePhysicalOutput.Click += new System.EventHandler(this.btnWritePhysicalOutput_Click);
            // 
            // Form_PDO_ETParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 486);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_PDO_ETParam";
            this.Text = "MXP_PDO_ETParam";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnSDOReadCheck;
        internal System.Windows.Forms.Button btnSDOWriteCheck;
        internal System.Windows.Forms.TextBox txtSubIndex;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Button btnSDORead;
        internal System.Windows.Forms.Button btnSDOWrite;
        internal System.Windows.Forms.TextBox txtSDOWriteData;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtSDOSize;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtSDOAddress;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtWriteData;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnWriteRxPDO;
        internal System.Windows.Forms.Button btnReadRxPDO;
        internal System.Windows.Forms.TextBox txtSize;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtOffset;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtSlaveNo;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnReadTxPDO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button btnSDOReadTimeWait;
        internal System.Windows.Forms.Button btnSDOWriteTimeWait;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox txtWaitTime;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.TextBox txtAxisNumber;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.TextBox txtAxisWriteData;
        internal System.Windows.Forms.Button btnReadPhysicalOutput;
        internal System.Windows.Forms.Button btnWritePhysicalOutput;
    }
}