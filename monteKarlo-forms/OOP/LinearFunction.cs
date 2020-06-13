namespace monteKarlo_forms
{
    class Line
    {
        private double k;
        private double b;


        public Line(Point firstPoint, Point secondPoint)
        {
            k = (secondPoint.Y - firstPoint.Y) / (secondPoint.X - firstPoint.X);
            b = firstPoint.Y - k * firstPoint.X;
        }


        public bool isInside(double x, double y)
        {
            return (y < (k * x + b)) ? true : false;
        }
    }
}
