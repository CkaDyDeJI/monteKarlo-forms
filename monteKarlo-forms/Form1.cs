using System;
using System.Windows.Forms;


namespace monteKarlo_forms
{
    using static Convert;


    public partial class Form1 : Form
    {
        private readonly Point[] mainPoints = new Point[4];


        public Form1()
        {
            InitializeComponent();
        }


        private void calculateButton_Click (object sender, EventArgs e)
        {
            if (manualCheck.Checked == true) {
                if (setPoints() == false) return;
            }

            var main1 = new MonteCarlo (mainPoints);
            main1.calculate(objectDataGrid);
        }


        private bool setPoints()
        {
            string[] temp;

            try {
                temp = leftPoint.Text.Replace ('.', ',').Split (' ');

                mainPoints[0] = new Point (ToDouble (temp[0]), ToDouble (temp[1]));
            }
            catch {
                MessageBox.Show("B задана неверно\n\r");

                return false;
            }

            try {
                temp = upPoint.Text.Replace ('.', ',').Split (' ');

                mainPoints[1] = new Point (ToDouble (temp[0]), ToDouble (temp[1]));
            }
            catch {
                MessageBox.Show("C задана неверно\n\r");

                return false;
            }

            try {
                temp = rightPoint.Text.Replace ('.', ',').Split (' ');

                mainPoints[2] = new Point (ToDouble (temp[0]), ToDouble (temp[1]));
            }
            catch {
                MessageBox.Show("D задана неверно\n\r");

                return false;
            }

            try
            {
                temp = bottomText.Text.Replace('.', ',').Split(' ');

                mainPoints[3] = new Point(ToDouble(temp[0]), ToDouble(temp[1]));
            }
            catch
            {
                MessageBox.Show("A задана неверно\n\r");

                return false;
            }


            if (mainPoints[0].X >= mainPoints[1].X || mainPoints[0].X >= mainPoints[2].X)
            {
                MessageBox.Show("координата х точки B должна быть меньше, чем у C и D\n\r");

                return false;
            }

            if (mainPoints[2].X <= mainPoints[1].X)
            {
                MessageBox.Show("координата х точки C должна быть меньше чем у D\n\r");

                return false;
            }

            if (mainPoints[1].Y <= mainPoints[0].Y || mainPoints[1].Y <= mainPoints[2].Y) {
                MessageBox.Show("координата у точки C должна быть больше чем у B и D\n\r");

                return false;
            }

            if (mainPoints[3].X != mainPoints[0].X) {
                MessageBox.Show("координата x точек A и B должны совпадать\n\r");

                return false;
            }

            if (mainPoints[3].Y >= mainPoints[0].Y || mainPoints[3].Y >= mainPoints[2].Y) {
                MessageBox.Show("координата y точки A должна быть меньше чем у B и D\n\r");

                return false;
            }

            return true;
        }

        private void controlCheck_CheckedChanged(object sender, EventArgs e)
        {
            bottomText.Text = "5 1";
            leftPoint.Text = "5 18";
            upPoint.Text = "15 21";
            rightPoint.Text = "25 16";
            mainPoints[0] = new Point (5, 18);
            mainPoints[1] = new Point(15, 21);
            mainPoints[2] = new Point(25, 16);
            mainPoints[3] = new Point(5, 1);
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