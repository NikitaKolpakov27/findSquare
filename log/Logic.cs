using System;

namespace log
{
    public class Logic
    {
        public double findSquare(double side)
        {
            double a = side;
            double S_square = a * a;
            double S_circle = Math.PI * Math.Pow((a / 2), 2);
            double sought_square = ((S_square - S_circle) / 4) + S_square / 4;

            return sought_square;
        }
    }
}