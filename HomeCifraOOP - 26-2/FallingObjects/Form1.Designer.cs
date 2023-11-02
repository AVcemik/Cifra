namespace GameFallingObj
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
            startBT = new Button();
            SuspendLayout();
            // 
            // startBT
            // 
            startBT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            startBT.Location = new Point(305, 221);
            startBT.Name = "startBT";
            startBT.Size = new Size(133, 49);
            startBT.TabIndex = 1;
            startBT.Text = "Старт";
            startBT.UseVisualStyleBackColor = true;
            startBT.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(784, 461);
            Controls.Add(startBT);
            Name = "Form1";
            Text = "Падающие обекты";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button startBT;
    }
}