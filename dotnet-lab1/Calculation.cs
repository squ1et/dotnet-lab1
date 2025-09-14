using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_lab1
{
    internal class Calculation
    {
        public double[,] xy = new double[1000, 2];

        public int n = 0;

        private double f1(double x)
        {
            return Math.Cos(x * x * x - 4 * x + 4) / (x * x * x - Math.Log(Math.Abs(x) + 1));
        }
        private double f2(double x)
        {
            return Math.Pow(Math.Sin(x + 2), 2) / (Math.Pow(2 * x * x + x * x * x * x + 1, 1.0 / 3.0));
        }
        private double f3(double x)
        {
            return (Math.Sqrt(Math.Abs(Math.Pow(x, 3))) * Math.Sin(Math.Pow(x, 3))) /
                   (Math.Pow(Math.Cos(x + 1), 2));
        }


        public void calc(double xn = 1, double xk = 5, double h = 1, double a = 3)
        {
            double x = xn, y;
            int i = 0;
            while (x <= xk)
            {
                if (x < 0)
                {
                    y = f1(x);
                }

                else if (x > 0 && x < a)
                {
                    y = f2(x);
                }

                else
                {
                    y = f3(x);
                }

                xy[i, 0] = x;
                xy[i, 1] = y;
                x += h;
                i++;
            }
            n = i;
        }
    }
}
