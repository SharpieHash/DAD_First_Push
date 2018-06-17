using DAD.PlrSheet;
using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace DAD.Classes
{
    public partial class gameSetup : Form
    {
        public Button detect = new Button();

        public gameSetup()
        {
            this.CenterToScreen();
            InitializeComponent();
        }

        public void gameSetup_Load(object sender, EventArgs e)
        {
            PlrSheet.Character charc = new Character();
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
                MessageBox.Show("dddddddd");
                if (GSD.adOption == true || GSD.dmMasterOption == true)
                {
                    MessageBox.Show("sss");
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
    }
}
