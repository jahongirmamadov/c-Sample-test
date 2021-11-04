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
    public partial class Form_UnitChange : Form
    {
        public Form_UnitChange()
        {
            InitializeComponent();
        }

        Form_Main frm1;

        public Form_UnitChange(Form_Main _form)
        {
            InitializeComponent();
            frm1 = _form;
        }

        private void btnMXPtoTimeUnit_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                Single fTargetVel = Convert.ToSingle(txtTargetVel.Text);
                Single fAcc = Convert.ToSingle(txtAccDec.Text);
                Single fJerk = Convert.ToSingle(txtJerk.Text);
                MXP_EasyClass.AccDecToAccTime_Reply stData = new MXP_EasyClass.AccDecToAccTime_Reply();

                nResult = Module.MXP.AX_AccDecToAccTime(nAxisNo, fTargetVel, fAcc, fJerk, out stData);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    String strTime = "";
                    strTime = "AccDecRampUp = " + stData.AccDecBuildUp.ToString();
                    strTime = strTime + ", LimitAccDec = " + stData.LimitAccDec.ToString();
                    strTime = strTime + ",\n fAccDecRampDown = " + stData.AccDecRampDown.ToString();

                    MessageBox.Show(strTime, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
                
        }

        private void btnTimeToMXPUnit_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                Single fTargetVel = Convert.ToSingle(txtTargetVel.Text);
                Single fAccDecBuildUpTime = Convert.ToSingle(txtAccdecBuildup.Text);
                Single fLimitAccDec = Convert.ToSingle(txtLimitAccdec.Text);
                Single fAccDecRampDown = Convert.ToSingle(txtAccDecRampDown.Text);
                MXP_EasyClass.AccTimeToAccDec_Reply stData = new MXP_EasyClass.AccTimeToAccDec_Reply();

                nResult = Module.MXP.AX_AccTimeToAccDec(nAxisNo, fTargetVel, fAccDecBuildUpTime, fLimitAccDec, fAccDecRampDown, out stData);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    String strTime = "";
                    strTime = "AccDec = " + stData.AccDec.ToString();
                    strTime = strTime + ", Jerk = " + stData.Jerk.ToString();

                    MessageBox.Show(strTime, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }             
        }
    }
}
