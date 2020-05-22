using System;
using System.Diagnostics;

namespace monteKarlo_forms
{
    using static Convert;

    class NonOOP
    {
        private double radius_;
        private double circleX_;
        private double circleY_;

        private double k1_;
        private double b1_;

        private double k2_;
        private double b2_;

        private int functionsIsCalculated = 0;

        private Point leftPoint_;
        private Point upPoint_;
        private Point downPoint_;
        private Point rightPoint_;

        private double minY_;
        private double minX_;
        private double maxY_;
        private double maxX_;

        public double square_;

        public ReturnedData doStuff(Point[] withPoints)
        {
            setStuff(withPoints[0], withPoints[1], withPoints[2], withPoints[3]);

            ReturnedData data = new ReturnedData();

            Stopwatch watch = new Stopwatch();
            watch.Start();

            var actuallySquare = calculateActualSquare(leftPoint_, upPoint_, downPoint_);
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


        private void setStuff(Point leftPoint, Point upPoint, Point rightPoint, Point downPoint)
        {
            leftPoint_ = leftPoint;
            upPoint_ = upPoint;
            rightPoint_ = rightPoint;
            downPoint_ = downPoint;

            setMinsAndMaxs();

            calculateSquare();

            calculateCircleCenter(rightPoint_, upPoint_);
            calculateLinearCoeffsFirst(leftPoint_, upPoint_);
            calculateLinearCoeffsSecond(leftPoint_, downPoint_);
        }


        private void setMinsAndMaxs()
        {
            minX_ = leftPoint_.X;
            minY_ = downPoint_.Y;
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

            if (newPoint.X < circleX_)
            {
                if ((isLowerlinearFunction(newPoint.X, newPoint.Y) == true) &&
                    (isUpperlinearFunction(newPoint.X, newPoint.Y) == true))
                    return true;
                else
                    return false;
            }
            else
                return isInsideCircle(newPoint.X, newPoint.Y);
        }


        public void calculateLinearCoeffsFirst(Point firstPoint, Point secondPoint)
        {
            k1_ = (secondPoint.Y - firstPoint.Y) / (secondPoint.X - firstPoint.X);
            b1_ = firstPoint.Y - k1_ * firstPoint.X;

            functionsIsCalculated++;
        }


        public void calculateLinearCoeffsSecond(Point firstPoint, Point secondPoint)
        {
            k2_ = (secondPoint.Y - firstPoint.Y) / (secondPoint.X - firstPoint.X);
            b2_ = firstPoint.Y - k2_ * firstPoint.X;

            functionsIsCalculated++;
        }


        private bool isLowerlinearFunction(double x, double y)
        {
            return (y < (k1_ * x + b1_)) ? true : false;
        }


        private bool isUpperlinearFunction(double x, double y)
        {
            return (y > (k2_ * x + b2_)) ? true : false;
        }


        public void calculateCircleCenter(Point cPoint, Point dPoint)
        {
            circleX_ = dPoint.X;
            circleY_ = cPoint.Y; 
            radius_ = cPoint.X - dPoint.X;

            functionsIsCalculated++;
        }


        private bool isInsideCircle(double x, double y)
        {
            return ((Math.Sqrt((x - circleX_) * (x - circleX_) + y * y)) <= radius_) ? true : false;
        }


        public double calculateActualSquare(Point left, Point up, Point down)
        {
            return (circleX_ - left.X) * (up.Y - down.Y) - ((up.Y - left.Y) * (up.X - left.X) * 0.5) -
                ((down.X - left.X) * (left.Y - down.Y) * 0.5) + (Math.PI * radius_ * radius_ / 4);

            //return ((centerCircle_.X - leftDown.X) * centerCircle_.Radius / 2) +
            //       (Math.PI * centerCircle_.Radius * centerCircle_.Radius / 4);
        }

    }
}
