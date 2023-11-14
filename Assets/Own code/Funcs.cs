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

    public static class MoveFuncs
    {
        public static Vector2 Accel(Vector2 v, float a, bool stopAtLow = false)
        {
            Vector2 newMove = v * a;
            if (stopAtLow && newMove.magnitude < 0.2f)
            {
                return new Vector2(0, 0);
            }
            return newMove;
        }
    }
}