using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.CenterToScreen();
            InitializeComponent();
        }

        private void gamesetupBtn_Click(object sender, EventArgs e)
        {
            Classes.gameSetup GS = new Classes.gameSetup();
            GS.Show();
            Hide();
        }
    }
}
