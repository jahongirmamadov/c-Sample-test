using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MXPEasyClass;

namespace Basic_Sample
{
    public partial class Form_Basic : Form
    {
        public Form_Basic()
        {
            InitializeComponent();
        }

        private void btnSystemInit_Click(object sender, EventArgs e)
        {
             //If the return value is not 0, refer to the "function return value" section of the Manual.
            MXP_EasyClass.MXP_FUNCTION_STATUS nResult = new MXP_EasyClass.MXP_FUNCTION_STATUS();

            nResult = Module.MXP.SYS_Init();

            if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("MXP Init Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnSystemRun_Click(object sender, EventArgs e)
        {
            //If the return value is not 0, refer to the "function return value" section of the Manual.
            MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

            nResult = Module.MXP.SYS_Run();

            if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("MXP Run Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnCheckSystem_Click(object sender, EventArgs e)
        {
            //If the return value is not 0, refer to the "function return value" section of the Manual.
            MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
            MXP_EasyClass.KERNEL_STATUS nState;

            nResult = Module.MXP.SYS_GetStatus(out nState);

            if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (nState < MXP_EasyClass.KERNEL_STATUS.SYSTEM_RUN)
                    MessageBox.Show("MXP is not Running", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else
                    MessageBox.Show("MXP is Running", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnPowerOn_Click(object sender, EventArgs e)
        {
            //If the return value is not 0, refer to the "function return value" section of the Manual.
            MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
            UInt32 nAxisNo = 0;

            nResult = Module.MXP.AX_Power(nAxisNo, true);

            if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("MXP Cmd Set Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnAxisReadyCheck_Click(object sender, EventArgs e)
        {
            //If the return value is not 0, refer to the "function return value" section of the Manual.
            MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
            UInt32 nAxisNo = 0;
            bool bReadyCheck = false;

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

        private void btnHome_Click(object sender, EventArgs e)
        {
            //If the return value is not 0, refer to the "function return value" section of the Manual.
            MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
            UInt32 nAxisNo = 0;

            nResult = Module.MXP.AX_Home(nAxisNo);

            if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("MXP Cmd Set Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnPowerOff_Click(object sender, EventArgs e)
        {
            //If the return value is not 0, refer to the "function return value" section of the Manual.
            MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
            UInt32 nAxisNo = 0;

            nResult = Module.MXP.AX_Power(nAxisNo, false);

            if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("MXP Cmd Set Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnSystemStop_Click(object sender, EventArgs e)
        {
            MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

            nResult = Module.MXP.SYS_Stop();

            if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("MXP Stop Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnSystemClose_Click(object sender, EventArgs e)
        {
            MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

            nResult = Module.MXP.SYS_Destroy();

            if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("MXP Destroy Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void LinkManual_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strMAnualPath = "D:\\SVN\\document\\4_개발모델\\제어기과제\\MXP4.0\\2_분석설계\\API 언어벌 개발\\배포경로\\Manual\\API Manual.chm";
            System.Diagnostics.Process.Start(strMAnualPath);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //If the return value is not 0, refer to the "function return value" section of the Manual.
            MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

            nResult = Module.MXP.SYS_Reset();

            if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("MXP Reset Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
