using System;
using System.Drawing;
using System.Windows.Forms;

namespace IndependentStudyUnit6
{
    public partial class BouncingBallForm : Form
    {
        /// <summary>
        /// Global declaration of variables and initial attribution of values.
        /// </summary>
        private int x;
        private int y;
        private int xMove = 10;
        private int yMove = 10;
        private int ballSize = 30;
        Random random = new Random();

        /// <summary>
        /// The form initializes here.
        /// </summary>
        public BouncingBallForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method will be start the animation when the startButton
        /// is clicked.
        /// </summary>
        private void StartBouncing(object sender, EventArgs e)
        {
            ballPositionTimer.Start();
        }

        /// <summary>
        /// This method will close the form when the quitButton is clicked.
        /// </summary>
        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// This method will stop the animation when the stopButton is clicked.
        /// </summary>
        private void StopBouncing(object sender, EventArgs e)
        {
            ballPositionTimer.Stop();
        }

        /// <summary>
        /// This method will draw (in the pictureBox) a red ball and a blue ball,
        /// size 30, at the position set by x and y.
        /// </summary>
        private void displayPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            
            x = random.Next(1, 619);
            y = random.Next(1, 431);
            
            g.FillEllipse(Brushes.Red, x, y, ballSize, ballSize);

            x = random.Next(1, 619);
            y = random.Next(1, 431);

            g.FillEllipse(Brushes.Blue, x, y, ballSize, ballSize);
        }

        /// <summary>
        /// This method will change the position of the ball by increasing the value
        /// of x and y. By calling Refresh() the ball is drawn again at the new x, y
        /// position and it bounces when it reaches the edges of the pictureBox.
        /// </summary>
        private void ballPositionTimer_Tick(object sender, EventArgs e)
        {
            //add 10 to the x and y positions
            x += xMove;
            y += yMove;

            if (y + ballSize >= displayPictureBox.Height) //bottom edge
            {
                yMove = -yMove;
            }
            else if (x <= 0) //left edge
            {
                xMove = -xMove;
            }
            else if (x + ballSize >= displayPictureBox.Width) //right edge
            {
                xMove = -xMove;
            }
            else if (y <= 0) //top edge
            {
                yMove = -yMove;
            }

            Refresh();
        }

        /// <summary>
        /// This method will respond to the Up, Down and the 'C' keys.
        /// When the Up key is pressed the ball size increases by 10.
        /// When the Down key is pressed the ball size decreases by 10.
        /// When the 'C' key is pressed the BackColor of the picturebox is changed.
        /// </summary>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            const int TEN = 10;
            
            if (keyData == Keys.Up)
            {
                ballSize = ballSize + TEN;
                return true;
            }
            else if (keyData == Keys.Down)
            {
                ballSize = ballSize - TEN;
                return true;
            }
            else if (keyData == Keys.C)
            {
                displayPictureBox.BackColor = Color.GreenYellow;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}