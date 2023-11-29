namespace CsvReaders
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
            DataCsvFileDGV = new DataGridView();
            OpenCsvFileBT = new Button();
            SaveCsvFileBT = new Button();
            ((System.ComponentModel.ISupportInitialize)DataCsvFileDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "CSV файл";
            // 
            // DataCsvFileDGV
            // 
            DataCsvFileDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataCsvFileDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataCsvFileDGV.Location = new Point(12, 27);
            DataCsvFileDGV.Name = "DataCsvFileDGV";
            DataCsvFileDGV.RowTemplate.Height = 25;
            DataCsvFileDGV.Size = new Size(648, 223);
            DataCsvFileDGV.TabIndex = 1;
            // 
            // OpenCsvFileBT
            // 
            OpenCsvFileBT.Location = new Point(12, 256);
            OpenCsvFileBT.Name = "OpenCsvFileBT";
            OpenCsvFileBT.Size = new Size(192, 32);
            OpenCsvFileBT.TabIndex = 2;
            OpenCsvFileBT.Text = "Открыть";
            OpenCsvFileBT.UseVisualStyleBackColor = true;
            OpenCsvFileBT.Click += OpenCsvFileBT_Click;
            // 
            // SaveCsvFileBT
            // 
            SaveCsvFileBT.Location = new Point(459, 256);
            SaveCsvFileBT.Name = "SaveCsvFileBT";
            SaveCsvFileBT.Size = new Size(201, 32);
            SaveCsvFileBT.TabIndex = 3;
            SaveCsvFileBT.Text = "Сохранить";
            SaveCsvFileBT.UseVisualStyleBackColor = true;
            SaveCsvFileBT.Click += SaveCsvFileBT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 294);
            Controls.Add(SaveCsvFileBT);
            Controls.Add(OpenCsvFileBT);
            Controls.Add(DataCsvFileDGV);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DataCsvFileDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView DataCsvFileDGV;
        private Button OpenCsvFileBT;
        private Button SaveCsvFileBT;
    }
}