namespace monteKarlo_forms
{
    class Figure
    {
        public Point aPoint { get; set; }
        public Point bPoint { get; set; }
        public Point cPoint { get; set; }
        public Point dPoint { get; set; }

        public double minY { get; set; }
        public double minX { get; set; }
        public double maxY { get; set; }
        public double maxX { get; set; }

        public double square { get; set; }

        private Line bcLine;
        private Line cdLine;
        private Line daLine;


        public Figure(Point[] pointsArray)
        {
            aPoint = pointsArray[3];
            bPoint = pointsArray[0];
            cPoint = pointsArray[1];
            dPoint = pointsArray[2];

            setMinsAndMaxs();

            calculateSquare();

            bcLine = new Line (bPoint, cPoint);
            cdLine = new Line (cPoint, dPoint);
            daLine = new Line (dPoint, aPoint);
        }


        private void setMinsAndMaxs()
        {
            minX = aPoint.X;
            maxX = dPoint.X;
            minY = aPoint.Y;
            maxY = cPoint.Y;
        }


        private void calculateSquare()
        {
            square = (maxX - minX) * (maxY - minY);
        }


        public bool isInside(double x, double y)
        {
            if ((bcLine.isInside(x, y) == true) &&
                (cdLine.isInside(x, y) == true) &&
                (daLine.isInside(x, y) == false))
                return true;
            else
                return false;
        }


        public double calculateActualSquare()
        {
            return square - ((maxY - bPoint.Y) * (cPoint.X - minX) * 0.5) - ((maxX - cPoint.X) * (maxY - dPoint.Y) * 0.5) - (
                (dPoint.Y - minY) * (maxX - minX) * 0.5);
        }
    }
}
