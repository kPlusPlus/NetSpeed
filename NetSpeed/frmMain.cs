using System;
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
        double dSpeed;
        ucStatWeb ucSW;

        public frmMain()
        {
            InitializeComponent();
        }

        public double CheckInternetSpeed(string strURL = "http://google.com")
        {
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

        private void btnCheckSpeed_Click(object sender, EventArgs e)
        {
            string strUnit = "kb per sec";
            dSpeed = CheckInternetSpeed();
            MessageBox.Show(dSpeed.ToString() + strUnit);
            //MessageBox.Show(CheckInternetSpeed("http://iskon.hr").ToString() + strUnit);

            // for test add UC on form and data in
            //TODO: ovo završi
            //panel1.ControlAdded()

            ucSW = new ucStatWeb();
            //this.Controls.Add(ucSW);
            panel1.Controls.Add(ucSW);
            ucSW.Left = 1;
            ucSW.Top = 1;
            ucSW.txtURL.Text = "Google.com";

        }
    }
}
