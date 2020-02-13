using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace L_System
{
    class FractalBinaryTree
    {
        private List<char> m_StringBuffer = new List<char>();

        public int ageOfTree = 0;
        public FractalBinaryTree()
        {
            m_StringBuffer.Add('0');
        }
        public void Draw(Graphics g, int x, int y)
        {            
            Stack<Turtle> stack = new Stack<Turtle>();
            g.TranslateTransform(x, y);

            Vector2 pos = new Vector2(0, 0);
            Turtle curr = new Turtle(pos, new Vector2(0, -1));

            // 8세대까지 그리는 비율 조절
            float rate = (17 - (ageOfTree*2)) / 17.0f;

            foreach (char c in m_StringBuffer)
            {
                if (c == '0')
                {
                    //잎사귀
                    pos = curr.GetLeaf(rate);
                    g.DrawLine(Pens.Black, curr.pos.X, curr.pos.Y, pos.X, pos.Y);
                }
                else if (c == '1')
                {
                    //가지
                    pos = curr.pos;
                    curr.Forward(rate);
                    g.DrawLine(Pens.Black, curr.pos.X, curr.pos.Y, pos.X, pos.Y);
                }
                else if (c == '[')
                {
                    //방향 왼쪽으로 변경 45도
                    Turtle t;
                    t = new Turtle(curr.pos, curr.dir);
                    stack.Push(t);
                    curr.dir = Vector2D.Rotate(curr.dir, 45);
                }
                else if (c == ']')
                {
                    //방향 오른쪽으로 변경 -45도
                    Vector2 old = curr.dir;
                    curr = stack.Pop();
                    curr.dir = Vector2D.Rotate(curr.dir, -45);
                }                
            }
        }

        public void Grow()
        {
            if (ageOfTree >= 8) return; //8세대이상부터는 자라지 않음

            List<char> newStringBuffer = new List<char>();

            foreach (char c in m_StringBuffer)
            {
                //규칙에 따라서 문자생성
                //
                //  1->11   ,   0 -> 1[0]0
                //
                if (c == '0')
                {
                    newStringBuffer.AddRange("1[0]0");
                }
                else if (c == '1')
                {
                    newStringBuffer.AddRange("11");
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
