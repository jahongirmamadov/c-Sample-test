namespace AdvancedSample
{
    partial class Form_Parameter
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
            this.Button1 = new System.Windows.Forms.Button();
            this.btnWriteParameter = new System.Windows.Forms.Button();
            this.txtWriteValue = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtAxisParameterNo = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtAxisNo = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnReadParameter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(14, 168);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(243, 23);
            this.Button1.TabIndex = 32;
            this.Button1.Text = "StoreParameter";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnWriteParameter
            // 
            this.btnWriteParameter.Location = new System.Drawing.Point(14, 139);
            this.btnWriteParameter.Name = "btnWriteParameter";
            this.btnWriteParameter.Size = new System.Drawing.Size(243, 23);
            this.btnWriteParameter.TabIndex = 31;
            this.btnWriteParameter.Text = "WrtieParameter";
            this.btnWriteParameter.UseVisualStyleBackColor = true;
            this.btnWriteParameter.Click += new System.EventHandler(this.btnWriteParameter_Click);
            // 
            // txtWriteValue
            // 
            this.txtWriteValue.Location = new System.Drawing.Point(179, 70);
            this.txtWriteValue.Name = "txtWriteValue";
            this.txtWriteValue.Size = new System.Drawing.Size(78, 21);
            this.txtWriteValue.TabIndex = 30;
            this.txtWriteValue.Text = "0";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(12, 73);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(159, 12);
            this.Label3.TabIndex = 29;
            this.Label3.Text = "Axis Parameter Write Value";
            // 
            // txtAxisParameterNo
            // 
            this.txtAxisParameterNo.Location = new System.Drawing.Point(179, 43);
            this.txtAxisParameterNo.Name = "txtAxisParameterNo";
            this.txtAxisParameterNo.Size = new System.Drawing.Size(78, 21);
            this.txtAxisParameterNo.TabIndex = 28;
            this.txtAxisParameterNo.Text = "0";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 46);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(141, 12);
            this.Label1.TabIndex = 27;
            this.Label1.Text = "Axis Parameter Number";
            // 
            // txtAxisNo
            // 
            this.txtAxisNo.Location = new System.Drawing.Point(179, 12);
            this.txtAxisNo.Name = "txtAxisNo";
            this.txtAxisNo.Size = new System.Drawing.Size(78, 21);
            this.txtAxisNo.TabIndex = 26;
            this.txtAxisNo.Text = "0";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 19);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(79, 12);
            this.Label2.TabIndex = 25;
            this.Label2.Text = "Axis Number";
            // 
            // btnReadParameter
            // 
            this.btnReadParameter.Location = new System.Drawing.Point(14, 110);
            this.btnReadParameter.Name = "btnReadParameter";
            this.btnReadParameter.Size = new System.Drawing.Size(243, 23);
            this.btnReadParameter.TabIndex = 24;
            this.btnReadParameter.Text = "ReadParameter";
            this.btnReadParameter.UseVisualStyleBackColor = true;
            this.btnReadParameter.Click += new System.EventHandler(this.btnReadParameter_Click);
            // 
            // Form_Parameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 209);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.btnWriteParameter);
            this.Controls.Add(this.txtWriteValue);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtAxisParameterNo);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtAxisNo);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btnReadParameter);
            this.Name = "Form_Parameter";
            this.Text = "MXP_Parameter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button btnWriteParameter;
        internal System.Windows.Forms.TextBox txtWriteValue;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtAxisParameterNo;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtAxisNo;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnReadParameter;
    }
}