namespace TextRedaktor
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            buttonSearch = new Button();
            buttonReplace = new Button();
            buttonReplaceAll = new Button();
            textBoxReplace = new TextBox();
            textBoxSearch = new TextBox();
            label1 = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(282, 12);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 23);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Найти далее";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonReplace
            // 
            buttonReplace.Location = new Point(282, 41);
            buttonReplace.Name = "buttonReplace";
            buttonReplace.Size = new Size(94, 23);
            buttonReplace.TabIndex = 3;
            buttonReplace.Text = "Заменить";
            buttonReplace.UseVisualStyleBackColor = true;
            buttonReplace.Click += buttonReplace_Click;
            // 
            // buttonReplaceAll
            // 
            buttonReplaceAll.Location = new Point(282, 70);
            buttonReplaceAll.Name = "buttonReplaceAll";
            buttonReplaceAll.Size = new Size(94, 23);
            buttonReplaceAll.TabIndex = 4;
            buttonReplaceAll.Text = "Заменить всё";
            buttonReplaceAll.UseVisualStyleBackColor = true;
            buttonReplaceAll.Click += buttonReplaceAll_Click;
            // 
            // textBoxReplace
            // 
            textBoxReplace.Location = new Point(86, 41);
            textBoxReplace.Name = "textBoxReplace";
            textBoxReplace.Size = new Size(190, 23);
            textBoxReplace.TabIndex = 6;
            textBoxReplace.TextChanged += textBoxReplace_TextChanged;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(86, 12);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(190, 23);
            textBoxSearch.TabIndex = 7;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 16);
            label1.Name = "label1";
            label1.Size = new Size(40, 13);
            label1.TabIndex = 8;
            label1.Text = "Найти";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 45);
            label2.Name = "label2";
            label2.Size = new Size(74, 13);
            label2.TabIndex = 9;
            label2.Text = "Заменить на";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 70);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(129, 19);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "С учётом регистра";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 108);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxSearch);
            Controls.Add(textBoxReplace);
            Controls.Add(buttonReplaceAll);
            Controls.Add(buttonReplace);
            Controls.Add(buttonSearch);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Найти и заменить";
            TopMost = true;
            Activated += Form2_Activated;
            FormClosing += Form2_FormClosing_1;
            Load += Form2_Load;
            VisibleChanged += Form2_VisibleChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Button buttonSearch;
        private Button buttonReplace;
        private Button buttonReplaceAll;
        private TextBox textBoxReplace;
        private TextBox textBoxSearch;
        private Label label1;
        private Label label2;
        private CheckBox checkBox1;

        public string TextBoxText
        {
            get { return textBoxSearch.Text; }
        }
    }
}