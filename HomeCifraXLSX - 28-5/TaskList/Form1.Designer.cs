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
            ListTasksDGV = new DataGridView();
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
            nameTask = new DataGridViewTextBoxColumn();
            statsTask = new DataGridViewTextBoxColumn();
            dateTask = new DataGridViewTextBoxColumn();
            prirityTask = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ListTasksDGV).BeginInit();
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
            // ListTasksDGV
            // 
            ListTasksDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListTasksDGV.Columns.AddRange(new DataGridViewColumn[] { nameTask, statsTask, dateTask, prirityTask });
            ListTasksDGV.Location = new Point(12, 27);
            ListTasksDGV.Name = "ListTasksDGV";
            ListTasksDGV.RowTemplate.Height = 25;
            ListTasksDGV.Size = new Size(690, 411);
            ListTasksDGV.TabIndex = 1;
            // 
            // NameTaskTB
            // 
            NameTaskTB.Location = new Point(708, 27);
            NameTaskTB.Name = "NameTaskTB";
            NameTaskTB.Size = new Size(153, 23);
            NameTaskTB.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(708, 9);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 4;
            label2.Text = "Название задачи";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(708, 58);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 7;
            label4.Text = "Дата сдачи";
            // 
            // DateTaskDTP
            // 
            DateTaskDTP.Location = new Point(708, 76);
            DateTaskDTP.Name = "DateTaskDTP";
            DateTaskDTP.Size = new Size(151, 23);
            DateTaskDTP.TabIndex = 8;
            // 
            // PriorityTaskCB
            // 
            PriorityTaskCB.FormattingEnabled = true;
            PriorityTaskCB.Items.AddRange(new object[] { "Низкий", "Средний", "Высокий" });
            PriorityTaskCB.Location = new Point(708, 120);
            PriorityTaskCB.Name = "PriorityTaskCB";
            PriorityTaskCB.Size = new Size(151, 23);
            PriorityTaskCB.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(708, 102);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 10;
            label5.Text = "Приоритет";
            // 
            // AddTaskBT
            // 
            AddTaskBT.Location = new Point(706, 149);
            AddTaskBT.Name = "AddTaskBT";
            AddTaskBT.Size = new Size(153, 35);
            AddTaskBT.TabIndex = 11;
            AddTaskBT.Text = "Добавить задачу";
            AddTaskBT.UseVisualStyleBackColor = true;
            AddTaskBT.Click += AddTaskBT_Click;
            // 
            // RemoveTaskBT
            // 
            RemoveTaskBT.Location = new Point(706, 190);
            RemoveTaskBT.Name = "RemoveTaskBT";
            RemoveTaskBT.Size = new Size(153, 35);
            RemoveTaskBT.TabIndex = 13;
            RemoveTaskBT.Text = "Удалить задачу";
            RemoveTaskBT.UseVisualStyleBackColor = true;
            RemoveTaskBT.Click += RemoveTaskBT_Click;
            // 
            // SaveBT
            // 
            SaveBT.Location = new Point(706, 403);
            SaveBT.Name = "SaveBT";
            SaveBT.Size = new Size(153, 35);
            SaveBT.TabIndex = 14;
            SaveBT.Text = "Сохранить изменения";
            SaveBT.UseVisualStyleBackColor = true;
            SaveBT.Click += SaveBT_Click;
            // 
            // EndTaskBT
            // 
            EndTaskBT.Location = new Point(706, 362);
            EndTaskBT.Name = "EndTaskBT";
            EndTaskBT.Size = new Size(153, 35);
            EndTaskBT.TabIndex = 15;
            EndTaskBT.Text = "Завершить задачу";
            EndTaskBT.UseVisualStyleBackColor = true;
            EndTaskBT.Click += EndTaskBT_Click;
            // 
            // nameTask
            // 
            nameTask.Frozen = true;
            nameTask.HeaderText = "Название";
            nameTask.Name = "nameTask";
            nameTask.ReadOnly = true;
            nameTask.SortMode = DataGridViewColumnSortMode.NotSortable;
            nameTask.Width = 250;
            // 
            // statsTask
            // 
            statsTask.Frozen = true;
            statsTask.HeaderText = "Статус";
            statsTask.Name = "statsTask";
            statsTask.ReadOnly = true;
            statsTask.Width = 150;
            // 
            // dateTask
            // 
            dateTask.Frozen = true;
            dateTask.HeaderText = "Срок здачи";
            dateTask.Name = "dateTask";
            dateTask.ReadOnly = true;
            dateTask.Width = 150;
            // 
            // prirityTask
            // 
            prirityTask.Frozen = true;
            prirityTask.HeaderText = "Приоритет";
            prirityTask.Name = "prirityTask";
            prirityTask.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(864, 450);
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
            Controls.Add(ListTasksDGV);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Список задач";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)ListTasksDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private DataGridViewTextBoxColumn nameTask;
        private DataGridViewTextBoxColumn statsTask;
        private DataGridViewTextBoxColumn dateTask;
        private DataGridViewTextBoxColumn prirityTask;
    }
}