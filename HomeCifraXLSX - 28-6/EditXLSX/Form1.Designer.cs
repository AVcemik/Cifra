namespace EditXLSX
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
            ExcelDGV = new DataGridView();
            OpenBT = new Button();
            openFileOPF = new OpenFileDialog();
            SaveAsBT = new Button();
            saveFileSFD = new SaveFileDialog();
            AddColumnBT = new Button();
            NewTableBT = new Button();
            DeleteRowBT = new Button();
            DeleteColumnBT = new Button();
            SaveBT = new Button();
            ((System.ComponentModel.ISupportInitialize)ExcelDGV).BeginInit();
            SuspendLayout();
            // 
            // ExcelDGV
            // 
            ExcelDGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ExcelDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ExcelDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ExcelDGV.Location = new Point(12, 12);
            ExcelDGV.Name = "ExcelDGV";
            ExcelDGV.RowTemplate.Height = 25;
            ExcelDGV.Size = new Size(649, 426);
            ExcelDGV.TabIndex = 0;
            // 
            // OpenBT
            // 
            OpenBT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            OpenBT.Location = new Point(669, 53);
            OpenBT.Name = "OpenBT";
            OpenBT.Size = new Size(123, 35);
            OpenBT.TabIndex = 1;
            OpenBT.Text = "Открыть";
            OpenBT.UseVisualStyleBackColor = true;
            OpenBT.Click += OpenBT_Click;
            // 
            // openFileOPF
            // 
            openFileOPF.FileName = "openFileDialog1";
            openFileOPF.Filter = "*.xlsx | *.xlsx";
            // 
            // SaveAsBT
            // 
            SaveAsBT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SaveAsBT.Location = new Point(669, 402);
            SaveAsBT.Name = "SaveAsBT";
            SaveAsBT.Size = new Size(123, 35);
            SaveAsBT.TabIndex = 2;
            SaveAsBT.Text = "Сохранить как";
            SaveAsBT.UseVisualStyleBackColor = true;
            SaveAsBT.Click += SaveAsBT_Click;
            // 
            // saveFileSFD
            // 
            saveFileSFD.Filter = "*.xlsx | *.xlsx";
            // 
            // AddColumnBT
            // 
            AddColumnBT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddColumnBT.Location = new Point(669, 170);
            AddColumnBT.Name = "AddColumnBT";
            AddColumnBT.Size = new Size(123, 35);
            AddColumnBT.TabIndex = 3;
            AddColumnBT.Text = "Добавить столбец";
            AddColumnBT.UseVisualStyleBackColor = true;
            AddColumnBT.Click += AddColumnBT_Click;
            // 
            // NewTableBT
            // 
            NewTableBT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            NewTableBT.Location = new Point(669, 12);
            NewTableBT.Name = "NewTableBT";
            NewTableBT.Size = new Size(123, 35);
            NewTableBT.TabIndex = 4;
            NewTableBT.Text = "Новая таблица";
            NewTableBT.UseVisualStyleBackColor = true;
            NewTableBT.Click += NewTableBT_Click;
            // 
            // DeleteRowBT
            // 
            DeleteRowBT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteRowBT.Location = new Point(669, 211);
            DeleteRowBT.Name = "DeleteRowBT";
            DeleteRowBT.Size = new Size(123, 35);
            DeleteRowBT.TabIndex = 5;
            DeleteRowBT.Text = "Удалить строку";
            DeleteRowBT.UseVisualStyleBackColor = true;
            DeleteRowBT.Click += DeleteRowBT_Click;
            // 
            // DeleteColumnBT
            // 
            DeleteColumnBT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteColumnBT.Location = new Point(669, 252);
            DeleteColumnBT.Name = "DeleteColumnBT";
            DeleteColumnBT.Size = new Size(123, 35);
            DeleteColumnBT.TabIndex = 6;
            DeleteColumnBT.Text = "Удалить столбец";
            DeleteColumnBT.UseVisualStyleBackColor = true;
            DeleteColumnBT.Click += DeleteColumnBT_Click;
            // 
            // SaveBT
            // 
            SaveBT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SaveBT.Location = new Point(669, 361);
            SaveBT.Name = "SaveBT";
            SaveBT.Size = new Size(123, 35);
            SaveBT.TabIndex = 7;
            SaveBT.Text = "Сохранить";
            SaveBT.UseVisualStyleBackColor = true;
            SaveBT.Click += SaveBT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(798, 450);
            Controls.Add(SaveBT);
            Controls.Add(DeleteColumnBT);
            Controls.Add(DeleteRowBT);
            Controls.Add(NewTableBT);
            Controls.Add(AddColumnBT);
            Controls.Add(SaveAsBT);
            Controls.Add(OpenBT);
            Controls.Add(ExcelDGV);
            Name = "Form1";
            Text = "Редактор Excel";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)ExcelDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ExcelDGV;
        private Button OpenBT;
        private OpenFileDialog openFileOPF;
        private Button SaveAsBT;
        private SaveFileDialog saveFileSFD;
        private Button AddColumnBT;
        private Button NewTableBT;
        private Button DeleteRowBT;
        private Button DeleteColumnBT;
        private Button SaveBT;
    }
}