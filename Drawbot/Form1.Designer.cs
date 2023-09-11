namespace Drawbot
{
    partial class Drawbot
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Drawbot));
            this.portname = new System.Windows.Forms.ComboBox();
            this.connectbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.disconnectbutton = new System.Windows.Forms.Button();
            this.yminusButton = new System.Windows.Forms.Button();
            this.yplusButton = new System.Windows.Forms.Button();
            this.xplusButton = new System.Windows.Forms.Button();
            this.xminusButton = new System.Windows.Forms.Button();
            this.controlgroup = new System.Windows.Forms.GroupBox();
            this.inputfile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.browsebutton = new System.Windows.Forms.Button();
            this.pengroup = new System.Windows.Forms.GroupBox();
            this.pendropbutton = new System.Windows.Forms.Button();
            this.penliftbutton = new System.Windows.Forms.Button();
            this.inputfilegroup = new System.Windows.Forms.GroupBox();
            this.gohomebutton = new System.Windows.Forms.Button();
            this.serialscreen = new System.Windows.Forms.ListBox();
            this.sentrows = new System.Windows.Forms.Label();
            this.RowsInFile = new System.Windows.Forms.Label();
            this.startbutton = new System.Windows.Forms.Button();
            this.stopbutton = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.ClearButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.PauseButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.controlgroup.SuspendLayout();
            this.pengroup.SuspendLayout();
            this.inputfilegroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // portname
            // 
            this.portname.FormattingEnabled = true;
            this.portname.Location = new System.Drawing.Point(24, 26);
            this.portname.Name = "portname";
            this.portname.Size = new System.Drawing.Size(75, 22);
            this.portname.TabIndex = 0;
            // 
            // connectbutton
            // 
            this.connectbutton.Location = new System.Drawing.Point(119, 20);
            this.connectbutton.Name = "connectbutton";
            this.connectbutton.Size = new System.Drawing.Size(75, 25);
            this.connectbutton.TabIndex = 1;
            this.connectbutton.Text = "Connect";
            this.connectbutton.UseVisualStyleBackColor = true;
            this.connectbutton.Click += new System.EventHandler(this.connectbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.disconnectbutton);
            this.groupBox1.Controls.Add(this.portname);
            this.groupBox1.Controls.Add(this.connectbutton);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 84);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Communication";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(64, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 26);
            this.button1.TabIndex = 34;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // disconnectbutton
            // 
            this.disconnectbutton.Location = new System.Drawing.Point(119, 52);
            this.disconnectbutton.Name = "disconnectbutton";
            this.disconnectbutton.Size = new System.Drawing.Size(75, 25);
            this.disconnectbutton.TabIndex = 2;
            this.disconnectbutton.Text = "Disconnect";
            this.disconnectbutton.UseVisualStyleBackColor = true;
            this.disconnectbutton.Click += new System.EventHandler(this.disconnectbutton_Click);
            // 
            // yminusButton
            // 
            this.yminusButton.Image = ((System.Drawing.Image)(resources.GetObject("yminusButton.Image")));
            this.yminusButton.Location = new System.Drawing.Point(64, 88);
            this.yminusButton.Name = "yminusButton";
            this.yminusButton.Size = new System.Drawing.Size(42, 34);
            this.yminusButton.TabIndex = 3;
            this.yminusButton.UseVisualStyleBackColor = true;
            this.yminusButton.Click += new System.EventHandler(this.yminusButton_Click);
            // 
            // yplusButton
            // 
            this.yplusButton.Image = ((System.Drawing.Image)(resources.GetObject("yplusButton.Image")));
            this.yplusButton.Location = new System.Drawing.Point(61, 20);
            this.yplusButton.Name = "yplusButton";
            this.yplusButton.Size = new System.Drawing.Size(42, 34);
            this.yplusButton.TabIndex = 4;
            this.yplusButton.UseVisualStyleBackColor = true;
            this.yplusButton.Click += new System.EventHandler(this.yplusButton_Click);
            // 
            // xplusButton
            // 
            this.xplusButton.Image = ((System.Drawing.Image)(resources.GetObject("xplusButton.Image")));
            this.xplusButton.Location = new System.Drawing.Point(109, 54);
            this.xplusButton.Name = "xplusButton";
            this.xplusButton.Size = new System.Drawing.Size(42, 34);
            this.xplusButton.TabIndex = 10;
            this.xplusButton.UseVisualStyleBackColor = true;
            this.xplusButton.Click += new System.EventHandler(this.xplusButton_Click);
            // 
            // xminusButton
            // 
            this.xminusButton.Image = ((System.Drawing.Image)(resources.GetObject("xminusButton.Image")));
            this.xminusButton.Location = new System.Drawing.Point(13, 54);
            this.xminusButton.Name = "xminusButton";
            this.xminusButton.Size = new System.Drawing.Size(42, 34);
            this.xminusButton.TabIndex = 9;
            this.xminusButton.UseVisualStyleBackColor = true;
            this.xminusButton.Click += new System.EventHandler(this.xminusButton_Click);
            // 
            // controlgroup
            // 
            this.controlgroup.Controls.Add(this.xminusButton);
            this.controlgroup.Controls.Add(this.yminusButton);
            this.controlgroup.Controls.Add(this.xplusButton);
            this.controlgroup.Controls.Add(this.yplusButton);
            this.controlgroup.Location = new System.Drawing.Point(12, 226);
            this.controlgroup.Name = "controlgroup";
            this.controlgroup.Size = new System.Drawing.Size(157, 134);
            this.controlgroup.TabIndex = 11;
            this.controlgroup.TabStop = false;
            this.controlgroup.Text = "Control";
            // 
            // inputfile
            // 
            this.inputfile.Location = new System.Drawing.Point(86, 30);
            this.inputfile.Name = "inputfile";
            this.inputfile.Size = new System.Drawing.Size(249, 22);
            this.inputfile.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 14);
            this.label1.TabIndex = 14;
            this.label1.Text = "Input File";
            // 
            // browsebutton
            // 
            this.browsebutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.browsebutton.Location = new System.Drawing.Point(321, 62);
            this.browsebutton.Name = "browsebutton";
            this.browsebutton.Size = new System.Drawing.Size(86, 27);
            this.browsebutton.TabIndex = 15;
            this.browsebutton.Text = "Browse";
            this.browsebutton.UseVisualStyleBackColor = true;
            this.browsebutton.Click += new System.EventHandler(this.browse_Click);
            // 
            // pengroup
            // 
            this.pengroup.Controls.Add(this.pendropbutton);
            this.pengroup.Controls.Add(this.penliftbutton);
            this.pengroup.Location = new System.Drawing.Point(175, 226);
            this.pengroup.Name = "pengroup";
            this.pengroup.Size = new System.Drawing.Size(122, 101);
            this.pengroup.TabIndex = 21;
            this.pengroup.TabStop = false;
            this.pengroup.Text = "Pen Movement";
            // 
            // pendropbutton
            // 
            this.pendropbutton.Location = new System.Drawing.Point(20, 57);
            this.pendropbutton.Name = "pendropbutton";
            this.pendropbutton.Size = new System.Drawing.Size(75, 25);
            this.pendropbutton.TabIndex = 5;
            this.pendropbutton.Text = "Pen Drop";
            this.pendropbutton.UseVisualStyleBackColor = true;
            this.pendropbutton.Click += new System.EventHandler(this.pendropbutton_Click);
            // 
            // penliftbutton
            // 
            this.penliftbutton.Location = new System.Drawing.Point(20, 26);
            this.penliftbutton.Name = "penliftbutton";
            this.penliftbutton.Size = new System.Drawing.Size(75, 25);
            this.penliftbutton.TabIndex = 4;
            this.penliftbutton.Text = "Pen Lift";
            this.penliftbutton.UseVisualStyleBackColor = true;
            this.penliftbutton.Click += new System.EventHandler(this.penliftbutton_Click);
            // 
            // inputfilegroup
            // 
            this.inputfilegroup.Controls.Add(this.label1);
            this.inputfilegroup.Controls.Add(this.inputfile);
            this.inputfilegroup.Controls.Add(this.browsebutton);
            this.inputfilegroup.Location = new System.Drawing.Point(12, 113);
            this.inputfilegroup.Name = "inputfilegroup";
            this.inputfilegroup.Size = new System.Drawing.Size(418, 100);
            this.inputfilegroup.TabIndex = 22;
            this.inputfilegroup.TabStop = false;
            this.inputfilegroup.Text = "Input File";
            // 
            // gohomebutton
            // 
            this.gohomebutton.Location = new System.Drawing.Point(235, 34);
            this.gohomebutton.Name = "gohomebutton";
            this.gohomebutton.Size = new System.Drawing.Size(93, 51);
            this.gohomebutton.TabIndex = 23;
            this.gohomebutton.Text = "Go Home";
            this.gohomebutton.UseVisualStyleBackColor = true;
            this.gohomebutton.Click += new System.EventHandler(this.gohomebutton_Click);
            // 
            // serialscreen
            // 
            this.serialscreen.FormattingEnabled = true;
            this.serialscreen.ItemHeight = 14;
            this.serialscreen.Location = new System.Drawing.Point(458, 34);
            this.serialscreen.Name = "serialscreen";
            this.serialscreen.Size = new System.Drawing.Size(323, 284);
            this.serialscreen.TabIndex = 24;
            // 
            // sentrows
            // 
            this.sentrows.AutoSize = true;
            this.sentrows.Location = new System.Drawing.Point(525, 10);
            this.sentrows.Name = "sentrows";
            this.sentrows.Size = new System.Drawing.Size(0, 14);
            this.sentrows.TabIndex = 25;
            // 
            // RowsInFile
            // 
            this.RowsInFile.AutoSize = true;
            this.RowsInFile.Location = new System.Drawing.Point(651, 10);
            this.RowsInFile.Name = "RowsInFile";
            this.RowsInFile.Size = new System.Drawing.Size(0, 14);
            this.RowsInFile.TabIndex = 26;
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(319, 226);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(111, 40);
            this.startbutton.TabIndex = 30;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // stopbutton
            // 
            this.stopbutton.Location = new System.Drawing.Point(319, 320);
            this.stopbutton.Name = "stopbutton";
            this.stopbutton.Size = new System.Drawing.Size(111, 40);
            this.stopbutton.TabIndex = 31;
            this.stopbutton.Text = "Stop";
            this.stopbutton.UseVisualStyleBackColor = true;
            this.stopbutton.Click += new System.EventHandler(this.stopbutton_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived_1);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(334, 34);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(96, 51);
            this.ClearButton.TabIndex = 32;
            this.ClearButton.Text = "Clear Screen";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(458, 325);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(323, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 33;
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(319, 272);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(111, 40);
            this.PauseButton.TabIndex = 34;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // Drawbot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 381);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.stopbutton);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.RowsInFile);
            this.Controls.Add(this.sentrows);
            this.Controls.Add(this.serialscreen);
            this.Controls.Add(this.gohomebutton);
            this.Controls.Add(this.inputfilegroup);
            this.Controls.Add(this.pengroup);
            this.Controls.Add(this.controlgroup);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Drawbot";
            this.Text = " Drawbot";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Drawbot_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.controlgroup.ResumeLayout(false);
            this.pengroup.ResumeLayout(false);
            this.inputfilegroup.ResumeLayout(false);
            this.inputfilegroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox portname;
        private System.Windows.Forms.Button connectbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button yminusButton;
        private System.Windows.Forms.Button yplusButton;
        private System.Windows.Forms.Button xplusButton;
        private System.Windows.Forms.Button xminusButton;
        private System.Windows.Forms.GroupBox controlgroup;
        private System.Windows.Forms.TextBox inputfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browsebutton;
        private System.Windows.Forms.GroupBox pengroup;
        private System.Windows.Forms.Button pendropbutton;
        private System.Windows.Forms.Button penliftbutton;
        private System.Windows.Forms.GroupBox inputfilegroup;
        private System.Windows.Forms.Button gohomebutton;
        private System.Windows.Forms.ListBox serialscreen;
        private System.Windows.Forms.Label sentrows;
        private System.Windows.Forms.Label RowsInFile;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Button stopbutton;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button disconnectbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button PauseButton;
    }
}

