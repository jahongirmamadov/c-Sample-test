namespace AdvancedSample
{
    partial class Form_TouchProb
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
            this.Button1 = new System.Windows.Forms.Button();
            this.btnTouchprob1State = new System.Windows.Forms.Button();
            this.btnTouchprob1Set = new System.Windows.Forms.Button();
            this.TimerTouch = new System.Windows.Forms.Timer(this.components);
            this.btnTouchProbPosition = new System.Windows.Forms.Button();
            this.txtEdge = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtMode = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtAxisNo = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button1.Location = new System.Drawing.Point(16, 209);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(290, 27);
            this.Button1.TabIndex = 74;
            this.Button1.Text = "Touchprobe1 Check Sample";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnTouchprob1State
            // 
            this.btnTouchprob1State.Location = new System.Drawing.Point(16, 151);
            this.btnTouchprob1State.Name = "btnTouchprob1State";
            this.btnTouchprob1State.Size = new System.Drawing.Size(155, 23);
            this.btnTouchprob1State.TabIndex = 72;
            this.btnTouchprob1State.Text = "Touchprobe1 State Check";
            this.btnTouchprob1State.UseVisualStyleBackColor = true;
            this.btnTouchprob1State.Click += new System.EventHandler(this.btnTouchprob1State_Click);
            // 
            // btnTouchprob1Set
            // 
            this.btnTouchprob1Set.Location = new System.Drawing.Point(16, 122);
            this.btnTouchprob1Set.Name = "btnTouchprob1Set";
            this.btnTouchprob1Set.Size = new System.Drawing.Size(155, 23);
            this.btnTouchprob1Set.TabIndex = 71;
            this.btnTouchprob1Set.Text = "Touchprobe1 Set";
            this.btnTouchprob1Set.UseVisualStyleBackColor = true;
            this.btnTouchprob1Set.Click += new System.EventHandler(this.btnTouchprob1Set_Click);
            // 
            // TimerTouch
            // 
            this.TimerTouch.Interval = 10;
            this.TimerTouch.Tick += new System.EventHandler(this.TimerTouch_Tick);
            // 
            // btnTouchProbPosition
            // 
            this.btnTouchProbPosition.Location = new System.Drawing.Point(16, 180);
            this.btnTouchProbPosition.Name = "btnTouchProbPosition";
            this.btnTouchProbPosition.Size = new System.Drawing.Size(155, 23);
            this.btnTouchProbPosition.TabIndex = 73;
            this.btnTouchProbPosition.Text = "Touchprobe1 Position Check";
            this.btnTouchProbPosition.UseVisualStyleBackColor = true;
            this.btnTouchProbPosition.Click += new System.EventHandler(this.btnTouchProbPosition_Click);
            // 
            // txtEdge
            // 
            this.txtEdge.Location = new System.Drawing.Point(251, 93);
            this.txtEdge.Name = "txtEdge";
            this.txtEdge.Size = new System.Drawing.Size(55, 21);
            this.txtEdge.TabIndex = 70;
            this.txtEdge.Text = "0";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(14, 96);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(231, 12);
            this.Label4.TabIndex = 69;
            this.Label4.Text = "Trigger Edge(0:Rising ,1:Falling, 2:Both)";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(251, 66);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(55, 21);
            this.txtType.TabIndex = 68;
            this.txtType.Text = "0";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(14, 69);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(215, 12);
            this.Label3.TabIndex = 67;
            this.Label3.Text = "Trigger Type(0:Touch probe,1:Index)";
            // 
            // txtMode
            // 
            this.txtMode.Location = new System.Drawing.Point(251, 39);
            this.txtMode.Name = "txtMode";
            this.txtMode.Size = new System.Drawing.Size(55, 21);
            this.txtMode.TabIndex = 66;
            this.txtMode.Text = "0";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(14, 42);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(207, 12);
            this.Label1.TabIndex = 65;
            this.Label1.Text = "Trigger Mode(0:Single,1:Cotinuous)";
            // 
            // txtAxisNo
            // 
            this.txtAxisNo.Location = new System.Drawing.Point(103, 12);
            this.txtAxisNo.Name = "txtAxisNo";
            this.txtAxisNo.Size = new System.Drawing.Size(78, 21);
            this.txtAxisNo.TabIndex = 64;
            this.txtAxisNo.Text = "0";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 17);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(79, 12);
            this.Label2.TabIndex = 63;
            this.Label2.Text = "Axis Number";
            // 
            // Form_TouchProb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 248);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.btnTouchprob1State);
            this.Controls.Add(this.btnTouchprob1Set);
            this.Controls.Add(this.btnTouchProbPosition);
            this.Controls.Add(this.txtEdge);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtMode);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtAxisNo);
            this.Controls.Add(this.Label2);
            this.Name = "Form_TouchProb";
            this.Text = "MXP_TouchProbe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button btnTouchprob1State;
        internal System.Windows.Forms.Button btnTouchprob1Set;
        internal System.Windows.Forms.Timer TimerTouch;
        internal System.Windows.Forms.Button btnTouchProbPosition;
        internal System.Windows.Forms.TextBox txtEdge;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtType;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtMode;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtAxisNo;
        internal System.Windows.Forms.Label Label2;
    }
}