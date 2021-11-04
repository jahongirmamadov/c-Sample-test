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
    public partial class Form_COM : Form
    {
        public Form_COM()
        {
            InitializeComponent();
        }

        private Int16 nMonitoringStep = 0;
        private UInt32 nWaitCount = 0;
        private UInt32 nGroupNo = 0;
        private Boolean bGroupSet = false;
        private UInt32[] arrDisplayAxis = new UInt32[0];
        private Boolean[] arrSelectedAxis = new Boolean[0];

        public void FormShow(Int32 nAxisCount, UInt32[] arrAxisNo)
        {
            try
            {
                nMonitoringStep = 0;
                TimerMonitoring.Enabled = true;

                Array.Resize(ref arrDisplayAxis, nAxisCount);
                Array.Resize(ref arrSelectedAxis, nAxisCount);

                Array.Copy(arrAxisNo, arrDisplayAxis, nAxisCount);

                GridInit();
                bGroupSet = false;
                JogGroup.Enabled = true;

                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        public void FormShow(Int32 nAxisCount, UInt32 nAxisNo)
        {
            try
            {
                nMonitoringStep = 0;
                TimerMonitoring.Enabled = true;

                Array.Resize(ref arrDisplayAxis, nAxisCount);
                Array.Resize(ref arrSelectedAxis, nAxisCount);

                arrDisplayAxis[0] = nAxisNo;
                arrSelectedAxis[0] = true;

                GridInit();
                bGroupSet = false;
                JogGroup.Enabled = true;

                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        public void FormGroupShow(UInt32 nGroup)
        {
            try
            {
                nMonitoringStep = 0;
                TimerMonitoring.Enabled = true;
                bGroupSet = true;
                nGroupNo = nGroup;
                JogGroup.Enabled = false;

                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void GridInit()
        {
            try
            {
                Int32 nRowCount, nColCount;
                Int32 nTotalRowCount = 0;

                GridState.Rows.Clear();           
                GridState.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                for (nRowCount = 0; nRowCount < arrDisplayAxis.Length; nRowCount++)
                {
                    if (nRowCount != 0)
                        GridState.Rows.Add();

                    Int32 nLastCount = arrDisplayAxis.Length-1;
                    GridState.Rows[nTotalRowCount].HeaderCell.Value = Convert.ToString(arrDisplayAxis[nLastCount - nRowCount]);

                    for (nColCount = 0; nColCount < GridState.ColumnCount; nColCount++)
                    {
                        GridState.Rows[nRowCount].Cells[nColCount].Value = "0";
                    }
                }

                for (nRowCount = 0; nRowCount < arrDisplayAxis.Length; nRowCount++ )
                {
                    GridState.Rows[nRowCount].HeaderCell.Value = Convert.ToString(arrDisplayAxis[nRowCount]);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AxisStateRefresh()
        {
            try
            {
                Int32 nRowCount = 0;
                MXP_EasyClass.MXP_AxisStateBit stAxisState = new MXP_EasyClass.MXP_AxisStateBit();
                String strDisplay = "";
                Single fReadData = 0;

                MXP_EasyClass.AXIS_ERROR stAxisError = new MXP_EasyClass.AXIS_ERROR();

                for (nRowCount = 0; nRowCount < arrDisplayAxis.Length; nRowCount++)
                {
                    Module.MXP.AX_ReadStatus(arrDisplayAxis[nRowCount], out stAxisState);

                    strDisplay = (stAxisState.Disabled == true ? "Off" : "On");
                    GridState.Rows[nRowCount].Cells[0].Value = strDisplay;

                    if (stAxisState.ErrorStop == true)
                        strDisplay = "ErrorStop";
                    else if (stAxisState.Disabled == true)
                        strDisplay = "Disable";
                    else if (stAxisState.Stopping == true)
                        strDisplay = "Stopping";
                    else if (stAxisState.DiscreteMotion == true)
                        strDisplay = "DiscreteMotion";
                    else if (stAxisState.ContinuousMotion == true)
                        strDisplay = "ContinuousMotion";
                    else if (stAxisState.SynchronizedMotion == true)
                        strDisplay = "SynchronizedMotion";
                    else if (stAxisState.Homing == true)
                        strDisplay = "Homing";
                    else if (stAxisState.Standstill == true)
                        strDisplay = "Standstill";

                    GridState.Rows[nRowCount].Cells[1].Value = strDisplay;

                    strDisplay = "Home : " + (stAxisState.HomeAbsSwitch ? "1" : "0");
                    strDisplay = strDisplay + "\n-Limit : " + (stAxisState.HWLimitSwitchNegEvent ? "1" : "0");
                    strDisplay = strDisplay + "\n+Limit : " + (stAxisState.HWLimitSwitchPosEvent ? "1" : "0");

                    GridState.Rows[nRowCount].Cells[2].Value = strDisplay;

                    Module.MXP.AX_ReadActualPosition(arrDisplayAxis[nRowCount], out fReadData);
                    strDisplay = String.Format("{0:0.##}", fReadData);
                    GridState.Rows[nRowCount].Cells[3].Value = strDisplay;

                    Module.MXP.AX_ReadActualVelocity(arrDisplayAxis[nRowCount], out fReadData);
                    strDisplay = String.Format("{0:0.##}", fReadData);
                    GridState.Rows[nRowCount].Cells[4].Value = strDisplay;

                    Module.MXP.AX_ReadActualTorque(arrDisplayAxis[nRowCount], out fReadData);
                    strDisplay = String.Format("{0:0.##}", fReadData);
                    GridState.Rows[nRowCount].Cells[5].Value = strDisplay;

                    Module.MXP.AX_ReadCommandPosition(arrDisplayAxis[nRowCount], out fReadData);
                    strDisplay = String.Format("{0:0.##}", fReadData);
                    GridState.Rows[nRowCount].Cells[6].Value = strDisplay;

                    Module.MXP.AX_ReadCommandVelocity(arrDisplayAxis[nRowCount], out fReadData);
                    strDisplay = String.Format("{0:0.##}", fReadData);
                    GridState.Rows[nRowCount].Cells[7].Value = strDisplay;

                    Module.MXP.AX_ReadError(arrDisplayAxis[nRowCount], out stAxisError);
                    strDisplay = stAxisError.MXPError.ToString();
                    GridState.Rows[nRowCount].Cells[8].Value = strDisplay;

                    strDisplay = stAxisError.DriveError.ToString();
                    GridState.Rows[nRowCount].Cells[9].Value = strDisplay;
                }
            }
            catch(Exception ex)  
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TimerMonitoring_Tick(object sender, EventArgs e)
        {
            MXP_EasyClass.MXP_FUNCTION_STATUS nResult = 0;
            MXP_EasyClass.KERNEL_STATUS nState;

            
            switch (nMonitoringStep)
            {
                case 0: //SystemState Check 
                    nResult = Module.MXP.SYS_GetStatus(out nState);
                    if (nState < MXP_EasyClass.KERNEL_STATUS.SYSTEM_IDLE)
                        nMonitoringStep = 10;
                    else if (nState < MXP_EasyClass.KERNEL_STATUS.SYSTEM_READY)
                    {
                        nResult = Module.MXP.SYS_Stop();
                        nMonitoringStep = 10;
                    }
                    else if (nState >= MXP_EasyClass.KERNEL_STATUS.SYSTEM_READY)
                        nMonitoringStep = 20;                        
                    break;

                case 10: //System Init
                    nResult = Module.MXP.SYS_Init();
                    nMonitoringStep = 20;
                    break;

                case 20: //Get init state
                    nResult = Module.MXP.SYS_GetStatus(out nState);
                    if (nState >= MXP_EasyClass.KERNEL_STATUS.SYSTEM_READY)
                    {
                        nResult = Module.MXP.SYS_Run();
                        nMonitoringStep = 30;
                    }                        
                    else
                        nMonitoringStep = 800;
                    break;
                case 30: //Get run state
                    nWaitCount = 0;
                    nMonitoringStep = 40;
                    break;
                case 40: //Check run state timeout
                    if (nWaitCount > 3)
                    {
                        nResult = Module.MXP.SYS_GetStatus(out nState);
                        if (nState == MXP_EasyClass.KERNEL_STATUS.SYSTEM_RUN)
                        {
                            lblState.BackColor = Color.LightGreen;
                            nMonitoringStep = 100;
                        }
                        else if (nState < MXP_EasyClass.KERNEL_STATUS.SYSTEM_READY)
                            nMonitoringStep = 800;
                    }
                    else
                        nWaitCount = nWaitCount + 1;
                    break;
                case 100: //Check group set 
                    MXP_EasyClass.MXP_ONLINE_STATE nOnlineMode = 0;

                    nResult = Module.MXP.SYS_GetStatus(out nState);
                    nResult = Module.MXP.ECAT_GetMasterOnlineMode(out nOnlineMode);

                    if (nState == MXP_EasyClass.KERNEL_STATUS.SYSTEM_RUN)
                    {
                        if (bGroupSet == false)
                            nMonitoringStep = 200;
                        else
                            nMonitoringStep = 110;
                    }
                    else
                        nMonitoringStep = 800;     
                    break;

                case 110: //Get Group info
                    Int32[] arrGroupAxisInfo = { -1,-1,-1,-1,-1,-1,-1,-1};
                    UInt32[] arrAxis = new UInt32[arrGroupAxisInfo.Length];

                    nResult = Module.MXP.GRP_GetGroupAxis(nGroupNo, out arrGroupAxisInfo);

                    if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                        nMonitoringStep = 800;
                    else
                    {
                        Int32 nAxisCount;
                        Int32 nCount = -1;

                        for (nAxisCount = 0; nAxisCount < arrGroupAxisInfo.Length; nAxisCount++)
                        {
                            if (arrGroupAxisInfo[nAxisCount] != -1)
                            {
                                nCount++;
                                Array.Resize(ref arrAxis, nCount + 1);
                                arrAxis[nCount] = (UInt32)arrGroupAxisInfo[nAxisCount];
                            }
                        }

                        if (nCount < 0)
                        {
                            GridState.Rows.Clear();
                            nMonitoringStep = 800;
                        }
                        else
                        {
                            Array.Resize(ref arrDisplayAxis, arrAxis.Length);
                            Array.Resize(ref arrSelectedAxis, arrAxis.Length);

                            arrDisplayAxis = arrAxis;
                            GridInit();
                            nMonitoringStep = 200;
                        }
                    }
                    break;

                case 200: //Display current state 
                    AxisStateRefresh();
                    break;

                case 800: //Not running
                    lblState.BackColor = Color.Gray;
                    nMonitoringStep = 0;
                    TimerMonitoring.Enabled = false;
                    break;

                case 1000:
                    break;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                TimerMonitoring.Enabled = false;

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult = MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR;
                UInt32 nAxisNo;

                for (Int32 nRowCount = 0; nRowCount < GridState.RowCount; nRowCount++)
                {
                    if (arrSelectedAxis[nRowCount])
                    {
                        nAxisNo = arrDisplayAxis[nRowCount];
                        nResult = Module.MXP.AX_Power(nAxisNo, true);
                    }                
                }

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult = MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR;
                UInt32 nAxisNo;

                for (Int32 nRowCount = 0; nRowCount < GridState.RowCount; nRowCount++)
                {
                    if (arrSelectedAxis[nRowCount])
                    {
                        nAxisNo = arrDisplayAxis[nRowCount];
                        nResult = Module.MXP.AX_Power(nAxisNo, false);
                    }
                }

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult = new MXP_EasyClass.MXP_FUNCTION_STATUS();
                UInt32 nAxisNo;
                Single fdec = 1000;
                Single fJerk = 10000;

                if (bGroupSet == true)
                    nResult = Module.MXP.GRP_Stop(nGroupNo, true, fdec, fJerk);
                else
                {
                    for (Int32 nRowCount = 0; nRowCount < GridState.RowCount; nRowCount++)
                    {
                        if (arrSelectedAxis[nRowCount])
                        {
                            nAxisNo = arrDisplayAxis[nRowCount];
                            nResult = Module.MXP.AX_Halt(nAxisNo, fdec, fJerk);
                        }                        
                    }
                }

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult = MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR;
                UInt32 nAxisNo;

                for (Int32 nRowCount = 0; nRowCount < GridState.RowCount; nRowCount++)
                {
                    if (arrSelectedAxis[nRowCount])
                    {
                        nAxisNo = arrDisplayAxis[nRowCount];
                        nResult = Module.MXP.AX_Reset(nAxisNo);
                    }
                }

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult = MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR;
                UInt32 nAxisNo;

                for (Int32 nRowCount = 0; nRowCount < GridState.RowCount; nRowCount++)
                {
                    if (arrSelectedAxis[nRowCount])
                    {
                        nAxisNo = arrDisplayAxis[nRowCount];
                        nResult = Module.MXP.AX_Home(nAxisNo);
                    }
                }

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnMJog_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult = new MXP_EasyClass.MXP_FUNCTION_STATUS();
                UInt32 nAxisNo = arrDisplayAxis[0];
                Single fVel = Convert.ToSingle(txtVelocity.Text);
                Single fAcc = Convert.ToSingle(txtAcc.Text);
                Single fDec = Convert.ToSingle(txtDec.Text);
                Single fJerk = Convert.ToSingle(txtJerk.Text);

                for (int nRowCount = 0; nRowCount < GridState.RowCount; nRowCount++)
                {
                    if (arrSelectedAxis[nRowCount])
                    {
                        nAxisNo = arrDisplayAxis[nRowCount];

                        nResult = Module.MXP.AX_MoveVelocity(nAxisNo, fVel, fAcc, fDec, fJerk, MXP_EasyClass.MXP_DIRECTION_ENUM.MXP_NEGATIVE_DIRECTION,
                                              MXP_EasyClass.MXP_BUFFERMODE_ENUM.MXP_ABORTING);
                    }
                }                    

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

        private void btnPJog_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult = new MXP_EasyClass.MXP_FUNCTION_STATUS();
                UInt32 nAxisNo = arrDisplayAxis[0];
                Single fVel = Convert.ToSingle(txtVelocity.Text);
                Single fAcc = Convert.ToSingle(txtAcc.Text);
                Single fDec = Convert.ToSingle(txtDec.Text);
                Single fJerk = Convert.ToSingle(txtJerk.Text);

                for (int nRowCount = 0; nRowCount < GridState.RowCount; nRowCount++)
                {
                    if (arrSelectedAxis[nRowCount])
                    {
                        nAxisNo = arrDisplayAxis[nRowCount];

                        nResult = Module.MXP.AX_MoveVelocity(nAxisNo, fVel, fAcc, fDec, fJerk, MXP_EasyClass.MXP_DIRECTION_ENUM.MXP_POSITIVE_DIRECTION,
                                          MXP_EasyClass.MXP_BUFFERMODE_ENUM.MXP_ABORTING);
                    }
                }                        

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

        #region Axis Select

        private Color cSelectedColor = Color.Aqua;
        private Color cDeSelectedColor = Color.White;

        private void GridState_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 nGridIndex = e.RowIndex;

            arrSelectedAxis[nGridIndex] = !arrSelectedAxis[nGridIndex];

            if (arrSelectedAxis[nGridIndex])
                GridState.Rows[nGridIndex].DefaultCellStyle.BackColor = cSelectedColor;
            else
                GridState.Rows[nGridIndex].DefaultCellStyle.BackColor = cDeSelectedColor;
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            for (int nRowCount = 0; nRowCount < GridState.RowCount; nRowCount++)
            {
                arrSelectedAxis[nRowCount] = true;
                GridState.Rows[nRowCount].DefaultCellStyle.BackColor = cSelectedColor;
            }
        }

        private void btnDeselect_Click(object sender, EventArgs e)
        {
            for (int nRowCount = 0; nRowCount < GridState.RowCount; nRowCount++)
            {
                arrSelectedAxis[nRowCount] = false;
                GridState.Rows[nRowCount].DefaultCellStyle.BackColor = cDeSelectedColor;
            }
        }
        #endregion

        private void btnABSMove_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult = MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR;
                UInt32 nAxisNo = arrDisplayAxis[0];
                Single fPosition = Convert.ToSingle(txtPosition.Text);
                Single fVel = Convert.ToSingle(txtVelocity.Text);
                Single fAcc = Convert.ToSingle(txtAcc.Text);
                Single fdec = Convert.ToSingle(txtDec.Text);
                Single fJerk = Convert.ToSingle(txtJerk.Text);

                for (int nRowCount = 0; nRowCount < GridState.RowCount; nRowCount++)
                {
                    if (arrSelectedAxis[nRowCount])
                    {
                        nAxisNo = arrDisplayAxis[nRowCount];

                        nResult = Module.MXP.AX_MoveAbsolute(nAxisNo, fPosition, fVel, fAcc, fdec, fJerk,
                            MXP_EasyClass.MXP_DIRECTION_ENUM.MXP_NONE_DIRECTION, MXP_EasyClass.MXP_BUFFERMODE_ENUM.MXP_ABORTING);
                    }
                }     

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

        private void btnRelativeMove_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult = MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR;
                UInt32 nAxisNo = arrDisplayAxis[0];
                Single nDistance = Convert.ToSingle(txtPosition.Text);
                Single fVel = Convert.ToSingle(txtVelocity.Text);
                Single fAcc = Convert.ToSingle(txtAcc.Text);
                Single fdec = Convert.ToSingle(txtDec.Text);
                Single fJerk = Convert.ToSingle(txtJerk.Text);

                for (int nRowCount = 0; nRowCount < GridState.RowCount; nRowCount++)
                {
                    if (arrSelectedAxis[nRowCount])
                    {
                        nAxisNo = arrDisplayAxis[nRowCount];

                        nResult = Module.MXP.AX_MoveRelative(nAxisNo, nDistance, fVel, fAcc, fdec, fJerk,
                            MXP_EasyClass.MXP_BUFFERMODE_ENUM.MXP_ABORTING);
                    }
                }

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
    }
}
