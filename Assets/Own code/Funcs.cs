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
        public static Vector2 DecelDelta(float t1, float a, Vector2 v)
        {
            float t2 = t1 + Time.fixedDeltaTime + Time.fixedTime;
            float y = 0.5f * a * (t2 * t2 - t1 * t1) + v.y * (t2 - t1);
            float x = 0.5f * a * (t2 * t2 - t1 * t1) + v.x * (t2 - t1);
            Vector2 diff = new Vector2(x, y);
            if (x > 0.1f && y > 0.1f) return diff;
            else return new Vector2(0,0);
        }
    }
}