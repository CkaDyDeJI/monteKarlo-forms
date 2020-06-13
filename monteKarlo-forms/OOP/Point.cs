namespace monteKarlo_forms
{
    class Point
    {
        private double x;   //точки поинта
        private double y;


        public double X
        {
            get => x;
            set => x = value;
        }


        public double Y
        {
            get => y;
            set => y = value;
        }

        public Point(double newX, double newY)
        {
            x = newX;
            y = newY;
        }
    }
}
