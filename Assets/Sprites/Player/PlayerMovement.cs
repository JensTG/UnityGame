using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Funcs;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public float deceleration;
    public Rigidbody2D rb;

    Vector2 movement;
    Vector2 lastMove;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Input:
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        // Movement:
        if (movement.magnitude >= 1)
        {
            Vector2 preMove = rb.position;
            rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.fixedDeltaTime);
            lastMove = rb.position - preMove;
        }
        else
        {
            Vector2 decelMove = lastMove;
            rb.MovePosition(rb.position + decelMove);
            lastMove = decelMove;
        }
    }
}
