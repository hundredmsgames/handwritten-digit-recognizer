using System.Drawing;
using System.Windows.Forms;

namespace HandwrittenDigitRecognizer
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Point lastPoint;

        public Form1()
        {
            InitializeComponent();

            bmp = new Bitmap(panel1.ClientSize.Width, panel1.ClientSize.Height,
                   System.Drawing.Imaging.PixelFormat.Format32bppPArgb);

            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.Paint += panel1_Paint;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, Point.Empty);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    Pen pen = new Pen(Color.Black, 20f);
                    pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                    g.DrawLine(pen, lastPoint, e.Location);
                }
                lastPoint = e.Location;
                panel1.Invalidate();
            }
        }
    }
}
