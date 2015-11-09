/*
 * Created by: Perry Martin
 * Created on: 09-11-2015
 * Created for: ICS3U
 * Daily Assignment – Unit#4-06
 * This program displays two String
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringComparison
{
    public partial class frmString : Form
    {
        public bool StringComparing(string first, string second)
        {
            bool answer = false;

            string firstUpper;
            string secondUpper;

            firstUpper = first.ToUpper();
            secondUpper = second.ToUpper();

            if (firstUpper.Length == secondUpper.Length)
            {
                if (firstUpper == secondUpper)
                {
                    answer = true;
                }
            }
            else
            {
                answer = false;
            }


            return answer;
        }


        public frmString()
        {
          InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Varribles & input

            string Upper = this.txtFirstString.Text;
            string Lowwer = this.txtSecondString.Text;
            bool answer;
            // Process

            answer = StringComparing(Upper, Lowwer);

            if (answer == true)
            {
                this.lblAnswer.Text = "They are the same.";
            }
            else if (answer == false)
            {
                this.lblAnswer.Text = "They are not the same sorry";
            }

        }
    }
}
