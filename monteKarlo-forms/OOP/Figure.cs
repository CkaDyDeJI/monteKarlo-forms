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


        public Figure(Point leftPoint, Point upPoint, Point rightPoint)
        {
            leftPoint_ = leftPoint;
            upPoint_ = upPoint;
            rightPoint_ = rightPoint;

            setMinsAndMaxs();

            calculateSquare();
        }


        private void setMinsAndMaxs()
        {
            minX_ = leftPoint_.X;
            maxX_ = rightPoint_.X;
            minY_ = 0;
            maxY_ = upPoint_.Y;
        }


        private void calculateSquare()
        {
            square_ = (maxX_ - minX_) * (maxY_ - minY_);
        }
    }
}
