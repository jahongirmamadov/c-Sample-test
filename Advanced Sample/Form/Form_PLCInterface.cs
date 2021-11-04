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
    public partial class Form_PLCInterface : Form
    {
        public Form_PLCInterface()
        {
            InitializeComponent();
        }

        Form_Main frm1;

        public Form_PLCInterface(Form_Main _form)
        {
            InitializeComponent();
            frm1 = _form;
        }

        private void btnWriteBit_Click(object sender, EventArgs e)
        {
            try
            {
                UInt32 nAddress = Convert.ToUInt32(txtAddress.Text);
                Byte nBitNo = Convert.ToByte(txtBitNo.Text);
                Boolean bSetValue = (Convert.ToInt32(txtSetValue.Text) != 0 ? true : false);
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

                nResult = Module.MXP.PLC_WriteBit(nAddress, nBitNo, bSetValue);

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
                UInt32 nAddress = Convert.ToUInt32(txtAddress.Text);
                Byte nBitNo = Convert.ToByte(txtBitNo.Text);
                Boolean bReadValue = false;
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

                nResult = Module.MXP.PLC_ReadBit(nAddress, nBitNo, out bReadValue);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("PLC ReadData = " + bReadValue.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                UInt32 nAddress = Convert.ToUInt32(txtAddress.Text);
                Byte nSetValue = Convert.ToByte(txtSetValue.Text);
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

                nResult = Module.MXP.PLC_WriteByte(nAddress, nSetValue);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("MXP Cmd Set Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch(Exception ex)  
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOutByteRead_Click(object sender, EventArgs e)
        {
            try
            {
                UInt32 nAddress = Convert.ToUInt32(txtAddress.Text);
                Byte nReadValue = 0;
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

                nResult = Module.MXP.PLC_ReadByte(nAddress, out nReadValue);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("PLC ReadData = " + nReadValue.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnWriteUInt16_Click(object sender, EventArgs e)
        {
            try
            {
                UInt32 nAddress = Convert.ToUInt32(txtAddress.Text);
                UInt16 nSetValue = Convert.ToUInt16(txtSetValue.Text);
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

                nResult = Module.MXP.PLC_WriteUInt16(nAddress, nSetValue);

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

        private void btnReadUInt16_Click(object sender, EventArgs e)
        {
            try
            {
                UInt32 nAddress = Convert.ToUInt32(txtAddress.Text);
                UInt16 nReadValue = 0;
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

                nResult = Module.MXP.PLC_ReadUInt16(nAddress, out nReadValue);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("PLC ReadData = " + nReadValue.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnWriteInt16_Click(object sender, EventArgs e)
        {
            try
            {
                UInt32 nAddress = Convert.ToUInt32(txtAddress.Text);
                Int16 nSetValue = Convert.ToInt16(txtSetValue.Text);
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

                nResult = Module.MXP.PLC_WriteInt16(nAddress, nSetValue);

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

        private void btnReadInt16_Click(object sender, EventArgs e)
        {
            try
            {
                UInt32 nAddress = Convert.ToUInt32(txtAddress.Text);
                Int16 nReadValue = 0;
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

                nResult = Module.MXP.PLC_ReadInt16(nAddress, out nReadValue);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("PLC ReadData = " + nReadValue.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnWriteUInt32_Click(object sender, EventArgs e)
        {
            try
            {
                UInt32 nAddress = Convert.ToUInt32(txtAddress.Text);
                UInt32 nSetValue = Convert.ToUInt32(txtSetValue.Text);
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

                nResult = Module.MXP.PLC_WriteUInt32(nAddress, nSetValue);

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

        private void btnReadUInt32_Click(object sender, EventArgs e)
        {
            try
            {
                UInt32 nAddress = Convert.ToUInt32(txtAddress.Text);
                UInt32 nReadValue = 0;
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

                nResult = Module.MXP.PLC_ReadUInt32(nAddress, out nReadValue);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("PLC ReadData = " + nReadValue.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnWriteInt32_Click(object sender, EventArgs e)
        {
            try
            {
                UInt32 nAddress = Convert.ToUInt32(txtAddress.Text);
                Int32 nSetValue = Convert.ToInt32(txtSetValue.Text);
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

                nResult = Module.MXP.PLC_WriteInt32(nAddress, nSetValue);

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

        private void btnReadInt32_Click(object sender, EventArgs e)
        {
            try
            {
                UInt32 nAddress = Convert.ToUInt32(txtAddress.Text);
                Int32 nReadValue = 0;
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

                nResult = Module.MXP.PLC_ReadInt32(nAddress, out nReadValue);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("PLC ReadData = " + nReadValue.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnWriteFloat_Click(object sender, EventArgs e)
        {
            try
            {
                UInt32 nAddress = Convert.ToUInt32(txtAddress.Text);
                Single fSetValue = Convert.ToSingle(txtSetValue.Text);
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

                nResult = Module.MXP.PLC_WriteFloat(nAddress, fSetValue);

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

        private void btnReadFloat_Click(object sender, EventArgs e)
        {
            try
            {
                UInt32 nAddress = Convert.ToUInt32(txtAddress.Text);
                Single fReadValue = 0;
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

                nResult = Module.MXP.PLC_ReadFloat(nAddress, out fReadValue);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("PLC ReadData = " + fReadValue.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnWriteDouble_Click(object sender, EventArgs e)
        {
            try
            {
                UInt32 nAddress = Convert.ToUInt32(txtAddress.Text);
                Double dSetValue = Convert.ToDouble(txtSetValue.Text);
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

                nResult = Module.MXP.PLC_WriteDouble(nAddress, dSetValue);

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

        private void btnReadDouble_Click(object sender, EventArgs e)
        {
            try
            {
                UInt32 nAddress = Convert.ToUInt32(txtAddress.Text);
                Double dReadValue = 0;
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

                nResult = Module.MXP.PLC_ReadDouble(nAddress, out dReadValue);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("PLC ReadData = " + dReadValue.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnWriteSByte_Click(object sender, EventArgs e)
        {
            try
            {
                UInt32 nAddress = Convert.ToUInt32(txtAddress.Text);
                SByte nSetValue = Convert.ToSByte(txtSetValue.Text);
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult = new MXP_EasyClass.MXP_FUNCTION_STATUS();

                nResult = Module.MXP.PLC_WriteSByte(nAddress, nSetValue);

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

        private void btnReadSByte_Click(object sender, EventArgs e)
        {
            try
            {
                UInt32 nAddress = Convert.ToUInt32(txtAddress.Text);
                SByte nReadValue = 0;
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

                nResult = Module.MXP.PLC_ReadSByte(nAddress, out nReadValue);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("PLC ReadData = " + nReadValue.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
