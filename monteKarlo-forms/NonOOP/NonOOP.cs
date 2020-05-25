using System;
using System.Diagnostics;

namespace monteKarlo_forms
{
    using static Convert;

    class NonOOP
    {
        private double k1_;
        private double b1_;

        private double k2_;
        private double b2_;

        private double k3_;
        private double b3_;

        private int functionsIsCalculated = 0;

        private Point leftPoint_;
        private Point upPoint_;
        private Point rightPoint_;

        private double minY_;
        private double minX_;
        private double maxY_;
        private double maxX_;

        private double square_;

        public ReturnedData doStuff(Point[] withPoints)
        {
            setStuff(withPoints[0], withPoints[1], withPoints[2]);

            ReturnedData data = new ReturnedData();

            Stopwatch watch = new Stopwatch();
            watch.Start();

            var actuallySquare = calculateActualSquare();
            data.actualSquare = actuallySquare;

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
                    randomX = minX_ + ToDouble(number.Next(0, 132767)) / 132767 * (maxX_ - minX_); //minX_ * number.Next (ToInt32 ( minX_ ), ToInt32(maxX_));
                    randomY = minY_ + ToDouble(number.Next(0, 132767)) / 132767 * (maxY_ - minY_); //number.Next (ToInt32 ( minY_ ), ToInt32(maxY_));
                    if (isInside(new Point(randomX, randomY)))
                        insideCounter++;
                }

                var square = square_ * insideCounter / n;

                watch.Stop();
                
                data.addSquare(square);
                data.addAcc(Math.Abs(square - actuallySquare) / actuallySquare);
                data.addPoints (n);
                data.addPointsInside (insideCounter);
                data.addTime (watch.Elapsed);

                watch.Reset();
            }

            return data;
        }


        private void setStuff(Point leftPoint, Point upPoint, Point rightPoint)
        {
            leftPoint_ = leftPoint;
            upPoint_ = upPoint;
            rightPoint_ = rightPoint;

            setMinsAndMaxs();

            calculateSquare();

            calculateLinearCoeffsFirst(leftPoint_, upPoint_);
            calculateLinearCoeffsSecond(upPoint_, rightPoint_);
            calculateLinearCoeffsThird(leftPoint_, rightPoint_);
        }


        private void setMinsAndMaxs()
        {
            minX_ = leftPoint_.X;
            minY_ = 0;
            maxX_ = rightPoint_.X;
            maxY_ = upPoint_.Y;
        }


        private void calculateSquare()
        {
            square_ = (maxX_ - minX_) * (maxY_ - minY_);
        }


        public bool isInside(Point newPoint)
        {
            if (functionsIsCalculated != 3)
            {
                Console.WriteLine("stuff is not set!");

                return false;
            }

            if ((isLowerlinearFunctionFirst(newPoint.X, newPoint.Y) == true) &&
                (isLowerlinearFunctionSecond(newPoint.X, newPoint.Y) == true) &&
                (isUpperlinearFunction(newPoint.X, newPoint.Y) == true))
                return true;
            else
                return false;
        }


        private void calculateLinearCoeffsFirst(Point firstPoint, Point secondPoint)
        {
            k1_ = (secondPoint.Y - firstPoint.Y) / (secondPoint.X - firstPoint.X);
            b1_ = firstPoint.Y - k1_ * firstPoint.X;

            functionsIsCalculated++;
        }


        private void calculateLinearCoeffsSecond(Point firstPoint, Point secondPoint)
        {
            k2_ = (secondPoint.Y - firstPoint.Y) / (secondPoint.X - firstPoint.X);
            b2_ = firstPoint.Y - k2_ * firstPoint.X;

            functionsIsCalculated++;
        }


        private void calculateLinearCoeffsThird(Point firstPoint, Point secondPoint)
        {
            k3_ = (secondPoint.Y - firstPoint.Y) / (secondPoint.X - firstPoint.X);
            b3_ = firstPoint.Y - k3_ * firstPoint.X;

            functionsIsCalculated++;
        }


        private bool isLowerlinearFunctionFirst(double x, double y)
        {
            return (y < (k1_ * x + b1_)) ? true : false;
        }


        private bool isLowerlinearFunctionSecond(double x, double y)
        {
            return (y < (k2_ * x + b2_)) ? true : false;
        }


        private bool isUpperlinearFunction(double x, double y)
        {
            return (y > (k3_ * x + b3_)) ? true : false;
        }


        private double calculateActualSquare()
        {
            return (square_ - ((maxY_ - leftPoint_.Y) * (upPoint_.X - minX_) * 0.5) - ((maxX_ - upPoint_.X) * (maxY_ - rightPoint_.Y) * 0.5) - (0.5 * ((leftPoint_.Y - minY_) + (rightPoint_.Y - minY_)) * (maxX_ - minX_)));

            //return ((centerCircle_.X - leftDown.X) * centerCircle_.Radius / 2) +
            //       (Math.PI * centerCircle_.Radius * centerCircle_.Radius / 4);
        }

    }
}
