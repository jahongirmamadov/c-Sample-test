namespace AdvancedSample
{
    partial class Form_FeedBackSensor
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
            this.btnApply = new System.Windows.Forms.Button();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtOverrideValue = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.txtOverrideDist = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtReduceValue = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtReduceVelDist = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtSensorTargetSetRange = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtSensorTargetValue = new System.Windows.Forms.TextBox();
            this.txtSlaveNo = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtOffset = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtAxisNo = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(15, 333);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(233, 67);
            this.btnApply.TabIndex = 77;
            this.btnApply.Text = "Set";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(12, 239);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(129, 12);
            this.Label10.TabIndex = 75;
            this.Label10.Text = "speed over ride Value";
            // 
            // txtOverrideValue
            // 
            this.txtOverrideValue.Location = new System.Drawing.Point(169, 237);
            this.txtOverrideValue.Name = "txtOverrideValue";
            this.txtOverrideValue.Size = new System.Drawing.Size(78, 21);
            this.txtOverrideValue.TabIndex = 76;
            this.txtOverrideValue.Text = "0.1";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(12, 212);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(148, 12);
            this.Label11.TabIndex = 73;
            this.Label11.Text = "speed  Override Distance";
            // 
            // txtOverrideDist
            // 
            this.txtOverrideDist.Location = new System.Drawing.Point(169, 210);
            this.txtOverrideDist.Name = "txtOverrideDist";
            this.txtOverrideDist.Size = new System.Drawing.Size(78, 21);
            this.txtOverrideDist.TabIndex = 74;
            this.txtOverrideDist.Text = "50";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(12, 185);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(90, 12);
            this.Label9.TabIndex = 71;
            this.Label9.Text = "reduced speed";
            // 
            // txtReduceValue
            // 
            this.txtReduceValue.Location = new System.Drawing.Point(169, 183);
            this.txtReduceValue.Name = "txtReduceValue";
            this.txtReduceValue.Size = new System.Drawing.Size(78, 21);
            this.txtReduceValue.TabIndex = 72;
            this.txtReduceValue.Text = "100";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(12, 158);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(143, 12);
            this.Label8.TabIndex = 69;
            this.Label8.Text = "reduced speed Distance";
            // 
            // txtReduceVelDist
            // 
            this.txtReduceVelDist.Location = new System.Drawing.Point(169, 156);
            this.txtReduceVelDist.Name = "txtReduceVelDist";
            this.txtReduceVelDist.Size = new System.Drawing.Size(78, 21);
            this.txtReduceVelDist.TabIndex = 70;
            this.txtReduceVelDist.Text = "300";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(12, 131);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(70, 12);
            this.Label7.TabIndex = 67;
            this.Label7.Text = "Sensor Unit";
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(169, 129);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(78, 21);
            this.txtUnit.TabIndex = 68;
            this.txtUnit.Text = "1";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(12, 298);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(156, 12);
            this.Label6.TabIndex = 65;
            this.Label6.Text = "Sensor Position Set Range";
            // 
            // txtSensorTargetSetRange
            // 
            this.txtSensorTargetSetRange.Location = new System.Drawing.Point(169, 296);
            this.txtSensorTargetSetRange.Name = "txtSensorTargetSetRange";
            this.txtSensorTargetSetRange.Size = new System.Drawing.Size(78, 21);
            this.txtSensorTargetSetRange.TabIndex = 66;
            this.txtSensorTargetSetRange.Text = "10";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 271);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(121, 12);
            this.Label1.TabIndex = 63;
            this.Label1.Text = "Sensor Target Value";
            // 
            // txtSensorTargetValue
            // 
            this.txtSensorTargetValue.Location = new System.Drawing.Point(169, 269);
            this.txtSensorTargetValue.Name = "txtSensorTargetValue";
            this.txtSensorTargetValue.Size = new System.Drawing.Size(78, 21);
            this.txtSensorTargetValue.TabIndex = 64;
            this.txtSensorTargetValue.Text = "1000";
            // 
            // txtSlaveNo
            // 
            this.txtSlaveNo.Location = new System.Drawing.Point(169, 45);
            this.txtSlaveNo.Name = "txtSlaveNo";
            this.txtSlaveNo.Size = new System.Drawing.Size(78, 21);
            this.txtSlaveNo.TabIndex = 58;
            this.txtSlaveNo.Text = "5";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(12, 47);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(129, 12);
            this.Label3.TabIndex = 57;
            this.Label3.Text = "Sensor Slave Number";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(12, 77);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(81, 12);
            this.Label4.TabIndex = 59;
            this.Label4.Text = "Sensor Offset";
            // 
            // txtOffset
            // 
            this.txtOffset.Location = new System.Drawing.Point(169, 75);
            this.txtOffset.Name = "txtOffset";
            this.txtOffset.Size = new System.Drawing.Size(78, 21);
            this.txtOffset.TabIndex = 60;
            this.txtOffset.Text = "0";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(12, 104);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(74, 12);
            this.Label5.TabIndex = 61;
            this.Label5.Text = "Sensor Size";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(169, 102);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(78, 21);
            this.txtSize.TabIndex = 62;
            this.txtSize.Text = "4";
            // 
            // txtAxisNo
            // 
            this.txtAxisNo.Location = new System.Drawing.Point(169, 18);
            this.txtAxisNo.Name = "txtAxisNo";
            this.txtAxisNo.Size = new System.Drawing.Size(78, 21);
            this.txtAxisNo.TabIndex = 56;
            this.txtAxisNo.Text = "3";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 21);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(79, 12);
            this.Label2.TabIndex = 55;
            this.Label2.Text = "Axis Number";
            // 
            // Form_FeedBackSensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 412);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.txtOverrideValue);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.txtOverrideDist);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.txtReduceValue);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.txtReduceVelDist);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtSensorTargetSetRange);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtSensorTargetValue);
            this.Controls.Add(this.txtSlaveNo);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtOffset);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtAxisNo);
            this.Controls.Add(this.Label2);
            this.Name = "Form_FeedBackSensor";
            this.Text = "Form_FeedBackSensor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnApply;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox txtOverrideValue;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox txtOverrideDist;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtReduceValue;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtReduceVelDist;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtUnit;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtSensorTargetSetRange;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtSensorTargetValue;
        internal System.Windows.Forms.TextBox txtSlaveNo;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtOffset;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtSize;
        internal System.Windows.Forms.TextBox txtAxisNo;
        internal System.Windows.Forms.Label Label2;
    }
}