using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Point
    {
        private double x, y;

        public Point() //конструктор по умолчанию
        {
            Random random = new Random();
            x = random.Next(-1000, 1000) / Math.Pow(10, random.Next(3));
            y = random.Next(-1000, 1000) / Math.Pow(10, random.Next(3));
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Point(Point n) //конструктор копирования
        {
            x = n.x;
            y = n.y;
        }

        //перегруженный ToString(), возвращает координаты точки
        public override string ToString()
        {
            return $"({x}; {y})";
        }

        //вычисляет расстояние от точки до начала координат
        public double Distance()
        {
            double z = 0;
            return z = Math.Sqrt(x * x + y * y);
        }

        //уменьшение координат x и y на 1
        public static Point operator --(Point n)
        {
            n.x--;
            n.y--;
            return n;
        }

        //меняет координаты х и у местами
        public static Point operator -(Point n)
        {
            double x1 = n.x;
            n.x = n.y;
            n.y = x1;
            return n;
        }

        //вычитает целое число из координаты x(левосторонняя операция)
        public static Point operator -(Point n, int z)
        {
            return new Point(n.x - z, n.y);
        }

        //вычитает целое число из координаты y(правосторонняя операция)
        public static Point operator -(int z, Point n)
        {
            return new Point(n.x, n.y - z);
        }

        //вычисляет расстояние от точки p1 до точки p, возвращает вещественное число
        public static double operator -(Point z, Point n)
        {
            return Math.Sqrt(Math.Abs(z.x - n.x) * Math.Abs(z.x - n.x) + Math.Abs(z.y - n.y) * Math.Abs(z.x - n.y));
        }

        //int (неявная) – результатом является целая часть координаты х
        public static implicit operator int(Point n)
        {
            return (int)n.x;
        }

        //double (явная) – результатом является координата y
        public static explicit operator double(Point n)
        {
            return n.y;
        }

        //геттеры
        public double X
        {
            get { return x; }
        }
        public double Y
        {
            get { return y; }
        }
    }
}
