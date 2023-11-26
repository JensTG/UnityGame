using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Funcs;

public class PlayerMovement : MonoBehaviour
{
    public float baseSpeed;
    public float friction;
    public Rigidbody2D rb;

    Vector2 vel;
    Vector2 moveInput;
    bool running;
    float speed;

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
        running = Input.GetKey(KeyCode.LeftShift);
    }

    private void FixedUpdate()
    {
        // Movement:
        if (moveInput.magnitude != 0) vel = moveInput.normalized;
        if (running) speed = baseSpeed * 2; else speed = baseSpeed;

        rb.MovePosition(vel * speed * Time.fixedDeltaTime + rb.position);
        vel /= friction;
    }
}
