using System;
using System.Diagnostics;
using System.Windows.Forms;


namespace monteKarlo_forms
{
    using static Convert;

    class MonteCarlo
    {
        private Figure figure;  //наша фигура


        public MonteCarlo (Point[] pointsArray)
        {
            figure = new Figure (pointsArray);
        }


        public void calculate(DataGridView table)
        {
            Stopwatch watch = new Stopwatch();  //таймер

            var actualSquare = figure.calculateActualSquare();  //настоящая площадь

            var number = new Random();
            int сounter;
            double randomX;
            double randomY;
            for (var i = 0; i < 5; i++)
            {
                watch.Start();  //запуска таймера
                double n = Math.Pow(10, i + 3); //задача общего колва точек от 10^3 до 10^7

                сounter = 0;
                for (var j = 0; j < n; j++)
                {
                    randomX = figure.minX + ToDouble(number.Next(0, 42757)) / 42757 * (figure.maxX - figure.minX);  //генерация случайной координаты по оси x
                    randomY = figure.minY + ToDouble(number.Next(0, 42757)) / 42757 * (figure.maxY - figure.minY);  //генерация случайной координаты по оси y
                    if (figure.isInside(randomX, randomY))  // проверка внутри ли эта точка
                        сounter++;
                }

                var square = figure.square * сounter / n;   //вычисление площади по формуле монте карло
                watch.Stop();   //остановка таймера

                table.Rows.Add (n, сounter, actualSquare, square,
                    Math.Round (Math.Abs (square - actualSquare) / actualSquare * 100, 2), watch.ElapsedMilliseconds);  //добавление всех жданных в таблицу

                watch.Reset();
            }
        }
    }
}
