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
            openFileDialog1.Filter = "��������� ����� (*.txt)|*.txt|���� RTF (*.rtf)|*.rtf";
            saveFileDialog1.Filter = "��������� ����� (*.txt)|*.txt|���� RTF (*.rtf)|*.rtf";

            richTextBox1.WordWrap = false; // ��������� ������� �����

            // �������� ������������ � �������������� ������ ���������
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Both;




            ��������ToolStripMenuItem.Enabled = false;
            ��������ToolStripMenuItem.Enabled = false;
            ����������ToolStripMenuItem.Enabled = false;
            �������ToolStripMenuItem.Enabled = false;
            ����������ToolStripMenuItem.Enabled = false;

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
                ������������ToolStripMenuItem_Click(null, null);
            }
            openFileDialog1.FileName = saveFileDialog1.FileName;
            richTextBox1.Modified = false;

            if (Path.GetFileName(openFileDialog1.FileName) == "")
            {
                this.Text = "�������";
            }

            else
                this.Text = Path.GetFileName(openFileDialog1.FileName);
            //MessageBox.Show("���� ������� �������!");

        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = openFileDialog1.FileName;
            //this.Text = openFileDialog1.FileName;
            Save();

            //MessageBox.Show("���� ������� �������!");

        }

        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            //{
            //    return; // ��������� ����, ���� ������ ������
            //}
            //string fileName = saveFileDialog1.FileName;
            //File.WriteAllText(fileName, richTextBox1.Text);
            //MessageBox.Show("���� ������� �������!");

            saveFileDialog1.FileName = Path.GetFileName(openFileDialog1.FileName);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Save();
            }

            ////MessageBox.Show("���� ������� �������!");
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Modified == true)
            {
                DialogResult resultOpen = MessageBox.Show("����� ��� ������.\n��������� ���������?", "����������", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resultOpen == DialogResult.Yes)
                {
                    saveFileDialog1.FileName = openFileDialog1.FileName;

                    Save();
                }
            }
            openFileDialog1.Filter = "��������� ����� (*.txt)|*.txt|���� RTF (*.rtf)|*.rtf";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return; // ��������� ����, ���� ������ ������
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
            MessageBox.Show("���� ������� ������!");

            //if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            //{
            //    return; // ��������� ����, ���� ������ ������
            //}
            //openFileDialog1.Filter = "��������� ����� (*.txt)|*.txt|���� RTF (*.rtf)|*.rtf";
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
            //MessageBox.Show("���� ������� ������!");
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0) //�������� �� ����� ��
            {
                richTextBox1.Copy();
            }
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Cut();

            }
        }

        private void ���������������ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void ���ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Modified == true)
            {
                DialogResult resultCreate = MessageBox.Show("����� ��� ������.\n��������� ���������?", "����������", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resultCreate == DialogResult.Yes)
                {
                    //saveFileDialog1.FileName = openFileDialog1.FileName;

                    Save();
                }


            }
            this.Text = "�������";
            richTextBox1.Clear();
            richTextBox1.Modified = false;
            ��������ToolStripMenuItem.Enabled = false;
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (richTextBox1.Modified == false) return;
            if (richTextBox1.Modified == true)
            {
                DialogResult resultClose = MessageBox.Show("�� ������ ��������� ���������?", "����������", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resultClose == DialogResult.Yes)
                {
                    saveFileDialog1.FileName = openFileDialog1.FileName;
                    Save();
                }

            }
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
                richTextBox1.SelectedText = "";
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
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
        //private void ���������������()
        //{
        //    string[] words = richTextBox1.Text.Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        //    richTextBox1.Clear();
        //    foreach (string word in words)
        //    {
        //        richTextBox1.AppendText(word + Environment.NewLine);
        //    }
        //}

        private void ���������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ���������������();
            //������� �� �������
            if (richTextBox1.WordWrap != true)
            {
                richTextBox1.WordWrap = true;
                ���������������ToolStripMenuItem.Checked = true;
            }
            else
            {
                richTextBox1.WordWrap = false;
                ���������������ToolStripMenuItem.Checked = false;
            }

            ToolStripLabel linesLabel = new ToolStripLabel(richTextBox1.Lines.Length.ToString());
            ToolStripLabel charactersLabel = new ToolStripLabel(richTextBox1.TextLength.ToString());
            linesLabel.Text = "�����: " + (richTextBox1.GetLineFromCharIndex(richTextBox1.TextLength) + 1).ToString();
            charactersLabel.Text = "��������: " + richTextBox1.Text.Length;
            statusStrip1.Items.Clear();
            statusStrip1.Items.Add(linesLabel);
            statusStrip1.Items.Add(charactersLabel);
        }

        private void richTextBox1_SelectionChanged_1(object sender, EventArgs e)
        {
            ��������ToolStripMenuItem.Enabled = true;
            if (richTextBox1.SelectedText != "")
            {
                ��������ToolStripMenuItem.Enabled = true;
                ����������ToolStripMenuItem.Enabled = true;
                �������ToolStripMenuItem.Enabled = true;
            }
            else
            {
                ��������ToolStripMenuItem.Enabled = false;
                ����������ToolStripMenuItem.Enabled = false;
                �������ToolStripMenuItem.Enabled = false;
            }
        }

        private void richTextBox1_Leave_1(object sender, EventArgs e)
        {
            ��������ToolStripMenuItem.Enabled = false;
            ����������ToolStripMenuItem.Enabled = false;
            �������ToolStripMenuItem.Enabled = false;
        }

        private void CheckClipboard()
        {
            if (Clipboard.ContainsText())
            {
                ��������ToolStripMenuItem.Enabled = true;
            }
            else
            {
                ��������ToolStripMenuItem.Enabled = false;
            }
        }

        private void ����������ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private ToolStripLabel linesLabel;

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

            ToolStripLabel linesLabel = new ToolStripLabel(richTextBox1.Lines.Length.ToString());
            ToolStripLabel charactersLabel = new ToolStripLabel(richTextBox1.TextLength.ToString());
            linesLabel.Text = "�����: " + (richTextBox1.GetLineFromCharIndex(richTextBox1.TextLength) + 1).ToString();
            charactersLabel.Text = "��������: " + richTextBox1.Text.Length;
            statusStrip1.Items.Clear();
            statusStrip1.Items.Add(linesLabel);
            statusStrip1.Items.Add(charactersLabel);

            ����������ToolStripMenuItem.Enabled = richTextBox1.TextLength > 0;
        }
    }
}