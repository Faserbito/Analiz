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
    public class FlyBall:InputParameters
    {
        double x, y;

        public FlyBall()
        {

        }

        public FlyBall(double height, double speed_throw, double speed_wind, string n_th, string n_wind) :base(height, speed_throw, speed_wind, n_th, n_wind)
        {
            
        }       
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }            
        public void Fly(List<double> t_x, List<double> t_y, double t, byte num)
        {
            switch(num.ToString())
            {
                case "1":
                    x = Speed_Throw * t * Math.Cos(0.7854) + ((0.4 * 1.2754 * Math.Pow(Speed_Wind, 2) * Math.Pow(0.75, 2) / (Math.PI * 8)) * Math.Cos(0.7854) * Math.Pow(t, 2) / (2 * 0.65));
                    t_x.Add(x);                   
                    y = - Speed_Throw * t * Math.Sin(0.7854) + ((9.8 - (0.4 * 1.2754 * Math.Pow(Speed_Wind, 2) * Math.Pow(0.75, 2) * Math.Sin(0.7854) / (Math.PI * 8))) * Math.Pow(t, 2) / (2 * 0.65));
                    t_y.Add(y);
                    break;

                case "2":                   
                    x = Speed_Throw * t * Math.Cos(0.7854) - ((0.4 * 1.2754 * Math.Pow(Speed_Wind, 2) * Math.Pow(0.75, 2) / (Math.PI * 8)) * Math.Cos(0.7854) * Math.Pow(t, 2) / (2 * 0.65));
                    t_x.Add(x);
                    y = - Speed_Throw * t * Math.Sin(0.7854) + ((9.8 - (0.4 * 1.2754 * Math.Pow(Speed_Wind, 2) * Math.Pow(0.75, 2) * Math.Sin(0.7854) / (Math.PI * 8)))  * Math.Pow(t, 2) / (2 * 0.65));
                    t_y.Add(y);
                    break;

                case "3":                  
                    x = - Speed_Throw * t * Math.Cos(0.7854) - ((0.4 * 1.2754 * Math.Pow(Speed_Wind, 2) * Math.Pow(0.75, 2) / (Math.PI * 8)) * Math.Cos(0.7854) * Math.Pow(t, 2) / (2 * 0.65));
                    t_x.Add(x);
                    y = - Speed_Throw * t * Math.Sin(0.7854) + ((9.8 - (0.4 * 1.2754 * Math.Pow(Speed_Wind, 2) * Math.Pow(0.75, 2) * Math.Sin(0.7854) / (Math.PI * 8))) * Math.Pow(t, 2) / (2 * 0.65));
                    t_y.Add(y);
                    break;

                case "4":                  
                    x = - Speed_Throw * t * Math.Cos(0.7854) + ((0.4 * 1.2754 * Math.Pow(Speed_Wind, 2) * Math.Pow(0.75, 2) / (Math.PI * 8)) * Math.Cos(0.7854) * Math.Pow(t, 2) / (2 * 0.65));
                    t_x.Add(x);
                    y = - Speed_Throw * t * Math.Sin(0.7854) + ((9.8 - (0.4 * 1.2754 * Math.Pow(Speed_Wind, 2) * Math.Pow(0.75, 2) * Math.Sin(0.7854) / (Math.PI * 8))) * Math.Pow(t, 2) / (2 * 0.65));
                    t_y.Add(y);
                    break;
            }
        }
    }
}
