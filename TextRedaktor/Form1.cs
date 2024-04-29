using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace TextRedaktor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Òåêñòîâûå ôàéëû (*.txt)|*.txt|Ôàéë RTF (*.rtf)|*.rtf";
            saveFileDialog1.Filter = "Òåêñòîâûå ôàéëû (*.txt)|*.txt|Ôàéë RTF (*.rtf)|*.rtf";

            richTextBox1.WordWrap = false; // çàïðåùàåì ïåðåíîñ ñòðîê

            // âêëþ÷àåì âåðòèêàëüíóþ è ãîðèçîíòàëüíóþ ïîëîñû ïðîêðóòêè
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Both;




            îòìåíèòüToolStripMenuItem.Enabled = false;
            âûðåçàòüToolStripMenuItem.Enabled = false;
            êîïèðîâàòüToolStripMenuItem.Enabled = false;
            óäàëèòüToolStripMenuItem.Enabled = false;
            âûäåëèòüÂñ¸ToolStripMenuItem.Enabled = false;

        }

        private void Save()
        {
            if (saveFileDialog1.FileName != "")
            {


                if (Path.GetExtension(saveFileDialog1.FileName) == ".txt")
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                else if (Path.GetExtension(saveFileDialog1.FileName) == ".rtf")
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
            else
            {
                ñîõðàíèòüÊàêToolStripMenuItem_Click(null, null);
            }
            openFileDialog1.FileName = saveFileDialog1.FileName;
            richTextBox1.Modified = false;

            if (Path.GetFileName(openFileDialog1.FileName) == "")
            {
                this.Text = "Áëîêíîò";
            }

            else
                this.Text = Path.GetFileName(openFileDialog1.FileName);
            //MessageBox.Show("Ôàéë óñïåøíî ñîõðàí¸í!");

        }

        private void ñîõðàíèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = openFileDialog1.FileName;
            //this.Text = openFileDialog1.FileName;
            Save();

            //MessageBox.Show("Ôàéë óñïåøíî ñîõðàí¸í!");

        }

        private void ñîõðàíèòüÊàêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            //{
            //    return; // çàêðûâàåì îêíî, åñëè íàæàòà îòìåíà
            //}
            //string fileName = saveFileDialog1.FileName;
            //File.WriteAllText(fileName, richTextBox1.Text);
            //MessageBox.Show("Ôàéë óñïåøíî ñîõðàí¸í!");

            saveFileDialog1.FileName = Path.GetFileName(openFileDialog1.FileName);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Save();
            }

            ////MessageBox.Show("Ôàéë óñïåøíî ñîõðàí¸í!");
        }

        private void îòêðûòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Modified == true)
            {
                DialogResult resultOpen = MessageBox.Show("Òåêñò áûë èçìåí¸í.\nÑîõðàíèòü èçìåíåíèÿ?", "Ñîõðàíåíèå", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resultOpen == DialogResult.Yes)
                {
                    saveFileDialog1.FileName = openFileDialog1.FileName;

                    Save();
                }
            }
            openFileDialog1.Filter = "Òåêñòîâûå ôàéëû (*.txt)|*.txt|Ôàéë RTF (*.rtf)|*.rtf";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return; // çàêðûâàåì îêíî, åñëè íàæàòà îòìåíà
            }


            if (Path.GetExtension(openFileDialog1.FileName) == ".rtf")
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
            else
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }

            richTextBox1.Modified = false;
            this.Text = Path.GetFileName(openFileDialog1.FileName);
            //saveFileDialog1.FileName = openFileDialog1.FileName;
            //this.Text = openFileDialog1.FileName;
            //string fileText = File.ReadAllText(fileName);
            //richTextBox1.Text = fileText;
            MessageBox.Show("Ôàéë óñïåøíî îòêðûò!");

            //if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            //{
            //    return; // çàêðûâàåì îêíî, åñëè íàæàòà îòìåíà
            //}
            //openFileDialog1.Filter = "Òåêñòîâûå ôàéëû (*.txt)|*.txt|Ôàéë RTF (*.rtf)|*.rtf";
            //string fileName = openFileDialog1.FileName;
            //if (Path.GetExtension(fileName) == ".rtf")
            //{
            //    richTextBox1.LoadFile(fileName, RichTextBoxStreamType.RichText);
            //}
            //else
            //{
            //    richTextBox1.LoadFile(fileName, RichTextBoxStreamType.PlainText);
            //}
            //saveFileDialog1.FileName = openFileDialog1.FileName;
            ////this.Text = openFileDialog1.FileName;
            ////string fileText = File.ReadAllText(fileName);
            ////richTextBox1.Text = fileText;
            //MessageBox.Show("Ôàéë óñïåøíî îòêðûò!");
        }

        private void îòìåíèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void êîïèðîâàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0) //ïðîâåðêà íå ïóñòî ëè
            {
                richTextBox1.Copy();
            }
        }

        private void âñòàâèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void âûðåçàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Cut();

            }
        }

        private void íàñòðîéêèØðèôòàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            dialog.ShowColor = true; // //

            DialogResult resultOK = dialog.ShowDialog();

            if (resultOK == DialogResult.OK)
            {

                richTextBox1.SelectionFont = dialog.Font;
                richTextBox1.SelectionColor = dialog.Color; // //
            }
        }

        private void ôîíToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }

        private void ñîçäàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Modified == true)
            {
                DialogResult resultCreate = MessageBox.Show("Òåêñò áûë èçìåí¸í.\nÑîõðàíèòü èçìåíåíèÿ?", "Ñîõðàíåíèå", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resultCreate == DialogResult.Yes)
                {
                    //saveFileDialog1.FileName = openFileDialog1.FileName;

                    Save();
                }


            }
            this.Text = "Áëîêíîò";
            richTextBox1.Clear();
            richTextBox1.Modified = false;
            îòìåíèòüToolStripMenuItem.Enabled = false;
        }

        private void âûõîäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (richTextBox1.Modified == false) return;
            if (richTextBox1.Modified == true)
            {
                DialogResult resultClose = MessageBox.Show("Âû õîòèòå ñîõðàíèòü èçìåíåíèÿ?", "Ñîõðàíåíèå", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resultClose == DialogResult.Yes)
                {
                    saveFileDialog1.FileName = openFileDialog1.FileName;
                    Save();
                }

            }
        }

        private void óäàëèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
                richTextBox1.SelectedText = "";
        }

        private void íàéòèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            //form2.Show();
            form2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckClipboard();
            statusStrip1.BringToFront();
        }
        //private void ÏåðåíîñÏîÑëîâàì()
        //{
        //    string[] words = richTextBox1.Text.Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        //    richTextBox1.Clear();
        //    foreach (string word in words)
        //    {
        //        richTextBox1.AppendText(word + Environment.NewLine);
        //    }
        //}

        private void ïåðåíîñÏîÑëîâàìToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ÏåðåíîñÏîÑëîâàì();
            //Ïåðåíîñ ïî ñòîëáàì
            if (richTextBox1.WordWrap != true)
            {
                richTextBox1.WordWrap = true;
                ïåðåíîñÏîÑëîâàìToolStripMenuItem.Checked = true;
            }
            else
            {
                richTextBox1.WordWrap = false;
                ïåðåíîñÏîÑëîâàìToolStripMenuItem.Checked = false;
            }

            ToolStripLabel linesLabel = new ToolStripLabel(richTextBox1.Lines.Length.ToString());
            ToolStripLabel charactersLabel = new ToolStripLabel(richTextBox1.TextLength.ToString());
            linesLabel.Text = "Ñòðîê: " + (richTextBox1.GetLineFromCharIndex(richTextBox1.TextLength) + 1).ToString();
            charactersLabel.Text = "Ñèìâîëîâ: " + richTextBox1.Text.Length;
            statusStrip1.Items.Clear();
            statusStrip1.Items.Add(linesLabel);
            statusStrip1.Items.Add(charactersLabel);
        }

        private void richTextBox1_SelectionChanged_1(object sender, EventArgs e)
        {
            îòìåíèòüToolStripMenuItem.Enabled = true;
            if (richTextBox1.SelectedText != "")
            {
                âûðåçàòüToolStripMenuItem.Enabled = true;
                êîïèðîâàòüToolStripMenuItem.Enabled = true;
                óäàëèòüToolStripMenuItem.Enabled = true;
            }
            else
            {
                âûðåçàòüToolStripMenuItem.Enabled = false;
                êîïèðîâàòüToolStripMenuItem.Enabled = false;
                óäàëèòüToolStripMenuItem.Enabled = false;
            }
        }

        private void richTextBox1_Leave_1(object sender, EventArgs e)
        {
            âûðåçàòüToolStripMenuItem.Enabled = false;
            êîïèðîâàòüToolStripMenuItem.Enabled = false;
            óäàëèòüToolStripMenuItem.Enabled = false;
        }

        private void CheckClipboard()
        {
            if (Clipboard.ContainsText())
            {
                âñòàâèòüToolStripMenuItem.Enabled = true;
            }
            else
            {
                âñòàâèòüToolStripMenuItem.Enabled = false;
            }
        }

        private void âûäåëèòüÂñ¸ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private ToolStripLabel linesLabel;

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

            ToolStripLabel linesLabel = new ToolStripLabel(richTextBox1.Lines.Length.ToString());
            ToolStripLabel charactersLabel = new ToolStripLabel(richTextBox1.TextLength.ToString());
            linesLabel.Text = "Ñòðîê: " + (richTextBox1.GetLineFromCharIndex(richTextBox1.TextLength) + 1).ToString();
            charactersLabel.Text = "Ñèìâîëîâ: " + richTextBox1.Text.Length;
            statusStrip1.Items.Clear();
            statusStrip1.Items.Add(linesLabel);
            statusStrip1.Items.Add(charactersLabel);

            âûäåëèòüÂñ¸ToolStripMenuItem.Enabled = richTextBox1.TextLength > 0;
        }
    }
}