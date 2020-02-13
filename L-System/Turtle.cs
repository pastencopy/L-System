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
        private int branch_size;
        private int leaf_size;

        public Vector2 dir;
        public Vector2 pos;

        public Turtle(Vector2 pos, Vector2 dir, int branch_size = 30, int leaf_size = 30)
        {
            this.pos = pos; //new Vector2(pos.X, pos.Y);
            this.dir = dir;// new Vector2(dir.X, dir.Y);
            this.branch_size = branch_size;
            this.leaf_size = leaf_size;

        }
        public void Forward(float rate)
        {
            Vector2 dv = Vector2.Normalize(dir);
            dv = Vector2.Multiply(branch_size * rate, dv);
            pos = Vector2.Add(pos, dv);
        }

        public Vector2 GetLeaf(float rate)
        {
            Vector2 dv = Vector2.Normalize(dir);
            dv = Vector2.Multiply(leaf_size * rate, dv);
            return  Vector2.Add(pos, dv);
        }
    }
}
