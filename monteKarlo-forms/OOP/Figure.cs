namespace monteKarlo_forms
{
    class Figure
    {
        public Point aPoint { get; set; }   //наши введенные точки вписанной фигуры
        public Point bPoint { get; set; }
        public Point cPoint { get; set; }
        public Point dPoint { get; set; }

        public double minY { get; set; }    //минимальные и макс значния прямоугольника, в который вписана наша фигура
        public double minX { get; set; }
        public double maxY { get; set; }
        public double maxX { get; set; }

        public double square { get; set; }  //площадь прямоугольника

        private Line bcLine;    //линейный функции, описывающие нашу фигуру 
        private Line cdLine;
        private Line daLine;


        public Figure(Point[] pointsArray)  //задаются всякие штуки
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


        private void setMinsAndMaxs()   //вычисляются угловые координаты
        {
            minX = aPoint.X;
            maxX = dPoint.X;
            minY = aPoint.Y;
            maxY = cPoint.Y;
        }


        private void calculateSquare()
        {
            square = (maxX - minX) * (maxY - minY); //вычисляется площадь прямоугольника
        }


        public bool isInside(double x, double y)    //првоерка внутри ли находится точка. внутри, если под отрезками bc и cd, но над отрезком ad
        {
            if ((bcLine.isInside(x, y) == true) &&
                (cdLine.isInside(x, y) == true) &&
                (daLine.isInside(x, y) == false))
                return true;
            else
                return false;
        }


        public double calculateActualSquare()   //вычисление точной площади фигуры abcd математическим способом
        {
            return square - ((maxY - bPoint.Y) * (cPoint.X - minX) * 0.5) - ((maxX - cPoint.X) * (maxY - dPoint.Y) * 0.5) - (
                (dPoint.Y - minY) * (maxX - minX) * 0.5);
        }
    }
}
