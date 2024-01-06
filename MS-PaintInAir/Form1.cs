using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace MS_PaintInAir
{

    public partial class PaintInAir : Form
    {
        VideoCapture capture;
        Mat currentFrame;
        Mat game;
        Rectangle brush;
        Mat art;
        bool isDrawing = false;
        Rectangle lastBrush = Rectangle.Empty;
        int size = 10;
        MCvScalar color;
        bool isRectangle = false;
        bool isFindPoint = false;
        bool rectangleDone = false;
        Point currentRectanglePoint = Point.Empty;
        public PaintInAir()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            capture = new VideoCapture(0);
            currentFrame = capture.QueryFrame();
            CanvasWindow.Tag = currentFrame;
            game = currentFrame;
            art = new Bitmap(currentFrame.Size.Width,currentFrame.Size.Height).ToMat();
            color = new MCvScalar(0, 0, 255);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentFrame = capture.QueryFrame();
            CvInvoke.Flip(currentFrame, currentFrame, FlipType.Horizontal);
            trackBrush();
            draw();
            paint();
        }
        private void trackBrush()
        {
            brush = Rectangle.Empty;
            Mat image = currentFrame.Clone();
            Mat output = currentFrame.Clone();
            CvInvoke.GaussianBlur(image, image, new Size(7, 7), 0);
            CvInvoke.CvtColor(image, image, ColorConversion.Bgr2Hsv);
            CvInvoke.InRange(image, (ScalarArray) new MCvScalar(0, 150, 150), (ScalarArray) new MCvScalar(10, 255, 255), image);

            VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
            Mat hierarchy = new Mat();
            CvInvoke.FindContours(image, contours, hierarchy, RetrType.External, ChainApproxMethod.ChainApproxNone);

            int index = 0;
            double biggestContourArea = double.MinValue;
            for (int i = 0; i < contours.Size; i++)
            {
                double area = CvInvoke.ContourArea(contours[i]);
                if (biggestContourArea <= area)
                {
                    index = i;
                    biggestContourArea = area;
                }
            }

            if (contours.Size != 0 && biggestContourArea > 1000)
            {
               CvInvoke.DrawContours(output, contours, index, new MCvScalar(255, 0, 0), 5);
               brush = CvInvoke.BoundingRectangle(contours[index]);
            }

            game = output;
        }
        private void draw()
        {
            Point center = new Point(brush.X + brush.Width / 2, brush.Y + brush.Height / 2);
            if(!isRectangle)
            {
                if (!isDrawing)
                {
                    CvInvoke.Circle(game, center, size / 2, color, -1);
                }
                if (brush != Rectangle.Empty && isDrawing)
                {
                    if (lastBrush != Rectangle.Empty)
                    {
                        Point lastBrushCenter = new Point(lastBrush.X + lastBrush.Width / 2, lastBrush.Y + lastBrush.Height / 2);
                        CvInvoke.Line(art, center, lastBrushCenter, color, size);
                    }
                    lastBrush = brush;
                }
            }
            else
            {
                if(isFindPoint)
                {
                    if(currentRectanglePoint == Point.Empty)
                    {
                        currentRectanglePoint = center;
                    }
                    Rectangle rectangle = new Rectangle(center, new Size(currentRectanglePoint.X - center.X, currentRectanglePoint.Y - center.Y));

                    CvInvoke.Rectangle(game, rectangle, color, size);
                    
                    if (rectangleDone)
                    {
                        CvInvoke.Rectangle(art, rectangle, color, size);
                        
                        rectangleDone = false;
                        isFindPoint = false;
                        currentRectanglePoint = Point.Empty;
                    }

                }
            }
        }
        private void paint()
        {
            CvInvoke.CvtColor(art, art, ColorConversion.Bgr2Hsv);
            Mat range = new Mat();
            CvInvoke.InRange(art, (ScalarArray)new MCvScalar(0, 0, 0), (ScalarArray)new MCvScalar(255, 1, 1), range);
            CvInvoke.CvtColor(range, range, ColorConversion.Gray2Bgr);
            CvInvoke.CvtColor(art, art, ColorConversion.Hsv2Bgr);

            Mat cutoutchristmastre = new Mat();
            CvInvoke.BitwiseAnd(range, game, cutoutchristmastre);

            Mat notRange = new Mat();
            CvInvoke.BitwiseNot(range, notRange);


            Mat cutoutgreenscreen = new Mat();
            CvInvoke.BitwiseAnd(art, notRange, cutoutgreenscreen);

            Mat output = new Mat();
            CvInvoke.BitwiseXor(cutoutgreenscreen, cutoutchristmastre, output);

            CanvasWindow.Image = output.ToBitmap();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!isRectangle)
            {
                isDrawing = !isDrawing;
                if (!isDrawing)
                {
                    lastBrush = Rectangle.Empty;
                }
            }
            else 
            {
                if(isFindPoint)
                {
                    rectangleDone = true;
                }
                else
                {
                    isFindPoint = !isFindPoint;
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            size = BrushSizeTrackBar.Value;
            label1.Text = $"Brush Size: {size}";
            CanvasWindow.Focus();
        }
        private void changeColorButton(int b, int g, int r)
        {
            color = new MCvScalar(b, g, r);
            BTrackBar.Value = b;
            GTrackBar.Value = g;
            RTrackBar.Value = r;
            RLabel.Text = $"R: {RTrackBar.Value}";
            GLabel.Text = $"G: {GTrackBar.Value}";
            BLabel.Text = $"B: {BTrackBar.Value}";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            changeColorButton(0, 0, 255);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            changeColorButton(0, 128, 255);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            changeColorButton(0, 255, 255);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            changeColorButton(0, 255, 0);
        }

        private void LightBlueButton_Click(object sender, EventArgs e)
        {
            changeColorButton(255, 200, 0);
        }

        private void BlueButton_Click(object sender, EventArgs e)
        {
            changeColorButton(255, 50, 0);
        }

        private void PinkButton_Click(object sender, EventArgs e)
        {
            changeColorButton(255, 0, 255);
        }

        private void PurpleButton_Click(object sender, EventArgs e)
        {
            changeColorButton(255, 0, 127);
        }

        private void WhiteButton_Click(object sender, EventArgs e)
        {
            changeColorButton(255, 255, 255);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            GLabel.Text = $"G: {GTrackBar.Value}";
            color = new MCvScalar(BTrackBar.Value, GTrackBar.Value, RTrackBar.Value);
        }

        private void RTrackBar_Scroll(object sender, EventArgs e)
        {
            RLabel.Text = $"R: {RTrackBar.Value}";
            color = new MCvScalar(BTrackBar.Value, GTrackBar.Value, RTrackBar.Value);
        }

        private void BTrackBar_Scroll(object sender, EventArgs e)
        {
            BLabel.Text = $"B: {BTrackBar.Value}";
            color = new MCvScalar(BTrackBar.Value, GTrackBar.Value, RTrackBar.Value);
        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            Mat image = (CanvasWindow.Image as Bitmap).ToMat();
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.ShowDialog();
            string fileName = dialog.FileName + ".jpg";
            CvInvoke.Imwrite(fileName, image);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            color = new MCvScalar(0, 0, 0);
            BTrackBar.Value = 0;
            GTrackBar.Value = 0;
            RTrackBar.Value = 0;
            RLabel.Text = $"NA";
            GLabel.Text = $"NA";
            BLabel.Text = $"NA";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isRectangle = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            isRectangle = false;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            art = new Bitmap(currentFrame.Size.Width, currentFrame.Size.Height).ToMat();
        }
    }
}
