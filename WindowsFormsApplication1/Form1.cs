using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryTutorial
{
    public partial class Form1 : Form
    {
        private BinaryTutorialResult btr = new BinaryTutorialResult();
        private Random num = new Random();
        private ToolTip submitButtonTooltip, newButtonTooltip;
        private String startingText = "Instructions: When counting in binary the least significant digit (the lowest digit in the set) is typically found farthest to the right. Every space going to the left is one power of 2 greater in value then the one before. From right to left the values above are 1, 2, 4, 8, 16, 32, 64 and 128.\nUsing the buttons you can select different combinations to view their combined value in the text box.";
        private String gameModeText = "Instructions: Click the new button to generate a random number within an 8-bit range.\nUsing the buttons select binary digits that total the number shown then press submit.\nIf you did it correctly the number will turn green! Way to go!\nKeep trying til you get it right!";

        public Form1()
        {
            
            InitializeComponent();
        }

        private void binaryTutorialButton128_Click(object sender, EventArgs e)
        {
            binaryTutorialButton128.onClick(btr);
            resultBox.Text = btr.toString();
        }

        private void binaryTutorialButton64_Click(object sender, EventArgs e)
        {
            binaryTutorialButton64.onClick(btr);
            resultBox.Text = btr.toString();
        }

        private void binaryTutorialButton32_Click(object sender, EventArgs e)
        {
            binaryTutorialButton32.onClick(btr);
            resultBox.Text = btr.toString();
        }

        private void binaryTutorialButton16_Click(object sender, EventArgs e)
        {
            binaryTutorialButton16.onClick(btr);
            resultBox.Text = btr.toString();
        }

        private void binaryTutorialButton8_Click(object sender, EventArgs e)
        {
            binaryTutorialButton8.onClick(btr);
            resultBox.Text = btr.toString();
        }

        private void binaryTutorialButton4_Click(object sender, EventArgs e)
        {
            binaryTutorialButton4.onClick(btr);
            resultBox.Text = btr.toString();
        }

        private void binaryTutorialButton2_Click(object sender, EventArgs e)
        {
            binaryTutorialButton2.onClick(btr);
            resultBox.Text = btr.toString();
        }

        private void binaryTutorialButton1_Click(object sender, EventArgs e)
        {
            binaryTutorialButton1.onClick(btr);
            resultBox.Text = btr.toString();
        }

        private void practiceModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.Compare(practiceModeToolStripMenuItem.Text, "Practice Mode") == 0)
            {
                practiceModeToolStripMenuItem.Text = "Game Mode";
                resultBox.Hide();
                label1.Text = "";
                label1.ForeColor = Color.Black;
                label1.Show();
                submitAnswer.Show();
                getNewRandomNumber.Show();
                label2.Text = gameModeText;
            }
            else if (string.Compare(practiceModeToolStripMenuItem.Text, "Game Mode") == 0)
            {
                practiceModeToolStripMenuItem.Text = "Practice Mode";
                resultBox.Show();
                label1.Hide();
                submitAnswer.Hide();
                getNewRandomNumber.Hide();
                label2.Text = startingText;
            }
        }

        private void getNewRandomNumber_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
            label1.Text = num.Next(255).ToString();
        }

        private void submitAnswer_Click(object sender, EventArgs e)
        {
            if (string.Compare(label1.Text, btr.toString()) == 0)
            {
                label1.ForeColor = Color.Lime;
            }
            else
            {
                label1.ForeColor = Color.Red;
            }
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            submitButtonTooltip = new ToolTip();
            newButtonTooltip = new ToolTip();
            submitButtonTooltip.SetToolTip(submitAnswer, "Check if your answer was correct!");
            newButtonTooltip.SetToolTip(getNewRandomNumber, "Randomly get a new number to try and match.");
            label2.Text = startingText;
        }
    }
}
