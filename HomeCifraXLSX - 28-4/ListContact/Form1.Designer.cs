namespace ListContact
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
            ContactListLTB = new ListBox();
            label1 = new Label();
            UserNameTB = new TextBox();
            label2 = new Label();
            label3 = new Label();
            UserAdressTB = new TextBox();
            label4 = new Label();
            UserPhoneTB = new TextBox();
            label5 = new Label();
            UserEmailTB = new TextBox();
            DeleteUserBT = new Button();
            AddUserBT = new Button();
            EditUserBT = new Button();
            SaveFileBT = new Button();
            SuspendLayout();
            // 
            // ContactListLTB
            // 
            ContactListLTB.FormattingEnabled = true;
            ContactListLTB.ItemHeight = 15;
            ContactListLTB.Location = new Point(12, 27);
            ContactListLTB.Name = "ContactListLTB";
            ContactListLTB.Size = new Size(168, 364);
            ContactListLTB.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "Контакты";
            // 
            // UserNameTB
            // 
            UserNameTB.Location = new Point(186, 27);
            UserNameTB.Name = "UserNameTB";
            UserNameTB.Size = new Size(372, 23);
            UserNameTB.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 9);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 3;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(186, 141);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 4;
            label3.Text = "Адрес";
            // 
            // UserAdressTB
            // 
            UserAdressTB.Location = new Point(186, 159);
            UserAdressTB.Name = "UserAdressTB";
            UserAdressTB.Size = new Size(372, 23);
            UserAdressTB.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(186, 53);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 6;
            label4.Text = "Номер телефона";
            // 
            // UserPhoneTB
            // 
            UserPhoneTB.Location = new Point(186, 71);
            UserPhoneTB.Name = "UserPhoneTB";
            UserPhoneTB.Size = new Size(372, 23);
            UserPhoneTB.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(186, 97);
            label5.Name = "label5";
            label5.Size = new Size(116, 15);
            label5.TabIndex = 8;
            label5.Text = "Электронный адрес";
            // 
            // UserEmailTB
            // 
            UserEmailTB.Location = new Point(186, 115);
            UserEmailTB.Name = "UserEmailTB";
            UserEmailTB.Size = new Size(372, 23);
            UserEmailTB.TabIndex = 9;
            // 
            // DeleteUserBT
            // 
            DeleteUserBT.Location = new Point(12, 397);
            DeleteUserBT.Name = "DeleteUserBT";
            DeleteUserBT.Size = new Size(168, 41);
            DeleteUserBT.TabIndex = 10;
            DeleteUserBT.Text = "Удалить";
            DeleteUserBT.UseVisualStyleBackColor = true;
            // 
            // AddUserBT
            // 
            AddUserBT.Location = new Point(186, 188);
            AddUserBT.Name = "AddUserBT";
            AddUserBT.Size = new Size(183, 35);
            AddUserBT.TabIndex = 11;
            AddUserBT.Text = "Добавить";
            AddUserBT.UseVisualStyleBackColor = true;
            // 
            // EditUserBT
            // 
            EditUserBT.Location = new Point(375, 188);
            EditUserBT.Name = "EditUserBT";
            EditUserBT.Size = new Size(183, 35);
            EditUserBT.TabIndex = 12;
            EditUserBT.Text = "Внести изменения";
            EditUserBT.UseVisualStyleBackColor = true;
            // 
            // SaveFileBT
            // 
            SaveFileBT.Location = new Point(277, 229);
            SaveFileBT.Name = "SaveFileBT";
            SaveFileBT.Size = new Size(183, 35);
            SaveFileBT.TabIndex = 13;
            SaveFileBT.Text = "Сохранить изменения";
            SaveFileBT.UseVisualStyleBackColor = true;
            SaveFileBT.Click += SaveFileBT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 450);
            Controls.Add(SaveFileBT);
            Controls.Add(EditUserBT);
            Controls.Add(AddUserBT);
            Controls.Add(DeleteUserBT);
            Controls.Add(UserEmailTB);
            Controls.Add(label5);
            Controls.Add(UserPhoneTB);
            Controls.Add(label4);
            Controls.Add(UserAdressTB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(UserNameTB);
            Controls.Add(label1);
            Controls.Add(ContactListLTB);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ContactListLTB;
        private Label label1;
        private TextBox UserNameTB;
        private Label label2;
        private Label label3;
        private TextBox UserAdressTB;
        private Label label4;
        private TextBox UserPhoneTB;
        private Label label5;
        private TextBox UserEmailTB;
        private Button DeleteUserBT;
        private Button AddUserBT;
        private Button EditUserBT;
        private Button SaveFileBT;
    }
}