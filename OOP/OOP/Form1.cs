using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOP {
    public partial class Form1:Form {
        Sensor[] sObj;
        static double sampleTime = 1.1;
        static double loggingTime = 54;
        double timeLeftSampling = sampleTime;
        double timeLeftLogging = loggingTime;
        static int analogSensors = 2;
        static int digitalSensors = 1;
        static int totalSensors = analogSensors + digitalSensors;
        double MinV = 0.0;
        double MaxV = 5.0;
        string output;

        public Form1 () {
                      
            sObj = new Sensor[totalSensors];

            // for loops to initialize first the analogue then one for the digital sensors
            for (int i = 0; i < analogSensors; i++) sObj[i] = new Sensor (i+1, MinV, MaxV, false);
            for (int i = analogSensors; i < totalSensors; i++) sObj[i] = new Sensor ((i-analogSensors+1), 0, 1, true);

            InitializeComponent ();
            } // end Form1

        private void btnSample_Click (object sender, EventArgs e) {
            tmrSample.Enabled = true;
            output = "";
            output += DateTime.Now.ToLongTimeString ();

            // read sensor values and add to output string, first analogue then digital sensors
            for (int i = 0; i < analogSensors; i++) output += (" A" + sObj[i].GetSensId () + ":" + sObj[i].GetValue ().ToString ("0.0000"));
            for (int i = analogSensors; i < totalSensors; i++) output += (" D" + sObj[i].GetSensId () + ":" + sObj[i].GetValue ().ToString ("0"));

            txtSensors.Text = output.Replace (" ", "\r\n "); // format output string to add NewLines
            } // end btnSample_Click

        private void btnLogging_Click (object sender, EventArgs e) {
            tmrLogging.Enabled = true;
            string filename = DateTime.Now.ToShortDateString () + ".txt";
            using (StreamWriter writer = File.AppendText (filename)) writer.WriteLine (output.Replace (" ", ", ")); // format output string to add commas
            } // end btnLogging_Click

        private void tmrSample_Tick (object sender, EventArgs e) {
            if (timeLeftSampling >= 0.1) {
                btnSample.Enabled = false;
                timeLeftSampling = timeLeftSampling - 0.1;
                txtSampling.Text = timeLeftSampling.ToString ("F");
                } else {
                btnSample.Enabled = true;
                txtSampling.Text = "READY";
                tmrSample.Enabled = false;
                timeLeftSampling = sampleTime;
                } // end else
            
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
                } // end else
            } // end timer2_Tick

        private void aboutToolStripMenuItem_Click (object sender, EventArgs e) {
            MessageBox.Show ("This application was made as part of an assignment for SCE1306 Object-oriented Analysis, Design and Programming fall 2016.",
            "About", System.Windows.Forms.MessageBoxButtons.OK);
            }
        } // end Form1:Form
    } // end OOP
