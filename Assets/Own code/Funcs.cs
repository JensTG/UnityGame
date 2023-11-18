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
        public static Vector2 CalculateAccel(float fric, Vector2 input, Vector2 accel)
        {
            if (accel.magnitude > 0.01f && input == Vector2.zero) {accel = accel / fric; return accel; }
            else if (input == Vector2.zero) {accel = new Vector2(0, 0); return accel; }

            accel = input;
            return accel;
        }
    }
}