using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Snake_IT3B
{
    class Snake
    {
       public List<PointF> Tail { get; set; }
        public PointF Head { get; set; }
        public double Speed { get; set; }
        public double Direction { get; set; }

        public Snake()
        {
            Head = new PointF();
            Tail = new List<PointF>();
        }

        public void Forward() 
        {
            Tail.Add(Head);
            var dx = Speed * Math.Cos(Direction);
            var dy = Speed * -Math.Sin(Direction);
            Head = new PointF(Convert.ToSingle(Tail[Tail.Count-1].X + dx),Convert.ToSingle(Tail[Tail.Count -1].Y + dy));
        }

        public void Left()
        {
            Direction += 0.3;
        }

        public void Right()
        {
            Direction += 0.3;
        }

        public List<PictureBox> GetPictureBoxes(Color color, int size)
        {
            List<PictureBox> pictureBoxes = new List<PictureBox>();
            var halfSize = size / 2F;
            foreach(var point in Tail)
            {
                pictureBoxes.Add(new PictureBox() {
                    Location = new Point(),
                    BackColor = color
                });
            }
            return pictureBoxes;
        }
    }
}
