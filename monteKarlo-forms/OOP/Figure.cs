namespace monteKarlo_forms
{
    class Figure
    {
        public Point aPoint_ { get; set; }
        public Point bPoint_ { get; set; }
        public Point cPoint_ { get; set; }
        public Point dPoint_ { get; set; }

        public double minY_ { get; set; }
        public double minX_ { get; set; }
        public double maxY_ { get; set; }
        public double maxX_ { get; set; }

        public double square_ { get; set; }

        private LinearFunction bcLine_;
        private LinearFunction cdLine_;
        private LinearFunction daLine_;


        public Figure(Point[] pointsArray)
        {
            aPoint_ = pointsArray[0];
            bPoint_ = pointsArray[1];
            cPoint_ = pointsArray[2];
            dPoint_ = pointsArray[4];

            setMinsAndMaxs();

            calculateSquare();

            bcLine_ = new LinearFunction (bPoint_, cPoint_);
            cdLine_ = new LinearFunction (cPoint_, dPoint_);
            daLine_ = new LinearFunction (dPoint_, aPoint_);
        }


        private void setMinsAndMaxs()
        {
            minX_ = aPoint_.X;
            maxX_ = dPoint_.X;
            minY_ = aPoint_.Y;
            maxY_ = cPoint_.Y;
        }


        private void calculateSquare()
        {
            square_ = (maxX_ - minX_) * (maxY_ - minY_);
        }


        public bool isInside(Point newPoint)
        {
            if ((bcLine_.isInside(newPoint.X, newPoint.Y) == true) &&
                (cdLine_.isInside(newPoint.X, newPoint.Y) == true) &&
                (daLine_.isInside(newPoint.X, newPoint.Y) == false))
                return true;
            else
                return false;
        }


        public double calculateActualSquare()
        {
            return (square_ - ((maxY_ - leftPoint_.Y) * (upPoint_.X - minX_) * 0.5) - ((maxX_ - upPoint_.X) * (maxY_ - rightPoint_.Y) * 0.5) - (0.5 * ((leftPoint_.Y - minY_) + (rightPoint_.Y - minY_)) * (maxX_ - minX_)));
        }
    }
}
