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
            aPoint_ = pointsArray[3];
            bPoint_ = pointsArray[0];
            cPoint_ = pointsArray[1];
            dPoint_ = pointsArray[2];

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


        public bool isInside(double x, double y)
        {
            if ((bcLine_.isInside(x, y) == true) &&
                (cdLine_.isInside(x, y) == true) &&
                (daLine_.isInside(x, y) == false))
                return true;
            else
                return false;
        }


        public double calculateActualSquare()
        {
            return square_ - ((maxY_ - bPoint_.Y) * (cPoint_.X - minX_) * 0.5) - ((maxX_ - cPoint_.X) * (maxY_ - dPoint_.Y) * 0.5) - (
                (dPoint_.Y - minY_) * (maxX_ - minX_) * 0.5);
        }
    }
}
