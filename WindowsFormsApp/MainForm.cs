using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetworkingLibrary;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private bool AdvancedMode;

        public MainForm()
        {
            InitializeComponent();
            pnlBasicInterface.Hide();
            hideAdvancedFeatures();
            AdvancedMode = false;
            cmbBoxCommand1.Items.Add("Get");
            cmbBoxCommand1.Items.Add("Update");
            txtboxLocation1.Enabled = false;
            txtboxName1.Enabled = false;
        }

        private void showAdvancedFeatures()
        {
            txtboxPort.Show();
            lblProtocol.Show();
            radioButtonWhoIs.Show();
            radioButtonHttp0_9.Show();
            radioButtonHttp1_0.Show();
            radioButtonHttp1_1.Show();
        }

        private void hideAdvancedFeatures()
        {
            txtboxPort.Hide();
            lblProtocol.Hide();
            radioButtonWhoIs.Hide();
            radioButtonHttp0_9.Hide();
            radioButtonHttp1_0.Hide();
            radioButtonHttp1_1.Hide();
        }

        private void lblSelect_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBasic_Click(object sender, EventArgs e)
        {
            AdvancedMode = false;
            hideAdvancedFeatures();
            pnlBasicInterface.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (AdvancedMode == false)
            {
                if (cmbBoxCommand1.SelectedItem == "Get")
                {
                    string[] args = { "-h", txtboxAddress1.Text, txtboxName1.Text };
                    ClientClass.ExecuteClient(args);
                    richTextBox1.Text = ClientClass.serverResponseText;
                    txtboxLocation1.Text = ClientClass.location;
                }
                else //update
                {
                    string[] args = { "-h", txtboxAddress1.Text, txtboxName1.Text, txtboxLocation1.Text };
                    ClientClass.ExecuteClient(args);
                    richTextBox1.Text = ClientClass.serverResponseText;
                }
            }
            else
            {
                string protocol = "";
                if (radioButtonWhoIs.Checked == true) { protocol = "-w"; }
                if (radioButtonHttp0_9.Checked == true) { protocol = "-h9"; }
                if (radioButtonHttp1_0.Checked == true) { protocol = "-h0"; }
                if (radioButtonHttp1_1.Checked == true) { protocol = "-h1"; }

                if (cmbBoxCommand1.SelectedItem == "Get")
                {
                    string[] args = { "-h", txtboxAddress1.Text, txtboxName1.Text, protocol, "-p", txtboxPort.Text };
                    ClientClass.ExecuteClient(args);
                    richTextBox1.Text = ClientClass.serverResponseText;
                    txtboxLocation1.Text = ClientClass.location;
                }
                else //update
                {
                    string[] args = { "-h", txtboxAddress1.Text, txtboxName1.Text, txtboxLocation1.Text, protocol, "-p", txtboxPort.Text };
                    ClientClass.ExecuteClient(args);
                    richTextBox1.Text = ClientClass.serverResponseText;
                }
            }
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            pnlBasicInterface.Hide();
        }

        private void cmbBoxCommand1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxCommand1.SelectedItem == "Get")
            {
                txtboxName1.Enabled = true;
                txtboxLocation1.Text = "";
                txtboxLocation1.Enabled = false;

            }
            else if (cmbBoxCommand1.SelectedItem == "Update")
            {
                txtboxName1.Enabled = true;
                txtboxLocation1.Enabled = true;
            }
            else
            {
                txtboxName1.Enabled = false;
                txtboxLocation1.Enabled = false;
            }
        }

        private void btnExpert_Click(object sender, EventArgs e)
        {
            AdvancedMode = true;
            pnlBasicInterface.Show();
            showAdvancedFeatures();
        }
    }
}
