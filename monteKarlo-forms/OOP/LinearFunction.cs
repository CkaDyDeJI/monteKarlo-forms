namespace monteKarlo_forms
{
    class LinearFunction
    {
        private double k_;
        private double b_;


        public LinearFunction(Point firstPoint, Point secondPoint)
        {
            k_ = (secondPoint.Y - firstPoint.Y) / (secondPoint.X - firstPoint.X);
            b_ = firstPoint.Y - k_ * firstPoint.X;
        }


        public bool isInside(double x, double y)
        {
            return (y < (k_ * x + b_)) ? true : false;
        }
    }
}
