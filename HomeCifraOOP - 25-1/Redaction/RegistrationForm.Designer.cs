namespace Redaction
{
    partial class RegistrationForm
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
            label1 = new Label();
            btRegistr = new Button();
            tbUsername = new TextBox();
            tbFirstName = new TextBox();
            label2 = new Label();
            tbSecondName = new TextBox();
            label3 = new Label();
            tbEmail = new TextBox();
            label4 = new Label();
            tbPassword = new TextBox();
            label5 = new Label();
            label6 = new Label();
            dtpBirthDay = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            // 
            // btRegistr
            // 
            btRegistr.Location = new Point(12, 276);
            btRegistr.Name = "btRegistr";
            btRegistr.Size = new Size(200, 36);
            btRegistr.TabIndex = 1;
            btRegistr.Text = "Зарегестрироваться";
            btRegistr.UseVisualStyleBackColor = true;
            btRegistr.Click += btRegistr_Click;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(12, 27);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(200, 23);
            tbUsername.TabIndex = 2;
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(12, 115);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(200, 23);
            tbFirstName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 3;
            label2.Text = "Имя";
            // 
            // tbSecondName
            // 
            tbSecondName.Location = new Point(12, 159);
            tbSecondName.Name = "tbSecondName";
            tbSecondName.Size = new Size(200, 23);
            tbSecondName.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 141);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 5;
            label3.Text = "Фамилия";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(12, 203);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(200, 23);
            tbEmail.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 185);
            label4.Name = "label4";
            label4.Size = new Size(155, 15);
            label4.TabIndex = 7;
            label4.Text = "Электроный адрес (Email)";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(12, 71);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(200, 23);
            tbPassword.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 53);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 9;
            label5.Text = "Пароль";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 229);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 11;
            label6.Text = "Дата рождения";
            // 
            // dtpBirthDay
            // 
            dtpBirthDay.Location = new Point(12, 247);
            dtpBirthDay.Name = "dtpBirthDay";
            dtpBirthDay.Size = new Size(200, 23);
            dtpBirthDay.TabIndex = 12;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(227, 331);
            Controls.Add(dtpBirthDay);
            Controls.Add(label6);
            Controls.Add(tbPassword);
            Controls.Add(label5);
            Controls.Add(tbEmail);
            Controls.Add(label4);
            Controls.Add(tbSecondName);
            Controls.Add(label3);
            Controls.Add(tbFirstName);
            Controls.Add(label2);
            Controls.Add(tbUsername);
            Controls.Add(btRegistr);
            Controls.Add(label1);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btRegistr;
        private TextBox tbUsername;
        private TextBox tbFirstName;
        private Label label2;
        private TextBox tbSecondName;
        private Label label3;
        private TextBox tbEmail;
        private Label label4;
        private TextBox tbPassword;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpBirthDay;
    }
}