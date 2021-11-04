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
    public partial class Form_ProfileMove : Form
    {
        public Form_ProfileMove()
        {
            InitializeComponent();
        }

        Form_Main frm1;

        public Form_ProfileMove(Form_Main _form)
        {
            InitializeComponent();
            frm1 = _form;
        }

        private void btnProfileMove_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                MXP_EasyClass.MXP_FILE_TABLE_ARRAY_IN stTable = new MXP_EasyClass.MXP_FILE_TABLE_ARRAY_IN();
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                UInt16 nRepeatCount = Convert.ToUInt16(txtRepeat.Text);
                UInt16 nReverseMode = Convert.ToUInt16(txtReverseMode.Text);

                Array.Resize(ref stTable.stData.FileTable, 4);

                stTable.stData.FileTable[0].TableindexNo = 0;
                stTable.stData.FileTable[0].Position = Convert.ToSingle(txtS1Pos.Text);
                stTable.stData.FileTable[0].Velocity = Convert.ToSingle(txtS1Vel.Text);

                stTable.stData.FileTable[1].TableindexNo = 1;
                stTable.stData.FileTable[1].Position = Convert.ToSingle(txtS2Pos.Text);
                stTable.stData.FileTable[1].Velocity = Convert.ToSingle(txtS2Vel.Text);

                stTable.stData.FileTable[2].TableindexNo = 2;
                stTable.stData.FileTable[2].Position = Convert.ToSingle(txtS3Pos.Text);
                stTable.stData.FileTable[2].Velocity = Convert.ToSingle(txtS3Vel.Text);

                stTable.stData.FileTable[3].TableindexNo = 3;
                stTable.stData.FileTable[3].Position = Convert.ToSingle(txtS4Pos.Text);
                stTable.stData.FileTable[3].Velocity = Convert.ToSingle(txtS4Vel.Text);

                UInt32 nMoveCount = 0;
                MXP_EasyClass.MXP_PROFILE_TABLE_ARRAY_IN stMotionTable = new MXP_EasyClass.MXP_PROFILE_TABLE_ARRAY_IN();
                MXP_EasyClass.MXP_IO_TABLE_ARRAY_IN stIOTable = new MXP_EasyClass.MXP_IO_TABLE_ARRAY_IN();

                nResult = Module.MXP.AX_GetProfileTable(stTable, 5, out stMotionTable);

                nMoveCount = stMotionTable.stData.DataSize;

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    nResult = Module.MXP.AX_ProfileMove(nAxisNo, nMoveCount, 0, nRepeatCount, 0, 0, nReverseMode, stMotionTable, stIOTable);
                    MessageBox.Show("MXP Cmd Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
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
                Form_Main.COM.FormShow(1, Convert.ToUInt32(txtAxisNo.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnProfileMoveCheck_Click(object sender, EventArgs e)
        {
            try
            {
                MXP_EasyClass.MXP_FUNCTION_STATUS nResult;
                UInt32 nAxisNo = Convert.ToUInt32(txtAxisNo.Text);
                MXP_EasyClass.PROCESS_CHECK stState = new MXP_EasyClass.PROCESS_CHECK();

                nResult = Module.MXP.AX_ProfileMoveCheck(nAxisNo, out stState);

                if (nResult != MXP_EasyClass.MXP_FUNCTION_STATUS.RET_NO_ERROR)
                    MessageBox.Show("Fail Error = " + nResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    String strState = "";
                    if (stState.ErrorOn == true)
                        strState = "Error = " + stState.ErrorID.ToString();
                    else if (stState.Done == true)
                        strState = "Done";
                    else if (stState.Busy == true)
                        strState = "Active";

                    MessageBox.Show("ProfileMove Result = " + strState, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
        
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
