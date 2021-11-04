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
    public partial class Form_MultiCCC : Form
    {
        public Form_MultiCCC()
        {
            InitializeComponent();
        }

        Form_Main frm1;

        public Form_MultiCCC(Form_Main _form)
        {
            InitializeComponent();
            frm1 = _form;            
        }

        private UInt32[] arrAxisArray = new UInt32[10];
        private Single fMultiControlKffGain = 0;

        private void btnCom_Click(object sender, EventArgs e)
        {
            arrAxisArray[0] = Convert.ToUInt32(txtAxis0.Text);
            arrAxisArray[1] = Convert.ToUInt32(txtAxis1.Text);
            arrAxisArray[2] = Convert.ToUInt32(txtAxis2.Text);
            arrAxisArray[3] = Convert.ToUInt32(txtAxis3.Text);
            arrAxisArray[4] = Convert.ToUInt32(txtAxis4.Text);
            arrAxisArray[5] = Convert.ToUInt32(txtAxis5.Text);
            arrAxisArray[6] = Convert.ToUInt32(txtAxis6.Text);
            arrAxisArray[7] = Convert.ToUInt32(txtAxis7.Text);
            arrAxisArray[8] = Convert.ToUInt32(txtAxis8.Text);
            arrAxisArray[9] = Convert.ToUInt32(txtAxis9.Text);

            Form_Main.COM.FormShow(Convert.ToInt32(txtAxisCount.Text), arrAxisArray);
        }

        private void btnCCCSet_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt16 nAxisCount = Convert.ToUInt16(txtAxisCount.Text);
                UInt16 nMode = Convert.ToUInt16(txtMode.Text);

                arrAxisArray[0] = Convert.ToUInt32(txtAxis0.Text);
                arrAxisArray[1] = Convert.ToUInt32(txtAxis1.Text);
                arrAxisArray[2] = Convert.ToUInt32(txtAxis2.Text);
                arrAxisArray[3] = Convert.ToUInt32(txtAxis3.Text);
                arrAxisArray[4] = Convert.ToUInt32(txtAxis4.Text);
                arrAxisArray[5] = Convert.ToUInt32(txtAxis5.Text);
                arrAxisArray[6] = Convert.ToUInt32(txtAxis6.Text);
                arrAxisArray[7] = Convert.ToUInt32(txtAxis7.Text);
                arrAxisArray[8] = Convert.ToUInt32(txtAxis8.Text);
                arrAxisArray[9] = Convert.ToUInt32(txtAxis9.Text);

                nResult = Module.MXP.AX_MultiAxisCCCSet(nAxisCount, arrAxisArray, nMode);

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

        private void btnCCCSetCheck_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt16 nAxisCount = Convert.ToUInt16(txtAxisCount.Text);
                MXP_EasyClass.PROCESS_CHECK stState;

                arrAxisArray[0] = Convert.ToUInt32(txtAxis0.Text);
                arrAxisArray[1] = Convert.ToUInt32(txtAxis1.Text);
                arrAxisArray[2] = Convert.ToUInt32(txtAxis2.Text);
                arrAxisArray[3] = Convert.ToUInt32(txtAxis3.Text);
                arrAxisArray[4] = Convert.ToUInt32(txtAxis4.Text);
                arrAxisArray[5] = Convert.ToUInt32(txtAxis5.Text);
                arrAxisArray[6] = Convert.ToUInt32(txtAxis6.Text);
                arrAxisArray[7] = Convert.ToUInt32(txtAxis7.Text);
                arrAxisArray[8] = Convert.ToUInt32(txtAxis8.Text);
                arrAxisArray[9] = Convert.ToUInt32(txtAxis9.Text);

                nResult = Module.MXP.AX_MultiAxisCCCSetCheck(nAxisCount, arrAxisArray, out stState);

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

                    MessageBox.Show("CCC Set = " + strState, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCCCReset_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt16 nAxisCount = Convert.ToUInt16(txtAxisCount.Text);

                arrAxisArray[0] = Convert.ToUInt32(txtAxis0.Text);
                arrAxisArray[1] = Convert.ToUInt32(txtAxis1.Text);
                arrAxisArray[2] = Convert.ToUInt32(txtAxis2.Text);
                arrAxisArray[3] = Convert.ToUInt32(txtAxis3.Text);
                arrAxisArray[4] = Convert.ToUInt32(txtAxis4.Text);
                arrAxisArray[5] = Convert.ToUInt32(txtAxis5.Text);
                arrAxisArray[6] = Convert.ToUInt32(txtAxis6.Text);
                arrAxisArray[7] = Convert.ToUInt32(txtAxis7.Text);
                arrAxisArray[8] = Convert.ToUInt32(txtAxis8.Text);
                arrAxisArray[9] = Convert.ToUInt32(txtAxis9.Text);

                nResult = Module.MXP.AX_MultiAxisCCCReset(nAxisCount, arrAxisArray);

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

        private void btnCCCResetCheck_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt16 nAxisCount = Convert.ToUInt16(txtAxisCount.Text);
                MXP_EasyClass.PROCESS_CHECK stState;

                arrAxisArray[0] = Convert.ToUInt32(txtAxis0.Text);
                arrAxisArray[1] = Convert.ToUInt32(txtAxis1.Text);
                arrAxisArray[2] = Convert.ToUInt32(txtAxis2.Text);
                arrAxisArray[3] = Convert.ToUInt32(txtAxis3.Text);
                arrAxisArray[4] = Convert.ToUInt32(txtAxis4.Text);
                arrAxisArray[5] = Convert.ToUInt32(txtAxis5.Text);
                arrAxisArray[6] = Convert.ToUInt32(txtAxis6.Text);
                arrAxisArray[7] = Convert.ToUInt32(txtAxis7.Text);
                arrAxisArray[8] = Convert.ToUInt32(txtAxis8.Text);
                arrAxisArray[9] = Convert.ToUInt32(txtAxis9.Text);

                nResult = Module.MXP.AX_MultiAxisCCCResetCheck(nAxisCount, arrAxisArray, out stState);

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

                    MessageBox.Show("CCC Reset = " + strState, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private MXP_EasyClass.MXP_MULTIAXISCOUPLE_SINGLEAXISGAIN[] arrSingleGain = new MXP_EasyClass.MXP_MULTIAXISCOUPLE_SINGLEAXISGAIN[10];
        private MXP_EasyClass.MXP_MULTIAXISCOUPLE_CCCGAIN[] arrCCCGain = new MXP_EasyClass.MXP_MULTIAXISCOUPLE_CCCGAIN[10];

        private void btnGainSet_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt16 mMultiContolKffGain = Convert.ToUInt16(txtWKff.Text);
                UInt16 nAxisCount = Convert.ToUInt16(txtAxisCount.Text);

                arrAxisArray[0] = Convert.ToUInt32(txtAxis0.Text);
                arrAxisArray[1] = Convert.ToUInt32(txtAxis1.Text);
                arrAxisArray[2] = Convert.ToUInt32(txtAxis2.Text);
                arrAxisArray[3] = Convert.ToUInt32(txtAxis3.Text);
                arrAxisArray[4] = Convert.ToUInt32(txtAxis4.Text);
                arrAxisArray[5] = Convert.ToUInt32(txtAxis5.Text);
                arrAxisArray[6] = Convert.ToUInt32(txtAxis6.Text);
                arrAxisArray[7] = Convert.ToUInt32(txtAxis7.Text);
                arrAxisArray[8] = Convert.ToUInt32(txtAxis8.Text);
                arrAxisArray[9] = Convert.ToUInt32(txtAxis9.Text);

                if (CCCGainRead())
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (CheckAxis.GetItemChecked(i))
                        {
                            arrSingleGain[i].strData.P_Gain = Convert.ToUInt16(txtP.Text);
                            arrSingleGain[i].strData.I_Gain = Convert.ToUInt16(txtI.Text);
                            arrSingleGain[i].strData.D_Gain = Convert.ToUInt16(txtD.Text);
                            arrSingleGain[i].strData.FeedForward_A_Gain = Convert.ToUInt16(txtAccFF.Text);
                            arrSingleGain[i].strData.FeedForward_V_Gain = Convert.ToUInt16(txtVelFF.Text);

                            arrCCCGain[i].strData.CCC_Wi = Convert.ToUInt16(txtWi.Text);
                            arrCCCGain[i].strData.CCC_Wp = Convert.ToUInt16(txtWp.Text);
                        }
                    }

                    nResult = Module.MXP.AX_MultiAxisCCCGainSet(nAxisCount, arrAxisArray, arrSingleGain, arrCCCGain, mMultiContolKffGain);

                    if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                        MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("MXP Cmd Set Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                    MessageBox.Show("CCC Gain Read Fail", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Boolean CCCGainRead()
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult = MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR;
                UInt16 mMultiControlKffGain = Convert.ToUInt16(txtWKff.Text);
                UInt16 nAxisCount = Convert.ToUInt16(txtAxisCount.Text);

                arrAxisArray[0] = Convert.ToUInt32(txtAxis0.Text);
                arrAxisArray[1] = Convert.ToUInt32(txtAxis1.Text);
                arrAxisArray[2] = Convert.ToUInt32(txtAxis2.Text);
                arrAxisArray[3] = Convert.ToUInt32(txtAxis3.Text);
                arrAxisArray[4] = Convert.ToUInt32(txtAxis4.Text);
                arrAxisArray[5] = Convert.ToUInt32(txtAxis5.Text);
                arrAxisArray[6] = Convert.ToUInt32(txtAxis6.Text);
                arrAxisArray[7] = Convert.ToUInt32(txtAxis7.Text);
                arrAxisArray[8] = Convert.ToUInt32(txtAxis8.Text);
                arrAxisArray[9] = Convert.ToUInt32(txtAxis9.Text);

                for (int i = 0; i < nAxisCount; i++)
                {
                    Single fParameterValue = 0;

                    nResult = Module.MXP.AX_ReadParameter(arrAxisArray[i], 504, out fParameterValue);
                    if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR) return false;
                    arrSingleGain[i].strData.FeedForward_V_Gain = Convert.ToUInt16(fParameterValue);

                    nResult = Module.MXP.AX_ReadParameter(arrAxisArray[i], 506, out fParameterValue);
                    if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR) return false;
                    arrSingleGain[i].strData.FeedForward_A_Gain = Convert.ToUInt16(fParameterValue);

                    nResult = Module.MXP.AX_ReadParameter(arrAxisArray[i], 500, out fParameterValue);
                    if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR) return false;
                    arrSingleGain[i].strData.P_Gain = Convert.ToUInt16(fParameterValue);

                    nResult = Module.MXP.AX_ReadParameter(arrAxisArray[i], 508, out fParameterValue);
                    if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR) return false;
                    arrSingleGain[i].strData.I_Gain = Convert.ToUInt16(fParameterValue);

                    nResult = Module.MXP.AX_ReadParameter(arrAxisArray[i], 509, out fParameterValue);
                    if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR) return false;
                    arrSingleGain[i].strData.D_Gain = Convert.ToUInt16(fParameterValue);

                    nResult = Module.MXP.AX_ReadParameter(arrAxisArray[i], 517, out fParameterValue);
                    if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR) return false;
                    arrCCCGain[i].strData.CCC_Wp = Convert.ToUInt16(fParameterValue);

                    nResult = Module.MXP.AX_ReadParameter(arrAxisArray[i], 518, out fParameterValue);
                    if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR) return false;
                    arrCCCGain[i].strData.CCC_Wi = Convert.ToUInt16(fParameterValue);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return false;
            }
        }

        private void btnGainSetCheck_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt16 nAxisCount = Convert.ToUInt16(txtAxisCount.Text);
                MXP_EasyClass.PROCESS_CHECK stState;

                arrAxisArray[0] = Convert.ToUInt32(txtAxis0.Text);
                arrAxisArray[1] = Convert.ToUInt32(txtAxis1.Text);
                arrAxisArray[2] = Convert.ToUInt32(txtAxis2.Text);
                arrAxisArray[3] = Convert.ToUInt32(txtAxis3.Text);
                arrAxisArray[4] = Convert.ToUInt32(txtAxis4.Text);
                arrAxisArray[5] = Convert.ToUInt32(txtAxis5.Text);
                arrAxisArray[6] = Convert.ToUInt32(txtAxis6.Text);
                arrAxisArray[7] = Convert.ToUInt32(txtAxis7.Text);
                arrAxisArray[8] = Convert.ToUInt32(txtAxis8.Text);
                arrAxisArray[9] = Convert.ToUInt32(txtAxis9.Text);

                nResult = Module.MXP.AX_MultiAxisCCCGainSetCheck(nAxisCount, arrAxisArray, out stState);

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

                    MessageBox.Show("Gain Set = " + strState, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAllSet_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CheckAxis.Items.Count ; i++ )
            {
                CheckAxis.SetItemCheckState(i, CheckState.Checked);
            }
        }

        private void btn_AllReset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CheckAxis.Items.Count; i++)
            {
                CheckAxis.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void btnCCCGainSet_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt16 mMultiContolKffGain = Convert.ToUInt16(txtWKff.Text);
                UInt16 nAxisCount = Convert.ToUInt16(txtAxisCount.Text);

                arrAxisArray[0] = Convert.ToUInt32(txtAxis0.Text);
                arrAxisArray[1] = Convert.ToUInt32(txtAxis1.Text);
                arrAxisArray[2] = Convert.ToUInt32(txtAxis2.Text);
                arrAxisArray[3] = Convert.ToUInt32(txtAxis3.Text);
                arrAxisArray[4] = Convert.ToUInt32(txtAxis4.Text);
                arrAxisArray[5] = Convert.ToUInt32(txtAxis5.Text);
                arrAxisArray[6] = Convert.ToUInt32(txtAxis6.Text);
                arrAxisArray[7] = Convert.ToUInt32(txtAxis7.Text);
                arrAxisArray[8] = Convert.ToUInt32(txtAxis8.Text);
                arrAxisArray[9] = Convert.ToUInt32(txtAxis9.Text);

                if (CCCGainRead())
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (CheckAxis.GetItemChecked(i))
                        {
                            arrCCCGain[i].strData.CCC_Wi = Convert.ToUInt16(txtWi.Text);
                            arrCCCGain[i].strData.CCC_Wp = Convert.ToUInt16(txtWp.Text);
                        }
                    }

                    nResult = Module.MXP.AX_MultiAxisCCCGainSet(nAxisCount, arrAxisArray, arrSingleGain, arrCCCGain, mMultiContolKffGain);

                    if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                        MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("MXP Cmd Set Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                    MessageBox.Show("CCC Gain Read Fail", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);                

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btgnAxisGainLoad_Click(object sender, EventArgs e)
        {
            try
            {
                UInt16 mMultiContolKffGain = Convert.ToUInt16(txtWKff.Text);
                UInt16 nAxisCount = Convert.ToUInt16(txtAxisCount.Text);

                arrAxisArray[0] = Convert.ToUInt32(txtAxis0.Text);
                arrAxisArray[1] = Convert.ToUInt32(txtAxis1.Text);
                arrAxisArray[2] = Convert.ToUInt32(txtAxis2.Text);
                arrAxisArray[3] = Convert.ToUInt32(txtAxis3.Text);
                arrAxisArray[4] = Convert.ToUInt32(txtAxis4.Text);
                arrAxisArray[5] = Convert.ToUInt32(txtAxis5.Text);
                arrAxisArray[6] = Convert.ToUInt32(txtAxis6.Text);
                arrAxisArray[7] = Convert.ToUInt32(txtAxis7.Text);
                arrAxisArray[8] = Convert.ToUInt32(txtAxis8.Text);
                arrAxisArray[9] = Convert.ToUInt32(txtAxis9.Text);

                if (CCCGainRead())
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (CheckAxis.GetItemChecked(i))
                        {
                            txtP.Text = arrSingleGain[i].strData.P_Gain.ToString();
                            txtI.Text = arrSingleGain[i].strData.I_Gain.ToString();
                            txtD.Text = arrSingleGain[i].strData.D_Gain.ToString();
                            txtAccFF.Text = arrSingleGain[i].strData.FeedForward_A_Gain.ToString();
                            txtVelFF.Text = arrSingleGain[i].strData.FeedForward_V_Gain.ToString();

                            txtWi.Text = arrCCCGain[i].strData.CCC_Wi.ToString();
                            txtWp.Text = arrCCCGain[i].strData.CCC_Wp.ToString();

                            MessageBox.Show("MXP Cmd Set Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                }
                else
                    MessageBox.Show("Gain Read Fail", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
