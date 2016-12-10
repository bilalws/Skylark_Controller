namespace Skylark_Home
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.connect_btn = new System.Windows.Forms.Button();
            this.discon_btn = new System.Windows.Forms.Button();
            this.home_btn = new System.Windows.Forms.Button();
            this.left_btn = new System.Windows.Forms.Button();
            this.right_btn = new System.Windows.Forms.Button();
            this.comList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_lat = new System.Windows.Forms.TextBox();
            this.txt_lon = new System.Windows.Forms.TextBox();
            this.txt_alt = new System.Windows.Forms.TextBox();
            this.baudList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.up_btn = new System.Windows.Forms.Button();
            this.down_btn = new System.Windows.Forms.Button();
            this.status_txt = new System.Windows.Forms.Label();
            this.gps_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(411, 38);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(121, 47);
            this.connect_btn.TabIndex = 0;
            this.connect_btn.Text = "Connect";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // discon_btn
            // 
            this.discon_btn.Enabled = false;
            this.discon_btn.Location = new System.Drawing.Point(556, 38);
            this.discon_btn.Name = "discon_btn";
            this.discon_btn.Size = new System.Drawing.Size(145, 47);
            this.discon_btn.TabIndex = 1;
            this.discon_btn.Text = "Disconnect";
            this.discon_btn.UseVisualStyleBackColor = true;
            this.discon_btn.Click += new System.EventHandler(this.discon_btn_Click);
            // 
            // home_btn
            // 
            this.home_btn.Enabled = false;
            this.home_btn.Location = new System.Drawing.Point(417, 227);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(115, 42);
            this.home_btn.TabIndex = 2;
            this.home_btn.Text = "Home";
            this.home_btn.UseVisualStyleBackColor = true;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // left_btn
            // 
            this.left_btn.Enabled = false;
            this.left_btn.Location = new System.Drawing.Point(267, 227);
            this.left_btn.Name = "left_btn";
            this.left_btn.Size = new System.Drawing.Size(115, 42);
            this.left_btn.TabIndex = 3;
            this.left_btn.Text = "Left";
            this.left_btn.UseVisualStyleBackColor = true;
            this.left_btn.Click += new System.EventHandler(this.left_btn_Click);
            // 
            // right_btn
            // 
            this.right_btn.Enabled = false;
            this.right_btn.Location = new System.Drawing.Point(576, 227);
            this.right_btn.Name = "right_btn";
            this.right_btn.Size = new System.Drawing.Size(112, 42);
            this.right_btn.TabIndex = 4;
            this.right_btn.Text = "Right";
            this.right_btn.UseVisualStyleBackColor = true;
            this.right_btn.Click += new System.EventHandler(this.right_btn_Click);
            // 
            // comList
            // 
            this.comList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comList.FormattingEnabled = true;
            this.comList.Location = new System.Drawing.Point(21, 47);
            this.comList.Name = "comList";
            this.comList.Size = new System.Drawing.Size(177, 33);
            this.comList.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(30, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "COM PORT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(30, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Latitude N (Decimal)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(30, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Longitude E (Decimal)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(29, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Altitude (m)";
            // 
            // txt_lat
            // 
            this.txt_lat.Location = new System.Drawing.Point(19, 141);
            this.txt_lat.Name = "txt_lat";
            this.txt_lat.Size = new System.Drawing.Size(180, 35);
            this.txt_lat.TabIndex = 10;
            // 
            // txt_lon
            // 
            this.txt_lon.Location = new System.Drawing.Point(19, 231);
            this.txt_lon.Name = "txt_lon";
            this.txt_lon.Size = new System.Drawing.Size(180, 35);
            this.txt_lon.TabIndex = 11;
            // 
            // txt_alt
            // 
            this.txt_alt.Location = new System.Drawing.Point(18, 313);
            this.txt_alt.Name = "txt_alt";
            this.txt_alt.Size = new System.Drawing.Size(180, 35);
            this.txt_alt.TabIndex = 12;
            // 
            // baudList
            // 
            this.baudList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.baudList.FormattingEnabled = true;
            this.baudList.Items.AddRange(new object[] {
            "9600",
            "57600",
            "115200"});
            this.baudList.Location = new System.Drawing.Point(235, 47);
            this.baudList.Name = "baudList";
            this.baudList.Size = new System.Drawing.Size(142, 33);
            this.baudList.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(242, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Baud Rate";
            // 
            // up_btn
            // 
            this.up_btn.Enabled = false;
            this.up_btn.Location = new System.Drawing.Point(417, 151);
            this.up_btn.Name = "up_btn";
            this.up_btn.Size = new System.Drawing.Size(118, 42);
            this.up_btn.TabIndex = 15;
            this.up_btn.Text = "Up";
            this.up_btn.UseVisualStyleBackColor = true;
            this.up_btn.Click += new System.EventHandler(this.up_btn_Click);
            // 
            // down_btn
            // 
            this.down_btn.Enabled = false;
            this.down_btn.Location = new System.Drawing.Point(417, 306);
            this.down_btn.Name = "down_btn";
            this.down_btn.Size = new System.Drawing.Size(115, 42);
            this.down_btn.TabIndex = 16;
            this.down_btn.Text = "Down";
            this.down_btn.UseVisualStyleBackColor = true;
            this.down_btn.Click += new System.EventHandler(this.down_btn_Click);
            // 
            // status_txt
            // 
            this.status_txt.AutoSize = true;
            this.status_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.status_txt.Location = new System.Drawing.Point(12, 414);
            this.status_txt.Name = "status_txt";
            this.status_txt.Size = new System.Drawing.Size(25, 24);
            this.status_txt.TabIndex = 17;
            this.status_txt.Text = "...";
            this.status_txt.Click += new System.EventHandler(this.label6_Click);
            // 
            // gps_btn
            // 
            this.gps_btn.Enabled = false;
            this.gps_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.gps_btn.Location = new System.Drawing.Point(60, 363);
            this.gps_btn.Name = "gps_btn";
            this.gps_btn.Size = new System.Drawing.Size(84, 36);
            this.gps_btn.TabIndex = 18;
            this.gps_btn.Text = "Get GPS";
            this.gps_btn.UseVisualStyleBackColor = true;
            this.gps_btn.Click += new System.EventHandler(this.gps_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(726, 442);
            this.Controls.Add(this.gps_btn);
            this.Controls.Add(this.status_txt);
            this.Controls.Add(this.down_btn);
            this.Controls.Add(this.up_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.baudList);
            this.Controls.Add(this.txt_alt);
            this.Controls.Add(this.txt_lon);
            this.Controls.Add(this.txt_lat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comList);
            this.Controls.Add(this.right_btn);
            this.Controls.Add(this.left_btn);
            this.Controls.Add(this.home_btn);
            this.Controls.Add(this.discon_btn);
            this.Controls.Add(this.connect_btn);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.Text = "SkyLark Tracking Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.Button discon_btn;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Button left_btn;
        private System.Windows.Forms.Button right_btn;
        private System.Windows.Forms.ComboBox comList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_lat;
        private System.Windows.Forms.TextBox txt_lon;
        private System.Windows.Forms.TextBox txt_alt;
        private System.Windows.Forms.ComboBox baudList;
        private System.Windows.Forms.Label label5;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button up_btn;
        private System.Windows.Forms.Button down_btn;
        private System.Windows.Forms.Label status_txt;
        private System.Windows.Forms.Button gps_btn;
    }
}

