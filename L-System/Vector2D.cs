using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace L_System
{
    class Vector2D
    {
        public static Vector2 Rotate(Vector2 v, int angle)
        {
            Vector2 result = new Vector2();

            double theta =  Math.PI * (angle / 180.0);

            /**
             *  [ cos  -sin ] [x]
             *  [ sin   cos ] [y]
             * */

            result.X = (float)(Math.Cos(theta) * v.X - Math.Sin(theta) * v.Y);
            result.Y = (float)(Math.Sin(theta) * v.X + Math.Cos(theta) * v.Y);

            return result;

        }
    }
}
