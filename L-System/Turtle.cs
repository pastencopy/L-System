using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace L_System
{
    class Turtle
    {
        public Vector2 dir;
        public Vector2 pos;

        private const int BRANCH_SIZE = 30;
        private const int LEAF_SIZE = 30;

        public Turtle(Vector2 pos, Vector2 dir)
        {
            this.pos = pos; //new Vector2(pos.X, pos.Y);
            this.dir = dir;// new Vector2(dir.X, dir.Y);

        }
        public void Forward(float rate)
        {
            Vector2 dv = Vector2.Normalize(dir);
            dv = Vector2.Multiply(BRANCH_SIZE * rate, dv);
            pos = Vector2.Add(pos, dv);
        }

        public Vector2 GetLeaf(float rate)
        {
            Vector2 dv = Vector2.Normalize(dir);
            dv = Vector2.Multiply(LEAF_SIZE * rate, dv);
            return  Vector2.Add(pos, dv);
        }
    }
}
