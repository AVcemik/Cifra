namespace Redaction
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
            tbUserName = new TextBox();
            tbUserPass = new TextBox();
            label2 = new Label();
            button1 = new Button();
            btRegistration = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 0;
            label1.Text = "Логин пользователя: ";
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(12, 27);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(308, 23);
            tbUserName.TabIndex = 1;
            // 
            // tbUserPass
            // 
            tbUserPass.Location = new Point(12, 77);
            tbUserPass.Name = "tbUserPass";
            tbUserPass.Size = new Size(308, 23);
            tbUserPass.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 2;
            label2.Text = "Пароль пользователя: ";
            // 
            // button1
            // 
            button1.Location = new Point(195, 106);
            button1.Name = "button1";
            button1.Size = new Size(125, 31);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btRegistration
            // 
            btRegistration.Location = new Point(191, 182);
            btRegistration.Name = "btRegistration";
            btRegistration.Size = new Size(129, 23);
            btRegistration.TabIndex = 5;
            btRegistration.Text = "Зарегестрироваться";
            btRegistration.UseVisualStyleBackColor = true;
            btRegistration.Click += btRegistration_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 186);
            label3.Name = "label3";
            label3.Size = new Size(163, 15);
            label3.TabIndex = 6;
            label3.Text = "Еще не зарегестрированны?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 217);
            Controls.Add(label3);
            Controls.Add(btRegistration);
            Controls.Add(button1);
            Controls.Add(tbUserPass);
            Controls.Add(label2);
            Controls.Add(tbUserName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Redaction";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbUserName;
        private TextBox tbUserPass;
        private Label label2;
        private Button button1;
        private Button btRegistration;
        private Label label3;
    }
}