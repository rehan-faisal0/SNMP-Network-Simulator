using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;

namespace OOP_Project
{
    public class NetworkDevice : PictureBox
    {
        private bool isDragging = false, isDragged = false;
        public bool IsDragged { get { return isDragged; } }
        private Point mouseOffset;
        public string DeviceName { get; set; }
        public string IPAddress { get; set; }
        public string DeviceStatus { get; set; }

        protected static string ImagePath(string filename)
        {
            return Path.Combine(Application.StartupPath, filename);
        }

        protected bool IsDesignMode
        {
            get { return LicenseManager.UsageMode == LicenseUsageMode.Designtime; }
        }
        public NetworkDevice()
        {
            SizeMode = PictureBoxSizeMode.StretchImage;
            Cursor = Cursors.Hand;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            isDragging = true;
            mouseOffset = e.Location;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (isDragging)
            {
                Point newLocation = new Point(e.X + Left - mouseOffset.X, e.Y + Top - mouseOffset.Y);
                if (Location != newLocation)
                {
                    isDragged = true;
                    Location = newLocation;
                }
            }
            else
            {
                isDragged = false;
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            isDragging = false;
        }

        public virtual string SendData()
        {
            return "Sending data from NetworkDevice...";
        }
    }

    public class SNMPManager : NetworkDevice
    {
        public SNMPManager()
        {
            IPAddress = "192.168.0.100";
            if (!IsDesignMode)
            {
                Image = Image.FromFile(ImagePath("images.jpg"));
            }
        }

        public override string SendData()
        {
            return "\nSending request to all devices ...";
        }
    }

    public class Router : NetworkDevice
    {
        public static int TotalRouters { get; private set; }

        public Router()
        {
            IPAddress = "";
            if (!IsDesignMode)
            {
                Image = Image.FromFile(ImagePath("wifi-router.png"));
                TotalRouters++;
            }
        }

        public override string SendData()
        {
            return "Sending trap from <" + this.Name + ">...";
        }
    }

    public class Thermometer : NetworkDevice
    {
        public static int TotalThermometer { get; private set; }

        public Thermometer()
        {
            IPAddress = "";
            if (!IsDesignMode)
            {
                Image = Image.FromFile(ImagePath("thermometer.png"));
                TotalThermometer++;
            }
        }

        public override string SendData()
        {
            return "Sending trap from <" + this.Name + ">...";
        }
    }

    public class Computer : NetworkDevice
    {
        public static int Totalcomputer { get; private set; }

        public Computer()
        {
            IPAddress = "";
            if (!IsDesignMode)
            {
                Image = Image.FromFile(ImagePath("computer.png"));
                Totalcomputer++;
            }
        }

        public override string SendData()
        {
            return "Sending trap from <" + this.Name + ">...";
        }
    }

    public class Cctv : NetworkDevice
    {
        public static int Totalcctv { get; private set; }

        public Cctv()
        {
            IPAddress = "";
            if (!IsDesignMode)
            {
                Image = Image.FromFile(ImagePath("cctv_icon_135799.png"));
                Totalcctv++;
            }
        }

        public override string SendData()
        {
            return "Sending trap from <" + this.Name + ">...";
        }
    }
}