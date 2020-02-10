using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAQ_simulator
{
    class Sensor
    {
        int sensorID;
        Random anumber;
        Random dnumber;
        double sensorValue;
        int digitalvalue;

        // Constructor for defining object properties
        public Sensor(int id)
        {
            sensorID = id;
            anumber = new Random();
            dnumber = new Random();
            sensorValue = 0.0F;
            digitalvalue = 0;
        }

        // Method for returning random analog value
        public double SensorValue()
        {
            sensorValue = anumber.NextDouble();
            return sensorValue;
        }

        // To get sensor ID Corresponding to sensor object
        public int GetSensorId()
        {
            return sensorID;
        }

        // Method for returning random Digital value
        public int Digital()
        {
            digitalvalue = dnumber.Next(0, 2);
            return digitalvalue;
        }

    }
}
