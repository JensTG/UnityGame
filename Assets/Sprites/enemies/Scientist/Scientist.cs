using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Funcs;

public class Scientist : MonoBehaviour
{
    public float speed = 1.0f;
    public Rigidbody2D sciBody;

    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.x = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        sciBody.MovePosition(sciBody.position * movement.normalized * speed * Time.fixedDeltaTime);
        //if (MathFuncs.Vec2Deg(movement) != -1) sciBody.MoveRotation(MathFuncs.Vec2Deg(movement));
    }
}
