using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeWork.HomeWork5.Task2
{
    class Message
    {
        public string UserString { get; set; }

        public void ReadFile(string path)
        {
            StreamReader streamReader = new StreamReader(path);
            bool trueRead = true;
            try
            {                
                UserString = streamReader.ReadToEnd();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Оштбка чтения файла {ex.Message}");
                Console.ReadLine();
                trueRead = false;
            }
            finally
            {
                streamReader.Close();
            }
            if (trueRead)
            {
                Console.WriteLine("Файл прочитан");
                Console.ReadLine();
            }
        }
        public void WriteToFile(string path)
        {
            StreamWriter streamWriter = new StreamWriter(path);
            bool trueWrite = true;
            try
            {                
                streamWriter.WriteLine(UserString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Оштбка записи файла {ex.Message}");
                Console.ReadLine();
                trueWrite = false;
            }
            finally
            {
                streamWriter.Close();
            }
            if (trueWrite)
            {
                Console.WriteLine("Файл записан");
                Console.ReadLine();
            }
        }
        public string WordsCertainLength(int len)
        {
            StringBuilder concatStr = new StringBuilder();
            MatchCollection matchCollection = new Regex(@"\b\w{" + len + @"}\b").Matches(UserString);
            foreach (Match item in matchCollection)
            {
                concatStr.Append(item.Value + ", ");
            }
            if (concatStr.Length > 0)
            {
                concatStr.Remove(concatStr.Length - 2, 2);
            }            
            return concatStr.ToString();
        }
        public void DeleteWordsStartingWith(string str)
        {
            StringBuilder editStr= new StringBuilder();
            editStr.Append(UserString);
            MatchCollection matchCollection = new Regex(@"\b" + str + @"\w*").Matches(UserString);
            foreach (Match item in matchCollection)
            {
                editStr.Replace(item.Value,"");
            }
            UserString = editStr.ToString();
        }
        public void DeleteWordsStartingWith(string str,StringBuilder stringBuilder)
        {
            MatchCollection matchCollection = new Regex(@"\b" + str + @"\w*").Matches(stringBuilder.ToString());
            foreach (Match item in matchCollection)
            {
                stringBuilder.Replace(item.Value, "");
            }
        }
        public string MaxWord(string str = "")
        {
            string sourceString = "";
            sourceString = str == "" ? UserString : str;
            string[] vs = sourceString.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
            string maxWord = "";
            foreach (string word in vs)
            {
                if (word.Length > maxWord.Length)
                {
                    maxWord = word;
                }
            }
            return maxWord;
        }
        public string LongestWords(int countWords)
        {
            
            StringBuilder sourceString = new StringBuilder().Append(UserString);
            StringBuilder resultString = new StringBuilder();
            string maxWord = "";
            for (int i = 1; i <= countWords; i++)
            {
                maxWord = MaxWord(sourceString.ToString());
                resultString.Append(maxWord + " ");
                DeleteWordsStartingWith(maxWord,sourceString);
            }
            return resultString.Remove(resultString.Length - 1, 1).ToString();
        }

    }
}
