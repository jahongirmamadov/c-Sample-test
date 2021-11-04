namespace AdvancedSample
{
    partial class Form_PLCInterface
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
            this.btnOutByteRead = new System.Windows.Forms.Button();
            this.btnWriteByte = new System.Windows.Forms.Button();
            this.btnOutBitRead = new System.Windows.Forms.Button();
            this.txtSetValue = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtBitNo = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnWriteBit = new System.Windows.Forms.Button();
            this.btnReadDouble = new System.Windows.Forms.Button();
            this.btnWriteDouble = new System.Windows.Forms.Button();
            this.btnReadInt32 = new System.Windows.Forms.Button();
            this.btnWriteInt32 = new System.Windows.Forms.Button();
            this.btnReadInt16 = new System.Windows.Forms.Button();
            this.btnWriteInt16 = new System.Windows.Forms.Button();
            this.btnReadUInt32 = new System.Windows.Forms.Button();
            this.btnWriteUInt32 = new System.Windows.Forms.Button();
            this.btnReadUInt16 = new System.Windows.Forms.Button();
            this.btnWriteUInt16 = new System.Windows.Forms.Button();
            this.btnReadFloat = new System.Windows.Forms.Button();
            this.btnWriteFloat = new System.Windows.Forms.Button();
            this.btnReadSByte = new System.Windows.Forms.Button();
            this.btnWriteSByte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOutByteRead
            // 
            this.btnOutByteRead.Location = new System.Drawing.Point(187, 135);
            this.btnOutByteRead.Name = "btnOutByteRead";
            this.btnOutByteRead.Size = new System.Drawing.Size(164, 23);
            this.btnOutByteRead.TabIndex = 58;
            this.btnOutByteRead.Text = "PLC Variable Byte Read";
            this.btnOutByteRead.UseVisualStyleBackColor = true;
            this.btnOutByteRead.Click += new System.EventHandler(this.btnOutByteRead_Click);
            // 
            // btnWriteByte
            // 
            this.btnWriteByte.Location = new System.Drawing.Point(17, 135);
            this.btnWriteByte.Name = "btnWriteByte";
            this.btnWriteByte.Size = new System.Drawing.Size(164, 23);
            this.btnWriteByte.TabIndex = 57;
            this.btnWriteByte.Text = "PLC Variable Byte Write";
            this.btnWriteByte.UseVisualStyleBackColor = true;
            this.btnWriteByte.Click += new System.EventHandler(this.btnWriteByte_Click);
            // 
            // btnOutBitRead
            // 
            this.btnOutBitRead.Location = new System.Drawing.Point(187, 105);
            this.btnOutBitRead.Name = "btnOutBitRead";
            this.btnOutBitRead.Size = new System.Drawing.Size(164, 23);
            this.btnOutBitRead.TabIndex = 54;
            this.btnOutBitRead.Text = "PLC Variable Bit Read";
            this.btnOutBitRead.UseVisualStyleBackColor = true;
            this.btnOutBitRead.Click += new System.EventHandler(this.btnOutBitRead_Click);
            // 
            // txtSetValue
            // 
            this.txtSetValue.Location = new System.Drawing.Point(110, 67);
            this.txtSetValue.Name = "txtSetValue";
            this.txtSetValue.Size = new System.Drawing.Size(78, 21);
            this.txtSetValue.TabIndex = 53;
            this.txtSetValue.Text = "1";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(19, 72);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(55, 12);
            this.Label5.TabIndex = 52;
            this.Label5.Text = "SetValue";
            // 
            // txtBitNo
            // 
            this.txtBitNo.Location = new System.Drawing.Point(110, 38);
            this.txtBitNo.Name = "txtBitNo";
            this.txtBitNo.Size = new System.Drawing.Size(78, 21);
            this.txtBitNo.TabIndex = 51;
            this.txtBitNo.Text = "0";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(19, 43);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(35, 12);
            this.Label4.TabIndex = 50;
            this.Label4.Text = "BitNo";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(110, 11);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(78, 21);
            this.txtAddress.TabIndex = 49;
            this.txtAddress.Text = "5000";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(19, 16);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(52, 12);
            this.Label2.TabIndex = 48;
            this.Label2.Text = "Address";
            // 
            // btnWriteBit
            // 
            this.btnWriteBit.Location = new System.Drawing.Point(17, 105);
            this.btnWriteBit.Name = "btnWriteBit";
            this.btnWriteBit.Size = new System.Drawing.Size(164, 23);
            this.btnWriteBit.TabIndex = 47;
            this.btnWriteBit.Text = "PLC Variable Bit Write";
            this.btnWriteBit.UseVisualStyleBackColor = true;
            this.btnWriteBit.Click += new System.EventHandler(this.btnWriteBit_Click);
            // 
            // btnReadDouble
            // 
            this.btnReadDouble.Location = new System.Drawing.Point(187, 339);
            this.btnReadDouble.Name = "btnReadDouble";
            this.btnReadDouble.Size = new System.Drawing.Size(164, 23);
            this.btnReadDouble.TabIndex = 70;
            this.btnReadDouble.Text = "PLC Variable Double Read";
            this.btnReadDouble.UseVisualStyleBackColor = true;
            this.btnReadDouble.Click += new System.EventHandler(this.btnReadDouble_Click);
            // 
            // btnWriteDouble
            // 
            this.btnWriteDouble.Location = new System.Drawing.Point(17, 339);
            this.btnWriteDouble.Name = "btnWriteDouble";
            this.btnWriteDouble.Size = new System.Drawing.Size(164, 23);
            this.btnWriteDouble.TabIndex = 69;
            this.btnWriteDouble.Text = "PLC Variable Double Write";
            this.btnWriteDouble.UseVisualStyleBackColor = true;
            this.btnWriteDouble.Click += new System.EventHandler(this.btnWriteDouble_Click);
            // 
            // btnReadInt32
            // 
            this.btnReadInt32.Location = new System.Drawing.Point(187, 281);
            this.btnReadInt32.Name = "btnReadInt32";
            this.btnReadInt32.Size = new System.Drawing.Size(164, 23);
            this.btnReadInt32.TabIndex = 68;
            this.btnReadInt32.Text = "PLC Variable Int32 Read";
            this.btnReadInt32.UseVisualStyleBackColor = true;
            this.btnReadInt32.Click += new System.EventHandler(this.btnReadInt32_Click);
            // 
            // btnWriteInt32
            // 
            this.btnWriteInt32.Location = new System.Drawing.Point(17, 281);
            this.btnWriteInt32.Name = "btnWriteInt32";
            this.btnWriteInt32.Size = new System.Drawing.Size(164, 23);
            this.btnWriteInt32.TabIndex = 67;
            this.btnWriteInt32.Text = "PLC Variable Int32 Write";
            this.btnWriteInt32.UseVisualStyleBackColor = true;
            this.btnWriteInt32.Click += new System.EventHandler(this.btnWriteInt32_Click);
            // 
            // btnReadInt16
            // 
            this.btnReadInt16.Location = new System.Drawing.Point(187, 223);
            this.btnReadInt16.Name = "btnReadInt16";
            this.btnReadInt16.Size = new System.Drawing.Size(164, 23);
            this.btnReadInt16.TabIndex = 66;
            this.btnReadInt16.Text = "PLC Variable Int16 Read";
            this.btnReadInt16.UseVisualStyleBackColor = true;
            this.btnReadInt16.Click += new System.EventHandler(this.btnReadInt16_Click);
            // 
            // btnWriteInt16
            // 
            this.btnWriteInt16.Location = new System.Drawing.Point(17, 222);
            this.btnWriteInt16.Name = "btnWriteInt16";
            this.btnWriteInt16.Size = new System.Drawing.Size(164, 23);
            this.btnWriteInt16.TabIndex = 65;
            this.btnWriteInt16.Text = "PLC Variable Int16 Write";
            this.btnWriteInt16.UseVisualStyleBackColor = true;
            this.btnWriteInt16.Click += new System.EventHandler(this.btnWriteInt16_Click);
            // 
            // btnReadUInt32
            // 
            this.btnReadUInt32.Location = new System.Drawing.Point(187, 252);
            this.btnReadUInt32.Name = "btnReadUInt32";
            this.btnReadUInt32.Size = new System.Drawing.Size(164, 23);
            this.btnReadUInt32.TabIndex = 64;
            this.btnReadUInt32.Text = "PLC Variable UInt32 Read";
            this.btnReadUInt32.UseVisualStyleBackColor = true;
            this.btnReadUInt32.Click += new System.EventHandler(this.btnReadUInt32_Click);
            // 
            // btnWriteUInt32
            // 
            this.btnWriteUInt32.Location = new System.Drawing.Point(17, 252);
            this.btnWriteUInt32.Name = "btnWriteUInt32";
            this.btnWriteUInt32.Size = new System.Drawing.Size(164, 23);
            this.btnWriteUInt32.TabIndex = 63;
            this.btnWriteUInt32.Text = "PLC Variable UInt32 Write";
            this.btnWriteUInt32.UseVisualStyleBackColor = true;
            this.btnWriteUInt32.Click += new System.EventHandler(this.btnWriteUInt32_Click);
            // 
            // btnReadUInt16
            // 
            this.btnReadUInt16.Location = new System.Drawing.Point(187, 193);
            this.btnReadUInt16.Name = "btnReadUInt16";
            this.btnReadUInt16.Size = new System.Drawing.Size(164, 23);
            this.btnReadUInt16.TabIndex = 62;
            this.btnReadUInt16.Text = "PLC Variable UInt16 Read";
            this.btnReadUInt16.UseVisualStyleBackColor = true;
            this.btnReadUInt16.Click += new System.EventHandler(this.btnReadUInt16_Click);
            // 
            // btnWriteUInt16
            // 
            this.btnWriteUInt16.Location = new System.Drawing.Point(17, 193);
            this.btnWriteUInt16.Name = "btnWriteUInt16";
            this.btnWriteUInt16.Size = new System.Drawing.Size(164, 23);
            this.btnWriteUInt16.TabIndex = 61;
            this.btnWriteUInt16.Text = "PLC Variable UInt16 Write";
            this.btnWriteUInt16.UseVisualStyleBackColor = true;
            this.btnWriteUInt16.Click += new System.EventHandler(this.btnWriteUInt16_Click);
            // 
            // btnReadFloat
            // 
            this.btnReadFloat.Location = new System.Drawing.Point(187, 310);
            this.btnReadFloat.Name = "btnReadFloat";
            this.btnReadFloat.Size = new System.Drawing.Size(164, 23);
            this.btnReadFloat.TabIndex = 60;
            this.btnReadFloat.Text = "PLC Variable Float Read";
            this.btnReadFloat.UseVisualStyleBackColor = true;
            this.btnReadFloat.Click += new System.EventHandler(this.btnReadFloat_Click);
            // 
            // btnWriteFloat
            // 
            this.btnWriteFloat.Location = new System.Drawing.Point(17, 310);
            this.btnWriteFloat.Name = "btnWriteFloat";
            this.btnWriteFloat.Size = new System.Drawing.Size(164, 23);
            this.btnWriteFloat.TabIndex = 59;
            this.btnWriteFloat.Text = "PLC Variable Float Write";
            this.btnWriteFloat.UseVisualStyleBackColor = true;
            this.btnWriteFloat.Click += new System.EventHandler(this.btnWriteFloat_Click);
            // 
            // btnReadSByte
            // 
            this.btnReadSByte.Location = new System.Drawing.Point(187, 164);
            this.btnReadSByte.Name = "btnReadSByte";
            this.btnReadSByte.Size = new System.Drawing.Size(164, 23);
            this.btnReadSByte.TabIndex = 82;
            this.btnReadSByte.Text = "PLC Variable SByte Read";
            this.btnReadSByte.UseVisualStyleBackColor = true;
            this.btnReadSByte.Click += new System.EventHandler(this.btnReadSByte_Click);
            // 
            // btnWriteSByte
            // 
            this.btnWriteSByte.Location = new System.Drawing.Point(17, 164);
            this.btnWriteSByte.Name = "btnWriteSByte";
            this.btnWriteSByte.Size = new System.Drawing.Size(164, 23);
            this.btnWriteSByte.TabIndex = 81;
            this.btnWriteSByte.Text = "PLC Variable SByte Write";
            this.btnWriteSByte.UseVisualStyleBackColor = true;
            this.btnWriteSByte.Click += new System.EventHandler(this.btnWriteSByte_Click);
            // 
            // Form_PLCInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 372);
            this.Controls.Add(this.btnReadSByte);
            this.Controls.Add(this.btnWriteSByte);
            this.Controls.Add(this.btnReadDouble);
            this.Controls.Add(this.btnWriteDouble);
            this.Controls.Add(this.btnReadInt32);
            this.Controls.Add(this.btnWriteInt32);
            this.Controls.Add(this.btnReadInt16);
            this.Controls.Add(this.btnWriteInt16);
            this.Controls.Add(this.btnReadUInt32);
            this.Controls.Add(this.btnWriteUInt32);
            this.Controls.Add(this.btnReadUInt16);
            this.Controls.Add(this.btnWriteUInt16);
            this.Controls.Add(this.btnReadFloat);
            this.Controls.Add(this.btnWriteFloat);
            this.Controls.Add(this.btnOutByteRead);
            this.Controls.Add(this.btnWriteByte);
            this.Controls.Add(this.btnOutBitRead);
            this.Controls.Add(this.txtSetValue);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtBitNo);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btnWriteBit);
            this.Name = "Form_PLCInterface";
            this.Text = "MXP_PLCInterface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnOutByteRead;
        internal System.Windows.Forms.Button btnWriteByte;
        internal System.Windows.Forms.Button btnOutBitRead;
        internal System.Windows.Forms.TextBox txtSetValue;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtBitNo;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtAddress;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnWriteBit;
        internal System.Windows.Forms.Button btnReadDouble;
        internal System.Windows.Forms.Button btnWriteDouble;
        internal System.Windows.Forms.Button btnReadInt32;
        internal System.Windows.Forms.Button btnWriteInt32;
        internal System.Windows.Forms.Button btnReadInt16;
        internal System.Windows.Forms.Button btnWriteInt16;
        internal System.Windows.Forms.Button btnReadUInt32;
        internal System.Windows.Forms.Button btnWriteUInt32;
        internal System.Windows.Forms.Button btnReadUInt16;
        internal System.Windows.Forms.Button btnWriteUInt16;
        internal System.Windows.Forms.Button btnReadFloat;
        internal System.Windows.Forms.Button btnWriteFloat;
        internal System.Windows.Forms.Button btnReadSByte;
        internal System.Windows.Forms.Button btnWriteSByte;
    }
}