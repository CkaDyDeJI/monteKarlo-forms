using System;
using System.Diagnostics;

namespace monteKarlo_forms
{
    using static Convert;

    class OOP
    {
        private Figure mainFigure_;
        //private InsertedFigure calculatedFigure_;


        public OOP (Point[] pointsArray)
        {
            mainFigure_ = new Figure (pointsArray[0], pointsArray[1], pointsArray[2]);

            //calculatedFigure_ = new InsertedFigure (mainFigure_);
        }


        public ReturnedData calculate()
        {
            ReturnedData data = new ReturnedData();

            Stopwatch watch = new Stopwatch();
            watch.Start();

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
                    randomX = mainFigure_.minX_ + ToDouble(number.Next(0, 132767)) / 132767 * (mainFigure_.maxX_ - mainFigure_.minX_); //minX_ * number.Next (ToInt32 ( minX_ ), ToInt32(maxX_));
                    randomY = mainFigure_.minY_ + ToDouble(number.Next(0, 132767)) / 132767 * (mainFigure_.maxY_ - mainFigure_.minY_); //number.Next (ToInt32 ( minY_ ), ToInt32(maxY_));
                    if (mainFigure_.isInside(new Point(randomX, randomY)))
                        insideCounter++;
                }

                var square = mainFigure_.square_ * insideCounter / n;
                watch.Stop();

                data.addSquare (square);
                data.addAcc (Math.Abs(square - actualSquare) / actualSquare);
                data.addPoints (n);
                data.addPointsInside (insideCounter);
                data.addTime (watch.Elapsed);

                watch.Reset();
            }

            return data;
        }
    }
}
