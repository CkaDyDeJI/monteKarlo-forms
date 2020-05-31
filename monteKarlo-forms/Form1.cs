using System;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace monteKarlo_forms
{
    using static Convert;


    public partial class Form1 : Form
    {
        private readonly Point[] withPoints_ = new Point[3];


        public Form1()
        {
            InitializeComponent();
        }


        private async void calculateButton_Click (object sender, EventArgs e)
        {
            if (setPoints() == false) return;

            statusLabel.Text = "Calculating...";
            splitContainer1.Enabled = false;

            await Task.Delay (1);

            var main1 = new OOP (withPoints_);
            outputResult (main1.calculate());

            var main2 = new NonOOP();
            main2.doStuff (withPoints_, procedureDataGrid);

            splitContainer1.Enabled = true;
            statusLabel.Text = "Done";
        }


        private void outputResult (ReturnedData dataForOutput)
        {
            var squares = dataForOutput.CalculatedSquares;
            var accs = dataForOutput.Accuracies;
            var numbOfPoints = dataForOutput.NumberOfPoints;
            var numbOfPointsInside = dataForOutput.NumberOfPointsInside;
            var times = dataForOutput.Times;

            var currentRow = objectDataGrid.RowCount - 1;
            for (var i = 0; i < squares.Count; i++) {
                objectDataGrid.Rows.Add();
                objectDataGrid.Rows[currentRow].Cells[0].Value = numbOfPoints[i];
                objectDataGrid.Rows[currentRow].Cells[1].Value = numbOfPointsInside[i];
                objectDataGrid.Rows[currentRow].Cells[2].Value = dataForOutput.actualSquare;
                objectDataGrid.Rows[currentRow].Cells[3].Value = squares[i];
                objectDataGrid.Rows[currentRow].Cells[4].Value = accs[i];
                objectDataGrid.Rows[currentRow].Cells[5].Value = times[i];

                currentRow++;
            }
        }


        private bool setPoints()
        {
            bool isCorrect = true;
            string errorString = "";
            string[] temp;

            try {
                temp = leftPoint.Text.Replace ('.', ',').Split (' ');

                withPoints_[0] = new Point (ToDouble (temp[0]), ToDouble (temp[1]));
            }
            catch {
                errorString += "левая точка задана неверна";

                isCorrect = false;
            }

            try {
                temp = upPoint.Text.Replace ('.', ',').Split (' ');

                withPoints_[1] = new Point (ToDouble (temp[0]), ToDouble (temp[1]));
            }
            catch {
                errorString += "верхняя точка задана неверна";

                isCorrect = false;
            }

            try {
                temp = rightPoint.Text.Replace ('.', ',').Split (' ');

                withPoints_[2] = new Point (ToDouble (temp[0]), ToDouble (temp[1]));
            }
            catch {
                errorString += "правая точка задана неверна";

                isCorrect = false;
            }

            if (isCorrect != false) {
                if (withPoints_[0].X >= withPoints_[1].X || withPoints_[0].X >= withPoints_[2].X)
                {
                    errorString += "координата х точки b должна быть меньше, чем у c и d";

                    isCorrect = false;
                }

                if (withPoints_[2].X <= withPoints_[1].X)
                {
                    errorString += "координата х точки е должна быть меньше чем у d";

                    isCorrect = false;
                }

                if (withPoints_[1].Y <= withPoints_[0].Y || withPoints_[1].Y <= withPoints_[2].Y) {
                    errorString += "координата у точки е должна быть больше чем у b и d";

                    isCorrect = false;
                }
            }

            if (isCorrect == false)
                MessageBox.Show (errorString);

            return isCorrect;
        }
    }
}