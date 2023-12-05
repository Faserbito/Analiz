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

namespace БД_курс
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = this.Owner as Form1;

            int count = 0;
            for (int i = 0; i < f1.Sotr.Count; i++)
            {
                count++;
                if (textBox1.Text == f1.Sotr[i].GetInfo()[3])
                {
                    if (textBox2.Text == f1.Sotr[i].GetInfo()[4])
                    {
                        f1.Kodsotr = f1.Sotr[i].GetInfo()[0];
                        if (f1.Sotr[i].GetInfo()[2] == "4")
                        {
                            f1.label2.Text = "Выберите сотрудника";
                            f1.tabControl1.TabPages.Add(f1.tabPage1);
                            f1.tabControl1.TabPages.Add(f1.tabPage2);
                            f1.tabControl1.TabPages.Add(f1.tabPage4);
                            f1.tabControl1.TabPages.Add(f1.tabPage3);
                            f1.comboBox2.Text = "";
                            f1.comboBox2.Enabled = true;
                        }
                        else
                        {
                            f1.label2.Text = "Сотрудник ";
                            f1.comboBox2.Text = $"{f1.Sotr[i].GetInfo()[1]}";
                            f1.comboBox2.Enabled = false;
                            f1.tabControl1.TabPages.Add(f1.tabPage2);
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Неправильный пароль");
                        textBox2.Text = "";
                    }
                    break;
                }
            }
            if (count == f1.Sotr.Count)
            {
                MessageBox.Show("Неправильный логин");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}
