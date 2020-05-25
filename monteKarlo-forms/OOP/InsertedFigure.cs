using System;

namespace monteKarlo_forms
{
    class InsertedFigure
    {
        private Figure wholeFigure_;

        private double k1_;
        private double b1_;

        private double k2_;
        private double b2_;

        private double k3_;
        private double b3_;

        private int functionsIsCalculated = 0;


        public InsertedFigure (Figure newFigure)
        {
            wholeFigure_ = newFigure;

            calculateLinearCoeffsFirst (wholeFigure_.leftPoint_, wholeFigure_.upPoint_);
            calculateLinearCoeffsSecond (wholeFigure_.upPoint_, wholeFigure_.rightPoint_);
            calculateLinearCoeffsThird(wholeFigure_.leftPoint_, wholeFigure_.rightPoint_); 
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


        public double calculateActualSquare()
        {
            return (wholeFigure_.square_ - ((wholeFigure_.maxY_ - wholeFigure_.leftPoint_.Y) * (wholeFigure_.upPoint_.X - wholeFigure_.minX_) * 0.5) - ((wholeFigure_.maxX_ - wholeFigure_.upPoint_.X) * (wholeFigure_.maxY_ - wholeFigure_.rightPoint_.Y) * 0.5) - (0.5 * ((wholeFigure_.leftPoint_.Y - wholeFigure_.minY_) + (wholeFigure_.rightPoint_.Y - wholeFigure_.minY_)) * (wholeFigure_.maxX_ - wholeFigure_.minX_)));

            //return (centerCircle_.X - wholeFigure_.leftPoint_.X) * (wholeFigure_.upPoint_.Y - wholeFigure_.downPoint_.Y) - ((wholeFigure_.upPoint_.Y - wholeFigure_.leftPoint_.Y) * (wholeFigure_.upPoint_.X - wholeFigure_.leftPoint_.X) * 0.5) - ((wholeFigure_.downPoint_.X - wholeFigure_.leftPoint_.X) * (wholeFigure_.leftPoint_.Y - wholeFigure_.downPoint_.Y) * 0.5) + (Math.PI * centerCircle_.Radius * centerCircle_.Radius / 4);

            //return ((centerCircle_.X - leftDown.X) * centerCircle_.Radius / 2) +
            //       (Math.PI * centerCircle_.Radius * centerCircle_.Radius / 4);
        }
    }
}
