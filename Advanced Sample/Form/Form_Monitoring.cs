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
    public partial class Form_Monitoring : Form
    {
        public Form_Monitoring()
        {
            InitializeComponent();
        }

        Form_Main frm1;

        public Form_Monitoring(Form_Main _form)
        {
            InitializeComponent();
            frm1 = _form;
        }

        private void btnReadActialPosition_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                Single fActualPosition = 0;

                nResult = Module.MXP.AX_ReadActualPosition(nAxisNo, out fActualPosition);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Actual Position : " + fActualPosition.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAxisState_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                MXP_EasyClass.MXP_AxisStateBit stAxisState = new MXP_EasyClass.MXP_AxisStateBit();

                nResult = Module.MXP.AX_ReadStatus(nAxisNo, out stAxisState);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    String strMotionState = "Not Moving";

                    if (stAxisState.Accelerating == true)
                        strMotionState = "Acceleration";
                    else if (stAxisState.ConstantVelocity == true)
                        strMotionState = "ConstantVelocity";
                    else if (stAxisState.Decelerating == true)
                        strMotionState = "Decelerating";

                    if (stAxisState.DirectionNegative == true)
                        strMotionState = strMotionState + "\t -";
                    else if (stAxisState.DirectionPositive == true)
                        strMotionState = strMotionState + "\t +";

                    MessageBox.Show("Actual MotionState : " + strMotionState, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    String strAxisStatus = "UnKnown";

                    if (stAxisState.ErrorStop == true)
                        strAxisStatus = "ErrorStop";
                    else if (stAxisState.Disabled == true)
                        strAxisStatus = "Disable";
                    else if (stAxisState.Stopping == true)
                        strAxisStatus = "Stopping";
                    else if (stAxisState.DiscreteMotion == true)
                        strAxisStatus = "DiscreteMotion";
                    else if (stAxisState.ContinuousMotion == true)
                        strAxisStatus = "ContinuousMotion";
                    else if (stAxisState.SynchronizedMotion == true)
                        strAxisStatus = "SynchronizedMotion";
                    else if (stAxisState.Standstill == true)
                        strAxisStatus = "Standstill";                    

                    MessageBox.Show("Actual AxisState : " + strAxisStatus, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    String strIOState = "AxisHArdwareIO State \n";
                    strIOState = "Home IO = " + stAxisState.HomeAbsSwitch.ToString() + "\n";
                    strIOState = strIOState + "Neg Limit IO = " + stAxisState.HWLimitSwitchNegEvent.ToString() + "\n";
                    strIOState = strIOState + "Pos Limit IO = " + stAxisState.HWLimitSwitchPosEvent.ToString() + "\n";
                    strIOState = strIOState + "Axis Warning IO = " + stAxisState.AxisWarning.ToString();

                    MessageBox.Show(strIOState, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnReadActialVelocity_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                Single fActualVelocity = 0;

                nResult = Module.MXP.AX_ReadActualVelocity(nAxisNo, out fActualVelocity);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Actual Velocity : " + fActualVelocity.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnReadActualTorque_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                Single fActualTorque = 0;

                nResult = Module.MXP.AX_ReadActualTorque(nAxisNo, out fActualTorque);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Actual Torque : " + fActualTorque.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnReadFollowingError_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                Single fFollowingError = 0;

                nResult = Module.MXP.AX_ReadFollowingError(nAxisNo, out fFollowingError);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Actual Following Error : " + fFollowingError.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnReadCmdPosition_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                Single fCmdPosition = 0;

                nResult = Module.MXP.AX_ReadCommandPosition(nAxisNo, out fCmdPosition);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Command Position : " + fCmdPosition.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnReadCmdVelocity_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                Single fCmdVelocity = 0;

                nResult = Module.MXP.AX_ReadCommandVelocity(nAxisNo, out fCmdVelocity);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Command Velocity : " + fCmdVelocity.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnReadError_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);

                MXP_EasyClass.AXIS_ERROR stAxisError = new MXP_EasyClass.AXIS_ERROR();
                nResult = Module.MXP.AX_ReadError(nAxisNo, out stAxisError);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("MXP Error : " + stAxisError.MXPError.ToString() + "\tDrive Error : " + stAxisError.DriveError.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnGroupReadActPos_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nGroupNo = Convert.ToUInt32(txtGroupNo.Text);
                MXP_EasyClass.Group_Pos stActualPosition = new MXP_EasyClass.Group_Pos();

                nResult = Module.MXP.GRP_ReadActualPosition(nGroupNo, out stActualPosition);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    String strPos;
                    strPos = "X : " + stActualPosition.nX.ToString();
                    strPos = strPos + "\nY : " + stActualPosition.nY.ToString();
                    strPos = strPos + "\nZ : " + stActualPosition.nZ.ToString();
                    strPos = strPos + "\nU : " + stActualPosition.nU.ToString();
                    strPos = strPos + "\nV : " + stActualPosition.nV.ToString();
                    strPos = strPos + "\nW : " + stActualPosition.nW.ToString();
                    strPos = strPos + "\nA : " + stActualPosition.nA.ToString();
                    strPos = strPos + "\nB : " + stActualPosition.nB.ToString();
                    strPos = strPos + "\nC : " + stActualPosition.nC.ToString();

                    MessageBox.Show(strPos, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnGroupReadActVel_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nGroupNo = Convert.ToUInt32(txtGroupNo.Text);
                Single fActualVelocity = 0;

                nResult = Module.MXP.GRP_ReadActualVelocity(nGroupNo, out fActualVelocity);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Group Actual Velocity : " + fActualVelocity.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnGroupReadCmdPos_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nGroupNo = Convert.ToUInt32(txtGroupNo.Text);
                MXP_EasyClass.Group_Pos stCommandPosition = new MXP_EasyClass.Group_Pos();

                nResult = Module.MXP.GRP_ReadCommandPosition(nGroupNo, out stCommandPosition);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    String strPos;
                    strPos = "X : " + stCommandPosition.nX.ToString();
                    strPos = strPos + "\nY : " + stCommandPosition.nY.ToString();
                    strPos = strPos + "\nZ : " + stCommandPosition.nZ.ToString();
                    strPos = strPos + "\nU : " + stCommandPosition.nU.ToString();
                    strPos = strPos + "\nV : " + stCommandPosition.nV.ToString();
                    strPos = strPos + "\nW : " + stCommandPosition.nW.ToString();
                    strPos = strPos + "\nA : " + stCommandPosition.nA.ToString();
                    strPos = strPos + "\nB : " + stCommandPosition.nB.ToString();
                    strPos = strPos + "\nC : " + stCommandPosition.nC.ToString();

                    MessageBox.Show(strPos, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnGroupReadCmdVel_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nGroupNo = Convert.ToUInt32(txtGroupNo.Text);
                Single fCommandVelocity = 0;

                nResult = Module.MXP.GRP_ReadCommandVelocity(nGroupNo, out fCommandVelocity);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Group Command Velocity : " + fCommandVelocity.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnGroupReadyCheck_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nGroupNo = Convert.ToUInt32(txtGroupNo.Text);
                Boolean bReadyCheck;

                nResult = Module.MXP.GRP_ReadyCheck(nGroupNo, out bReadyCheck);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Group Ready Status: " + bReadyCheck.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
