namespace WindowsFormsApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSelect = new System.Windows.Forms.Label();
            this.btnBasic = new System.Windows.Forms.Button();
            this.btnExpert = new System.Windows.Forms.Button();
            this.pnlModeSelect = new System.Windows.Forms.Panel();
            this.pnlBasicInterface = new System.Windows.Forms.Panel();
            this.btnBack1 = new System.Windows.Forms.Button();
            this.txtboxLocation1 = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtboxName1 = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.cmbBoxCommand1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtboxAddress1 = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblProtocol = new System.Windows.Forms.Label();
            this.radioButtonWhoIs = new System.Windows.Forms.RadioButton();
            this.radioButtonHttp0_9 = new System.Windows.Forms.RadioButton();
            this.radioButtonHttp1_0 = new System.Windows.Forms.RadioButton();
            this.radioButtonHttp1_1 = new System.Windows.Forms.RadioButton();
            this.txtboxPort = new System.Windows.Forms.TextBox();
            this.pnlModeSelect.SuspendLayout();
            this.pnlBasicInterface.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(239, 61);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(106, 20);
            this.lblSelect.TabIndex = 0;
            this.lblSelect.Text = "Select Mode: ";
            this.lblSelect.Click += new System.EventHandler(this.lblSelect_Click);
            // 
            // btnBasic
            // 
            this.btnBasic.Location = new System.Drawing.Point(214, 130);
            this.btnBasic.Name = "btnBasic";
            this.btnBasic.Size = new System.Drawing.Size(160, 60);
            this.btnBasic.TabIndex = 1;
            this.btnBasic.Text = "Basic";
            this.btnBasic.UseVisualStyleBackColor = true;
            this.btnBasic.Click += new System.EventHandler(this.btnBasic_Click);
            // 
            // btnExpert
            // 
            this.btnExpert.Location = new System.Drawing.Point(214, 226);
            this.btnExpert.Name = "btnExpert";
            this.btnExpert.Size = new System.Drawing.Size(160, 60);
            this.btnExpert.TabIndex = 2;
            this.btnExpert.Text = "Expert";
            this.btnExpert.UseVisualStyleBackColor = true;
            this.btnExpert.Click += new System.EventHandler(this.btnExpert_Click);
            // 
            // pnlModeSelect
            // 
            this.pnlModeSelect.Controls.Add(this.pnlBasicInterface);
            this.pnlModeSelect.Controls.Add(this.btnBasic);
            this.pnlModeSelect.Controls.Add(this.btnExpert);
            this.pnlModeSelect.Controls.Add(this.lblSelect);
            this.pnlModeSelect.Location = new System.Drawing.Point(1, -1);
            this.pnlModeSelect.Name = "pnlModeSelect";
            this.pnlModeSelect.Size = new System.Drawing.Size(597, 462);
            this.pnlModeSelect.TabIndex = 3;
            this.pnlModeSelect.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlBasicInterface
            // 
            this.pnlBasicInterface.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBasicInterface.Controls.Add(this.txtboxPort);
            this.pnlBasicInterface.Controls.Add(this.radioButtonHttp1_1);
            this.pnlBasicInterface.Controls.Add(this.radioButtonHttp1_0);
            this.pnlBasicInterface.Controls.Add(this.radioButtonHttp0_9);
            this.pnlBasicInterface.Controls.Add(this.radioButtonWhoIs);
            this.pnlBasicInterface.Controls.Add(this.lblProtocol);
            this.pnlBasicInterface.Controls.Add(this.btnBack1);
            this.pnlBasicInterface.Controls.Add(this.txtboxLocation1);
            this.pnlBasicInterface.Controls.Add(this.lblLocation);
            this.pnlBasicInterface.Controls.Add(this.txtboxName1);
            this.pnlBasicInterface.Controls.Add(this.lblName);
            this.pnlBasicInterface.Controls.Add(this.btnSend);
            this.pnlBasicInterface.Controls.Add(this.cmbBoxCommand1);
            this.pnlBasicInterface.Controls.Add(this.label1);
            this.pnlBasicInterface.Controls.Add(this.panel1);
            this.pnlBasicInterface.Controls.Add(this.txtboxAddress1);
            this.pnlBasicInterface.Controls.Add(this.lblAddress);
            this.pnlBasicInterface.Location = new System.Drawing.Point(0, 0);
            this.pnlBasicInterface.Name = "pnlBasicInterface";
            this.pnlBasicInterface.Size = new System.Drawing.Size(597, 459);
            this.pnlBasicInterface.TabIndex = 3;
            // 
            // btnBack1
            // 
            this.btnBack1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack1.Location = new System.Drawing.Point(11, 13);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(30, 28);
            this.btnBack1.TabIndex = 10;
            this.btnBack1.Text = "<";
            this.btnBack1.UseVisualStyleBackColor = true;
            this.btnBack1.Click += new System.EventHandler(this.btnBack1_Click);
            // 
            // txtboxLocation1
            // 
            this.txtboxLocation1.Location = new System.Drawing.Point(133, 213);
            this.txtboxLocation1.Name = "txtboxLocation1";
            this.txtboxLocation1.Size = new System.Drawing.Size(128, 20);
            this.txtboxLocation1.TabIndex = 9;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(57, 213);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(65, 18);
            this.lblLocation.TabIndex = 8;
            this.lblLocation.Text = "Location";
            // 
            // txtboxName1
            // 
            this.txtboxName1.Location = new System.Drawing.Point(133, 175);
            this.txtboxName1.Name = "txtboxName1";
            this.txtboxName1.Size = new System.Drawing.Size(128, 20);
            this.txtboxName1.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(71, 175);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 18);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(441, 184);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(106, 77);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // cmbBoxCommand1
            // 
            this.cmbBoxCommand1.FormattingEnabled = true;
            this.cmbBoxCommand1.Location = new System.Drawing.Point(134, 134);
            this.cmbBoxCommand1.Name = "cmbBoxCommand1";
            this.cmbBoxCommand1.Size = new System.Drawing.Size(128, 21);
            this.cmbBoxCommand1.TabIndex = 4;
            this.cmbBoxCommand1.Text = "Select Command";
            this.cmbBoxCommand1.SelectedIndexChanged += new System.EventHandler(this.cmbBoxCommand1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Command";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(0, 292);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 167);
            this.panel1.TabIndex = 2;
            // 
            // txtboxAddress1
            // 
            this.txtboxAddress1.Location = new System.Drawing.Point(133, 62);
            this.txtboxAddress1.Name = "txtboxAddress1";
            this.txtboxAddress1.Size = new System.Drawing.Size(353, 20);
            this.txtboxAddress1.TabIndex = 1;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(57, 61);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(62, 18);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox1.Location = new System.Drawing.Point(0, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(594, 161);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // lblProtocol
            // 
            this.lblProtocol.AutoSize = true;
            this.lblProtocol.Location = new System.Drawing.Point(57, 98);
            this.lblProtocol.Name = "lblProtocol";
            this.lblProtocol.Size = new System.Drawing.Size(49, 13);
            this.lblProtocol.TabIndex = 11;
            this.lblProtocol.Text = "Protocol:";
            // 
            // radioButtonWhoIs
            // 
            this.radioButtonWhoIs.AutoSize = true;
            this.radioButtonWhoIs.Checked = true;
            this.radioButtonWhoIs.Location = new System.Drawing.Point(146, 98);
            this.radioButtonWhoIs.Name = "radioButtonWhoIs";
            this.radioButtonWhoIs.Size = new System.Drawing.Size(62, 17);
            this.radioButtonWhoIs.TabIndex = 16;
            this.radioButtonWhoIs.TabStop = true;
            this.radioButtonWhoIs.Text = "WHOIS";
            this.radioButtonWhoIs.UseVisualStyleBackColor = true;
            // 
            // radioButtonHttp0_9
            // 
            this.radioButtonHttp0_9.AutoSize = true;
            this.radioButtonHttp0_9.Location = new System.Drawing.Point(230, 98);
            this.radioButtonHttp0_9.Name = "radioButtonHttp0_9";
            this.radioButtonHttp0_9.Size = new System.Drawing.Size(74, 17);
            this.radioButtonHttp0_9.TabIndex = 17;
            this.radioButtonHttp0_9.TabStop = true;
            this.radioButtonHttp0_9.Text = "HTTP/0.9";
            this.radioButtonHttp0_9.UseVisualStyleBackColor = true;
            // 
            // radioButtonHttp1_0
            // 
            this.radioButtonHttp1_0.AutoSize = true;
            this.radioButtonHttp1_0.Location = new System.Drawing.Point(320, 98);
            this.radioButtonHttp1_0.Name = "radioButtonHttp1_0";
            this.radioButtonHttp1_0.Size = new System.Drawing.Size(74, 17);
            this.radioButtonHttp1_0.TabIndex = 18;
            this.radioButtonHttp1_0.TabStop = true;
            this.radioButtonHttp1_0.Text = "HTTP/1.0";
            this.radioButtonHttp1_0.UseVisualStyleBackColor = true;
            // 
            // radioButtonHttp1_1
            // 
            this.radioButtonHttp1_1.AutoSize = true;
            this.radioButtonHttp1_1.Location = new System.Drawing.Point(412, 98);
            this.radioButtonHttp1_1.Name = "radioButtonHttp1_1";
            this.radioButtonHttp1_1.Size = new System.Drawing.Size(74, 17);
            this.radioButtonHttp1_1.TabIndex = 19;
            this.radioButtonHttp1_1.TabStop = true;
            this.radioButtonHttp1_1.Text = "HTTP/1.1";
            this.radioButtonHttp1_1.UseVisualStyleBackColor = true;
            // 
            // txtboxPort
            // 
            this.txtboxPort.Location = new System.Drawing.Point(510, 62);
            this.txtboxPort.Name = "txtboxPort";
            this.txtboxPort.Size = new System.Drawing.Size(73, 20);
            this.txtboxPort.TabIndex = 20;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 456);
            this.Controls.Add(this.pnlModeSelect);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlModeSelect.ResumeLayout(false);
            this.pnlModeSelect.PerformLayout();
            this.pnlBasicInterface.ResumeLayout(false);
            this.pnlBasicInterface.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Button btnBasic;
        private System.Windows.Forms.Button btnExpert;
        private System.Windows.Forms.Panel pnlModeSelect;
        private System.Windows.Forms.Panel pnlBasicInterface;
        private System.Windows.Forms.TextBox txtboxLocation1;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtboxName1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ComboBox cmbBoxCommand1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtboxAddress1;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnBack1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtboxPort;
        private System.Windows.Forms.RadioButton radioButtonHttp1_1;
        private System.Windows.Forms.RadioButton radioButtonHttp1_0;
        private System.Windows.Forms.RadioButton radioButtonHttp0_9;
        private System.Windows.Forms.RadioButton radioButtonWhoIs;
        private System.Windows.Forms.Label lblProtocol;
    }
}

