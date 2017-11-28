namespace Course
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.пассажирамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расписаниеПоездовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оплатаБилетовOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.администраторамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.входToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пассажирамToolStripMenuItem,
            this.администраторамToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1358, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // пассажирамToolStripMenuItem
            // 
            this.пассажирамToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расписаниеПоездовToolStripMenuItem,
            this.оплатаБилетовOnlineToolStripMenuItem});
            this.пассажирамToolStripMenuItem.Name = "пассажирамToolStripMenuItem";
            this.пассажирамToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.пассажирамToolStripMenuItem.Text = "Пассажирам";
            // 
            // расписаниеПоездовToolStripMenuItem
            // 
            this.расписаниеПоездовToolStripMenuItem.Name = "расписаниеПоездовToolStripMenuItem";
            this.расписаниеПоездовToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.расписаниеПоездовToolStripMenuItem.Text = "Расписание поездов";
            this.расписаниеПоездовToolStripMenuItem.Click += new System.EventHandler(this.расписаниеПоездовToolStripMenuItem_Click);
            // 
            // оплатаБилетовOnlineToolStripMenuItem
            // 
            this.оплатаБилетовOnlineToolStripMenuItem.Name = "оплатаБилетовOnlineToolStripMenuItem";
            this.оплатаБилетовOnlineToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.оплатаБилетовOnlineToolStripMenuItem.Text = "Оплата билетов Online";
            // 
            // администраторамToolStripMenuItem
            // 
            this.администраторамToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.входToolStripMenuItem});
            this.администраторамToolStripMenuItem.Name = "администраторамToolStripMenuItem";
            this.администраторамToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.администраторамToolStripMenuItem.Text = "Администраторам";
            // 
            // входToolStripMenuItem
            // 
            this.входToolStripMenuItem.Name = "входToolStripMenuItem";
            this.входToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.входToolStripMenuItem.Text = "Вход";
            this.входToolStripMenuItem.Click += new System.EventHandler(this.входToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 741);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem пассажирамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расписаниеПоездовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оплатаБилетовOnlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem администраторамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem входToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

