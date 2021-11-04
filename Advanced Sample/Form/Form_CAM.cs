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
    public partial class Form_CAM : Form
    {
        public Form_CAM()
        {
            InitializeComponent();
        }

        Form_Main frm1;

        public Form_CAM(Form_Main _form)
        {
            InitializeComponent();
            frm1 = _form;            
        }

        private void btnWriteCAMTable_Click(object sender, EventArgs e)
        {
            try
            {
                UInt16 nCamID = Convert.ToUInt16(txtCamID.Text);
                MXP_EasyClass.MXP_CAMTABLE_REF[] arrCAMTable = new MXP_EasyClass.MXP_CAMTABLE_REF[3];
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

                arrCAMTable[0].stData.MasterPos = 0;
                arrCAMTable[0].stData.SlavePos = 0;
                arrCAMTable[0].stData.InterpolationType = Convert.ToInt32(txtInterpolation1.Text); ;

                arrCAMTable[1].stData.MasterPos = Convert.ToSingle(txtMasterPos1.Text);
                arrCAMTable[1].stData.SlavePos = Convert.ToSingle(txtSlavePos1.Text);
                arrCAMTable[1].stData.InterpolationType = Convert.ToInt32(txtInterpolation2.Text);

                arrCAMTable[2].stData.MasterPos = Convert.ToSingle(txtMasterPos2.Text);
                arrCAMTable[2].stData.SlavePos = Convert.ToSingle(txtSlavePos2.Text);
                arrCAMTable[2].stData.InterpolationType = 0;

                nResult = Module.MXP.AX_CamWriteTableRequest(nCamID, true, 3, arrCAMTable);

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

        private void btnWrtieCamTableCheck_Click(object sender, EventArgs e)
        {
            try
            {
                UInt16 nCamID = Convert.ToUInt16(txtCamID.Text);
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                MXP_EasyClass.PROCESS_CHECK stState = new MXP_EasyClass.PROCESS_CHECK();

                nResult = Module.MXP.AX_CamWriteTableReply(nCamID, out stState);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    String strState = "";

                    if (stState.ErrorOn == true)
                    {
                        MXP_EasyClass.MXP_CAM_STATUS nCAMError = (MXP_EasyClass.MXP_CAM_STATUS)stState.ErrorID;
                        strState = "Error = " + nCAMError.ToString();
                    }
                    else if (stState.Done == true)
                        strState = "Done";
                    else if (stState.Busy == true)
                        strState = "Active";

                    MessageBox.Show("CamTable Write Result = " + strState, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnWriteCAMTableReset_Click(object sender, EventArgs e)
        {
            try
            {
                UInt16 nCamID = Convert.ToUInt16(txtCamID.Text);
                MXP_EasyClass.MXP_CAMTABLE_REF[] arrCAMTable = new MXP_EasyClass.MXP_CAMTABLE_REF[1];
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

                nResult = Module.MXP.AX_CamWriteTableRequest(nCamID, false, 1, arrCAMTable);

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

        private void btnCamTableSelect_Click(object sender, EventArgs e)
        {
            try
            {
                UInt32 nMasterAxisNo = Convert.ToUInt32(txtMasterAxisNo.Text);
                UInt32 nSlaveAxisNo = Convert.ToUInt32(txtSlaveAxisNo.Text);
                UInt16 nCamID = Convert.ToUInt16(txtCamID.Text);
                Boolean bPeriodic = (Convert.ToInt32(txtPeriodic.Text) == 0 ? false : true);
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

                nResult = Module.MXP.AX_CamTableSelect(nMasterAxisNo, nSlaveAxisNo, nCamID, bPeriodic);

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

        private void btnCAMIn_Click(object sender, EventArgs e)
        {
            try
            {
                UInt32 nMasterAxisNo = Convert.ToUInt32(txtMasterAxisNo.Text);
                UInt32 nSlaveAxisNo = Convert.ToUInt32(txtSlaveAxisNo.Text);
                UInt16 nCamID = Convert.ToUInt16(txtCamID.Text);
                Single fMasterOffset = Convert.ToSingle(txtMasterOffset.Text);
                Single fSlaveOffset = Convert.ToSingle(txtSlaveOffset.Text);
                Single fMasterScaling = Convert.ToSingle(txtMasterScailing.Text);
                Single fSlaveScaling = Convert.ToSingle(txtSlaveScailing.Text);
                Single fMasterSyncPos = Convert.ToSingle(txtMasterSyncPosition.Text);
                Single fMasterStartDistance = Convert.ToSingle(txtMasterStartDistance.Text);
                MXP_EasyClass.MXP_STARTMODE_ENUM nStartMode = (MXP_EasyClass.MXP_STARTMODE_ENUM)Convert.ToInt32(txtStartMode.Text);
                MXP_EasyClass.MXP_SOURCE_ENUM nMasterSource = (MXP_EasyClass.MXP_SOURCE_ENUM)Convert.ToInt32(txtMasterSource.Text);
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

                nResult = Module.MXP.AX_CamIn(nMasterAxisNo, nSlaveAxisNo, fMasterOffset, fSlaveOffset, fMasterScaling, fSlaveScaling, fMasterSyncPos,
                    fMasterStartDistance, nStartMode, nMasterSource, nCamID);

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

        private void btnCAMInCheck_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nSlaveAxisNo = Convert.ToUInt32(txtSlaveAxisNo.Text);
                MXP_EasyClass.PROCESS_CHECK stState = new MXP_EasyClass.PROCESS_CHECK();

                nResult = Module.MXP.AX_CamInMonitor(nSlaveAxisNo, out stState);

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

                    MessageBox.Show("CamTable In Result = " + strState, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
                
        }

        private void btnCAMOut_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nSlaveAxisNo = Convert.ToUInt32(txtSlaveAxisNo.Text);

                nResult = Module.MXP.AX_CamOut(nSlaveAxisNo);

                nResult = Module.MXP.AX_Stop(nSlaveAxisNo, true, 1000, 1000);
                nResult = Module.MXP.AX_Stop(nSlaveAxisNo, false, 1000, 1000);

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

        private void btnReadCamTable_Click(object sender, EventArgs e)
        {
            try
            {
                UInt16 nCamID = Convert.ToUInt16(txtCamID.Text);
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

                nResult = Module.MXP.AX_CamReadTableRequest(nCamID, true);

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

        private void btnReadCamTableCheck_Click(object sender, EventArgs e)
        {
            try
            {
                UInt16 nCamID = Convert.ToUInt16(txtCamID.Text);
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                MXP_EasyClass.READ_CAMTABLE_REPLY stState = new MXP_EasyClass.READ_CAMTABLE_REPLY();

                nResult = Module.MXP.AX_CamReadTableReply(nCamID, out stState);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    String strState = "";

                    if (stState.ErrorOn == true)
                    {
                        MXP_EasyClass.MXP_CAM_STATUS nCAMError = (MXP_EasyClass.MXP_CAM_STATUS)stState.ErrorID;
                        strState = "Error = " + nCAMError.ToString();
                    }
                    else if (stState.Done == true)
                        strState = "Done    CamTableCount = " + stState.TableRowCount.ToString();
                    else if (stState.Busy == true)
                        strState = "Active";

                    Int32 nCount = 0;
                    for (nCount = 0; nCount < stState.TableRowCount; nCount++)
                    {
                        strState = strState + "\nstep" + nCount.ToString() + "   "
                            + stState.arrCamData[nCount].stData.MasterPos.ToString() + ", " + stState.arrCamData[nCount].stData.SlavePos.ToString();
                    }

                    MessageBox.Show("CamTable Count = " + strState, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }               
        }

        private void btnReadCamTableReset_Click(object sender, EventArgs e)
        {
            try
            {
                UInt16 nCamID = Convert.ToUInt16(txtCamID.Text);
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

                nResult = Module.MXP.AX_CamReadTableRequest(nCamID, false);

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

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                UInt32[] arrAxis = new UInt32[2];
                arrAxis[0] = Convert.ToUInt32(txtMasterAxisNo.Text);
                arrAxis[1] = Convert.ToUInt32(txtSlaveAxisNo.Text);

                Form_Main.COM.FormShow(2, arrAxis);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }

        private void btnMasterPhasing_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nMasterAxisNo = Convert.ToUInt32(txtMasterAxisNo.Text);
                UInt32 nSlaveAxisNo = Convert.ToUInt32(txtSlaveAxisNo.Text);
                Single fShiftDistance = Convert.ToSingle(txtMasterPhasingDistance.Text);

                nResult = Module.MXP.AX_Phasing(nMasterAxisNo, nSlaveAxisNo, fShiftDistance);

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

        private void btnScailing_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nMasterAxisNo = Convert.ToUInt32(txtMasterAxisNo.Text);
                UInt32 nSlaveAxisNo = Convert.ToUInt32(txtSlaveAxisNo.Text);
                MXP_EasyClass.MXP_ACTIVATIONMODE nActivationMode = (MXP_EasyClass.MXP_ACTIVATIONMODE)Convert.ToInt32(txtActivationMode.Text);
                Single fActivationPosition = Convert.ToSingle(txtActivationPosition.Text);
                Single fMasterScaling = Convert.ToSingle(txtMasterScailing2.Text);
                Single fSlaveScaling = Convert.ToSingle(txtSlaveScailing2.Text);

                nResult = Module.MXP.AX_CamScaling(nMasterAxisNo, nSlaveAxisNo, nActivationMode, fActivationPosition, fMasterScaling, fSlaveScaling);

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

        private void btnReadCamSlavePosition_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt16 nCamID = Convert.ToUInt16(txtCamID.Text);
                Single fMasterPosition = Convert.ToSingle(txtMasterPosition.Text);

                nResult = Module.MXP.AX_CamReadSlavePositionRequest(nCamID, true, fMasterPosition);

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

        private void btnReadCamSlavePositionCheck_Click(object sender, EventArgs e)
        {
            try
            {
                UInt16 nCamID = Convert.ToUInt16(txtCamID.Text);
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                MXP_EasyClass.READ_CAMSLAVEPOSITION_REPLY stState = new MXP_EasyClass.READ_CAMSLAVEPOSITION_REPLY();

                nResult = Module.MXP.AX_CamReadSlavePositionReply(nCamID, out stState);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    String strState = "";

                    if (stState.ErrorOn == true)
                        strState = "Error = " + stState.ErrorID.ToString();
                    else if (stState.Done == true)
                        strState = "Done   Slave Pos = " + stState.SlavePos.ToString();
                    else if (stState.Busy == true)
                        strState = "Active";

                    MessageBox.Show("CamTable ReadSlave Result = " + strState, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnReadCamSlavePositionReset_Click(object sender, EventArgs e)
        {
            try
            {
                UInt16 nCamID = Convert.ToUInt16(txtCamID.Text);
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                Single fMasterPosition = Convert.ToSingle(txtMasterPosition.Text);

                nResult = Module.MXP.AX_CamReadSlavePositionRequest(nCamID, false, fMasterPosition);

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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnWriteCAMTableWaitTime_Click(object sender, EventArgs e)
        {
            try
            {
                UInt16 nCamID = Convert.ToUInt16(txtCamID.Text);
                MXP_EasyClass.MXP_CAMTABLE_REF[] arrCAMTable = new MXP_EasyClass.MXP_CAMTABLE_REF[3];
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                MXP_EasyClass.PROCESS_CHECK stState;
                Int32 nWaitTime = Convert.ToInt32(txtWaitTime.Text);

                arrCAMTable[0].stData.MasterPos = 0;
                arrCAMTable[0].stData.SlavePos = 0;
                arrCAMTable[0].stData.InterpolationType = Convert.ToInt32(txtInterpolation1.Text);

                arrCAMTable[1].stData.MasterPos = Convert.ToSingle(txtMasterPos1.Text);
                arrCAMTable[1].stData.SlavePos = Convert.ToSingle(txtSlavePos1.Text);
                arrCAMTable[1].stData.InterpolationType = Convert.ToInt32(txtInterpolation2.Text);

                arrCAMTable[2].stData.MasterPos = Convert.ToSingle(txtMasterPos2.Text);
                arrCAMTable[2].stData.SlavePos = Convert.ToSingle(txtSlavePos2.Text);
                arrCAMTable[2].stData.InterpolationType = 0;

                nResult = Module.MXP.AX_CamWriteTable(nCamID, 3, arrCAMTable, nWaitTime, out stState);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    String strState = "";

                    if (stState.ErrorOn == true)
                    {
                        MXP_EasyClass.MXP_CAM_STATUS nCAMError = (MXP_EasyClass.MXP_CAM_STATUS)stState.ErrorID;
                        strState = "Error = " + nCAMError.ToString();
                    }
                    else if (stState.Done == true)
                        strState = "Done";
                    else if (stState.Busy == true)
                        strState = "Active";

                    MessageBox.Show("CamTable Write Result = " + strState, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnReadCamTableWaitTime_Click(object sender, EventArgs e)
        {
            try
            {
                UInt16 nCamID = Convert.ToUInt16(txtCamID.Text);
                Int32 nWaitTime = Convert.ToInt32(txtWaitTime.Text);
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                MXP_EasyClass.READ_CAMTABLE_REPLY stState;

                nResult = Module.MXP.AX_CamReadTable(nCamID, nWaitTime, out stState);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    String strState = "";

                    if (stState.ErrorOn == true)
                    {
                        MXP_EasyClass.MXP_CAM_STATUS nCAMError = (MXP_EasyClass.MXP_CAM_STATUS)stState.ErrorID;
                        strState = "Error = " + nCAMError.ToString();
                    }
                    else if (stState.Done == true)
                        strState = "Done    CamTableCount = " + stState.TableRowCount.ToString();
                    else if (stState.Busy == true)
                        strState = "Active";

                    Int32 nCount = 0;
                    for (nCount = 0; nCount < stState.TableRowCount; nCount++)
                    {
                        strState = strState + "\nstep" + nCount.ToString() + "   " + stState.arrCamData[nCount].stData.MasterPos.ToString()
                            + ", " + stState.arrCamData[nCount].stData.SlavePos.ToString();
                    }

                    MessageBox.Show("CamTable Count = " + strState, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReadCamSlavePositionWaitTime_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt16 nCamID = Convert.ToUInt16(txtCamID.Text);
                Single fMasterPosition = Convert.ToSingle(txtMasterPosition.Text);
                MXP_EasyClass.READ_CAMSLAVEPOSITION_REPLY stState;
                Int32 nWaitTime = Convert.ToInt32(txtWaitTime.Text);

                nResult = Module.MXP.AX_CamReadSlavePosition(nCamID, fMasterPosition, nWaitTime, out stState);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    String strState = "";

                    if (stState.ErrorOn == true)
                        strState = "Error = " + stState.ErrorID.ToString();
                    else if (stState.Done == true)
                        strState = "Done   Slave Pos = = " + stState.SlavePos.ToString();
                    else if (stState.Busy == true)
                        strState = "Active";

                    MessageBox.Show("CamTable ReadSlave Result = " + strState, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCAMInEx_Click(object sender, EventArgs e)
        {
            try
            {
                UInt32 nSlaveAxisNo = Convert.ToUInt32(txtSlaveAxisNo.Text);
                UInt16 nCamID = Convert.ToUInt16(txtCamID.Text);
                Single fMasterOffset = Convert.ToSingle(txtMasterOffset.Text);
                Single fSlaveOffset = Convert.ToSingle(txtSlaveOffset.Text);
                Single fMasterScaling = Convert.ToSingle(txtMasterScailing.Text);
                Single fSlaveScaling = Convert.ToSingle(txtSlaveScailing.Text);
                Single fMasterSyncPos = Convert.ToSingle(txtMasterSyncPosition.Text);
                Single fMasterStartDistance = Convert.ToSingle(txtMasterStartDistance.Text);
                MXP_EasyClass.MXP_STARTMODE_ENUM nStartMode = (MXP_EasyClass.MXP_STARTMODE_ENUM)Convert.ToInt32(txtStartMode.Text);
                MXP_EasyClass.MXP_SOURCE_ENUM nMasterSource = (MXP_EasyClass.MXP_SOURCE_ENUM)Convert.ToInt32(txtMasterSource.Text);
                UInt32 nSlaveNo = Convert.ToUInt32(txtExternal_SlaveNo.Text);
                UInt32 nSlavePos = Convert.ToUInt32(txtExternal_SlavePos.Text);
                Byte nSlaveSize = Convert.ToByte(txtExternal_SlaveSize.Text);
                UInt32 nResolution = Convert.ToUInt32(txtExternal_Resolution.Text);
                Single fPulseToUnit = Convert.ToSingle(txtExternal_Unit.Text);

                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

                nResult = Module.MXP.AX_CamIn_MasterIO(nSlaveNo, nSlavePos, nSlaveSize, nResolution, fPulseToUnit, nSlaveAxisNo, fMasterOffset, fSlaveOffset, fMasterScaling,
                                    fSlaveScaling, fMasterSyncPos, fMasterStartDistance, nStartMode, nMasterSource, nCamID);

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
    }
}
