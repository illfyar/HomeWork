using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork.HomeWork7.Task2
{
    public partial class MainForm : Form
    {
        GuessNumberGame guessNumberGame;
        public MainForm()
        {
            InitializeComponent();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guessNumberGame = new GuessNumberGame();
            textBox1.Enabled = true;
            Check.Enabled = true;
            UpdateInfo();
        }
        void UpdateInfo()
        {
            countAttempts.Text = guessNumberGame.CounAttempt.ToString();
            textBox2.AppendText(textBox2.Text == ""? guessNumberGame.History.Last() : Environment.NewLine + guessNumberGame.History.Last());
            if (guessNumberGame.Position == Positions.over)
            {
                labelOver.ForeColor = Color.Red;
                labelLess.ForeColor = Color.Black;
            }
            else if (guessNumberGame.Position == Positions.less)
            {
                labelOver.ForeColor = Color.Black;
                labelLess.ForeColor = Color.Red;
            }else if (guessNumberGame.Position == Positions.equally)
            {
                labelOver.ForeColor = Color.Black;
                labelLess.ForeColor = Color.Black;
                textBox1.Enabled = false;
                Check.Enabled = false;
            }else if (guessNumberGame.Position == Positions.undefined)
            {
                labelOver.ForeColor = Color.Black;
                labelLess.ForeColor = Color.Black;
            }
        }

        private void Check_Click(object sender, EventArgs e)
        {
            guessNumberGame.CheckAnswer(textBox1.Text);
            UpdateInfo();
        }
    }
}
