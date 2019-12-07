using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTransport
{
    public class AttackAircraft
    {
        private float _startPosX;
        private float _startPosY;
        private int _pictureWidth;
        private int _pictureHeight;
        private const int AttackAircraftWidth = 100;
        private const int AttackAircraftHeight = 60;

        public int MaxSpeed { private set; get; }
        public float Weight { private set; get; }
        public Color MainColor { private set; get; }
        public Color DopColor { private set; get; }
        public bool Turbines { private set; get; }
        public bool Propeller { private set; get; }

        public AttackAircraft(int maxSpeed, float weight, Color mainColor, Color dopColor,
           bool turbines, bool propeller)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Turbines = turbines;
            Propeller = propeller;

        }
      
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + 40 + step < 900)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - 50 - step > 0)

                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step - 10 > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step + 30 < _pictureHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public void DrawAttackAircraft(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush br = new SolidBrush(MainColor);
            g.FillRectangle(br, _startPosX - 50, _startPosY, 70, 10);
            g.FillRectangle(br, _startPosX, _startPosY - 20, 10, 50);
            g.FillEllipse(br, _startPosX + 15, _startPosY, 10, 10);
            g.FillRectangle(br, _startPosX - 45, _startPosY - 15, 10, 40);
            Brush br1 = new SolidBrush(DopColor);
            g.FillEllipse(br1, _startPosX - 10, _startPosY + 2, 25, 5);

            if (Propeller)
            {
                g.FillEllipse(br1, _startPosX + 25, _startPosY - 5, 5, 20);
            }

            if (Turbines)
            {
                Brush b = new SolidBrush(Color.DarkGray);
                g.FillRectangle(b, _startPosX - 50, _startPosY - 10, 20, 5);
                g.FillRectangle(b, _startPosX - 50, _startPosY + 15, 20, 5);
            }
        }
    }
}
