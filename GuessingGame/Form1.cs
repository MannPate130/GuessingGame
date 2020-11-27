using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class guessingGame : Form
    {
        Random RandGen = new Random();
        int answer;
        int numberGuessed;

        public guessingGame()
        {
            InitializeComponent();
            answer = RandGen.Next(1, 101);
        }

        private void guessButton_Click(object sender, EventArgs e)
        {

            int numberGuessed = Convert.ToInt32(textBox.Text);
            

            if (numberGuessed > answer)
            {
                outputLabel.Text = "Too high";
            }
            else if (numberGuessed < answer)
            {
                outputLabel.Text = "Too low";
            }
            else
            {
                outputLabel.Text = "You Got It!!!";
            }

        }
        
        
    }
}
