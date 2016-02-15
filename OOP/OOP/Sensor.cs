using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP {
    class Sensor {
        double min; // minimin voltage
        double max; // maximum voltage
        bool type; // analog/digital (0/1) sensor
        double dVal;
        int sId;
        Random rSenVal;
        public Sensor (int id, double a, double b, bool c) {
            sId = id;
            min = a;
            max = b;
            type = c;
            rSenVal = new Random (id);
            dVal = 0.0F;
            }

        public double GetValue () {
            dVal = rSenVal.NextDouble () * ( max - min ) + min; // *(max-min) + min to get the correct range
            if (type == true) dVal = Math.Round (dVal, 0); // if true then the sensor is digital and is rounded to 0 or 1
            return dVal;
            }
        public int GetSensId () {
            return sId;
            }
        } // end Sensor
    } // end OOP
