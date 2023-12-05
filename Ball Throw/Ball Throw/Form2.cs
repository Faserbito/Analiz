// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ball_Throw
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            cb_th.Items.AddRange(new string[] {"Вправо", "Влево"});
            cb_wind.Items.AddRange(new string[] { "Попутный", "Встречный" });
        }

        private void b_accept_Click(object sender, EventArgs e)
        {           
            if (tb_h.Text == "" || tb_skth.Text == "" || tb_skv.Text == "" || cb_th.SelectedIndex == -1 || cb_wind.SelectedIndex == -1)
            {
                MessageBox.Show("Заполните все поля!","Ошибка");
            }
            else
            {                
                FlyBall par = new FlyBall();  
                double valueh;
                bool rezh = double.TryParse(tb_h.Text, out valueh);
                double valueth;
                bool rezth = double.TryParse(tb_skth.Text, out valueth);
                double valuev;
                bool rezv = double.TryParse(tb_skv.Text, out valuev);
                if (rezh == false || rezth == false || rezv == false)
                {
                    MessageBox.Show("Неверный формат ввода!", "Ошибка");
                }
                else
                {
                    par.Height = valueh;
                    par.Speed_Throw = valueth;
                    par.Speed_Wind = valuev;
                    if (par.Height != 0 && par.Speed_Throw != 0 && par.Speed_Wind != 0)
                    {
                        Form1 f1 = this.Owner as Form1;
                        f1.height = par.Height;
                        f1.speed_throw = par.Speed_Throw;
                        f1.speed_wind = par.Speed_Wind;
                        f1.n_th = cb_th.Text;
                        f1.n_wind = cb_wind.Text;
                        f1.x.Clear();
                        f1.y.Clear();
                        this.Close();
                        f1.Show();
                    }
                }                                                                          
            }            
        }

        private void tb_h_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num) && num != 8 && num != 44) e.Handled = true;
        }

        private void tb_skth_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num) && num != 8 && num != 44) e.Handled = true;
        }

        private void tb_skv_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num) && num != 8 && num != 44) e.Handled = true;
        }
    }
}
