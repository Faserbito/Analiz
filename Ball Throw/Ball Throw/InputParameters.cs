// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ball_Throw
{
    public class InputParameters
    {
        double height, speed_throw, speed_wind;
        string n_th, n_wind;
        public InputParameters()
        {

        }

        public InputParameters(double height, double speed_throw, double speed_wind, string n_th, string n_wind)
        {
            Height = height;
            Speed_Throw = speed_throw;
            Speed_Wind = speed_wind;
            Direction_Throw = n_th;
            Direction_Wind = n_wind;
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value >= 150 && value <= 210)
                {
                    height = value;
                }
                else
                {
                    height = 0;
                    MessageBox.Show("Рост не соответсвует реальности");
                }
            }
        }

        public double Speed_Throw
        {
            get
            {
                return speed_throw;
            }
            set
            {               
                if (value >= 5 && value <= 50)
                {
                    speed_throw = value;
                }
                else
                {
                    speed_throw = 0;
                    MessageBox.Show("Скорость мяча не соответствует реальности");
                }               
            }
        }

        public double Speed_Wind
        {
            get
            {
                return speed_wind;
            }
            set
            {                
                if (value >= 0 && value <= 10)
                {
                    speed_wind = value;
                }
                else
                {
                    speed_wind = 0;
                    MessageBox.Show("Скорость ветра не соответствует реальности");
                }
            }
        }
        public string Direction_Throw
        {
            get
            {
                return n_th;
            }
            set
            {
                n_th = value;
            }
        }

        public string Direction_Wind
        {
            get
            {
                return n_wind;
            }
            set
            {
                n_wind = value;
            }
        }
    }    
}
