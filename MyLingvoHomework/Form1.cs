using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MyLingvoHomework.Models;

namespace MyLingvoHomework
{
    public partial class Form1 : Form
    {
        private readonly string _filePath;
        private readonly XDocument _doc;
        private readonly XElement _root;
        private readonly Dictionary<string, Word> _wordsTranslete;

        public Form1()
        {
            InitializeComponent();
            _filePath = @"..\..\Data\Word.xml";
            _doc = XDocument.Load(_filePath);
            _root = _doc.Root;
            _wordsTranslete = new Dictionary<string, Word>();
            LoadData();
        }

        private bool IsEnglishWord(string word)
        {
            return _wordsTranslete.Any(pair => pair.Value.En == word);
        }

        private bool IsUkrainianWord(string word)
        {
            return _wordsTranslete.Any(pair => pair.Value.Ua == word);
        }
    private void LoadData()
        {
            foreach (XElement wordElement in _root.Elements("word"))
            {
                var newWord = new Word()
                {
                    En = wordElement.Attribute("en").Value,
                    Ua = wordElement.Attribute("ua").Value,
                    Ex1 = wordElement.Attribute("ex1").Value,
                    Ex2 = wordElement.Attribute("ex2").Value
                };
                _wordsTranslete.Add(newWord.En, newWord);
                _wordsTranslete.Add(newWord.Ua, newWord);
            }
        }
        private void TransButton_Click(object sender, EventArgs e)
        {
            var targetWord = InputWord.Text;
            if (string.IsNullOrWhiteSpace(targetWord))
            {
                MessageBox.Show("Ви не ввели слово для перекладу!!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if ((checkBox1.Checked && !IsEnglishWord(targetWord)) || (!checkBox1.Checked && !IsUkrainianWord(targetWord)))
                {
                    MessageBox.Show("Введенное слово не соответствует текущему направлению перевода!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    InputWord.Clear();
                    InputWord.Focus();
                    return;
                }
                var wordExists = _wordsTranslete.ContainsKey(targetWord) || _wordsTranslete.ContainsValue(new Word() { Ua = targetWord });
                if (!wordExists)
                {
                    MessageBox.Show("Такого слова немає в словнику!!", "Провал", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    InputWord.Clear();
                    InputWord.Focus();
                }
                else
                {
                    var result = _wordsTranslete.Values.FirstOrDefault(w => w.En == targetWord || w.Ua == targetWord);
                    if (checkBox1.Checked)
                    {
                        Tran1.Items.Add(result.En);
                        Tran2.Items.Add(result.Ua);
                        Ex1.Items.Add(result.Ex1);
                        Ex2.Items.Add(result.Ex2);
                    }
                    else
                    {
                        Tran1.Items.Add(result.Ua);
                        Tran2.Items.Add(result.En);
                        Ex1.Items.Add(result.Ex2);
                        Ex2.Items.Add(result.Ex1);
                    }
                }
            }
        
        }
    }
}
