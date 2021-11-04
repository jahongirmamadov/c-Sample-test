using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MXPEasyClass;

namespace AdvancedSample
{
    public partial class Form_SpinMove : Form
    {
        public Form_SpinMove()
        {
            InitializeComponent();
        }

        Form_Main frm1;

        public Form_SpinMove(Form_Main _form)
        {
            InitializeComponent();
            frm1 = _form;
        }

        private void btnWriteSpinTable_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.SpinTable[] arrDataIn = new MXP_EasyClass.SpinTable[4];
                Single fAcc = Convert.ToSingle(txtAcc.Text);
                Single fOriginVel = Convert.ToSingle(txtOriginMoveVel.Text);
                Single fOriginWaitTime = Convert.ToSingle(txtWaitTime.Text);
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

                arrDataIn[0].fStepTime = Convert.ToSingle(txtTime_0.Text);
                arrDataIn[0].fStepVel = Convert.ToSingle(txtVel_0.Text);
                arrDataIn[1].fStepTime = Convert.ToSingle(txtTime_1.Text);
                arrDataIn[1].fStepVel = Convert.ToSingle(txtVel_1.Text);
                arrDataIn[2].fStepTime = Convert.ToSingle(txtTime_2.Text);
                arrDataIn[2].fStepVel = Convert.ToSingle(txtVel_2.Text);
                arrDataIn[3].fStepTime = Convert.ToSingle(txtTime_3.Text);
                arrDataIn[3].fStepVel = Convert.ToSingle(txtVel_3.Text);

                nResult = Module.MXP.AX_SpinRecipeWrite(arrDataIn, 4, fAcc, fOriginWaitTime, fOriginVel);

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

        private void btnSpinRun_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);

                nResult = Module.MXP.AX_SpinnerRecipeMove(nAxisNo, MXP_EasyClass.ePLCFBRunMode.e_Run);

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

        private void btnSpinStop_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);

                nResult = Module.MXP.AX_SpinnerRecipeMove(nAxisNo, MXP_EasyClass.ePLCFBRunMode.e_Stop);

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

        private void btnSpinReset_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);

                nResult = Module.MXP.AX_SpinnerRecipeMove(nAxisNo, MXP_EasyClass.ePLCFBRunMode.e_Reset);

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

        private void btnStatusCheck_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                MXP_EasyClass.FBPROCESS_CHECK nSpinProcessCheck;

                nResult = Module.MXP.AX_SpinRecipeMoveCheck(nAxisNo, out nSpinProcessCheck);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    String strState = "";

                    if (nSpinProcessCheck.nRunState == MXP_EasyClass.eFBRunState.e_Fail)
                        strState = "Error = " + nSpinProcessCheck.ErrorID.ToString();
                    else if (nSpinProcessCheck.nRunState == MXP_EasyClass.eFBRunState.e_Run)
                        strState = "Running... Step : " + ((MXP_EasyClass.eFBRunState)nSpinProcessCheck.nRunStep).ToString();
                    else
                        strState = "Ready";

                    MessageBox.Show("Spin Move Result : " + strState, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (chkMonitoring.CheckState == CheckState.Checked)
            {
                MXP_EasyClass.FBPROCESS_CHECK nSpinProcessCheck;

                Module.MXP.AX_SpinRecipeMoveCheck(Convert.ToUInt32(txtAxisNo.Text), out nSpinProcessCheck);

                String strState = "";

                if (nSpinProcessCheck.nRunState == MXP_EasyClass.eFBRunState.e_Fail)
                    strState = "Error = " + nSpinProcessCheck.ErrorID.ToString();
                else if (nSpinProcessCheck.nRunState == MXP_EasyClass.eFBRunState.e_Run)
                    strState = "Running";
                else
                    strState = "Ready";

                lblRunStep.Text = nSpinProcessCheck.nRunStep.ToString();
                lblRunState.Text = strState;
            }
        }
    }
}
