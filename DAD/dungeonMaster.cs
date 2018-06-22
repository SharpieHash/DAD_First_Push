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
    public partial class dungeonMaster : Form
    {
        public bool mapLarge = true;
        public dungeonMaster()
        {
            InitializeComponent();
        }

        private void dungeonMaster_Load(object sender, EventArgs e)
        {
            string curDir = Directory.GetCurrentDirectory();
            DirectoryInfo curDirPar = Directory.GetParent(curDir);
            curDirPar = curDirPar.Parent;
            this.characterInfoHtml.Navigate(new Uri(String.Format("{0}/PlrSheet/characterInfo.html", curDirPar.FullName)));
        }

        private void locationOneBtn_Click(object sender, EventArgs e)
        {
             
        }

        private void locationTwoBtn_Click(object sender, EventArgs e)
        {

        }

        private void locationThreeBtn_Click(object sender, EventArgs e)
        {

        }

        private void locationFourBtn_Click(object sender, EventArgs e)
        {

        }

        private void mapSize_Click(object sender, EventArgs e)
        {
            if(mapLarge)
            {
                mapSize.Text = "-";
                mapLarge = false;
                //big map show ();
            }
            else
            {
                mapSize.Text = "+";
                mapLarge = true;
                //big map show ();
            }
        } 
    }
}
