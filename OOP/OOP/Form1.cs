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
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main () {
            Application.EnableVisualStyles ();
            Application.SetCompatibleTextRenderingDefault (false);
            Application.Run (new Form1 ());

            Sensor sens1 = new Sensor (0);
            }
        } // end Program

    public partial class Form1:Form {
        public Form1 () {
            InitializeComponent ();
            }

        private void btnSample_Click (object sender, EventArgs e) {
            txtSampling.Text = "Hello World!";
            }
        } // end Form1:Form
    } // end OOP
