namespace TestProject
{
    partial class EditForm
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
            label1=new Label();
            tbQuestion=new TextBox();
            btAddQuestion=new Button();
            btSave=new Button();
            lbOtvet=new Label();
            plAnswers=new Panel();
            btAdd=new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(12, 9);
            label1.Name="label1";
            label1.Size=new Size(143, 25);
            label1.TabIndex=0;
            label1.Text="Введите вопрос";
            // 
            // tbQuestion
            // 
            tbQuestion.Location=new Point(12, 37);
            tbQuestion.Multiline=true;
            tbQuestion.Name="tbQuestion";
            tbQuestion.Size=new Size(660, 82);
            tbQuestion.TabIndex=1;
            // 
            // btAddQuestion
            // 
            btAddQuestion.Location=new Point(370, 476);
            btAddQuestion.Name="btAddQuestion";
            btAddQuestion.Size=new Size(173, 40);
            btAddQuestion.TabIndex=2;
            btAddQuestion.Text="Добавить вопрос";
            btAddQuestion.UseVisualStyleBackColor=true;
            btAddQuestion.Click+=btAddQuestion_Click;
            // 
            // btSave
            // 
            btSave.Location=new Point(549, 476);
            btSave.Name="btSave";
            btSave.Size=new Size(123, 40);
            btSave.TabIndex=4;
            btSave.Text="Сохранить";
            btSave.UseVisualStyleBackColor=true;
            btSave.Click+=btSave_Click;
            // 
            // lbOtvet
            // 
            lbOtvet.AutoSize=true;
            lbOtvet.Location=new Point(12, 137);
            lbOtvet.Name="lbOtvet";
            lbOtvet.Size=new Size(343, 25);
            lbOtvet.TabIndex=5;
            lbOtvet.Text="Введите ответы и выберите правильные";
            // 
            // plAnswers
            // 
            plAnswers.AutoScroll=true;
            plAnswers.Location=new Point(12, 165);
            plAnswers.Name="plAnswers";
            plAnswers.Size=new Size(662, 305);
            plAnswers.TabIndex=6;
            // 
            // btAdd
            // 
            btAdd.Location=new Point(12, 476);
            btAdd.Name="btAdd";
            btAdd.Size=new Size(160, 40);
            btAdd.TabIndex=7;
            btAdd.Text="Добавить ответ";
            btAdd.UseVisualStyleBackColor=true;
            btAdd.Click+=btAdd_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions=new SizeF(9F, 23F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(686, 525);
            Controls.Add(btAdd);
            Controls.Add(plAnswers);
            Controls.Add(lbOtvet);
            Controls.Add(btSave);
            Controls.Add(btAddQuestion);
            Controls.Add(tbQuestion);
            Controls.Add(label1);
            Font=new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Margin=new Padding(4, 5, 4, 5);
            Name="EditForm";
            Text="Редактор тестов";
            FormClosing+=EditForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbQuestion;
        private Button btAddQuestion;
        private Button btSave;
        private Label lbOtvet;
        private Button btAdd;
        public Panel plAnswers;
    }
}