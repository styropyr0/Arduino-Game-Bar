using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Bar
{
    public partial class Form1 : Form
    {

        int clicks = 0, isConnected=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            clicks++;
            if (clicks % 2 == 0)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.Height = 35;
                this.Opacity = 0.7;
                this.ShowInTaskbar = false;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.Height = 360;
                this.Opacity = 1;
                this.ShowInTaskbar = true;
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            while (true)
            {
                Thread.Sleep(1000);
                double cpuval = cpuCounter.NextValue();
                double ramval = ramCounter.NextValue();
                double gpuval = gpuCounter.NextValue();
                //double gpuVal1 = gpuCounter1.NextValue(); 24118.3
                float batLvl;
                label1.Text = cpuval.ToString("0") + "%";
                label2.Text = ramval.ToString("0") + "%";
                label3.Text = gpuval.ToString("0") + "%";
                PowerStatus status = SystemInformation.PowerStatus;
                float percent = status.BatteryLifePercent;
                string percent_text = percent.ToString("P0");
                batLvl = percent;

                if (isConnected == 1)
                {
                    //arduino.WriteLine(cpuval.ToString("0"));
                    //arduino.WriteLine(ramval.ToString("0"));
                    //arduino.WriteLine(gpuval.ToString("0"));
                    //arduino.WriteLine(percent_text);
                    try
                    {
                        arduino.WriteLine(cpuval.ToString("0") + "% " + ramval.ToString("0") + "% " + gpuval.ToString("0") + "% " + percent_text);
                    }
                    catch(Exception err)
                    {

                    }
                }

                if (ramval >= 90)
                {
                    label2.ForeColor = Color.Red;
                }
                if (status.PowerLineStatus == PowerLineStatus.Online && percent == 0)
                {
                    label4.Text = "--";
                    label4.ForeColor = Color.Red;
                }

                else
                {
                    label4.Text = percent_text;
                    if (batLvl * 100 > 20 && batLvl * 100 < 100)
                    {
                        label4.ForeColor = Color.White;
                    }
                    else if (batLvl * 100 <= 20 && batLvl * 100 > 10)
                    {
                        label4.ForeColor = Color.Orange;
                    }
                    else if (batLvl * 100 <= 10)
                    {
                        label4.ForeColor = Color.Red;
                    }
                    else if (batLvl * 100 == 100)
                        label4.ForeColor = Color.GreenYellow;
                }
            }
        }

        private void ports_DropDown(object sender, EventArgs e)
        {
            ports.Items.Clear();
            string[] port = SerialPort.GetPortNames();
            ports.Items.Add("None");
            ports.Items.AddRange(port);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (button1.Text == "CONNECT")
                {
                    string bd;
                    arduino.PortName = ports.Text.Trim();
                    bd = baudrate.Text;

                    arduino.DataBits = 8;


                    arduino.StopBits = StopBits.One;

                    if (bd.ToUpper().Trim() == "USE DEFAULT")
                    {
                        bd = "9600";
                        arduino.BaudRate = Convert.ToInt32(bd);
                    }
                    else
                        arduino.BaudRate = Convert.ToInt32(bd);

                    arduino.Parity = Parity.None;

                    if (ports.Text.Trim() == "" || ports.Text.Trim().ToUpper() == "NONE")
                    {
                        dispBox.ForeColor = Color.Red;
                        dispBox.Text = "Select a port.";
                    }
                    else if (baudrate.Text.Trim() == "")
                    {
                        dispBox.ForeColor = Color.Red;
                        dispBox.Text = "Choose a baud rate.";
                    }

                    else
                    {
                        arduino.Open();
                        if (arduino.IsOpen)
                        {
                            button1.Text = "DISCONNECT";
                            dispBox.ForeColor = Color.GreenYellow;
                            dispBox.Text = "Connected to " + ports.Text;
                            isConnected = 1;
                        }
                        else
                        {
                            dispBox.ForeColor = Color.Red;
                            dispBox.Text = "Couldn't connect to " + ports.Text + ".";
                            button1.Text = "CONNECT";
                        }
                    }

                }
                else
                {
                    arduino.Close();
                    dispBox.ForeColor = Color.White;
                    dispBox.Text = "Disconnected from " + ports.Text;
                    button1.Text = "CONNECT";
                }
            }
            catch (Exception err)
            {
                dispBox.ForeColor = Color.Red;
                dispBox.Text = "Couldn't establish a connection.";
            }
        }
    }
}