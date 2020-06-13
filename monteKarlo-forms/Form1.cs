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

            var main1 = new MonteCarlo (withPoints_);
            main1.calculate(objectDataGrid);
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
                errorString += "B задана неверно\n\r";

                isCorrect = false;
            }

            try {
                temp = upPoint.Text.Replace ('.', ',').Split (' ');

                withPoints_[1] = new Point (ToDouble (temp[0]), ToDouble (temp[1]));
            }
            catch {
                errorString += "C задана неверно\n\r";

                isCorrect = false;
            }

            try {
                temp = rightPoint.Text.Replace ('.', ',').Split (' ');

                withPoints_[2] = new Point (ToDouble (temp[0]), ToDouble (temp[1]));
            }
            catch {
                errorString += "D задана неверно\n\r";

                isCorrect = false;
            }

            try
            {
                temp = rightPoint.Text.Replace('.', ',').Split(' ');

                withPoints_[3] = new Point(ToDouble(temp[0]), ToDouble(temp[1]));
            }
            catch
            {
                errorString += "A задана неверно\n\r";

                isCorrect = false;
            }

            if (isCorrect != false) {
                if (withPoints_[0].X >= withPoints_[1].X || withPoints_[0].X >= withPoints_[2].X)
                {
                    errorString += "координата х точки B должна быть меньше, чем у C и D\n\r";

                    isCorrect = false;
                }

                if (withPoints_[2].X <= withPoints_[1].X)
                {
                    errorString += "координата х точки C должна быть меньше чем у D\n\r";

                    isCorrect = false;
                }

                if (withPoints_[1].Y <= withPoints_[0].Y || withPoints_[1].Y <= withPoints_[2].Y) {
                    errorString += "координата у точки C должна быть больше чем у B и D\n\r";

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