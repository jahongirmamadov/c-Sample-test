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
    public partial class Form_System : Form
    {
        public Form_System()
        {
            InitializeComponent();
        }

        Form_Main exam1;

        public Form_System(Form_Main _form)
        {
            InitializeComponent();
            exam1 = _form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult = new MXP_EasyClass.MXP_FUNCTION_STATUS();

                nResult = Module.MXP.SYS_Init();

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("MXP Init Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

                nResult = Module.MXP.SYS_Run();

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("MXP Run Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

                nResult = Module.MXP.SYS_Stop();

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("MXP Stop Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

                nResult = Module.MXP.SYS_Destroy();

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("MXP Destroy Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                UInt32 nAliasNumber = Convert.ToUInt32(txtAliasNumber.Text);
                UInt32 nSlaveNumber = 0;

                nResult = Module.MXP.ECAT_GetSlaveNoFromNodeId(nAliasNumber, out nSlaveNumber);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("AliasNo = " + nAliasNumber.ToString() + ", " + "SlaveNo = " + nSlaveNumber.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                UInt32 nAliasNumber = Convert.ToUInt32(txtAliasNumber.Text);
                UInt32 nAxisNumber = 0;

                nResult = Module.MXP.ECAT_GetAxisNoFromNodeId(nAliasNumber, out nAxisNumber);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("AliasNo = " + nAliasNumber.ToString() + ", " + "AxisNo = " + nAxisNumber.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                MXP_EasyClass.MXP_ONLINE_STATE nMasterState = new MXP_EasyClass.MXP_ONLINE_STATE();

                nResult = Module.MXP.ECAT_GetMasterOnlineMode(out nMasterState);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("MXP ComState = " + nMasterState.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                Int32[] arrAlarmHistory = new Int32[20];

                nResult = Module.MXP.SYS_GetEtherCATHistoryAlarm(out arrAlarmHistory);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Int32 nAlarmCount = 0;
                    String strAlarm = "";
                    Int32 nCurAlarmCount = 0;

                    for (nAlarmCount = 0; nAlarmCount < arrAlarmHistory.Length; nAlarmCount++)
                    {
                        if (arrAlarmHistory[nAlarmCount] != 0)
                        {
                            strAlarm = strAlarm + arrAlarmHistory[nAlarmCount].ToString() + "/n";
                            nCurAlarmCount++;
                        }
                    }

                    if (nCurAlarmCount == 0)
                        strAlarm = "AlarmCount = 0";

                    MessageBox.Show(strAlarm, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
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
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nSlaveCount = 0;

                nResult = Module.MXP.ECAT_GetSlaveCount(out nSlaveCount);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("SlaveCount=" + nSlaveCount.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                UInt32 nAxisCount = 0;

                nResult = Module.MXP.ECAT_GetAxisCount(out nAxisCount);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("AxisCount = " + nAxisCount.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                Boolean bPortState = false;

                nResult = Module.MXP.ECAT_GetMasterEtherCATLineStatus(out bPortState);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (bPortState == true)
                        MessageBox.Show("Master Link State: Connect", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    else
                        MessageBox.Show("Master Link State: Disconnect", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
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
                Boolean bSimulationMode = false;

                nResult = Module.MXP.SYS_GetMasterSimulationMode(out bSimulationMode);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Simulation Mode Check = " + bSimulationMode.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                MXP_EasyClass.MXP_ONLINE_STATE nSlaveState;
                UInt32 nSlaveNo = Convert.ToUInt32(txtSlaveNo.Text);

                nResult = Module.MXP.ECAT_GetSlaveCurrentState(nSlaveNo, out nSlaveState);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Slave ComState = " + nSlaveState.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                MXP_EasyClass.MXP_NODE_TYPE nSlaveNodeType;
                UInt32 nSlaveNo = Convert.ToUInt32(txtSlaveNo.Text);

                nResult = Module.MXP.ECAT_GetSlaveType(nSlaveNo, out nSlaveNodeType);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Slave NodeType = " + nSlaveNodeType.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                MXP_EasyClass.PORT_STATE stPortState = new MXP_EasyClass.PORT_STATE();
                UInt32 nSlaveNo = Convert.ToUInt32(txtSlaveNo.Text);

                nResult = Module.MXP.ECAT_GetSlaveEtherCATLineStatus(nSlaveNo, out stPortState);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Slave Link State \nPort1 : " + stPortState.Port1State.ToString() + "\nPort2 : " + stPortState.Port2State.ToString()
                        + "\nPort3 : " + stPortState.Port3State.ToString() + "\nPort4 : " + stPortState.Port4State.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                String strName = "";
                UInt32 nSlaveNo = Convert.ToUInt32(txtSlaveNo.Text);

                nResult = Module.MXP.ECAT_GetSlaveName(nSlaveNo, out strName);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Slave Name = " + strName, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnETMasterMode_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                MXP_EasyClass.EC_NETWORK_CMD nMode = (MXP_EasyClass.EC_NETWORK_CMD)Convert.ToInt32(txtSetMasterMode.Text);

                nResult = Module.MXP.ECAT_SetMasterOnlineMode(nMode);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Cmd Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnETSlaveMode_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                MXP_EasyClass.EC_NETWORK_CMD nMode = (MXP_EasyClass.EC_NETWORK_CMD)Convert.ToInt32(txtSetSlaveMode.Text);
                UInt32 nSlaveNo = Convert.ToUInt32(txtSlaveNo.Text);

                nResult = Module.MXP.ECAT_SetSlaveOnlineMode(nSlaveNo, nMode);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Cmd Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnETSlaveComReadyCheck_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nSlaveNo = Convert.ToUInt32(txtSlaveNo.Text);
                Boolean bReadyState = false;

                nResult = Module.MXP.ECAT_SlaveReadyCheck(nSlaveNo, out bReadyState);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Slave ReaedyState = " + bReadyState.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSysreset_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;

                nResult = Module.MXP.SYS_Reset();

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("MXP SystemReset Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnETEntireSlaveComReadyCheck_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                Boolean bReadyState = false;

                nResult = Module.MXP.ECAT_ReadyCheck(out bReadyState);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Entire Ready State = " + bReadyState.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLicenseCheck_Click(object sender, EventArgs e)
        {

            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                Boolean bLicenseCheckState = false;
                MXP_EasyClass.MXP_USERLib nLib = (MXP_EasyClass.MXP_USERLib)Convert.ToInt32(txtUserLib.Text);

                nResult = Module.MXP.SYS_CheckLicense(nLib, out bLicenseCheckState);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("LicenseCheck State =" + bLicenseCheckState.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
