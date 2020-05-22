using System;
using System.Collections.Generic;


namespace monteKarlo_forms
{
    class ReturnedData
    {
        public TimeSpan time { get; set; }
        private List <double> calculatedSquares;// { get; set; }
        private List <double> accuracies;// { get; set; }
        private List <double> numberOfPoints;
        private List <double> numberOfPointsInside;
        private List <TimeSpan> times;
        public double actualSquare { get; set; }

        


        public ReturnedData()
        {
            calculatedSquares = new List <double>();
            accuracies = new List <double>();
            numberOfPoints = new List <double>();
            numberOfPointsInside = new List <double>();
            times = new List <TimeSpan>();
        }


        public void addSquare (double newSquare)
        {
            calculatedSquares.Add (newSquare);
        }


        public void addAcc (double newAcc)
        {
            accuracies.Add (newAcc);
        }


        public void addPoints (double number)
        {
            numberOfPoints.Add (number);
        }


        public void addPointsInside (double number)
        {
            numberOfPointsInside.Add (number);
        }


        public void addTime (TimeSpan time)
        {
            times.Add (time);
        }


        public List <double> CalculatedSquares => calculatedSquares;


        public List<double> Accuracies => accuracies;


        public List <double> NumberOfPoints => numberOfPoints;


        public List<double> NumberOfPointsInside => numberOfPointsInside;


        public List <TimeSpan> Times => times;
    }
}
