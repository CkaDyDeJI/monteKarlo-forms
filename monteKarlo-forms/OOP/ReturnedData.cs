using System;
using System.Collections.Generic;


namespace monteKarlo_forms
{
    class ReturnedData
    {
        private List <double> calculatedSquares;
        private List <double> accuracies;
        private List <double> numberOfPoints;
        private List <double> numberOfPointsInside;
        private List <long> times;
        public double actualSquare { get; set; }

        


        public ReturnedData()
        {
            calculatedSquares = new List <double>();
            accuracies = new List <double>();
            numberOfPoints = new List <double>();
            numberOfPointsInside = new List <double>();
            times = new List <long>();
        }


        public void addToAll (double n, double insideN, double actualSquare, double square, double accurs, long time)
        {
            calculatedSquares.Add (square);
            accuracies.Add (accurs);
            numberOfPoints.Add (n);
            numberOfPointsInside.Add (insideN);
            times.Add (time);
        }


        public Object[] returnAll(int i)
        {
            return new object[6] {numberOfPoints[i], numberOfPointsInside[i], actualSquare, calculatedSquares[i], accuracies[i], times[i]};
        }


        public int Count
        {
            get { return calculatedSquares.Count; }
        }
    }
}
