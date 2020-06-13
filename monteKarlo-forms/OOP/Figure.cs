namespace monteKarlo_forms
{
    class Figure
    {
        public Point leftPoint_ { get; set; }
        public Point upPoint_ { get; set; }
        public Point rightPoint_ { get; set; }

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
            leftPoint_ = pointsArray[0];
            upPoint_ = pointsArray[1];
            rightPoint_ = pointsArray[2];

            setMinsAndMaxs(pointsArray[3]);

            calculateSquare();

            firstOne_ = new LinearFunction (leftPoint_, upPoint_);
            secondOne_ = new LinearFunction (upPoint_, rightPoint_);
            thirdOne_ = new LinearFunction (leftPoint_, rightPoint_);
        }


        private void setMinsAndMaxs(Point bottomPoint)
        {
            minX_ = leftPoint_.X;
            maxX_ = rightPoint_.X;
            minY_ = bottomPoint.Y;
            maxY_ = upPoint_.Y;
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
            return (square_ - ((maxY_ - leftPoint_.Y) * (upPoint_.X - minX_) * 0.5) - ((maxX_ - upPoint_.X) * (maxY_ - rightPoint_.Y) * 0.5) - (0.5 * ((leftPoint_.Y - minY_) + (rightPoint_.Y - minY_)) * (maxX_ - minX_)));
        }
    }
}
