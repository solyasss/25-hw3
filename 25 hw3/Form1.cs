using System;
using System.Drawing;
using System.Windows.Forms;

namespace hw
{
    public partial class Form1 : Form
    {
        private enum Direction
        {
            Right,
            Down,
            Left,
            Up
        }

        private Direction current = Direction.Right;
        private Rectangle screen_resize;
        private int speed = 5; 

        public Form1()
        {
            InitializeComponent();
            this.KeyDown += Form1_KeyDown;
            time_move.Tick += TimerMove_Tick;
            screen_resize = Screen.PrimaryScreen.WorkingArea;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Size = new Size(300, 300);
                this.Location = new Point(screen_resize.Left, screen_resize.Top);
                current = Direction.Right;
                time_move.Start();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                time_move.Stop();
            }
        }

        private void TimerMove_Tick(object sender, EventArgs e)
        {
            MoveFormAlongPerimeter();
        }
        private void MoveFormAlongPerimeter()
        {
            switch (current)
            {
                case Direction.Right:
                    if (this.Right + speed <= screen_resize.Right)
                        this.Left += speed;
                    else
                        current = Direction.Down;
                    break;

                case Direction.Down:
                    if (this.Bottom + speed <= screen_resize.Bottom)
                        this.Top += speed;
                    else
                        current = Direction.Left;
                    break;

                case Direction.Left:
                    if (this.Left - speed >= screen_resize.Left)
                        this.Left -= speed;
                    else
                        current = Direction.Up;
                    break;

                case Direction.Up:
                    if (this.Top - speed >= screen_resize.Top)
                        this.Top -= speed;
                    else
                        current = Direction.Right;
                    break;
            }
        }
    }
}
