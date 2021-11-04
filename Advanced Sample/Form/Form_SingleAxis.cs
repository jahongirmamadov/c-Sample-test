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
    public partial class Single_Motion_example : Form
    {
        public Single_Motion_example()
        {
            InitializeComponent();
        }

        Form_Main exam1;
        static Int16 nTaskPos = 0;
        static UInt32 nAxisNo;
        static Single fPosition1, fPosition2;
        static Single fVel;
        static Single fAcc;
        static Single fDec;
        static Single fJerk;
        static Single fInpos;

        public Single_Motion_example(Form_Main _form)
        {
            InitializeComponent();
            exam1 = _form;
        }


        private void SequenceMove()
        {
            Boolean bReadyCheck = false;
            MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
            MXP_EasyClass.MXP_MOVESTATE nMoveCheck = new MXP_EasyClass.MXP_MOVESTATE();

            switch(nTaskPos)
            {
                case 0: //Check Axis Ready
                    nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                    fPosition1 = Convert.ToSingle(txtPosition.Text);
                    fPosition2 = Convert.ToSingle(txtPosition2.Text);

                    fVel = Convert.ToSingle(txtVelocity.Text);
                    fAcc = Convert.ToSingle(txtAcc.Text);
                    fDec = Convert.ToSingle(txtDec.Text);
                    fJerk = Convert.ToSingle(txtJerk.Text);
                    fInpos = Convert.ToSingle(txtInpositionRange.Text);

                    nResult = Module.MXP.AX_ReadyCheck(nAxisNo, out bReadyCheck);

                    if(nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR || bReadyCheck == false)
                        nTaskPos = 800;
                    else
                        nTaskPos = 10;
                    break;

                case 10: //Move Position1
                    nResult = Module.MXP.AX_MoveAbsolute(nAxisNo, fPosition1, fVel, fAcc, fDec, fJerk, 
                MXP_EasyClass.MXP_DIRECTION_ENUM.MXP_NONE_DIRECTION, MXP_EasyClass.MXP_BUFFERMODE_ENUM.MXP_ABORTING);

                    if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                        nTaskPos = 800;
                    else
                        nTaskPos = 20;
                    break;

                case 20: //Check Position1 Complete
                    nResult = Module.MXP.AX_MoveStateCheck(nAxisNo, fPosition1, fInpos, out nMoveCheck);

                    if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR || (nMoveCheck == MXP_EasyClass.MXP_MOVESTATE.MOVESTATE_Fail || nMoveCheck == MXP_EasyClass.MXP_MOVESTATE.MOVESTATE_Null))
                        nTaskPos = 800;
                    else if(nMoveCheck == MXP_EasyClass.MXP_MOVESTATE.MOVESTATE_Complete)
                        nTaskPos = 30;
                    break;

                case 30: //Move Position2
                    nResult = Module.MXP.AX_MoveAbsolute(nAxisNo, fPosition2, fVel, fAcc, fDec, fJerk,
               MXP_EasyClass.MXP_DIRECTION_ENUM.MXP_NONE_DIRECTION, MXP_EasyClass.MXP_BUFFERMODE_ENUM.MXP_ABORTING);

                    if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                         nTaskPos = 800;
                    else
                        nTaskPos = 40;
                    break;

                case 40: //Check Position2 Complete
                    nResult = Module.MXP.AX_MoveStateCheck(nAxisNo, fPosition2, fInpos, out nMoveCheck);

                    if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR || (nMoveCheck == MXP_EasyClass.MXP_MOVESTATE.MOVESTATE_Fail | nMoveCheck == MXP_EasyClass.MXP_MOVESTATE.MOVESTATE_Null))
                        nTaskPos = 800;
                    else if(nMoveCheck == MXP_EasyClass.MXP_MOVESTATE.MOVESTATE_Complete)
                        nTaskPos = 1000;
                    break;

                case 800: //Error
                    nTaskPos = 0;
                    Timer2Point.Enabled = false;
                    MessageBox.Show("Sequence Move Fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case 1000: //Complete
                    nTaskPos = 0;
                    Timer2Point.Enabled = false;
                    MessageBox.Show("Sequence Move Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);

                nResult = Module.MXP.AX_Power(nAxisNo, true);

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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);

                nResult = Module.MXP.AX_Power(nAxisNo, false);

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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);

                nResult = Module.MXP.AX_Reset(nAxisNo);

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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);

                nResult = Module.MXP.AX_Home(nAxisNo);

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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                Single fSetPosition = Convert.ToSingle(txtSetPosition.Text);

                nResult = Module.MXP.AX_SetPosition(nAxisNo, fSetPosition);

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

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                Single fdec = Convert.ToSingle(txtDec.Text);
                Single fJerk = Convert.ToSingle(txtJerk.Text);

                nResult = Module.MXP.AX_Halt(nAxisNo, fdec, fJerk);

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

        

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                Single fPosition = Convert.ToSingle(txtPosition.Text);
                Single fVel = Convert.ToSingle(txtVelocity.Text);
                Single fAcc = Convert.ToSingle(txtAcc.Text);
                Single fdec = Convert.ToSingle(txtDec.Text);
                Single fJerk = Convert.ToSingle(txtJerk.Text);

                nResult = Module.MXP.AX_MoveAbsolute(nAxisNo, fPosition, fVel, fAcc, fdec, fJerk,
                    MXP_EasyClass.MXP_DIRECTION_ENUM.MXP_NONE_DIRECTION, MXP_EasyClass.MXP_BUFFERMODE_ENUM.MXP_ABORTING);

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

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                Single fDistance = Convert.ToSingle(txtPosition.Text);
                Single fVel = Convert.ToSingle(txtVelocity.Text);
                Single fAcc = Convert.ToSingle(txtAcc.Text);
                Single fdec = Convert.ToSingle(txtDec.Text);
                Single fJerk = Convert.ToSingle(txtJerk.Text);

                nResult = Module.MXP.AX_MoveRelative(nAxisNo, fDistance, fVel, fAcc, fdec, fJerk,
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

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                Module.MXP.AX_MoveVelocity(0, 50, 100, 100, 1000, MXP_EasyClass.MXP_DIRECTION_ENUM.MXP_CURRENT_DIRECTION, MXP_EasyClass.MXP_BUFFERMODE_ENUM.MXP_ABORTING);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                Form_Main.COM.FormShow(1, Convert.ToUInt32(txtAxisNo.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                Boolean bReadyCheck = false;

                nResult = Module.MXP.AX_ReadyCheck(nAxisNo, out bReadyCheck);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (bReadyCheck)
                        MessageBox.Show("Axis Ready", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    else
                        MessageBox.Show("Axis Not Ready", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                Single fdec = Convert.ToSingle(txtDec.Text);
                Single fJerk = Convert.ToSingle(txtJerk.Text);

                nResult = Module.MXP.AX_Stop(nAxisNo, true, fdec, fJerk);

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

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                Single fdec = Convert.ToSingle(txtDec.Text);
                Single fJerk = Convert.ToSingle(txtJerk.Text);

                nResult = Module.MXP.AX_Stop(nAxisNo, false, fdec, fJerk);

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

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                Single fPosition = Convert.ToSingle(txtPosition.Text);
                MXP_EasyClass.MXP_MOVESTATE nMoveState = new MXP_EasyClass.MXP_MOVESTATE();
                Single fInpositionRange = Convert.ToSingle(txtInpositionRange.Text);

                nResult = Module.MXP.AX_MoveStateCheck(nAxisNo, fPosition, fInpositionRange, out nMoveState);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Axis Move State = " + nMoveState.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                       
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                Single fPosition = Convert.ToSingle(txtPosition2.Text);
                MXP_EasyClass.MXP_MOVESTATE nMoveState = new MXP_EasyClass.MXP_MOVESTATE();
                Single fInpositionRange = Convert.ToSingle(txtInpositionRange.Text);

                nResult = Module.MXP.AX_MoveStateCheck(nAxisNo, fPosition, fInpositionRange, out nMoveState);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Axis Move State = " + nMoveState.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                       
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                Single fPosition1 = Convert.ToSingle(txtPosition.Text);
                Single fPosition2 = Convert.ToSingle(txtPosition2.Text);
                Single fVel = Convert.ToSingle(txtVelocity.Text);
                Single fAcc = Convert.ToSingle(txtAcc.Text);
                Single fdec = Convert.ToSingle(txtDec.Text);
                Single fJerk = Convert.ToSingle(txtJerk.Text);

                nResult = Module.MXP.AX_MoveAbsolute(nAxisNo, fPosition1, fVel, fAcc, fdec, fJerk, MXP_EasyClass.MXP_DIRECTION_ENUM.MXP_NONE_DIRECTION,
                    MXP_EasyClass.MXP_BUFFERMODE_ENUM.MXP_BUFFERED);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    nResult = Module.MXP.AX_MoveAbsolute(nAxisNo, fPosition2, fVel, fAcc, fdec, fJerk, MXP_EasyClass.MXP_DIRECTION_ENUM.MXP_NONE_DIRECTION,
                    MXP_EasyClass.MXP_BUFFERMODE_ENUM.MXP_BUFFERED);
                    MessageBox.Show("MXP Cmd Set Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                Timer2Point.Interval = 10;
                Timer2Point.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                       
        }

        private void Timer2Point_Tick(object sender, EventArgs e)
        {
            SequenceMove();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                Single fVel = Convert.ToSingle(txtVelocity.Text);
                Single fAcc = Convert.ToSingle(txtAcc.Text);
                Single fdec = Convert.ToSingle(txtDec.Text);
                Single fJerk = Convert.ToSingle(txtJerk.Text);

                nResult = Module.MXP.AX_MoveVelocity(nAxisNo, fVel, fAcc, fdec, fJerk, MXP_EasyClass.MXP_DIRECTION_ENUM.MXP_NEGATIVE_DIRECTION,
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

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                Single fVel = Convert.ToSingle(txtVelocity.Text);
                Single fAcc = Convert.ToSingle(txtAcc.Text);
                Single fdec = Convert.ToSingle(txtDec.Text);
                Single fJerk = Convert.ToSingle(txtJerk.Text);

                nResult = Module.MXP.AX_MoveVelocity(nAxisNo, fVel, fAcc, fdec, fJerk, MXP_EasyClass.MXP_DIRECTION_ENUM.MXP_POSITIVE_DIRECTION,
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

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                Single fSetOverride = Convert.ToSingle(txtSetOverride.Text);

                nResult = Module.MXP.AX_SetOverride(nAxisNo, fSetOverride);

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

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                Single fPosition = Convert.ToSingle(txtPosition2.Text);
                Single fVel = Convert.ToSingle(txtVelocity.Text);
                Single fAcc = Convert.ToSingle(txtAcc.Text);
                Single fdec = Convert.ToSingle(txtDec.Text);
                Single fJerk = Convert.ToSingle(txtJerk.Text);

                nResult = Module.MXP.AX_MoveAbsolute(nAxisNo, fPosition, fVel, fAcc, fdec, fJerk,
                    MXP_EasyClass.MXP_DIRECTION_ENUM.MXP_NONE_DIRECTION, MXP_EasyClass.MXP_BUFFERMODE_ENUM.MXP_ABORTING);

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

                nResult = Module.MXP.AX_SequenceMove_File(txtSequenceMovePath.Text, Convert.ToUInt16(txtStartStep.Text),Convert.ToUInt16(txtEndStep.Text), out strError);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString() + "\n" + strError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                  //  bStartFlag = true;
                    MessageBox.Show("MXP Cmd Set Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
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

                nResult = Module.MXP.AX_SequenceMoveCheck(Convert.ToUInt16(txtAxisNo.Text), out nCurStep, out strCurStepName, out nRemainCount, out stResult);

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

        String strLog1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bStartFlag)
            {
                try
                {
                    MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                    MXP_EasyClass.SEQUENCEMOVEPROCESS_CHECK stResult;
                    UInt16 nRemainCount;
                    UInt16 nCurStep;
                    String strCurStepName = "";
                    String strCurLog ="";
                    nResult = Module.MXP.AX_SequenceMoveCheck(Convert.ToUInt16(txtAxisNo.Text), out nCurStep, out strCurStepName, out nRemainCount, out stResult);

                    if (nResult == MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    {
                        if (stResult.Busy) lblSequenceState.Text = "Busy";
                        else if (stResult.Done) lblSequenceState.Text = "Done";
                        else if (stResult.ErrorOn) lblSequenceState.Text = "Error";
                        strCurLog= lblSequenceState.Text ;

                        lblSequenceStep.Text = "Current Step : " + nCurStep.ToString();
                        strCurLog = lblSequenceStep.Text  + ", " + strCurLog;

                        lblSequenceStepInfo.Text = "Current Step Info : " + strCurStepName;
                        strCurLog = lblSequenceStepInfo.Text  + strCurLog;

                        if (strLog1 != strCurLog)
                        {
                            Console.WriteLine("Axis2"+","+ strCurLog);                           
                        }
                        strLog1 = strCurLog;

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } 

            }
        }

        private void btnOverridMoveCheck_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAixsNo = Convert.ToUInt32(txtAxisNo.Text);
                Single fPosition = Convert.ToSingle(txtOverrideTargetPosition.Text);
                MXP_EasyClass.MXP_MOVESTATE nMoveState;
                Single fInpositionRange = Convert.ToSingle(txtInpositionRange.Text);

                nResult = Module.MXP.AX_MoveStateCheck(nAxisNo, fPosition, fInpositionRange, out nMoveState);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Axis Move State = " + nMoveState.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void btnPos1OverrideMove_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                Single fTargetPosition = Convert.ToSingle(txtOverrideTargetPosition.Text);
                Single fTargetVel = Convert.ToSingle(txtOverrideTargetVelocity.Text);
                Single[] fOverridePos = new Single[2];
                Single[] fOverrideVel = new Single[2];
                Single fAcc = Convert.ToSingle(txtAcc.Text);
                Single fDec = Convert.ToSingle(txtDec.Text);
                Single fJerk = Convert.ToSingle(txtJerk.Text);
                MXP_EasyClass.MXP_BUFFERMODE_ENUM nBlendingMode = (MXP_EasyClass.MXP_BUFFERMODE_ENUM)cboBufferMode.SelectedIndex;

                fOverridePos[0] = Convert.ToSingle(txtOverride1Position.Text);
                fOverridePos[1] = Convert.ToSingle(txtOverride2Position.Text);

                fOverrideVel[0] = Convert.ToSingle(txtOverride1Velocity.Text);
                fOverrideVel[1] = Convert.ToSingle(txtOverride2Velocity.Text);

                nResult = Module.MXP.AX_MoveAbsolute_VelocityOverride(nAxisNo, fTargetPosition, fTargetVel, 2, fOverridePos, fOverrideVel, fAcc, fDec, fJerk, nBlendingMode);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void Single_Motion_example_Load(object sender, EventArgs e)
        {
            cboBufferMode.SelectedIndex = 3;
        }

        private void btnSequenceMoveReqA_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.StSequenceMoveStep[] arrStepMoveData = new MXP_EasyClass.StSequenceMoveStep[2];
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                Single fAcc = Convert.ToSingle(txtAcc.Text);
                Single fDec = Convert.ToSingle(txtDec.Text);
                Single fJerk = Convert.ToSingle(txtJerk.Text);
                MXP_EasyClass.MXP_SequenceMoveMode nMoveMode = (MXP_EasyClass.MXP_SequenceMoveMode)Convert.ToInt32(txtMoveMode.Text);
                MXP_EasyClass.MXP_BUFFERMODE_ENUM nBufferedMode = (MXP_EasyClass.MXP_BUFFERMODE_ENUM)Convert.ToInt32(txtSequenceBufferedMode.Text);
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                arrStepMoveData[0].fPos = Convert.ToSingle(txtPosition.Text);
                arrStepMoveData[0].fVel = Convert.ToSingle(txtVelocity.Text);
                arrStepMoveData[1].fPos = Convert.ToSingle(txtPosition2.Text);
                arrStepMoveData[1].fVel = Convert.ToSingle(txtVelocity.Text);

                //nResult = Module.MXP.AX_SequenceMoveRequest(nAxisNo, nMoveMode, nBufferedMode, arrStepMoveData, fAcc, fDec, fJerk);

                nResult = Module.MXP.AX_SequenceMoveRequest(nAxisNo, nMoveMode, nBufferedMode, arrStepMoveData, fAcc, fDec, fJerk, true);
                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                bStartFlag = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void btnSequenceMoveReqACheck_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                MXP_EasyClass.SEQUENCEMOVEPROCESS_CHECK stResult;
                UInt16 nRemainCount = 0;
                UInt16 nCurStep = 0;
                String strCurStepName = "";
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);

                nResult = Module.MXP.AX_SequenceMoveCheck(nAxisNo, out nCurStep, out strCurStepName, out nRemainCount, out stResult);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (stResult.Busy)
                        lblSequenceState.Text = "Busy";
                    else if (stResult.Done)
                        lblSequenceState.Text = "Done";
                    else if (stResult.ErrorOn)
                        lblSequenceState.Text = "Error";

                    lblSequenceStep.Text = "Current Step : " + nCurStep.ToString();
                    lblSequenceStepInfo.Text = "Current Step Info : " + strCurStepName;
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void btnFeedBackSensor_Click(object sender, EventArgs e)
        {
            Form_FeedBackSensor nForm = new Form_FeedBackSensor();
            nForm.Show();
        }
    }
}
