using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Lucky7s
{
    public partial class frmLucky7s : Form
    {
        public frmLucky7s()
        {
            InitializeComponent();
        }

        int win = 0;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdAbout_Click(object sender, EventArgs e)
        {
            if (win != 1)
            {
                win = 1;
            }
            else {
                win = 0;
            }
            MessageBox.Show("Lucky 7s by Quinn Prisbrey, January 2019", "About Lucky 7s");
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            int intNum1 = 0, intNum2 = 0, intNum3 = 0;
            int intCounter = 0;
            while (intCounter < 10)
            {
                if (win == 1)
                {
                    Random rnd = new Random();
                    intNum1 = rnd.Next(1, 10); // creates a number between 1 and 9
                    intNum2 = rnd.Next(1, 10); // creates a number between 1 and 9
                    intNum3 = rnd.Next(1, 10); // creates a number between 1 and 9
                    picPenny.Visible = false;
                    picCoins.Visible = false;
                    picMoney.Visible = false;

                    Random rndColor = new Random();
                    Color.FromArgb(rndColor.Next(1, 255),
                    rndColor.Next(1, 255), rndColor.Next(1, 255));
                    lblNumber1.ForeColor = Color.FromArgb(rndColor.Next(1, 255),
                    rndColor.Next(1, 255), rndColor.Next(1, 255));
                    lblNumber2.ForeColor = Color.FromArgb(rndColor.Next(1, 255),
                    rndColor.Next(1, 255), rndColor.Next(1, 255));
                    lblNumber3.ForeColor = Color.FromArgb(rndColor.Next(1, 255),
                    rndColor.Next(1, 255), rndColor.Next(1, 255));

                    lblNumber1.Text = Convert.ToString(intNum1);
                    lblNumber2.Text = Convert.ToString(intNum2);
                    lblNumber3.Text = Convert.ToString(intNum3);

                    lblNumber1.Refresh();
                    Thread.Sleep(50);
                    lblNumber2.Refresh();
                    Thread.Sleep(50);
                    lblNumber3.Refresh();
                    intCounter++;
                    if (intCounter >= 10)
                    {
                        picMoney.Visible = true;
                        intNum1 = 7;
                        intNum2 = 7;
                        intNum3 = 7;

                        lblNumber1.Text = Convert.ToString(intNum1);
                        lblNumber2.Text = Convert.ToString(intNum2);
                        lblNumber3.Text = Convert.ToString(intNum3);

                    }

                }
                else {
                    Random rnd = new Random();
                    intNum1 = rnd.Next(1, 10); // creates a number between 1 and 9
                    intNum2 = rnd.Next(1, 10); // creates a number between 1 and 9
                    intNum3 = rnd.Next(1, 10); // creates a number between 1 and 9
                    picPenny.Visible = false;
                    picCoins.Visible = false;
                    picMoney.Visible = false;

                    lblNumber1.Text = Convert.ToString(intNum1);
                    lblNumber2.Text = Convert.ToString(intNum2);
                    lblNumber3.Text = Convert.ToString(intNum3);

                    Random rndColor = new Random();
                    Color.FromArgb(rndColor.Next(1, 255),
                    rndColor.Next(1, 255), rndColor.Next(1, 255));
                    lblNumber1.ForeColor = Color.FromArgb(rndColor.Next(1, 255),
                    rndColor.Next(1, 255), rndColor.Next(1, 255));
                    lblNumber2.ForeColor = Color.FromArgb(rndColor.Next(1, 255),
                    rndColor.Next(1, 255), rndColor.Next(1, 255));
                    lblNumber3.ForeColor = Color.FromArgb(rndColor.Next(1, 255),
                    rndColor.Next(1, 255), rndColor.Next(1, 255));

                    lblNumber1.Refresh();
                    Thread.Sleep(50);
                    lblNumber2.Refresh();
                    Thread.Sleep(50);
                    lblNumber3.Refresh();
                    intCounter++;
                }
            }

            lblResults.Text = "Spin Again.";

            /// Check to see if all the numbers are 7
            if (intNum1 == 7 && intNum2 == 7 && intNum3 == 7)
            {
                lblResults.Text = "Lucky Seven Winner!";
                picMoney.Visible = true;
            }
            else if (intNum1 == intNum2 && intNum2 == intNum3)
            {
                lblResults.Text = "Three in a Row!";
                picCoins.Visible = true;
            }
            else if(intNum1 == intNum2 || intNum2 == intNum3 || intNum1 == intNum3)
{
                lblResults.Text = "Two out of three!";
                picPenny.Visible = true;
            }

        }
    }
}
