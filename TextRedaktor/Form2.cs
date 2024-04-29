using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TextRedaktor
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        private int numWordNow = 0;
        private bool caseSensitive = false;
        private List<int> SearchWord = new List<int>();

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        // Найти далее
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //int numWord = form1.richTextBox1.Find(textBoxSearch.Text, numWordNow, RichTextBoxFinds.MatchCase);//находим координату слова
            int numWord = form1.richTextBox1.Find(textBoxSearch.Text, numWordNow, caseSensitive ? RichTextBoxFinds.MatchCase : RichTextBoxFinds.None);
            if (numWord >= numWordNow)
            {
                form1.richTextBox1.Select(numWord, textBoxSearch.Text.Length);//выделяем фрагмент
                numWordNow = numWord + 1;
                SearchWord.Add(numWord);
                form1.richTextBox1.Select();
            }
            else
            {
                numWordNow = 0;
                SearchWord.Clear();
                form1.richTextBox1.Select(0, 0);
                MessageBox.Show("Больше нет совпадений");
            }
            ////form1.Select();
        }

        // Найти все
        //private void buttonSearchAll_Click(object sender, EventArgs e)
        //{
        //    //int numWord = form1.richTextBox1.Find(textBoxSearch.Text, numWordNow, );
        //    int numWord = form1.richTextBox1.Find(textBoxSearch.Text, 0, caseSensitive ? RichTextBoxFinds.MatchCase : RichTextBoxFinds.None);
        //    List<int> SearchWord = new List<int>();
        //    int count = 0;
        //    while (numWord >= 0)
        //    {
        //        SearchWord.Add(numWord);
        //        count++;
        //        numWord = form1.richTextBox1.Find(textBoxSearch.Text, numWord + 1, caseSensitive ? RichTextBoxFinds.MatchCase : RichTextBoxFinds.None);
        //    }
        //    if (count == 0)
        //    {
        //        MessageBox.Show("Совпадений не найдено");
        //    }
        //    else
        //    {
        //        StringBuilder result = new StringBuilder();
        //        result.AppendFormat("Найдено совпадений: {0}\n", count);
        //        MessageBox.Show(result.ToString());
        //    }
        //}

        // Заменить
        private void buttonReplace_Click(object sender, EventArgs e)
        {
            int replaceLength = textBoxReplace.Text.Length;
            //int numWord = form1.richTextBox1.Find(textBoxSearch.Text, numWordNow, RichTextBoxFinds.MatchCase);//находим координату слова
            int numWord = form1.richTextBox1.Find(textBoxSearch.Text, numWordNow, caseSensitive ? RichTextBoxFinds.MatchCase : RichTextBoxFinds.None);
            if (numWord >= numWordNow)
            {
                form1.richTextBox1.Select(numWord, textBoxSearch.Text.Length); //выделяем фрагмент
                numWordNow = numWord + replaceLength;
                SearchWord.Add(numWord);
                form1.richTextBox1.Select();

                if (form1.richTextBox1.SelectedText == textBoxSearch.Text)
                {
                    form1.richTextBox1.SelectedText = textBoxReplace.Text;
                }
            }
            else
            {
                numWordNow = 0;
                SearchWord.Clear();
                form1.richTextBox1.Select(0, 0);
                MessageBox.Show("Больше нет совпадений");
            }
            form1.Select();

            //int findCutLength = 0;
            //if (form1.richTextBox1.SelectedText != "")
            //{
            //    int startSearchIndex = findCutLength;
            //    int resultPosition = form1.richTextBox1.Text.IndexOf(textBoxSearch.Text, startSearchIndex);
            //    if (resultPosition != -1)
            //    {
            //        form1.richTextBox1.Select(resultPosition, textBoxSearch.Text.Length);
            //        form1.richTextBox1.SelectedText = textBoxReplace.Text;
            //        form1.richTextBox1.ScrollToCaret();
            //        form1.richTextBox1.Focus();
            //        findCutLength = resultPosition + textBoxReplace.Text.Length + textBoxReplace.Text.Length;
            //    }
            //    else
            //    {
            //        findCutLength = 0;
            //        MessageBox.Show("По вашему запросу ничего не нашлось.", "Совпадений не найдено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}



        }

        // Заменить всё
        private void buttonReplaceAll_Click(object sender, EventArgs e)
        {
            numWordNow = 0;
            SearchWord.Clear();
            buttonSearch_Click(null, null);
            while (form1.richTextBox1.SelectedText != "")
            {
                form1.richTextBox1.SelectedText = textBoxReplace.Text;
                numWordNow += textBoxReplace.Text.Length - 1;
                buttonSearch_Click(null, null);
            }
        }

        private void textBoxSearch_TextChanged_1(object sender, EventArgs e)
        {
            SearchWord.Clear();
        }

        private void textBoxReplace_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void Form2_Activated(object sender, EventArgs e)
        {

        }

        private void Form2_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing_1(object sender, FormClosingEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            caseSensitive = checkBox1.Checked;
        }




        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string text = textBox1.Text;
        //    Form1 form1 = (Form1)Application.OpenForms["Form1"];
        //    if (form1 != null)
        //    {
        //        form1.SetTextBoxText(text);
        //    }
        //}
    }
}
