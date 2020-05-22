using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monteKarlo_forms
{
    class Drawing
    {
        private Graphics mainGraphics_;
        private Bitmap mainMap_;
        private Pen blackPen_ = new Pen (Color.Black, 1);
        private Pen redPen_ = new Pen(Color.Red, 3);


        public Drawing (int width, int height)
        {
            mainMap_ = new Bitmap (width, height);
            mainGraphics_ = Graphics.FromImage (mainMap_);
            mainGraphics_.TranslateTransform (0, height);

            drawBigRectangle();
            drawFigure();
        }


        private void drawBigRectangle()
        {
            mainGraphics_.DrawLine(blackPen_, 10, -10, 10, -160);
            mainGraphics_.DrawLine(blackPen_, 10, -160, 410, -160);
            mainGraphics_.DrawLine(blackPen_, 410, -160, 410, -10);
            mainGraphics_.DrawLine(blackPen_, 410, -10, 10, -10);
        }


        private void drawFigure()
        {
            mainGraphics_.DrawLine (redPen_, 10, -100, 260, -160);
            mainGraphics_.DrawArc (redPen_, 110, -160, 300, 300, 0, -90);
            mainGraphics_.DrawLine (redPen_, 410, -10, 260, -10);
            mainGraphics_.DrawLine (redPen_, 260, -10, 10, -100);
        }


        public Bitmap getBitmap()
        {
            return mainMap_;
        }
    }
}
