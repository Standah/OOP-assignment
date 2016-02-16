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
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTop.SuspendLayout();
            this.grpSampling.SuspendLayout();
            this.grpLogging.SuspendLayout();
            this.grpSensors.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSample
            // 
            this.btnSample.AccessibleName = "";
            this.btnSample.Location = new System.Drawing.Point(4, 48);
            this.btnSample.Margin = new System.Windows.Forms.Padding(2);
            this.btnSample.Name = "btnSample";
            this.btnSample.Size = new System.Drawing.Size(56, 28);
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
            this.mnuTop.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuTop.Size = new System.Drawing.Size(436, 24);
            this.mnuTop.TabIndex = 1;
            this.mnuTop.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.operationsToolStripMenuItem.Text = "Operations";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // grpSampling
            // 
            this.grpSampling.BackColor = System.Drawing.SystemColors.Control;
            this.grpSampling.Controls.Add(this.txtSampling);
            this.grpSampling.Controls.Add(this.lblSampling);
            this.grpSampling.Controls.Add(this.btnSample);
            this.grpSampling.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpSampling.Location = new System.Drawing.Point(26, 47);
            this.grpSampling.Margin = new System.Windows.Forms.Padding(2);
            this.grpSampling.Name = "grpSampling";
            this.grpSampling.Padding = new System.Windows.Forms.Padding(2);
            this.grpSampling.Size = new System.Drawing.Size(202, 81);
            this.grpSampling.TabIndex = 3;
            this.grpSampling.TabStop = false;
            this.grpSampling.Text = "Sampling";
            // 
            // txtSampling
            // 
            this.txtSampling.Enabled = false;
            this.txtSampling.Location = new System.Drawing.Point(114, 26);
            this.txtSampling.Margin = new System.Windows.Forms.Padding(2);
            this.txtSampling.Name = "txtSampling";
            this.txtSampling.ReadOnly = true;
            this.txtSampling.Size = new System.Drawing.Size(76, 20);
            this.txtSampling.TabIndex = 2;
            this.txtSampling.Text = "READY";
            // 
            // lblSampling
            // 
            this.lblSampling.AutoSize = true;
            this.lblSampling.Location = new System.Drawing.Point(5, 26);
            this.lblSampling.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSampling.Name = "lblSampling";
            this.lblSampling.Size = new System.Drawing.Size(101, 13);
            this.lblSampling.TabIndex = 1;
            this.lblSampling.Text = "Next Sampling Time";
            // 
            // grpLogging
            // 
            this.grpLogging.Controls.Add(this.txtLogging);
            this.grpLogging.Controls.Add(this.lblLogging);
            this.grpLogging.Controls.Add(this.btnLogging);
            this.grpLogging.Location = new System.Drawing.Point(26, 186);
            this.grpLogging.Margin = new System.Windows.Forms.Padding(2);
            this.grpLogging.Name = "grpLogging";
            this.grpLogging.Padding = new System.Windows.Forms.Padding(2);
            this.grpLogging.Size = new System.Drawing.Size(202, 81);
            this.grpLogging.TabIndex = 4;
            this.grpLogging.TabStop = false;
            this.grpLogging.Text = "Logging";
            // 
            // txtLogging
            // 
            this.txtLogging.Enabled = false;
            this.txtLogging.Location = new System.Drawing.Point(114, 17);
            this.txtLogging.Margin = new System.Windows.Forms.Padding(2);
            this.txtLogging.Name = "txtLogging";
            this.txtLogging.ReadOnly = true;
            this.txtLogging.Size = new System.Drawing.Size(76, 20);
            this.txtLogging.TabIndex = 3;
            this.txtLogging.Text = "READY";
            // 
            // lblLogging
            // 
            this.lblLogging.AutoSize = true;
            this.lblLogging.Location = new System.Drawing.Point(8, 18);
            this.lblLogging.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogging.Name = "lblLogging";
            this.lblLogging.Size = new System.Drawing.Size(96, 13);
            this.lblLogging.TabIndex = 1;
            this.lblLogging.Text = "Next Logging Time";
            // 
            // btnLogging
            // 
            this.btnLogging.AccessibleName = "";
            this.btnLogging.Location = new System.Drawing.Point(4, 48);
            this.btnLogging.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogging.Name = "btnLogging";
            this.btnLogging.Size = new System.Drawing.Size(56, 28);
            this.btnLogging.TabIndex = 0;
            this.btnLogging.Text = "Logging on File";
            this.btnLogging.UseVisualStyleBackColor = true;
            this.btnLogging.Click += new System.EventHandler(this.btnLogging_Click);
            // 
            // grpSensors
            // 
            this.grpSensors.Controls.Add(this.txtSensors);
            this.grpSensors.Location = new System.Drawing.Point(258, 47);
            this.grpSensors.Margin = new System.Windows.Forms.Padding(2);
            this.grpSensors.Name = "grpSensors";
            this.grpSensors.Padding = new System.Windows.Forms.Padding(2);
            this.grpSensors.Size = new System.Drawing.Size(148, 245);
            this.grpSensors.TabIndex = 5;
            this.grpSensors.TabStop = false;
            this.grpSensors.Text = "Sensor Values";
            // 
            // txtSensors
            // 
            this.txtSensors.Enabled = false;
            this.txtSensors.Location = new System.Drawing.Point(12, 26);
            this.txtSensors.Margin = new System.Windows.Forms.Padding(2);
            this.txtSensors.Multiline = true;
            this.txtSensors.Name = "txtSensors";
            this.txtSensors.ReadOnly = true;
            this.txtSensors.Size = new System.Drawing.Size(126, 208);
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
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(436, 315);
            this.Controls.Add(this.grpSensors);
            this.Controls.Add(this.grpLogging);
            this.Controls.Add(this.grpSampling);
            this.Controls.Add(this.mnuTop);
            this.MainMenuStrip = this.mnuTop;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "DAQ Simulator";
            this.TransparencyKey = System.Drawing.Color.White;
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
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        }
    }

