using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeaopardy_App
{
    public partial class SplashScreen : Form
    {
        Timer tmr;
        public SplashScreen()
        {
            InitializeComponent();           
        }

        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();
            //set time interval 5 sec
            tmr.Interval = 5000;
            //starts the timer
            tmr.Start();
            tmr.Tick += tmr_Tick;
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            //after 5 sec stop the timer
            tmr.Stop();
            //display option form
            FormOptions mf = new FormOptions();
            mf.Show();
            //hide this form
            this.Hide();
        }
    }
}
