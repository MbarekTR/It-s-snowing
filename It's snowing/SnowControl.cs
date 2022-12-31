using System;
using System.Drawing;
using System.Windows.Forms;

namespace It_s_snowing
{
    internal class SnowControl: PictureBox
    {
        public SnowControl()
        {
            CreateSnow();
            MoveSnow();
        }

        private readonly Random rSnow = new Random();

        private void CreateSnow()
        {
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.Location = new Point(rSnow.Next(-Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Width), rSnow.Next(-Screen.PrimaryScreen.Bounds.Height, Screen.PrimaryScreen.Bounds.Height));

            this.MinimumSize = new Size(7, 7);
            this.Size = new Size(10, 10);
            this.BackgroundImage = Properties.Resources.Kar;
        }

        private void MoveSnow()
        {
            Timer snowTimer = new Timer
            {
                Interval = 40
            };
            snowTimer.Tick += new EventHandler(SnowTimer_Tick);
            snowTimer.Start();
        }

        void SnowTimer_Tick(object sender, EventArgs e)
        {
            this.Location += new Size(1, 3);

            if (this.Location.X > Screen.PrimaryScreen.Bounds.Width || this.Location.Y > Screen.PrimaryScreen.Bounds.Height)
                this.Location = new Point(rSnow.Next(-Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Width), rSnow.Next(-Screen.PrimaryScreen.Bounds.Height, Screen.PrimaryScreen.Bounds.Height));
        }
    }
}
