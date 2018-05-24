using System;
using System.Collections.Generic;
using System.Text;

namespace HuongThaoCore
{
    public static class HTMath
    {        
        public static double PhuongTrinhBacNhat(double a, double b)
        {
            return -b / a;
        }
        public static double[] PhuongTrinhBac2(double a, double b, double c)
        {
            double[] nghiem = new double[0];

            double delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta > 0)
            {
                nghiem = new double[2];
                nghiem[0] = (-b - Math.Sqrt(delta)) / 2 * a;
                nghiem[1] = (-b + Math.Sqrt(delta)) / 2 * a;
            }
            else if (delta == 0)
            {
                nghiem = new double[1];
                nghiem[0] = -b / 2 * a;
            }
            else if (delta < 0)
            {
                nghiem = new double[0];
            }
            return nghiem;
        }
        public static double RadToDegree(double rad)
        {
            return rad * 180 / Math.PI;
        }
    }
}
