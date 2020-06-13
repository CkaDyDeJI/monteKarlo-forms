namespace monteKarlo_forms
{
    class Point
    {
        private double x_;
        private double y_;


        public double X
        {
            get => x_;
            set => x_ = value;
        }


        public double Y
        {
            get => y_;
            set => y_ = value;
        }

        public Point(double newX, double newY)
        {
            x_ = newX;
            y_ = newY;
        }
    }
}
