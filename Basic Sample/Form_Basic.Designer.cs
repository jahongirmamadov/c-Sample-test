namespace Basic_Sample
{
    partial class Form_Basic
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnCheckSystem = new System.Windows.Forms.Button();
            this.btnSystemRun = new System.Windows.Forms.Button();
            this.btnSystemInit = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.btnSystemStop = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSystemClose = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPowerOff = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAxisReadyCheck = new System.Windows.Forms.Button();
            this.btnPowerOn = new System.Windows.Forms.Button();
            this.LinkManual = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(169, 30);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(173, 36);
            this.Label2.TabIndex = 21;
            this.Label2.Text = "Refer to Form_SingleAxis.cs, \r\nForm_Monitoring.cs \r\nof the Advanced example.";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.button2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.btnCheckSystem);
            this.GroupBox1.Controls.Add(this.btnSystemRun);
            this.GroupBox1.Controls.Add(this.btnSystemInit);
            this.GroupBox1.Location = new System.Drawing.Point(12, 30);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(347, 143);
            this.GroupBox1.TabIndex = 10;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Step1. MXP Control Run";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(169, 27);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(166, 24);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Refer to Form_System.cs of \r\nthe Advanced example.";
            // 
            // btnCheckSystem
            // 
            this.btnCheckSystem.Location = new System.Drawing.Point(26, 108);
            this.btnCheckSystem.Name = "btnCheckSystem";
            this.btnCheckSystem.Size = new System.Drawing.Size(123, 23);
            this.btnCheckSystem.TabIndex = 7;
            this.btnCheckSystem.Text = "SYS_GetStatus";
            this.btnCheckSystem.UseVisualStyleBackColor = true;
            this.btnCheckSystem.Click += new System.EventHandler(this.btnCheckSystem_Click);
            // 
            // btnSystemRun
            // 
            this.btnSystemRun.Location = new System.Drawing.Point(25, 68);
            this.btnSystemRun.Name = "btnSystemRun";
            this.btnSystemRun.Size = new System.Drawing.Size(124, 23);
            this.btnSystemRun.TabIndex = 3;
            this.btnSystemRun.Text = "SYS_Run";
            this.btnSystemRun.UseVisualStyleBackColor = true;
            this.btnSystemRun.Click += new System.EventHandler(this.btnSystemRun_Click);
            // 
            // btnSystemInit
            // 
            this.btnSystemInit.Location = new System.Drawing.Point(25, 28);
            this.btnSystemInit.Name = "btnSystemInit";
            this.btnSystemInit.Size = new System.Drawing.Size(124, 23);
            this.btnSystemInit.TabIndex = 2;
            this.btnSystemInit.Text = "SYS_Init";
            this.btnSystemInit.UseVisualStyleBackColor = true;
            this.btnSystemInit.Click += new System.EventHandler(this.btnSystemInit_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(26, 146);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(108, 52);
            this.Button1.TabIndex = 20;
            this.Button1.Text = "Axis Ready Check";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.btnAxisReadyCheck_Click);
            // 
            // btnSystemStop
            // 
            this.btnSystemStop.Location = new System.Drawing.Point(25, 24);
            this.btnSystemStop.Name = "btnSystemStop";
            this.btnSystemStop.Size = new System.Drawing.Size(124, 23);
            this.btnSystemStop.TabIndex = 9;
            this.btnSystemStop.Text = "SYS_Stop";
            this.btnSystemStop.UseVisualStyleBackColor = true;
            this.btnSystemStop.Click += new System.EventHandler(this.btnSystemStop_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(26, 117);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(108, 23);
            this.btnHome.TabIndex = 19;
            this.btnHome.Text = "AX_Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSystemClose
            // 
            this.btnSystemClose.Location = new System.Drawing.Point(25, 24);
            this.btnSystemClose.Name = "btnSystemClose";
            this.btnSystemClose.Size = new System.Drawing.Size(138, 23);
            this.btnSystemClose.TabIndex = 9;
            this.btnSystemClose.Text = "SYS_Destroy";
            this.btnSystemClose.UseVisualStyleBackColor = true;
            this.btnSystemClose.Click += new System.EventHandler(this.btnSystemClose_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(169, 24);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(166, 24);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "Refer to Form_System.cs of \r\nthe Advanced example.";
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.btnSystemClose);
            this.GroupBox4.Controls.Add(this.Label4);
            this.GroupBox4.Location = new System.Drawing.Point(12, 501);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(347, 64);
            this.GroupBox4.TabIndex = 13;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Step4. Application termination";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(169, 24);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(166, 24);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "Refer to Form_System.cs of \r\nthe Advanced example.";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.btnSystemStop);
            this.GroupBox3.Controls.Add(this.Label3);
            this.GroupBox3.Location = new System.Drawing.Point(12, 431);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(347, 64);
            this.GroupBox3.TabIndex = 12;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Step3. MXP Control Stop";
            // 
            // btnPowerOff
            // 
            this.btnPowerOff.Location = new System.Drawing.Point(26, 208);
            this.btnPowerOff.Name = "btnPowerOff";
            this.btnPowerOff.Size = new System.Drawing.Size(108, 23);
            this.btnPowerOff.TabIndex = 17;
            this.btnPowerOff.Text = "AX_Power(Off)";
            this.btnPowerOff.UseVisualStyleBackColor = true;
            this.btnPowerOff.Click += new System.EventHandler(this.btnPowerOff_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.Button1);
            this.GroupBox2.Controls.Add(this.btnHome);
            this.GroupBox2.Controls.Add(this.btnAxisReadyCheck);
            this.GroupBox2.Controls.Add(this.btnPowerOff);
            this.GroupBox2.Controls.Add(this.btnPowerOn);
            this.GroupBox2.Location = new System.Drawing.Point(12, 183);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(347, 242);
            this.GroupBox2.TabIndex = 11;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Step2. Using MXP Function";
            // 
            // btnAxisReadyCheck
            // 
            this.btnAxisReadyCheck.Location = new System.Drawing.Point(25, 59);
            this.btnAxisReadyCheck.Name = "btnAxisReadyCheck";
            this.btnAxisReadyCheck.Size = new System.Drawing.Size(108, 52);
            this.btnAxisReadyCheck.TabIndex = 18;
            this.btnAxisReadyCheck.Text = "Axis Ready Check";
            this.btnAxisReadyCheck.UseVisualStyleBackColor = true;
            this.btnAxisReadyCheck.Click += new System.EventHandler(this.btnAxisReadyCheck_Click);
            // 
            // btnPowerOn
            // 
            this.btnPowerOn.Location = new System.Drawing.Point(26, 30);
            this.btnPowerOn.Name = "btnPowerOn";
            this.btnPowerOn.Size = new System.Drawing.Size(108, 23);
            this.btnPowerOn.TabIndex = 16;
            this.btnPowerOn.Text = "AX_Power(On)";
            this.btnPowerOn.UseVisualStyleBackColor = true;
            this.btnPowerOn.Click += new System.EventHandler(this.btnPowerOn_Click);
            // 
            // LinkManual
            // 
            this.LinkManual.AutoSize = true;
            this.LinkManual.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LinkManual.Location = new System.Drawing.Point(12, 10);
            this.LinkManual.Name = "LinkManual";
            this.LinkManual.Size = new System.Drawing.Size(39, 13);
            this.LinkManual.TabIndex = 14;
            this.LinkManual.TabStop = true;
            this.LinkManual.Text = "Help";
            this.LinkManual.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkManual_LinkClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 41);
            this.button2.TabIndex = 9;
            this.button2.Text = "SYS_Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_Basic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 576);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.LinkManual);
            this.Name = "Form_Basic";
            this.Text = "Basic Sample";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnCheckSystem;
        internal System.Windows.Forms.Button btnSystemRun;
        internal System.Windows.Forms.Button btnSystemInit;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button btnSystemStop;
        internal System.Windows.Forms.Button btnHome;
        internal System.Windows.Forms.Button btnSystemClose;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Button btnPowerOff;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btnAxisReadyCheck;
        internal System.Windows.Forms.Button btnPowerOn;
        internal System.Windows.Forms.LinkLabel LinkManual;
        internal System.Windows.Forms.Button button2;
    }
}

