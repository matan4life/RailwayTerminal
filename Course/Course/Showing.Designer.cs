namespace Course
{
    partial class Showing
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пассажирамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расписаниеПоездовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оплатаБилетовOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.администраторамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.входToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.railroadDataSet1 = new Course.RailroadDataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.railroadDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главнаяToolStripMenuItem,
            this.пассажирамToolStripMenuItem,
            this.администраторамToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // главнаяToolStripMenuItem
            // 
            this.главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            this.главнаяToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.главнаяToolStripMenuItem.Text = "Главная";
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
            // railroadDataSet1
            // 
            this.railroadDataSet1.DataSetName = "RailroadDataSet1";
            this.railroadDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(140, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "№ поезда";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Начальная станция";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Конечная станция";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Время отправления";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Время прибытия";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(140, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(543, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Задача автоматизации (АЛЬФА-ТЕСТ)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Showing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Showing";
            this.Text = "Showing";
            this.Load += new System.EventHandler(this.Showing_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.railroadDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
        private RailroadDataSet1 railroadDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button1;
    }
}