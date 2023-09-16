using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Game_Bar
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void cpuLabel_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ports_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ports.Items.Clear();

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            ports.Text = "None";
            baudrate.Text = "9600";
        }

        private void ports_DropDown(object sender, EventArgs e)
        {
            ports.Items.Clear();
            string[] port = SerialPort.GetPortNames();
            ports.Items.Add("None");
            ports.Items.AddRange(port);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
