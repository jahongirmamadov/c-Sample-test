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
    public partial class Form_Parameter : Form
    {
        public Form_Parameter()
        {
            InitializeComponent();
        }

        Form_Main frm1;

        public Form_Parameter(Form_Main _form)
        {
            InitializeComponent();
            frm1 = _form;
        }

        private void btnReadParameter_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                UInt16 nParamegerNo = Convert.ToUInt16(txtAxisParameterNo.Text);
                Single fParameterValue = 0;

                nResult = Module.MXP.AX_ReadParameter(nAxisNo, nParamegerNo, out fParameterValue);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Parameter Value : " + fParameterValue.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnWriteParameter_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                UInt16 nParamegerNo = Convert.ToUInt16(txtAxisParameterNo.Text);
                Single fWriteValue = Convert.ToUInt16(txtWriteValue.Text);

                nResult = Module.MXP.AX_WriteParameter(nAxisNo, nParamegerNo, fWriteValue);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Parameter Write Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

                nResult = Module.MXP.AX_StoreParameter();

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Parameter Store Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
