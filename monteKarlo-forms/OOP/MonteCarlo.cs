using System;
using System.Diagnostics;
using System.Windows.Forms;


namespace monteKarlo_forms
{
    using static Convert;

    class MonteCarlo
    {
        private Figure mainFigure_;


        public MonteCarlo (Point[] pointsArray)
        {
            mainFigure_ = new Figure (pointsArray);
        }


        public void calculate(DataGridView table)
        {
            Stopwatch watch = new Stopwatch();

            var actualSquare = mainFigure_.calculateActualSquare();

            var number = new Random();
            int insideCounter;
            double randomX;
            double randomY;
            for (var i = 0; i < 5; i++)
            {
                watch.Start();
                double n = Math.Pow(10, i + 3);

                insideCounter = 0;
                for (var j = 0; j < n; j++)
                {
                    randomX = mainFigure_.minX_ + ToDouble(number.Next(0, 132767)) / 132767 * (mainFigure_.maxX_ - mainFigure_.minX_);
                    randomY = mainFigure_.minY_ + ToDouble(number.Next(0, 132767)) / 132767 * (mainFigure_.maxY_ - mainFigure_.minY_);
                    if (mainFigure_.isInside(new Point(randomX, randomY)))
                        insideCounter++;
                }

                var square = mainFigure_.square_ * insideCounter / n;
                watch.Stop();

                table.Rows.Add (n, insideCounter, actualSquare, square,
                    Math.Round (Math.Abs (square - actualSquare) / actualSquare * 100, 2), watch.ElapsedMilliseconds);

                watch.Reset();
            }
        }
    }
}
