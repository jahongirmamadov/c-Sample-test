namespace AdvancedSample
{
    partial class Form_SpinMove
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
            this.components = new System.ComponentModel.Container();
            this.chkMonitoring = new System.Windows.Forms.CheckBox();
            this.btnStatusCheck = new System.Windows.Forms.Button();
            this.lblRunState = new System.Windows.Forms.Label();
            this.lblRunStep = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSpinStop = new System.Windows.Forms.Button();
            this.btnSpinReset = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtAxisNo = new System.Windows.Forms.TextBox();
            this.btnSpinRun = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.btnWriteSpinTable = new System.Windows.Forms.Button();
            this.txtWaitTime = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtAcc = new System.Windows.Forms.TextBox();
            this.txtOriginMoveVel = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtTime_3 = new System.Windows.Forms.TextBox();
            this.txtVel_3 = new System.Windows.Forms.TextBox();
            this.txtTime_2 = new System.Windows.Forms.TextBox();
            this.txtVel_2 = new System.Windows.Forms.TextBox();
            this.txtTime_1 = new System.Windows.Forms.TextBox();
            this.txtVel_1 = new System.Windows.Forms.TextBox();
            this.txtTime_0 = new System.Windows.Forms.TextBox();
            this.txtVel_0 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GroupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkMonitoring
            // 
            this.chkMonitoring.AutoSize = true;
            this.chkMonitoring.Location = new System.Drawing.Point(8, 118);
            this.chkMonitoring.Name = "chkMonitoring";
            this.chkMonitoring.Size = new System.Drawing.Size(122, 16);
            this.chkMonitoring.TabIndex = 50;
            this.chkMonitoring.Text = "Status Monitoring";
            this.chkMonitoring.UseVisualStyleBackColor = true;
            // 
            // btnStatusCheck
            // 
            this.btnStatusCheck.Location = new System.Drawing.Point(136, 113);
            this.btnStatusCheck.Name = "btnStatusCheck";
            this.btnStatusCheck.Size = new System.Drawing.Size(122, 21);
            this.btnStatusCheck.TabIndex = 49;
            this.btnStatusCheck.Text = "Move Check";
            this.btnStatusCheck.UseVisualStyleBackColor = true;
            this.btnStatusCheck.Click += new System.EventHandler(this.btnStatusCheck_Click);
            // 
            // lblRunState
            // 
            this.lblRunState.AutoSize = true;
            this.lblRunState.Location = new System.Drawing.Point(73, 90);
            this.lblRunState.Name = "lblRunState";
            this.lblRunState.Size = new System.Drawing.Size(11, 12);
            this.lblRunState.TabIndex = 48;
            this.lblRunState.Text = "0";
            // 
            // lblRunStep
            // 
            this.lblRunStep.AutoSize = true;
            this.lblRunStep.Location = new System.Drawing.Point(73, 68);
            this.lblRunStep.Name = "lblRunStep";
            this.lblRunStep.Size = new System.Drawing.Size(11, 12);
            this.lblRunStep.TabIndex = 47;
            this.lblRunStep.Text = "0";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(6, 90);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(55, 12);
            this.Label7.TabIndex = 46;
            this.Label7.Text = "RunState";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 68);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 12);
            this.lblName.TabIndex = 45;
            this.lblName.Text = "RunStep";
            // 
            // btnSpinStop
            // 
            this.btnSpinStop.Location = new System.Drawing.Point(136, 59);
            this.btnSpinStop.Name = "btnSpinStop";
            this.btnSpinStop.Size = new System.Drawing.Size(122, 21);
            this.btnSpinStop.TabIndex = 44;
            this.btnSpinStop.Text = "Stop";
            this.btnSpinStop.UseVisualStyleBackColor = true;
            this.btnSpinStop.Click += new System.EventHandler(this.btnSpinStop_Click);
            // 
            // btnSpinReset
            // 
            this.btnSpinReset.Location = new System.Drawing.Point(136, 86);
            this.btnSpinReset.Name = "btnSpinReset";
            this.btnSpinReset.Size = new System.Drawing.Size(122, 21);
            this.btnSpinReset.TabIndex = 43;
            this.btnSpinReset.Text = "Reset";
            this.btnSpinReset.UseVisualStyleBackColor = true;
            this.btnSpinReset.Click += new System.EventHandler(this.btnSpinReset_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(6, 36);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(30, 12);
            this.Label3.TabIndex = 42;
            this.Label3.Text = "Axis";
            // 
            // txtAxisNo
            // 
            this.txtAxisNo.Location = new System.Drawing.Point(49, 33);
            this.txtAxisNo.Name = "txtAxisNo";
            this.txtAxisNo.Size = new System.Drawing.Size(73, 21);
            this.txtAxisNo.TabIndex = 41;
            this.txtAxisNo.Text = "0";
            // 
            // btnSpinRun
            // 
            this.btnSpinRun.Location = new System.Drawing.Point(136, 32);
            this.btnSpinRun.Name = "btnSpinRun";
            this.btnSpinRun.Size = new System.Drawing.Size(122, 21);
            this.btnSpinRun.TabIndex = 40;
            this.btnSpinRun.Text = "Move";
            this.btnSpinRun.UseVisualStyleBackColor = true;
            this.btnSpinRun.Click += new System.EventHandler(this.btnSpinRun_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label11);
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.btnWriteSpinTable);
            this.GroupBox1.Controls.Add(this.txtWaitTime);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.txtAcc);
            this.GroupBox1.Controls.Add(this.txtOriginMoveVel);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.txtTime_3);
            this.GroupBox1.Controls.Add(this.txtVel_3);
            this.GroupBox1.Controls.Add(this.txtTime_2);
            this.GroupBox1.Controls.Add(this.txtVel_2);
            this.GroupBox1.Controls.Add(this.txtTime_1);
            this.GroupBox1.Controls.Add(this.txtVel_1);
            this.GroupBox1.Controls.Add(this.txtTime_0);
            this.GroupBox1.Controls.Add(this.txtVel_0);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(269, 285);
            this.GroupBox1.TabIndex = 39;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "SpinTable";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(6, 127);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(36, 12);
            this.Label11.TabIndex = 32;
            this.Label11.Text = "Step4";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(6, 106);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(36, 12);
            this.Label10.TabIndex = 31;
            this.Label10.Text = "Step3";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(6, 73);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(36, 12);
            this.Label9.TabIndex = 30;
            this.Label9.Text = "Step2";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(6, 46);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(36, 12);
            this.Label8.TabIndex = 29;
            this.Label8.Text = "Step1";
            // 
            // btnWriteSpinTable
            // 
            this.btnWriteSpinTable.Location = new System.Drawing.Point(120, 242);
            this.btnWriteSpinTable.Name = "btnWriteSpinTable";
            this.btnWriteSpinTable.Size = new System.Drawing.Size(138, 25);
            this.btnWriteSpinTable.TabIndex = 1;
            this.btnWriteSpinTable.Text = "Write";
            this.btnWriteSpinTable.UseVisualStyleBackColor = true;
            this.btnWriteSpinTable.Click += new System.EventHandler(this.btnWriteSpinTable_Click);
            // 
            // txtWaitTime
            // 
            this.txtWaitTime.Location = new System.Drawing.Point(199, 188);
            this.txtWaitTime.Name = "txtWaitTime";
            this.txtWaitTime.Size = new System.Drawing.Size(59, 21);
            this.txtWaitTime.TabIndex = 28;
            this.txtWaitTime.Text = "0.1";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(10, 197);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(167, 12);
            this.Label6.TabIndex = 27;
            this.Label6.Text = "0 Pos Move Wait Time (sec)";
            // 
            // txtAcc
            // 
            this.txtAcc.Location = new System.Drawing.Point(199, 161);
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.Size = new System.Drawing.Size(59, 21);
            this.txtAcc.TabIndex = 14;
            this.txtAcc.Text = "600";
            // 
            // txtOriginMoveVel
            // 
            this.txtOriginMoveVel.Location = new System.Drawing.Point(199, 215);
            this.txtOriginMoveVel.Name = "txtOriginMoveVel";
            this.txtOriginMoveVel.Size = new System.Drawing.Size(59, 21);
            this.txtOriginMoveVel.TabIndex = 26;
            this.txtOriginMoveVel.Text = "1000";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(10, 171);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(113, 12);
            this.Label4.TabIndex = 13;
            this.Label4.Text = "Accerlation(rmp/s)";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(10, 219);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(126, 12);
            this.Label5.TabIndex = 25;
            this.Label5.Text = "0 Pos Move Vel(rpm)";
            // 
            // txtTime_3
            // 
            this.txtTime_3.Location = new System.Drawing.Point(158, 124);
            this.txtTime_3.Name = "txtTime_3";
            this.txtTime_3.Size = new System.Drawing.Size(100, 21);
            this.txtTime_3.TabIndex = 9;
            this.txtTime_3.Text = "5";
            // 
            // txtVel_3
            // 
            this.txtVel_3.Location = new System.Drawing.Point(49, 124);
            this.txtVel_3.Name = "txtVel_3";
            this.txtVel_3.Size = new System.Drawing.Size(100, 21);
            this.txtVel_3.TabIndex = 8;
            this.txtVel_3.Text = "2400";
            // 
            // txtTime_2
            // 
            this.txtTime_2.Location = new System.Drawing.Point(158, 97);
            this.txtTime_2.Name = "txtTime_2";
            this.txtTime_2.Size = new System.Drawing.Size(100, 21);
            this.txtTime_2.TabIndex = 7;
            this.txtTime_2.Text = "5";
            // 
            // txtVel_2
            // 
            this.txtVel_2.Location = new System.Drawing.Point(49, 97);
            this.txtVel_2.Name = "txtVel_2";
            this.txtVel_2.Size = new System.Drawing.Size(100, 21);
            this.txtVel_2.TabIndex = 6;
            this.txtVel_2.Text = "1800";
            // 
            // txtTime_1
            // 
            this.txtTime_1.Location = new System.Drawing.Point(158, 70);
            this.txtTime_1.Name = "txtTime_1";
            this.txtTime_1.Size = new System.Drawing.Size(100, 21);
            this.txtTime_1.TabIndex = 5;
            this.txtTime_1.Text = "5";
            // 
            // txtVel_1
            // 
            this.txtVel_1.Location = new System.Drawing.Point(49, 70);
            this.txtVel_1.Name = "txtVel_1";
            this.txtVel_1.Size = new System.Drawing.Size(100, 21);
            this.txtVel_1.TabIndex = 4;
            this.txtVel_1.Text = "1100";
            // 
            // txtTime_0
            // 
            this.txtTime_0.Location = new System.Drawing.Point(158, 43);
            this.txtTime_0.Name = "txtTime_0";
            this.txtTime_0.Size = new System.Drawing.Size(100, 21);
            this.txtTime_0.TabIndex = 3;
            this.txtTime_0.Text = "5";
            // 
            // txtVel_0
            // 
            this.txtVel_0.Location = new System.Drawing.Point(49, 43);
            this.txtVel_0.Name = "txtVel_0";
            this.txtVel_0.Size = new System.Drawing.Size(100, 21);
            this.txtVel_0.TabIndex = 1;
            this.txtVel_0.Text = "600";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(173, 28);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(65, 12);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Time(sec)";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(56, 28);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(82, 12);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Velocity(rpm)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Label3);
            this.groupBox2.Controls.Add(this.chkMonitoring);
            this.groupBox2.Controls.Add(this.btnSpinRun);
            this.groupBox2.Controls.Add(this.btnStatusCheck);
            this.groupBox2.Controls.Add(this.txtAxisNo);
            this.groupBox2.Controls.Add(this.lblRunState);
            this.groupBox2.Controls.Add(this.btnSpinReset);
            this.groupBox2.Controls.Add(this.lblRunStep);
            this.groupBox2.Controls.Add(this.btnSpinStop);
            this.groupBox2.Controls.Add(this.Label7);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Location = new System.Drawing.Point(12, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 149);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Spin Move";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_SpinMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 464);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Name = "Form_SpinMove";
            this.Text = "SpinMove";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.CheckBox chkMonitoring;
        internal System.Windows.Forms.Button btnStatusCheck;
        internal System.Windows.Forms.Label lblRunState;
        internal System.Windows.Forms.Label lblRunStep;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label lblName;
        internal System.Windows.Forms.Button btnSpinStop;
        internal System.Windows.Forms.Button btnSpinReset;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtAxisNo;
        internal System.Windows.Forms.Button btnSpinRun;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Button btnWriteSpinTable;
        internal System.Windows.Forms.TextBox txtWaitTime;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtAcc;
        internal System.Windows.Forms.TextBox txtOriginMoveVel;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtTime_3;
        internal System.Windows.Forms.TextBox txtVel_3;
        internal System.Windows.Forms.TextBox txtTime_2;
        internal System.Windows.Forms.TextBox txtVel_2;
        internal System.Windows.Forms.TextBox txtTime_1;
        internal System.Windows.Forms.TextBox txtVel_1;
        internal System.Windows.Forms.TextBox txtTime_0;
        internal System.Windows.Forms.TextBox txtVel_0;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer timer1;
    }
}