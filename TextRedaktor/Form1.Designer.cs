namespace TextRedaktor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public void SetTextBoxText(string text)
        {
            richTextBox1.Text = text;
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            создатьToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьКакToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            правкаToolStripMenuItem = new ToolStripMenuItem();
            отменитьToolStripMenuItem = new ToolStripMenuItem();
            выделитьВсёToolStripMenuItem = new ToolStripMenuItem();
            вырезатьToolStripMenuItem = new ToolStripMenuItem();
            копироватьToolStripMenuItem = new ToolStripMenuItem();
            вставитьToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            найтиToolStripMenuItem = new ToolStripMenuItem();
            шрифтToolStripMenuItem = new ToolStripMenuItem();
            переносПоСловамToolStripMenuItem = new ToolStripMenuItem();
            настройкиШрифтаToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            pageSetupDialog1 = new PageSetupDialog();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.BackColor = SystemColors.InactiveBorder;
            richTextBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.HideSelection = false;
            richTextBox1.Location = new Point(0, 24);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 401);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.WordWrap = false;
            richTextBox1.SelectionChanged += richTextBox1_SelectionChanged_1;
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            richTextBox1.Leave += richTextBox1_Leave_1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, правкаToolStripMenuItem, шрифтToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { создатьToolStripMenuItem, открытьToolStripMenuItem, сохранитьToolStripMenuItem, сохранитьКакToolStripMenuItem, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            создатьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            создатьToolStripMenuItem.Size = new Size(232, 22);
            создатьToolStripMenuItem.Text = "Создать";
            создатьToolStripMenuItem.Click += создатьToolStripMenuItem_Click;
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            открытьToolStripMenuItem.Size = new Size(232, 22);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            сохранитьToolStripMenuItem.Size = new Size(232, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // сохранитьКакToolStripMenuItem
            // 
            сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            сохранитьКакToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            сохранитьКакToolStripMenuItem.Size = new Size(232, 22);
            сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            сохранитьКакToolStripMenuItem.Click += сохранитьКакToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(232, 22);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // правкаToolStripMenuItem
            // 
            правкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { отменитьToolStripMenuItem, выделитьВсёToolStripMenuItem, вырезатьToolStripMenuItem, копироватьToolStripMenuItem, вставитьToolStripMenuItem, удалитьToolStripMenuItem, найтиToolStripMenuItem });
            правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            правкаToolStripMenuItem.Size = new Size(59, 20);
            правкаToolStripMenuItem.Text = "Правка";
            // 
            // отменитьToolStripMenuItem
            // 
            отменитьToolStripMenuItem.Name = "отменитьToolStripMenuItem";
            отменитьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            отменитьToolStripMenuItem.Size = new Size(212, 22);
            отменитьToolStripMenuItem.Text = "Отменить";
            отменитьToolStripMenuItem.Click += отменитьToolStripMenuItem_Click;
            // 
            // выделитьВсёToolStripMenuItem
            // 
            выделитьВсёToolStripMenuItem.Name = "выделитьВсёToolStripMenuItem";
            выделитьВсёToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            выделитьВсёToolStripMenuItem.Size = new Size(212, 22);
            выделитьВсёToolStripMenuItem.Text = "Выделить всё";
            выделитьВсёToolStripMenuItem.Click += выделитьВсёToolStripMenuItem_Click_1;
            // 
            // вырезатьToolStripMenuItem
            // 
            вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            вырезатьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            вырезатьToolStripMenuItem.Size = new Size(212, 22);
            вырезатьToolStripMenuItem.Text = "Вырезать";
            вырезатьToolStripMenuItem.Click += вырезатьToolStripMenuItem_Click;
            // 
            // копироватьToolStripMenuItem
            // 
            копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            копироватьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            копироватьToolStripMenuItem.Size = new Size(212, 22);
            копироватьToolStripMenuItem.Text = "Копировать";
            копироватьToolStripMenuItem.Click += копироватьToolStripMenuItem_Click;
            // 
            // вставитьToolStripMenuItem
            // 
            вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            вставитьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            вставитьToolStripMenuItem.Size = new Size(212, 22);
            вставитьToolStripMenuItem.Text = "Вставить";
            вставитьToolStripMenuItem.Click += вставитьToolStripMenuItem_Click;
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.ShortcutKeys = Keys.Delete;
            удалитьToolStripMenuItem.Size = new Size(212, 22);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
            // 
            // найтиToolStripMenuItem
            // 
            найтиToolStripMenuItem.Name = "найтиToolStripMenuItem";
            найтиToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            найтиToolStripMenuItem.Size = new Size(212, 22);
            найтиToolStripMenuItem.Text = "Найти и заменить";
            найтиToolStripMenuItem.Click += найтиToolStripMenuItem_Click;
            // 
            // шрифтToolStripMenuItem
            // 
            шрифтToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { переносПоСловамToolStripMenuItem, настройкиШрифтаToolStripMenuItem });
            шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            шрифтToolStripMenuItem.Size = new Size(62, 20);
            шрифтToolStripMenuItem.Text = "Формат";
            // 
            // переносПоСловамToolStripMenuItem
            // 
            переносПоСловамToolStripMenuItem.Name = "переносПоСловамToolStripMenuItem";
            переносПоСловамToolStripMenuItem.Size = new Size(183, 22);
            переносПоСловамToolStripMenuItem.Text = "Перенос по словам";
            переносПоСловамToolStripMenuItem.Click += переносПоСловамToolStripMenuItem_Click;
            // 
            // настройкиШрифтаToolStripMenuItem
            // 
            настройкиШрифтаToolStripMenuItem.Name = "настройкиШрифтаToolStripMenuItem";
            настройкиШрифтаToolStripMenuItem.Size = new Size(183, 22);
            настройкиШрифтаToolStripMenuItem.Text = "Шрифт";
            настройкиШрифтаToolStripMenuItem.Click += настройкиШрифтаToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            statusStrip1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            statusStrip1.Dock = DockStyle.None;
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 425);
            statusStrip1.MaximumSize = new Size(800, 25);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RenderMode = ToolStripRenderMode.ManagerRenderMode;
            statusStrip1.Size = new Size(145, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(52, 17);
            toolStripStatusLabel1.Text = "Строк: 0";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(76, 17);
            toolStripStatusLabel2.Text = "Символов: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Блокнот";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem правкаToolStripMenuItem;
        private ToolStripMenuItem копироватьToolStripMenuItem;
        private ToolStripMenuItem вставитьToolStripMenuItem;
        private ToolStripMenuItem вырезатьToolStripMenuItem;
        private ToolStripMenuItem шрифтToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem настройкиШрифтаToolStripMenuItem;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem переносПоСловамToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem отменитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem найтиToolStripMenuItem;
        private ToolStripMenuItem аААToolStripMenuItem;
        private PageSetupDialog pageSetupDialog1;
        private ToolStripMenuItem выделитьВсёToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
    }
}