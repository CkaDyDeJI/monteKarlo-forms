using System;
using System.Diagnostics;

namespace monteKarlo_forms
{
    using static Convert;

    class OOP : Figure
    {
        public OOP (Point[] pointsArray) : base(pointsArray)
        { }


        public ReturnedData calculate()
        {
            ReturnedData data = new ReturnedData();

            Stopwatch watch = new Stopwatch();

            var actualSquare = calculateActualSquare();
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
                    randomX = minX_ + ToDouble(number.Next(0, 132767)) / 132767 * (maxX_ - minX_);
                    randomY = minY_ + ToDouble(number.Next(0, 132767)) / 132767 * (maxY_ - minY_);
                    if (isInside(new Point(randomX, randomY)))
                        insideCounter++;
                }

                var square = square_ * insideCounter / n;
                watch.Stop();

                data.addToAll (n, insideCounter, actualSquare, square, Math.Round(Math.Abs(square - actualSquare) / actualSquare * 100, 2), watch.ElapsedMilliseconds);

                watch.Reset();
            }

            return data;
        }
    }
}
