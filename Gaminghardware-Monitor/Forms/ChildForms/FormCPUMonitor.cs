﻿using OpenHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaminghardwareMonitor.Forms
{
    public partial class FormCPUMonitor : Form
    {
        public FormCPUMonitor()
        {
            InitializeComponent();
            circularProgressBarCPU.Value = 0;
            circularProgressBarCPUTemp.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Thread thCPU_Usage = new Thread(cpuUsage);
            thCPU_Usage.Start();

            Thread thCPU_Temp = new Thread(cpuTemp);
            thCPU_Temp.Start();
        }

        private void cpuUsage()
        {
            float fcpu = pCPU.NextValue();
            circularProgressBarCPU.Invoke((MethodInvoker)(() => circularProgressBarCPU.Value = (int)fcpu));
            labelCPUP.Invoke((MethodInvoker)(() => labelCPUP.Text = string.Format("{0:0}%", fcpu)));
        }

        private void cpuTemp()
        {
            float tcpu = 0;

            Computer c = new Computer();
            c.MainboardEnabled = true;
            c.CPUEnabled = true;
            c.GPUEnabled = true;
            c.RAMEnabled = true;
            c.Open();

            foreach (var hardware in c.Hardware)
            {
                if (hardware.HardwareType == HardwareType.CPU)
                {
                    hardware.Update();
                    foreach (var sensors in hardware.Sensors)
                    {
                        if (sensors.SensorType == SensorType.Temperature && sensors.Name.Equals("CPU Package"))
                        {
                            tcpu = (float)sensors.Value;
                            //Console.WriteLine(sensors.Name + ": " + sensors.Value);
                        }
                    }
                }
            }

            circularProgressBarCPUTemp.Invoke((MethodInvoker)(() => circularProgressBarCPUTemp.Value = (int)tcpu));
            labelCPUTemp.Invoke((MethodInvoker)(() => labelCPUTemp.Text = string.Format("{0:0}°C", tcpu)));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }
    }
}
