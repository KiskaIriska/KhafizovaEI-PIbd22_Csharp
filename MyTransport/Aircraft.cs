using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTransport
{
    public class Aircraft : FlyingObject
    {
        protected const int carWidth = 100;
        protected const int carHeight = 60;
        public Aircraft(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;

        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - carHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public override void DrawAircraft(Graphics g)
        {
            Brush br = new SolidBrush(MainColor);
            g.FillRectangle(br, _startPosX + 5, _startPosY + 25, 85, 10);
            g.FillEllipse(br, _startPosX, _startPosY + 25, 10, 10);
            g.FillEllipse(br, _startPosX + 85, _startPosY + 25, 10, 10);

            g.FillRectangle(br, _startPosX + 10, _startPosY + 15, 10, 30);
            g.FillEllipse(br, _startPosX + 10, _startPosY + 10, 10, 10);
            g.FillEllipse(br, _startPosX + 10, _startPosY + 40, 10, 10);

            g.FillRectangle(br, _startPosX + 60, _startPosY + 5, 15, 50);
            g.FillEllipse(br, _startPosX + 60, _startPosY, 15, 10);
            g.FillEllipse(br, _startPosX + 60, _startPosY + 50, 15, 10);

            g.FillRectangle(br, _startPosX + 50, _startPosY + 20, 25, 20);
            g.FillEllipse(br, _startPosX + 65, _startPosY + 20, 20, 20);
            g.FillEllipse(br, _startPosX + 40, _startPosY + 20, 20, 20);

            Brush br1 = new SolidBrush(Color.DarkCyan);
            g.FillEllipse(br1, _startPosX + 60, _startPosY + 25, 20, 10);
        }
    }
}
