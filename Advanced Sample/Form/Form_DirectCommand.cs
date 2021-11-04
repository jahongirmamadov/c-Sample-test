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
    public partial class Form_DirectCommand : Form
    {
        public Form_DirectCommand()
        {
            InitializeComponent();
        }

        Form_Main frm1;

        public Form_DirectCommand(Form_Main _form)
        {
            InitializeComponent();
            frm1 = _form;            
        }

        private void btnDirectPos_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                Single fTargetPos = Convert.ToSingle(txtPosition.Text);

                nResult = Module.MXP.AX_MoveDirectPosition(nAxisNo, fTargetPos);

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

        private void btnHalt_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                Single fdec = 1000;
                Single fJerk = 10000;

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

        private void btnDirectCmdCheck_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                MXP_EasyClass.MXP_AxisStateBit stAxisState = new MXP_EasyClass.MXP_AxisStateBit();

                nResult = Module.MXP.AX_ReadStatus(nAxisNo, out stAxisState);

                if (stAxisState.ContinuousMotion == false)
                    MessageBox.Show("Fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("MXP Cmd Set Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnCom_Click(object sender, EventArgs e)
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

        private void btnDirectVel_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                Single fTargetVelocity = Convert.ToSingle(txtVelocity.Text);

                nResult = Module.MXP.AX_MoveDirectVelocity(nAxisNo, fTargetVelocity);

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

        private void btnDirectTorque_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                Single fTargetTorque = Convert.ToSingle(txtTorque.Text);

                nResult = Module.MXP.AX_MoveDirectTorque(nAxisNo, fTargetTorque);

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

        }
    }
}
