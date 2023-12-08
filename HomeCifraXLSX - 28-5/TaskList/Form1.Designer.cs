namespace TaskList
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
            this.label1 = new System.Windows.Forms.Label();
            this.ListTasksDGV = new System.Windows.Forms.DataGridView();
            this.NameTaskTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DateTaskDTP = new System.Windows.Forms.DateTimePicker();
            this.PriorityTaskCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddTaskBT = new System.Windows.Forms.Button();
            this.RemoveTaskBT = new System.Windows.Forms.Button();
            this.SaveBT = new System.Windows.Forms.Button();
            this.EndTaskBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListTasksDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список задач";
            // 
            // ListTasksDGV
            // 
            this.ListTasksDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListTasksDGV.Location = new System.Drawing.Point(12, 27);
            this.ListTasksDGV.Name = "ListTasksDGV";
            this.ListTasksDGV.RowTemplate.Height = 25;
            this.ListTasksDGV.Size = new System.Drawing.Size(617, 411);
            this.ListTasksDGV.TabIndex = 1;
            // 
            // NameTaskTB
            // 
            this.NameTaskTB.Location = new System.Drawing.Point(635, 27);
            this.NameTaskTB.Name = "NameTaskTB";
            this.NameTaskTB.Size = new System.Drawing.Size(153, 23);
            this.NameTaskTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(635, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Название задачи";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(635, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дата сдачи";
            // 
            // DateTaskDTP
            // 
            this.DateTaskDTP.Location = new System.Drawing.Point(635, 76);
            this.DateTaskDTP.Name = "DateTaskDTP";
            this.DateTaskDTP.Size = new System.Drawing.Size(151, 23);
            this.DateTaskDTP.TabIndex = 8;
            // 
            // PriorityTaskCB
            // 
            this.PriorityTaskCB.FormattingEnabled = true;
            this.PriorityTaskCB.Items.AddRange(new object[] {
            "Низкий",
            "Средний",
            "Высокий"});
            this.PriorityTaskCB.Location = new System.Drawing.Point(633, 120);
            this.PriorityTaskCB.Name = "PriorityTaskCB";
            this.PriorityTaskCB.Size = new System.Drawing.Size(153, 23);
            this.PriorityTaskCB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(635, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Приоритет";
            // 
            // AddTaskBT
            // 
            this.AddTaskBT.Location = new System.Drawing.Point(635, 149);
            this.AddTaskBT.Name = "AddTaskBT";
            this.AddTaskBT.Size = new System.Drawing.Size(151, 35);
            this.AddTaskBT.TabIndex = 11;
            this.AddTaskBT.Text = "Добавить задачу";
            this.AddTaskBT.UseVisualStyleBackColor = true;
            this.AddTaskBT.Click += new System.EventHandler(this.AddTaskBT_Click);
            // 
            // RemoveTaskBT
            // 
            this.RemoveTaskBT.Location = new System.Drawing.Point(635, 190);
            this.RemoveTaskBT.Name = "RemoveTaskBT";
            this.RemoveTaskBT.Size = new System.Drawing.Size(151, 35);
            this.RemoveTaskBT.TabIndex = 13;
            this.RemoveTaskBT.Text = "Удалить задачу";
            this.RemoveTaskBT.UseVisualStyleBackColor = true;
            // 
            // SaveBT
            // 
            this.SaveBT.Location = new System.Drawing.Point(635, 403);
            this.SaveBT.Name = "SaveBT";
            this.SaveBT.Size = new System.Drawing.Size(151, 35);
            this.SaveBT.TabIndex = 14;
            this.SaveBT.Text = "Сохранить изменения";
            this.SaveBT.UseVisualStyleBackColor = true;
            this.SaveBT.Click += new System.EventHandler(this.SaveBT_Click);
            // 
            // EndTaskBT
            // 
            this.EndTaskBT.Location = new System.Drawing.Point(633, 362);
            this.EndTaskBT.Name = "EndTaskBT";
            this.EndTaskBT.Size = new System.Drawing.Size(153, 35);
            this.EndTaskBT.TabIndex = 15;
            this.EndTaskBT.Text = "Завершить задачу";
            this.EndTaskBT.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EndTaskBT);
            this.Controls.Add(this.SaveBT);
            this.Controls.Add(this.RemoveTaskBT);
            this.Controls.Add(this.AddTaskBT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PriorityTaskCB);
            this.Controls.Add(this.DateTaskDTP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTaskTB);
            this.Controls.Add(this.ListTasksDGV);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список задач";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ListTasksDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView ListTasksDGV;
        private TextBox NameTaskTB;
        private Label label2;
        private Label label4;
        private DateTimePicker DateTaskDTP;
        private ComboBox PriorityTaskCB;
        private Label label5;
        private Button AddTaskBT;
        private Button RemoveTaskBT;
        private Button SaveBT;
        private Button EndTaskBT;
    }
}