using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace DAD.Classes
{
    public partial class gameSetup : Form
    {
        public gameSetup()
        {
            this.CenterToScreen();
            InitializeComponent();
        }

        private void gameSetup_Load(object sender, EventArgs e)
        {

        }

        private void detectBtn_Click(object sender, EventArgs e)
        {
            string externalip = new WebClient().DownloadString("http://icanhazip.com");
            ipv4Txt.Text = externalip;
        }

        private void dmasterOption_Click(object sender, EventArgs e)
        {
            Classes.gs_datatypes GSD = new gs_datatypes();
            adOption.BackColor = Color.DarkSlateGray;
            GSD.adOption = false;
            dmasterOption.BackColor = Color.Green;
            GSD.dmMasterOption = true;
        }

        private void adOption_Click(object sender, EventArgs e)
        {
            Classes.gs_datatypes GSD = new gs_datatypes();
            dmasterOption.BackColor = Color.DarkSlateGray;
            GSD.dmMasterOption = false;
            adOption.BackColor = Color.Green;
            GSD.adOption = true;
        }
    }
}
