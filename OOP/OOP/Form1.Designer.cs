namespace OOP {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && ( components != null )) {
                components.Dispose ();
                }
            base.Dispose (disposing);
            }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.components = new System.ComponentModel.Container();
            this.btnSample = new System.Windows.Forms.Button();
            this.mnuTop = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSampling = new System.Windows.Forms.GroupBox();
            this.txtSampling = new System.Windows.Forms.TextBox();
            this.lblSampling = new System.Windows.Forms.Label();
            this.grpLogging = new System.Windows.Forms.GroupBox();
            this.txtLogging = new System.Windows.Forms.TextBox();
            this.lblLogging = new System.Windows.Forms.Label();
            this.btnLogging = new System.Windows.Forms.Button();
            this.grpSensors = new System.Windows.Forms.GroupBox();
            this.txtSensors = new System.Windows.Forms.TextBox();
            this.tmrSample = new System.Windows.Forms.Timer(this.components);
            this.tmrLogging = new System.Windows.Forms.Timer(this.components);
            this.mnuTop.SuspendLayout();
            this.grpSampling.SuspendLayout();
            this.grpLogging.SuspendLayout();
            this.grpSensors.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSample
            // 
            this.btnSample.AccessibleName = "";
            this.btnSample.Location = new System.Drawing.Point(6, 59);
            this.btnSample.Name = "btnSample";
            this.btnSample.Size = new System.Drawing.Size(75, 35);
            this.btnSample.TabIndex = 0;
            this.btnSample.Text = "Sample";
            this.btnSample.UseVisualStyleBackColor = true;
            this.btnSample.Click += new System.EventHandler(this.btnSample_Click);
            // 
            // mnuTop
            // 
            this.mnuTop.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.operationsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuTop.Location = new System.Drawing.Point(0, 0);
            this.mnuTop.Name = "mnuTop";
            this.mnuTop.Size = new System.Drawing.Size(580, 28);
            this.mnuTop.TabIndex = 1;
            this.mnuTop.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.operationsToolStripMenuItem.Text = "Operations";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // grpSampling
            // 
            this.grpSampling.Controls.Add(this.txtSampling);
            this.grpSampling.Controls.Add(this.lblSampling);
            this.grpSampling.Controls.Add(this.btnSample);
            this.grpSampling.Location = new System.Drawing.Point(35, 58);
            this.grpSampling.Name = "grpSampling";
            this.grpSampling.Size = new System.Drawing.Size(270, 100);
            this.grpSampling.TabIndex = 3;
            this.grpSampling.TabStop = false;
            this.grpSampling.Text = "Sampling";
            // 
            // txtSampling
            // 
            this.txtSampling.Enabled = false;
            this.txtSampling.Location = new System.Drawing.Point(152, 32);
            this.txtSampling.Name = "txtSampling";
            this.txtSampling.ReadOnly = true;
            this.txtSampling.Size = new System.Drawing.Size(100, 22);
            this.txtSampling.TabIndex = 2;
            this.txtSampling.Text = "READY";
            // 
            // lblSampling
            // 
            this.lblSampling.AutoSize = true;
            this.lblSampling.Location = new System.Drawing.Point(7, 32);
            this.lblSampling.Name = "lblSampling";
            this.lblSampling.Size = new System.Drawing.Size(133, 17);
            this.lblSampling.TabIndex = 1;
            this.lblSampling.Text = "Next Sampling Time";
            // 
            // grpLogging
            // 
            this.grpLogging.Controls.Add(this.txtLogging);
            this.grpLogging.Controls.Add(this.lblLogging);
            this.grpLogging.Controls.Add(this.btnLogging);
            this.grpLogging.Location = new System.Drawing.Point(35, 229);
            this.grpLogging.Name = "grpLogging";
            this.grpLogging.Size = new System.Drawing.Size(270, 100);
            this.grpLogging.TabIndex = 4;
            this.grpLogging.TabStop = false;
            this.grpLogging.Text = "Logging";
            // 
            // txtLogging
            // 
            this.txtLogging.Enabled = false;
            this.txtLogging.Location = new System.Drawing.Point(152, 21);
            this.txtLogging.Name = "txtLogging";
            this.txtLogging.ReadOnly = true;
            this.txtLogging.Size = new System.Drawing.Size(100, 22);
            this.txtLogging.TabIndex = 3;
            this.txtLogging.Text = "READY";
            // 
            // lblLogging
            // 
            this.lblLogging.AutoSize = true;
            this.lblLogging.Location = new System.Drawing.Point(10, 22);
            this.lblLogging.Name = "lblLogging";
            this.lblLogging.Size = new System.Drawing.Size(126, 17);
            this.lblLogging.TabIndex = 1;
            this.lblLogging.Text = "Next Logging Time";
            // 
            // btnLogging
            // 
            this.btnLogging.AccessibleName = "";
            this.btnLogging.Location = new System.Drawing.Point(6, 59);
            this.btnLogging.Name = "btnLogging";
            this.btnLogging.Size = new System.Drawing.Size(75, 35);
            this.btnLogging.TabIndex = 0;
            this.btnLogging.Text = "Logging on File";
            this.btnLogging.UseVisualStyleBackColor = true;
            this.btnLogging.Click += new System.EventHandler(this.btnLogging_Click);
            // 
            // grpSensors
            // 
            this.grpSensors.Controls.Add(this.txtSensors);
            this.grpSensors.Location = new System.Drawing.Point(344, 58);
            this.grpSensors.Name = "grpSensors";
            this.grpSensors.Size = new System.Drawing.Size(197, 302);
            this.grpSensors.TabIndex = 5;
            this.grpSensors.TabStop = false;
            this.grpSensors.Text = "Sensor Values";
            // 
            // txtSensors
            // 
            this.txtSensors.Enabled = false;
            this.txtSensors.Location = new System.Drawing.Point(16, 32);
            this.txtSensors.Multiline = true;
            this.txtSensors.Name = "txtSensors";
            this.txtSensors.ReadOnly = true;
            this.txtSensors.Size = new System.Drawing.Size(166, 255);
            this.txtSensors.TabIndex = 0;
            // 
            // tmrSample
            // 
            this.tmrSample.Tick += new System.EventHandler(this.tmrSample_Tick);
            // 
            // tmrLogging
            // 
            this.tmrLogging.Tick += new System.EventHandler(this.tmrLogging_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 388);
            this.Controls.Add(this.grpSensors);
            this.Controls.Add(this.grpLogging);
            this.Controls.Add(this.grpSampling);
            this.Controls.Add(this.mnuTop);
            this.MainMenuStrip = this.mnuTop;
            this.Name = "Form1";
            this.Text = "DAQ Simulator";
            this.mnuTop.ResumeLayout(false);
            this.mnuTop.PerformLayout();
            this.grpSampling.ResumeLayout(false);
            this.grpSampling.PerformLayout();
            this.grpLogging.ResumeLayout(false);
            this.grpLogging.PerformLayout();
            this.grpSensors.ResumeLayout(false);
            this.grpSensors.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Button btnSample;
        private System.Windows.Forms.MenuStrip mnuTop;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpSampling;
        private System.Windows.Forms.Label lblSampling;
        private System.Windows.Forms.GroupBox grpLogging;
        private System.Windows.Forms.Label lblLogging;
        private System.Windows.Forms.Button btnLogging;
        private System.Windows.Forms.GroupBox grpSensors;
        private System.Windows.Forms.TextBox txtSampling;
        private System.Windows.Forms.TextBox txtLogging;
        private System.Windows.Forms.TextBox txtSensors;
        private System.Windows.Forms.Timer tmrSample;
        private System.Windows.Forms.Timer tmrLogging;
        }
    }

