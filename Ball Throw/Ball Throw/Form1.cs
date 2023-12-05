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
    public partial class Form1 : Form
    {
        public double height = -1, speed_throw = -1, speed_wind = -1;
        public string n_th = "", n_wind = "";
        public List<double> x0 = new List<double>();
        public List<double> y0 = new List<double>();
        public List<double> x = new List<double>();
        public List<double> y = new List<double>();
        bool rotate = false;
        public Form1()
        {
            InitializeComponent();           
        }       

        private void НовыйБросокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p_ball.Visible = false;
            p_bp.Visible = false;
            Form2 new_throw = new Form2();
            new_throw.Owner = this;
            new_throw.ShowDialog();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (x.Count() != 0)
            {
                p_ball.Visible = false;
                p_bp.Visible = false;
                Excel file = new Excel();
                file.Open(System.Windows.Forms.Application.StartupPath + @"\Полет.xlsx", 1);
                int k = 2;
                while (file.ReadCell(k, 6) != "")
                {
                    k++;
                }
                file.Writecell(k, 1, height.ToString());
                file.Writecell(k, 2, speed_throw.ToString());
                file.Writecell(k, 3, n_th);
                file.Writecell(k, 4, speed_wind.ToString());
                file.Writecell(k, 5, n_wind);
                file.Writecell(k, 6, "x");
                file.Writecell(k + 1, 6, "y");
                for (int j = 0; j < x.Count(); j++)
                {
                    file.Writecell(k, j + 7, Math.Round(x[j], 0).ToString());
                    file.Writecell(k + 1, j + 7, Math.Round(y[j], 0).ToString());
                }
                file.Save();
                file.Close();
            }
            else
            {
                MessageBox.Show("Нет данных для сохранения!","Ошибка");
            }
        }     

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p_ball.Visible = false;
            p_bp.Visible = false;
            Form3 spravka = new Form3();
            spravka.Owner = this;
            spravka.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            p_ball.Visible = false;
            p_bp.Visible = false;
            if (height == -1 || speed_throw == -1 || speed_wind == -1 || n_th == "" || n_wind == "")
            {
                MessageBox.Show("Создайте новый бросок!","Ошибка");
            }
            else
            {
                if (e.Y < 331)
                {
                    MessageBox.Show("Баскетболист должен стоять на земле!","Ошибка");
                }
                else
                {                   
                    x0.Clear();
                    y0.Clear();
                    x.Clear();
                    y.Clear();
                    Excel par = new Excel(height, speed_throw, speed_wind, n_th, n_wind);
                    p_bp.Height = Convert.ToInt32(height + 90);
                    double x_ball;
                    double y_ball;
                    double ground = e.Y - 30;
                    //MessageBox.Show(ground.ToString());
                    double t = 0;    
                    if (par.Direction_Throw == "Вправо")
                    {
                        x_ball = e.X - 15 + p_bp.Width / 2;
                        y_ball = e.Y - p_bp.Height;                           
                        par.Y = y_ball; 
                        x.Add(x_ball); 
                        y.Add(y_ball); 
                        if (rotate == true) rotate = false;
                        if (par.Direction_Wind == "Попутный")
                        {
                            while (par.Y < (ground - y_ball))
                            {
                                par.Fly(x0, y0, t, 1);                                
                                t += 0.015;
                            }
                        }
                        else
                        {
                            while (par.Y < (ground - y_ball))
                            {
                                par.Fly(x0, y0, t, 2);
                                t += 0.015;
                            }
                        }
                    }
                    else
                    {
                        x_ball = e.X - 15 - p_bp.Width / 2;
                        y_ball = e.Y - p_bp.Height;                        
                        par.Y = y_ball;   
                        x.Add(x_ball);  
                        y.Add(y_ball); 
                        if (rotate == false)
                        {
                            p_bp.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                            rotate = true;
                        }                      
                        if (par.Direction_Wind == "Попутный")
                        {
                            while (par.Y < (ground - y_ball))
                            {
                                par.Fly(x0, y0, t, 3);
                                t += 0.015;
                            }
                        }
                        else
                        {
                            while (par.Y < (ground - y_ball))
                            {
                                par.Fly(x0, y0, t, 4);
                                t += 0.015;
                            }
                        }
                    }                                                                                             
                    for (int i=0;i<x0.Count()-1;i++)
                    {
                        double razn = x0[i + 1] - x0[i];                     
                        x.Add(x[i] + razn);
                        razn = y0[i + 1] - y0[i];
                        y.Add(y[i] + razn);                      
                    }
                    menuStrip.Visible = false;                   
                    p_ball.Location = new Point(Convert.ToInt32(x_ball), Convert.ToInt32(y_ball));
                    p_bp.Location = new Point(e.X - p_bp.Size.Width/2, e.Y - p_bp.Size.Height);                   
                    p_ball.Visible = true;
                    p_bp.Visible = true;
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(500);
                    for (int i = 0; i < x.Count; i++)
                    {                     
                        Application.DoEvents();                      
                        p_ball.Location = new Point(Convert.ToInt32(x[i]), Convert.ToInt32(y[i]));                                              
                    }
                    menuStrip.Visible = true;
                }               
            }            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, 30, 30);
            Region rgn = new Region(path);
            p_ball.Region = rgn;
        }
    }
}
