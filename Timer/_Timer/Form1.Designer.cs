namespace _Timer
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
            components=new System.ComponentModel.Container();
            timer1=new System.Windows.Forms.Timer(components);
            tbMinutes=new TextBox();
            lbTimer=new Label();
            tbSecundes=new TextBox();
            label1=new Label();
            btSetup=new Button();
            btStart=new Button();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick+=timer1_Tick;
            // 
            // tbMinutes
            // 
            tbMinutes.Location=new Point(240, 47);
            tbMinutes.Name="tbMinutes";
            tbMinutes.Size=new Size(103, 31);
            tbMinutes.TabIndex=0;
            tbMinutes.Text="Минуты";
            // 
            // lbTimer
            // 
            lbTimer.Location=new Point(12, 9);
            lbTimer.Name="lbTimer";
            lbTimer.Size=new Size(210, 69);
            lbTimer.TabIndex=1;
            // 
            // tbSecundes
            // 
            tbSecundes.Location=new Point(347, 47);
            tbSecundes.Name="tbSecundes";
            tbSecundes.Size=new Size(103, 31);
            tbSecundes.TabIndex=2;
            tbSecundes.Text="Секунды";
            // 
            // label1
            // 
            label1.Location=new Point(240, 9);
            label1.Name="label1";
            label1.Size=new Size(210, 23);
            label1.TabIndex=3;
            label1.Text="Введите время";
            // 
            // btSetup
            // 
            btSetup.Location=new Point(240, 84);
            btSetup.Name="btSetup";
            btSetup.Size=new Size(210, 47);
            btSetup.TabIndex=4;
            btSetup.Text="Установить";
            btSetup.UseVisualStyleBackColor=true;
            btSetup.Click+=btSetup_Click;
            // 
            // btStart
            // 
            btStart.Location=new Point(12, 84);
            btStart.Name="btStart";
            btStart.Size=new Size(210, 47);
            btStart.TabIndex=5;
            btStart.Text="Старт";
            btStart.UseVisualStyleBackColor=true;
            btStart.Click+=btStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(9F, 23F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(466, 145);
            Controls.Add(btStart);
            Controls.Add(btSetup);
            Controls.Add(label1);
            Controls.Add(tbSecundes);
            Controls.Add(lbTimer);
            Controls.Add(tbMinutes);
            Font=new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Margin=new Padding(4, 5, 4, 5);
            Name="Form1";
            Text="Таймер";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private TextBox tbMinutes;
        private Label lbTimer;
        private TextBox tbSecundes;
        private Label label1;
        private Button btSetup;
        private Button btStart;
    }
}