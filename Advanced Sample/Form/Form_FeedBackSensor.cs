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
    public partial class Form_FeedBackSensor : Form
    {
        public Form_FeedBackSensor()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                UInt32 nSlaveNo = Convert.ToUInt32(txtSlaveNo.Text);
                UInt16 nOffset = Convert.ToUInt16(txtOffset.Text);
                UInt16 nSize = Convert.ToUInt16(txtSize.Text);
                Single fSensorUnit = Convert.ToSingle(txtUnit.Text);
                Single fSensorTargetValue = Convert.ToSingle(txtSensorTargetValue.Text);
                Single fSensorPositionSetRange = Convert.ToSingle(txtSensorTargetSetRange.Text);

                Single fReducedStepDist = Convert.ToSingle(txtReduceVelDist.Text);
                Single fReducedStepVel = Convert.ToSingle(txtReduceValue.Text);

                Single fOverrideDist = Convert.ToSingle(txtOverrideDist.Text);
                Single fOverrideValue = Convert.ToSingle(txtOverrideValue.Text);

                nResult = Module.MXP.AX_SetUsingPositionSensor(nAxisNo, true, nSlaveNo, nOffset, nSize, fSensorTargetValue, fSensorPositionSetRange,
                    fSensorUnit, fReducedStepDist, fReducedStepVel, fOverrideDist, fOverrideValue);

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

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);

                nResult = Module.MXP.AX_SetUsingPositionSensor(nAxisNo, false);

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

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);

                nResult = Module.MXP.AX_FeedBackSensorDataSet(nAxisNo);

                nResult = Module.MXP.AX_FeedBackSensorRun(nAxisNo, MXP_EasyClass.ePLCFBRunMode.e_Run);

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
            UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);

            Module.MXP.AX_FeedBackSensorRun(nAxisNo, MXP_EasyClass.ePLCFBRunMode.e_Reset);
        }
    }
}

