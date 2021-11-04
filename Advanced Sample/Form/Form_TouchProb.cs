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
    public partial class Form_TouchProb : Form
    {
        public Form_TouchProb()
        {
            InitializeComponent();
        }

        Form_Main frm1;

        public Form_TouchProb(Form_Main _form)
        {
            InitializeComponent();
            frm1 = _form;
        }

        private void btnTouchprob1Set_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult = new MXP_EasyClass.MXP_FUNCTION_STATUS();
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                MXP_EasyClass.MXP_TRIGGER_MODE nTriggerMode = (MXP_EasyClass.MXP_TRIGGER_MODE)Convert.ToUInt32(txtMode.Text);
                MXP_EasyClass.MXP_TRIGGER_TYPE nTriggerType = (MXP_EasyClass.MXP_TRIGGER_TYPE)Convert.ToUInt32(txtType.Text);
                MXP_EasyClass.MXP_TRIGGER_EDGE nTriggerEdge = (MXP_EasyClass.MXP_TRIGGER_EDGE)Convert.ToUInt32(txtEdge.Text);

                if (nTriggerMode == MXP_EasyClass.MXP_TRIGGER_MODE.e_Single)
                    nResult = Module.MXP.AX_TouchProbe1SingleModeReSet(nAxisNo);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    System.Threading.Thread.Sleep(4);

                    nResult = Module.MXP.AX_TouchProbe1Set(nAxisNo, nTriggerMode, nTriggerType, nTriggerEdge);

                    if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                        MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("MXP Cmd Set Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
                
        }

        private void btnTouchprob1State_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                MXP_EasyClass.strTouchprobeState nTouchProbState = new MXP_EasyClass.strTouchprobeState();

                nResult = Module.MXP.AX_TouchProbe1ReadState(nAxisNo, out nTouchProbState);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    String strMessage = "";
                    strMessage = "Rising Edge Update State = " + nTouchProbState.TouchprobeRisingPositionUpdate.ToString();
                    strMessage = strMessage + ", Falling Edge Update State = " + nTouchProbState.TouchprobeFallingPositionUpdate.ToString();
                    MessageBox.Show(strMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
                
        }

        private void btnTouchProbPosition_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                MXP_EasyClass.MXP_TRIGGER_EDGE nTouchProbCheckEdge = (MXP_EasyClass.MXP_TRIGGER_EDGE)Convert.ToUInt32(txtEdge.Text);
                MXP_EasyClass.TouchProbeReadPos_Reply stPosition = new MXP_EasyClass.TouchProbeReadPos_Reply();

                nResult = Module.MXP.AX_TouchProbe1ReadPosition(nAxisNo, nTouchProbCheckEdge, out stPosition);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    String strMessage = "";
                    strMessage = "EdgePositive = " + stPosition.EdgePositivePosition.ToString();
                    strMessage = strMessage + " , EdgeNegaitive = " + stPosition.EdgeNegativePosition.ToString();
                    MessageBox.Show(strMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private UInt16 nTaskPos = 0;
        static UInt32 nAxisNo = 0;
        static MXP_EasyClass.MXP_TRIGGER_MODE nTriggerMode = new MXP_EasyClass.MXP_TRIGGER_MODE();
        static MXP_EasyClass.MXP_TRIGGER_TYPE nTriggerType = new MXP_EasyClass.MXP_TRIGGER_TYPE();
        static MXP_EasyClass.MXP_TRIGGER_EDGE nTriggerEdge = new MXP_EasyClass.MXP_TRIGGER_EDGE();
        static Boolean bStartRigingUpdateState = false, bStartFallingUpdateState = false;
        static MXP_EasyClass.TouchProbeReadPos_Reply stPosition = new MXP_EasyClass.TouchProbeReadPos_Reply();

        private void TimerTouch_Tick(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.strTouchprobeState stTouchProbState = new MXP_EasyClass.strTouchprobeState();
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult = new MXP_EasyClass.MXP_FUNCTION_STATUS();

                switch (nTaskPos)
                {
                    case 0:
                        nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                        nTriggerMode = (MXP_EasyClass.MXP_TRIGGER_MODE)Convert.ToInt32(txtMode.Text);
                        nTriggerType = (MXP_EasyClass.MXP_TRIGGER_TYPE)Convert.ToInt32(txtType.Text);
                        nTriggerEdge = (MXP_EasyClass.MXP_TRIGGER_EDGE)Convert.ToInt32(txtEdge.Text);

                        if (nTriggerMode == MXP_EasyClass.MXP_TRIGGER_MODE.e_Single)
                        {
                            nResult = Module.MXP.AX_TouchProbe1SingleModeReSet(nAxisNo);
                            nTaskPos = 10;
                        }
                        else
                            nTaskPos = 10;

                        break;

                    case 10:

                        nResult = Module.MXP.AX_TouchProbe1ReadState(nAxisNo, out stTouchProbState);

                        if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                            nTaskPos = 800;
                        else
                        {
                            bStartRigingUpdateState = stTouchProbState.TouchprobeRisingPositionUpdate;
                            bStartFallingUpdateState = stTouchProbState.TouchprobeFallingPositionUpdate;

                            nResult = Module.MXP.AX_TouchProbe1Set(nAxisNo, nTriggerMode, nTriggerType, nTriggerEdge);

                            if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                                nTaskPos = 800;
                            else
                                nTaskPos = 20;
                        }

                        break;

                    case 20:
                        nResult = Module.MXP.AX_TouchProbe1ReadState(nAxisNo, out stTouchProbState);

                        if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                            nTaskPos = 800;
                        else
                        {
                            Boolean bCheckFlag = false;

                            if (bStartRigingUpdateState != stTouchProbState.TouchprobeRisingPositionUpdate)
                                bCheckFlag = true;
                            if (bStartFallingUpdateState != stTouchProbState.TouchprobeFallingPositionUpdate)
                                bCheckFlag = true;

                            if (bCheckFlag)
                            {
                                nResult = Module.MXP.AX_TouchProbe1ReadPosition(nAxisNo, nTriggerEdge, out stPosition);

                                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                                    nTaskPos = 800;
                                else
                                    nTaskPos = 1000;
                            }
                        }

                        break;

                    case 800:
                        nTaskPos = 0;
                        TimerTouch.Enabled = false;
                        MessageBox.Show("TouchProbCheck  Fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                    case 1000:
                        nTaskPos = 0;
                        TimerTouch.Enabled = false;
                        String strMessage;
                        strMessage = "EdgePositive = " + stPosition.EdgePositivePosition.ToString();
                        strMessage = strMessage + "\nEdgeNegative = " + stPosition.EdgeNegativePosition.ToString();
                        MessageBox.Show(strMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception ex)
            {
                nTaskPos = 0;
                TimerTouch.Enabled = false;
                MessageBox.Show(ex.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TimerTouch.Enabled = true;
            nTaskPos = 0;
        }
    }
}
