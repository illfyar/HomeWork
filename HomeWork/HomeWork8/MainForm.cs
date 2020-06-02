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
    public partial class MainForm : Form
    {
        TruthOrLie TruthOrLie { get; set; }
        public MainForm()
        {
            InitializeComponent();
            TruthOrLie = new TruthOrLie();
            TruthOrLie.AddEventUpdateInfo(UpdateInfo);
            UpdateInfo();
        }
        private void previousButton_Click(object sender, EventArgs e)
        {
            TruthOrLie.PreviousQuestion();
        }
        private void UpdateInfo()
        {
            Question question = TruthOrLie.ReturnQuestion();
            this.numberQuestion.Text = "Вопрос №" + question.NumberQuestion;
            this.questionText.Text = question.QuestionText;
            this.pictureTruthUserAnsver.BackColor = Color.Transparent;
            this.pictureLieUserAnsver.BackColor = Color.Transparent;            
            if (question.UserAnswer == StatusesAnswer.Truth)
            {
                pictureTruthUserAnsver.BackColor = ReturnColorAnswer(StatusesAnswer.Truth, question);
            }
            else if(question.UserAnswer == StatusesAnswer.Lie)
            {
                pictureLieUserAnsver.BackColor = ReturnColorAnswer(StatusesAnswer.Lie, question);
            }
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            TruthOrLie.NextQuestion();
        }
        private void AddQuestionButton_Click(object sender, EventArgs e)
        {
            FormQuestion formQuestion = new FormQuestion();
            formQuestion.ShowDialog();
            Question question = formQuestion.question;
            TruthOrLie.AddQuestion(formQuestion.question);
        }
        private void EditQuestionButton_Click(object sender, EventArgs e)
        {
            FormQuestion formQuestion = new FormQuestion();
            formQuestion.ShowDialog();
            Question question = formQuestion.question;
            TruthOrLie.InsertQuestion(formQuestion.question);
        }
        private void pictureTruthUserAnsver_Click(object sender, EventArgs e)
        {
            Question question = TruthOrLie.ReturnQuestion();
            question.UserAnswer = StatusesAnswer.Truth;
            TruthOrLie.InsertQuestion(question);
        }
        private void pictureLieUserAnsver_Click(object sender, EventArgs e)
        {
            Question question = TruthOrLie.ReturnQuestion();
            question.UserAnswer = StatusesAnswer.Lie;
            TruthOrLie.InsertQuestion(question);
        }
        /// <summary>
        /// Проверка соответствия ответа пользователя и правильного ответа
        /// </summary>
        /// <param name="statusesAnswer"></param>
        /// <returns></returns>
        private Color ReturnColorAnswer(StatusesAnswer statusesAnswer,Question question)
        {
            if (question.Truth ==  statusesAnswer)
            {
                return Color.Lime;
            }
            else
            {
                return Color.Red;
            }
        }
        private void SaveQuestionsButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string messageError = TruthOrLie.SaveQuestions(saveFileDialog.FileName);
                if (messageError != "")
                {
                    MessageBox.Show(messageError, "Ошибка сохранения");
                }
            }
        }
        private void deleteQuestion_Click(object sender, EventArgs e)
        {
            TruthOrLie.RemovQuestion();
        }

        private void openQuestionsButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Diles (*.xml)|*.xml|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string messageError = TruthOrLie.LoadQuestions(openFileDialog.FileName);
                if (messageError != "")
                {
                    MessageBox.Show(messageError, "Ошибка загрузки");
                }
            }
        }
    }
}
