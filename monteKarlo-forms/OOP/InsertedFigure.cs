using System;

namespace monteKarlo_forms
{
    class InsertedFigure
    {
        private Figure wholeFigure_;

        private Circle centerCircle_;

        private double k1_;
        private double b1_;

        private double k2_;
        private double b2_;

        private  int functionsIsCalculated = 0;


        public InsertedFigure (Figure newFigure)
        {
            wholeFigure_ = newFigure;

            calculateLinearCoeffsFirst (wholeFigure_.leftPoint_, wholeFigure_.upPoint_);
            calculateLinearCoeffsSecond (wholeFigure_.leftPoint_, wholeFigure_.downPoint_);
            calculateCircleCenter (wholeFigure_.rightPoint_, wholeFigure_.upPoint_);
        }


        public bool isInside(Point newPoint)
        {
            if (functionsIsCalculated != 3)
            {
                Console.WriteLine("stuff is not set!");

                return false;
            }

            if (newPoint.X < centerCircle_.X)
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


        private bool isLowerlinearFunction(double x, double y)
        {
            return (y < (k1_ * x + b1_)) ? true : false;
        }


        private bool isUpperlinearFunction(double x, double y)
        {
            return (y > (k2_ * x + b2_)) ? true : false;
        }


        private void calculateCircleCenter(Point cPoint, Point dPoint)
        {
            centerCircle_ = new Circle(new Point(dPoint.X, cPoint.Y), cPoint.X - dPoint.X);

            functionsIsCalculated++;
        }


        private bool isInsideCircle(double x, double y)
        {
            return ((Math.Sqrt((x - centerCircle_.X) * (x - centerCircle_.X) + y * y)) <= centerCircle_.Radius) ? true : false;
        }


        public double calculateActualSquare()
        {
            return (centerCircle_.X - wholeFigure_.leftPoint_.X) * (wholeFigure_.upPoint_.Y - wholeFigure_.downPoint_.Y) - ((wholeFigure_.upPoint_.Y - wholeFigure_.leftPoint_.Y) * (wholeFigure_.upPoint_.X - wholeFigure_.leftPoint_.X) * 0.5) -
                ((wholeFigure_.downPoint_.X - wholeFigure_.leftPoint_.X) * (wholeFigure_.leftPoint_.Y - wholeFigure_.downPoint_.Y) * 0.5) + (Math.PI * centerCircle_.Radius * centerCircle_.Radius / 4);

            //return ((centerCircle_.X - leftDown.X) * centerCircle_.Radius / 2) +
            //       (Math.PI * centerCircle_.Radius * centerCircle_.Radius / 4);
        }
    }
}
