namespace AdvancedSample
{
    partial class Form_COM
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
            this.GridState = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimerMonitoring = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.lblState = new System.Windows.Forms.Label();
            this.JogGroup = new System.Windows.Forms.GroupBox();
            this.btnRelativeMove = new System.Windows.Forms.Button();
            this.btnABSMove = new System.Windows.Forms.Button();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVelocity = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtJerk = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtDec = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtAcc = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.btnMJog = new System.Windows.Forms.Button();
            this.btnPJog = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeselect = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridState)).BeginInit();
            this.JogGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridState
            // 
            this.GridState.AllowUserToOrderColumns = true;
            this.GridState.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridState.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.GridState.Location = new System.Drawing.Point(3, 12);
            this.GridState.Name = "GridState";
            this.GridState.ReadOnly = true;
            this.GridState.RowHeadersWidth = 45;
            this.GridState.RowTemplate.Height = 23;
            this.GridState.Size = new System.Drawing.Size(799, 261);
            this.GridState.TabIndex = 9;
            this.GridState.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridState_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Power";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 66;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Status";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Drive Sensor State";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 190;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Actual Position";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Actual Velocity";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 60;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Actual Torque";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 60;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Command Position";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 60;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Command Velocity";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 60;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "MXP Error";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 51;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Drive Error";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 45;
            // 
            // TimerMonitoring
            // 
            this.TimerMonitoring.Tick += new System.EventHandler(this.TimerMonitoring_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Power On";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 37);
            this.button2.TabIndex = 10;
            this.button2.Text = "Power Off";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 411);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 37);
            this.button3.TabIndex = 10;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 454);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 37);
            this.button4.TabIndex = 10;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 368);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 37);
            this.button5.TabIndex = 10;
            this.button5.Text = "Halt";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(709, 454);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(84, 29);
            this.button7.TabIndex = 10;
            this.button7.Text = "Exit";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(415, 413);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(96, 12);
            this.lblState.TabIndex = 11;
            this.lblState.Text = "Monitoring State";
            // 
            // JogGroup
            // 
            this.JogGroup.Controls.Add(this.btnRelativeMove);
            this.JogGroup.Controls.Add(this.btnABSMove);
            this.JogGroup.Controls.Add(this.txtPosition);
            this.JogGroup.Controls.Add(this.label1);
            this.JogGroup.Controls.Add(this.txtVelocity);
            this.JogGroup.Controls.Add(this.Label12);
            this.JogGroup.Controls.Add(this.txtJerk);
            this.JogGroup.Controls.Add(this.Label8);
            this.JogGroup.Controls.Add(this.txtDec);
            this.JogGroup.Controls.Add(this.Label7);
            this.JogGroup.Controls.Add(this.txtAcc);
            this.JogGroup.Controls.Add(this.Label6);
            this.JogGroup.Controls.Add(this.btnMJog);
            this.JogGroup.Controls.Add(this.btnPJog);
            this.JogGroup.Location = new System.Drawing.Point(94, 279);
            this.JogGroup.Name = "JogGroup";
            this.JogGroup.Size = new System.Drawing.Size(303, 212);
            this.JogGroup.TabIndex = 79;
            this.JogGroup.TabStop = false;
            this.JogGroup.Text = "Jog Move";
            // 
            // btnRelativeMove
            // 
            this.btnRelativeMove.Location = new System.Drawing.Point(174, 71);
            this.btnRelativeMove.Name = "btnRelativeMove";
            this.btnRelativeMove.Size = new System.Drawing.Size(120, 48);
            this.btnRelativeMove.TabIndex = 81;
            this.btnRelativeMove.Text = "Relative Move";
            this.btnRelativeMove.UseVisualStyleBackColor = true;
            this.btnRelativeMove.Click += new System.EventHandler(this.btnRelativeMove_Click);
            // 
            // btnABSMove
            // 
            this.btnABSMove.Location = new System.Drawing.Point(174, 17);
            this.btnABSMove.Name = "btnABSMove";
            this.btnABSMove.Size = new System.Drawing.Size(120, 48);
            this.btnABSMove.TabIndex = 80;
            this.btnABSMove.Text = "Absolute Move";
            this.btnABSMove.UseVisualStyleBackColor = true;
            this.btnABSMove.Click += new System.EventHandler(this.btnABSMove_Click);
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(90, 17);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(78, 21);
            this.txtPosition.TabIndex = 74;
            this.txtPosition.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 12);
            this.label1.TabIndex = 73;
            this.label1.Text = "Position";
            // 
            // txtVelocity
            // 
            this.txtVelocity.Location = new System.Drawing.Point(90, 44);
            this.txtVelocity.Name = "txtVelocity";
            this.txtVelocity.Size = new System.Drawing.Size(78, 21);
            this.txtVelocity.TabIndex = 74;
            this.txtVelocity.Text = "10";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(4, 47);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(50, 12);
            this.Label12.TabIndex = 73;
            this.Label12.Text = "Velocity";
            // 
            // txtJerk
            // 
            this.txtJerk.Location = new System.Drawing.Point(90, 125);
            this.txtJerk.Name = "txtJerk";
            this.txtJerk.Size = new System.Drawing.Size(78, 21);
            this.txtJerk.TabIndex = 72;
            this.txtJerk.Text = "10000";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(4, 128);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(28, 12);
            this.Label8.TabIndex = 71;
            this.Label8.Text = "Jerk";
            // 
            // txtDec
            // 
            this.txtDec.Location = new System.Drawing.Point(90, 98);
            this.txtDec.Name = "txtDec";
            this.txtDec.Size = new System.Drawing.Size(78, 21);
            this.txtDec.TabIndex = 70;
            this.txtDec.Text = "1000";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(4, 101);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(75, 12);
            this.Label7.TabIndex = 69;
            this.Label7.Text = "Deceleration";
            // 
            // txtAcc
            // 
            this.txtAcc.Location = new System.Drawing.Point(90, 71);
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.Size = new System.Drawing.Size(78, 21);
            this.txtAcc.TabIndex = 68;
            this.txtAcc.Text = "1000";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(4, 74);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(75, 12);
            this.Label6.TabIndex = 67;
            this.Label6.Text = "Acceleration";
            // 
            // btnMJog
            // 
            this.btnMJog.Location = new System.Drawing.Point(5, 157);
            this.btnMJog.Name = "btnMJog";
            this.btnMJog.Size = new System.Drawing.Size(78, 46);
            this.btnMJog.TabIndex = 65;
            this.btnMJog.Text = "Job(-)";
            this.btnMJog.UseVisualStyleBackColor = true;
            this.btnMJog.Click += new System.EventHandler(this.btnMJog_Click);
            // 
            // btnPJog
            // 
            this.btnPJog.Location = new System.Drawing.Point(90, 157);
            this.btnPJog.Name = "btnPJog";
            this.btnPJog.Size = new System.Drawing.Size(78, 46);
            this.btnPJog.TabIndex = 66;
            this.btnPJog.Text = "Job(+)";
            this.btnPJog.UseVisualStyleBackColor = true;
            this.btnPJog.Click += new System.EventHandler(this.btnPJog_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeselect);
            this.groupBox1.Controls.Add(this.btnSelectAll);
            this.groupBox1.Location = new System.Drawing.Point(403, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 119);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Axis";
            // 
            // btnDeselect
            // 
            this.btnDeselect.Location = new System.Drawing.Point(6, 65);
            this.btnDeselect.Name = "btnDeselect";
            this.btnDeselect.Size = new System.Drawing.Size(109, 39);
            this.btnDeselect.TabIndex = 82;
            this.btnDeselect.Text = "Deselect All";
            this.btnDeselect.UseVisualStyleBackColor = true;
            this.btnDeselect.Click += new System.EventHandler(this.btnDeselect_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(6, 20);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(109, 39);
            this.btnSelectAll.TabIndex = 81;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // Form_COM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 495);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.JogGroup);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GridState);
            this.Name = "Form_COM";
            this.Text = "Common Monitor";
            ((System.ComponentModel.ISupportInitialize)(this.GridState)).EndInit();
            this.JogGroup.ResumeLayout(false);
            this.JogGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridState;
        private System.Windows.Forms.Timer TimerMonitoring;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label lblState;
        internal System.Windows.Forms.GroupBox JogGroup;
        internal System.Windows.Forms.TextBox txtVelocity;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox txtJerk;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtDec;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtAcc;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Button btnMJog;
        internal System.Windows.Forms.Button btnPJog;
        internal System.Windows.Forms.Button btnRelativeMove;
        internal System.Windows.Forms.Button btnABSMove;
        internal System.Windows.Forms.TextBox txtPosition;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Button btnDeselect;
        internal System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;

    }
}