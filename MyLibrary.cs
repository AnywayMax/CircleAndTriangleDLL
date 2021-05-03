using System;

namespace MyLibrary
{
    public static class MyLibrary
    {
        public static double MatchTriangle(double side1, double side2, double side3)
        {
            if ((side1 == 0 && side2 == 0 && side3 == 0)) return 0;
            //Площадь треугольника ∆ABC можно найти зная длины его сторон a, b и c, воспользовавшись формулой Герона
            double p = side1 + side2 + side3;
            double s = Math.Sqrt(p / 2 * (p / 2 - side1) * (p / 2 - side2) * (p / 2 - side3));
            return s;
        }
        public static double MatchCircle(double R)
        {
            if (R == 0) return 0;
            return Math.PI * Math.Pow(R, 2);
        }
    }
}
