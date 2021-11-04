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
    public partial class Form_Group : Form
    {
        public Form_Group()
        {
            InitializeComponent();
        }

        Form_Main frm1;

        public Form_Group(Form_Main _form)
        {
            InitializeComponent();
            frm1 = _form;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form_Main.COM.FormGroupShow(Convert.ToUInt32(txtGroupNo.Text));
        }

        private void btnAbsMove_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nGroupNo = Convert.ToUInt32(txtGroupNo.Text);
                MXP_EasyClass.Group_Pos stGroupPos;

                stGroupPos.nX = Convert.ToSingle(txtXPos.Text);
                stGroupPos.nY = Convert.ToSingle(txtYPos.Text);
                stGroupPos.nZ = Convert.ToSingle(txtZPos.Text);
                stGroupPos.nU = Convert.ToSingle(txtUPos.Text);
                stGroupPos.nV = Convert.ToSingle(txtVPos.Text);
                stGroupPos.nW = Convert.ToSingle(txtWPos.Text);
                stGroupPos.nA = Convert.ToSingle(txtAPos.Text);
                stGroupPos.nB = Convert.ToSingle(txtBPos.Text);
                stGroupPos.nC = Convert.ToSingle(txtCPos.Text);

                Single fVel = Convert.ToSingle(txtVelocity.Text);
                Single fAcc = Convert.ToSingle(txtAcc.Text);
                Single fDec = Convert.ToSingle(txtDec.Text);
                Single fJerk = Convert.ToSingle(txtJerk.Text);

                nResult = Module.MXP.GRP_MoveLinearAbsolute(nGroupNo, stGroupPos, fVel, fAcc, fDec, fJerk,
                    MXP_EasyClass.MXP_BUFFERMODE_ENUM.MXP_ABORTING);

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
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nGroupNo = Convert.ToUInt32(txtGroupNo.Text);
                MXP_EasyClass.Group_Pos stGroupPos;

                stGroupPos.nX = Convert.ToSingle(txtXPos.Text);
                stGroupPos.nY = Convert.ToSingle(txtYPos.Text);
                stGroupPos.nZ = Convert.ToSingle(txtZPos.Text);
                stGroupPos.nU = Convert.ToSingle(txtUPos.Text);
                stGroupPos.nV = Convert.ToSingle(txtVPos.Text);
                stGroupPos.nW = Convert.ToSingle(txtWPos.Text);
                stGroupPos.nA = Convert.ToSingle(txtAPos.Text);
                stGroupPos.nB = Convert.ToSingle(txtBPos.Text);
                stGroupPos.nC = Convert.ToSingle(txtCPos.Text);

                Single fVel = Convert.ToSingle(txtVelocity.Text);
                Single fAcc = Convert.ToSingle(txtAcc.Text);
                Single fDec = Convert.ToSingle(txtDec.Text);
                Single fJerk = Convert.ToSingle(txtJerk.Text);

                nResult = Module.MXP.GRP_MoveLinearRelative(nGroupNo, stGroupPos, fVel, fAcc, fDec, fJerk,
                    MXP_EasyClass.MXP_BUFFERMODE_ENUM.MXP_ABORTING);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("MXP Cmd Set Success", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAbscircular_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nGroupNo = Convert.ToUInt32(txtGroupNo.Text);
                Single fAuxPoint1 = Convert.ToSingle(txtCenterPoint1.Text);
                Single fAuxPoint2 = Convert.ToSingle(txtCenterPoint2.Text);
                Single fEndPoint1 = Convert.ToSingle(txtEndPoint1.Text);
                Single fEndPoint2 = Convert.ToSingle(txtEndPoint2.Text);
                MXP_EasyClass.MXP_PATHCHOICE_ENUM nPath = (MXP_EasyClass.MXP_PATHCHOICE_ENUM)Convert.ToInt32(txtPathChoice.Text);

                Single fVel = Convert.ToSingle(txtVelocity.Text);
                Single fAcc = Convert.ToSingle(txtAcc.Text);
                Single fDec = Convert.ToSingle(txtDec.Text);
                Single fJerk = Convert.ToSingle(txtJerk.Text);

                nResult = Module.MXP.GRP_MoveCircularAbsolute(nGroupNo, nPath, fAuxPoint1, fAuxPoint2, fEndPoint1, fEndPoint2, MXP_EasyClass.MXP_PLANE.XPLANE,
                    MXP_EasyClass.MXP_PLANE.YPLANE, fVel, fAcc, fDec, fJerk, MXP_EasyClass.MXP_BUFFERMODE_ENUM.MXP_ABORTING);

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

        private void btnGroupAxisInfo_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nGroupNo = Convert.ToUInt32(txtGroupNo.Text);
                Int32[] arrGroupAxisInfo = { -1, -1, -1, -1, -1, -1, -1, -1 };

                nResult = Module.MXP.GRP_GetGroupAxis(nGroupNo, out arrGroupAxisInfo);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    String strAxisInfo = "";
                    Int32 nAxisCount;

                    for (nAxisCount = 0; nAxisCount < arrGroupAxisInfo.Length; nAxisCount++)
                    {
                        if (arrGroupAxisInfo[nAxisCount] != -1)
                            strAxisInfo = strAxisInfo + arrGroupAxisInfo[nAxisCount].ToString() + "\t";
                    }
                    MessageBox.Show("Group Axes = " + strAxisInfo, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nGroupNo = Convert.ToUInt32(txtGroupNo.Text);
                Single fDec = Convert.ToSingle(txtDec.Text);
                Single fJerk = Convert.ToSingle(txtJerk.Text);

                nResult = Module.MXP.GRP_Stop(nGroupNo, true, fDec, fJerk);

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

        private void btnStopReset_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nGroupNo = Convert.ToUInt32(txtGroupNo.Text);
                Single fDec = Convert.ToSingle(txtDec.Text);
                Single fJerk = Convert.ToSingle(txtJerk.Text);

                nResult = Module.MXP.GRP_Stop(nGroupNo, false, fDec, fJerk);

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

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nGroupNo = Convert.ToUInt32(txtGroupNo.Text);
                Single fSetOverride = Convert.ToSingle(txtSetOverride.Text);

                nResult = Module.MXP.GRP_SetOverride(nGroupNo, fSetOverride);

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

        private void btnRelativecircular_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nGroupNo = Convert.ToUInt32(txtGroupNo.Text);
                Single fAuxPoint1 = Convert.ToSingle(txtCenterPoint1.Text);
                Single fAuxPoint2 = Convert.ToSingle(txtCenterPoint2.Text);
                Single fEndPoint1 = Convert.ToSingle(txtEndPoint1.Text);
                Single fEndPoint2 = Convert.ToSingle(txtEndPoint2.Text);
                MXP_EasyClass.MXP_PATHCHOICE_ENUM nPath = (MXP_EasyClass.MXP_PATHCHOICE_ENUM)Convert.ToInt32(txtPathChoice.Text);

                Single fVel = Convert.ToSingle(txtVelocity.Text);
                Single fAcc = Convert.ToSingle(txtAcc.Text);
                Single fDec = Convert.ToSingle(txtDec.Text);
                Single fJerk = Convert.ToSingle(txtJerk.Text);

                nResult = Module.MXP.GRP_MoveCircularRelative(nGroupNo, nPath, fAuxPoint1, fAuxPoint2, fEndPoint1, fEndPoint2, MXP_EasyClass.MXP_PLANE.XPLANE,
                    MXP_EasyClass.MXP_PLANE.YPLANE, fVel, fAcc, fDec, fJerk, MXP_EasyClass.MXP_BUFFERMODE_ENUM.MXP_ABORTING);

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

        private void btnFileSelect_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                txtSequenceMovePath.Text = OpenFileDialog1.FileName;
        }

        private Boolean bStartFlag = false;//디버깅용
        private void btnSequenceMoveReq_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                String strError = "";

                nResult = Module.MXP.GRP_SequenceMove_File(txtSequenceMovePath.Text, Convert.ToUInt16(txtStartStep.Text), Convert.ToUInt16(txtEndStep.Text), out strError);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString() + "\n" + strError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                   // bStartFlag = true;
                    MessageBox.Show("MXP Cmd Set Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSequenceMoveCheck_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                MXP_EasyClass.SEQUENCEMOVEPROCESS_CHECK stResult;
                UInt16 nRemainCount;
                UInt16 nCurStep;
                String strCurStepName = "";

                nResult = Module.MXP.GRP_SequenceMoveCheck(Convert.ToUInt16(txtGroupNo.Text), out nCurStep, out strCurStepName, out nRemainCount, out stResult);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (stResult.Busy) lblSequenceState.Text = "Busy";
                    else if (stResult.Done) lblSequenceState.Text = "Done";
                    else if (stResult.ErrorOn) lblSequenceState.Text = "Error";

                    lblSequenceStep.Text = "Current Step : " + nCurStep.ToString();
                    lblSequenceStepInfo.Text = "Current Step Info : " + strCurStepName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        String strLog1 = "";
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bStartFlag)
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                MXP_EasyClass.SEQUENCEMOVEPROCESS_CHECK stResult;
                UInt16 nRemainCount;
                UInt16 nCurStep;
                String strCurStepName = "";
                String strCurLog = "";

                nResult = Module.MXP.GRP_SequenceMoveCheck(Convert.ToUInt16(txtGroupNo.Text), out nCurStep, out strCurStepName, out nRemainCount, out stResult);

                if (nResult == MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                {
                    if (stResult.Busy) lblSequenceState.Text = "Busy";
                    else if (stResult.Done) lblSequenceState.Text = "Done";
                    else if (stResult.ErrorOn) lblSequenceState.Text = "Error";

                    strCurLog = lblSequenceState.Text;
                    lblSequenceStep.Text = "Current Step : " + nCurStep.ToString();
                    strCurLog = lblSequenceStep.Text + "," + strCurLog;

                    if (strLog1 != strCurLog)
                    {
                        Console.WriteLine("Group 0" + "," + strCurLog);
                    }
                    strLog1 = strCurLog;


                }
            }
        }
    }
}
