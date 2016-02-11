using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP {
    class Sensor {

        double dVal;
        int sId;
        Random rSenVal;
        public Sensor (int id) {
            sId = id;
            rSenVal = new Random (id);
            dVal = 0.0F;
            }
        public double GetValue () {
            dVal += rSenVal.NextDouble ();
            return dVal;
            }
        public int GetSensId () {
            return sId;
            }
        } // end Sensor
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main () {
            Application.EnableVisualStyles ();
            Application.SetCompatibleTextRenderingDefault (false);
            Application.Run (new Form1 ());

            // Application settings
            int iAnalogSensors = 2;
            int iDigitalSensors = 2;
            double dSampleTime = 1.1;
            double dLoggingTime = 54;
            double dLowerVoltage = 0;
            double dUpperVoltage = 5;
            int iResolution = 12;


            int totalSensors = iAnalogSensors + iDigitalSensors;
            Sensor[] sens = new Sensor[totalSensors];

            for (int i = 0; i < totalSensors; i++) {
                sens[i] = new Sensor (i);
                } // end for
            double verdi = sens[0].GetValue ();

            } // end Main
        } // end Program
    } // end OOP
