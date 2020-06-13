using System;
using System.Diagnostics;

namespace monteKarlo_forms
{
    using static Convert;

    class OOP
    {
        private Figure mainFigure_;


        public OOP (Point[] pointsArray)
        {
            mainFigure_ = new Figure (pointsArray);
        }


        public ReturnedData calculate()
        {
            ReturnedData data = new ReturnedData();

            Stopwatch watch = new Stopwatch();

            var actualSquare = mainFigure_.calculateActualSquare();
            data.actualSquare = actualSquare;

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

                data.addSquare (square);
                data.addAcc (Math.Round(Math.Abs (square - actualSquare) / actualSquare * 100, 2));
                data.addPoints (n);
                data.addPointsInside (insideCounter);
                data.addTime (watch.ElapsedMilliseconds);

                watch.Reset();
            }

            return data;
        }
    }
}
