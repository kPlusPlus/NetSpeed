﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetSpeed
{
    public partial class frmMain : Form
    {
        //double dSpeed;
        //string sURL;
        ucStatWeb[] ucSW;
        int countuc = 1;
        //dsSpeed dsSpeedD;


        public frmMain()
        {
            InitializeComponent();
            //dsSpeedD = new dsSpeed();
        }

        /*
        public double CheckInternetSpeed(string strURL = "http://google.com")
        {
            sURL = strURL;
            // Create Object Of WebClient
            System.Net.WebClient wc = new System.Net.WebClient();

            //DateTime Variable To Store Download Start Time.
            DateTime dt1 = DateTime.Now;

            //Number Of Bytes Downloaded Are Stored In ‘data’
            byte[] data = wc.DownloadData(strURL);

            //DateTime Variable To Store Download End Time.
            DateTime dt2 = DateTime.Now;

            //To Calculate Speed in Kb Divide Value Of data by 1024 And Then by End Time Subtract Start Time To Know Download Per Second.
            return Math.Round((data.Length / 1024) / (dt2 - dt1).TotalSeconds, 2);
        }
        */

        private void btnCheckSpeed_Click(object sender, EventArgs e)
        {
            if (ucSW == null)
            {
                countuc = 1;
            }
            else
            {
                countuc = ucSW.Length + 1;
            }

            Array.Resize(ref ucSW, countuc);
            ucSW[countuc - 1] = new ucStatWeb();
            
            panel1.Controls.Add(ucSW[countuc - 1]);
            ucSW[countuc - 1].ControlNum = countuc;
            ucSW[countuc - 1].txtURL.Text = txtURLmain.Text;
            ucSW[countuc - 1].Left = (countuc - 1)* ucSW[countuc - 1].Width;
        }
    }
}
