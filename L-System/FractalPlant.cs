using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace L_System
{
    class FractalPlant
    {
        private List<char> m_StringBuffer = new List<char>();

        public int ageOfTree = 0;
        public FractalPlant()
        {
            m_StringBuffer.Add('X');
        }
        public void Draw(Graphics g, int x, int y)
        {
            Stack<Turtle> stack = new Stack<Turtle>();
            g.TranslateTransform(x, y);

            Vector2 pos = new Vector2(0, 0);
            Turtle curr = new Turtle(pos, new Vector2(0.7f, -1));

            // 8세대까지 그리는 비율 조절
            float rate = 3.0f / ((ageOfTree * ageOfTree + 1));

            foreach (char c in m_StringBuffer)
            {
                if (c == 'X')
                {
                    //Nothing
                }
                else if (c == 'F')
                {
                    //가지
                    pos = curr.pos;
                    curr.Forward(rate);
                    g.DrawLine(Pens.Black, curr.pos.X, curr.pos.Y, pos.X, pos.Y);
                }
                else if (c == '-')
                {
                    curr.dir = Vector2D.Rotate(curr.dir, 25);
                }
                else if (c == '+')
                {
                    curr.dir = Vector2D.Rotate(curr.dir, -25);
                }
                else if (c == '[')
                {
                    Turtle t;
                    t = new Turtle(curr.pos, curr.dir, 50, 30);
                    stack.Push(t);
                }
                else if (c == ']')
                {
                    Vector2 old = curr.dir;
                    curr = stack.Pop();
                }
            }
        }

        public void Grow()
        {
            if (ageOfTree >= 7) return;

            List<char> newStringBuffer = new List<char>();

            foreach (char c in m_StringBuffer)
            {
                if (c == 'X')
                {
                    newStringBuffer.AddRange("F+[[X]-X]-F[-FX]+X");
                }
                else if (c == 'F')
                {
                    newStringBuffer.AddRange("FF");
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
