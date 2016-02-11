using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP {

    public partial class Form1:Form {
        public Form1 () {
            InitializeComponent ();
            }

        static double sampleTime = 2;
        static double loggingTime = 5;
        double timeLeftSampling = sampleTime;
        double timeLeftLogging = loggingTime;

        private void btnSample_Click (object sender, EventArgs e) {
            tmrSample.Enabled = true;
            txtSensors.Text = DateTime.Now.ToLongTimeString ();

            } // end btnSample_Click

        private void btnLogging_Click (object sender, EventArgs e) {
            tmrLogging.Enabled = true;

            } // end btnLogging_Click

        private void tmrSample_Tick (object sender, EventArgs e) {
            if (timeLeftSampling >= 0.1) {
                btnSample.Enabled = false;
                timeLeftSampling = timeLeftSampling - 0.1;
                txtSampling.Text = timeLeftSampling.ToString ("F");
                } 
            else {
                btnSample.Enabled = true;
                txtSampling.Text = "READY";
                tmrSample.Enabled = false;
                timeLeftSampling = sampleTime;
                }
            
            } // end timer1_Tick

        private void tmrLogging_Tick (object sender, EventArgs e) {
            if (timeLeftLogging >= 0.1) {
                btnLogging.Enabled = false;
                timeLeftLogging = timeLeftLogging - 0.1;
                txtLogging.Text = timeLeftLogging.ToString ("F");
                } else {
                btnLogging.Enabled = true;
                txtLogging.Text = "READY";
                tmrLogging.Enabled = false;
                timeLeftLogging = loggingTime;
                }
            } // end timer2_Tick
        } // end Form1:Form
    } // end OOP
