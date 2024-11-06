using System;
using System.Diagnostics.Metrics;

namespace амогус
{

    class Program
    {
        static void Main(string[] args)
        {
            string x, y;
            double x1, y1;
            Console.WriteLine("Введите x");
            x = Console.ReadLine();
            try
            {
                x1 = Convert.ToDouble(x);
            }
            catch (Exception ex)
            {
                Console.WriteLine("x Не является числом");
                throw;
            }
            Console.WriteLine("Введите y");
            y = Console.ReadLine();
            try
            {
                y1 = Convert.ToDouble(y);
            }
            catch(Exception ex)
            {
                Console.WriteLine("y Не является числом");
                throw;
            }
            Point One=new Point(x1,y1);
            Point Two = new Point(One);
            Console.Write("X и Y в виде строки: ");
            string s = Two.ToString();
            Console.WriteLine(s);
            Console.Write("Расстояние от X до Y: ");
            double dis = Two.Range();
            Console.WriteLine(dis);
            Console.Write("Бинарный +: ");
            Two = Two++;
            Console.WriteLine(Two.ToString());
            Console.Write("Бинарный -: ");
            Two = Two--;
            Console.WriteLine(Two.ToString());
            Console.Write("Явное приведение: ");
            Console.WriteLine((int)Two);
            Console.Write("Неявное приведение: ");
            double z = Two;
            Console.WriteLine(z);
            double x2, y2;
            Console.WriteLine("Введите x точки p");
            x = Console.ReadLine();
            try
            {
                x2 = Convert.ToDouble(x);
            }
            catch(Exception ex)
            {
                Console.WriteLine("x Не является числом");
                throw;
            }
            Console.WriteLine("Введите y точки p");
            y = Console.ReadLine();
            try
            {
                y2 = Convert.ToDouble(y);
            }
            catch(Exception ex )
            {
                Console.WriteLine("y Не является числом");
                throw;
            }
            Point Three = new Point(x2,y2);
            double g=One+Three;
            Console.Write("Расстояние между XY и pXpY: ");
            Console.WriteLine(g);

            Point Some=One+x2;
            Console.Write("Добавление к точке XY координаты pX справа: ");
            Console.WriteLine(Some.ToString());
            Point Some2 = x2+One;
            Console.Write("Добавление к точке XY координаты pX слева: ");
            Console.WriteLine(Some2.ToString());
        }

    }
}