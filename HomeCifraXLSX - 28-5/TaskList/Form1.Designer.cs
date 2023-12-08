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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            NameTask = new DataGridViewTextBoxColumn();
            StatusTask = new DataGridViewTextBoxColumn();
            DateTask = new DataGridViewTextBoxColumn();
            PriorityTask = new DataGridViewTextBoxColumn();
            NameTaskTB = new TextBox();
            label2 = new Label();
            label4 = new Label();
            DateTaskDTP = new DateTimePicker();
            PriorityTaskCB = new ComboBox();
            label5 = new Label();
            AddTaskBT = new Button();
            RemoveTaskBT = new Button();
            SaveBT = new Button();
            EndTaskBT = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Список задач";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NameTask, StatusTask, DateTask, PriorityTask });
            dataGridView1.Location = new Point(12, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(617, 411);
            dataGridView1.TabIndex = 1;
            // 
            // NameTask
            // 
            NameTask.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NameTask.HeaderText = "Название";
            NameTask.Name = "NameTask";
            NameTask.ReadOnly = true;
            // 
            // StatusTask
            // 
            StatusTask.HeaderText = "Статус";
            StatusTask.Name = "StatusTask";
            StatusTask.ReadOnly = true;
            StatusTask.Width = 120;
            // 
            // DateTask
            // 
            DateTask.HeaderText = "Время";
            DateTask.Name = "DateTask";
            DateTask.ReadOnly = true;
            DateTask.Width = 150;
            // 
            // PriorityTask
            // 
            PriorityTask.HeaderText = "Приоритет";
            PriorityTask.Name = "PriorityTask";
            PriorityTask.ReadOnly = true;
            // 
            // NameTaskTB
            // 
            NameTaskTB.Location = new Point(635, 27);
            NameTaskTB.Name = "NameTaskTB";
            NameTaskTB.Size = new Size(153, 23);
            NameTaskTB.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(635, 9);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 4;
            label2.Text = "Название задачи";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(635, 58);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 7;
            label4.Text = "Дата сдачи";
            // 
            // DateTaskDTP
            // 
            DateTaskDTP.Location = new Point(635, 76);
            DateTaskDTP.Name = "DateTaskDTP";
            DateTaskDTP.Size = new Size(151, 23);
            DateTaskDTP.TabIndex = 8;
            // 
            // PriorityTaskCB
            // 
            PriorityTaskCB.FormattingEnabled = true;
            PriorityTaskCB.Items.AddRange(new object[] { "Низкий", "Средний", "Высокий" });
            PriorityTaskCB.Location = new Point(633, 120);
            PriorityTaskCB.Name = "PriorityTaskCB";
            PriorityTaskCB.Size = new Size(153, 23);
            PriorityTaskCB.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(635, 102);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 10;
            label5.Text = "Приоритет";
            // 
            // AddTaskBT
            // 
            AddTaskBT.Location = new Point(635, 149);
            AddTaskBT.Name = "AddTaskBT";
            AddTaskBT.Size = new Size(151, 35);
            AddTaskBT.TabIndex = 11;
            AddTaskBT.Text = "Добавить задачу";
            AddTaskBT.UseVisualStyleBackColor = true;
            // 
            // RemoveTaskBT
            // 
            RemoveTaskBT.Location = new Point(635, 190);
            RemoveTaskBT.Name = "RemoveTaskBT";
            RemoveTaskBT.Size = new Size(151, 35);
            RemoveTaskBT.TabIndex = 13;
            RemoveTaskBT.Text = "Удалить задачу";
            RemoveTaskBT.UseVisualStyleBackColor = true;
            // 
            // SaveBT
            // 
            SaveBT.Location = new Point(635, 403);
            SaveBT.Name = "SaveBT";
            SaveBT.Size = new Size(151, 35);
            SaveBT.TabIndex = 14;
            SaveBT.Text = "Сохранить изменения";
            SaveBT.UseVisualStyleBackColor = true;
            // 
            // EndTaskBT
            // 
            EndTaskBT.Location = new Point(633, 362);
            EndTaskBT.Name = "EndTaskBT";
            EndTaskBT.Size = new Size(153, 35);
            EndTaskBT.TabIndex = 15;
            EndTaskBT.Text = "Завершить задачу";
            EndTaskBT.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EndTaskBT);
            Controls.Add(SaveBT);
            Controls.Add(RemoveTaskBT);
            Controls.Add(AddTaskBT);
            Controls.Add(label5);
            Controls.Add(PriorityTaskCB);
            Controls.Add(DateTaskDTP);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(NameTaskTB);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Список задач";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NameTask;
        private DataGridViewTextBoxColumn StatusTask;
        private DataGridViewTextBoxColumn DateTask;
        private DataGridViewTextBoxColumn PriorityTask;
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