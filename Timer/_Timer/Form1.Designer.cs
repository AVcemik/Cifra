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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbMinutes = new System.Windows.Forms.TextBox();
            this.lbTimer = new System.Windows.Forms.Label();
            this.tbSecundes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSetup = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbMinutes
            // 
            this.tbMinutes.Location = new System.Drawing.Point(240, 47);
            this.tbMinutes.Name = "tbMinutes";
            this.tbMinutes.Size = new System.Drawing.Size(103, 31);
            this.tbMinutes.TabIndex = 0;
            this.tbMinutes.Text = "Минуты";
            // 
            // lbTimer
            // 
            this.lbTimer.Location = new System.Drawing.Point(12, 9);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(210, 69);
            this.lbTimer.TabIndex = 1;
            // 
            // tbSecundes
            // 
            this.tbSecundes.Location = new System.Drawing.Point(347, 47);
            this.tbSecundes.Name = "tbSecundes";
            this.tbSecundes.Size = new System.Drawing.Size(103, 31);
            this.tbSecundes.TabIndex = 2;
            this.tbSecundes.Text = "Секунды";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(240, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите время";
            // 
            // btSetup
            // 
            this.btSetup.Location = new System.Drawing.Point(240, 84);
            this.btSetup.Name = "btSetup";
            this.btSetup.Size = new System.Drawing.Size(210, 47);
            this.btSetup.TabIndex = 4;
            this.btSetup.Text = "Установить";
            this.btSetup.UseVisualStyleBackColor = true;
            this.btSetup.Click += new System.EventHandler(this.btSetup_Click);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(12, 84);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(210, 47);
            this.btStart.TabIndex = 5;
            this.btStart.Text = "Старт";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 145);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.btSetup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSecundes);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.tbMinutes);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Таймер";
            this.ResumeLayout(false);
            this.PerformLayout();

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