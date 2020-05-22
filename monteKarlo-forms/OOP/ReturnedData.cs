using System;
using System.Collections.Generic;


namespace monteKarlo_forms
{
    class ReturnedData
    {
        public TimeSpan time { get; set; }
        private List <double> calculatedSquares;// { get; set; }
        private List <double> accuracies;// { get; set; }
        public double actualSquare { get; set; }


        public ReturnedData()
        {
            calculatedSquares = new List <double>();
            accuracies = new List <double>();
        }


        public void addSquare (double newSquare)
        {
            calculatedSquares.Add (newSquare);
        }


        public void addAcc (double newAcc)
        {
            accuracies.Add (newAcc);
        }


        public List <double> CalculatedSquares => calculatedSquares;


        public List<double> Accuracies => accuracies;
    }
}
