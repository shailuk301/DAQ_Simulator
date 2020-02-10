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
        Random rnumber;
        double sensorValue;

        public Sensor(int id)
        {
            sensorID = id;
            rnumber = new Random();
            sensorValue = 0.0F;
        }

        public double SensorValue()
        {

            sensorValue = rnumber.NextDouble();
            return sensorValue;
        }
        public int GetSensorId()
        {
            return sensorID;
        }

    }
}
