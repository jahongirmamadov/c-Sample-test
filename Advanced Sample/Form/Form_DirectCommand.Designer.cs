namespace AdvancedSample
{
    partial class Form_DirectCommand
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
            this.btnDirectCmdCheck = new System.Windows.Forms.Button();
            this.txtTorque = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnHalt = new System.Windows.Forms.Button();
            this.btnCom = new System.Windows.Forms.Button();
            this.btnDirectTorque = new System.Windows.Forms.Button();
            this.txtAxisNo = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnDirectVel = new System.Windows.Forms.Button();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnDirectPos = new System.Windows.Forms.Button();
            this.txtVelocity = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDirectCmdCheck
            // 
            this.btnDirectCmdCheck.Location = new System.Drawing.Point(9, 201);
            this.btnDirectCmdCheck.Name = "btnDirectCmdCheck";
            this.btnDirectCmdCheck.Size = new System.Drawing.Size(265, 23);
            this.btnDirectCmdCheck.TabIndex = 85;
            this.btnDirectCmdCheck.Text = "Direct Command Check";
            this.btnDirectCmdCheck.UseVisualStyleBackColor = true;
            this.btnDirectCmdCheck.Click += new System.EventHandler(this.btnDirectCmdCheck_Click);
            // 
            // txtTorque
            // 
            this.txtTorque.Location = new System.Drawing.Point(103, 87);
            this.txtTorque.Name = "txtTorque";
            this.txtTorque.Size = new System.Drawing.Size(78, 21);
            this.txtTorque.TabIndex = 84;
            this.txtTorque.Text = "0";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(14, 90);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(45, 12);
            this.Label4.TabIndex = 83;
            this.Label4.Text = "Torque";
            // 
            // btnHalt
            // 
            this.btnHalt.Location = new System.Drawing.Point(145, 114);
            this.btnHalt.Name = "btnHalt";
            this.btnHalt.Size = new System.Drawing.Size(129, 81);
            this.btnHalt.TabIndex = 82;
            this.btnHalt.Text = "Halt";
            this.btnHalt.UseVisualStyleBackColor = true;
            this.btnHalt.Click += new System.EventHandler(this.btnHalt_Click);
            // 
            // btnCom
            // 
            this.btnCom.Location = new System.Drawing.Point(187, 6);
            this.btnCom.Name = "btnCom";
            this.btnCom.Size = new System.Drawing.Size(87, 75);
            this.btnCom.TabIndex = 81;
            this.btnCom.Text = "Common Monitor";
            this.btnCom.UseVisualStyleBackColor = true;
            this.btnCom.Click += new System.EventHandler(this.btnCom_Click);
            // 
            // btnDirectTorque
            // 
            this.btnDirectTorque.Location = new System.Drawing.Point(9, 172);
            this.btnDirectTorque.Name = "btnDirectTorque";
            this.btnDirectTorque.Size = new System.Drawing.Size(129, 23);
            this.btnDirectTorque.TabIndex = 80;
            this.btnDirectTorque.Text = "DirectToruqe";
            this.btnDirectTorque.UseVisualStyleBackColor = true;
            this.btnDirectTorque.Click += new System.EventHandler(this.btnDirectTorque_Click);
            // 
            // txtAxisNo
            // 
            this.txtAxisNo.Location = new System.Drawing.Point(103, 6);
            this.txtAxisNo.Name = "txtAxisNo";
            this.txtAxisNo.Size = new System.Drawing.Size(78, 21);
            this.txtAxisNo.TabIndex = 79;
            this.txtAxisNo.Text = "0";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(12, 11);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(79, 12);
            this.Label3.TabIndex = 78;
            this.Label3.Text = "Axis Number";
            // 
            // btnDirectVel
            // 
            this.btnDirectVel.Location = new System.Drawing.Point(9, 143);
            this.btnDirectVel.Name = "btnDirectVel";
            this.btnDirectVel.Size = new System.Drawing.Size(129, 23);
            this.btnDirectVel.TabIndex = 77;
            this.btnDirectVel.Text = "DirectVelocity";
            this.btnDirectVel.UseVisualStyleBackColor = true;
            this.btnDirectVel.Click += new System.EventHandler(this.btnDirectVel_Click);
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(103, 33);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(78, 21);
            this.txtPosition.TabIndex = 76;
            this.txtPosition.Text = "0";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(14, 36);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(50, 12);
            this.Label1.TabIndex = 75;
            this.Label1.Text = "Position";
            // 
            // btnDirectPos
            // 
            this.btnDirectPos.Location = new System.Drawing.Point(9, 114);
            this.btnDirectPos.Name = "btnDirectPos";
            this.btnDirectPos.Size = new System.Drawing.Size(129, 23);
            this.btnDirectPos.TabIndex = 74;
            this.btnDirectPos.Text = "DirectPostion ";
            this.btnDirectPos.UseVisualStyleBackColor = true;
            this.btnDirectPos.Click += new System.EventHandler(this.btnDirectPos_Click);
            // 
            // txtVelocity
            // 
            this.txtVelocity.Location = new System.Drawing.Point(103, 60);
            this.txtVelocity.Name = "txtVelocity";
            this.txtVelocity.Size = new System.Drawing.Size(78, 21);
            this.txtVelocity.TabIndex = 73;
            this.txtVelocity.Text = "0";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(14, 63);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(50, 12);
            this.Label12.TabIndex = 72;
            this.Label12.Text = "Velocity";
            // 
            // Form_DirectCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 233);
            this.Controls.Add(this.btnDirectCmdCheck);
            this.Controls.Add(this.txtTorque);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.btnHalt);
            this.Controls.Add(this.btnCom);
            this.Controls.Add(this.btnDirectTorque);
            this.Controls.Add(this.txtAxisNo);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.btnDirectVel);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnDirectPos);
            this.Controls.Add(this.txtVelocity);
            this.Controls.Add(this.Label12);
            this.Name = "Form_DirectCommand";
            this.Text = "MXP_DirectCommand";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnDirectCmdCheck;
        internal System.Windows.Forms.TextBox txtTorque;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnHalt;
        internal System.Windows.Forms.Button btnCom;
        internal System.Windows.Forms.Button btnDirectTorque;
        internal System.Windows.Forms.TextBox txtAxisNo;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btnDirectVel;
        internal System.Windows.Forms.TextBox txtPosition;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnDirectPos;
        internal System.Windows.Forms.TextBox txtVelocity;
        internal System.Windows.Forms.Label Label12;
    }
}