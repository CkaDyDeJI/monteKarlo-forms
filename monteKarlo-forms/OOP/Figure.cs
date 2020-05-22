namespace monteKarlo_forms
{
    class Figure
    {
        public Point leftPoint_ { get; set; }
        public Point upPoint_ { get; set; }
        public Point downPoint_ { get; set; }
        public Point rightPoint_ { get; set; }

        public double minY_ { get; set; }
        public double minX_ { get; set; }
        public double maxY_ { get; set; }
        public double maxX_ { get; set; }

        public double square_ { get; set; }


        public Figure(Point leftPoint, Point upPoint, Point rightPoint, Point downPoint)
        {
            leftPoint_ = leftPoint;
            upPoint_ = upPoint;
            rightPoint_ = rightPoint;
            downPoint_ = downPoint;

            setMinsAndMaxs();

            calculateSquare();
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
    }
}
