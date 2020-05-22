using System;
using System.Windows.Forms;


namespace monteKarlo_forms
{
    using static Convert;

    public partial class Form1 : Form
    {
        private Point[] withPoints_ = new Point[4];


        public Form1()
        {
            InitializeComponent();
        }


        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (setPoints() == false) {
                return;
            }

            OOP main1 = new OOP(withPoints_);
            outputResult(main1.calculate(), 0);

            NonOOP main2 = new NonOOP();
            outputResult (main2.doStuff(withPoints_), 1);
        }


        private void outputResult (ReturnedData dataForOutput, int textBoxNumber)
        {
            RichTextBox[] textBoxes = new RichTextBox[] {forOOP, forNonOOP};

            var squares = dataForOutput.CalculatedSquares;
            var accs = dataForOutput.Accuracies;
            for (int i = 0; i < squares.Count; i++) {
                textBoxes[textBoxNumber].Text += $"Площадь = {squares[i]}   Погрешность = {accs[i]}\n\r";
            }

            textBoxes[textBoxNumber].Text += $"Настоящая Площадь = {dataForOutput.actualSquare}\n\r\n\rВремя Затрачено: {dataForOutput.time}";
        }


        private bool setPoints()
        {
            string[] temp;

            try {
                temp = leftPoint.Text.Replace('.', ',').Split (new char[] {' '});

                withPoints_[0] = new Point(ToDouble (temp[0]), ToDouble(temp[1]));
            }
            catch {
                MessageBox.Show ("левая точка задана неверна");

                return false;
            }

            try {
                temp = upPoint.Text.Replace('.', ',').Split(new char[] { ' ' });

                withPoints_[1] = new Point(ToDouble(temp[0]), ToDouble(temp[1]));
            }
            catch {
                MessageBox.Show("верхняя точка задана неверна");

                return false;
            }

            try
            {
                temp = rightPoint.Text.Replace('.', ',').Split(new char[] { ' ' });

                withPoints_[2] = new Point(ToDouble(temp[0]), ToDouble(temp[1]));
            }
            catch
            {
                MessageBox.Show("правая точка задана неверна");

                return false;
            }

            try
            {
                temp = downPoint.Text.Replace('.', ',').Split(new char[] { ' ' });

                withPoints_[3] = new Point(ToDouble(temp[0]), ToDouble(temp[1]));
            }
            catch
            {
                MessageBox.Show("нижняя точка задана неверна");

                return false;
            }

            return true;
        }
    }
}
