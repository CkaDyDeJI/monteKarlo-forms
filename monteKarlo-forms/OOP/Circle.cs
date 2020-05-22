namespace monteKarlo_forms
{
    class Circle : Point
    {
        public double Radius { get; set; }


        public Circle(Point newCenter, double newRadius) : base(newCenter.X, newCenter.Y)
        {
            Radius = newRadius;
        }
    }
}
