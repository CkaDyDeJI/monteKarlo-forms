namespace monteKarlo_forms
{
    class Line  //класс описывает линейную функцию y = kx + b
    {
        private double k;   //коэффициент k линейного уравнения 
        private double b;   //b


        public Line(Point firstPoint, Point secondPoint)    //вычисление этих коэфф
        {
            k = (secondPoint.Y - firstPoint.Y) / (secondPoint.X - firstPoint.X);
            b = firstPoint.Y - k * firstPoint.X;
        }


        public bool isInside(double x, double y)    //проверка того, находится ли точка над или под графиком лин функции
        {
            return (y < (k * x + b)) ? true : false;
        }
    }
}
