using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MXPEasyClass;

namespace AdvancedSample
{
    public partial class Form_IO : Form
    {
        public Form_IO()
        {
            InitializeComponent();
        }

        Form_Main frm1;

        public Form_IO(Form_Main _form)
        {
            InitializeComponent();
            frm1 = _form;            
        }

        private void btnWriteBit_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nSlaveNo = Convert.ToUInt32(txtSlaveNo.Text);
                UInt16 nOffset = Convert.ToUInt16(txtOffset.Text);
                Byte nBitNO = Convert.ToByte(txtBitNo.Text);
                Boolean bSetValue = (Convert.ToInt32(txtSetValue.Text) != 0 ? true : false);

                nResult = Module.MXP.IO_WriteBit(nSlaveNo, nOffset, nBitNO, bSetValue);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("MXP Cmd Set Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnOutBitRead_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nSlaveNo = Convert.ToUInt32(txtSlaveNo.Text);
                UInt16 nOffset = Convert.ToUInt16(txtOffset.Text);
                Byte nBitNO = Convert.ToByte(txtBitNo.Text);
                Boolean bReadValue = false;

                nResult = Module.MXP.IO_ReadBit(nSlaveNo, MXP_EasyClass.MXP_IO_TYPE.IO_Out, nOffset, nBitNO, out bReadValue);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Output ReadBit = " + bReadValue.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnInBitRead_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nSlaveNo = Convert.ToUInt32(txtSlaveNo.Text);
                UInt16 nOffset = Convert.ToUInt16(txtOffset.Text);
                Byte nBitNO = Convert.ToByte(txtBitNo.Text);
                Boolean bReadValue = false;

                nResult = Module.MXP.IO_ReadBit(nSlaveNo, MXP_EasyClass.MXP_IO_TYPE.IO_In, nOffset, nBitNO, out bReadValue);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Input ReadBit = " + bReadValue.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnWriteByte_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nSlaveNo = Convert.ToUInt32(txtSlaveNo.Text);
                UInt16 nOffset = Convert.ToUInt16(txtOffset.Text);
                Byte nSetValue = Convert.ToByte(txtSetValue.Text);

                nResult = Module.MXP.IO_WriteByte(nSlaveNo, nOffset, nSetValue);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("MXP Cmd Set Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnReadOutputByte_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nSlaveNo = Convert.ToUInt32(txtSlaveNo.Text);
                UInt16 nOffset = Convert.ToUInt16(txtOffset.Text);
                Byte nReadValue = 0;

                nResult = Module.MXP.IO_ReadByte(nSlaveNo, MXP_EasyClass.MXP_IO_TYPE.IO_Out, nOffset, out nReadValue);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Output ReadByte = " + nReadValue.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnReadInputByte_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nSlaveNo = Convert.ToUInt32(txtSlaveNo.Text);
                UInt16 nOffset = Convert.ToUInt16(txtOffset.Text);
                Byte nReadValue = 0;

                nResult = Module.MXP.IO_ReadByte(nSlaveNo, MXP_EasyClass.MXP_IO_TYPE.IO_In, nOffset, out nReadValue);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Input ReadByte = " + nReadValue.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnWriteWord_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nSlaveNo = Convert.ToUInt32(txtSlaveNo.Text);
                UInt16 nOffset = Convert.ToUInt16(txtOffset.Text);
                UInt16 nSetValue = Convert.ToUInt16(txtSetValue.Text);

                nResult = Module.MXP.IO_WriteWord(nSlaveNo, nOffset, nSetValue);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("MXP Cmd Set Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnReadOutputWord_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nSlaveNo = Convert.ToUInt32(txtSlaveNo.Text);
                UInt16 nOffset = Convert.ToUInt16(txtOffset.Text);
                UInt16 nReadValue = 0;

                nResult = Module.MXP.IO_ReadWord(nSlaveNo, MXP_EasyClass.MXP_IO_TYPE.IO_Out, nOffset, out nReadValue);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Output ReadWord = " + nReadValue.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnReadInputWord_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nSlaveNo = Convert.ToUInt32(txtSlaveNo.Text);
                UInt16 nOffset = Convert.ToUInt16(txtOffset.Text);
                UInt16 nReadValue = 0;

                nResult = Module.MXP.IO_ReadWord(nSlaveNo, MXP_EasyClass.MXP_IO_TYPE.IO_In, nOffset, out nReadValue);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Input ReadWord = " + nReadValue.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnWriteDWord_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nSlaveNo = Convert.ToUInt32(txtSlaveNo.Text);
                UInt16 nOffset = Convert.ToUInt16(txtOffset.Text);
                UInt32 nSetValue = Convert.ToUInt32(txtSetValue.Text);

                nResult = Module.MXP.IO_WriteDword(nSlaveNo, nOffset, nSetValue);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("MXP Cmd Set Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnReadOutputDWord_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nSlaveNo = Convert.ToUInt32(txtSlaveNo.Text);
                UInt16 nOffset = Convert.ToUInt16(txtOffset.Text);
                UInt32 nReadValue = 0;

                nResult = Module.MXP.IO_ReadDword(nSlaveNo, MXP_EasyClass.MXP_IO_TYPE.IO_Out, nOffset, out nReadValue);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Output Read DWord = " + nReadValue.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnReadInputDWord_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nSlaveNo = Convert.ToUInt32(txtSlaveNo.Text);
                UInt16 nOffset = Convert.ToUInt16(txtOffset.Text);
                UInt32 nReadValue = 0;

                nResult = Module.MXP.IO_ReadDword(nSlaveNo, MXP_EasyClass.MXP_IO_TYPE.IO_In, nOffset, out nReadValue);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Input ReadWord = " + nReadValue.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nSlaveNo = Convert.ToUInt32(txtSlaveNo.Text);
                UInt16 nOffset = Convert.ToUInt16(txtOffset.Text);
                Byte[] arrSetValue = BitConverter.GetBytes(Convert.ToUInt32(txtSetValue.Text));
                UInt16 nSize = Convert.ToUInt16(txtSize.Text);

                nResult = Module.MXP.IO_Write(nSlaveNo, nOffset, nSize, arrSetValue);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("MXP Cmd Set Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnReadOutput_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nSlaveNo = Convert.ToUInt32(txtSlaveNo.Text);
                UInt16 nOffset = Convert.ToUInt16(txtOffset.Text);
                UInt16 nSize = Convert.ToUInt16(txtSize.Text);
                Byte[] arrReadValue = new Byte[nSize];

                nResult = Module.MXP.IO_Read(nSlaveNo, MXP_EasyClass.MXP_IO_TYPE.IO_Out, nOffset, nSize, out arrReadValue);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Int32 i = 0;
                    String strOut = "";
                    strOut = "Output ReadArray = ";
                    for (i = 0; i < nSize; i++)
                        strOut = strOut + "\n" + arrReadValue[i].ToString();

                    MessageBox.Show(strOut, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
               
        }

        private void btnReadInput_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nSlaveNo = Convert.ToUInt32(txtSlaveNo.Text);
                UInt16 nOffset = Convert.ToUInt16(txtOffset.Text);
                UInt16 nSize = Convert.ToUInt16(txtSize.Text);
                Byte[] arrReadValue = new Byte[nSize];

                nResult = Module.MXP.IO_Read(nSlaveNo, MXP_EasyClass.MXP_IO_TYPE.IO_In, nOffset, nSize, out arrReadValue);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Int32 i = 0;
                    String strOut = "";
                    strOut = "Input ReadArray = ";
                    for (i = 0; i < nSize; i++)
                        strOut = strOut + "\n" + arrReadValue[i].ToString();

                    MessageBox.Show(strOut, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


        public class Crc16_IBM
        {
            private static ushort[] CrcTable = {
            0X0000, 0XC0C1, 0XC181, 0X0140, 0XC301, 0X03C0, 0X0280, 0XC241,
            0XC601, 0X06C0, 0X0780, 0XC741, 0X0500, 0XC5C1, 0XC481, 0X0440,
            0XCC01, 0X0CC0, 0X0D80, 0XCD41, 0X0F00, 0XCFC1, 0XCE81, 0X0E40,
            0X0A00, 0XCAC1, 0XCB81, 0X0B40, 0XC901, 0X09C0, 0X0880, 0XC841,
            0XD801, 0X18C0, 0X1980, 0XD941, 0X1B00, 0XDBC1, 0XDA81, 0X1A40,
            0X1E00, 0XDEC1, 0XDF81, 0X1F40, 0XDD01, 0X1DC0, 0X1C80, 0XDC41,
            0X1400, 0XD4C1, 0XD581, 0X1540, 0XD701, 0X17C0, 0X1680, 0XD641,
            0XD201, 0X12C0, 0X1380, 0XD341, 0X1100, 0XD1C1, 0XD081, 0X1040,
            0XF001, 0X30C0, 0X3180, 0XF141, 0X3300, 0XF3C1, 0XF281, 0X3240,
            0X3600, 0XF6C1, 0XF781, 0X3740, 0XF501, 0X35C0, 0X3480, 0XF441,
            0X3C00, 0XFCC1, 0XFD81, 0X3D40, 0XFF01, 0X3FC0, 0X3E80, 0XFE41,
            0XFA01, 0X3AC0, 0X3B80, 0XFB41, 0X3900, 0XF9C1, 0XF881, 0X3840,
            0X2800, 0XE8C1, 0XE981, 0X2940, 0XEB01, 0X2BC0, 0X2A80, 0XEA41,
            0XEE01, 0X2EC0, 0X2F80, 0XEF41, 0X2D00, 0XEDC1, 0XEC81, 0X2C40,
            0XE401, 0X24C0, 0X2580, 0XE541, 0X2700, 0XE7C1, 0XE681, 0X2640,
            0X2200, 0XE2C1, 0XE381, 0X2340, 0XE101, 0X21C0, 0X2080, 0XE041,
            0XA001, 0X60C0, 0X6180, 0XA141, 0X6300, 0XA3C1, 0XA281, 0X6240,
            0X6600, 0XA6C1, 0XA781, 0X6740, 0XA501, 0X65C0, 0X6480, 0XA441,
            0X6C00, 0XACC1, 0XAD81, 0X6D40, 0XAF01, 0X6FC0, 0X6E80, 0XAE41,
            0XAA01, 0X6AC0, 0X6B80, 0XAB41, 0X6900, 0XA9C1, 0XA881, 0X6840,
            0X7800, 0XB8C1, 0XB981, 0X7940, 0XBB01, 0X7BC0, 0X7A80, 0XBA41,
            0XBE01, 0X7EC0, 0X7F80, 0XBF41, 0X7D00, 0XBDC1, 0XBC81, 0X7C40,
            0XB401, 0X74C0, 0X7580, 0XB541, 0X7700, 0XB7C1, 0XB681, 0X7640,
            0X7200, 0XB2C1, 0XB381, 0X7340, 0XB101, 0X71C0, 0X7080, 0XB041,
            0X5000, 0X90C1, 0X9181, 0X5140, 0X9301, 0X53C0, 0X5280, 0X9241,
            0X9601, 0X56C0, 0X5780, 0X9741, 0X5500, 0X95C1, 0X9481, 0X5440,
            0X9C01, 0X5CC0, 0X5D80, 0X9D41, 0X5F00, 0X9FC1, 0X9E81, 0X5E40,
            0X5A00, 0X9AC1, 0X9B81, 0X5B40, 0X9901, 0X59C0, 0X5880, 0X9841,
            0X8801, 0X48C0, 0X4980, 0X8941, 0X4B00, 0X8BC1, 0X8A81, 0X4A40,
            0X4E00, 0X8EC1, 0X8F81, 0X4F40, 0X8D01, 0X4DC0, 0X4C80, 0X8C41,
            0X4400, 0X84C1, 0X8581, 0X4540, 0X8701, 0X47C0, 0X4680, 0X8641,
            0X8201, 0X42C0, 0X4380, 0X8341, 0X4100, 0X81C1, 0X8081, 0X4040 };

            public static UInt16 ComputeCrc(byte[] data)
            {
                ushort crc = 0xFFFF;

                foreach (byte datum in data)
                {
                    crc = (ushort)((crc >> 8) ^ CrcTable[(crc ^ datum) & 0xFF]);
                }

                return crc;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
            byte[] ImageData = {   0,  1,  2,  3,  4,  5,  6,  7,  8,  9,
                                      10, 11, 12, 13, 14, 15, 16, 17, 18, 19,
                                      20, 21, 22, 23, 24, 25, 26, 27, 28, 29,
                                      30, 31, 32, 33, 34, 35, 36, 37, 38, 39,
                                      40, 41, 42, 43, 44, 45, 46, 47, 48, 49,
                                      50, 51, 52, 53, 54, 55, 56, 57, 58, 59,
                                      60, 61, 62, 63, 64, 65, 66, 67, 68, 69,
                                      70, 11, 72, 73, 74, 75, 76, 77, 78, 79,
                                      80, 81, 82, 83, 84, 85, 86, 87, 88, 89,
                                      90, 91, 92, 93, 94, 95, 96, 97, 98, 99,
                                     100,101,102,103,104,105,106,107,108,109,
                                     110,111,112,113,114,115,116,117,118,119,
                                     120,121,122,123,124,125,126,127,128,129,
                                     130,131,132,133,134,135,136,137,138,139,
                                     140,141,142,143,144,145,146,147,148,149,
                                     150,151,152,153,154,155,156,157,158,159,
                                     160,161,162,163,164,165,166,167,168,169,
                                     170,111,172,173,174,175,176,177,178,179,
                                     180,181,182,183,184,185,186,187,255,189,
                                     190,191,192,193, };

            for (byte i = 0; i < ImageData.Length; i++)
            {
                nResult = Module.MXP.PLC_WriteByte((uint)(6000 + i), ImageData[i]);
            }

            UInt16 crcCal = Crc16_IBM.ComputeCrc(ImageData);
            nResult = Module.MXP.PLC_WriteUInt16(6200, crcCal);
            nResult = Module.MXP.PLC_WriteUInt16(6300, Convert.ToUInt16(ImageData.Length));
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }


    }
}
