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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "Путь к файлу";
            // 
            // filePathTB
            // 
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
            ParagraphTB.Size = new Size(481, 374);
            ParagraphTB.TabIndex = 3;
            // 
            // BoldCHB
            // 
            BoldCHB.AutoSize = true;
            BoldCHB.Enabled = false;
            BoldCHB.Location = new Point(499, 73);
            BoldCHB.Name = "BoldCHB";
            BoldCHB.Size = new Size(78, 19);
            BoldCHB.TabIndex = 4;
            BoldCHB.Text = "Жирный";
            BoldCHB.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(499, 97);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 5;
            label3.Text = "Шрифт";
            // 
            // SetFontCB
            // 
            SetFontCB.Enabled = false;
            SetFontCB.FormattingEnabled = true;
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
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "Цвет";
            // 
            // SetColorFontCB
            // 
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
            label5.Size = new Size(49, 15);
            label5.TabIndex = 9;
            label5.Text = "Размер";
            // 
            // SetSizeFontTB
            // 
            SetSizeFontTB.Enabled = false;
            SetSizeFontTB.Location = new Point(499, 203);
            SetSizeFontTB.Name = "SetSizeFontTB";
            SetSizeFontTB.Size = new Size(196, 23);
            SetSizeFontTB.TabIndex = 10;
            // 
            // AddParagraphBT
            // 
            AddParagraphBT.Enabled = false;
            AddParagraphBT.Location = new Point(499, 232);
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
            SaveFileBT.Location = new Point(499, 409);
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
            editCheckLB.Text = "✅";
            // 
            // openOFD
            // 
            openOFD.FileName = "openOFD";
            openOFD.Filter = "*.docx | *docx";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 455);
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
    }
}