using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace Jeaopardy_App
{
    public partial class FormGameBoard : Form
    {
        /// <summary>
        /// variables
        /// </summary>
        public static string playerTurn = "1";
        public static string questionNumber = "0";
        public static int p1Score;
        public static int p2Score;
        public static string winOrLose = " ";
        public static int numPlayers = 1;
        public static int round = 0;
        private Timer GameTime;


        public FormGameBoard()
        {
            InitializeComponent();
        }
        /// <summary>
        /// calls option to get new players
        /// </summary>
        private void OptionsLoad()
        {
            this.Hide();
            var nextForm = new FormOptions();
            nextForm.Closed += (s, args) => this.Close();
            nextForm.Show();
        }

        /// <summary>
        /// checks for winner
        /// </summary>
        public static void Victory()
        {
            if (p1Score > p2Score)
            {
                MessageBox.Show("Congratulations, " + FormOptions.playerOne + "!!! You are victiorious!!!");
            }
            else if (p2Score > p1Score)
            {
                MessageBox.Show("Congratulations, " + FormOptions.playerTwo + "!!! You are victiorious!!!");
            }
            else
            {
                MessageBox.Show("TIE!!!!");
            }
        }

        /// <summary>
        /// Scoring
        /// </summary>
        /// <param name="winOrLose"></param>
        /// <param name="PointValue"></param>
        public static void Score(string winOrLose, int PointValue)
        {
            round = round + 1;
            if (FormOptions.playerCount == 2)
            {
                if (winOrLose == "w")
                {
                    if (playerTurn == "2")
                    {
                        p2Score += PointValue;
                        MessageBox.Show("Player 2 current Score: " + p2Score.ToString());
                    }
                    else
                    {
                        p1Score += PointValue;
                        MessageBox.Show("Player 1 current Score: " + p1Score.ToString());
                    }
                }
                else
                {
                    if (playerTurn == "2")
                    {
                        p2Score -= PointValue;
                        MessageBox.Show("Player 2 current Score: " + p2Score.ToString());
                    }
                    else
                    {
                        p1Score -= PointValue;
                        MessageBox.Show("Player 1 current Score: " + p1Score.ToString());
                    }
                }
            }
            else
            {
                if (winOrLose == "w")
                {
                    p1Score += PointValue;
                    MessageBox.Show("Player 1 current Score: " + p1Score.ToString());
                }
                else
                {
                    p1Score -= PointValue;
                    MessageBox.Show("Player 1 current Score: " + p1Score.ToString());
                }
            } 

            if (playerTurn == "1")
            {
                playerTurn = "2";
            }
            else
            {
                playerTurn = "1";
            }           
        }
        /// <summary>
        /// displays score to user
        /// </summary>
        private void NewScores()
        {
            txtBxP1Score.Text = p1Score.ToString();
            txtBxP2Score.Text = p2Score.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// timer for total game time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameTime_Tick(object sender, EventArgs e)
        {
            GameTime.Stop();
            GameTime.Dispose();
            MessageBox.Show("Sorry ran out of time! New game is starting!");
            OptionsLoad();
        }

        /// <summary>
        /// makes timer/ sets form up accorsing to options classs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormGameBoard_Load(object sender, EventArgs e)
        {
            lblPlayer1.Text = FormOptions.playerOne;
            lblPlayer2.Text = FormOptions.playerTwo;
            GameTime = new Timer();
            GameTime.Interval = 3600000;
            GameTime.Start();
            GameTime.Tick += GameTime_Tick;

            // discplays names-
            if (FormOptions.playerCount == 1)
            {
                lblPlayer1.Text = FormOptions.playerOne;
                lblPlayer2.Visible = false;
                txtBxP2Score.Visible = false;
            }
            else if (FormOptions.playerCount == 2)
            {
                lblPlayer1.Text = FormOptions.playerOne;
                lblPlayer2.Text = FormOptions.playerTwo;
            }
            else
            {               
            }
            
        }
        #region ---- Columns ----
        //First Column BUttons
        #region

        private void btn1Cat100_Click(object sender, EventArgs e)
        {
            int pValue = 100;
            string QAnswer = "Alan Turing";
            string Question = "Known as the questioner of the human mind, this man is known for helping tell humans and computers apart.";

            FormQandA qaForm = new FormQandA(Question, QAnswer, pValue);
            qaForm.Show();

            //Disables After Click
            btn1Cat100.Enabled = false;
            btn1Cat100.Text = " ";
        }

        private void btn1Cat200_Click(object sender, EventArgs e)
        {
            int pValue = 200;
            string QAnswer = "Grace Hopper";
            string Question = "This female pioneer of the COBOL computer programming language was an Admiral in the US Navy.";
            
            FormQandA qaForm = new FormQandA(Question, QAnswer, pValue);
            qaForm.Show();

            btn1Cat200.Enabled = false;
            btn1Cat200.Text = " ";
        }

        private void btn1Cat300_Click(object sender, EventArgs e)
        {
            int pValue = 300;
            string QAnswer = "Tim Berners-Lee";
            string Question = "Called the father of the world wide web, this man is the director of the W3C";
            
            FormQandA qaForm = new FormQandA(Question, QAnswer, pValue);
            qaForm.Show();

            btn1Cat300.Enabled = false;
            btn1Cat300.Text = " ";
        }

        private void btn1Cat400_Click(object sender, EventArgs e)
        {
            int pValue = 400;
            string QAnswer = "Lawrence Lessig";
            string Question = "An American academic and political activist who founded the Creative Commons, this man lobbies for reduced legal restrictions on copyrights and trademarks in the technology sector.";
            
            FormQandA qaForm = new FormQandA(Question, QAnswer, pValue);
            qaForm.Show();

            btn1Cat400.Enabled = false;
            btn1Cat400.Text = " ";
        }

        private void btn1Cat500_Click(object sender, EventArgs e)
        {
            int pValue = 500;
            string QAnswer = "Ada Lovelace";
            string Question = "This woman, known as the world's first computer programmer was also a Countess.";
            
            FormQandA qaForm = new FormQandA(Question, QAnswer, pValue);
            qaForm.Show();

            btn1Cat500.Enabled = false;
            btn1Cat500.Text = " ";
        }
        #endregion
        //Second Column Buttons
        #region
        private void btn2Cat100_Click(object sender, EventArgs e)
        {
            int pValue = 100;
            string QAnswer = "Concrete";
            string Question = "A class from which objects can be instatitated";
            
            FormQandA qaForm = new FormQandA(Question, QAnswer, pValue);
            qaForm.Show();

            btn2Cat100.Enabled = false;
            btn2Cat100.Text = " ";
        }

        private void btn2Cat200_Click(object sender, EventArgs e)
        {
            int pValue = 200;
            string QAnswer = "Base";
            string Question = "Derived class constructors can call base class constructors with a call to the same name.";
            
            FormQandA qaForm = new FormQandA(Question, QAnswer, pValue);
            qaForm.Show();

            btn2Cat200.Enabled = false;
            btn2Cat200.Text = " ";
        }

        private void btn2Cat300_Click(object sender, EventArgs e)
        {
            int pValue = 300;
            string QAnswer = "Derived class";
            string Question = "This class type can effect state changes in base class private members only through public, protected or internal methods.";
            
            FormQandA qaForm = new FormQandA(Question, QAnswer, pValue);
            qaForm.Show();

            btn2Cat300.Enabled = false;
            btn2Cat300.Text = " ";
        }

        private void btn2Cat400_Click(object sender, EventArgs e)
        {
            int pValue = 400;
            string QAnswer = "Garbage collector";
            string Question = "An invisible process that reclaims an object's memory.";
            
            FormQandA qaForm = new FormQandA(Question, QAnswer, pValue);
            qaForm.Show();

            btn2Cat400.Enabled = false;
            btn2Cat400.Text = " ";
        }

        private void btn2Cat500_Click(object sender, EventArgs e)
        {
            int pValue = 500;
            string QAnswer = "has-a";
            string Question = "A relationship between two objects in which one object is a part of another.";
            
            FormQandA qaForm = new FormQandA(Question, QAnswer, pValue);
            qaForm.Show();

            btn2Cat500.Enabled = false;
            btn2Cat500.Text = " ";
        }
        #endregion
        //Third Column Buttons
        #region
        private void btn3Cat100_Click(object sender, EventArgs e)
        {
            int pValue = 100;
            string QAnswer = "var";
            string Question = "The keyword for a generic data return type or object.";
            
            FormQandA qaForm = new FormQandA(Question, QAnswer, pValue);
            qaForm.Show();

            btn3Cat100.Enabled = false;
            btn3Cat100.Text = " ";
        }

        private void btn3Cat200_Click(object sender, EventArgs e)
        {
            int pValue = 200;
            string QAnswer = "List";
            string Question = "This data type is better and more efficient than an array and often used in LINQ.";
            
            FormQandA qaForm = new FormQandA(Question, QAnswer, pValue);
            qaForm.Show();

            btn3Cat200.Enabled = false;
            btn3Cat200.Text = " ";
        }

        private void btn3Cat300_Click(object sender, EventArgs e)
        {
            int pValue = 300;
            string QAnswer = "SQL";
            string Question = "This is the international standard for querying relational databases.";
            
            FormQandA qaForm = new FormQandA(Question, QAnswer, pValue);
            qaForm.Show();

            btn3Cat300.Enabled = false;
            btn3Cat300.Text = " ";
        }

        private void btn3Cat400_Click(object sender, EventArgs e)
        {
            int pValue = 400;
            string QAnswer = "Count";
            string Question = "This property will return the number of items in a LINQ query result.";
            
            FormQandA qaForm = new FormQandA(Question, QAnswer, pValue);
            qaForm.Show();

            btn3Cat400.Enabled = false;
            btn3Cat400.Text = " ";
        }

        private void btn3Cat500_Click(object sender, EventArgs e)
        {
            int pValue = 500;
            string QAnswer = "Capacity";
            string Question = "This property will return the number of elements available in a List.";
            
            FormQandA qaForm = new FormQandA(Question, QAnswer, pValue);
            qaForm.Show();

            btn4Cat500.Enabled = false;
            btn4Cat500.Text = " ";
        }
        #endregion
        //Fourth Column Buttons
        #region
        private void btn4Cat100_Click(object sender, EventArgs e)
        {
            int pValue = 100;
            string QAnswer = "Metacharacter";
            string Question = "These characters have special meaning in a regular expression and often represent concepts for matching.";
            
            FormQandA qaForm = new FormQandA(Question, QAnswer, pValue);
            qaForm.Show();

            btn4Cat100.Enabled = false;
            btn4Cat100.Text = " ";
        }

        private void btn4Cat200_Click(object sender, EventArgs e)
        {
            int pValue = 200;
            string QAnswer = "Question mark";
            string Question = "This metacharacter can describe how many times a part of the pattern may occur in a match.";
            
            FormQandA qaForm = new FormQandA(Question, QAnswer, pValue);
            qaForm.Show();

            btn4Cat200.Enabled = false;
            btn4Cat200.Text = " ";
        }

        private void btn4Cat300_Click(object sender, EventArgs e)
        {
            int pValue = 300;
            string QAnswer = "Pipe";
            string Question = "This metacharacter is known as the alternation and can match expressions on the left or the right.";
            
            FormQandA qaForm = new FormQandA(Question, QAnswer, pValue);
            qaForm.Show();

            btn4Cat300.Enabled = false;
            btn4Cat300.Text = " ";
        }

        private void btn4Cat400_Click(object sender, EventArgs e)
        {
            int pValue = 400;
            string QAnswer = "w";
            string Question = "This character class can represent any alphanumeric character or underscore.";
            
            FormQandA qaForm = new FormQandA(Question, QAnswer, pValue);
            qaForm.Show();

            btn4Cat400.Enabled = false;
            btn4Cat400.Text = " ";
        }

        private void btn4Cat500_Click(object sender, EventArgs e)
        {
            int pValue = 500;
            string QAnswer = "System.Text.RegularExpressions";
            string Question = "This namespace must be imported in an application before regular expression classes can be used.";
            
            FormQandA qaForm = new FormQandA(Question, QAnswer, pValue);
            qaForm.Show();

            btn4Cat500.Enabled = false;
            btn4Cat500.Text = " ";
        }
        #endregion
        //Fifth Column Buttons
        #region
        private void btn5Cat100_Click(object sender, EventArgs e)
        {
            int pValue = 100;
            string QAnswer = "Big O Notation";
            string Question = "This concept of data structures measures the efficiency of an algorithm.";
            
            FormQandA qaForm = new FormQandA(Question, QAnswer, pValue);
            qaForm.Show();

            btn5Cat100.Enabled = false;
            btn5Cat100.Text = " ";
        }

        private void btn5Cat200_Click(object sender, EventArgs e)
        {
            int pValue = 200;
            string QAnswer = "Leaf";
            string Question = "In a Tree, this is a node with no children.";
            
            FormQandA qaForm = new FormQandA(Question, QAnswer, pValue);
            qaForm.Show();

            btn5Cat200.Enabled = false;
            btn5Cat200.Text = " ";
        }

        private void btn5Cat300_Click(object sender, EventArgs e)
        {
            int pValue = 300;
            string QAnswer = "List";
            string Question = "Stacks must inherit from this class.";
            
            FormQandA qaForm = new FormQandA(Question, QAnswer, pValue);
            qaForm.Show();

            btn5Cat300.Enabled = false;
            btn5Cat300.Text = " ";
        }
        private void btn5Cat400_Click(object sender, EventArgs e)
        {
            int pValue = 400;
            string QAnswer = "Node";
            string Question = "This element of a Linked List can contain properties of any type.";
            
            FormQandA qaForm = new FormQandA(Question, QAnswer, pValue);
            qaForm.Show();

            btn5Cat400.Enabled = false;
            btn5Cat400.Text = " ";
        }
        private void btn5Cat500_Click(object sender, EventArgs e)
        {
            int pValue = 500;
            string QAnswer = "Self-referential";
            string Question = "This technique is used when a class calls it's own constructor.";
            
            FormQandA qaForm = new FormQandA(Question, QAnswer, pValue);
            qaForm.Show();

            btn5Cat500.Enabled = false;
            btn5Cat500.Text = " ";
        }
        #endregion
        #endregion
        /// <summary>
        /// starts new game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Victory();
            OptionsLoad();
        }
        /// <summary>
        /// closes app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormGameBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #region ---- UNNEEDED METHODS CLICKED ----
        private void txtBxP2Score_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPlayer2_Click(object sender, EventArgs e)
        {

        }

        private void FormGameBoard_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void FormGameBoard_VisibleChanged(object sender, EventArgs e)
        {
        }

        private void FormGameBoard_TextChanged(object sender, EventArgs e)
        {
        }

        private void FormGameBoard_MouseLeave(object sender, EventArgs e)
        {
        }

        #endregion
        /// <summary>
        /// checdks for victory and new scores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormGameBoard_MouseMove(object sender, MouseEventArgs e)
        {
            NewScores();
            if (round == 25)
            {
                Victory();
            }

        }
    }
}
