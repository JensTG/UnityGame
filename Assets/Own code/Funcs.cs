using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Funcs
{
    public static class MathFuncs
    {
        public static float Vec2Deg(Vector2 vec)
        {
            float deg;

            if(vec.x == 0 &&  vec.y == 0) { return -1; }

            if(vec.x > 0)
            {
                if(vec.y > 0)
                {
                    deg = Mathf.Asin(vec.x);
                    return deg;
                }
                deg = 180 - Mathf.Asin(vec.x);
                return deg;
            }
            if(vec.y < 0)
            {
                deg = 180 + Mathf.Asin(-vec.x);
                return deg;
            }
            deg = 360 - Mathf.Asin(-vec.x);
            return deg;

        }
    }
}