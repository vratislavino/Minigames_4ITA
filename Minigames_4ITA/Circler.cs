using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minigames_4ITA
{
    public partial class Circler : Minigame
    {
        private Random random = new Random();

        private Point currentCircle;
        private int size = 100;

        public Circler() {
            InitializeComponent();
        }

        public override void StartMinigame() {
            currentCircle = GenerateNewPoint();
        }

        private double PointDistance(Point a, Point b) {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }

        private Point GenerateNewPoint() {
            return new Point(random.Next(Width), random.Next(Height));
        }

        private void Circler_Paint(object sender, PaintEventArgs e) {
            e.Graphics.FillEllipse(Brushes.Blue, currentCircle.X - size/2, currentCircle.Y-size/2, size, size);
        }

        private void Circler_MouseClick(object sender, MouseEventArgs e) {
            var click = e.Location;
            if(PointDistance(click, currentCircle) < size / 2) {
                score++;
                currentCircle= GenerateNewPoint();
                size = 100;
            } else {
                EndMinigame();
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            size -= 1;
            if(size <= 0) {
                EndMinigame();
                timer1.Stop();
            }
            Refresh();
        }
    }
}
