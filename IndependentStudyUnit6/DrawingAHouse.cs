using System.Drawing;
using System.Windows.Forms;

namespace IndependentStudyUnit6
{
    public partial class DrawingAHouse : Form
    {
        /// <summary>
        /// Declaring new array.
        /// </summary>
        Point[] points =
        {
            new Point (50, 250),
            new Point (200, 100),
            new Point (350, 250)
        };

        /// <summary>
        /// The form initializes here.
        /// </summary>
        public DrawingAHouse()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method will draw and fill different polygons 
        /// forming the shape of a house with 2 windows, a door
        /// and a chimney. 
        /// </summary>
        private void DrawingAHouse_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black, 1);

            //roof
            g.DrawPolygon(myPen, points);
            g.FillPolygon(Brushes.Black, points);

            //chimney
            g.DrawRectangle(myPen, 300, 99, 50, 150);
            g.FillRectangle(Brushes.Black, 300, 100, 50, 150);

            //house body
            g.DrawRectangle(myPen, 50, 250, 300, 200);
            g.FillRectangle(Brushes.OrangeRed, 50, 250, 300, 200);

            //windows
            g.DrawRectangle(myPen, 100, 265, 50, 75);
            g.FillRectangle(Brushes.White, 100, 265, 50, 75);
            g.DrawRectangle(myPen, 250, 265, 50, 75);
            g.FillRectangle(Brushes.White, 250, 265, 50, 75);

            //door
            g.DrawRectangle(myPen, 175, 350, 50, 100);
            g.FillRectangle(Brushes.Wheat, 175, 350, 50, 100);

            //door handle
            g.DrawRectangle(myPen, 210, 410, 2, 2);
            g.FillRectangle(Brushes.Black, 210, 410, 2, 2);
            
            //clouds of smoke
            g.DrawEllipse(myPen, 350, 11, 90, 50);
            g.FillEllipse(Brushes.DarkGray, 350, 11, 90, 50);
            g.DrawEllipse(myPen, 315, 65, 45, 25);            
            g.FillEllipse(Brushes.DarkGray, 315, 65, 45, 25);
        }
    }
}