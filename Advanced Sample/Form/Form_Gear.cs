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
    public partial class Form_Gear : Form
    {
        public Form_Gear()
        {
            InitializeComponent();
        }

        Form_Main frm1;

        public Form_Gear(Form_Main _form)
        {
            InitializeComponent();
            frm1 = _form;            
        }

        private void btnGearIn_Click(object sender, EventArgs e)
        {
            try
            {
                UInt32 nMasterAxisNo = Convert.ToUInt32(txtMasterAxisNo.Text);
                UInt32 nSlaveAxisNo = Convert.ToUInt32(txtSlaveAxisNo.Text);
                Int32 nNumeratorRatio = Convert.ToInt32(txtNumeratorRatio.Text);
                UInt32 nDenomiratorRatio = Convert.ToUInt32(txtDenomiratorRatio.Text);
                MXP_EasyClass.MXP_SOURCE_ENUM nMasterSource = (MXP_EasyClass.MXP_SOURCE_ENUM)Convert.ToInt32(txtMasterSource.Text);

                Single fAcc = Convert.ToSingle(txtAcc.Text);
                Single fDec = Convert.ToSingle(txtDec.Text);
                Single fJerk = Convert.ToSingle(txtJerk.Text);

                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

                nResult = Module.MXP.AX_GearIn(nMasterAxisNo, nSlaveAxisNo, nNumeratorRatio, nDenomiratorRatio, nMasterSource, fAcc, fDec, fJerk);

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

        private void btnGearOut_Click(object sender, EventArgs e)
        {
            try
            {
                UInt32 nSlaveAxisNo = Convert.ToUInt32(txtSlaveAxisNo.Text);
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

                nResult = Module.MXP.AX_GearOut(nSlaveAxisNo);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    nResult = Module.MXP.AX_Stop(nSlaveAxisNo, true, 1000, 1000);
                    nResult = Module.MXP.AX_Stop(nSlaveAxisNo, false, 1000, 1000);

                    if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                        MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("MXP Cmd Set Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
                
        }

        private void btnGearInCheck_Click(object sender, EventArgs e)
        {
            try
            {
                UInt32 nSlaveAxisNo = Convert.ToUInt32(txtSlaveAxisNo.Text);
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                MXP_EasyClass.PROCESS_CHECK stState;

                nResult = Module.MXP.AX_GearInMonitor(nSlaveAxisNo, out stState);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    String strState = "";

                    if (stState.ErrorOn == true)
                        strState = "Error = " + stState.ErrorID.ToString();
                    else if (stState.Done == true)
                        strState = "GearIn";
                    else if (stState.Busy == true)
                        strState = "Active";

                    MessageBox.Show("GearInState = " + strState, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
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

        private void btnGearInpos_Click(object sender, EventArgs e)
        {
            try
            {
                UInt32 nMasterAxisNo = Convert.ToUInt32(txtMasterAxisNo.Text);
                UInt32 nSlaveAxisNo = Convert.ToUInt32(txtSlaveAxisNo.Text);
                Int32 nNumeratorRatio = Convert.ToInt32(txtNumeratorRatio.Text);
                UInt32 nDenomiratorRatio = Convert.ToUInt32(txtDenomiratorRatio.Text);
                MXP_EasyClass.MXP_SOURCE_ENUM nMasterSource = (MXP_EasyClass.MXP_SOURCE_ENUM)Convert.ToInt32(txtMasterSource.Text);
                Single fMasterStartDist = Convert.ToSingle(txtMasterStartDist.Text);
                Single fMasterSyncPos = Convert.ToSingle(txtMasterSyncPos.Text);
                Single fSlaveSyncPos = Convert.ToSingle(txtSlaveSyncPos.Text);

                Single fVel = Convert.ToSingle(txtVelocity.Text);
                Single fAcc = Convert.ToUInt32(txtAcc.Text);
                Single fDec = Convert.ToUInt32(txtDec.Text);
                Single fJerk = Convert.ToUInt32(txtJerk.Text);

                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

                nResult = Module.MXP.AX_GearInPos(nMasterAxisNo, nSlaveAxisNo, nNumeratorRatio, nDenomiratorRatio
                                        , nMasterSource, fMasterSyncPos, fSlaveSyncPos, fMasterStartDist
                                        , fVel, fAcc, fDec, fJerk);

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

        private void btnGearInPosOut_Click(object sender, EventArgs e)
        {
            try
            {
                UInt32 nSlaveAxisNo = Convert.ToUInt32(txtSlaveAxisNo.Text);
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

                nResult = Module.MXP.AX_GearInPosOut(nSlaveAxisNo);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    nResult = Module.MXP.AX_Stop(nSlaveAxisNo, true, 1000, 1000);
                    nResult = Module.MXP.AX_Stop(nSlaveAxisNo, false, 1000, 1000);

                    if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                        MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("MXP Cmd Set Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnGearInPosCheck_Click(object sender, EventArgs e)
        {
            try
            {
                UInt32 nSlaveAxisNo = Convert.ToUInt32(txtSlaveAxisNo.Text);
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                MXP_EasyClass.PROCESS_CHECK stState;

                nResult = Module.MXP.AX_GearInPosMonitor(nSlaveAxisNo, out stState);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    String strState = "";

                    if (stState.ErrorOn == true)
                        strState = "Error = " + stState.ErrorID.ToString();
                    else if (stState.Done == true)
                        strState = "InPosGear";
                    else if (stState.Busy == true)
                        strState = "Active";

                    MessageBox.Show("GearInPosState = " + strState, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
