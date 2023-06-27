namespace TestProject
{
    partial class AnswerControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            tbAnswer=new TextBox();
            cbYesNo=new CheckBox();
            btRemove=new Button();
            SuspendLayout();
            // 
            // tbAnswer
            // 
            tbAnswer.Location=new Point(3, 3);
            tbAnswer.Name="tbAnswer";
            tbAnswer.Size=new Size(396, 31);
            tbAnswer.TabIndex=0;
            // 
            // cbYesNo
            // 
            cbYesNo.AutoSize=true;
            cbYesNo.Location=new Point(405, 4);
            cbYesNo.Name="cbYesNo";
            cbYesNo.Size=new Size(123, 29);
            cbYesNo.TabIndex=1;
            cbYesNo.Text="Правильно";
            cbYesNo.UseVisualStyleBackColor=true;
            // 
            // btRemove
            // 
            btRemove.Location=new Point(534, 2);
            btRemove.Name="btRemove";
            btRemove.Size=new Size(105, 31);
            btRemove.TabIndex=2;
            btRemove.Text="Удалить";
            btRemove.UseVisualStyleBackColor=true;
            btRemove.Click+=btRemove_Click;
            // 
            // AnswerControl
            // 
            AutoScaleDimensions=new SizeF(9F, 23F);
            AutoScaleMode=AutoScaleMode.Font;
            Controls.Add(btRemove);
            Controls.Add(cbYesNo);
            Controls.Add(tbAnswer);
            Font=new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Margin=new Padding(4, 5, 4, 5);
            Name="AnswerControl";
            Size=new Size(662, 37);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox tbAnswer;
        public CheckBox cbYesNo;
        public Button btRemove;
    }
}
