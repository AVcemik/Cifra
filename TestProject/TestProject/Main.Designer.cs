namespace FAQ
{
    partial class Main
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
            menuStrip1=new MenuStrip();
            редакторToolStripMenuItem=new ToolStripMenuItem();
            загрузитьToolStripMenuItem=new ToolStripMenuItem();
            создатьToolStripMenuItem=new ToolStripMenuItem();
            toolStripMenuItem1=new ToolStripSeparator();
            выходToolStripMenuItem=new ToolStripMenuItem();
            plQuestion=new Panel();
            btPref=new Button();
            btNext=new Button();
            btApply=new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { редакторToolStripMenuItem });
            menuStrip1.Location=new Point(0, 0);
            menuStrip1.Name="menuStrip1";
            menuStrip1.Size=new Size(783, 24);
            menuStrip1.TabIndex=0;
            menuStrip1.Text="menuStrip1";
            // 
            // редакторToolStripMenuItem
            // 
            редакторToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { загрузитьToolStripMenuItem, создатьToolStripMenuItem, toolStripMenuItem1, выходToolStripMenuItem });
            редакторToolStripMenuItem.Name="редакторToolStripMenuItem";
            редакторToolStripMenuItem.Size=new Size(48, 20);
            редакторToolStripMenuItem.Text="Файл";
            // 
            // загрузитьToolStripMenuItem
            // 
            загрузитьToolStripMenuItem.Name="загрузитьToolStripMenuItem";
            загрузитьToolStripMenuItem.Size=new Size(121, 22);
            загрузитьToolStripMenuItem.Text="&Открыть";
            загрузитьToolStripMenuItem.Click+=загрузитьToolStripMenuItem_Click;
            // 
            // создатьToolStripMenuItem
            // 
            создатьToolStripMenuItem.Name="создатьToolStripMenuItem";
            создатьToolStripMenuItem.Size=new Size(121, 22);
            создатьToolStripMenuItem.Text="&Создать";
            создатьToolStripMenuItem.Click+=создатьToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name="toolStripMenuItem1";
            toolStripMenuItem1.Size=new Size(118, 6);
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name="выходToolStripMenuItem";
            выходToolStripMenuItem.Size=new Size(121, 22);
            выходToolStripMenuItem.Text="&Выход";
            выходToolStripMenuItem.Click+=выходToolStripMenuItem_Click;
            // 
            // plQuestion
            // 
            plQuestion.Location=new Point(12, 27);
            plQuestion.Name="plQuestion";
            plQuestion.Size=new Size(759, 296);
            plQuestion.TabIndex=1;
            // 
            // btPref
            // 
            btPref.Location=new Point(589, 329);
            btPref.Name="btPref";
            btPref.Size=new Size(88, 36);
            btPref.TabIndex=2;
            btPref.Text="Назад";
            btPref.UseVisualStyleBackColor=true;
            btPref.Click+=btPref_Click;
            // 
            // btNext
            // 
            btNext.Location=new Point(683, 329);
            btNext.Name="btNext";
            btNext.Size=new Size(88, 36);
            btNext.TabIndex=3;
            btNext.Text="Вперед";
            btNext.UseVisualStyleBackColor=true;
            btNext.Click+=btNext_Click;
            // 
            // btApply
            // 
            btApply.Location=new Point(12, 329);
            btApply.Name="btApply";
            btApply.Size=new Size(107, 36);
            btApply.TabIndex=4;
            btApply.Text="Принять";
            btApply.UseVisualStyleBackColor=true;
            btApply.Click+=btApply_Click;
            // 
            // Main
            // 
            AutoScaleDimensions=new SizeF(9F, 23F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(783, 413);
            Controls.Add(btApply);
            Controls.Add(btNext);
            Controls.Add(btPref);
            Controls.Add(plQuestion);
            Controls.Add(menuStrip1);
            Font=new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip=menuStrip1;
            Margin=new Padding(4, 5, 4, 5);
            Name="Main";
            Text="Тест";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem редакторToolStripMenuItem;
        private ToolStripMenuItem загрузитьToolStripMenuItem;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem выходToolStripMenuItem;
        private Panel plQuestion;
        private Button btPref;
        private Button btNext;
        private Button btApply;
    }
}