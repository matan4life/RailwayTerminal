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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пассажирамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расписаниеПоездовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оплатаБилетовOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.администраторамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.входToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.engineIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propulsionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.railroadDataSet1 = new Course.RailroadDataSet1();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.railroadDataSet = new Course.RailroadDataSet();
            this.trainStationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainStationsTableAdapter = new Course.RailroadDataSetTableAdapters.TrainStationsTableAdapter();
            this.engineTableAdapter = new Course.RailroadDataSet1TableAdapters.EngineTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.railroadDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.railroadDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainStationsBindingSource)).BeginInit();
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
            this.главнаяToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.главнаяToolStripMenuItem.Text = "Главная";
            // 
            // пассажирамToolStripMenuItem
            // 
            this.пассажирамToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расписаниеПоездовToolStripMenuItem,
            this.оплатаБилетовOnlineToolStripMenuItem});
            this.пассажирамToolStripMenuItem.Name = "пассажирамToolStripMenuItem";
            this.пассажирамToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.пассажирамToolStripMenuItem.Text = "Пассажирам";
            // 
            // расписаниеПоездовToolStripMenuItem
            // 
            this.расписаниеПоездовToolStripMenuItem.Name = "расписаниеПоездовToolStripMenuItem";
            this.расписаниеПоездовToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.расписаниеПоездовToolStripMenuItem.Text = "Расписание поездов";
            // 
            // оплатаБилетовOnlineToolStripMenuItem
            // 
            this.оплатаБилетовOnlineToolStripMenuItem.Name = "оплатаБилетовOnlineToolStripMenuItem";
            this.оплатаБилетовOnlineToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.оплатаБилетовOnlineToolStripMenuItem.Text = "Оплата билетов Online";
            // 
            // администраторамToolStripMenuItem
            // 
            this.администраторамToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.входToolStripMenuItem});
            this.администраторамToolStripMenuItem.Name = "администраторамToolStripMenuItem";
            this.администраторамToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
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
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.engineIdDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.propulsionDataGridViewTextBoxColumn,
            this.factoryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.engineBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(151, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 274);
            this.dataGridView1.TabIndex = 2;
            // 
            // engineIdDataGridViewTextBoxColumn
            // 
            this.engineIdDataGridViewTextBoxColumn.DataPropertyName = "EngineId";
            this.engineIdDataGridViewTextBoxColumn.HeaderText = "EngineId";
            this.engineIdDataGridViewTextBoxColumn.Name = "engineIdDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // propulsionDataGridViewTextBoxColumn
            // 
            this.propulsionDataGridViewTextBoxColumn.DataPropertyName = "Propulsion";
            this.propulsionDataGridViewTextBoxColumn.HeaderText = "Propulsion";
            this.propulsionDataGridViewTextBoxColumn.Name = "propulsionDataGridViewTextBoxColumn";
            // 
            // factoryDataGridViewTextBoxColumn
            // 
            this.factoryDataGridViewTextBoxColumn.DataPropertyName = "Factory";
            this.factoryDataGridViewTextBoxColumn.HeaderText = "Factory";
            this.factoryDataGridViewTextBoxColumn.Name = "factoryDataGridViewTextBoxColumn";
            // 
            // engineBindingSource
            // 
            this.engineBindingSource.DataMember = "Engine";
            this.engineBindingSource.DataSource = this.bindingSource2;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSource = this.railroadDataSet1;
            this.bindingSource2.Position = 0;
            // 
            // railroadDataSet1
            // 
            this.railroadDataSet1.DataSetName = "RailroadDataSet1";
            this.railroadDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.railroadDataSet;
            this.bindingSource1.Position = 0;
            // 
            // railroadDataSet
            // 
            this.railroadDataSet.DataSetName = "RailroadDataSet";
            this.railroadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainStationsBindingSource
            // 
            this.trainStationsBindingSource.DataMember = "TrainStations";
            this.trainStationsBindingSource.DataSource = this.bindingSource1;
            // 
            // trainStationsTableAdapter
            // 
            this.trainStationsTableAdapter.ClearBeforeFill = true;
            // 
            // engineTableAdapter
            // 
            this.engineTableAdapter.ClearBeforeFill = true;
            // 
            // Showing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Showing";
            this.Text = "Showing";
            this.Load += new System.EventHandler(this.Showing_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.railroadDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.railroadDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainStationsBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private RailroadDataSet railroadDataSet;
        private System.Windows.Forms.BindingSource trainStationsBindingSource;
        private RailroadDataSetTableAdapters.TrainStationsTableAdapter trainStationsTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource2;
        private RailroadDataSet1 railroadDataSet1;
        private System.Windows.Forms.BindingSource engineBindingSource;
        private RailroadDataSet1TableAdapters.EngineTableAdapter engineTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn propulsionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factoryDataGridViewTextBoxColumn;
    }
}