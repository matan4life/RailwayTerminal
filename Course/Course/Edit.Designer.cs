namespace Course
{
    partial class Edit
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.terminalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.railroadDataSet2 = new Course.RailroadDataSet2();
            this.trainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.engineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.terminalTableAdapter = new Course.RailroadDataSet2TableAdapters.TerminalTableAdapter();
            this.trainTableAdapter = new Course.RailroadDataSet2TableAdapters.TrainTableAdapter();
            this.engineTableAdapter = new Course.RailroadDataSet2TableAdapters.EngineTableAdapter();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.trainStationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carriageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carriageTableAdapter = new Course.RailroadDataSet2TableAdapters.CarriageTableAdapter();
            this.trainStationsTableAdapter = new Course.RailroadDataSet2TableAdapters.TrainStationsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.railroadDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainStationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carriageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(12, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(92, 26);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Вокзал";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(110, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(82, 26);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Поезд";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.Location = new System.Drawing.Point(198, 12);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(130, 26);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Локомотив";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 34);
            this.button1.TabIndex = 41;
            this.button1.Text = "Редактировать вокзал";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(12, 356);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(250, 29);
            this.textBox4.TabIndex = 40;
            this.textBox4.Visible = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(12, 299);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(250, 29);
            this.numericUpDown1.TabIndex = 39;
            this.numericUpDown1.Value = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.numericUpDown1.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(12, 242);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(250, 29);
            this.textBox3.TabIndex = 38;
            this.textBox3.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(12, 187);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 29);
            this.textBox2.TabIndex = 37;
            this.textBox2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 29);
            this.textBox1.TabIndex = 36;
            this.textBox1.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(12, 76);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(250, 26);
            this.listBox1.TabIndex = 35;
            this.listBox1.Visible = false;
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 34);
            this.button2.TabIndex = 42;
            this.button2.Text = "Удалить вокзал";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // terminalBindingSource
            // 
            this.terminalBindingSource.DataMember = "Terminal";
            this.terminalBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.railroadDataSet2;
            this.bindingSource1.Position = 0;
            // 
            // railroadDataSet2
            // 
            this.railroadDataSet2.DataSetName = "RailroadDataSet2";
            this.railroadDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainBindingSource
            // 
            this.trainBindingSource.DataMember = "Train";
            this.trainBindingSource.DataSource = this.bindingSource1;
            // 
            // engineBindingSource
            // 
            this.engineBindingSource.DataMember = "Engine";
            this.engineBindingSource.DataSource = this.bindingSource1;
            // 
            // terminalTableAdapter
            // 
            this.terminalTableAdapter.ClearBeforeFill = true;
            // 
            // trainTableAdapter
            // 
            this.trainTableAdapter.ClearBeforeFill = true;
            // 
            // engineTableAdapter
            // 
            this.engineTableAdapter.ClearBeforeFill = true;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 22;
            this.listBox2.Location = new System.Drawing.Point(268, 76);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(250, 26);
            this.listBox2.TabIndex = 43;
            this.listBox2.Visible = false;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            this.listBox2.SelectedValueChanged += new System.EventHandler(this.listBox2_SelectedValueChanged);
            // 
            // listBox3
            // 
            this.listBox3.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 22;
            this.listBox3.Location = new System.Drawing.Point(268, 133);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(250, 26);
            this.listBox3.TabIndex = 44;
            this.listBox3.Visible = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(268, 205);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 34);
            this.button3.TabIndex = 46;
            this.button3.Text = "Удалить поезд";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(268, 165);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 34);
            this.button4.TabIndex = 45;
            this.button4.Text = "Редактировать поезд";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox4
            // 
            this.listBox4.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 22;
            this.listBox4.Location = new System.Drawing.Point(524, 76);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(266, 26);
            this.listBox4.TabIndex = 47;
            this.listBox4.Visible = false;
            this.listBox4.SelectedValueChanged += new System.EventHandler(this.listBox4_SelectedValueChanged);
            // 
            // listBox5
            // 
            this.listBox5.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 22;
            this.listBox5.Location = new System.Drawing.Point(524, 133);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(266, 26);
            this.listBox5.TabIndex = 48;
            this.listBox5.Visible = false;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(524, 205);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(266, 34);
            this.button5.TabIndex = 50;
            this.button5.Text = "Удалить локомотив";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(524, 165);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(266, 34);
            this.button6.TabIndex = 49;
            this.button6.Text = "Редактировать локомотив";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSource = this.trainStationsBindingSource;
            // 
            // trainStationsBindingSource
            // 
            this.trainStationsBindingSource.DataMember = "TrainStations";
            this.trainStationsBindingSource.DataSource = this.bindingSource1;
            // 
            // carriageBindingSource
            // 
            this.carriageBindingSource.DataMember = "Carriage";
            this.carriageBindingSource.DataSource = this.bindingSource1;
            // 
            // carriageTableAdapter
            // 
            this.carriageTableAdapter.ClearBeforeFill = true;
            // 
            // trainStationsTableAdapter
            // 
            this.trainStationsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(93, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 54;
            this.label1.Text = "Станция";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(55, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 22);
            this.label2.TabIndex = 60;
            this.label2.Text = "Название вокзала";
            this.label2.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(44, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 22);
            this.label6.TabIndex = 64;
            this.label6.Text = "Прочая информация";
            this.label6.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(93, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 22);
            this.label3.TabIndex = 61;
            this.label3.Text = "Страна";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(104, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 22);
            this.label4.TabIndex = 62;
            this.label4.Text = "Город";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(68, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 22);
            this.label5.TabIndex = 63;
            this.label5.Text = "Год основания";
            this.label5.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(317, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 22);
            this.label7.TabIndex = 65;
            this.label7.Text = "Номер поезда";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(317, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 22);
            this.label8.TabIndex = 66;
            this.label8.Text = "ID локомотива";
            this.label8.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(583, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 22);
            this.label10.TabIndex = 73;
            this.label10.Text = "ID локомотива";
            this.label10.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(569, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 22);
            this.label9.TabIndex = 74;
            this.label9.Text = "Модель локомотива";
            this.label9.Visible = false;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 741);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Name = "Edit";
            this.Text = "Edit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Edit_FormClosing);
            this.Load += new System.EventHandler(this.Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.railroadDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainStationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carriageBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private RailroadDataSet2 railroadDataSet2;
        private System.Windows.Forms.BindingSource terminalBindingSource;
        private RailroadDataSet2TableAdapters.TerminalTableAdapter terminalTableAdapter;
        private System.Windows.Forms.BindingSource trainBindingSource;
        private RailroadDataSet2TableAdapters.TrainTableAdapter trainTableAdapter;
        private System.Windows.Forms.BindingSource engineBindingSource;
        private RailroadDataSet2TableAdapters.EngineTableAdapter engineTableAdapter;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource carriageBindingSource;
        private RailroadDataSet2TableAdapters.CarriageTableAdapter carriageTableAdapter;
        private System.Windows.Forms.BindingSource trainStationsBindingSource;
        private RailroadDataSet2TableAdapters.TrainStationsTableAdapter trainStationsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}