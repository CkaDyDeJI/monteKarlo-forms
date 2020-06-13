namespace monteKarlo_forms
{
    class Figure
    {
        public Point bPoint_ { get; set; }
        public Point cPoint_ { get; set; }
        public Point dPoint_ { get; set; }

        public double minY_ { get; set; }
        public double minX_ { get; set; }
        public double maxY_ { get; set; }
        public double maxX_ { get; set; }

        public double square_ { get; set; }

        private LinearFunction firstOne_;
        private LinearFunction secondOne_;
        private LinearFunction thirdOne_;


        public Figure(Point[] pointsArray)
        {
            bPoint_ = pointsArray[1];
            cPoint_ = pointsArray[2];
            dPoint_ = pointsArray[3];

            setMinsAndMaxs(pointsArray[0]);

            calculateSquare();

            firstOne_ = new LinearFunction (bPoint_, cPoint_);
            secondOne_ = new LinearFunction (cPoint_, dPoint_);
            thirdOne_ = new LinearFunction (bPoint_, dPoint_);
        }


        private void setMinsAndMaxs(Point bottomPoint)
        {
            minX_ = bPoint_.X;
            maxX_ = dPoint_.X;
            minY_ = bottomPoint.Y;
            maxY_ = cPoint_.Y;
        }


        private void calculateSquare()
        {
            square_ = (maxX_ - minX_) * (maxY_ - minY_);
        }


        public bool isInside(Point newPoint)
        {
            if ((firstOne_.isInside(newPoint.X, newPoint.Y) == true) &&
                (secondOne_.isInside(newPoint.X, newPoint.Y) == true) &&
                (thirdOne_.isInside(newPoint.X, newPoint.Y) == false))
                return true;
            else
                return false;
        }


        public double calculateActualSquare()
        {
            return (square_ - ((maxY_ - bPoint_.Y) * (cPoint_.X - minX_) * 0.5) - ((maxX_ - cPoint_.X) * (maxY_ - dPoint_.Y) * 0.5) - (0.5 * ((bPoint_.Y - minY_) + (dPoint_.Y - minY_)) * (maxX_ - minX_)));
        }
    }
}
