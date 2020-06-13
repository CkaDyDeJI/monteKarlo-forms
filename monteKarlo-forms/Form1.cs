using System;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace monteKarlo_forms
{
    using static Convert;


    public partial class Form1 : Form
    {
        private readonly Point[] withPoints_ = new Point[4];


        public Form1()
        {
            InitializeComponent();
        }


        private async void calculateButton_Click (object sender, EventArgs e)
        {
            if (manualCheck.Checked == true) {
                if (setPoints() == false) return;
            }

            statusLabel.Text = "Calculating...";
            splitContainer1.Enabled = false;

            await Task.Delay (1);

            var main1 = new OOP (withPoints_);
            outputResult (main1.calculate());

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
                errorString += "Левая точка (b) задана неверно\n\r";

                isCorrect = false;
            }

            try {
                temp = upPoint.Text.Replace ('.', ',').Split (' ');

                withPoints_[1] = new Point (ToDouble (temp[0]), ToDouble (temp[1]));
            }
            catch {
                errorString += "Верхняя точка (c) задана неверно\n\r";

                isCorrect = false;
            }

            try {
                temp = rightPoint.Text.Replace ('.', ',').Split (' ');

                withPoints_[2] = new Point (ToDouble (temp[0]), ToDouble (temp[1]));
            }
            catch {
                errorString += "Правая точка (d) задана неверно\n\r";

                isCorrect = false;
            }

            try
            {
                temp = rightPoint.Text.Replace('.', ',').Split(' ');

                withPoints_[3] = new Point(ToDouble(temp[0]), ToDouble(temp[1]));
            }
            catch
            {
                errorString += "Нижняя точка точка (a) задана неверно\n\r";

                isCorrect = false;
            }

            if (isCorrect != false) {
                if (withPoints_[0].X >= withPoints_[1].X || withPoints_[0].X >= withPoints_[2].X)
                {
                    errorString += "координата х точки b должна быть меньше, чем у c и d\n\r";

                    isCorrect = false;
                }

                if (withPoints_[2].X <= withPoints_[1].X)
                {
                    errorString += "координата х точки е должна быть меньше чем у d\n\r";

                    isCorrect = false;
                }

                if (withPoints_[1].Y <= withPoints_[0].Y || withPoints_[1].Y <= withPoints_[2].Y) {
                    errorString += "координата у точки е должна быть больше чем у b и d\n\r";

                    isCorrect = false;
                }

                if (withPoints_[3].X != withPoints_[0].X) {
                    errorString += "координата x точек A и B должны совпадать\n\r";

                    isCorrect = false;
                }

                if (withPoints_[3].Y >= withPoints_[0].Y || withPoints_[3].Y >= withPoints_[2].Y) {
                    errorString += "координата y точки A должна быть меньше чем у B и D\n\r";

                    isCorrect = false;
                }
            }

            if (isCorrect == false)
                MessageBox.Show (errorString);

            return isCorrect;
        }

        private void controlCheck_CheckedChanged(object sender, EventArgs e)
        {
            bottomText.Text = "3 0";
            leftPoint.Text = "3 17";
            upPoint.Text = "13 20";
            rightPoint.Text = "23 15";
            withPoints_[0] = new Point (3, 17);
            withPoints_[1] = new Point(13, 20);
            withPoints_[2] = new Point(23, 15);
            withPoints_[3] = new Point(3, 0);
        }

        private void manualCheck_CheckedChanged(object sender, EventArgs e)
        {
            bottomText.Text = "";
            leftPoint.Text = "";
            upPoint.Text = "";
            rightPoint.Text = "";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            bottomText.Text = "";
            leftPoint.Text = "";
            upPoint.Text = "";
            rightPoint.Text = "";
            objectDataGrid.Rows.Clear();
        }
    }
}