using DAD.PlrSheet;
using System;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace DAD.Classes
{
    public partial class gameSetup : Form
    {
        public Button detect = new Button();
        public string ipvalStr;
        public gameSetup()
        {
            this.CenterToScreen();
            InitializeComponent();
        }

        public void gameSetup_Load(object sender, EventArgs e)
        {
            detectBtn.Enabled = false;
            detectBtn.Hide();
            detectBtn.Visible = false;
            applyBtn.Hide();
            applyBtn.Visible = false;
        }

        private void detectBtn_Click(object sender, EventArgs e)
        {
            string externalip = new WebClient().DownloadString("http://icanhazip.com");
            ipv4Txt.Text = externalip;
            checkApply();
        }

        private void dmasterOption_Click(object sender, EventArgs e)
        {
            Classes.gs_datatypes GSD = new gs_datatypes();
            adOption.BackColor = Color.DarkSlateGray;
            GSD.adOption = false;
            dmasterOption.BackColor = Color.Green;
            GSD.dmMasterOption = true;
            detectBtn.Enabled = true;
            detectBtn.Show();
            detectBtn.Visible = true;
            checkApply();
        }

        public void checkApply()
        {
            Classes.gs_datatypes GSD = new gs_datatypes();
            if (!String.IsNullOrEmpty(ipv4Txt.Text) && !String.IsNullOrEmpty(portTxt.Text))
            {
                if (dmasterOption.BackColor == Color.Green || adOption.BackColor == Color.Green)
                {
                    if(ipv4Txt.BackColor == Color.Red || ipv4Txt.BackColor == Color.White)
                    {
                    }
                    applyBtn.Show();
                    applyBtn.Visible = true;
                }
            }

        }

        private void adOption_Click(object sender, EventArgs e)
        {
            Classes.gs_datatypes GSD = new gs_datatypes();
            dmasterOption.BackColor = Color.DarkSlateGray;
            GSD.dmMasterOption = false;
            adOption.BackColor = Color.Green;
            GSD.adOption = true;
            detectBtn.Enabled = false;
            detectBtn.Hide();
            detectBtn.Visible = false;
            if (!detectBtn.Visible)
            {
                ipv4Txt.Text = string.Empty;
            }
            checkApply();
        }

        public void valIP()
        {
            ipvalStr = ipv4Txt.Text;
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            if (dmasterOption.BackColor == Color.Green)
            {
                gameSetup GSF = new gameSetup();
                GSF.Hide();
                dungeonMaster dm = new dungeonMaster();
                dm.Show();
            }
            else
            {
                gameSetup GSF = new gameSetup();
                GSF.Hide();
                adventureForm adf = new adventureForm();
                adf.Show(); 
            }
        }

        private void ipv4Txt_Leave(object sender, System.EventArgs e)
        {
            IPAddress ip;
            bool ValidateIP = IPAddress.TryParse(ipv4Txt.ToString(), out ip);
            if (ValidateIP)
            {
                ipv4Txt.BackColor = Color.Green;
            }
            else
            {
                ipv4Txt.BackColor = Color.Red;
            }
        }

        private void portTxt_TextChanged(object sender, EventArgs e)
        {
            checkApply();
        }
    }
}
