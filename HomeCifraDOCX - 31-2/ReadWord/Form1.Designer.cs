namespace ReadWord
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            filePathTB = new TextBox();
            label2 = new Label();
            ParagraphTB = new TextBox();
            BoldCHB = new CheckBox();
            label3 = new Label();
            SetFontCB = new ComboBox();
            label4 = new Label();
            SetColorFontCB = new ComboBox();
            label5 = new Label();
            SetSizeFontTB = new TextBox();
            AddParagraphBT = new Button();
            SaveFileBT = new Button();
            OpenFileBT = new Button();
            editCheckLB = new Label();
            openOFD = new OpenFileDialog();
            label6 = new Label();
            SearchWordTB = new TextBox();
            label7 = new Label();
            EditWordTB = new TextBox();
            SetAligmentParagraphCB = new ComboBox();
            label8 = new Label();
            EditWordBT = new Button();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Путь к файлу";
            // 
            // filePathTB
            // 
            filePathTB.Enabled = false;
            filePathTB.Location = new Point(12, 27);
            filePathTB.Name = "filePathTB";
            filePathTB.Size = new Size(481, 23);
            filePathTB.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Параграф";
            // 
            // ParagraphTB
            // 
            ParagraphTB.Enabled = false;
            ParagraphTB.Location = new Point(12, 71);
            ParagraphTB.Multiline = true;
            ParagraphTB.Name = "ParagraphTB";
            ParagraphTB.Size = new Size(481, 385);
            ParagraphTB.TabIndex = 3;
            // 
            // BoldCHB
            // 
            BoldCHB.AutoSize = true;
            BoldCHB.Enabled = false;
            BoldCHB.Location = new Point(499, 73);
            BoldCHB.Name = "BoldCHB";
            BoldCHB.Size = new Size(74, 19);
            BoldCHB.TabIndex = 4;
            BoldCHB.Text = "Жирный";
            BoldCHB.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(499, 97);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 5;
            label3.Text = "Шрифт";
            // 
            // SetFontCB
            // 
            SetFontCB.DropDownStyle = ComboBoxStyle.DropDownList;
            SetFontCB.Enabled = false;
            SetFontCB.FormattingEnabled = true;
            SetFontCB.ImeMode = ImeMode.NoControl;
            SetFontCB.Items.AddRange(new object[] { "Arial", "Calibri", "TimesNewRoman" });
            SetFontCB.Location = new Point(499, 115);
            SetFontCB.Name = "SetFontCB";
            SetFontCB.Size = new Size(196, 23);
            SetFontCB.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(499, 141);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 7;
            label4.Text = "Цвет";
            // 
            // SetColorFontCB
            // 
            SetColorFontCB.DropDownStyle = ComboBoxStyle.DropDownList;
            SetColorFontCB.Enabled = false;
            SetColorFontCB.FormattingEnabled = true;
            SetColorFontCB.Items.AddRange(new object[] { "Черный", "Синий", "Зеленый", "Красный" });
            SetColorFontCB.Location = new Point(499, 159);
            SetColorFontCB.Name = "SetColorFontCB";
            SetColorFontCB.Size = new Size(196, 23);
            SetColorFontCB.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(499, 185);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 9;
            label5.Text = "Размер";
            // 
            // SetSizeFontTB
            // 
            SetSizeFontTB.Enabled = false;
            SetSizeFontTB.Location = new Point(499, 203);
            SetSizeFontTB.MaxLength = 3;
            SetSizeFontTB.Name = "SetSizeFontTB";
            SetSizeFontTB.Size = new Size(196, 23);
            SetSizeFontTB.TabIndex = 10;
            SetSizeFontTB.KeyPress += SetSizeFontTB_KeyPress;
            // 
            // AddParagraphBT
            // 
            AddParagraphBT.Enabled = false;
            AddParagraphBT.Location = new Point(12, 462);
            AddParagraphBT.Name = "AddParagraphBT";
            AddParagraphBT.Size = new Size(196, 34);
            AddParagraphBT.TabIndex = 11;
            AddParagraphBT.Text = "Добавить параграф";
            AddParagraphBT.UseVisualStyleBackColor = true;
            AddParagraphBT.Click += AddParagraphBT_Click;
            // 
            // SaveFileBT
            // 
            SaveFileBT.Enabled = false;
            SaveFileBT.Location = new Point(297, 462);
            SaveFileBT.Name = "SaveFileBT";
            SaveFileBT.Size = new Size(196, 34);
            SaveFileBT.TabIndex = 12;
            SaveFileBT.Text = "Сохранить";
            SaveFileBT.UseVisualStyleBackColor = true;
            SaveFileBT.Click += SaveFileBT_Click;
            // 
            // OpenFileBT
            // 
            OpenFileBT.Location = new Point(499, 27);
            OpenFileBT.Name = "OpenFileBT";
            OpenFileBT.Size = new Size(74, 23);
            OpenFileBT.TabIndex = 13;
            OpenFileBT.Text = "Открыть";
            OpenFileBT.UseVisualStyleBackColor = true;
            OpenFileBT.Click += OpenFileBT_Click;
            // 
            // editCheckLB
            // 
            editCheckLB.AutoSize = true;
            editCheckLB.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            editCheckLB.ForeColor = Color.Red;
            editCheckLB.Location = new Point(579, 25);
            editCheckLB.Name = "editCheckLB";
            editCheckLB.Size = new Size(37, 25);
            editCheckLB.TabIndex = 14;
            editCheckLB.Text = "❎";
            // 
            // openOFD
            // 
            openOFD.Filter = "*.docx | *docx";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(499, 291);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 15;
            label6.Text = "Найти текст:";
            // 
            // SearchWordTB
            // 
            SearchWordTB.Location = new Point(499, 309);
            SearchWordTB.Multiline = true;
            SearchWordTB.Name = "SearchWordTB";
            SearchWordTB.Size = new Size(196, 63);
            SearchWordTB.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(499, 375);
            label7.Name = "label7";
            label7.Size = new Size(110, 15);
            label7.TabIndex = 17;
            label7.Text = "Заменить текст на:";
            // 
            // EditWordTB
            // 
            EditWordTB.Location = new Point(499, 393);
            EditWordTB.Multiline = true;
            EditWordTB.Name = "EditWordTB";
            EditWordTB.Size = new Size(196, 63);
            EditWordTB.TabIndex = 18;
            // 
            // SetAligmentParagraphCB
            // 
            SetAligmentParagraphCB.DropDownStyle = ComboBoxStyle.DropDownList;
            SetAligmentParagraphCB.FormattingEnabled = true;
            SetAligmentParagraphCB.Items.AddRange(new object[] { "По левому краю", "По правому краю", "По центру", "Растянуть" });
            SetAligmentParagraphCB.Location = new Point(499, 247);
            SetAligmentParagraphCB.Name = "SetAligmentParagraphCB";
            SetAligmentParagraphCB.Size = new Size(196, 23);
            SetAligmentParagraphCB.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(499, 229);
            label8.Name = "label8";
            label8.Size = new Size(172, 15);
            label8.TabIndex = 20;
            label8.Text = "Вид выравнивания параграфа";
            // 
            // EditWordBT
            // 
            EditWordBT.Location = new Point(499, 462);
            EditWordBT.Name = "EditWordBT";
            EditWordBT.Size = new Size(196, 34);
            EditWordBT.TabIndex = 21;
            EditWordBT.Text = "Заменить текст";
            EditWordBT.UseVisualStyleBackColor = true;
            EditWordBT.Click += EditWordBT_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Enabled = false;
            label9.Location = new Point(499, 273);
            label9.Name = "label9";
            label9.Size = new Size(197, 15);
            label9.TabIndex = 22;
            label9.Text = "--------------------------------------";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(704, 514);
            Controls.Add(label9);
            Controls.Add(EditWordBT);
            Controls.Add(label8);
            Controls.Add(SetAligmentParagraphCB);
            Controls.Add(EditWordTB);
            Controls.Add(label7);
            Controls.Add(SearchWordTB);
            Controls.Add(label6);
            Controls.Add(editCheckLB);
            Controls.Add(OpenFileBT);
            Controls.Add(SaveFileBT);
            Controls.Add(AddParagraphBT);
            Controls.Add(SetSizeFontTB);
            Controls.Add(label5);
            Controls.Add(SetColorFontCB);
            Controls.Add(label4);
            Controls.Add(SetFontCB);
            Controls.Add(label3);
            Controls.Add(BoldCHB);
            Controls.Add(ParagraphTB);
            Controls.Add(label2);
            Controls.Add(filePathTB);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Операции с Word";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox filePathTB;
        private Label label2;
        private TextBox ParagraphTB;
        private CheckBox BoldCHB;
        private Label label3;
        private ComboBox SetFontCB;
        private Label label4;
        private ComboBox SetColorFontCB;
        private Label label5;
        private TextBox SetSizeFontTB;
        private Button AddParagraphBT;
        private Button SaveFileBT;
        private Button OpenFileBT;
        private Label editCheckLB;
        private OpenFileDialog openOFD;
        private Label label6;
        private TextBox SearchWordTB;
        private Label label7;
        private TextBox EditWordTB;
        private ComboBox SetAligmentParagraphCB;
        private Label label8;
        private Button EditWordBT;
        private Label label9;
    }
}