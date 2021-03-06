﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace NetSpeed
{
    class common
    {

        public string strURL;
        public string sURL;
        public double dSpeed;
        public double dMin;
        public double dMax;
        public double dSigma;
        public double dAvr;

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

        public void CalcStat(DataSet ds)
        {

            // take statistics
            dMin = (double)ds.Tables[0].Compute("min(speed)",string.Empty);
            dMax = (double)ds.Tables[0].Compute("max(speed)", string.Empty);
            dAvr = (double)ds.Tables[0].Compute("AVG(speed)", string.Empty);


        }

        
    }
}
