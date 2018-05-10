using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetSpeed
{
    public partial class ucStatWeb : UserControl
    {
        common cm;
        public int ControlNum;
        public string sFileName;

        public ucStatWeb()
        {
            InitializeComponent();
            cm = new common();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtURL.Text == "")
            {
                MessageBox.Show("you must insert some web address");
            }
            else
            {
                cm.dSpeed = cm.CheckInternetSpeed(this.txtURL.Text.ToString());
                dsSpeed.InternetSpeedRow rowDS = dsSpeed.InternetSpeed.NewInternetSpeedRow();
                rowDS.uc = ControlNum;
                rowDS.web = cm.sURL;
                rowDS.speed = cm.dSpeed;
                rowDS.date = (System.DateTime) DateTime.Now;
                dsSpeed.InternetSpeed.Rows.Add(rowDS);

            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "*Kspeed file|*.kspd|All Files (*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dsSpeed.WriteXml(saveFileDialog1.FileName);
                txtFileName.Text = sFileName = saveFileDialog1.FileName;
                MessageBox.Show("data is saved in "+ saveFileDialog1.FileName);
            }                
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*Kspeed file|*.kspd|All Files (*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dsSpeed.ReadXml(openFileDialog1.FileName);
                txtFileName.Text = sFileName = openFileDialog1.FileName;
            }
        }
    }
}
