using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Device.Location;


namespace Skylark_Home
{
    public partial class Form1 : Form
    {
        string lat_home;
        string lon_home;
        string alt_home;

        string current_lat;
        string current_lon;
        string current_alt;

        string current_lat_dec;
        string current_lon_dec;
        string current_alt_dec;

        int r = 400;
        int angle=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getAvailablePorts();
            gps_read();

        }
        void getAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            comList.Items.AddRange(ports);
        }

        private void connect_btn_Click(object sender, EventArgs e)
        {
            status_txt.Text = "Connecting..";
            try
            {
                if (comList.Text == "" || baudList.Text == "")
                {
                    MessageBox.Show("Please Select Comport or baudrate");
                }
                else
                {
                    serialPort1.PortName = comList.Text;
                    serialPort1.BaudRate = Convert.ToInt32(baudList.Text);
                    serialPort1.Open();
                    discon_btn.Enabled = true;
                    connect_btn.Enabled = false;
                    home_btn.Enabled = true;
                    status_txt.Text = "Connected";

                }
            }
            catch (UnauthorizedAccessException)
            {
                status_txt.Text = "Unable to Connect Comport";
                MessageBox.Show("Unable to Connect Comport");
            }
        }

        private void discon_btn_Click(object sender, EventArgs e)
        {
            

            serialPort1.Close();
            
            discon_btn.Enabled = false;
            connect_btn.Enabled = true;

            home_btn.Enabled = false;
            left_btn.Enabled = false;
            right_btn.Enabled = false;

            up_btn.Enabled = false;
            down_btn.Enabled = false;
            status_txt.Text = "Disconnected";

        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            if (txt_lat.Text == "") txt_lat.Text = "0";
            if (txt_lon.Text == "") txt_lon.Text = "0";
            if (txt_alt.Text == "") txt_alt.Text = "0";

            string lat = txt_lat.Text;
            string lon = txt_lon.Text;
            string alt = txt_alt.Text;


            string[] position_dms = decimalToDMS(lat, lon);

            lat = position_dms[0];
            lon = position_dms[1];

            status_txt.Text = "Setting Home position...";
            for (int i = 0;i<100; i++)
            {
                sendPosition(lat,lon,alt);
                
                for (int j = 0; j < 90000000; j++) ;
            }
            // turn noth

            double dlat = Convert.ToDouble(lat) + 0.0400;
            double dlon = Convert.ToDouble(lon);


            current_lat = dlat.ToString();
            current_lon = dlon.ToString();
            current_alt = alt;

            
            Thread.Sleep(2000);
            MessageBox.Show("Home Position Already Set");
            status_txt.Text = "Home Position Already Set";
            lat_home = lat;
            lon_home = lon;
            alt_home = alt;

            home_btn.Enabled = false;

            left_btn.Enabled = true;
            right_btn.Enabled = true;

            up_btn.Enabled = true;
            down_btn.Enabled = true;


            Thread loop = new Thread(sendloop);
            loop.Start();
            Thread.Sleep(2000);

        }
        void sendPosition(string lat,string lon,string alt)
        {
            DateTime tNow = DateTime.Now;
            int hr = tNow.Hour;
            string time_txt = String.Format("{0:00}{1:00}{2:00}.000,", hr, tNow.Minute, tNow.Second);

            //$GPGGA massage
            string msg1 = "$GPGGA,"+ time_txt + lat +",N,"+ lon + ",E,1,13,," + alt + ",M,,M,1,0000*";

            
            int checksum1 = 0;
            for (int i = 1; i < msg1.Length-1; i++)
            {
                checksum1 ^= Convert.ToByte(msg1[i]);
            }
            string strChecksum1 = checksum1.ToString("X2");
            msg1 = msg1 + strChecksum1+Environment.NewLine;

            //$GPGLL massage
            string msg2 = "$GPGLL," + lat + ",N," + lon +",E,"+ time_txt + "A*";
            int checksum2 = 0;
            for (int i = 1; i < msg2.Length - 1; i++)
            {
                checksum2 ^= Convert.ToByte(msg2[i]);
            }
            string strChecksum2 = checksum2.ToString("X2");
            msg2 = msg2 + strChecksum2 + Environment.NewLine;

            string msg3 = "$GPGSA,A,,,,,,,,,,,,,,,,*2f"+ Environment.NewLine ;

            serialPort1.Write(msg1);
            serialPort1.Write(msg2);
            serialPort1.Write(msg3);


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void left_btn_Click(object sender, EventArgs e)
        {
            left_btn.Enabled = false;
            angle -= 2;
            turn();
            left_btn.Enabled = true;
            

        }

        private void right_btn_Click(object sender, EventArgs e)
        {
            right_btn.Enabled = false;
            angle += 2;
            turn();
            right_btn.Enabled = true;

        }
        void turn()
        {
            double dhomelat = Convert.ToDouble(lat_home);
            double dhomelon = Convert.ToDouble(lon_home);
            double aa = angle*Math.PI/180.0;

            double y = r * Math.Cos(aa);
            double x = r * Math.Sin(aa);

            double dlat = dhomelat + (y / 10000);
            double dlon = dhomelon + (x / 10000);

            current_lat = dlat.ToString();
            current_lon = dlon.ToString();

        }
        string[] decimalToDMS(string lat_dec, string lon_dec)
        {
            string[] position_dms = {"",""};


            int lat_ddd = Convert.ToInt32( Math.Floor(Convert.ToDouble(lat_dec)) );
            double lat_mmm = (Convert.ToDouble(lat_dec)- lat_ddd)*60;
            position_dms[0] = String.Format("{0:0}{1:00.00000}", lat_ddd, lat_mmm);


            int lon_ddd = Convert.ToInt32( Math.Floor(Convert.ToDouble(lon_dec)) );
            double lon_mmm = (Convert.ToDouble(lon_dec) - lon_ddd) * 60;
            position_dms[1] = String.Format("{0:0}{1:00.00000}", lon_ddd, lon_mmm);

            return position_dms;
        }
        void sendloop()
        {
            while(serialPort1.IsOpen)
            {
                sendPosition(current_lat, current_lon, current_alt);
                Thread.Sleep(250);


                status_txt.Invoke((MethodInvoker)(() => status_txt.Text = "Send : "+ current_lat + " N, " + current_lon + " E, " + current_alt + " m"));
            };
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void up_btn_Click(object sender, EventArgs e)
        {
            up_btn.Enabled = false;
            current_alt = (Convert.ToDouble(current_alt) + 5).ToString();
            up_btn.Enabled = true;
        }

        private void down_btn_Click(object sender, EventArgs e)
        {
            down_btn.Enabled = false;
            current_alt = (Convert.ToDouble(current_alt) - 5).ToString();
            down_btn.Enabled = true;
        }

        private void gps_btn_Click(object sender, EventArgs e)
        {
            txt_lat.Text = current_lat_dec;
            txt_lon.Text = current_lon_dec;
            txt_alt.Text = current_alt_dec;
        }
        void gps_read()
        {
            GeoCoordinateWatcher watcher;
            watcher = new GeoCoordinateWatcher();
            
            watcher.PositionChanged += (sender, e) =>
            {
                var coordinate = e.Position.Location;
                    
                if(coordinate.HorizontalAccuracy<10 && coordinate.VerticalAccuracy < 10)
                {
                    gps_btn.Enabled = true;
                    current_lat_dec = coordinate.Latitude.ToString();
                    current_lon_dec = coordinate.Longitude.ToString();
                    current_alt_dec = coordinate.Altitude.ToString();

                }
               
            };
            watcher.Start();
        }
    }
}
