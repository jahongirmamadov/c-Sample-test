using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using MXPEasyClass;

namespace AdvancedSample
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }
        public static Form_COM COM = new Form_COM();

        private void button3_Click(object sender, EventArgs e)
        {
            Single_Motion_example nForm = new Single_Motion_example(this);
            nForm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistryKey reg = Registry.LocalMachine;
            reg = reg.OpenSubKey(@"SOFTWARE\WOW6432Node\LS Mecapion", true);

            if (reg != null)
            {
                Object val = reg.GetValue("MXP3DataPath");
                if (val != null)
                {
                    String installPath = val.ToString().Replace("MXP_Data","") + @"ExAPI\Manual\ExAPI.htm";                   

                    System.Diagnostics.Process.Start(installPath);        
                }
                else
                    MessageBox.Show("MXP3 Install Path is not Exist.");
            }
            else
                MessageBox.Show("MXP3 Install Path is not Exist.");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_System nForm = new Form_System(this);
            nForm.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Single_Motion_example nForm = new Single_Motion_example(this);
            nForm.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Group nForm = new Form_Group(this);
            nForm.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Monitoring nForm = new Form_Monitoring(this);
            nForm.Show();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Parameter nForm = new Form_Parameter(this);
            nForm.Show();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_PDO_ETParam nForm = new Form_PDO_ETParam(this);
            nForm.Show();
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_PLCInterface nForm = new Form_PLCInterface(this);
            nForm.Show();
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Gear nForm = new Form_Gear(this);
            nForm.Show();
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_CAM nForm = new Form_CAM(this);
            nForm.Show();
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_TouchProb nForm = new Form_TouchProb(this);
            nForm.Show();
        }

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_ProfileMove nForm = new Form_ProfileMove(this);
            nForm.Show();
        }

        private void linkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_DirectCommand nForm = new Form_DirectCommand(this);
            nForm.Show();
        }

        private void linkLabel15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_UnitChange nForm = new Form_UnitChange(this);
            nForm.Show();
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_IO nForm = new Form_IO(this);
            nForm.Show();
        }

        private void linkLabel16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_MultiCCC nForm = new Form_MultiCCC(this);
            nForm.Show();
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Module.MXP.SYS_Stop();
        }

        private void linkLabel17_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_SpinMove nForm = new Form_SpinMove(this);
            nForm.Show();
        }
    }
}
