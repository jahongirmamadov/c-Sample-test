namespace AdvancedSample
{
    partial class Form_IO
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
            this.btnReadInput = new System.Windows.Forms.Button();
            this.btnReadOutput = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnReadInputDWord = new System.Windows.Forms.Button();
            this.btnReadOutputDWord = new System.Windows.Forms.Button();
            this.btnWriteDWord = new System.Windows.Forms.Button();
            this.btnReadInputWord = new System.Windows.Forms.Button();
            this.btnReadOutputWord = new System.Windows.Forms.Button();
            this.btnWriteWord = new System.Windows.Forms.Button();
            this.btnReadInputByte = new System.Windows.Forms.Button();
            this.btnReadOutputByte = new System.Windows.Forms.Button();
            this.btnWriteByte = new System.Windows.Forms.Button();
            this.btnInBitRead = new System.Windows.Forms.Button();
            this.btnOutBitRead = new System.Windows.Forms.Button();
            this.txtSetValue = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtBitNo = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtOffset = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtSlaveNo = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnWriteBit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReadInput
            // 
            this.btnReadInput.Location = new System.Drawing.Point(160, 462);
            this.btnReadInput.Name = "btnReadInput";
            this.btnReadInput.Size = new System.Drawing.Size(150, 25);
            this.btnReadInput.TabIndex = 67;
            this.btnReadInput.Text = "Read IO Byte Array (Input)";
            this.btnReadInput.UseVisualStyleBackColor = true;
            this.btnReadInput.Click += new System.EventHandler(this.btnReadInput_Click);
            // 
            // btnReadOutput
            // 
            this.btnReadOutput.Location = new System.Drawing.Point(160, 428);
            this.btnReadOutput.Name = "btnReadOutput";
            this.btnReadOutput.Size = new System.Drawing.Size(150, 25);
            this.btnReadOutput.TabIndex = 66;
            this.btnReadOutput.Text = "Read IO Byte Array (Output)";
            this.btnReadOutput.UseVisualStyleBackColor = true;
            this.btnReadOutput.Click += new System.EventHandler(this.btnReadOutput_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(15, 428);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(141, 25);
            this.btnWrite.TabIndex = 65;
            this.btnWrite.Text = "Write IO Byte Array";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnReadInputDWord
            // 
            this.btnReadInputDWord.Location = new System.Drawing.Point(160, 394);
            this.btnReadInputDWord.Name = "btnReadInputDWord";
            this.btnReadInputDWord.Size = new System.Drawing.Size(150, 25);
            this.btnReadInputDWord.TabIndex = 64;
            this.btnReadInputDWord.Text = "Read IO Dword (Input)";
            this.btnReadInputDWord.UseVisualStyleBackColor = true;
            this.btnReadInputDWord.Click += new System.EventHandler(this.btnReadInputDWord_Click);
            // 
            // btnReadOutputDWord
            // 
            this.btnReadOutputDWord.Location = new System.Drawing.Point(160, 361);
            this.btnReadOutputDWord.Name = "btnReadOutputDWord";
            this.btnReadOutputDWord.Size = new System.Drawing.Size(150, 25);
            this.btnReadOutputDWord.TabIndex = 63;
            this.btnReadOutputDWord.Text = "Read IO Dword (Output)";
            this.btnReadOutputDWord.UseVisualStyleBackColor = true;
            this.btnReadOutputDWord.Click += new System.EventHandler(this.btnReadOutputDWord_Click);
            // 
            // btnWriteDWord
            // 
            this.btnWriteDWord.Location = new System.Drawing.Point(15, 361);
            this.btnWriteDWord.Name = "btnWriteDWord";
            this.btnWriteDWord.Size = new System.Drawing.Size(141, 25);
            this.btnWriteDWord.TabIndex = 62;
            this.btnWriteDWord.Text = "Write IO Dword";
            this.btnWriteDWord.UseVisualStyleBackColor = true;
            this.btnWriteDWord.Click += new System.EventHandler(this.btnWriteDWord_Click);
            // 
            // btnReadInputWord
            // 
            this.btnReadInputWord.Location = new System.Drawing.Point(160, 327);
            this.btnReadInputWord.Name = "btnReadInputWord";
            this.btnReadInputWord.Size = new System.Drawing.Size(150, 25);
            this.btnReadInputWord.TabIndex = 61;
            this.btnReadInputWord.Text = "Read IO Word (Input)";
            this.btnReadInputWord.UseVisualStyleBackColor = true;
            this.btnReadInputWord.Click += new System.EventHandler(this.btnReadInputWord_Click);
            // 
            // btnReadOutputWord
            // 
            this.btnReadOutputWord.Location = new System.Drawing.Point(160, 294);
            this.btnReadOutputWord.Name = "btnReadOutputWord";
            this.btnReadOutputWord.Size = new System.Drawing.Size(150, 25);
            this.btnReadOutputWord.TabIndex = 60;
            this.btnReadOutputWord.Text = "Read IO Word (Output)";
            this.btnReadOutputWord.UseVisualStyleBackColor = true;
            this.btnReadOutputWord.Click += new System.EventHandler(this.btnReadOutputWord_Click);
            // 
            // btnWriteWord
            // 
            this.btnWriteWord.Location = new System.Drawing.Point(15, 294);
            this.btnWriteWord.Name = "btnWriteWord";
            this.btnWriteWord.Size = new System.Drawing.Size(141, 25);
            this.btnWriteWord.TabIndex = 59;
            this.btnWriteWord.Text = "Write IO Word";
            this.btnWriteWord.UseVisualStyleBackColor = true;
            this.btnWriteWord.Click += new System.EventHandler(this.btnWriteWord_Click);
            // 
            // btnReadInputByte
            // 
            this.btnReadInputByte.Location = new System.Drawing.Point(160, 260);
            this.btnReadInputByte.Name = "btnReadInputByte";
            this.btnReadInputByte.Size = new System.Drawing.Size(150, 25);
            this.btnReadInputByte.TabIndex = 58;
            this.btnReadInputByte.Text = "Read IO Byte (Input)";
            this.btnReadInputByte.UseVisualStyleBackColor = true;
            this.btnReadInputByte.Click += new System.EventHandler(this.btnReadInputByte_Click);
            // 
            // btnReadOutputByte
            // 
            this.btnReadOutputByte.Location = new System.Drawing.Point(160, 226);
            this.btnReadOutputByte.Name = "btnReadOutputByte";
            this.btnReadOutputByte.Size = new System.Drawing.Size(150, 25);
            this.btnReadOutputByte.TabIndex = 57;
            this.btnReadOutputByte.Text = "Read IO Byte (Output)";
            this.btnReadOutputByte.UseVisualStyleBackColor = true;
            this.btnReadOutputByte.Click += new System.EventHandler(this.btnReadOutputByte_Click);
            // 
            // btnWriteByte
            // 
            this.btnWriteByte.Location = new System.Drawing.Point(15, 228);
            this.btnWriteByte.Name = "btnWriteByte";
            this.btnWriteByte.Size = new System.Drawing.Size(141, 25);
            this.btnWriteByte.TabIndex = 56;
            this.btnWriteByte.Text = "Write IO Byte";
            this.btnWriteByte.UseVisualStyleBackColor = true;
            this.btnWriteByte.Click += new System.EventHandler(this.btnWriteByte_Click);
            // 
            // btnInBitRead
            // 
            this.btnInBitRead.Location = new System.Drawing.Point(160, 193);
            this.btnInBitRead.Name = "btnInBitRead";
            this.btnInBitRead.Size = new System.Drawing.Size(150, 25);
            this.btnInBitRead.TabIndex = 55;
            this.btnInBitRead.Text = "Read IO Bit (Input)";
            this.btnInBitRead.UseVisualStyleBackColor = true;
            this.btnInBitRead.Click += new System.EventHandler(this.btnInBitRead_Click);
            // 
            // btnOutBitRead
            // 
            this.btnOutBitRead.Location = new System.Drawing.Point(160, 159);
            this.btnOutBitRead.Name = "btnOutBitRead";
            this.btnOutBitRead.Size = new System.Drawing.Size(150, 25);
            this.btnOutBitRead.TabIndex = 54;
            this.btnOutBitRead.Text = "Read IO Bit (Output)";
            this.btnOutBitRead.UseVisualStyleBackColor = true;
            this.btnOutBitRead.Click += new System.EventHandler(this.btnOutBitRead_Click);
            // 
            // txtSetValue
            // 
            this.txtSetValue.Location = new System.Drawing.Point(88, 130);
            this.txtSetValue.Name = "txtSetValue";
            this.txtSetValue.Size = new System.Drawing.Size(67, 20);
            this.txtSetValue.TabIndex = 53;
            this.txtSetValue.Text = "0";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(10, 135);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(50, 13);
            this.Label5.TabIndex = 52;
            this.Label5.Text = "SetValue";
            // 
            // txtBitNo
            // 
            this.txtBitNo.Location = new System.Drawing.Point(88, 99);
            this.txtBitNo.Name = "txtBitNo";
            this.txtBitNo.Size = new System.Drawing.Size(67, 20);
            this.txtBitNo.TabIndex = 51;
            this.txtBitNo.Text = "0";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(10, 104);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(33, 13);
            this.Label4.TabIndex = 50;
            this.Label4.Text = "BitNo";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(88, 69);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(67, 20);
            this.txtSize.TabIndex = 49;
            this.txtSize.Text = "0";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(10, 75);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(27, 13);
            this.Label3.TabIndex = 48;
            this.Label3.Text = "Size";
            // 
            // txtOffset
            // 
            this.txtOffset.Location = new System.Drawing.Point(88, 40);
            this.txtOffset.Name = "txtOffset";
            this.txtOffset.Size = new System.Drawing.Size(67, 20);
            this.txtOffset.TabIndex = 47;
            this.txtOffset.Text = "0";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(10, 46);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(35, 13);
            this.Label1.TabIndex = 46;
            this.Label1.Text = "Offset";
            // 
            // txtSlaveNo
            // 
            this.txtSlaveNo.Location = new System.Drawing.Point(88, 11);
            this.txtSlaveNo.Name = "txtSlaveNo";
            this.txtSlaveNo.Size = new System.Drawing.Size(67, 20);
            this.txtSlaveNo.TabIndex = 45;
            this.txtSlaveNo.Text = "0";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(10, 16);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(74, 13);
            this.Label2.TabIndex = 44;
            this.Label2.Text = "Slave Number";
            // 
            // btnWriteBit
            // 
            this.btnWriteBit.Location = new System.Drawing.Point(15, 159);
            this.btnWriteBit.Name = "btnWriteBit";
            this.btnWriteBit.Size = new System.Drawing.Size(141, 25);
            this.btnWriteBit.TabIndex = 43;
            this.btnWriteBit.Text = "Write IO Bit";
            this.btnWriteBit.UseVisualStyleBackColor = true;
            this.btnWriteBit.Click += new System.EventHandler(this.btnWriteBit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 68;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_IO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 501);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReadInput);
            this.Controls.Add(this.btnReadOutput);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnReadInputDWord);
            this.Controls.Add(this.btnReadOutputDWord);
            this.Controls.Add(this.btnWriteDWord);
            this.Controls.Add(this.btnReadInputWord);
            this.Controls.Add(this.btnReadOutputWord);
            this.Controls.Add(this.btnWriteWord);
            this.Controls.Add(this.btnReadInputByte);
            this.Controls.Add(this.btnReadOutputByte);
            this.Controls.Add(this.btnWriteByte);
            this.Controls.Add(this.btnInBitRead);
            this.Controls.Add(this.btnOutBitRead);
            this.Controls.Add(this.txtSetValue);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtBitNo);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtOffset);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtSlaveNo);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btnWriteBit);
            this.Name = "Form_IO";
            this.Text = "MXP_IO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnReadInput;
        internal System.Windows.Forms.Button btnReadOutput;
        internal System.Windows.Forms.Button btnWrite;
        internal System.Windows.Forms.Button btnReadInputDWord;
        internal System.Windows.Forms.Button btnReadOutputDWord;
        internal System.Windows.Forms.Button btnWriteDWord;
        internal System.Windows.Forms.Button btnReadInputWord;
        internal System.Windows.Forms.Button btnReadOutputWord;
        internal System.Windows.Forms.Button btnWriteWord;
        internal System.Windows.Forms.Button btnReadInputByte;
        internal System.Windows.Forms.Button btnReadOutputByte;
        internal System.Windows.Forms.Button btnWriteByte;
        internal System.Windows.Forms.Button btnInBitRead;
        internal System.Windows.Forms.Button btnOutBitRead;
        internal System.Windows.Forms.TextBox txtSetValue;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtBitNo;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtSize;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtOffset;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtSlaveNo;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnWriteBit;
        private System.Windows.Forms.Button button1;
    }
}