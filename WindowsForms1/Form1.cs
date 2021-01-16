using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.Common;
using System.Data.SqlClient;

namespace WindowsForms1
{
    public partial class Form1 : MaterialForm
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Data_base1.mdb;";

        private OleDbConnection dbConnection;

        public Form1()
        {
            InitializeComponent();
            var materialSkin = MaterialSkinManager.Instance;
            materialSkin.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue800, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            dbConnection = new OleDbConnection(connectString);
            dbConnection.Open();
            string query = "SELECT * FROM Педагоги";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();
            if (dbReader.HasRows == false)
            {
                MessageBox.Show("Данные не найдены", "Ошибка");
            }
            else
            {
                while (dbReader.Read())
                {
                    dataGridView1.Rows.Add(dbReader["Код"], dbReader["ФИО"]);
                }
            }
            dbReader.Close();
            dbConnection.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridView1.SelectedRows[0].Index;

            if (dataGridView1.Rows[index].Cells[0].Value == null ||
               dataGridView1.Rows[index].Cells[1].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }

            string код = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string ФИО = dataGridView1.Rows[index].Cells[1].Value.ToString();

            dbConnection = new OleDbConnection(connectString);
            dbConnection.Open();
            string query = "INSERT INTO Педагоги VALUES  (" + код + ", '" + ФИО + "')";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выплнения запроса!", "Внимание!");
            else
                MessageBox.Show("Данные добавлены!", "Внимание!");

            dbConnection.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridView1.SelectedRows[0].Index;

            if (dataGridView1.Rows[index].Cells[0].Value == null ||
               dataGridView1.Rows[index].Cells[1].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }

            string Код = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string ФИО = dataGridView1.Rows[index].Cells[1].Value.ToString();

            dbConnection = new OleDbConnection(connectString);
            dbConnection.Open();
            string query = "UPDATE Педагоги SET ФИО='" + ФИО + "' WHERE Код=" + Код;
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выплнения запроса!", "Внимание!");
            else
                MessageBox.Show("Данные изменены!", "Внимание!");

            dbConnection.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridView1.SelectedRows[0].Index;

            if (dataGridView1.Rows[index].Cells[0].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }

            string Код = dataGridView1.Rows[index].Cells[0].Value.ToString();

            dbConnection = new OleDbConnection(connectString);
            dbConnection.Open();
            string query = "DELETE FROM Педагоги WHERE Код =" + Код;
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выплнения запроса!", "Внимание!");
            else
            {
                MessageBox.Show("Данные удалены!", "Внимание!");
                dataGridView1.Rows.RemoveAt(index);
            }
            dbConnection.Close();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            dbConnection = new OleDbConnection(connectString);
            dbConnection.Open();
            string query = "SELECT * FROM Группы";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();

            if (dbReader.HasRows == false)
            {
                MessageBox.Show("Данные не найдены", "Ошибка");
            }
            else
            {
                while (dbReader.Read())
                {
                    dataGridView2.Rows.Add(dbReader["Код"], dbReader["Группа"]);
                }
            }
            dbReader.Close();
            dbConnection.Close();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridView2.SelectedRows[0].Index;

            if (dataGridView2.Rows[index].Cells[0].Value == null ||
               dataGridView2.Rows[index].Cells[1].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }

            string код = dataGridView2.Rows[index].Cells[0].Value.ToString();
            string Группа = dataGridView2.Rows[index].Cells[1].Value.ToString();

            dbConnection = new OleDbConnection(connectString);
            dbConnection.Open();
            string query = "INSERT INTO Группы VALUES  (" + код + ", '" + Группа + "')";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выплнения запроса!", "Внимание!");
            else
                MessageBox.Show("Данные добавлены!", "Внимание!");

            dbConnection.Close();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridView2.SelectedRows[0].Index;

            if (dataGridView2.Rows[index].Cells[0].Value == null ||
               dataGridView2.Rows[index].Cells[1].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }

            string Код = dataGridView2.Rows[index].Cells[0].Value.ToString();
            string Группа = dataGridView2.Rows[index].Cells[1].Value.ToString();

            dbConnection = new OleDbConnection(connectString);
            dbConnection.Open();
            string query = "UPDATE Группы SET Группа='" + Группа + "' WHERE Код=" + Код;
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выплнения запроса!", "Внимание!");
            else
                MessageBox.Show("Данные изменены!", "Внимание!");

            dbConnection.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridView2.SelectedRows[0].Index;

            if (dataGridView2.Rows[index].Cells[0].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }

            string Код = dataGridView2.Rows[index].Cells[0].Value.ToString();

            dbConnection = new OleDbConnection(connectString);
            dbConnection.Open();
            string query = "DELETE FROM Группы WHERE Код =" + Код;
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выплнения запроса!", "Внимание!");
            else
            {
                MessageBox.Show("Данные удалены!", "Внимание!");
                dataGridView2.Rows.RemoveAt(index);
            }
            dbConnection.Close();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            dbConnection = new OleDbConnection(connectString);
            dbConnection.Open();
            string query = "SELECT Нагрузка.[Код] FROM Нагрузка;";
            string query1 = "SELECT Педагоги.[ФИО] as Преподаватель  FROM Нагрузка,Педагоги WHERE (Педагоги.[Код]=Нагрузка.[Преподаватель]);";
            string query2 = "SELECT Дисциплина.[Дисциплина] as [Наименование предмета] FROM Нагрузка,Дисциплина WHERE (Дисциплина.[Код]=Нагрузка.[Наименование предмета]);";
            string query3 = "SELECT Группы.[Группа] as Группа FROM Нагрузка, Группы WHERE (Группы.[Код]=Нагрузка.[Группа]);";
            string query4 = "SELECT [Учебный год].[Учебный год] as [Учебный год] FROM Нагрузка, [Учебный год] WHERE ([Учебный год].[Код]=Нагрузка.[Учебный год]);";


            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            OleDbCommand dbCommand1 = new OleDbCommand(query1, dbConnection);
            OleDbCommand dbCommand2 = new OleDbCommand(query2, dbConnection);
            OleDbCommand dbCommand3 = new OleDbCommand(query3, dbConnection);
            OleDbCommand dbCommand4 = new OleDbCommand(query4, dbConnection);

            OleDbDataReader dbReader = dbCommand.ExecuteReader();
            OleDbDataReader dbReader1 = dbCommand1.ExecuteReader();
            OleDbDataReader dbReader2 = dbCommand2.ExecuteReader();
            OleDbDataReader dbReader3 = dbCommand3.ExecuteReader();
            OleDbDataReader dbReader4 = dbCommand4.ExecuteReader();

            if (dbReader.HasRows == false)
            {
                MessageBox.Show("Данные не найдены", "Ошибка");
            }
            else
            {
                while (dbReader.Read() && dbReader1.Read() && dbReader2.Read() && dbReader3.Read() && dbReader4.Read())
                {
                    dataGridView3.Rows.Add(dbReader["Код"], dbReader1["Преподаватель"], dbReader2["Наименование предмета"], dbReader3["Группа"], dbReader4["Учебный год"]);
                }
            }
            dbReader.Close();
            dbReader1.Close();
            dbReader2.Close();
            dbReader3.Close();
            dbReader4.Close();
            dbConnection.Close();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            // index = dataGridView3.SelectedRows[0].Index;

            //if (dataGridView3.Rows[index].Cells[0].Value == null ||
            //   dataGridView3.Rows[index].Cells[1].Value == null)
            //{
            //    MessageBox.Show("Не все данные введены!", "Внимание!");
            //    return;
            //}
            string Преподаватель = comboBox1.SelectedValue.ToString();
            string Наименованиие_предмета = comboBox2.SelectedValue.ToString();
            string Группа = comboBox3.SelectedValue.ToString();
            string Учебный_год = comboBox4.SelectedValue.ToString();

            dbConnection = new OleDbConnection(connectString);
            dbConnection.Open();
            string query = "INSERT INTO Нагрузка (Преподаватель, [Наименование предмета], Группа, [Учебный год]) VALUES  (" + Преподаватель + ", " + Наименованиие_предмета + ", " + Группа + ", " + Учебный_год + ")";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выплнения запроса!", "Внимание!");
            else
                MessageBox.Show("Данные добавлены!", "Внимание!");

            dbConnection.Close();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridView3.SelectedRows[0].Index;

            if (dataGridView3.Rows[index].Cells[0].Value == null ||
               dataGridView3.Rows[index].Cells[1].Value == null ||
               dataGridView3.Rows[index].Cells[2].Value == null ||
               dataGridView3.Rows[index].Cells[3].Value == null ||
               dataGridView3.Rows[index].Cells[4].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }


            string Код = dataGridView3.Rows[index].Cells[0].Value.ToString();
            string Преподаватель = dataGridView3.Rows[index].Cells[1].Value.ToString();
            string Наименованиие_предмета = dataGridView3.Rows[index].Cells[2].Value.ToString();
            string Группа = dataGridView3.Rows[index].Cells[3].Value.ToString();
            string Учебный_год = dataGridView3.Rows[index].Cells[4].Value.ToString();

            dbConnection = new OleDbConnection(connectString);
            dbConnection.Open();
            string query = "UPDATE Нагрузка SET Преподаватель=" + Преподаватель + ", [Наименование предмета]=" + Наименованиие_предмета + ", Группа=" + Группа + ", [Учебный год]=" + Учебный_год + " WHERE Код=" + Код;
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выплнения запроса!", "Внимание!");
            else
                MessageBox.Show("Данные изменены!", "Внимание!");

            dbConnection.Close();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridView3.SelectedRows[0].Index;

            if (dataGridView3.Rows[index].Cells[0].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }

            string Код = dataGridView3.Rows[index].Cells[0].Value.ToString();

            dbConnection = new OleDbConnection(connectString);
            dbConnection.Open();
            string query = "DELETE FROM Нагрузка WHERE Код =" + Код;
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выплнения запроса!", "Внимание!");
            else
            {
                MessageBox.Show("Данные удалены!", "Внимание!");
                dataGridView3.Rows.RemoveAt(index);
            }
            dbConnection.Close();
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            dbConnection = new OleDbConnection(connectString);
            dbConnection.Open();
            string query = "SELECT Группы.Код AS Группы_Код, Группы.Группа AS Группы_Группа, Дисциплина.Код AS Дисциплина_Код, Дисциплина.Дисциплина, Дисциплина.Группа AS Дисциплина_Группа, Дисциплина.[Лекции 1 семестр], Дисциплина.[Лекции 2 семестр], Дисциплина.[ЛР 1 семестр], Дисциплина.[ЛР 2 семестр], Дисциплина.[ПР 1 семестр], Дисциплина.[ПР 2 семестр], Дисциплина.[КП 1 семестр], Дисциплина.[КП 2 семестр], Дисциплина.[Консультации 1 семестр], Дисциплина.[Консультации 2 семестр], Дисциплина.[ФК 1 семестр], Дисциплина.[ФК 2 семестр], Дисциплина.[Самостоятельные работы] FROM Группы INNER JOIN Дисциплина ON Группы.[Код] = Дисциплина.[Группа] WHERE(((Группы.Группа) like '" + textBox1.Text + "%') and ((Дисциплина.Дисциплина) like '" + textBox2.Text + "%'));";

            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            OleDbDataReader dbReader = dbCommand.ExecuteReader();

            if (dbReader.HasRows == false)
            {
                MessageBox.Show("Данные не найдены", "Ошибка");
            }
            else
            {
                while (dbReader.Read())
                {
                    dataGridView4.Rows.Add(dbReader["Дисциплина_Код"], dbReader["Дисциплина"], dbReader["Группы_Группа"], dbReader["Лекции 1 семестр"], dbReader["Лекции 2 семестр"], dbReader["ЛР 1 семестр"], dbReader["ЛР 2 семестр"], dbReader["ПР 1 семестр"], dbReader["ПР 2 семестр"], dbReader["КП 1 семестр"], dbReader["КП 2 семестр"], dbReader["Консультации 1 семестр"], dbReader["Консультации 2 семестр"], dbReader["ФК 1 семестр"], dbReader["ФК 2 семестр"], dbReader["Самостоятельные работы"]);
                }
            }
            dbReader.Close();
            dbConnection.Close();
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridView4.SelectedRows[0].Index;

            if (dataGridView4.Rows[index].Cells[0].Value == null ||
               dataGridView4.Rows[index].Cells[1].Value == null ||
               dataGridView4.Rows[index].Cells[2].Value == null ||
               dataGridView4.Rows[index].Cells[3].Value == null ||
               dataGridView4.Rows[index].Cells[4].Value == null ||
               dataGridView4.Rows[index].Cells[5].Value == null ||
               dataGridView4.Rows[index].Cells[6].Value == null ||
               dataGridView4.Rows[index].Cells[7].Value == null ||
               dataGridView4.Rows[index].Cells[8].Value == null ||
               dataGridView4.Rows[index].Cells[9].Value == null ||
               dataGridView4.Rows[index].Cells[10].Value == null ||
               dataGridView4.Rows[index].Cells[11].Value == null ||
               dataGridView4.Rows[index].Cells[12].Value == null ||
               dataGridView4.Rows[index].Cells[13].Value == null ||
               dataGridView4.Rows[index].Cells[14].Value == null ||
               dataGridView4.Rows[index].Cells[15].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }

            string Код = dataGridView4.Rows[index].Cells[0].Value.ToString();
            string Дисциплина = dataGridView4.Rows[index].Cells[1].Value.ToString();
            string Группа = dataGridView4.Rows[index].Cells[2].Value.ToString();
            string Лекции_1_семестр = dataGridView4.Rows[index].Cells[3].Value.ToString();
            string Лекции_2_семестр = dataGridView4.Rows[index].Cells[4].Value.ToString();
            string ЛР_1_семестр = dataGridView4.Rows[index].Cells[5].Value.ToString();
            string ЛР_2_семестр = dataGridView4.Rows[index].Cells[6].Value.ToString();
            string ПР_1_семестр = dataGridView4.Rows[index].Cells[7].Value.ToString();
            string ПР_2_семестр = dataGridView4.Rows[index].Cells[8].Value.ToString();
            string КП_1_семестр = dataGridView4.Rows[index].Cells[9].Value.ToString();
            string КП_2_семестр = dataGridView4.Rows[index].Cells[10].Value.ToString();
            string Консультации_1_семестр = dataGridView4.Rows[index].Cells[11].Value.ToString();
            string Консультации_2_семестр = dataGridView4.Rows[index].Cells[12].Value.ToString();
            string ФК_1_семестр = dataGridView4.Rows[index].Cells[13].Value.ToString();
            string ФК_2_семестр = dataGridView4.Rows[index].Cells[14].Value.ToString();
            string Самостоятельные_работы = dataGridView4.Rows[index].Cells[15].Value.ToString();

            dbConnection = new OleDbConnection(connectString);
            dbConnection.Open();
            string query = "INSERT INTO Дисциплина VALUES (" + Код + ", '" + Дисциплина + "', " + Группа + ", " + Лекции_1_семестр + ", " + Лекции_2_семестр + ", " + ЛР_1_семестр + "," + ЛР_2_семестр + ", " + ПР_1_семестр + ", " + ПР_2_семестр + ", " + КП_1_семестр + ", " + КП_2_семестр + "," + Консультации_1_семестр + ", " + Консультации_2_семестр + ", '" + ФК_1_семестр + "', '" + ФК_2_семестр + "'," + Самостоятельные_работы + ") ";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выплнения запроса!", "Внимание!");
            else
                MessageBox.Show("Данные добавлены!", "Внимание!");

            dbConnection.Close();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridView4.SelectedRows[0].Index;

            if (dataGridView4.Rows[index].Cells[0].Value == null ||
               dataGridView4.Rows[index].Cells[1].Value == null ||
               dataGridView4.Rows[index].Cells[2].Value == null ||
               dataGridView4.Rows[index].Cells[3].Value == null ||
               dataGridView4.Rows[index].Cells[4].Value == null ||
               dataGridView4.Rows[index].Cells[5].Value == null ||
               dataGridView4.Rows[index].Cells[6].Value == null ||
               dataGridView4.Rows[index].Cells[7].Value == null ||
               dataGridView4.Rows[index].Cells[8].Value == null ||
               dataGridView4.Rows[index].Cells[9].Value == null ||
               dataGridView4.Rows[index].Cells[10].Value == null ||
               dataGridView4.Rows[index].Cells[11].Value == null ||
               dataGridView4.Rows[index].Cells[12].Value == null ||
               dataGridView4.Rows[index].Cells[13].Value == null ||
               dataGridView4.Rows[index].Cells[14].Value == null ||
               dataGridView4.Rows[index].Cells[15].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }

            string Код = dataGridView4.Rows[index].Cells[0].Value.ToString();
            string Дисциплина = dataGridView4.Rows[index].Cells[1].Value.ToString();
            string Группа = dataGridView4.Rows[index].Cells[2].Value.ToString();
            string Лекции_1_семестр = dataGridView4.Rows[index].Cells[3].Value.ToString();
            string Лекции_2_семестр = dataGridView4.Rows[index].Cells[4].Value.ToString();
            string ЛР_1_семестр = dataGridView4.Rows[index].Cells[5].Value.ToString();
            string ЛР_2_семестр = dataGridView4.Rows[index].Cells[6].Value.ToString();
            string ПР_1_семестр = dataGridView4.Rows[index].Cells[7].Value.ToString();
            string ПР_2_семестр = dataGridView4.Rows[index].Cells[8].Value.ToString();
            string КП_1_семестр = dataGridView4.Rows[index].Cells[9].Value.ToString();
            string КП_2_семестр = dataGridView4.Rows[index].Cells[10].Value.ToString();
            string Консультации_1_семестр = dataGridView4.Rows[index].Cells[11].Value.ToString();
            string Консультации_2_семестр = dataGridView4.Rows[index].Cells[12].Value.ToString();
            string ФК_1_семестр = dataGridView4.Rows[index].Cells[13].Value.ToString();
            string ФК_2_семестр = dataGridView4.Rows[index].Cells[14].Value.ToString();
            string Самостоятельные_работы = dataGridView4.Rows[index].Cells[15].Value.ToString();

            dbConnection = new OleDbConnection(connectString);
            dbConnection.Open();

            string query = "UPDATE Дисциплина  SET Дисциплина = '" + Дисциплина + "',  Группа = " + Группа + ", [Лекции 1 семестр] = " + Лекции_1_семестр + ", [Лекции 2 семестр] = " + Лекции_2_семестр + ", [ЛР 1 семестр] = " + ЛР_1_семестр + ", [ЛР 2 семестр] = " + ЛР_2_семестр + ", [ПР 1 семестр] = " + ПР_1_семестр + ", [ПР 2 семестр] =" + ПР_2_семестр + ", [КП 1 семестр] =" + КП_1_семестр + ", [КП 2 семестр] =" + КП_2_семестр + ", [Консультации 1 семестр] =" + Консультации_1_семестр + ", [Консультации 2 семестр] = " + Консультации_2_семестр + ", [ФК 1 семестр] = '" + ФК_1_семестр + "', [ФК 2 семестр] = '" + ФК_2_семестр + "', [Самостоятельные работы] = " + Самостоятельные_работы + " WHERE Код = " + Код;
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выплнения запроса!", "Внимание!");
            else
                MessageBox.Show("Данные обновлены!", "Внимание!");

            dbConnection.Close();
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "data_base1DataSet.Учебный_год". При необходимости она может быть перемещена или удалена.
            this.учебный_годTableAdapter.Fill(this.data_base1DataSet.Учебный_год);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "data_base1DataSet.Группы". При необходимости она может быть перемещена или удалена.
            this.группыTableAdapter.Fill(this.data_base1DataSet.Группы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "data_base1DataSet.Дисциплина". При необходимости она может быть перемещена или удалена.
            this.дисциплинаTableAdapter.Fill(this.data_base1DataSet.Дисциплина);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "data_base1DataSet.Педагоги". При необходимости она может быть перемещена или удалена.
            this.педагогиTableAdapter.Fill(this.data_base1DataSet.Педагоги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "data_base1DataSet.Нагрузка". При необходимости она может быть перемещена или удалена.
            this.нагрузкаTableAdapter.Fill(this.data_base1DataSet.Нагрузка);

        }
    }
}