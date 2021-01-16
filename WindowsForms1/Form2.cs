using System;
using System.Windows.Forms;
using System.Data.OleDb;
using MaterialSkin.Controls;
using Excel=Microsoft.Office.Interop.Excel;
using System.Drawing.Printing;

namespace WindowsForms1
{
    public partial class Form2 : MaterialForm
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Data_base1.mdb;";

        private OleDbConnection dbConnection;

        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dbConnection = new OleDbConnection(connectString);
            dbConnection.Open();
            string query = "SELECT Дисциплина.Дисциплина, Дисциплина.[Лекции 1 семестр], Дисциплина.[Лекции 2 семестр], Дисциплина.[ЛР 1 семестр], Дисциплина.[ЛР 2 семестр], Дисциплина.[ПР 1 семестр], Дисциплина.[ПР 2 семестр], Дисциплина.[КП 1 семестр], Дисциплина.[КП 2 семестр], Дисциплина.[Консультации 1 семестр], Дисциплина.[Консультации 2 семестр], Дисциплина.[ФК 1 семестр], Дисциплина.[ФК 2 семестр], Дисциплина.[Самостоятельные работы] FROM Педагоги INNER JOIN(Дисциплина INNER JOIN Нагрузка ON Дисциплина.Код = Нагрузка.[Наименование предмета]) ON Педагоги.Код = Нагрузка.Преподаватель WHERE(((Педагоги.ФИО) like '" + comboBox1.Text.ToString() + "%'));";
            string query_1 = "SELECT Группы.Группа FROM Группы INNER JOIN(Педагоги INNER JOIN Нагрузка ON Педагоги.Код = Нагрузка.Преподаватель) ON Группы.Код = Нагрузка.Группа WHERE(((Педагоги.ФИО) like '" + comboBox1.Text.ToString() + "%'));";
            string query_2 = "SELECT SUM( Дисциплина.[Лекции 1 семестр]+ Дисциплина.[Лекции 2 семестр]+ Дисциплина.[ЛР 1 семестр]+ Дисциплина.[ЛР 2 семестр]+ Дисциплина.[ПР 1 семестр]+ Дисциплина.[ПР 2 семестр]+ Дисциплина.[КП 1 семестр]+ Дисциплина.[КП 2 семестр]+ Дисциплина.[Консультации 1 семестр]+ Дисциплина.[Консультации 2 семестр]+ Дисциплина.[Самостоятельные работы]) AS Сумма FROM Педагоги INNER JOIN(Дисциплина INNER JOIN Нагрузка ON Дисциплина.Код = Нагрузка.[Наименование предмета]) ON Педагоги.Код = Нагрузка.Преподаватель WHERE(((Педагоги.ФИО) like '" + comboBox1.Text.ToString() + "%'));";

            
            
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            OleDbCommand dbCommand1 = new OleDbCommand(query_1, dbConnection);
            OleDbCommand dbCommand2 = new OleDbCommand(query_2, dbConnection);

            OleDbDataReader dbReader = dbCommand.ExecuteReader();
            OleDbDataReader dbReader1 = dbCommand1.ExecuteReader();
            OleDbDataReader dbReader2 = dbCommand2.ExecuteReader();

            if (dbReader.HasRows == false)
            {
                MessageBox.Show("Данные не найдены", "Ошибка");
            }
            else
            {
                while(dbReader2.Read()) dataGridView1.Rows.Add(dbReader2["Сумма"]);

                while (dbReader.Read() && dbReader1.Read())
                {
                    dataGridView5.Rows.Add(dbReader["Дисциплина"], dbReader1["Группа"], dbReader["Лекции 1 семестр"], dbReader["Лекции 2 семестр"], dbReader["ЛР 1 семестр"], dbReader["ЛР 2 семестр"], dbReader["ПР 1 семестр"], dbReader["ПР 2 семестр"], dbReader["КП 1 семестр"], dbReader["КП 2 семестр"], dbReader["Консультации 1 семестр"], dbReader["Консультации 2 семестр"], dbReader["ФК 1 семестр"], dbReader["ФК 2 семестр"], dbReader["Самостоятельные работы"]);
                }
            }
            dbReader.Close();
            dbReader1.Close();
            dbReader2.Close();
            dbConnection.Close();
        }
        void  SaveTable(DataGridView Whate_Save)
        {
            Excel.Application excelapp = new Excel.Application();
            Excel.Workbook workbook = excelapp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;
            excelapp.Columns.ColumnWidth = 15;

            int k = 1;
            for (int i = 0; i < Whate_Save.Rows.Count - 1; i++)
            {
                for (int j = 0; j < Whate_Save.Columns.Count; j++)
                {
                    if (Whate_Save.Columns[j].Visible)
                    {
                        excelapp.Cells[1, 1] = "Педогагическая нагрузка преподавателя "+ comboBox1.Text.ToString();
                        worksheet.Cells[2, k] = Whate_Save.Columns[j].HeaderText;
                        worksheet.Cells[i + 3, k] = Whate_Save.Rows[i].Cells[j].Value;
                        excelapp.Cells[i+4, 3] = "Подпись____________________________";
                        k++;
                    }
                }
                k = 1;
            }
            excelapp.AlertBeforeOverwriting = false;
            excelapp.Quit();
            
        }
        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Bitmap bmp = new Bitmap(dataGridView5.Size.Width , dataGridView5.Size.Height);
            //dataGridView5.DrawToBitmap(bmp, dataGridView5.Bounds);
            //e.Graphics.DrawImage(bmp, 0, 0);
            //printDocument1.DefaultPageSettings.Landscape = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SaveTable(dataGridView5);
            //printDocument1.Print();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "data_base1DataSet4.Педагоги". При необходимости она может быть перемещена или удалена.
            this.педагогиTableAdapter.Fill(this.data_base1DataSet4.Педагоги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "data_base1DataSet3.Нагрузка". При необходимости она может быть перемещена или удалена.
            this.нагрузкаTableAdapter2.Fill(this.data_base1DataSet3.Нагрузка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "data_base1DataSet2.Нагрузка". При необходимости она может быть перемещена или удалена.
            this.нагрузкаTableAdapter1.Fill(this.data_base1DataSet2.Нагрузка);

        }
    }
}

