namespace AdvancedSample
{
    partial class Form_Monitoring
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
            this.btnGroupReadCmdVel = new System.Windows.Forms.Button();
            this.btnGroupReadCmdPos = new System.Windows.Forms.Button();
            this.btnGroupReadActVel = new System.Windows.Forms.Button();
            this.txtGroupNo = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.btnGroupReadActPos = new System.Windows.Forms.Button();
            this.btnReadError = new System.Windows.Forms.Button();
            this.btnReadCmdVelocity = new System.Windows.Forms.Button();
            this.btnReadCmdPosition = new System.Windows.Forms.Button();
            this.btnReadActualTorque = new System.Windows.Forms.Button();
            this.btnReadFollowingError = new System.Windows.Forms.Button();
            this.btnReadActialVelocity = new System.Windows.Forms.Button();
            this.btnAxisState = new System.Windows.Forms.Button();
            this.txtAxisNo = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnReadActialPosition = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGroupReadyCheck = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGroupReadCmdVel
            // 
            this.btnGroupReadCmdVel.Location = new System.Drawing.Point(6, 135);
            this.btnGroupReadCmdVel.Name = "btnGroupReadCmdVel";
            this.btnGroupReadCmdVel.Size = new System.Drawing.Size(203, 23);
            this.btnGroupReadCmdVel.TabIndex = 109;
            this.btnGroupReadCmdVel.Text = "Group Read Command Velocity";
            this.btnGroupReadCmdVel.UseVisualStyleBackColor = true;
            this.btnGroupReadCmdVel.Click += new System.EventHandler(this.btnGroupReadCmdVel_Click);
            // 
            // btnGroupReadCmdPos
            // 
            this.btnGroupReadCmdPos.Location = new System.Drawing.Point(6, 106);
            this.btnGroupReadCmdPos.Name = "btnGroupReadCmdPos";
            this.btnGroupReadCmdPos.Size = new System.Drawing.Size(203, 23);
            this.btnGroupReadCmdPos.TabIndex = 108;
            this.btnGroupReadCmdPos.Text = "Group Read Command  Position";
            this.btnGroupReadCmdPos.UseVisualStyleBackColor = true;
            this.btnGroupReadCmdPos.Click += new System.EventHandler(this.btnGroupReadCmdPos_Click);
            // 
            // btnGroupReadActVel
            // 
            this.btnGroupReadActVel.Location = new System.Drawing.Point(6, 77);
            this.btnGroupReadActVel.Name = "btnGroupReadActVel";
            this.btnGroupReadActVel.Size = new System.Drawing.Size(203, 23);
            this.btnGroupReadActVel.TabIndex = 107;
            this.btnGroupReadActVel.Text = "Group Read Actual Velocity";
            this.btnGroupReadActVel.UseVisualStyleBackColor = true;
            this.btnGroupReadActVel.Click += new System.EventHandler(this.btnGroupReadActVel_Click);
            // 
            // txtGroupNo
            // 
            this.txtGroupNo.Location = new System.Drawing.Point(86, 19);
            this.txtGroupNo.Name = "txtGroupNo";
            this.txtGroupNo.Size = new System.Drawing.Size(78, 21);
            this.txtGroupNo.TabIndex = 106;
            this.txtGroupNo.Text = "0";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(25, 22);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(55, 12);
            this.Label15.TabIndex = 105;
            this.Label15.Text = "GroupNo";
            // 
            // btnGroupReadActPos
            // 
            this.btnGroupReadActPos.Location = new System.Drawing.Point(6, 48);
            this.btnGroupReadActPos.Name = "btnGroupReadActPos";
            this.btnGroupReadActPos.Size = new System.Drawing.Size(203, 23);
            this.btnGroupReadActPos.TabIndex = 104;
            this.btnGroupReadActPos.Text = "Group Read Actual Position";
            this.btnGroupReadActPos.UseVisualStyleBackColor = true;
            this.btnGroupReadActPos.Click += new System.EventHandler(this.btnGroupReadActPos_Click);
            // 
            // btnReadError
            // 
            this.btnReadError.Location = new System.Drawing.Point(15, 251);
            this.btnReadError.Name = "btnReadError";
            this.btnReadError.Size = new System.Drawing.Size(159, 23);
            this.btnReadError.TabIndex = 103;
            this.btnReadError.Text = "Read Error";
            this.btnReadError.UseVisualStyleBackColor = true;
            this.btnReadError.Click += new System.EventHandler(this.btnReadError_Click);
            // 
            // btnReadCmdVelocity
            // 
            this.btnReadCmdVelocity.Location = new System.Drawing.Point(15, 222);
            this.btnReadCmdVelocity.Name = "btnReadCmdVelocity";
            this.btnReadCmdVelocity.Size = new System.Drawing.Size(159, 23);
            this.btnReadCmdVelocity.TabIndex = 102;
            this.btnReadCmdVelocity.Text = "Read Command Velocity";
            this.btnReadCmdVelocity.UseVisualStyleBackColor = true;
            this.btnReadCmdVelocity.Click += new System.EventHandler(this.btnReadCmdVelocity_Click);
            // 
            // btnReadCmdPosition
            // 
            this.btnReadCmdPosition.Location = new System.Drawing.Point(15, 193);
            this.btnReadCmdPosition.Name = "btnReadCmdPosition";
            this.btnReadCmdPosition.Size = new System.Drawing.Size(159, 23);
            this.btnReadCmdPosition.TabIndex = 101;
            this.btnReadCmdPosition.Text = "Read Command Position";
            this.btnReadCmdPosition.UseVisualStyleBackColor = true;
            this.btnReadCmdPosition.Click += new System.EventHandler(this.btnReadCmdPosition_Click);
            // 
            // btnReadActualTorque
            // 
            this.btnReadActualTorque.Location = new System.Drawing.Point(15, 135);
            this.btnReadActualTorque.Name = "btnReadActualTorque";
            this.btnReadActualTorque.Size = new System.Drawing.Size(159, 23);
            this.btnReadActualTorque.TabIndex = 100;
            this.btnReadActualTorque.Text = "Read Actual Torque";
            this.btnReadActualTorque.UseVisualStyleBackColor = true;
            this.btnReadActualTorque.Click += new System.EventHandler(this.btnReadActualTorque_Click);
            // 
            // btnReadFollowingError
            // 
            this.btnReadFollowingError.Location = new System.Drawing.Point(15, 164);
            this.btnReadFollowingError.Name = "btnReadFollowingError";
            this.btnReadFollowingError.Size = new System.Drawing.Size(159, 23);
            this.btnReadFollowingError.TabIndex = 99;
            this.btnReadFollowingError.Text = "Read Following Error";
            this.btnReadFollowingError.UseVisualStyleBackColor = true;
            this.btnReadFollowingError.Click += new System.EventHandler(this.btnReadFollowingError_Click);
            // 
            // btnReadActialVelocity
            // 
            this.btnReadActialVelocity.Location = new System.Drawing.Point(15, 106);
            this.btnReadActialVelocity.Name = "btnReadActialVelocity";
            this.btnReadActialVelocity.Size = new System.Drawing.Size(159, 23);
            this.btnReadActialVelocity.TabIndex = 98;
            this.btnReadActialVelocity.Text = "Read Actual Velocity";
            this.btnReadActialVelocity.UseVisualStyleBackColor = true;
            this.btnReadActialVelocity.Click += new System.EventHandler(this.btnReadActialVelocity_Click);
            // 
            // btnAxisState
            // 
            this.btnAxisState.Location = new System.Drawing.Point(15, 48);
            this.btnAxisState.Name = "btnAxisState";
            this.btnAxisState.Size = new System.Drawing.Size(159, 23);
            this.btnAxisState.TabIndex = 97;
            this.btnAxisState.Text = "Read Axis Status";
            this.btnAxisState.UseVisualStyleBackColor = true;
            this.btnAxisState.Click += new System.EventHandler(this.btnAxisState_Click);
            // 
            // txtAxisNo
            // 
            this.txtAxisNo.Location = new System.Drawing.Point(96, 19);
            this.txtAxisNo.Name = "txtAxisNo";
            this.txtAxisNo.Size = new System.Drawing.Size(78, 21);
            this.txtAxisNo.TabIndex = 96;
            this.txtAxisNo.Text = "0";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(13, 22);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(79, 12);
            this.Label2.TabIndex = 95;
            this.Label2.Text = "Axis Number";
            // 
            // btnReadActialPosition
            // 
            this.btnReadActialPosition.Location = new System.Drawing.Point(15, 77);
            this.btnReadActialPosition.Name = "btnReadActialPosition";
            this.btnReadActialPosition.Size = new System.Drawing.Size(159, 23);
            this.btnReadActialPosition.TabIndex = 94;
            this.btnReadActialPosition.Text = "Read Actual Position";
            this.btnReadActialPosition.UseVisualStyleBackColor = true;
            this.btnReadActialPosition.Click += new System.EventHandler(this.btnReadActialPosition_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReadCmdVelocity);
            this.groupBox1.Controls.Add(this.btnReadActialPosition);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.txtAxisNo);
            this.groupBox1.Controls.Add(this.btnAxisState);
            this.groupBox1.Controls.Add(this.btnReadActialVelocity);
            this.groupBox1.Controls.Add(this.btnReadFollowingError);
            this.groupBox1.Controls.Add(this.btnReadError);
            this.groupBox1.Controls.Add(this.btnReadActualTorque);
            this.groupBox1.Controls.Add(this.btnReadCmdPosition);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 284);
            this.groupBox1.TabIndex = 110;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Axis Monitoring";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGroupReadyCheck);
            this.groupBox2.Controls.Add(this.btnGroupReadCmdVel);
            this.groupBox2.Controls.Add(this.btnGroupReadActPos);
            this.groupBox2.Controls.Add(this.Label15);
            this.groupBox2.Controls.Add(this.btnGroupReadCmdPos);
            this.groupBox2.Controls.Add(this.txtGroupNo);
            this.groupBox2.Controls.Add(this.btnGroupReadActVel);
            this.groupBox2.Location = new System.Drawing.Point(219, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 284);
            this.groupBox2.TabIndex = 111;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Group Monitoring";
            // 
            // btnGroupReadyCheck
            // 
            this.btnGroupReadyCheck.Location = new System.Drawing.Point(6, 164);
            this.btnGroupReadyCheck.Name = "btnGroupReadyCheck";
            this.btnGroupReadyCheck.Size = new System.Drawing.Size(203, 23);
            this.btnGroupReadyCheck.TabIndex = 110;
            this.btnGroupReadyCheck.Text = "Group Ready Check";
            this.btnGroupReadyCheck.UseVisualStyleBackColor = true;
            this.btnGroupReadyCheck.Click += new System.EventHandler(this.btnGroupReadyCheck_Click);
            // 
            // Form_Monitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 305);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Monitoring";
            this.Text = "Monitoring";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnGroupReadCmdVel;
        internal System.Windows.Forms.Button btnGroupReadCmdPos;
        internal System.Windows.Forms.Button btnGroupReadActVel;
        internal System.Windows.Forms.TextBox txtGroupNo;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Button btnGroupReadActPos;
        internal System.Windows.Forms.Button btnReadError;
        internal System.Windows.Forms.Button btnReadCmdVelocity;
        internal System.Windows.Forms.Button btnReadCmdPosition;
        internal System.Windows.Forms.Button btnReadActualTorque;
        internal System.Windows.Forms.Button btnReadFollowingError;
        internal System.Windows.Forms.Button btnReadActialVelocity;
        internal System.Windows.Forms.Button btnAxisState;
        internal System.Windows.Forms.TextBox txtAxisNo;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnReadActialPosition;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button btnGroupReadyCheck;
    }
}