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
    public partial class FormOptions : Form
    {
        public static string playerOne;
        public static string playerTwo;
        public static int playerCount;


        public FormOptions()
        {
            InitializeComponent();
        }

        private void FormOptions_Load(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// submits players number and names 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            playerOne = txtBx1.Text;
            playerTwo = txtBx2.Text;

            MessageBox.Show("Number of players: " + playerCount.ToString());

            this.Hide();
            FormGameBoard nextForm = new FormGameBoard();
            nextForm.Closed += (s, args) => this.Close();
            nextForm.Show();

        }
        /// <summary>
        /// number of players
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radBtn1_CheckedChanged(object sender, EventArgs e)
        {
            txtBx2.Enabled = false;
            txtBx2.Visible = false;
            txtBx2.Text = " ";
            txtBx1.Enabled = true;
            playerCount = 1;
        }
        /// <summary>
        /// number of players
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radBtn2_CheckedChanged(object sender, EventArgs e)
        {
            txtBx1.Enabled = true;
            txtBx2.Enabled = true;
            txtBx2.Visible = true;
            playerCount = 2;           
        }

        private void txtBx1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
