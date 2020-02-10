using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAQ_simulator
{
    public partial class DAQmain : Form
    {
        public DAQmain()
        {
            InitializeComponent();
        }

        // Array to store current value of each sensor in one index each
        double[] sensorvaluearray = new double[12];

        // Array to store sensor ID
        int[] sensoridarray = new int[12];

        // Create an array of sensor objects
        public void sensorarray()
        {
            int counter, totalid = 12;
            Sensor[] sensor = new Sensor[totalid];
            for (counter = 0; counter < totalid; counter++)
            {
                sensor[counter] = new Sensor(counter);
                sensorvaluearray[counter] = sensor[counter].SensorValue();
                System.Threading.Thread.Sleep(100);
                sensoridarray[counter] = sensor[counter].GetSensorId();
            }

        }

        // Created Array to store sum of all the recorded values from sensors
        int counter1;
        double[] sensor1sumarray = new double[40];
        double[] sensor2sumarray = new double[40];
        double[] sensor3sumarray = new double[40];
        double[] sensor4sumarray = new double[40];
        double[] sensor5sumarray = new double[40];
        double[] sensor6sumarray = new double[40];
        double[] sensor7sumarray = new double[40];
        double[] sensor8sumarray = new double[40];
        double[] sensor9sumarray = new double[40];
        double[] sensor10sumarray = new double[40];
        double[] sensor11sumarray = new double[40];
        double[] sensor12sumarray = new double[40];

        // Array to store all the average taken
        double[] mafilterarray = new double[12];

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void DAQmain_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }

        // Displaying the Current Sensor Values
        private void timer1_Tick(object sender, EventArgs e)
        {
            sensorarray();


            DataTable sd = new DataTable();
            sd.Columns.Add("SensorID");
            sd.Columns.Add("sensor value");

            for (int i = 0; i <= 11; i++)
            {
                sd.Rows.Add(sensoridarray[i], sensorvaluearray[i].ToString("F3"));
            }

            showSensorData.DataSource = sd;



            // Storing individual sensor values in an array to take average later
            sensor1sumarray[counter1] += sensorvaluearray[0];
            sensor2sumarray[counter1] += sensorvaluearray[1];
            sensor3sumarray[counter1] += sensorvaluearray[2];
            sensor4sumarray[counter1] += sensorvaluearray[3];
            sensor5sumarray[counter1] += sensorvaluearray[4];
            sensor6sumarray[counter1] += sensorvaluearray[5];
            sensor7sumarray[counter1] += sensorvaluearray[6];
            sensor8sumarray[counter1] += sensorvaluearray[7];
            sensor9sumarray[counter1] += sensorvaluearray[8];
            sensor10sumarray[counter1] += sensorvaluearray[9];
            sensor11sumarray[counter1] += sensorvaluearray[10];
            sensor12sumarray[counter1] += sensorvaluearray[11];
        }

        // Showing the average of sensor value till now
        private void timer2_Tick(object sender, EventArgs e)
        {
            // Taking average of all the sensor values
            mafilterarray[0] = sensor1sumarray.Average();
            mafilterarray[1] = sensor2sumarray.Average();
            mafilterarray[2] = sensor3sumarray.Average();
            mafilterarray[3] = sensor4sumarray.Average();
            mafilterarray[4] = sensor5sumarray.Average();
            mafilterarray[5] = sensor6sumarray.Average();
            mafilterarray[6] = sensor7sumarray.Average();
            mafilterarray[7] = sensor8sumarray.Average();
            mafilterarray[8] = sensor9sumarray.Average();
            mafilterarray[9] = sensor10sumarray.Average();
            mafilterarray[10] = sensor11sumarray.Average();
            mafilterarray[11] = sensor12sumarray.Average();

            DataTable log = new DataTable();
            log.Columns.Add("SensorID");
            log.Columns.Add("average value");

            for (int i = 0; i <= 11; i++)
            {
                log.Rows.Add(sensoridarray[i], mafilterarray[i].ToString("F3"));
            }

            showLogData.DataSource = log;
        }
    }
}
