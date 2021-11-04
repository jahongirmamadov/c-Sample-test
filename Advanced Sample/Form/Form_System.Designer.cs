namespace AdvancedSample
{
    partial class Form_System
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSysreset = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtAliasNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLicenseCheck = new System.Windows.Forms.Button();
            this.txtUserLib = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.btnETMasterMode = new System.Windows.Forms.Button();
            this.txtSetMasterMode = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnETEntireSlaveComReadyCheck = new System.Windows.Forms.Button();
            this.btnETSlaveComReadyCheck = new System.Windows.Forms.Button();
            this.btnETSlaveMode = new System.Windows.Forms.Button();
            this.txtSetSlaveMode = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.txtSlaveNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "1. SystemInit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "2. SystemRun";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(187, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "3. SystemStop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 78);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(347, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "4. SystemDestroy(Application Close)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSysreset);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 190);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MXP Controller";
            // 
            // btnSysreset
            // 
            this.btnSysreset.Location = new System.Drawing.Point(184, 127);
            this.btnSysreset.Name = "btnSysreset";
            this.btnSysreset.Size = new System.Drawing.Size(169, 23);
            this.btnSysreset.TabIndex = 8;
            this.btnSysreset.Text = "SystemReset";
            this.btnSysreset.UseVisualStyleBackColor = true;
            this.btnSysreset.Click += new System.EventHandler(this.btnSysreset_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 127);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(169, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "SystemStatus";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "StateCheck";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(6, 156);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(169, 23);
            this.button9.TabIndex = 9;
            this.button9.Text = "Get System Alarm";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.txtAliasNumber);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 85);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Node";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(184, 47);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(169, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "GetAxisNo";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 47);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(169, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "GetSlaveNo";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtAliasNumber
            // 
            this.txtAliasNumber.Location = new System.Drawing.Point(90, 19);
            this.txtAliasNumber.Name = "txtAliasNumber";
            this.txtAliasNumber.Size = new System.Drawing.Size(100, 21);
            this.txtAliasNumber.TabIndex = 5;
            this.txtAliasNumber.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Node Number";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLicenseCheck);
            this.groupBox3.Controls.Add(this.txtUserLib);
            this.groupBox3.Controls.Add(this.Label6);
            this.groupBox3.Controls.Add(this.btnETMasterMode);
            this.groupBox3.Controls.Add(this.txtSetMasterMode);
            this.groupBox3.Controls.Add(this.Label4);
            this.groupBox3.Controls.Add(this.button13);
            this.groupBox3.Controls.Add(this.button12);
            this.groupBox3.Controls.Add(this.button11);
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Location = new System.Drawing.Point(12, 299);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(362, 189);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Master";
            // 
            // btnLicenseCheck
            // 
            this.btnLicenseCheck.Location = new System.Drawing.Point(252, 134);
            this.btnLicenseCheck.Name = "btnLicenseCheck";
            this.btnLicenseCheck.Size = new System.Drawing.Size(85, 45);
            this.btnLicenseCheck.TabIndex = 21;
            this.btnLicenseCheck.Text = "License Check";
            this.btnLicenseCheck.UseVisualStyleBackColor = true;
            this.btnLicenseCheck.Click += new System.EventHandler(this.btnLicenseCheck_Click);
            // 
            // txtUserLib
            // 
            this.txtUserLib.Location = new System.Drawing.Point(252, 107);
            this.txtUserLib.Name = "txtUserLib";
            this.txtUserLib.Size = new System.Drawing.Size(85, 21);
            this.txtUserLib.TabIndex = 20;
            this.txtUserLib.Text = "0";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(182, 110);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(64, 48);
            this.Label6.TabIndex = 19;
            this.Label6.Text = "UserLib\r\n0:R2R\r\n1:Robotics\r\n2:EDG";
            // 
            // btnETMasterMode
            // 
            this.btnETMasterMode.Location = new System.Drawing.Point(69, 134);
            this.btnETMasterMode.Name = "btnETMasterMode";
            this.btnETMasterMode.Size = new System.Drawing.Size(85, 48);
            this.btnETMasterMode.TabIndex = 18;
            this.btnETMasterMode.Text = "Master Mode Set";
            this.btnETMasterMode.UseVisualStyleBackColor = true;
            this.btnETMasterMode.Click += new System.EventHandler(this.btnETMasterMode_Click);
            // 
            // txtSetMasterMode
            // 
            this.txtSetMasterMode.Location = new System.Drawing.Point(69, 107);
            this.txtSetMasterMode.Name = "txtSetMasterMode";
            this.txtSetMasterMode.Size = new System.Drawing.Size(85, 21);
            this.txtSetMasterMode.TabIndex = 17;
            this.txtSetMasterMode.Text = "0";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(6, 110);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(57, 72);
            this.Label4.TabIndex = 16;
            this.Label4.Text = "SetMode\r\n1:Init\r\n2:PreOP\r\n3:Boot\r\n4:SafeOP\r\n8:OP";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(184, 49);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(169, 23);
            this.button13.TabIndex = 13;
            this.button13.Text = "Simulation Mode Check";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(6, 78);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(169, 23);
            this.button12.TabIndex = 12;
            this.button12.Text = "Master Hardware Link State";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(184, 20);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(169, 23);
            this.button11.TabIndex = 11;
            this.button11.Text = "Get Axis Count";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(6, 49);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(169, 23);
            this.button10.TabIndex = 10;
            this.button10.Text = "Get Slave Count";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 20);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(169, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "MasterOnlineMode";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnETEntireSlaveComReadyCheck);
            this.groupBox4.Controls.Add(this.btnETSlaveComReadyCheck);
            this.groupBox4.Controls.Add(this.btnETSlaveMode);
            this.groupBox4.Controls.Add(this.txtSetSlaveMode);
            this.groupBox4.Controls.Add(this.Label5);
            this.groupBox4.Controls.Add(this.button17);
            this.groupBox4.Controls.Add(this.button16);
            this.groupBox4.Controls.Add(this.button15);
            this.groupBox4.Controls.Add(this.button14);
            this.groupBox4.Controls.Add(this.txtSlaveNo);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(12, 494);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(362, 217);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Slave";
            // 
            // btnETEntireSlaveComReadyCheck
            // 
            this.btnETEntireSlaveComReadyCheck.Location = new System.Drawing.Point(184, 107);
            this.btnETEntireSlaveComReadyCheck.Name = "btnETEntireSlaveComReadyCheck";
            this.btnETEntireSlaveComReadyCheck.Size = new System.Drawing.Size(169, 23);
            this.btnETEntireSlaveComReadyCheck.TabIndex = 23;
            this.btnETEntireSlaveComReadyCheck.Text = "Entire Slave Ready Check";
            this.btnETEntireSlaveComReadyCheck.UseVisualStyleBackColor = true;
            this.btnETEntireSlaveComReadyCheck.Click += new System.EventHandler(this.btnETEntireSlaveComReadyCheck_Click);
            // 
            // btnETSlaveComReadyCheck
            // 
            this.btnETSlaveComReadyCheck.Location = new System.Drawing.Point(6, 107);
            this.btnETSlaveComReadyCheck.Name = "btnETSlaveComReadyCheck";
            this.btnETSlaveComReadyCheck.Size = new System.Drawing.Size(169, 23);
            this.btnETSlaveComReadyCheck.TabIndex = 22;
            this.btnETSlaveComReadyCheck.Text = "Slave Ready Check";
            this.btnETSlaveComReadyCheck.UseVisualStyleBackColor = true;
            this.btnETSlaveComReadyCheck.Click += new System.EventHandler(this.btnETSlaveComReadyCheck_Click);
            // 
            // btnETSlaveMode
            // 
            this.btnETSlaveMode.Location = new System.Drawing.Point(184, 136);
            this.btnETSlaveMode.Name = "btnETSlaveMode";
            this.btnETSlaveMode.Size = new System.Drawing.Size(169, 23);
            this.btnETSlaveMode.TabIndex = 21;
            this.btnETSlaveMode.Text = "Slave Mode Set";
            this.btnETSlaveMode.UseVisualStyleBackColor = true;
            this.btnETSlaveMode.Click += new System.EventHandler(this.btnETSlaveMode_Click);
            // 
            // txtSetSlaveMode
            // 
            this.txtSetSlaveMode.Location = new System.Drawing.Point(90, 138);
            this.txtSetSlaveMode.Name = "txtSetSlaveMode";
            this.txtSetSlaveMode.Size = new System.Drawing.Size(85, 21);
            this.txtSetSlaveMode.TabIndex = 20;
            this.txtSetSlaveMode.Text = "0";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(6, 138);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(57, 72);
            this.Label5.TabIndex = 19;
            this.Label5.Text = "SetMode\r\n1:Init\r\n2:PreOP\r\n3:Boot\r\n4:SafeOP\r\n8:OP";
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(6, 49);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(169, 23);
            this.button17.TabIndex = 16;
            this.button17.Text = "Get Slave Name";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(6, 78);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(169, 23);
            this.button16.TabIndex = 15;
            this.button16.Text = "Slave Hardware Link State";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(184, 78);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(169, 23);
            this.button15.TabIndex = 14;
            this.button15.Text = "Get Slave Type";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(184, 49);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(169, 23);
            this.button14.TabIndex = 13;
            this.button14.Text = "Get Current State";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // txtSlaveNo
            // 
            this.txtSlaveNo.Location = new System.Drawing.Point(90, 20);
            this.txtSlaveNo.Name = "txtSlaveNo";
            this.txtSlaveNo.Size = new System.Drawing.Size(100, 21);
            this.txtSlaveNo.TabIndex = 7;
            this.txtSlaveNo.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Slave Number";
            // 
            // Form_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 723);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_System";
            this.Text = "MXP_System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtAliasNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TextBox txtSlaveNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button17;
        internal System.Windows.Forms.Button btnETMasterMode;
        internal System.Windows.Forms.TextBox txtSetMasterMode;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnETSlaveMode;
        internal System.Windows.Forms.TextBox txtSetSlaveMode;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button btnETSlaveComReadyCheck;
        internal System.Windows.Forms.Button btnSysreset;
        internal System.Windows.Forms.Button btnETEntireSlaveComReadyCheck;
        internal System.Windows.Forms.Button btnLicenseCheck;
        internal System.Windows.Forms.TextBox txtUserLib;
        internal System.Windows.Forms.Label Label6;
    }
}