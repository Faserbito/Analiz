// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace БД_курс
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;
        private List<Sotrudniki> sotr = new List<Sotrudniki>();
        public List<Sotrudniki> Sotr
        {
            get
            {
                return sotr;
            }
            set
            {
                sotr = value;
            }
        }
        private string kodsotr;
        public string Kodsotr
        {
            get
            {
                return kodsotr;
            }
            set
            {
                kodsotr = value;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            цsqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["BD"].ConnectionString);

            richTextBox1.Text = "";
            richTextBox2.Text = "";
            label3.Text = "Производственные процессы:";
            label4.Text = "Инциденты:";
            label5.Text = "Коэффициент работника: ";
            label6.Text = "Коэффициент работника: ";
            label7.Text = "Коэффициент работника: ";
            label3.Visible = false;
            label4.Visible = false;
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            chart1.Visible = false;
            chart2.Visible = false;

            sqlConnection.Open();

            //Добавление таблиц
            comboBox1.Items.Clear();
            SqlCommand thisCommand = sqlConnection.CreateCommand();
            thisCommand.CommandText = "SELECT Name FROM dbo.sysobjects WHERE(xtype = 'U')";
            SqlDataReader thisReader = thisCommand.ExecuteReader();
            while (thisReader.Read())
            {
                comboBox1.Items.Add(thisReader["Name"]);
            }
            thisReader.Close();

            //Добавление сотрудников
            SqlCommand thisCommand2 = new SqlCommand("SELECT * FROM [Сотрудники]", sqlConnection);
            SqlDataReader reader1 = thisCommand2.ExecuteReader();
            sotr.Clear();
            while (reader1.Read())
            {
                try
                {
                    sotr.Add(new Sotrudniki(reader1.GetInt32(0), reader1.GetString(1), reader1.GetInt32(2), reader1.GetString(3), reader1.GetString(4)));
                }
                catch (Exception) { }
                comboBox2.Items.Add(reader1.GetString(1));
            }
            reader1.Close();

            //Добавление должностей
            SqlCommand thisCommand3 = new SqlCommand("SELECT * FROM [Должности]", sqlConnection);
            SqlDataReader reader = thisCommand3.ExecuteReader();
            while (reader.Read())
            {
                comboBox4.Items.Add(reader.GetString(1));
            }
            reader.Close();

            sqlConnection.Close();

            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Remove(tabPage4);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            SqlDataAdapter dataAdapter = new SqlDataAdapter($"select * from [{comboBox1.Text}]", sqlConnection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void администраторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Remove(tabPage4);
            Form2 f2 = new Form2();
            f2.Owner = this;
            f2.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Remove(tabPage4);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart2.Series[0].Points.Clear();
            chart2.Series[1].Points.Clear();
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            label3.Text = "Производственные процессы:";
            label4.Text = "Инциденты:";
            label5.Text = "Коэффициент работника: ";
            label6.Text = "Коэффициент работника: ";
            label7.Text = "Коэффициент работника: ";
            label3.Visible = false;
            label4.Visible = false;
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            chart1.Visible = false;
            chart2.Visible = false;

            sqlConnection.Open();

            int count = 0;
            double k1 = 0;
            //Производственные процессы
            SqlCommand thisCommand = new SqlCommand($"SELECT [Сотрудники].[ФИО сотрудника], [Производственные процессы].[Название ПП], [Сотрудники в производственных процессах].[Доля участия], [Производственные процессы].[Вес ПП] FROM [Сотрудники в производственных процессах] INNER JOIN [Сотрудники] ON [Сотрудники].[Код сотрудника] = [Сотрудники в производственных процессах].[Сотрудник] INNER JOIN [Данные] INNER JOIN [Производственные процессы] ON [Производственные процессы].[Код ПП] = [Данные].[Производственный процесс] ON [Данные].[Код] = [Сотрудники в производственных процессах].[Производственный процесс] WHERE [Сотрудники].[ФИО сотрудника] = N'{comboBox2.Text}'", sqlConnection);
            SqlDataReader reader = thisCommand.ExecuteReader();
            while (reader.Read())
            {
                count += 1;
                chart1.Series[1].Points.Add(reader.GetInt32(2));
                chart1.Series[0].Points.Add(100);
                richTextBox1.Text = richTextBox1.Text + $"{count}: {reader.GetString(1)}, доля участия: {reader.GetInt32(2)}, вес пп: {reader.GetInt32(3)}" + "\n";
                double k = reader.GetInt32(3) * (Convert.ToDouble(reader.GetInt32(2)) / 100);
                k1 += k;
            }
            reader.Close();

            count = 0;
            double k2 = 0;
            //Инциденты
            SqlCommand thisCommand1 = new SqlCommand($"SELECT [Сотрудники].[ФИО сотрудника], [Инциденты].[Название инцидента], [Сотрудники в инцидентах].[Доля участия], [Инциденты].[Тяжесть] FROM [Сотрудники в инцидентах] INNER JOIN [Сотрудники] ON [Сотрудники].[Код сотрудника] = [Сотрудники в инцидентах].[Сотрудник] INNER JOIN [Инциденты на предприятии] INNER JOIN [Инциденты] ON [Инциденты].[Код инцидента] = [Инциденты на предприятии].[Инцидент] ON [Инциденты на предприятии].[Код] = [Сотрудники в инцидентах].[Инцидент] WHERE [Сотрудники].[ФИО сотрудника] = N'{comboBox2.Text}'", sqlConnection);
            reader = thisCommand1.ExecuteReader();
            while (reader.Read())
            {
                count += 1;
                chart2.Series[1].Points.Add(reader.GetInt32(2));
                chart2.Series[0].Points.Add(100);
                richTextBox2.Text = richTextBox2.Text + $"{count}: {reader.GetString(1)}, доля участия: {reader.GetInt32(2)}, тяжесть инцидента: {reader.GetInt32(3)}" + "\n";
                double k = reader.GetInt32(3) * (Convert.ToDouble(reader.GetInt32(2)) / 100);
                k2 += k;
            }
            reader.Close();

            sqlConnection.Close();

            if (k1 != 0 & k2 != 0)
            {
                this.Width = 658;
                this.Height = 648;
                label5.Text = "Положительный коэф. работника: " + k1;
                label6.Text = "Отрицательный коэф. работника: " + k2;
                label7.Text = "Коэффициент работника: " + (k1 - k2).ToString();
                richTextBox2.Location = new Point(321, 46);
                chart2.Location = new Point(320, 241);
                label3.Visible = true;
                label4.Visible = true;
                richTextBox1.Visible = true;
                richTextBox2.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                chart1.Visible = true;
                chart2.Visible = true;
            }
            else if (k1 != 0)
            {
                this.Width = 441;
                this.Height = 648;
                label5.Text = "Коэффициент работника: " + k1;
                label3.Visible = true;
                richTextBox1.Visible = true;
                label5.Visible = true;
                chart1.Visible = true;
            }
            else if (k2 != 0)
            {
                this.Width = 441;
                this.Height = 648;
                label5.Text = "Коэффициент работника: " + -k2;
                label3.Text = "Инциденты:";
                label3.Visible = true;
                richTextBox2.Location = new Point(10, 46);
                richTextBox2.Visible = true;
                label5.Visible = true;
                chart2.Location = new Point(9, 241);
                chart2.Visible = true;
            }
            else
            {
                this.Width = 658;
                this.Height = 648;
                label3.Text = "Ничего не делал!";
                label3.Visible = true;
            }
            //label5.Text = "Коэффициент работника: " + k1;
            //label6.Text = "Коэффициент работника: " + k2;
            //label7.Text = "Коэффициент работника: " + (k1 - k2).ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.Columns.Clear();
            dataGridView2.DataSource = null;
            textBox1.Text = "";
            label9.Visible = false;
            textBox1.Visible = false;
            if (comboBox3.SelectedIndex == 0)
            {
                label9.Visible = true;
                textBox1.Visible = true;
                SqlDataAdapter dataAdapter = new SqlDataAdapter($"declare @doljnost nvarchar(MAX) = N'{textBox1.Text}' select [Сотрудники].[Код сотрудника], [Сотрудники].[ФИО сотрудника], [Должности].[Название должности] from[Сотрудники] INNER JOIN [Должности] ON [Должности].[Код должности] = [Сотрудники].[Должность] where [Должности].[Название должности] = @doljnost", sqlConnection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridView2.DataSource = dataSet.Tables[0];
            }
            if (comboBox3.SelectedIndex == 1)
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT [Отделы].[Название отдела], COUNT(CASE [Данные].[Производственный процесс] WHEN 1 THEN 1 END) AS [Front-end разработка],  COUNT(CASE [Данные].[Производственный процесс] WHEN 2 THEN 1 END) AS [Back-end разработка],  COUNT(CASE [Данные].[Производственный процесс] WHEN 3 THEN 1 END) AS [Реклама],  COUNT(CASE [Данные].[Производственный процесс] WHEN 4 THEN 1 END) AS [Тестировка],  COUNT(CASE [Данные].[Производственный процесс] WHEN 5 THEN 1 END) AS [Отдел техподдержки] FROM [Данные]INNER JOIN [Отделы] ON [Отделы].[Код отдела] = [Данные].[Отдел]GROUP BY [Отделы].[Название отдела]", sqlConnection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridView2.DataSource = dataSet.Tables[0];
            }
            if (comboBox3.SelectedIndex == 3)
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT [Производственные процессы].[Название ПП], [Сотрудники].[ФИО сотрудника], IIF([Сотрудники в производственных процессах].[Доля участия] < 30, N'Аболтус', N'Работяга') AS [Участие] FROM [Сотрудники в производственных процессах] INNER JOIN [Сотрудники] ON [Сотрудники].[Код сотрудника] = [Сотрудники в производственных процессах].[Сотрудник] INNER JOIN [Данные] INNER JOIN [Производственные процессы] ON [Производственные процессы].[Код ПП] = [Данные].[Производственный процесс] ON [Данные].[Код] = [Сотрудники в производственных процессах].[Производственный процесс]", sqlConnection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridView2.DataSource = dataSet.Tables[0];
            }
            if (comboBox3.SelectedIndex == 4)
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT [Инциденты].[Название инцидента], [Инциденты на предприятии].[Дата инцидента], [Сотрудники].[ФИО сотрудника], (SELECT [Должности].[Название должности] FROM [Сотрудники] INNER JOIN [Должности] ON [Должности].[Код должности] = [Сотрудники].[Должность] WHERE [Сотрудники].[Код сотрудника] = [Сотрудники в инцидентах].[Сотрудник]) AS [Должность] FROM [Сотрудники в инцидентах] INNER JOIN [Инциденты на предприятии] INNER JOIN [Инциденты] ON [Инциденты].[Код инцидента] = [Инциденты на предприятии].[Инцидент] ON [Инциденты на предприятии].[Код] = [Сотрудники в инцидентах].[Инцидент] INNER JOIN [Сотрудники] ON [Сотрудники].[Код сотрудника] = [Сотрудники в инцидентах].[Сотрудник]", sqlConnection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridView2.DataSource = dataSet.Tables[0];
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)
            {
                dataGridView2.Columns.Clear();
                dataGridView2.DataSource = null;
                SqlDataAdapter dataAdapter = new SqlDataAdapter($"declare @doljnost nvarchar(MAX) = N'{textBox1.Text}' select [Сотрудники].[Код сотрудника], [Сотрудники].[ФИО сотрудника], [Должности].[Название должности] from[Сотрудники] INNER JOIN [Должности] ON [Должности].[Код должности] = [Сотрудники].[Должность] where [Должности].[Название должности] = @doljnost", sqlConnection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridView2.DataSource = dataSet.Tables[0];
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage4)
            {
                this.Width = 441;
                this.Height = 284;
            }
            else
            {
                this.Width = 658;
                this.Height = 648;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Length != 6 | textBox4.Text.Length != 11 | textBox2.Text == "" | comboBox4.Text == "")
            {
                MessageBox.Show("Что-то введено не верно", "Ошибка");
            }
            else if (textBox5.Text != "" | textBox6.Text != "")
            {
                if (textBox5.Text == "" | textBox6.Text == "")
                {
                    MessageBox.Show("Что-то введено не верно", "Ошибка");
                }
            }
            else
            {
                try
                {
                    sqlConnection.Open();

                    SqlCommand thisCommand1 = new SqlCommand($"INSERT INTO [dbo].[Сотрудники] ([ФИО сотрудника], [Должность], [Паспорт], [Телефон], [Логин], [Пароль]) VALUES (N'{textBox2.Text}', {comboBox4.SelectedIndex + 1}, N'{textBox3.Text}', N'{textBox4.Text}', N'{textBox5.Text}', N'{textBox6.Text}')", sqlConnection);
                    thisCommand1.ExecuteNonQuery();
                    MessageBox.Show("Сотрудник добавлен", "Сообщение");

                    //Обновление сотрудников
                    SqlCommand thisCommand2 = new SqlCommand("SELECT * FROM [Сотрудники]", sqlConnection);
                    SqlDataReader reader1 = thisCommand2.ExecuteReader();
                    sotr.Clear();
                    while (reader1.Read())
                    {
                        try
                        {
                            sotr.Add(new Sotrudniki(reader1.GetInt32(0), reader1.GetString(1), reader1.GetInt32(2), reader1.GetString(3), reader1.GetString(4)));
                        }
                        catch (Exception) { }
                        comboBox2.Items.Add(reader1.GetString(1));
                    }
                    reader1.Close();

                    sqlConnection.Close();

                    textBox2.Text = "";
                    comboBox4.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Сотрудник не добавлен", "Ошибка");
                }
            }
        }

        private void KeyPress_(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (e.KeyChar >= 0)
            {
                e.Handled = true;
            }
        }
        private void KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (e.KeyChar >= 58 | e.KeyChar <= 47 & e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
