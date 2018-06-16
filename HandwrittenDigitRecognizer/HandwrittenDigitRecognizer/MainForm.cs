using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using MatrixLib;
using ConvNeuralNetwork;

namespace HandwrittenDigitRecognizer
{
    public partial class MainForm : Form
    {
        #region Variables

        Bitmap bmp;
        Point lastPoint;

        #endregion

        #region CTOR

        public MainForm()
        {
            InitializeComponent();

            ResetPanel();
        }

        #endregion

        #region Component Events

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, Point.Empty);
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    Pen pen = new Pen(Color.Black, 17f);
                    pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                    g.DrawLine(pen, lastPoint, e.Location);
                }
                lastPoint = e.Location;
                panel1.Invalidate();
            }
        }

        private void Button_Reset_Click(object sender, System.EventArgs e)
        {
            ResetPanel();
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Predict();
        }

        #endregion

        #region Methods

        private void ResetPanel()
        {
            bmp = new Bitmap(panel1.ClientSize.Width, panel1.ClientSize.Height,
                   PixelFormat.Format24bppRgb);

            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                    bmp.SetPixel(i, j, Color.White);

            panel1.Invalidate();
            lblGuess.Text = "";
        }

        Matrix[] input = new Matrix[1];

        private void Predict()
        {
            string filePath = @"..\..\CNN\Configs\95,11__9__AFDAB.json";

            Bitmap resized = new Bitmap(bmp, new Size(28, 28));
            
            input[0] = new Matrix(resized.Width, resized.Height);
            byte[][] bytes = new byte[28][];

            for (int i = 0; i < input[0].rows; i++)
            {
                bytes[i] = new byte[28];
                for(int j = 0; j < input[0].cols; j++)
                {
                    Color c = resized.GetPixel(j, i);
                    
                    input[0][i, j] = 255f - (c.R + c.G + c.B) / 3f;
                    bytes[i][j] = (byte) (255 - (c.R + c.G + c.B) / 3);
                }
            }

            //DigitImage di = new DigitImage(bytes, 1);

            
            Console.WriteLine(input[0].ToString());

            CNN cnn = new CNN(filePath);
            Matrix output = cnn.Predict(input);

            int maxIndex = output.GetMaxRowIndex();
            string guessText;

            guessText = string.Format("This is %{0:f2} a {1}", output[maxIndex, 0]*100, maxIndex);
            lblGuess.Text = guessText;

            lstOutput.Items.Clear();
            for (int i = 0; i < output.rows; i++)
            {
                lstOutput.Items.Add(output[i, 0].ToString("F3"));
            }
        }

        #endregion

        int idx = 0;

        private void Button_Next_Click(object sender, EventArgs e)
        {
            DigitImage[] digitImages = MNIST_Parser.ReadFromFile(DataSet.Training, 10000);
            input[0] = new Matrix(digitImages[idx++].pixels);

            Bitmap b = new Bitmap(28, 28);
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    b.SetPixel(i, j, Color.FromArgb((byte)(255 - input[0][j, i]), (byte)(255 -input[0][j, i]), (byte)(255 -input[0][j, i])));
                }
            }

            bmp = new Bitmap(b, new Size(bmp.Width, bmp.Height));
            panel1.Invalidate();

            Predict();
        }
    }
}
