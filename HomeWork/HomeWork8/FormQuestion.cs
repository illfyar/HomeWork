using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork.HomeWork8
{
    /// <summary>
    /// Форма для изменения вопроса
    /// </summary>
    public partial class FormQuestion : Form
    {
        /// <summary>
        /// структура вопроса
        /// </summary>
        public Question question;
        /// <summary>
        /// Статус ответа на вопрос
        /// </summary>
        private StatusesAnswer StatusAnswer {get;set;}
        private bool modified;
        /// <summary>
        /// Признак модифицированности данных вопроса
        /// </summary>
        private bool Modified { 
            get { return modified;  } 
            set 
            {
                if (value == true)
                {
                    Text = Text.Replace("*", "");
                    Text += "*";
                }
                else 
                {
                    Text = Text.Replace("*", "");
                }
                modified = value;
            } 
        }
        public FormQuestion()
        {
            InitializeComponent();
            this.question = new Question();
            StatusAnswer = StatusesAnswer.Undefined;
        }
        public FormQuestion(Question question)
        {
            InitializeComponent();
            this.question = question;
            this.textQuestion.Text = question.QuestionText;
            if (question.Truth == StatusesAnswer.Truth)
            {
                this.pictureTruth.BackColor = Color.Lime;
                StatusAnswer = StatusesAnswer.Truth;
            }
            else if(question.Truth == StatusesAnswer.Truth)
            {
                this.pictureLie.BackColor = Color.Lime;
                StatusAnswer = StatusesAnswer.Lie;
            }
        }
        private void pictureTruth_Click(object sender, EventArgs e)
        {
            this.pictureTruth.BackColor = Color.Lime;
            this.pictureLie.BackColor = Color.Transparent;
            Modified = true;
        }
        private void pictureLie_Click(object sender, EventArgs e)
        {
            this.pictureLie.BackColor = Color.Lime;
            this.pictureTruth.BackColor = Color.Transparent;
            Modified = true;
        }

        private void saveQuestion_Click(object sender, EventArgs e)
        {
            question.QuestionText = this.textQuestion.Text;
            question.Truth = StatusAnswer;
            Modified = false;
        }
        private void pictureTruth_BackColorChanged(object sender, EventArgs e)
        {
            if ((sender is PictureBox) && (sender as PictureBox).BackColor == Color.Lime)
            {
                StatusAnswer = StatusesAnswer.Truth;
            }
        }
        private void pictureLie_BackColorChanged(object sender, EventArgs e)
        {
            if ((sender is PictureBox) && (sender as PictureBox).BackColor == Color.Lime)
            {
                StatusAnswer = StatusesAnswer.Lie;
            }
        }
        private void closeFormButton_Click(object sender, EventArgs e)
        {
            if (Modified)
            {
                DialogResult dialogResult = MessageBox.Show("Созранить изменения?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    question.QuestionText = textQuestion.Text;
                    question.Truth = this.StatusAnswer;
                }
            }
            Close();
        }
        private void textQuestion_TextChanged(object sender, EventArgs e)
        {
            Modified = true;
        }
    }
}
