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
            drawFigure();
        }


        private async void calculateButton_Click (object sender, EventArgs e)
        {
            if (setPoints() == false) return;

            statusLabel.Text = "Calculating...";
            splitContainer1.Enabled = false;

            await Task.Delay (1);

            var main1 = new OOP (withPoints_);
            outputResult (main1.calculate(), 0);

            var main2 = new NonOOP();
            outputResult (main2.doStuff (withPoints_), 1);

            splitContainer1.Enabled = true;
            statusLabel.Text = "Done";
        }


        private void outputResult (ReturnedData dataForOutput, int textBoxNumber)
        {
            DataGridView currentDataGrid;
            if (textBoxNumber == 0)
                currentDataGrid = objectDataGrid;
            else
                currentDataGrid = procedureDataGrid;


            var squares = dataForOutput.CalculatedSquares;
            var accs = dataForOutput.Accuracies;
            var numbOfPoints = dataForOutput.NumberOfPoints;
            var numbOfPointsInside = dataForOutput.NumberOfPointsInside;
            var times = dataForOutput.Times;

            var currentRow = currentDataGrid.RowCount - 1;
            for (var i = 0; i < squares.Count; i++) {
                currentDataGrid.Rows.Add();
                currentDataGrid.Rows[currentRow].Cells[0].Value = numbOfPoints[i];
                currentDataGrid.Rows[currentRow].Cells[1].Value = numbOfPointsInside[i];
                currentDataGrid.Rows[currentRow].Cells[2].Value = dataForOutput.actualSquare;
                currentDataGrid.Rows[currentRow].Cells[3].Value = squares[i];
                currentDataGrid.Rows[currentRow].Cells[4].Value = accs[i];
                currentDataGrid.Rows[currentRow].Cells[5].Value = times[i];

                currentRow++;
            }

            currentDataGrid.Rows.Add();
        }


        private void drawFigure()
        {
            var drawing = new Drawing (figurePicture.Width, figurePicture.Height);

            figurePicture.Image = drawing.getBitmap();
        }


        private bool setPoints()
        {
            string[] temp;

            try {
                temp = leftPoint.Text.Replace ('.', ',').Split (' ');

                withPoints_[0] = new Point (ToDouble (temp[0]), ToDouble (temp[1]));
            }
            catch {
                MessageBox.Show ("левая точка задана неверна");

                return false;
            }

            try {
                temp = upPoint.Text.Replace ('.', ',').Split (' ');

                withPoints_[1] = new Point (ToDouble (temp[0]), ToDouble (temp[1]));
            }
            catch {
                MessageBox.Show ("верхняя точка задана неверна");

                return false;
            }

            try {
                temp = rightPoint.Text.Replace ('.', ',').Split (' ');

                withPoints_[2] = new Point (ToDouble (temp[0]), ToDouble (temp[1]));
            }
            catch {
                MessageBox.Show ("правая точка задана неверна");

                return false;
            }

            return true;
        }
    }
}