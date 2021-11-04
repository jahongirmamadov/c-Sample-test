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
    public partial class Form_PDO_ETParam : Form
    {
        public Form_PDO_ETParam()
        {
            InitializeComponent();
        }

        Form_Main frm1;

        public Form_PDO_ETParam(Form_Main _form)
        {
            InitializeComponent();
            frm1 = _form;
        }

        private void btnReadTxPDO_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nSlaveNo = Convert.ToUInt32(txtSlaveNo.Text);
                UInt16 nOffset = Convert.ToUInt16(txtOffset.Text);
                UInt16 nSize = Convert.ToUInt16(txtSize.Text);
                Byte[] arrReadValue;

                nResult = Module.MXP.ECAT_ReadPdoData(nSlaveNo, MXP_EasyClass.MXP_PDO_DIRECTION.e_ServoWrite, nOffset, nSize, out arrReadValue);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    String strData = "", strIntData = "";
                    strData = "Byte Format = ";
                    for (Int32 i = 0; i < nSize; i++)
                    {
                        strData = strData + arrReadValue[i].ToString() + "  ";
                    }
                    Array.Resize(ref arrReadValue, 4);
                    strIntData = "IntData = " + BitConverter.ToInt32(arrReadValue, 0).ToString();

                    MessageBox.Show(strData + "\n" + strIntData, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnReadRxPDO_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nSlaveNo = Convert.ToUInt32(txtSlaveNo.Text);
                UInt16 nOffset = Convert.ToUInt16(txtOffset.Text);
                UInt16 nSize = Convert.ToUInt16(txtSize.Text);
                Byte[] arrReadValue = new Byte[4];

                nResult = Module.MXP.ECAT_ReadPdoData(nSlaveNo, MXP_EasyClass.MXP_PDO_DIRECTION.e_MXPWrite, nOffset, nSize, out arrReadValue);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    String strData = "", strIntData = "";
                    strData = "Byte Format = ";

                    for (Int32 i = 0; i < nSize; i++)
                    {
                        strData = strData + arrReadValue[i].ToString() + "  ";
                    }
                    Array.Resize(ref arrReadValue, 4);
                    strIntData = "IntData = " + BitConverter.ToInt32(arrReadValue, 0).ToString();

                    MessageBox.Show(strData + "\n" + strIntData, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnSDOWrite_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt16 nAddress = Convert.ToUInt16(txtSDOAddress.Text, 16);
                UInt32 nSlaveNo = Convert.ToUInt32(txtSlaveNo.Text);
                UInt16 nSubIndex = Convert.ToUInt16(txtSubIndex.Text);
                UInt16 nSize = Convert.ToUInt16(txtSDOSize.Text);
                UInt32 nWriteValue = Convert.ToUInt32(txtSDOWriteData.Text);

                nResult = Module.MXP.ECAT_CoeWriteRequest(nSlaveNo, nAddress, nSubIndex, nSize, nWriteValue);

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

        private void btnSDOWriteCheck_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt16 nSlaveAxisNo = Convert.ToUInt16(txtSlaveNo.Text);
                MXP_EasyClass.PROCESS_CHECK stState = new MXP_EasyClass.PROCESS_CHECK();

                nResult = Module.MXP.ECAT_CoeWriteReply(nSlaveAxisNo, out stState);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    String strState = "";

                    if (stState.ErrorOn == true)
                        strState = "Error = " + stState.ErrorID.ToString();
                    else if (stState.Done == true)
                        strState = "Done";
                    else if (stState.Busy == true)
                        strState = "Active";

                    MessageBox.Show("COE Write Result = " + strState, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnSDORead_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt16 nAddress = Convert.ToUInt16(txtSDOAddress.Text, 16);
                UInt32 nSlaveNo = Convert.ToUInt32(txtSlaveNo.Text);
                UInt16 nSubIndex = Convert.ToUInt16(txtSubIndex.Text);
                UInt16 nSize = Convert.ToUInt16(txtSDOSize.Text);

                nResult = Module.MXP.ECAT_CoeReadRequest(nSlaveNo, nAddress, nSubIndex, nSize);

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

        private void btnSDOReadCheck_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nSlaveAxisNo = Convert.ToUInt32(txtSlaveNo.Text);
                MXP_EasyClass.READ_ETParameterReply stState = new MXP_EasyClass.READ_ETParameterReply();

                nResult = Module.MXP.ECAT_CoeReadReply(nSlaveAxisNo, out stState);

                Array.Resize(ref stState.ReadData, Convert.ToInt32(txtSDOSize.Text));

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    String strState = "";

                    if (stState.ErrorOn == true)
                        strState = "Error = " + stState.ErrorID.ToString();
                    else if (stState.Done == true)
                        strState = "Done";
                    else if (stState.Busy == true)
                        strState = "Active";

                    String strData = "", strIntData = "";
                    strData = "Byte Format = ";

                    for (Int32 i = 0; i < stState.ReadData.Length; i++)
                    {
                        strData = strData + Convert.ToString(stState.ReadData[i]) + "  ";
                    }

                    Array.Resize(ref stState.ReadData, 4);
                    strIntData = "IntData = " + BitConverter.ToInt32(stState.ReadData, 0).ToString();

                    MessageBox.Show("COE Read Result = " + strState + "\n" + strData + "\n" + strIntData, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnWriteRxPDO_Click(object sender, EventArgs e)
        {
            try
            {
                UInt32 nSlaveNo = Convert.ToUInt32(txtSlaveNo.Text);
                UInt16 nOffset = Convert.ToUInt16(txtOffset.Text);
                UInt16 nSize = Convert.ToUInt16(txtSize.Text);
                Byte[] arrWriteValue = BitConverter.GetBytes(Convert.ToInt32(txtWriteData.Text));
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;


                nResult = Module.MXP.ECAT_WrtiePdoData(nSlaveNo, nOffset, nSize, arrWriteValue);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("PDO Write Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnSDOWriteTimeWait_Click(object sender, EventArgs e)
        {
            try
            {
                UInt16 nAddress = Convert.ToUInt16(txtSDOAddress.Text, 16);
                UInt32 nSlaveAxisNo = Convert.ToUInt32(txtSlaveNo.Text);
                UInt16 nSubIndex = Convert.ToUInt16(txtSubIndex.Text);
                UInt16 nSize = Convert.ToUInt16(txtSDOSize.Text);
                UInt32 nWriteValue = Convert.ToUInt32(txtSDOWriteData.Text);
                Int32 nWaitTime = Convert.ToInt32(txtWaitTime.Text);
                MXP_EasyClass.PROCESS_CHECK stState;
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

                nResult = Module.MXP.ECAT_CoeWrite(nSlaveAxisNo, nAddress, nSubIndex, nSize, nWriteValue, nWaitTime, out stState);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    String strState = "";
                    if (stState.ErrorOn == true)
                        strState = "Error = " + stState.ErrorID.ToString();
                    else if (stState.Done == true)
                        strState = "Done";
                    else if (stState.Busy == true)
                        strState = "Active";

                    MessageBox.Show("COE Write Result = " + strState, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSDOReadTimeWait_Click(object sender, EventArgs e)
        {
            try
            {
                UInt16 nAddress = Convert.ToUInt16(txtSDOAddress.Text, 16);
                UInt32 nSlaveAxisNo = Convert.ToUInt32(txtSlaveNo.Text);
                UInt16 nSubIndex = Convert.ToUInt16(txtSubIndex.Text);
                UInt16 nSize = Convert.ToUInt16(txtSDOSize.Text);
                Int32 nWaitTime = Convert.ToInt32(txtWaitTime.Text);
                MXP_EasyClass.READ_ETParameterReply stState;
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

                nResult = Module.MXP.ECAT_CoeRead(nSlaveAxisNo, nAddress, nSubIndex, nSize, nWaitTime, out stState);

                Array.Resize(ref stState.ReadData, Convert.ToInt32(txtSDOSize.Text));

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    String strState = "";

                    if (stState.ErrorOn == true)
                        strState = "Error = " + stState.ErrorID.ToString();
                    else if (stState.Done == true)
                        strState = "Done";
                    else if (stState.Busy == true)
                        strState = "Active";

                    String strData = "", strIntData = "";
                    strData = "Byte Format = ";

                    for (Int32 i = 0; i < stState.ReadData.Length; i++)
                    {
                        strData = strData + Convert.ToString(stState.ReadData[i]) + "  ";
                    }

                    Array.Resize(ref stState.ReadData, 4);
                    strIntData = "IntData = " + BitConverter.ToInt32(stState.ReadData, 0).ToString();

                    MessageBox.Show("COE Read Result = " + strState + "\n" + strData + "\n" + strIntData, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReadPhysicalOutput_Click(object sender, EventArgs e)
        {
            try
            {
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNumber.Text);
                Byte[] arrReadValue = new Byte[4];
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

                nResult = Module.MXP.ECAT_ReadAxisIO(nAxisNo, out arrReadValue);

                if(nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    String strData, strIntData;
                    strData = "Byte Format = ";

                    for (int i = 0; i < arrReadValue.Length; i++)
                    {
                        strData = strData + arrReadValue[i].ToString() + "   ";
                    }

                    Array.Resize(ref arrReadValue, 4);

                    strIntData = "IntData = " + BitConverter.ToUInt32(arrReadValue, 0).ToString();

                    MessageBox.Show(strData + "\t" + strIntData, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnWritePhysicalOutput_Click(object sender, EventArgs e)
        {
            try
            {
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNumber.Text);
                Byte[] arrWriteValue = BitConverter.GetBytes(Convert.ToUInt32(txtAxisWriteData.Text));
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

                nResult = Module.MXP.ECAT_WriteAxisIO(nAxisNo, arrWriteValue);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("PDO Write Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
