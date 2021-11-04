namespace AdvancedSample
{
    partial class Form_UnitChange
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
            this.btnTimeToMXPUnit = new System.Windows.Forms.Button();
            this.btnMXPtoTimeUnit = new System.Windows.Forms.Button();
            this.txtAccDecRampDown = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtLimitAccdec = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtAccdecBuildup = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtJerk = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtAccDec = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtTargetVel = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtAxisNo = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimeToMXPUnit
            // 
            this.btnTimeToMXPUnit.Location = new System.Drawing.Point(8, 134);
            this.btnTimeToMXPUnit.Name = "btnTimeToMXPUnit";
            this.btnTimeToMXPUnit.Size = new System.Drawing.Size(222, 23);
            this.btnTimeToMXPUnit.TabIndex = 48;
            this.btnTimeToMXPUnit.Text = "Time -> MXP Unit ";
            this.btnTimeToMXPUnit.UseVisualStyleBackColor = true;
            this.btnTimeToMXPUnit.Click += new System.EventHandler(this.btnTimeToMXPUnit_Click);
            // 
            // btnMXPtoTimeUnit
            // 
            this.btnMXPtoTimeUnit.Location = new System.Drawing.Point(17, 134);
            this.btnMXPtoTimeUnit.Name = "btnMXPtoTimeUnit";
            this.btnMXPtoTimeUnit.Size = new System.Drawing.Size(194, 23);
            this.btnMXPtoTimeUnit.TabIndex = 47;
            this.btnMXPtoTimeUnit.Text = "MXP Unit -> Time";
            this.btnMXPtoTimeUnit.UseVisualStyleBackColor = true;
            this.btnMXPtoTimeUnit.Click += new System.EventHandler(this.btnMXPtoTimeUnit_Click);
            // 
            // txtAccDecRampDown
            // 
            this.txtAccDecRampDown.Location = new System.Drawing.Point(152, 79);
            this.txtAccDecRampDown.Name = "txtAccDecRampDown";
            this.txtAccDecRampDown.Size = new System.Drawing.Size(78, 21);
            this.txtAccDecRampDown.TabIndex = 46;
            this.txtAccDecRampDown.Text = "0.1";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(6, 82);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(145, 12);
            this.Label5.TabIndex = 45;
            this.Label5.Text = "AccDecRampDown(sec)";
            // 
            // txtLimitAccdec
            // 
            this.txtLimitAccdec.Location = new System.Drawing.Point(152, 52);
            this.txtLimitAccdec.Name = "txtLimitAccdec";
            this.txtLimitAccdec.Size = new System.Drawing.Size(78, 21);
            this.txtLimitAccdec.TabIndex = 44;
            this.txtLimitAccdec.Text = "1.0";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(6, 55);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(107, 12);
            this.Label6.TabIndex = 43;
            this.Label6.Text = "LimitAccDec(sec)";
            // 
            // txtAccdecBuildup
            // 
            this.txtAccdecBuildup.Location = new System.Drawing.Point(152, 25);
            this.txtAccdecBuildup.Name = "txtAccdecBuildup";
            this.txtAccdecBuildup.Size = new System.Drawing.Size(78, 21);
            this.txtAccdecBuildup.TabIndex = 42;
            this.txtAccdecBuildup.Text = "0.1";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(6, 28);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(123, 12);
            this.Label7.TabIndex = 41;
            this.Label7.Text = "AccDecBuildUp(sec)";
            // 
            // txtJerk
            // 
            this.txtJerk.Location = new System.Drawing.Point(133, 106);
            this.txtJerk.Name = "txtJerk";
            this.txtJerk.Size = new System.Drawing.Size(78, 21);
            this.txtJerk.TabIndex = 40;
            this.txtJerk.Text = "10000";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(23, 109);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(28, 12);
            this.Label4.TabIndex = 39;
            this.Label4.Text = "Jerk";
            // 
            // txtAccDec
            // 
            this.txtAccDec.Location = new System.Drawing.Point(133, 79);
            this.txtAccDec.Name = "txtAccDec";
            this.txtAccDec.Size = new System.Drawing.Size(78, 21);
            this.txtAccDec.TabIndex = 38;
            this.txtAccDec.Text = "1000";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(23, 82);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(55, 12);
            this.Label3.TabIndex = 37;
            this.Label3.Text = "Acc/Dec";
            // 
            // txtTargetVel
            // 
            this.txtTargetVel.Location = new System.Drawing.Point(133, 52);
            this.txtTargetVel.Name = "txtTargetVel";
            this.txtTargetVel.Size = new System.Drawing.Size(78, 21);
            this.txtTargetVel.TabIndex = 36;
            this.txtTargetVel.Text = "100";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(23, 55);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(90, 12);
            this.Label1.TabIndex = 35;
            this.Label1.Text = "Target Velocity";
            // 
            // txtAxisNo
            // 
            this.txtAxisNo.Location = new System.Drawing.Point(133, 25);
            this.txtAxisNo.Name = "txtAxisNo";
            this.txtAxisNo.Size = new System.Drawing.Size(78, 21);
            this.txtAxisNo.TabIndex = 34;
            this.txtAxisNo.Text = "0";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(23, 28);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(79, 12);
            this.Label2.TabIndex = 33;
            this.Label2.Text = "Axis Number";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMXPtoTimeUnit);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.txtAxisNo);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Controls.Add(this.txtTargetVel);
            this.groupBox1.Controls.Add(this.Label3);
            this.groupBox1.Controls.Add(this.txtAccDec);
            this.groupBox1.Controls.Add(this.Label4);
            this.groupBox1.Controls.Add(this.txtJerk);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 175);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MXP Unit -> Time";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Label7);
            this.groupBox2.Controls.Add(this.txtAccdecBuildup);
            this.groupBox2.Controls.Add(this.btnTimeToMXPUnit);
            this.groupBox2.Controls.Add(this.Label6);
            this.groupBox2.Controls.Add(this.txtAccDecRampDown);
            this.groupBox2.Controls.Add(this.txtLimitAccdec);
            this.groupBox2.Controls.Add(this.Label5);
            this.groupBox2.Location = new System.Drawing.Point(246, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 175);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Time -> MXP Unit";
            // 
            // Form_UnitChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 198);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_UnitChange";
            this.Text = "MXP_UnitChange";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnTimeToMXPUnit;
        internal System.Windows.Forms.Button btnMXPtoTimeUnit;
        internal System.Windows.Forms.TextBox txtAccDecRampDown;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtLimitAccdec;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtAccdecBuildup;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtJerk;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtAccDec;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtTargetVel;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtAxisNo;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}