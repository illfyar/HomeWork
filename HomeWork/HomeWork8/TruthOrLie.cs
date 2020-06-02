using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HomeWork.HomeWork8
{    
    class TruthOrLie
    {
        public delegate void UpdateInfo();
        /// <summary>
        /// Событие для обновления данных MainForm
        /// </summary>
        private event UpdateInfo EUpdateInfo; 
        /// <summary>
        /// Структура вопросов
        /// </summary>
        private Questions QuestionsObj;        
        public TruthOrLie()
        {
            QuestionsObj.QuestionsList = new List<Question>();
            AddQuestion(new Question());
            EUpdateInfo?.Invoke();
        }
        /// <summary>
        /// Добавить вопрос в список вопросов
        /// </summary>
        /// <param name="question"></param>
        public void AddQuestion(Question question)
        {
            int CurrentNumberQuestion = QuestionsObj.QuestionsList.Count;
            question.NumberQuestion = CurrentNumberQuestion;
            QuestionsObj.QuestionsList.Add(question);
            QuestionsObj.CurrentNumberQuestion = CurrentNumberQuestion;
            EUpdateInfo?.Invoke();
        }
        /// <summary>
        /// Удаляет текущий вопрос из списка
        /// </summary>
        public void RemovQuestion()
        {
            QuestionsObj.QuestionsList.RemoveAt(QuestionsObj.CurrentNumberQuestion);
            if (QuestionsObj.QuestionsList.Count == 0)
            {
                AddQuestion(new Question());
                QuestionsObj.CurrentNumberQuestion = 0;
            }
            else
            {
                QuestionsObj.CurrentNumberQuestion = QuestionsObj.QuestionsList.Count - 1;
            }
            EUpdateInfo?.Invoke();
        }
        /// <summary>
        /// Переключает на следующий вопрос
        /// </summary>
        public void NextQuestion()
        {
            QuestionsObj.CurrentNumberQuestion = QuestionsObj.QuestionsList.Count - 1 == QuestionsObj.CurrentNumberQuestion ? 
                QuestionsObj.CurrentNumberQuestion : QuestionsObj.CurrentNumberQuestion + 1;
            EUpdateInfo?.Invoke();
        }
        /// <summary>
        /// Пеерключает на предыдущий вопрос
        /// </summary>
        public void PreviousQuestion()
        {
            QuestionsObj.CurrentNumberQuestion = QuestionsObj.CurrentNumberQuestion == 0 ? 0 : QuestionsObj.CurrentNumberQuestion - 1;
            EUpdateInfo?.Invoke();
        }
        /// <summary>
        /// Вставить вопрос в список вопросов на 
        /// позицию текущего вопроса.
        /// используется после редактирования вопроса
        /// </summary>
        /// <param name="question"></param>
        public void InsertQuestion(Question question)
        {
            QuestionsObj.QuestionsList[QuestionsObj.CurrentNumberQuestion] = question;
            EUpdateInfo?.Invoke();
        }
        /// <summary>
        /// Возвращает текущий вопрос
        /// </summary>
        /// <returns></returns>
        public Question ReturnQuestion()
        {
            return QuestionsObj.QuestionsList[QuestionsObj.CurrentNumberQuestion];
        }
        /// <summary>
        /// Установка метода для обновления информации на MainForm
        /// </summary>
        /// <param name="updateInfo"></param>
        public void AddEventUpdateInfo(UpdateInfo updateInfo)
        {
            EUpdateInfo += updateInfo;
        }
        /// <summary>
        /// Сохрание данных вопросов в XML
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>Если произошла ошибка то возвращает её сообщение, иначе пустую строку</returns>
        public string SaveQuestions(string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Questions));
            StreamWriter streamWriter = new StreamWriter(fileName, false);
            try
            {
                xmlSerializer.Serialize(streamWriter, QuestionsObj);
            }
            catch (Exception ex)
            {
                streamWriter.Close();
                return ex.Message;
            }
            streamWriter.Close();
            return "";
        }
        /// <summary>
        /// Создает структуру из загруженного файла
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>Если произошла ошибка то возвращает её сообщение, иначе пустую строку</returns>
        public string LoadQuestions(string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Questions));
            StreamReader streamReader = new StreamReader(fileName);
            try
            {
                QuestionsObj = (Questions)xmlSerializer.Deserialize(streamReader);
            }
            catch (Exception ex)
            {
                streamReader.Close();
                return ex.Message;
            }
            streamReader.Close();
            QuestionsObj.CurrentNumberQuestion = 0;
            EUpdateInfo?.Invoke();
            return "";
        }
    }
}
