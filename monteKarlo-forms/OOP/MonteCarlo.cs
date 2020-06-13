using System;
using System.Diagnostics;
using System.Windows.Forms;


namespace monteKarlo_forms
{
    using static Convert;

    class MonteCarlo
    {
        private Figure figure;


        public MonteCarlo (Point[] pointsArray)
        {
            figure = new Figure (pointsArray);
        }


        public void calculate(DataGridView table)
        {
            Stopwatch watch = new Stopwatch();

            var actualSquare = figure.calculateActualSquare();

            var number = new Random();
            int сounter;
            double randomX;
            double randomY;
            for (var i = 0; i < 5; i++)
            {
                watch.Start();
                double n = Math.Pow(10, i + 3);

                сounter = 0;
                for (var j = 0; j < n; j++)
                {
                    randomX = figure.minX + ToDouble(number.Next(0, 42757)) / 42757 * (figure.maxX - figure.minX);
                    randomY = figure.minY + ToDouble(number.Next(0, 42757)) / 42757 * (figure.maxY - figure.minY);
                    if (figure.isInside(randomX, randomY))
                        сounter++;
                }

                var square = figure.square * сounter / n;
                watch.Stop();

                table.Rows.Add (n, сounter, actualSquare, square,
                    Math.Round (Math.Abs (square - actualSquare) / actualSquare * 100, 2), watch.ElapsedMilliseconds);

                watch.Reset();
            }
        }
    }
}
