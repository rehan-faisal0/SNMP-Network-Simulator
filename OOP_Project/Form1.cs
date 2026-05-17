using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class Form1 : Form
    {
        private List<NetworkDevice> connectedDevices = new List<NetworkDevice>();
        public Form1()
        {
            InitializeComponent();
            //subscribe the event
            snmp.LocationChanged += PictureBox_LocationChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void PictureBox_LocationChanged(object sender, EventArgs e)
        {
            // Invalidate the form to trigger a repaint
            Invalidate();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Get the selected device from the ComboBox
            string selectedDeviceName = comboBox1.SelectedItem as string;
            Random rnd = new Random();
            int num = rnd.Next();
            if (selectedDeviceName == "Router")
            {
                // Create a new instance of Router
                Router router = new Router();
                router.Location = new Point(400, 200);
                router.Size = new Size(80, 80);
                router.Name = "Router" + Router.TotalRouters;
                router.IPAddress = "192.168.1." + connectedDevices.Count;
                if (num % 2 == 0)
                {
                    router.DeviceStatus = "On";
                }
                else
                {
                    router.DeviceStatus = "Off";
                }
                router.LocationChanged += PictureBox_LocationChanged; // Handle LocationChanged event
                Controls.Add(router);
                // Add the router to the connected devices
                connectedDevices.Add(router);
                // Redraw the form
                Invalidate();
            }
            else if (selectedDeviceName == "Thermometer")
            {
                // Create a new instance of Thermometer
                Thermometer thermometer = new Thermometer();
                thermometer.Location = new Point(400, 220);
                thermometer.Size = new Size(80, 80);
                thermometer.Name = "Thermometer" + Thermometer.TotalThermometer;
                thermometer.IPAddress = "192.168.1." + connectedDevices.Count;
                if (num % 2 == 0)
                {
                    thermometer.DeviceStatus = "On";
                }
                else
                {
                    thermometer.DeviceStatus = "Off";
                }
                thermometer.LocationChanged += PictureBox_LocationChanged; // Handle LocationChanged event
                Controls.Add(thermometer);
                // Add the thermometer to the connected devices
                connectedDevices.Add(thermometer);
                // Redraw the form
                Invalidate();
            }
            else if (selectedDeviceName == "Computer")
            {
                Computer computer = new Computer();
                computer.Location = new Point(400, 200);
                computer.Size = new Size(80, 80);
                computer.Name = "Computer" + Computer.Totalcomputer;
                computer.IPAddress = "192.168.1." + connectedDevices.Count;
                if (num % 2 == 0)
                {
                    computer.DeviceStatus = "On";
                }
                else
                {
                    computer.DeviceStatus = "Off";
                }
                computer.LocationChanged += PictureBox_LocationChanged; // Handle LocationChanged event
                Controls.Add(computer);
                // Add the computer to the connected devices
                connectedDevices.Add(computer);
                // Redraw the form
                Invalidate();
            }
            else if (selectedDeviceName == "Cctv")
            {
                Cctv cctv = new Cctv();
                cctv.Location = new Point(400, 200);
                cctv.Size = new Size(80, 80);
                cctv.Name = "Cctv" + Cctv.Totalcctv;
                cctv.IPAddress = "192.168.1." + connectedDevices.Count;
                if(num % 2 == 0)
                {
                    cctv.DeviceStatus = "On";
                }
                else
                {
                    cctv.DeviceStatus = "Off";
                }
                cctv.LocationChanged += PictureBox_LocationChanged; // Handle LocationChanged event
                Controls.Add(cctv);
                // Add the CCTV to the connected devices
                connectedDevices.Add(cctv);
                // Redraw the form
                Invalidate();
            }

            // Attach the event handler to the newly created device
            connectedDevices[connectedDevices.Count - 1].Click += NetworkDevice_Click;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Check if SNMP and any connected devices exist
            if (snmp != null && connectedDevices.Count > 0)
            {
                // Draw a line for each connected device
                using (Pen linePen = new Pen(Color.Black))
                {
                    foreach (NetworkDevice device in connectedDevices)
                    {
                        // Calculate the line start and end points
                        Point startPoint = CalculateCenterPoint(snmp);
                        Point endPoint = CalculateCenterPoint(device);
                        // Draw a line between the start and end points
                        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; // Enable anti-aliasing for smoother line
                        e.Graphics.DrawLine(linePen, startPoint, endPoint);
                    }
                }
            }
        }
        private Point CalculateCenterPoint(NetworkDevice device)
        {
            int x = device.Left + device.Width / 2;
            int y = device.Top + device.Height / 2;
            return new Point(x,y);
        } 

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void NetworkDevice_Click(object sender, EventArgs e)
        {

            NetworkDevice clickedDevice = (NetworkDevice)sender;
            if (!clickedDevice.IsDragged)
            {
            richTextBox1.Text += clickedDevice.SendData();
            richTextBox1.Text += "\n";
            }
        }

        private void snmp_Click(object sender, EventArgs e)
        {
            if (!snmp.IsDragged)
            {
                richTextBox1.Text += "SNMP MANAGER IP : " + snmp.IPAddress + "\n";
                richTextBox1.Text += snmp.SendData() + "\n";
                new Thread(() =>
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        Thread.Sleep(1000); // Delay for 1 second (1000 milliseconds)
                        if (connectedDevices.Count > 0)
                        {
                            int i=1;
                            richTextBox1.Text += "Connected Devices : \n";
                            foreach (NetworkDevice device in connectedDevices)
                            {
                                richTextBox1.Text +="Device No : "+i+"\n";
                                Thread.Sleep(1000); // Delay for 1 second (1000 milliseconds)
                                richTextBox1.Text += "Device Name : " + device.Name + "\n";
                                richTextBox1.Text += "Device IP : " + device.IPAddress + "\n";
                                richTextBox1.Text += "Device Status : " + device.DeviceStatus + "\n\t =========== \n";
                                //if device is router then add text to richtextbox
                                i++;
                            }
                        }
                        else
                        {
                            richTextBox1.Text += "No Connected Devices \n";
                        }
                    });
                }).Start();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }
    }
}
