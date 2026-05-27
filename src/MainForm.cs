```csharp
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PcGamingAutoClicker
{
    public partial class MainForm : Form
    {
        private Process targetProcess;
        private Timer processCheckTimer;
        private bool isClicking;

        public MainForm()
        {
            InitializeComponent();
            InitializeProcessCheckTimer();
        }

        private void InitializeComponent()
        {
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.TargetProcessTextBox = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 70);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(107, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start Clicking";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(125, 70);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(107, 23);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop Clicking";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // TargetProcessTextBox
            // 
            this.TargetProcessTextBox.Location = new System.Drawing.Point(12, 12);
            this.TargetProcessTextBox.Name = "TargetProcessTextBox";
            this.TargetProcessTextBox.Size = new System.Drawing.Size(220, 20);
            this.TargetProcessTextBox.TabIndex = 2;
            this.TargetProcessTextBox.Text = "Enter Game Process Name";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(12, 45);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(80, 13);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "Status: Idle";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(244, 105);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.TargetProcessTextBox);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Name = "MainForm";
            this.Text = "PC Gaming Auto Clicker";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void InitializeProcessCheckTimer()
        {
            processCheckTimer = new Timer();
            processCheckTimer.Interval = 1000; // Check every second
            processCheckTimer.Tick