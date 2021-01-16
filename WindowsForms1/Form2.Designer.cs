namespace WindowsForms1
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.НагрузкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ДисциплинаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_base1DataSet1 = new WindowsForms1.Data_base1DataSet1();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button2 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.database1DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data_base1DataSet2 = new WindowsForms1.Data_base1DataSet2();
            this.нагрузкаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.нагрузкаTableAdapter1 = new WindowsForms1.Data_base1DataSet2TableAdapters.НагрузкаTableAdapter();
            this.data_base1DataSet3 = new WindowsForms1.Data_base1DataSet3();
            this.нагрузкаBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.нагрузкаTableAdapter2 = new WindowsForms1.Data_base1DataSet3TableAdapters.НагрузкаTableAdapter();
            this.data_base1DataSet4 = new WindowsForms1.Data_base1DataSet4();
            this.педагогиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.педагогиTableAdapter = new WindowsForms1.Data_base1DataSet4TableAdapters.ПедагогиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.НагрузкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ДисциплинаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data_base1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_base1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.нагрузкаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_base1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.нагрузкаBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_base1DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.педагогиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ДисциплинаBindingSource
            // 
            this.ДисциплинаBindingSource.DataMember = "Дисциплина";
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column24,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20,
            this.Column21,
            this.Column22,
            this.Column23,
            this.Column25});
            this.dataGridView5.Location = new System.Drawing.Point(12, 117);
            this.dataGridView5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(1859, 565);
            this.dataGridView5.TabIndex = 1;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Дисциплина";
            this.Column11.Name = "Column11";
            this.Column11.Width = 400;
            // 
            // Column24
            // 
            this.Column24.HeaderText = "Группа";
            this.Column24.Name = "Column24";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Лекции 1 семестр";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Лекции 2 семестр";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "ЛР 1 семестр";
            this.Column14.Name = "Column14";
            // 
            // Column15
            // 
            this.Column15.HeaderText = "ЛР 2 семестр";
            this.Column15.Name = "Column15";
            // 
            // Column16
            // 
            this.Column16.HeaderText = "ПР 1 семестр";
            this.Column16.Name = "Column16";
            // 
            // Column17
            // 
            this.Column17.HeaderText = "ПР 2 семестр";
            this.Column17.Name = "Column17";
            // 
            // Column18
            // 
            this.Column18.HeaderText = "КП 1 семестр";
            this.Column18.Name = "Column18";
            // 
            // Column19
            // 
            this.Column19.HeaderText = "КП 2 семестр";
            this.Column19.Name = "Column19";
            // 
            // Column20
            // 
            this.Column20.HeaderText = "Консультации 1 семестр";
            this.Column20.Name = "Column20";
            // 
            // Column21
            // 
            this.Column21.HeaderText = "Консультации 2 семестр";
            this.Column21.Name = "Column21";
            // 
            // Column22
            // 
            this.Column22.HeaderText = "ФК 1 семестр";
            this.Column22.Name = "Column22";
            // 
            // Column23
            // 
            this.Column23.HeaderText = "ФК 2 семестр";
            this.Column23.Name = "Column23";
            // 
            // Column25
            // 
            this.Column25.HeaderText = "Самостоятельные работы";
            this.Column25.Name = "Column25";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 734);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Загрузить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(54, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Преподаватель";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(1107, 682);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(215, 72);
            this.dataGridView1.TabIndex = 6;
            // 
            // Column1
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column1.HeaderText = "Всего часов";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Data_base1DataSet1
            // 
            this.Data_base1DataSet1.DataSetName = "Data_base1DataSet1";
            this.Data_base1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(341, 734);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Экспорт в Excel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.педагогиBindingSource;
            this.comboBox1.DisplayMember = "ФИО";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(212, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.ValueMember = "Код";
            // 
            // database1DataSet1BindingSource
            // 
            this.database1DataSet1BindingSource.DataSource = this.Data_base1DataSet1;
            this.database1DataSet1BindingSource.Position = 0;
            // 
            // data_base1DataSet2
            // 
            this.data_base1DataSet2.DataSetName = "Data_base1DataSet2";
            this.data_base1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // нагрузкаBindingSource1
            // 
            this.нагрузкаBindingSource1.DataMember = "Нагрузка";
            this.нагрузкаBindingSource1.DataSource = this.data_base1DataSet2;
            // 
            // нагрузкаTableAdapter1
            // 
            this.нагрузкаTableAdapter1.ClearBeforeFill = true;
            // 
            // data_base1DataSet3
            // 
            this.data_base1DataSet3.DataSetName = "Data_base1DataSet3";
            this.data_base1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // нагрузкаBindingSource2
            // 
            this.нагрузкаBindingSource2.DataMember = "Нагрузка";
            this.нагрузкаBindingSource2.DataSource = this.data_base1DataSet3;
            // 
            // нагрузкаTableAdapter2
            // 
            this.нагрузкаTableAdapter2.ClearBeforeFill = true;
            // 
            // data_base1DataSet4
            // 
            this.data_base1DataSet4.DataSetName = "Data_base1DataSet4";
            this.data_base1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // педагогиBindingSource
            // 
            this.педагогиBindingSource.DataMember = "Педагоги";
            this.педагогиBindingSource.DataSource = this.data_base1DataSet4;
            // 
            // педагогиTableAdapter
            // 
            this.педагогиTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1940, 864);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView5);
            this.Name = "Form2";
            this.Text = "Педагогическая нагрузка";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.НагрузкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ДисциплинаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data_base1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_base1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.нагрузкаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_base1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.нагрузкаBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_base1DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.педагогиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource НагрузкаBindingSource;
        private System.Windows.Forms.BindingSource ДисциплинаBindingSource;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column24;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column23;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column25;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private Data_base1DataSet1 Data_base1DataSet1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource database1DataSet1BindingSource;
        private Data_base1DataSet2 data_base1DataSet2;
        private System.Windows.Forms.BindingSource нагрузкаBindingSource1;
        private Data_base1DataSet2TableAdapters.НагрузкаTableAdapter нагрузкаTableAdapter1;
        private Data_base1DataSet3 data_base1DataSet3;
        private System.Windows.Forms.BindingSource нагрузкаBindingSource2;
        private Data_base1DataSet3TableAdapters.НагрузкаTableAdapter нагрузкаTableAdapter2;
        private Data_base1DataSet4 data_base1DataSet4;
        private System.Windows.Forms.BindingSource педагогиBindingSource;
        private Data_base1DataSet4TableAdapters.ПедагогиTableAdapter педагогиTableAdapter;
    }
}