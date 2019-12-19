using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTransport
{
    public class AttackAircraft : Aircraft
    {
        public Color DopColor { private set; get; }
        public bool Turbines { private set; get; }
        public bool Propeller { private set; get; }
        public bool Flag { private set; get; }

        public AttackAircraft(int maxSpeed, float weight, Color mainColor, Color dopColor, bool turbines,
            bool propeller, bool flag) :
            base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            Turbines = turbines;
            Propeller = propeller;
            Flag = flag;        
        }
        public override void DrawAircraft(Graphics g)
        {
            base.DrawAircraft(g);
            if (Propeller)
            {
                Brush br1 = new SolidBrush(DopColor);
                g.FillEllipse(br1, _startPosX + 93, _startPosY + 13, 5, 18);
                g.FillEllipse(br1, _startPosX + 93, _startPosY + 31, 5, 18);
                Brush br = new SolidBrush(Color.Black);
                g.FillEllipse(br, _startPosX + 90, _startPosY + 27, 10, 5);
            }

            if (Turbines)
            {
                Brush br2 = new SolidBrush(Color.DarkGray);
                g.FillRectangle(br2, _startPosX + 5, _startPosY + 15, 20, 5);
                g.FillRectangle(br2, _startPosX + 5, _startPosY + 40, 20, 5);
            }

            if (Flag)
            {
                Brush b = new SolidBrush(Color.Red);
                g.FillRectangle(b, _startPosX + 65, _startPosY + 10, 5, 5);
                g.FillRectangle(b, _startPosX + 65, _startPosY + 45, 5, 5);
            }

        }
    }
}
