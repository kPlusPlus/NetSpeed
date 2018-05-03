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
                rowDS.uc = 1;
                rowDS.web = cm.sURL;
                rowDS.speed = cm.dSpeed;
                dsSpeed.InternetSpeed.Rows.Add(rowDS);

            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
