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
    public partial class FormQandA : Form
    {
        /// <summary>
        /// variables and getter setters
        /// </summary>
        private Timer tmr;
        public static string answer;
        public static string userAnswer;
        public static string winOrLose = " ";
        public string Question { get; set; }
        public string QAnswer { get; set; }
        public int PointValue { get; set; }
        /// <summary>
        /// Timer ticking 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void tmr_Tick(object sender, EventArgs e)
        {
            if (btnSubmit.Visible == false)
            {
                tmr.Stop();
                tmr.Dispose();
            }
            else
            {
                tmr.Stop();
                tmr.Dispose();
                winOrLose = "l";
                MessageBox.Show("Sorry ran out of time!");
                FormGameBoard.Score(winOrLose, PointValue);
            }
            this.Close();           
        }
        /// <summary>
        /// gets the quesastons variables
        /// </summary>
        /// <param name="question"></param>
        /// <param name="Qanswer"></param>
        /// <param name="pValue"></param>
        public FormQandA(string question, string Qanswer, int pValue)
        {
            InitializeComponent();

            this.Question = question;
            this.QAnswer = Qanswer;
            this.PointValue = pValue;
        }
        /// <summary>
        /// prints question to scrteen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormQandA_Load(object sender, EventArgs e)
        {
            txtBxQ.Text = Question;
        }

        /// <summary>
        /// submits answer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            btnOK.Visible = true;
            btnOK.Enabled = true;
            btnSubmit.Enabled = false;
            btnSubmit.Visible = false;
            userAnswer = txtBxA.Text;
            txtBxQ.Text = ("Correct Answer: " + QAnswer + "\r\nYour Answer: " + userAnswer);
            txtBxA.Enabled = false;
            if (userAnswer != QAnswer)
            {
                winOrLose = "l";
                MessageBox.Show("Sorry the correct answer was: " + QAnswer);
            }
            else
            {
                winOrLose = "w";
                MessageBox.Show("DING DING DING!!! Correct!");
            }
        }
        /// <summary>
        /// close form and calls score method form other class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            FormGameBoard.Score(winOrLose, PointValue);
            Close();
        }

        private void FormQandA_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        /// <summary>
        /// starts timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormQandA_Shown_1(object sender, EventArgs e)
        {
            tmr = new Timer();
            //set time interval 60 sec
            tmr.Interval = 10000;
            //starts the timer
            tmr.Start();
            tmr.Tick += tmr_Tick;
        }
    }
}
