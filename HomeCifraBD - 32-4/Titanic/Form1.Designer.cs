namespace Titanic
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
            ListPassengerDGV = new DataGridView();
            NameP = new DataGridViewTextBoxColumn();
            Survived = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Pclass = new DataGridViewTextBoxColumn();
            SurvivedPassengerBT = new Button();
            AgePassengerBT = new Button();
            PclassPassengerBT = new Button();
            label1 = new Label();
            AllPasangerBT = new Button();
            TimerLB = new Label();
            ((System.ComponentModel.ISupportInitialize)ListPassengerDGV).BeginInit();
            SuspendLayout();
            // 
            // ListPassengerDGV
            // 
            ListPassengerDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListPassengerDGV.Columns.AddRange(new DataGridViewColumn[] { NameP, Survived, Age, Pclass });
            ListPassengerDGV.Location = new Point(12, 12);
            ListPassengerDGV.Name = "ListPassengerDGV";
            ListPassengerDGV.RowTemplate.Height = 25;
            ListPassengerDGV.Size = new Size(694, 426);
            ListPassengerDGV.TabIndex = 0;
            // 
            // NameP
            // 
            NameP.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            NameP.Frozen = true;
            NameP.HeaderText = "Имя";
            NameP.Name = "NameP";
            NameP.ReadOnly = true;
            NameP.Width = 350;
            // 
            // Survived
            // 
            Survived.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Survived.Frozen = true;
            Survived.HeaderText = "Выжил";
            Survived.Name = "Survived";
            Survived.ReadOnly = true;
            // 
            // Age
            // 
            Age.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Age.Frozen = true;
            Age.HeaderText = "Возраст";
            Age.Name = "Age";
            Age.ReadOnly = true;
            // 
            // Pclass
            // 
            Pclass.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Pclass.Frozen = true;
            Pclass.HeaderText = "Класс";
            Pclass.Name = "Pclass";
            Pclass.ReadOnly = true;
            // 
            // SurvivedPassengerBT
            // 
            SurvivedPassengerBT.Location = new Point(712, 106);
            SurvivedPassengerBT.Name = "SurvivedPassengerBT";
            SurvivedPassengerBT.Size = new Size(154, 35);
            SurvivedPassengerBT.TabIndex = 1;
            SurvivedPassengerBT.Text = "Выжившие";
            SurvivedPassengerBT.UseVisualStyleBackColor = true;
            SurvivedPassengerBT.Click += SurvivedPassengerBT_Click;
            // 
            // AgePassengerBT
            // 
            AgePassengerBT.Location = new Point(712, 147);
            AgePassengerBT.Name = "AgePassengerBT";
            AgePassengerBT.Size = new Size(154, 35);
            AgePassengerBT.TabIndex = 2;
            AgePassengerBT.Text = "Совершеннолетние";
            AgePassengerBT.UseVisualStyleBackColor = true;
            AgePassengerBT.Click += AgePassengerBT_Click;
            // 
            // PclassPassengerBT
            // 
            PclassPassengerBT.Location = new Point(712, 188);
            PclassPassengerBT.Name = "PclassPassengerBT";
            PclassPassengerBT.Size = new Size(154, 35);
            PclassPassengerBT.TabIndex = 3;
            PclassPassengerBT.Text = "Пассажиры 3-го класса";
            PclassPassengerBT.UseVisualStyleBackColor = true;
            PclassPassengerBT.Click += PclassPassengerBT_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(712, 49);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 4;
            label1.Text = "Вывести пассажиров";
            // 
            // AllPasangerBT
            // 
            AllPasangerBT.Location = new Point(712, 67);
            AllPasangerBT.Name = "AllPasangerBT";
            AllPasangerBT.Size = new Size(154, 33);
            AllPasangerBT.TabIndex = 5;
            AllPasangerBT.Text = "Все пассажиры";
            AllPasangerBT.UseVisualStyleBackColor = true;
            AllPasangerBT.Click += AllPasangerBT_Click;
            // 
            // TimerLB
            // 
            TimerLB.AutoSize = true;
            TimerLB.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            TimerLB.Location = new Point(750, 12);
            TimerLB.Name = "TimerLB";
            TimerLB.Size = new Size(82, 25);
            TimerLB.TabIndex = 6;
            TimerLB.Text = "00:00:00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 450);
            Controls.Add(TimerLB);
            Controls.Add(AllPasangerBT);
            Controls.Add(label1);
            Controls.Add(PclassPassengerBT);
            Controls.Add(AgePassengerBT);
            Controls.Add(SurvivedPassengerBT);
            Controls.Add(ListPassengerDGV);
            Name = "Form1";
            Text = "Титаник";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)ListPassengerDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ListPassengerDGV;
        private Button SurvivedPassengerBT;
        private Button AgePassengerBT;
        private Button PclassPassengerBT;
        private Label label1;
        private DataGridViewTextBoxColumn NameP;
        private DataGridViewTextBoxColumn Survived;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Pclass;
        private Button AllPasangerBT;
        private Label TimerLB;
    }
}