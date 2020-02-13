using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace L_System
{
    class DragonCurve
    {
        private List<char> m_StringBuffer = new List<char>();

        public int ageOfTree = 0;
        public DragonCurve()
        {
            m_StringBuffer.AddRange("FX");
        }
        public void Draw(Graphics g, int x, int y)
        {
            g.TranslateTransform(x, y);

            Vector2 pos = new Vector2(0, 0);
            Turtle curr = new Turtle(pos, new Vector2(0, -1), 10, 10);

            // 8세대까지 그리는 비율 조절
            float rate = 1.0f;

            foreach (char c in m_StringBuffer)
            {
                if (c == 'X')
                {
                    //Nothing
                }
                else if (c == 'F')
                {
                    //Draw Forward
                    pos = curr.pos;
                    curr.Forward(rate);
                    g.DrawLine(Pens.Black, curr.pos.X, curr.pos.Y, pos.X, pos.Y);
                }
                else if (c == '-')
                {
                    curr.dir = Vector2D.Rotate(curr.dir, -90);
                }
                else if (c == '+')
                {
                    curr.dir = Vector2D.Rotate(curr.dir, 90);
                }
            }
        }

        public void Grow()
        {
            if (ageOfTree >= 10) return;

            List<char> newStringBuffer = new List<char>();

            foreach (char c in m_StringBuffer)
            {
                if (c == 'X')
                {
                    newStringBuffer.AddRange("X+YF+");
                }
                else if (c == 'Y')
                {
                    newStringBuffer.AddRange("-FX-Y");
                }
                else
                {
                    newStringBuffer.Add(c);
                }
            }

            ageOfTree++;
            m_StringBuffer = newStringBuffer;
        }
    }
}
