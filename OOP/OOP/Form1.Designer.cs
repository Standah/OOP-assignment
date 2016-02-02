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
            this.btnSample = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSample
            // 
            this.btnSample.AccessibleName = "";
            this.btnSample.Location = new System.Drawing.Point(81, 116);
            this.btnSample.Name = "btnSample";
            this.btnSample.Size = new System.Drawing.Size(75, 35);
            this.btnSample.TabIndex = 0;
            this.btnSample.Text = "Sample";
            this.btnSample.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnSample);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

            }

        #endregion
        private System.Windows.Forms.Button btnSample;
        }
    }

