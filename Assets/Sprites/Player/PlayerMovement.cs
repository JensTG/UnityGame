using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Funcs;

public class PlayerMovement : MonoBehaviour
{
    public float maxVel;
    public float inputWeight;
    public float friction;
    public Rigidbody2D rb;

    Vector2 accel;
    Vector2 vel;

    Vector2 moveInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Input:
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        // Movement:
        accel = MoveFuncs.CalculateAccel(friction, moveInput, accel);
        vel += accel;

        rb.MovePosition(vel * Time.fixedDeltaTime + rb.position);
    }
}
