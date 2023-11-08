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

            deg = Mathf.Rad2Deg * Mathf.Atan2(vec.y, vec.x) - 90;

            return deg;
        }
    }
}